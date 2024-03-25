<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        SideBar = New Panel()
        AddServiceButton = New FontAwesome.Sharp.IconButton()
        CustomersButton = New FontAwesome.Sharp.IconButton()
        LogoPanel = New Panel()
        Logo = New PictureBox()
        NavBar = New Panel()
        IconLabel = New Label()
        HomeIcon = New FontAwesome.Sharp.IconPictureBox()
        Body = New Panel()
        Footer1 = New Panel()
        Label1 = New Label()
        SideBar.SuspendLayout()
        LogoPanel.SuspendLayout()
        CType(Logo, ComponentModel.ISupportInitialize).BeginInit()
        NavBar.SuspendLayout()
        CType(HomeIcon, ComponentModel.ISupportInitialize).BeginInit()
        Footer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SideBar
        ' 
        SideBar.BackColor = Color.Silver
        SideBar.Controls.Add(AddServiceButton)
        SideBar.Controls.Add(CustomersButton)
        SideBar.Controls.Add(LogoPanel)
        SideBar.Dock = DockStyle.Left
        SideBar.Location = New Point(0, 0)
        SideBar.Name = "SideBar"
        SideBar.Size = New Size(224, 548)
        SideBar.TabIndex = 0
        ' 
        ' AddServiceButton
        ' 
        AddServiceButton.BackColor = Color.Gray
        AddServiceButton.Dock = DockStyle.Top
        AddServiceButton.FlatStyle = FlatStyle.Flat
        AddServiceButton.IconChar = FontAwesome.Sharp.IconChar.Plus
        AddServiceButton.IconColor = Color.WhiteSmoke
        AddServiceButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        AddServiceButton.IconSize = 32
        AddServiceButton.ImageAlign = ContentAlignment.MiddleLeft
        AddServiceButton.Location = New Point(0, 200)
        AddServiceButton.Name = "AddServiceButton"
        AddServiceButton.Padding = New Padding(10, 0, 20, 0)
        AddServiceButton.Size = New Size(224, 60)
        AddServiceButton.TabIndex = 2
        AddServiceButton.Text = "Add Service"
        AddServiceButton.TextAlign = ContentAlignment.MiddleLeft
        AddServiceButton.TextImageRelation = TextImageRelation.ImageBeforeText
        AddServiceButton.UseVisualStyleBackColor = False
        ' 
        ' CustomersButton
        ' 
        CustomersButton.BackColor = Color.Gray
        CustomersButton.Dock = DockStyle.Top
        CustomersButton.FlatStyle = FlatStyle.Flat
        CustomersButton.IconChar = FontAwesome.Sharp.IconChar.Users
        CustomersButton.IconColor = Color.WhiteSmoke
        CustomersButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        CustomersButton.IconSize = 32
        CustomersButton.ImageAlign = ContentAlignment.MiddleLeft
        CustomersButton.Location = New Point(0, 140)
        CustomersButton.Name = "CustomersButton"
        CustomersButton.Padding = New Padding(10, 0, 20, 0)
        CustomersButton.Size = New Size(224, 60)
        CustomersButton.TabIndex = 1
        CustomersButton.Text = "Customers"
        CustomersButton.TextAlign = ContentAlignment.MiddleLeft
        CustomersButton.TextImageRelation = TextImageRelation.ImageBeforeText
        CustomersButton.UseVisualStyleBackColor = False
        ' 
        ' LogoPanel
        ' 
        LogoPanel.Controls.Add(Logo)
        LogoPanel.Dock = DockStyle.Top
        LogoPanel.Location = New Point(0, 0)
        LogoPanel.Name = "LogoPanel"
        LogoPanel.Size = New Size(224, 140)
        LogoPanel.TabIndex = 0
        ' 
        ' Logo
        ' 
        Logo.Image = CType(resources.GetObject("Logo.Image"), Image)
        Logo.Location = New Point(3, 12)
        Logo.Name = "Logo"
        Logo.Size = New Size(202, 125)
        Logo.SizeMode = PictureBoxSizeMode.Zoom
        Logo.TabIndex = 0
        Logo.TabStop = False
        ' 
        ' NavBar
        ' 
        NavBar.BackColor = SystemColors.GrayText
        NavBar.Controls.Add(IconLabel)
        NavBar.Controls.Add(HomeIcon)
        NavBar.Dock = DockStyle.Top
        NavBar.Location = New Point(224, 0)
        NavBar.Name = "NavBar"
        NavBar.Size = New Size(760, 75)
        NavBar.TabIndex = 1
        ' 
        ' IconLabel
        ' 
        IconLabel.AutoSize = True
        IconLabel.ForeColor = SystemColors.ControlLightLight
        IconLabel.Location = New Point(74, 25)
        IconLabel.Name = "IconLabel"
        IconLabel.Size = New Size(0, 15)
        IconLabel.TabIndex = 1
        ' 
        ' HomeIcon
        ' 
        HomeIcon.BackColor = SystemColors.GrayText
        HomeIcon.ForeColor = SystemColors.ControlText
        HomeIcon.IconChar = FontAwesome.Sharp.IconChar.HomeUser
        HomeIcon.IconColor = SystemColors.ControlText
        HomeIcon.IconFont = FontAwesome.Sharp.IconFont.Auto
        HomeIcon.Location = New Point(36, 25)
        HomeIcon.Name = "HomeIcon"
        HomeIcon.Size = New Size(32, 32)
        HomeIcon.TabIndex = 0
        HomeIcon.TabStop = False
        ' 
        ' Body
        ' 
        Body.BackColor = SystemColors.GrayText
        Body.Location = New Point(280, 107)
        Body.Name = "Body"
        Body.Size = New Size(704, 358)
        Body.TabIndex = 2
        ' 
        ' Footer1
        ' 
        Footer1.BackColor = SystemColors.ButtonShadow
        Footer1.Controls.Add(Label1)
        Footer1.Dock = DockStyle.Bottom
        Footer1.Location = New Point(224, 487)
        Footer1.Name = "Footer1"
        Footer1.Size = New Size(760, 61)
        Footer1.TabIndex = 3
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
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 548)
        Controls.Add(Footer1)
        Controls.Add(Body)
        Controls.Add(NavBar)
        Controls.Add(SideBar)
        Name = "Admin"
        Text = "Admin"
        SideBar.ResumeLayout(False)
        LogoPanel.ResumeLayout(False)
        CType(Logo, ComponentModel.ISupportInitialize).EndInit()
        NavBar.ResumeLayout(False)
        NavBar.PerformLayout()
        CType(HomeIcon, ComponentModel.ISupportInitialize).EndInit()
        Footer1.ResumeLayout(False)
        Footer1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SideBar As Panel
    Friend WithEvents LogoPanel As Panel
    Friend WithEvents Logo As PictureBox
    Friend WithEvents CustomersButton As FontAwesome.Sharp.IconButton
    Friend WithEvents AddServiceButton As FontAwesome.Sharp.IconButton
    Friend WithEvents NavBar As Panel
    Friend WithEvents IconLabel As Label
    Friend WithEvents HomeIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Body As Panel
    Friend WithEvents Footer1 As Panel
    Friend WithEvents Label1 As Label

End Class
