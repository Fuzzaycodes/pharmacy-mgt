Imports System.Data.SqlClient
Public Class Billing
    Dim number1 As Integer
    Dim number2 As Integer
    Dim answer As Integer




    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yegod\Documents\Phanadydb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FillCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from BillTbl", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        MedComboCb.DataSource = Tbl
        MedComboCb.DisplayMember = "MedName"
        MedComboCb.ValueMember = "MedName"

        Con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MedComboCb.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Decimal
        Dim num2 As Decimal
        If Decimal.TryParse(Qtty.Text, num1) AndAlso Decimal.TryParse(Unitprice.Text, num2) Then
            ' Perform multiplication
            Dim result As Decimal = num1 * num2
            ' Display the result in the answer textbox
            total.Text = result.ToString()
        Else
            MessageBox.Show("Please enter valid numeric values in both textboxes.")
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles total.TextChanged

    End Sub

    Private Sub Qtty_TextChanged(sender As Object, e As EventArgs) Handles Qtty.TextChanged

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.BunifuView.Rows.Add(MedComboCb.Text, Qtty.Text, Unitprice.Text, total.Text)
        MsgBox("Data updated successfuly")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub
End Class