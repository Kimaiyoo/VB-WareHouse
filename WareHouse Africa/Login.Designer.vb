<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        LoginName1 = New Label()
        LoginNameTB1 = New TextBox()
        LoginPassTB2 = New TextBox()
        LoginPassLabel2 = New Label()
        LoginSubmitLabel3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LoginSubmitLabel3)
        Panel1.Controls.Add(LoginPassLabel2)
        Panel1.Controls.Add(LoginPassTB2)
        Panel1.Controls.Add(LoginNameTB1)
        Panel1.Controls.Add(LoginName1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(436, 334)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.AppWorkspace
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 19)
        Label1.TabIndex = 0
        Label1.Text = "Login to your account"
        ' 
        ' LoginName1
        ' 
        LoginName1.AutoSize = True
        LoginName1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginName1.Location = New Point(33, 64)
        LoginName1.Name = "LoginName1"
        LoginName1.Size = New Size(44, 20)
        LoginName1.TabIndex = 1
        LoginName1.Text = "Name"
        ' 
        ' LoginNameTB1
        ' 
        LoginNameTB1.Location = New Point(143, 64)
        LoginNameTB1.Name = "LoginNameTB1"
        LoginNameTB1.Size = New Size(161, 23)
        LoginNameTB1.TabIndex = 4
        ' 
        ' LoginPassTB2
        ' 
        LoginPassTB2.Location = New Point(143, 139)
        LoginPassTB2.Name = "LoginPassTB2"
        LoginPassTB2.Size = New Size(161, 23)
        LoginPassTB2.TabIndex = 5
        ' 
        ' LoginPassLabel2
        ' 
        LoginPassLabel2.AutoSize = True
        LoginPassLabel2.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginPassLabel2.Location = New Point(33, 142)
        LoginPassLabel2.Name = "LoginPassLabel2"
        LoginPassLabel2.Size = New Size(69, 20)
        LoginPassLabel2.TabIndex = 6
        LoginPassLabel2.Text = "Password"
        ' 
        ' LoginSubmitLabel3
        ' 
        LoginSubmitLabel3.AutoSize = True
        LoginSubmitLabel3.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginSubmitLabel3.Location = New Point(143, 209)
        LoginSubmitLabel3.Name = "LoginSubmitLabel3"
        LoginSubmitLabel3.Size = New Size(54, 20)
        LoginSubmitLabel3.TabIndex = 7
        LoginSubmitLabel3.Text = "Submit"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "Login"
        Size = New Size(436, 334)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LoginPassTB2 As TextBox
    Friend WithEvents LoginNameTB1 As TextBox
    Friend WithEvents LoginName1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginPassLabel2 As Label
    Friend WithEvents LoginSubmitLabel3 As Label

End Class
