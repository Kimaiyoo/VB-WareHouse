Imports MySql.Data.MySqlClient

Public Class Login
    Dim con As New MySqlConnection("host=127.0.0.1; user=savo; password=#g0langr0ckx; database=warehouse_africa")
    Private Sub LoginSubmitLabel3_Click(sender As Object, e As EventArgs) Handles LoginSubmitLabel3.Click
        Dim name As String = LoginNameTB1.Text
        Dim password As String = LoginPassTB2.Text
        Dim isAdmin As Boolean = LoginMiddleware(name, password)

        If isAdmin Then
            Dim adminPage As New Admin
            Dim homepage As New Home
            adminPage.Show()
            Home.Hide()
        Else
            MessageBox.Show("You MUST be an admin to access the admin page")
            LoginNameTB1.Text = String.Empty
            LoginPassTB2.Text = String.Empty
        End If

    End Sub

    Public Function LoginMiddleware(ByVal name As String, ByVal password As String) As Boolean
        Try
            If String.IsNullOrEmpty(name) Then
                MessageBox.Show("Name cannot be null")
                Return False
            End If

            If String.IsNullOrEmpty(password) Then
                MessageBox.Show("Password cannot be null")
                Return False
            End If

            Dim query As String = "SELECT * FROM sudoers WHERE name = '" & name & "' AND password = '" & password & "'"
            Dim cmd As New MySqlCommand(query, con)
            con.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read Then
                con.Close()
                Return True
            Else
                con.Close()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("An error occurred: " & ex.ToString())
        End Try
    End Function
End Class
