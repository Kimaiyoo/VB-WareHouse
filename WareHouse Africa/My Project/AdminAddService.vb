Imports MySql.Data.MySqlClient

Public Class AdminAddService
    Dim con As New MySqlConnection("host=127.0.0.1; user=savo; password=#g0langr0ckx; database=warehouse_africa")
    Private Sub AdminSubmit1_Click(sender As Object, e As EventArgs) Handles AdminSubmit1.Click
        Dim serviceID As Integer = AdminServIDTB1.Text
        Dim storeItem As String = AdminStrItemTB1.Text
        Dim price As Integer = AdminSerPrice1.Text
        Dim site As String = WHSite1.Text

        Dim inputIsValid As Boolean = IsValidInput(serviceID, storeItem, price, site)

        If inputIsValid Then
            SubmitForm(serviceID, storeItem, price, site)
        Else
            MessageBox.Show("Form was not submitted due to being invalid")
        End If

    End Sub

    Public Function IsValidInput(ByVal serviceID As Integer, ByVal storeItem As String, ByVal price As Integer, ByVal site As String) As Boolean
        Try
            If Not Integer.TryParse(serviceID, Nothing) Then
                MessageBox.Show("Service ID must be an integer")
                Return False
            End If

            If String.IsNullOrEmpty(storeItem) Then
                MessageBox.Show("Store Item cannot be null")
                Return False
            End If

            If Not Integer.TryParse(price, Nothing) Then
                MessageBox.Show("Price must be an integer")
                Return False
            End If

            If String.IsNullOrEmpty(site) Then
                MessageBox.Show("Site cannot be null")
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("An error occurred: " & ex.ToString())
        End Try
        Return True
    End Function

    Sub SubmitForm(serviceID, storeItem, price, site)
        Try
            Dim query As String = "INSERT INTO services VALUES('" & serviceID & "','" & storeItem & "','" & price & "','" & site & "')"
            con.Open()
            Dim cmd As New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Service has been added")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("An error occurred: " & ex.ToString())
        End Try
    End Sub
End Class
