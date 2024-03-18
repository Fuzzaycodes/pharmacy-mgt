Imports System.Data.SqlClient
Public Class Med
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yegod\Documents\Phanadydb.mdf;Integrated Security=True;Connect Timeout=30")

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from Medic"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        MedicinGV.DataSource = ds.Tables()
        Con.Close()

    End Sub
    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub
    Private Sub ExpDate_ValueChanged(sender As Object, e As EventArgs) Handles dt.ValueChanged

    End Sub

    Private Sub SpriceTb_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.MedicinGV.Rows.Add(md.Text, bp.Text, sp.Text, qt.Text, dt.Text)
        MsgBox("Data updated successfuly")
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub

    Private Sub md_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) 

    End Sub
End Class






