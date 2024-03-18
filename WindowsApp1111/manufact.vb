Public Class manufact
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub manufact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.ManuGV.Rows.Add(ManuNameTb.Text, ManuAddresTb.Text, CountyTb.Text, stockCb.Text)
        MsgBox("Data Successfuly Added to Form")
    End Sub

    Private Sub ManuNameTb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ManuNameTb.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class

