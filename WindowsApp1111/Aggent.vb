Public Class Aggent
    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AgentGv.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.AgentGv.Rows.Add(ManuNameTba.Text, ManuAddresTba.Text, CountyTba.Text, stockCba.Text)
        MsgBox("Data Successfuly Added to Form")
    End Sub
End Class