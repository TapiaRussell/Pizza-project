Option Explicit On
Option Strict On
Option Infer Off

Public Class PizzaOrder
    Dim pizza As Decimal
    Dim meatToppings As Decimal = 0.00D
    Dim otherToppings As Decimal = 0.00D
    Dim total As Decimal
    Dim pepperoni As Decimal = 0.4D
    Dim sausage As Decimal = 0.4D
    Dim bacon As Decimal = 0.4D
    Dim ham As Decimal = 0.4D
    Dim cheese As Decimal = 0.4D
    Dim mushroom As Decimal = 0.3D
    Dim bellPepper As Decimal = 0.3D
    Dim onion As Decimal = 0.3D




    Private Sub btbExit_Click(sender As Object, e As EventArgs) Handles btbExit.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If rdbSmall.Checked Then
            pizza = 10.99D
        ElseIf rdbMidium.Checked Then
            pizza = 11.99D
        ElseIf rdbLarge.Checked Then
            pizza = 12.99D
        End If

        Select Case True
            Case ckbPepperoni.Checked
                meatToppings = meatToppings + pepperoni
            Case ckbSausage.Checked
                meatToppings = meatToppings + sausage

        End Select
    End Sub
End Class
