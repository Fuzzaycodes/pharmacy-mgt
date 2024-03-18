Public Class Login
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox_Pass.Text = "123") Then
            Home.Show()
        Else
            MessageBox.Show("Incorrect Password")

        End If

    End Sub

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox_Pass.OnValueChanged

    End Sub
End Class