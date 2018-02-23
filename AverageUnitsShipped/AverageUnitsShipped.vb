
Public Class AverageUnitsShipped

    ''' <summary>
    ''' Author: Sara Bhatti
    ''' Project: Lab 1 - Average Units Shipped
    ''' Date: February 6, 2018
    ''' Description: The purpose of this windows application is
    ''' to calculate the average units shipped per week based
    ''' on the user input. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub AverageUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Const minimumArraySize As Integer = 1


        Dim userInput As Integer                    ' holds user input for calculation
        Dim days(0 To 7) As String
        Dim output As String = String.Empty        ' holds the output

        Dim array() As Integer





        If Not IsNumeric(txtInputDisplay.Text) Then
            MessageBox.Show("Please enter a numeric value.")

            ' Check to see if input is numeric and will display error message box

            txtInputDisplay.Select()
            txtInputDisplay.SelectionStart = 0
            txtInputDisplay.SelectionLength = Len(txtInputDisplay.Text)

            ' If input is not numeric the focus will be set back on the textbox with the value 
            ' highlighted so the user can easily enter the correct value

        ElseIf Not Integer.TryParse(txtInputDisplay.Text, userInput) Then
            MessageBox.Show("Please only enter a whole number.")

            ' Check to see if input is a whole number and will display error message box

            txtInputDisplay.Select()
            txtInputDisplay.SelectionStart = 0
            txtInputDisplay.SelectionLength = Len(txtInputDisplay.Text)

            ' If input is not a whole number the focus will be set 
            ' back on the textbox with the value 
            ' highlighted so the user can easily enter the correct value

        ElseIf txtInputDisplay.Text > 1000 Then
            MessageBox.Show("Please enter a number that is equal to or less than 1000.")

            ' if number is not within the 0 to 1000 range error message will show

            txtInputDisplay.Select()
            txtInputDisplay.SelectionStart = 0
            txtInputDisplay.SelectionLength = Len(txtInputDisplay.Text)

            ' If input is not between the range the focus will be set 
            ' back on the textbox with the value 
            ' highlighted so the user can easily enter the correct value

        ElseIf txtInputDisplay.Text < 0 Then
            MessageBox.Show("Please enter a number that is equal to or greater than 0.")

            ' if number is notwithin the 0 to 1000 range error message will show

            txtInputDisplay.Select()
            txtInputDisplay.SelectionStart = 0
            txtInputDisplay.SelectionLength = Len(txtInputDisplay.Text)


            ' If input is not between the range the focus will be set 
            ' back on the textbox with the value 
            ' highlighted so the user can easily enter the correct value





        End If


        days(1) = "Day 1:"

        lblDisplayForUnitsShipped.Text = txtInputDisplay.Text

        days(2) = "Day 2"
        days(3) = "Day 3"
        days(4) = "Day 4"
        days(5) = "Day 5"
        days(6) = "Day 6"
        days(7) = "Day 7"


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtInputDisplay.Text = ""
        lblAveragePerDay.Text = ""
        lblDisplayForUnitsShipped.Text = ""
        txtInputDisplay.Select()

        ' clears all values from textbox, label for average days,
        ' label for list of units shipped per day, and resets days 
        ' back to Day 1

    End Sub
End Class
