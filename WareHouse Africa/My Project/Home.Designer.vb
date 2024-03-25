<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        HomeNavBar = New Panel()
        NavBarAdmin = New FontAwesome.Sharp.IconButton()
        NavBarBook = New FontAwesome.Sharp.IconButton()
        NavBarServices = New FontAwesome.Sharp.IconButton()
        PictureBox1 = New PictureBox()
        HomeBody = New Panel()
        HomeServicesView1 = New DataGridView()
        ServiceID = New DataGridViewTextBoxColumn()
        StoreItem = New DataGridViewTextBoxColumn()
        ServiceCharges = New DataGridViewTextBoxColumn()
        WHSite = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        Label2 = New Label()
        Footer1 = New Panel()
        Label1 = New Label()
        HomeNavBar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        HomeBody.SuspendLayout()
        CType(HomeServicesView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Footer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' HomeNavBar
        ' 
        HomeNavBar.BackColor = SystemColors.GrayText
        HomeNavBar.Controls.Add(NavBarAdmin)
        HomeNavBar.Controls.Add(NavBarBook)
        HomeNavBar.Controls.Add(NavBarServices)
        HomeNavBar.Controls.Add(PictureBox1)
        HomeNavBar.Dock = DockStyle.Top
        HomeNavBar.Location = New Point(0, 0)
        HomeNavBar.Name = "HomeNavBar"
        HomeNavBar.Size = New Size(800, 88)
        HomeNavBar.TabIndex = 0
        ' 
        ' NavBarAdmin
        ' 
        NavBarAdmin.BackColor = SystemColors.ControlDark
        NavBarAdmin.FlatStyle = FlatStyle.Flat
        NavBarAdmin.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NavBarAdmin.IconChar = FontAwesome.Sharp.IconChar.None
        NavBarAdmin.IconColor = Color.Black
        NavBarAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto
        NavBarAdmin.ImageAlign = ContentAlignment.BottomLeft
        NavBarAdmin.Location = New Point(700, 36)
        NavBarAdmin.Name = "NavBarAdmin"
        NavBarAdmin.Size = New Size(75, 31)
        NavBarAdmin.TabIndex = 3
        NavBarAdmin.Text = "Admin"
        NavBarAdmin.UseVisualStyleBackColor = False
        ' 
        ' NavBarBook
        ' 
        NavBarBook.BackColor = SystemColors.ControlDark
        NavBarBook.FlatStyle = FlatStyle.Flat
        NavBarBook.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NavBarBook.IconChar = FontAwesome.Sharp.IconChar.None
        NavBarBook.IconColor = Color.Black
        NavBarBook.IconFont = FontAwesome.Sharp.IconFont.Auto
        NavBarBook.ImageAlign = ContentAlignment.BottomLeft
        NavBarBook.Location = New Point(579, 36)
        NavBarBook.Name = "NavBarBook"
        NavBarBook.Size = New Size(75, 31)
        NavBarBook.TabIndex = 2
        NavBarBook.Text = "Bookings"
        NavBarBook.UseVisualStyleBackColor = False
        ' 
        ' NavBarServices
        ' 
        NavBarServices.BackColor = SystemColors.ControlDark
        NavBarServices.FlatStyle = FlatStyle.Flat
        NavBarServices.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NavBarServices.IconChar = FontAwesome.Sharp.IconChar.None
        NavBarServices.IconColor = Color.Black
        NavBarServices.IconFont = FontAwesome.Sharp.IconFont.Auto
        NavBarServices.Location = New Point(453, 36)
        NavBarServices.Name = "NavBarServices"
        NavBarServices.Size = New Size(75, 31)
        NavBarServices.TabIndex = 1
        NavBarServices.Text = "Services"
        NavBarServices.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.warehouse
        PictureBox1.Location = New Point(0, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(115, 66)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' HomeBody
        ' 
        HomeBody.Controls.Add(HomeServicesView1)
        HomeBody.Controls.Add(Panel1)
        HomeBody.Location = New Point(12, 121)
        HomeBody.Name = "HomeBody"
        HomeBody.Size = New Size(776, 377)
        HomeBody.TabIndex = 1
        ' 
        ' HomeServicesView1
        ' 
        HomeServicesView1.AllowUserToAddRows = False
        HomeServicesView1.BackgroundColor = SystemColors.ButtonFace
        HomeServicesView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        HomeServicesView1.Columns.AddRange(New DataGridViewColumn() {ServiceID, StoreItem, ServiceCharges, WHSite})
        HomeServicesView1.Location = New Point(66, 121)
        HomeServicesView1.Name = "HomeServicesView1"
        HomeServicesView1.ReadOnly = True
        HomeServicesView1.RowHeadersVisible = False
        HomeServicesView1.Size = New Size(605, 253)
        HomeServicesView1.TabIndex = 3
        ' 
        ' ServiceID
        ' 
        ServiceID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        ServiceID.HeaderText = "Service ID"
        ServiceID.MinimumWidth = 150
        ServiceID.Name = "ServiceID"
        ServiceID.ReadOnly = True
        ServiceID.Width = 150
        ' 
        ' StoreItem
        ' 
        StoreItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        StoreItem.HeaderText = "Store Item"
        StoreItem.MinimumWidth = 150
        StoreItem.Name = "StoreItem"
        StoreItem.ReadOnly = True
        StoreItem.Width = 150
        ' 
        ' ServiceCharges
        ' 
        ServiceCharges.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        ServiceCharges.HeaderText = "Service Charges"
        ServiceCharges.MinimumWidth = 150
        ServiceCharges.Name = "ServiceCharges"
        ServiceCharges.ReadOnly = True
        ServiceCharges.Width = 150
        ' 
        ' WHSite
        ' 
        WHSite.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        WHSite.HeaderText = "Warehouse location"
        WHSite.MinimumWidth = 150
        WHSite.Name = "WHSite"
        WHSite.ReadOnly = True
        WHSite.Width = 150
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 94)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(268, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(238, 40)
        Label2.TabIndex = 0
        Label2.Text = "Our Services"
        ' 
        ' Footer1
        ' 
        Footer1.BackColor = SystemColors.ButtonShadow
        Footer1.Controls.Add(Label1)
        Footer1.Dock = DockStyle.Bottom
        Footer1.Location = New Point(0, 521)
        Footer1.Name = "Footer1"
        Footer1.Size = New Size(800, 61)
        Footer1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(346, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 16)
        Label1.TabIndex = 0
        Label1.Text = "Copyright @2024"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 582)
        Controls.Add(Footer1)
        Controls.Add(HomeBody)
        Controls.Add(HomeNavBar)
        Name = "Home"
        Text = "Home"
        HomeNavBar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        HomeBody.ResumeLayout(False)
        CType(HomeServicesView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Footer1.ResumeLayout(False)
        Footer1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents HomeNavBar As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NavBarServices As FontAwesome.Sharp.IconButton
    Friend WithEvents NavBarBook As FontAwesome.Sharp.IconButton
    Friend WithEvents HomeBody As Panel
    Friend WithEvents Footer1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NavBarAdmin As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents HomeServicesView1 As DataGridView
    Friend WithEvents ServiceID As DataGridViewTextBoxColumn
    Friend WithEvents StoreItem As DataGridViewTextBoxColumn
    Friend WithEvents ServiceCharges As DataGridViewTextBoxColumn
    Friend WithEvents WHSite As DataGridViewTextBoxColumn
End Class
