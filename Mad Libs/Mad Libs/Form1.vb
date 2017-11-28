Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String 'Holds selected list boxes

        If listColor.SelectedIndex = -1 Then
            ' No Color Selected
            MessageBox.Show("Select a Color.")

        ElseIf listEst.SelectedIndex = -1 Then
            ' No word ending in est
            MessageBox.Show("No word ending in est.")

        ElseIf listNumber.SelectedIndex = -1 Then
            ' No number was Selected
            MessageBox.Show("Select a Number.")

        ElseIf listBody.SelectedIndex = -1 Then
            ' No Body Part was Selected
            MessageBox.Show("Select a Body Part.")

        ElseIf listAnimal.SelectedIndex = -1 Then
            ' No Animal was Selected
            MessageBox.Show("Select an Animal.")

        ElseIf listNoun.SelectedIndex = -1 Then
            ' No Noun was Selected
            MessageBox.Show("Select a Noun.")

        ElseIf listPluralNoun.SelectedIndex = -1 Then
            ' No Plural Noun Selected
            MessageBox.Show("Select a Plural Noun.")

        End If
        ' Get the selected list from above to place into a message box
        strInput = listColor.SelectedItem.ToString() &
            " Dragon is the " & listEst.SelectedItem.ToString() &
            " Dragon of all. It has " & listNumber.SelectedItem.ToString() &
            " " & listBody.SelectedItem.ToString() & ", and a " &
            listAnimal.SelectedItem.ToString() & " shaped like a " &
            listNoun.SelectedItem.ToString() & ". It loves to eat " &
            listPluralNoun.SelectedItem.ToString()
        MessageBox.Show("The " & strInput & ", although it will feast on nearly anything.")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listColor.SelectedIndex = -1
        listEst.SelectedIndex = -1
        listNumber.SelectedIndex = -1
        listBody.SelectedIndex = -1
        listAnimal.SelectedIndex = -1
        listNoun.SelectedIndex = -1
        listPluralNoun.SelectedIndex = -1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
