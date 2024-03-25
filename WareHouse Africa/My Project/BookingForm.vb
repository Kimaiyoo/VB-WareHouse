Imports System.ComponentModel.Design.Serialization
Imports MySql.Data.MySqlClient

Public Class BookingForm
    Dim con As New MySqlConnection("host=127.0.0.1; user=savo; password=#g0langr0ckx; database=warehouse_africa")
    Private Sub BookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BookingSubmit1_Click(sender As Object, e As EventArgs) Handles BookingSubmit1.Click
        Dim companyName As String = CompanyNameTB.Text
        Dim serviceID As String = ServiceIDTB.Text
        Dim dateIn As DateTime = DateInTB.Value
        Dim dateOut As DateTime = DateOutTB.Value
        Dim inputIsValid As Boolean = IsValidInput(companyName, serviceID, dateIn, dateOut)

        If inputIsValid Then
            SubmitForm(companyName, serviceID, dateIn, dateOut)
            CompanyNameTB.Text = String.Empty
            ServiceIDTB.Text = String.Empty
        Else
            MessageBox.Show("Form was not submitted due to being invalid")
        End If

    End Sub

    Public Function IsValidInput(ByVal companyName As String, ByVal serviceID As String, ByVal dateIn As Date, ByVal dateOut As Date) As Boolean
        Try
            If String.IsNullOrEmpty(companyName) Then
                MessageBox.Show("Company name cannot be null")
                Return False
            End If

            If dateIn = DateTime.MinValue Then
                MessageBox.Show("Date in cannot be null")
                Return False
            End If

            If dateOut = DateTime.MinValue Then
                MessageBox.Show("Date out cannot be null")
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("An error occurred: " & ex.ToString())
        End Try
        Return True
    End Function

    Sub SubmitForm(companyName, serviceID, dateIn, dateOut)
        Try
            Dim query1 As String = "SELECT * FROM services WHERE id = '" & serviceID & "'"
            Dim query2 As String = "INSERT INTO customers VALUES('" & companyName & "','" & serviceID & "','" & dateIn & "','" & dateOut & "')"
            Dim cmd1 As New MySqlCommand(query1, con)
            Dim cmd2 As New MySqlCommand(query2, con)

            con.Open()
            Dim reader As MySqlDataReader = cmd1.ExecuteReader()

            If reader.Read() Then
                ' insert records
                reader.Close()
                cmd2.ExecuteNonQuery()
                MsgBox("Slot booked successfully")
                con.Close()
            Else
                reader.Close()
                MessageBox.Show("Service ID does not exist")
                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("An error occurred: " & ex.ToString())
        End Try
    End Sub
End Class
