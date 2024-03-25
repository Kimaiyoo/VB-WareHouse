Imports MySql.Data.MySqlClient

Public Class Admin
    Dim con As New MySqlConnection("host=127.0.0.1; user=savo; password=#g0langr0ckx; database=warehouse_africa")
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerRecords()

    End Sub

    Private Sub CustomersButton_Click(sender As Object, e As EventArgs) Handles CustomersButton.Click
        LoadCustomerRecords()
    End Sub

    Private Sub AddServiceButton_Click(sender As Object, e As EventArgs) Handles AddServiceButton.Click
        LoadServicesForm()
    End Sub


    Private Sub Logo_Click(sender As Object, e As EventArgs) Handles Logo.Click
        Dim mainForm As New Home
        mainForm.Show()
        Me.Close()
    End Sub


    Sub LoadCustomerRecords()
        Try
            '' Load records of customers
            Body.Controls.Clear()
            Dim customers As New EditCustomers()
            Body.Controls.Add(customers.EditCustomersDataGrid)

            'open mysql connnection
            con.Open()

            Dim query As String = "SELECT * FROM customers"
            Dim cmd As New MySqlCommand(query, con)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                customers.EditCustomersDataGrid.Rows.Add(reader("company_name"), reader("service_id"), reader("date_in"), reader("date_out"))

            End While

            'close mysql connection
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub

    Sub LoadServicesForm()
        Body.Controls.Clear()
        Dim serviceForm As New AdminAddService()
        Body.Controls.Add(serviceForm)
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles HomeIcon.Click
        Dim mainForm As New Home
        mainForm.Show()
        Me.Close()
    End Sub

End Class
