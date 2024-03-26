Imports MySql.Data.MySqlClient

Public Class Home
    Dim con As New MySqlConnection("host=127.0.0.1; user=savo; password=#g0langr0ckx; database=warehouse_africa")

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServices()
    End Sub
    Private Sub NavBarServices_Click(sender As Object, e As EventArgs) Handles NavBarServices.Click
        'LoadServices()
    End Sub

    Private Sub NavBarBook_Click(sender As Object, e As EventArgs) Handles NavBarBook.Click
        LoadBookings()
    End Sub

    Sub LoadServices()
        Try
            Dim query As String = "SELECT * FROM services"
            Dim cmd As New MySqlCommand(query, con)

            'open mysql connnection
            con.Open()

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                HomeServicesView1.Rows.Add(reader("id"), reader("store_item"), reader("price"), reader("site"))

            End While

            'close mysql connection
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Sub LoadBookings()
        '' Load records of customers
        HomeBody.Controls.Clear()
        Dim bookingForm As New BookingForm()
        HomeBody.Controls.Add(bookingForm)

    End Sub


    Private Sub NavBarAdmin_Click(sender As Object, e As EventArgs) Handles NavBarAdmin.Click
        Dim loginForm As New Login
        HomeBody.Controls.Clear()
        HomeBody.Controls.Add(loginForm)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class