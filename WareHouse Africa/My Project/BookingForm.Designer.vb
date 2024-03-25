<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingForm
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
        CompanyNameTB = New TextBox()
        ServiceIDTB = New TextBox()
        CompanyNameLabel = New Label()
        ServiceIdLabel = New Label()
        DateInLabel = New Label()
        DateOutLabel = New Label()
        DateInTB = New DateTimePicker()
        DateOutTB = New DateTimePicker()
        BookingHeader = New Label()
        BookingSubmit1 = New Label()
        SuspendLayout()
        ' 
        ' CompanyNameTB
        ' 
        CompanyNameTB.Location = New Point(275, 87)
        CompanyNameTB.Name = "CompanyNameTB"
        CompanyNameTB.Size = New Size(191, 23)
        CompanyNameTB.TabIndex = 0
        ' 
        ' ServiceIDTB
        ' 
        ServiceIDTB.Location = New Point(275, 145)
        ServiceIDTB.Name = "ServiceIDTB"
        ServiceIDTB.Size = New Size(191, 23)
        ServiceIDTB.TabIndex = 1
        ' 
        ' CompanyNameLabel
        ' 
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CompanyNameLabel.Location = New Point(66, 87)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New Size(107, 20)
        CompanyNameLabel.TabIndex = 2
        CompanyNameLabel.Text = "Company Name"
        ' 
        ' ServiceIdLabel
        ' 
        ServiceIdLabel.AutoSize = True
        ServiceIdLabel.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ServiceIdLabel.Location = New Point(66, 148)
        ServiceIdLabel.Name = "ServiceIdLabel"
        ServiceIdLabel.Size = New Size(72, 20)
        ServiceIdLabel.TabIndex = 3
        ServiceIdLabel.Text = "Service ID"
        ' 
        ' DateInLabel
        ' 
        DateInLabel.AutoSize = True
        DateInLabel.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateInLabel.Location = New Point(66, 210)
        DateInLabel.Name = "DateInLabel"
        DateInLabel.Size = New Size(52, 20)
        DateInLabel.TabIndex = 4
        DateInLabel.Text = "Date In"
        ' 
        ' DateOutLabel
        ' 
        DateOutLabel.AutoSize = True
        DateOutLabel.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateOutLabel.Location = New Point(66, 269)
        DateOutLabel.Name = "DateOutLabel"
        DateOutLabel.Size = New Size(62, 20)
        DateOutLabel.TabIndex = 5
        DateOutLabel.Text = "Date Out"
        ' 
        ' DateInTB
        ' 
        DateInTB.CustomFormat = "dd-MM-yyyy"
        DateInTB.Format = DateTimePickerFormat.Custom
        DateInTB.Location = New Point(275, 202)
        DateInTB.Name = "DateInTB"
        DateInTB.Size = New Size(191, 23)
        DateInTB.TabIndex = 6
        ' 
        ' DateOutTB
        ' 
        DateOutTB.CustomFormat = "dd-MM-yyyy"
        DateOutTB.Format = DateTimePickerFormat.Custom
        DateOutTB.Location = New Point(275, 263)
        DateOutTB.Name = "DateOutTB"
        DateOutTB.Size = New Size(191, 23)
        DateOutTB.TabIndex = 7
        ' 
        ' BookingHeader
        ' 
        BookingHeader.AutoSize = True
        BookingHeader.BackColor = SystemColors.GrayText
        BookingHeader.Dock = DockStyle.Fill
        BookingHeader.FlatStyle = FlatStyle.Flat
        BookingHeader.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BookingHeader.Location = New Point(0, 0)
        BookingHeader.Margin = New Padding(31, 10, 3, 0)
        BookingHeader.Name = "BookingHeader"
        BookingHeader.Size = New Size(202, 19)
        BookingHeader.TabIndex = 80
        BookingHeader.Text = "Book Your Service Below"
        BookingHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BookingSubmit1
        ' 
        BookingSubmit1.AutoSize = True
        BookingSubmit1.BackColor = SystemColors.ActiveBorder
        BookingSubmit1.FlatStyle = FlatStyle.Flat
        BookingSubmit1.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BookingSubmit1.Location = New Point(275, 319)
        BookingSubmit1.Name = "BookingSubmit1"
        BookingSubmit1.Size = New Size(45, 16)
        BookingSubmit1.TabIndex = 81
        BookingSubmit1.Text = "Submit"
        ' 
        ' BookingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BookingSubmit1)
        Controls.Add(BookingHeader)
        Controls.Add(DateOutTB)
        Controls.Add(DateInTB)
        Controls.Add(DateOutLabel)
        Controls.Add(DateInLabel)
        Controls.Add(ServiceIdLabel)
        Controls.Add(CompanyNameLabel)
        Controls.Add(ServiceIDTB)
        Controls.Add(CompanyNameTB)
        Name = "BookingForm"
        Size = New Size(553, 415)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CompanyNameTB As TextBox
    Friend WithEvents ServiceIDTB As TextBox
    Friend WithEvents CompanyNameLabel As Label
    Friend WithEvents ServiceIdLabel As Label
    Friend WithEvents DateInLabel As Label
    Friend WithEvents DateOutLabel As Label
    Friend WithEvents DateInTB As DateTimePicker
    Friend WithEvents DateOutTB As DateTimePicker
    Friend WithEvents BookingHeader As Label
    Friend WithEvents BookingSubmit1 As Label

End Class
