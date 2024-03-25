<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCustomers
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
        EditCustomersDataGrid = New DataGridView()
        CompanyName2 = New DataGridViewTextBoxColumn()
        ServiceID = New DataGridViewTextBoxColumn()
        DateIn = New DataGridViewTextBoxColumn()
        DateOut = New DataGridViewTextBoxColumn()
        CType(EditCustomersDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' EditCustomersDataGrid
        ' 
        EditCustomersDataGrid.AllowUserToAddRows = False
        EditCustomersDataGrid.BackgroundColor = SystemColors.ControlLight
        EditCustomersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        EditCustomersDataGrid.Columns.AddRange(New DataGridViewColumn() {CompanyName2, ServiceID, DateIn, DateOut})
        EditCustomersDataGrid.Dock = DockStyle.Top
        EditCustomersDataGrid.Location = New Point(0, 0)
        EditCustomersDataGrid.Name = "EditCustomersDataGrid"
        EditCustomersDataGrid.Size = New Size(643, 433)
        EditCustomersDataGrid.TabIndex = 0
        ' 
        ' CompanyName2
        ' 
        CompanyName2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        CompanyName2.HeaderText = "Company Name"
        CompanyName2.MinimumWidth = 150
        CompanyName2.Name = "CompanyName2"
        CompanyName2.Width = 150
        ' 
        ' ServiceID
        ' 
        ServiceID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        ServiceID.HeaderText = "Service ID"
        ServiceID.MinimumWidth = 150
        ServiceID.Name = "ServiceID"
        ServiceID.Width = 150
        ' 
        ' DateIn
        ' 
        DateIn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DateIn.HeaderText = "Date In"
        DateIn.MinimumWidth = 150
        DateIn.Name = "DateIn"
        DateIn.Width = 150
        ' 
        ' DateOut
        ' 
        DateOut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DateOut.HeaderText = "Date Out"
        DateOut.MinimumWidth = 150
        DateOut.Name = "DateOut"
        DateOut.Width = 150
        ' 
        ' EditCustomers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(EditCustomersDataGrid)
        Name = "EditCustomers"
        Size = New Size(643, 433)
        CType(EditCustomersDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents EditCustomersDataGrid As DataGridView
    Friend WithEvents CompanyName2 As DataGridViewTextBoxColumn
    Friend WithEvents ServiceID As DataGridViewTextBoxColumn
    Friend WithEvents DateIn As DataGridViewTextBoxColumn
    Friend WithEvents DateOut As DataGridViewTextBoxColumn

End Class
