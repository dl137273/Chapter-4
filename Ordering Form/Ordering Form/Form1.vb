Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFinishOrder.Click
        Dim dblHamburger As Double = 5.99
        Dim dblChicken As Double = 6.99
        Dim dblSteak As Double = 8.99
        Dim dblRoastBeef As Double = 4.99
        Dim dblCheese As Double = 0.5
        Dim dblBBQ As Double = 0.25
        Dim dblOnions As Double = 0.5
        Dim dblMushrooms As Double = 0.5
        Dim dblFries As Double = 2.99
        Dim dblOnionRings As Double = 3.99
        Dim dblSalad As Double = 1.99
        Dim dblTotal As Double

        If rdHamburger.Checked = True Then
            lblFinalMeal.Text = "You selected Hamburger"
            dblTotal = dblHamburger + dblTotal
        ElseIf rdChicken.Checked = True Then
            lblFinalMeal.Text = "You selected Chicken Sandwhich"
            dblTotal = dblChicken + dblTotal
        ElseIf rdSteak.Checked = True Then
            lblFinalMeal.Text = "You selected Steak Sandwich"
            dblTotal = dblSteak + dblTotal
        ElseIf rdRoastBeef.Checked = True Then
            lblFinalMeal.Text = "You selected Roast Beef Sandwhich"
            dblTotal = dblRoastBeef + dblTotal
        End If

        If cbCheese.Checked = True Then
            lblFinalMeal.Text &= " with Cheese"
            dblTotal = dblCheese + dblTotal
        End If
        If cbBBQ.Checked = True Then
            lblFinalMeal.Text &= ", BBQ Sauce"
            dblTotal = dblBBQ + dblTotal
        End If
        If cbOnions.Checked = True Then
            lblFinalMeal.Text &= ", Onions"
            dblTotal = dblOnions + dblTotal
        End If
        If cbMushrooms.Checked = True Then
            lblFinalMeal.Text &= ", Mushrooms"
            dblTotal = dblMushrooms + dblTotal
        End If

        If rdFries.Checked = True Then
            lblFinalMeal.Text &= " and a side of Fries"
            dblTotal = dblFries + dblTotal
        ElseIf rdOnionRings.Checked = True Then
            lblFinalMeal.Text &= " and a side of Onion Rings"
            dblTotal = dblOnionRings + dblTotal
        ElseIf rdSalad.Checked = True Then
            lblFinalMeal.Text &= " and a side Salad"
            dblTotal = dblSalad + dblTotal
        End If

        lblTotal.Text = dblTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
