Public Class Calculator

    Dim total1 As Single
    Dim total2 As Single
    Dim plusOperator As Boolean = False
    Dim minusOperator As Boolean = False
    Dim multiplyOperator As Boolean = False
    Dim divideOperator As Boolean = False

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click

        txtDisplay.Text = txtDisplay.Text & btnZero.Text

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click

        txtDisplay.Text = txtDisplay.Text & btnOne.Text

    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click

        txtDisplay.Text = txtDisplay.Text & btnTwo.Text

    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click

        txtDisplay.Text = txtDisplay.Text & btnThree.Text

    End Sub

    Private Sub btnfour_Click(sender As Object, e As EventArgs) Handles btnfour.Click

        txtDisplay.Text = txtDisplay.Text & btnfour.Text

    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click

        txtDisplay.Text = txtDisplay.Text & btnFive.Text

    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click

        txtDisplay.Text = txtDisplay.Text & btnSix.Text

    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click

        txtDisplay.Text = txtDisplay.Text & btnSeven.Text

    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click

        txtDisplay.Text = txtDisplay.Text & btnEight.Text

    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click

        txtDisplay.Text = txtDisplay.Text & btnNine.Text

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtDisplay.Clear()

    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click

        total1 += Val(txtDisplay.Text)
        plusOperator = True
        txtDisplay.Clear()

    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click

        total1 += Val(txtDisplay.Text)
        minusOperator = True
        txtDisplay.Clear()

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click

        total1 += Val(txtDisplay.Text)
        multiplyOperator = True
        txtDisplay.Clear()

    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click

        total1 += Val(txtDisplay.Text)
        divideOperator = True
        txtDisplay.Clear()

    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click

        If plusOperator = True Then

            total2 = total1 + Val(txtDisplay.Text)

            txtDisplay.Text = total2

            total1 = 0

        ElseIf minusOperator = True Then

            total2 = total1 - Val(txtDisplay.Text)

            txtDisplay.Text = total2

            total1 = 0

        ElseIf multiplyOperator = True Then

            total2 = total1 * Val(txtDisplay.Text)

            txtDisplay.Text = total2

            total1 = 0

        ElseIf divideOperator = True Then

            total2 = total1 / Val(txtDisplay.Text)

            txtDisplay.Text = total2

            total1 = 0

        End If

    End Sub
End Class
