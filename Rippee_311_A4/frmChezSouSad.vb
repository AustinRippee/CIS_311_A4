'------------------------------------------------------------
'-                File Name : frmChezSouSad.frm                     - 
'-                Part of Project: Main                  -
'------------------------------------------------------------
'-                Written By: Austin Rippee                     -
'-                Written On: February 15, 2022         -
'------------------------------------------------------------
'- File Purpose:                                            -
'- The user will be prompted with a selection of a dish, then
'- based on that, they will be prompted with prepped items, then
'- based on that, prompted with raw ingredients made. This will
'- ultimately lead to creating their own dish.
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows for the user to create their own dish
'- filled with prepped items that are made from raw materials
'- that are listed within.
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- gdicDishes - Creates dictionary for all dishes made from the prepped items
'- gdicPreppedItems - Creates dictionary for all prepped items made from from the raw items
'- gdicRawItems - Creates dictionary for all raw items
'- gDicTempDishes - 'Creates a temporary dictionary to store the dishes
'- gDicTempPrepItems - 'Creates a temporary dictionary to store the prepped items
'- gDicTempRawItems - 'Creates a temporary dictionary to store the selected values
'------------------------------------------------------------
Public Class frmChezSouSad

    'Creates dictionary for all raw items
    Public gdicRawItems As New Dictionary(Of String, String)
    'Creates dictionary for all prepped items made from from the raw items
    Public gdicPreppedItems As New Dictionary(Of String, Dictionary(Of String, String))
    'Creates dictionary for all dishes made from the prepped items
    Public gdicDishes As New Dictionary(Of String, Dictionary(Of String, Dictionary(Of String, String)))

    'Creates a temporary dictionary to store the selected values
    Public gDicTempRawItems As New Dictionary(Of String, String)
    'Creates a temporary dictionary to store the prepped items
    Public gDicTempPrepItems As New Dictionary(Of String, Dictionary(Of String, String))
    'Creates a temporary dictionary to store the dishes
    Public gDicTempDishes As New Dictionary(Of String, Dictionary(Of String, Dictionary(Of String, String)))

    '------------------------------------------------------------
    '-                Subprogram Name: frm_Load           -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: February 15th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user loads the
    '– form. Items will be automatically added to the various
    '- list boxes of dishes, prepped items, and raw ingredients.
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load all raw items into the dictionary
        gdicRawItems.Add("basket", "basket")
        gdicRawItems.Add("beef patty", "beef patty")
        gdicRawItems.Add("bun", "bun")
        gdicRawItems.Add("chicken", "chicken")
        gdicRawItems.Add("glass", "glass")
        gdicRawItems.Add("grapes", "grapes")
        gdicRawItems.Add("ketchup", "ketchup")
        gdicRawItems.Add("mayonaise", "mayonaise")
        gdicRawItems.Add("mustard", "mustard")
        gdicRawItems.Add("oil", "oil")
        gdicRawItems.Add("onions", "onions")
        gdicRawItems.Add("pickles", "pickles")
        gdicRawItems.Add("plate", "plate")
        gdicRawItems.Add("sugar", "sugar")
        gdicRawItems.Add("syrup", "syrup")
        gdicRawItems.Add("water", "water")
        'Load all raw items into each prepped item
        gdicPreppedItems.Add("chicken salad", gdicRawItems)
        gdicPreppedItems.Add("fries", gdicRawItems)
        gdicPreppedItems.Add("hamburger", gdicRawItems)
        gdicPreppedItems.Add("soft drink", gdicRawItems)
        'Load all prepped items into each dish
        gdicDishes.Add("hamburger platter", gdicPreppedItems)
        gdicDishes.Add("chicken salad platter", gdicPreppedItems)

        'Add all raw items from the dictionary to the list box
        For Each rawKey In gdicRawItems.Keys
            lstRaw.Items.Add(gdicRawItems.Item(rawKey))
        Next
        'Add all prepped items from the dictionary to the list box
        For Each rawingredient In gdicPreppedItems.Keys
            lstPrep.Items.Add(rawingredient)
        Next
        'Add all dishes from the dictionary to the list box
        For Each dish In gdicDishes.Keys
            lstDish.Items.Add(dish)
        Next

        'For Each item In gdicDishes(lstDish.Text)
        '    lstPreppedSelected.Items.Add(item.Key)
        'Next

        'If lstDish.SelectedItem = "Hamburger Platter" Then
        '    For Each prepItem In tempItems.Keys
        '        lstRawSelected.Items.Add(prepItem)
        '    Next
        'End If

    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnAddRaw_Click            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: February 15th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- AddRaw button. This sub adds a new raw ingredient to the
    '– list but will not be added twice and won't be added if
    '- nothing has been added to the text box.
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnAddRaw_Click(sender As Object, e As EventArgs) Handles btnAddRaw.Click
        'Checks if nothing has been entered
        If txtRaw.Text = "" Then
            MsgBox("No value entered, try again")
        Else
            'Checks if the key is already entered
            If gdicRawItems.ContainsKey(txtRaw.Text) Then
                MsgBox("Item already added, try something else")
            Else
                'adds to the dictionary
                gdicRawItems.Add(txtRaw.Text, txtRaw.Text)
                'adds to the listbox
                lstRaw.Items.Add(txtRaw.Text)
                'sorts the listbox
                lstRaw.Sorted = True
                'sets the textbox to contain nothing
                txtRaw.Text = ""
            End If
        End If
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnAddPrep_Click            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: February 15th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- AddPrep button. This sub adds a new prepped item to the
    '– list but will not be added twice and won't be added if
    '- nothing has been added to the text box.                                       –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnAddPrep_Click(sender As Object, e As EventArgs) Handles btnAddPrep.Click
        'Checks if nothing has been entered
        If txtPrep.Text = "" Then
            MsgBox("No value entered, try again")
        Else
            'Checks if the key is already entered
            If gdicPreppedItems.ContainsKey(txtPrep.Text) Then
                MsgBox("Item already added, try something else")
            Else
                Try
                    'adds to dictionary
                    gdicPreppedItems.Add(txtPrep.Text, gdicRawItems)
                Catch
                    MsgBox(Err.ToString)
                End Try
                'adds to list box
                lstPrep.Items.Add(txtPrep.Text)
                'sorts list box
                lstPrep.Sorted = True
                'sets text to nothing in textbox
                txtPrep.Text = ""
            End If
        End If
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnAddDish_Click            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                    -
    '-                Written On: February 15th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- AddDish button. This sub adds a new dish to the list but
    '- will not be added twice and won't be added if nothing has
    '- been added to the text box.                                        –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnAddDish_Click(sender As Object, e As EventArgs) Handles btnAddDish.Click
        'Checks if nothing has been entered
        If txtDish.Text = "" Then
            MsgBox("No value entered, try again")
        Else
            'Checks if item is already entered
            If gdicDishes.ContainsKey(txtDish.Text) Then
                MsgBox("Item already added, try something else")
            Else
                Try
                    'adds to dictionary
                    gdicDishes.Add(txtDish.Text, gdicPreppedItems)
                Catch
                    MsgBox(Err.ToString)
                End Try
                'adds to listbox
                lstDish.Items.Add(txtDish.Text)
                'sorts list box
                lstDish.Sorted = True
                'sets text to nothing in textbox
                txtDish.Text = ""
            End If
        End If
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnLeftRaw_Click            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: February 15th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- LeftRaw button. This adds the selected item from the
    '- raw ingrediants list to the selected raw ingredients.
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnLeftRaw_Click(sender As Object, e As EventArgs) Handles btnLeftRaw.Click
        'Checks if nothing is selected
        If lstRaw.SelectedIndex = -1 Then
            MsgBox("Nothing Selected, try again")
        Else
            'adds to dictionary and listbox
            If gDicTempRawItems.ContainsKey(txtRaw.Text) Then
                MsgBox("Item already added, try something else")
            Else
                lstRaw.Text = lstRawSelected.Items.Add(lstRaw.Text)
                gDicTempRawItems.Add(txtRaw.Text, txtRaw.Text)
            End If

        End If
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnRightRaw_Click            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: February 15th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- RightRaw button. This removes the raw ingredient from the
    '- selected raw ingrediants. –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnRightRaw_Click(sender As Object, e As EventArgs) Handles btnRightRaw.Click
        'Checks if nothing is selected
        If lstRawSelected.SelectedIndex = -1 Then
            MsgBox("Nothing Selected, try again")
        Else
            'removes from dictionary and listbox
            gDicTempRawItems.Remove(txtRaw.Text, txtRaw.Text)
            lstRawSelected.Items.Remove(lstRawSelected.Text)
        End If
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnLeftPrep_Click            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: February 15th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- LeftPrep button. This adds the selected item from the
    '- prepped items list to the selected prepped items.                                       –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnLeftPrep_Click(sender As Object, e As EventArgs) Handles btnLeftPrep.Click
        'Checks if nothing is selected
        If lstPrep.SelectedIndex = -1 Then
            MsgBox("Nothing Selected, try again")
        Else
            'adds to dictionary and listbox
            If gDicTempPrepItems.ContainsKey(txtPrep.Text) Then
                MsgBox("Item already added, try something else")
            Else
                lstPreppedSelected.Items.Add(lstPrep.Text)
                gDicTempPrepItems.Add(lstPrep.Text, gDicTempRawItems) 'Not sure why I am getting an error for this line
            End If

        End If
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnRightPrep_Click            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: February 15th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- RightPrep button. This removes the prepped item from the
    '- selected prepped items.                                        –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnRightPrep_Click(sender As Object, e As EventArgs) Handles btnRightPrep.Click
        'Checks if nothing is selected
        If lstPreppedSelected.SelectedIndex = -1 Then
            MsgBox("Nothing Selected, try again")
        Else
            'removes from dictionary and listbox
            gDicTempPrepItems.Remove(txtRaw.Text, gDicTempRawItems)
            lstPreppedSelected.Items.Remove(lstPreppedSelected.Text)
        End If
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: txtPrep_LostFocus            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: February 15th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks away
    '- from a text box and changes all letters to lowercase.
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtPrep_LostFocus(sender As Object, e As EventArgs) Handles txtPrep.LostFocus
        'sets text to lowercase
        txtPrep.Text = LCase(txtPrep.Text)
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: txtRaw_LostFocus            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                    -
    '-                Written On: February 15th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks away
    '- from a text box and changes all letters to lowercase.                                         –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtRaw_LostFocus(sender As Object, e As EventArgs) Handles txtRaw.LostFocus
        'sets text to lowercase
        txtRaw.Text = LCase(txtRaw.Text)
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: txtDish_LostFocus            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: February 15th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks away
    '- from a text box and changes all letters to lowercase.                                        –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtDish_LostFocus(sender As Object, e As EventArgs) Handles txtDish.LostFocus
        'sets text to lowercase
        txtDish.Text = LCase(txtDish.Text)
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: lstDish_SelectedIndexChanged            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: February 15th, 2022        -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks upon a
    '- different index of the lstDish. –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub lstDish_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDish.SelectedIndexChanged
        '==============================================================================================
        ' Here is where I had the most trouble and really couldn't figure it out. I know that when I
        ' selected between the different items, that each one should be contained within its own temp
        ' dictionary in which holds those prepped items and the raw materials inside of each dish.
        ' For some reason, I couldn't get the syntax down to be able to check for or add specific 
        ' values to the specific dishes and this cost me.
        '==============================================================================================

        'Clears the listbox
        lstPreppedSelected.Items.Clear()

        'Checks for hamburger platter and adds the prepped items
        If lstDish.Text = "hamburger platter" Then
            'Dim tempPrepItems As New Dictionary(Of String, Dictionary(Of String, String))
            lstPreppedSelected.Items.Clear()
            gDicTempPrepItems.Add("soft drink", gDicTempRawItems)
            gDicTempPrepItems.Add("hamburger", gDicTempRawItems)
            gDicTempPrepItems.Add("fries", gDicTempRawItems)
            If lstPreppedSelected.Text = "soft drink" Then
                'Dim tempRawItems As New Dictionary(Of String, String)
                gDicTempRawItems.Add("sugar", "sugar")
                gDicTempRawItems.Add("water", "water")
                gDicTempRawItems.Add("glass", "glass")
                gDicTempRawItems.Add("syrup", "syrup")
            ElseIf lstPreppedSelected.Text = "hamburger" Then
                'Dim tempRawItems As New Dictionary(Of String, String)
                gDicTempRawItems.Add("beef patty", "beef patty")
                gDicTempRawItems.Add("ketchup", "ketchup")
                gDicTempRawItems.Add("mayonaise", "mayonaise")
                gDicTempRawItems.Add("mustard", "mustard")
                gDicTempRawItems.Add("onions", "onions")
                gDicTempRawItems.Add("pickles", "pickles")
            ElseIf lstPreppedSelected.Text = "fries" Then
                'Dim tempRawItems As New Dictionary(Of String, String)
                gDicTempRawItems.Add("oil", "oil")
                gDicTempRawItems.Add("ketchup", "ketchup")
                gDicTempRawItems.Add("basket", "basket")
            End If
        End If

        'Checks for chicken salad platter and adds the prepped items
        If lstDish.Text = "chicken salad platter" Then
            'Dim tempPrepItems As New Dictionary(Of String, Dictionary(Of String, String))
            lstPreppedSelected.Items.Clear()
            gDicTempPrepItems.Add("soft drink", gDicTempRawItems)
            gDicTempPrepItems.Add("chicken salad", gDicTempRawItems)
            If lstPreppedSelected.Text = "soft drink" Then
                'Dim tempRawItems As New Dictionary(Of String, String)
                gDicTempRawItems.Add("sugar", "sugar")
                gDicTempRawItems.Add("water", "water")
                gDicTempRawItems.Add("glass", "glass")
                gDicTempRawItems.Add("syrup", "syrup")
            ElseIf lstPreppedSelected.Text = "chicken salad" Then
                'Dim tempRawItems As New Dictionary(Of String, String)
                gDicTempRawItems.Add("plate", "plate")
                gDicTempRawItems.Add("chicken", "chicken")
            End If
        End If

        'Checks if the key is not already in the list of dishes
        If Not gDicTempDishes.ContainsKey(lstDish.SelectedItem) Then
            'adds dish to the dictionary
            gDicTempDishes.Add(lstDish.SelectedItem, gDicTempPrepItems)
        End If
        'For Each item In tempPrepItems.Keys
        '    lstPreppedSelected.Items.Add(item)
        'Next
        'iterates through the dishes and adds in each prepped item to the listbox
        For Each item In gDicTempDishes(lstDish.SelectedItem)
            lstPreppedSelected.Items.Add(item.Key)
        Next
        'iterates through the prepped items and adds in each raw ingredient to the listbox
        'For Each item In tempPrepItems(lstPrep.SelectedItem)
        '    lstRawSelected.Items.Add(item.Key) ' this code DOES NOT work but is the same idea as above. Not sure how to implement it
        'Next

    End Sub

End Class
