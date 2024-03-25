<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAddService
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
        AdminBookingLabel1 = New Label()
        AdminServiceID1 = New Label()
        AdminStoreItemLabel1 = New Label()
        ServPriceLabel1 = New Label()
        AdminWHSite1 = New Label()
        AdminServIDTB1 = New TextBox()
        AdminStrItemTB1 = New TextBox()
        AdminSerPrice1 = New TextBox()
        WHSite1 = New TextBox()
        AdminSubmit1 = New Label()
        SuspendLayout()
        ' 
        ' AdminBookingLabel1
        ' 
        AdminBookingLabel1.AutoSize = True
        AdminBookingLabel1.BackColor = SystemColors.ButtonShadow
        AdminBookingLabel1.FlatStyle = FlatStyle.Flat
        AdminBookingLabel1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AdminBookingLabel1.Location = New Point(0, 0)
        AdminBookingLabel1.Name = "AdminBookingLabel1"
        AdminBookingLabel1.Size = New Size(185, 19)
        AdminBookingLabel1.TabIndex = 0
        AdminBookingLabel1.Text = "Add new service below"
        ' 
        ' AdminServiceID1
        ' 
        AdminServiceID1.AutoSize = True
        AdminServiceID1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AdminServiceID1.Location = New Point(89, 60)
        AdminServiceID1.Name = "AdminServiceID1"
        AdminServiceID1.Size = New Size(72, 20)
        AdminServiceID1.TabIndex = 1
        AdminServiceID1.Text = "Service ID"
        ' 
        ' AdminStoreItemLabel1
        ' 
        AdminStoreItemLabel1.AutoSize = True
        AdminStoreItemLabel1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AdminStoreItemLabel1.Location = New Point(89, 120)
        AdminStoreItemLabel1.Name = "AdminStoreItemLabel1"
        AdminStoreItemLabel1.Size = New Size(73, 20)
        AdminStoreItemLabel1.TabIndex = 2
        AdminStoreItemLabel1.Text = "Store Item"
        ' 
        ' ServPriceLabel1
        ' 
        ServPriceLabel1.AutoSize = True
        ServPriceLabel1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ServPriceLabel1.Location = New Point(89, 180)
        ServPriceLabel1.Name = "ServPriceLabel1"
        ServPriceLabel1.Size = New Size(91, 20)
        ServPriceLabel1.TabIndex = 3
        ServPriceLabel1.Text = "Service Price"
        ' 
        ' AdminWHSite1
        ' 
        AdminWHSite1.AutoSize = True
        AdminWHSite1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AdminWHSite1.Location = New Point(89, 234)
        AdminWHSite1.Name = "AdminWHSite1"
        AdminWHSite1.Size = New Size(110, 20)
        AdminWHSite1.TabIndex = 4
        AdminWHSite1.Text = "Ware House Site"
        ' 
        ' AdminServIDTB1
        ' 
        AdminServIDTB1.Location = New Point(288, 52)
        AdminServIDTB1.Name = "AdminServIDTB1"
        AdminServIDTB1.Size = New Size(131, 23)
        AdminServIDTB1.TabIndex = 5
        ' 
        ' AdminStrItemTB1
        ' 
        AdminStrItemTB1.Location = New Point(288, 117)
        AdminStrItemTB1.Name = "AdminStrItemTB1"
        AdminStrItemTB1.Size = New Size(131, 23)
        AdminStrItemTB1.TabIndex = 6
        ' 
        ' AdminSerPrice1
        ' 
        AdminSerPrice1.Location = New Point(288, 177)
        AdminSerPrice1.Name = "AdminSerPrice1"
        AdminSerPrice1.Size = New Size(131, 23)
        AdminSerPrice1.TabIndex = 7
        ' 
        ' WHSite1
        ' 
        WHSite1.Location = New Point(288, 234)
        WHSite1.Name = "WHSite1"
        WHSite1.Size = New Size(131, 23)
        WHSite1.TabIndex = 8
        ' 
        ' AdminSubmit1
        ' 
        AdminSubmit1.AutoSize = True
        AdminSubmit1.BackColor = SystemColors.ActiveBorder
        AdminSubmit1.FlatStyle = FlatStyle.Flat
        AdminSubmit1.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AdminSubmit1.Location = New Point(288, 286)
        AdminSubmit1.Name = "AdminSubmit1"
        AdminSubmit1.Size = New Size(45, 16)
        AdminSubmit1.TabIndex = 9
        AdminSubmit1.Text = "Submit"
        ' 
        ' AdminAddService
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(AdminSubmit1)
        Controls.Add(WHSite1)
        Controls.Add(AdminSerPrice1)
        Controls.Add(AdminStrItemTB1)
        Controls.Add(AdminServIDTB1)
        Controls.Add(AdminWHSite1)
        Controls.Add(ServPriceLabel1)
        Controls.Add(AdminStoreItemLabel1)
        Controls.Add(AdminServiceID1)
        Controls.Add(AdminBookingLabel1)
        Name = "AdminAddService"
        Size = New Size(579, 377)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AdminBookingLabel1 As Label
    Friend WithEvents AdminServiceID1 As Label
    Friend WithEvents AdminStoreItemLabel1 As Label
    Friend WithEvents ServPriceLabel1 As Label
    Friend WithEvents AdminWHSite1 As Label
    Friend WithEvents AdminServIDTB1 As TextBox
    Friend WithEvents AdminStrItemTB1 As TextBox
    Friend WithEvents AdminSerPrice1 As TextBox
    Friend WithEvents WHSite1 As TextBox
    Friend WithEvents AdminSubmit1 As Label

End Class
