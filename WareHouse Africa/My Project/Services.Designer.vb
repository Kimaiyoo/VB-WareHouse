<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Services
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
        WHServices = New DataGridView()
        ServiceID = New DataGridViewTextBoxColumn()
        StoreItem = New DataGridViewTextBoxColumn()
        ServicePrice = New DataGridViewTextBoxColumn()
        WHSite = New DataGridViewTextBoxColumn()
        CType(WHServices, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' WHServices
        ' 
        WHServices.BackgroundColor = SystemColors.Control
        WHServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        WHServices.Columns.AddRange(New DataGridViewColumn() {ServiceID, StoreItem, ServicePrice, WHSite})
        WHServices.Dock = DockStyle.Fill
        WHServices.Location = New Point(0, 0)
        WHServices.Name = "WHServices"
        WHServices.Size = New Size(462, 270)
        WHServices.TabIndex = 0
        ' 
        ' ServiceID
        ' 
        ServiceID.HeaderText = "Service ID"
        ServiceID.Name = "ServiceID"
        ' 
        ' StoreItem
        ' 
        StoreItem.HeaderText = "Store Item"
        StoreItem.Name = "StoreItem"
        ' 
        ' ServicePrice
        ' 
        ServicePrice.HeaderText = "Service Price"
        ServicePrice.Name = "ServicePrice"
        ' 
        ' WHSite
        ' 
        WHSite.HeaderText = "WareHouse Site"
        WHSite.Name = "WHSite"
        ' 
        ' Services
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(WHServices)
        Name = "Services"
        Size = New Size(462, 270)
        CType(WHServices, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents WHServices As DataGridView
    Friend WithEvents ServiceID As DataGridViewTextBoxColumn
    Friend WithEvents StoreItem As DataGridViewTextBoxColumn
    Friend WithEvents ServicePrice As DataGridViewTextBoxColumn
    Friend WithEvents WHSite As DataGridViewTextBoxColumn

End Class
