Public Class Form1
    Const dblPointSeven As Double = 0.7
    Const dblTwo As Double = 2
    Const dblTwoPointFive As Double = 2.5
    Const dblEightFive As Double = 0.85
    Const dblSixFive As Double = 0.65
    Const dblEight As Double = 0.8

    Private Sub ItemTypeGroupBox_Enter(sender As Object, e As EventArgs) Handles ItemTypeGroupBox.Enter

    End Sub

    'handles math for buttons that require division by .7
    Private Sub Point_Seven(sender As Object, e As EventArgs) Handles btnPetFood.Click, btnLitter.Click
        'creates a variable to hold the text after it is converted to a double
        Dim dblCost As Double
        Double.TryParse(txtCost.Text, dblCost)
        'calculates the cost of the given product, converts back to a string and assigns 
        'value to the price label with currency formatting
        lblPrice.Text = (dblCost / dblPointSeven).ToString("C")
    End Sub

    'handles math for buttons that require division by .85
    Private Sub Point_Eight_Five(sender As Object, e As EventArgs) Handles btnHorseFeed.Click, btnGroceryPointFive.Click
        'creates a variable to hold the text after it is converted to a double
        Dim dblCost As Double
        Double.TryParse(txtCost.Text, dblCost)
        'calculates the cost of the given product, converts back to a string and assigns 
        'value to the price label with currency formatting
        lblPrice.Text = (dblCost / dblEightFive).ToString("C")
    End Sub

    'handles math for buttons that require division by .65
    Private Sub Point_Six_Five(sender As Object, e As EventArgs) Handles btnSixFivePetFood.Click
        'creates a variable to hold the text after it is converted to a double
        Dim dblCost As Double
        Double.TryParse(txtCost.Text, dblCost)
        'calculates the cost of the given product, converts back to a string and assigns 
        'value to the price label with currency formatting
        lblPrice.Text = (dblCost / dblSixFive).ToString("C")
    End Sub

    'handles math for buttons that require division by .8
    Private Sub Point_Eight(sender As Object, e As EventArgs) Handles btnGrocery.Click
        'creates a variable to hold the text after it is converted to a double
        Dim dblCost As Double
        Double.TryParse(txtCost.Text, dblCost)
        'calculates the cost of the given product, converts back to a string and assigns 
        'value to the price label with currency formatting
        lblPrice.Text = (dblCost / dblEight).ToString("C")
    End Sub

    'handles math for buttons that requires multiplication by 2
    Private Sub Two(sender As Object, e As EventArgs) Handles btnTreatsToys.Click
        'creates a variable to hold the text after it is converted to a double
        Dim dblCost As Double
        Double.TryParse(txtCost.Text, dblCost)
        'calculates the cost of the given product, converts back to a string and assigns 
        'value to the price label with currency formatting
        lblPrice.Text = (dblCost * dblTwo).ToString("C")
    End Sub

    'handles math for buttons that requires multiplication by 2.5
    Private Sub Two_Point_Five(sender As Object, e As EventArgs) Handles btnToyPointFive.Click
        'creates a variable to hold the text after it is converted to a double
        Dim dblCost As Double
        Double.TryParse(txtCost.Text, dblCost)
        'calculates the cost of the given product, converts back to a string and assigns 
        'value to the price label with currency formatting
        lblPrice.Text = (dblCost * dblTwoPointFive).ToString("C")
    End Sub

    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged
        'clears the label when the text changes
        lblPrice.Text = String.Empty
    End Sub



End Class
