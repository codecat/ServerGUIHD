<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.txtClientPass = New System.Windows.Forms.TextBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.numPrivateSlots = New System.Windows.Forms.NumericUpDown()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.cmbMode = New System.Windows.Forms.ComboBox()
    Me.chkSpawnInvul = New System.Windows.Forms.CheckBox()
    Me.chkAllowPause = New System.Windows.Forms.CheckBox()
    Me.chkAllowArmor = New System.Windows.Forms.CheckBox()
    Me.chkAllowHealth = New System.Windows.Forms.CheckBox()
    Me.chkInfiniteAmmo = New System.Windows.Forms.CheckBox()
    Me.CheckBox1 = New System.Windows.Forms.CheckBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtAdminPass = New System.Windows.Forms.TextBox()
    Me.numInterChat = New System.Windows.Forms.NumericUpDown()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtInterChat = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.numPlayers = New System.Windows.Forms.NumericUpDown()
    Me.txtLevel = New System.Windows.Forms.TextBox()
    Me.cmbLevel = New System.Windows.Forms.ComboBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtServername = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lblEnumPort = New System.Windows.Forms.Label()
    Me.numPort = New System.Windows.Forms.NumericUpDown()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.Button4 = New System.Windows.Forms.Button()
    Me.ListBox1 = New System.Windows.Forms.ListBox()
    Me.tmrGet = New System.Windows.Forms.Timer(Me.components)
    Me.Button5 = New System.Windows.Forms.Button()
    Me.Button6 = New System.Windows.Forms.Button()
    Me.Button7 = New System.Windows.Forms.Button()
    Me.lstPlayers = New System.Windows.Forms.ListBox()
    Me.GroupBox4 = New System.Windows.Forms.GroupBox()
    Me.Button9 = New System.Windows.Forms.Button()
    Me.Button8 = New System.Windows.Forms.Button()
    Me.grpDebug = New System.Windows.Forms.GroupBox()
    Me.lblStatus = New System.Windows.Forms.Label()
    Me.Button10 = New System.Windows.Forms.Button()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.numMinimal = New System.Windows.Forms.NumericUpDown()
    Me.Label25 = New System.Windows.Forms.Label()
    Me.Label24 = New System.Windows.Forms.Label()
    Me.Label23 = New System.Windows.Forms.Label()
    Me.numMaxClientBPS = New System.Windows.Forms.NumericUpDown()
    Me.Label22 = New System.Windows.Forms.Label()
    Me.numFPS = New System.Windows.Forms.NumericUpDown()
    Me.Label21 = New System.Windows.Forms.Label()
    Me.numTimeLimit = New System.Windows.Forms.NumericUpDown()
    Me.numFragLimit = New System.Windows.Forms.NumericUpDown()
    Me.Label20 = New System.Windows.Forms.Label()
    Me.Label19 = New System.Windows.Forms.Label()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.chkDisableVoting = New System.Windows.Forms.CheckBox()
    Me.chkCheats = New System.Windows.Forms.CheckBox()
    Me.lblVal2 = New System.Windows.Forms.Label()
    Me.lblVal1 = New System.Windows.Forms.Label()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.numExtraEnemyStrengthPerPlayer = New System.Windows.Forms.TrackBar()
    Me.numExtraEnemyStrength = New System.Windows.Forms.TrackBar()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.cmbDifficulty = New System.Windows.Forms.ComboBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.chkRespawnInPlace = New System.Windows.Forms.CheckBox()
    Me.chkFriendlyFire = New System.Windows.Forms.CheckBox()
    Me.chkExtraEnemies = New System.Windows.Forms.CheckBox()
    Me.chkWeaponsStay = New System.Windows.Forms.CheckBox()
    Me.chkAmmoStays = New System.Windows.Forms.CheckBox()
    Me.chkArmorStays = New System.Windows.Forms.CheckBox()
    Me.chkHealthStays = New System.Windows.Forms.CheckBox()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.textExec = New System.Windows.Forms.TextBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.checkExec = New System.Windows.Forms.CheckBox()
    Me.TabPage5 = New System.Windows.Forms.TabPage()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.txtRconInput = New System.Windows.Forms.TextBox()
    Me.txtRconOutput = New System.Windows.Forms.TextBox()
    Me.tmrSleep = New System.Windows.Forms.Timer(Me.components)
    CType(Me.numPrivateSlots, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numInterChat, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numPort, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox4.SuspendLayout()
    Me.grpDebug.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    CType(Me.numMinimal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numMaxClientBPS, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numFPS, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numTimeLimit, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numFragLimit, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPage2.SuspendLayout()
    CType(Me.numExtraEnemyStrengthPerPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.numExtraEnemyStrength, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPage3.SuspendLayout()
    Me.TabPage5.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'LinkLabel1
    '
    Me.LinkLabel1.AutoSize = True
    Me.LinkLabel1.Location = New System.Drawing.Point(7, 393)
    Me.LinkLabel1.Name = "LinkLabel1"
    Me.LinkLabel1.Size = New System.Drawing.Size(85, 13)
    Me.LinkLabel1.TabIndex = 0
    Me.LinkLabel1.TabStop = True
    Me.LinkLabel1.Text = "By Angelo Geels"
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(12, 363)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(63, 23)
    Me.Button1.TabIndex = 1
    Me.Button1.Text = "Start"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(451, 181)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(62, 13)
    Me.Label11.TabIndex = 21
    Me.Label11.Text = "Client Pass:"
    Me.Label11.Visible = False
    '
    'txtClientPass
    '
    Me.txtClientPass.Location = New System.Drawing.Point(519, 178)
    Me.txtClientPass.Name = "txtClientPass"
    Me.txtClientPass.Size = New System.Drawing.Size(119, 20)
    Me.txtClientPass.TabIndex = 20
    Me.txtClientPass.UseSystemPasswordChar = True
    Me.txtClientPass.Visible = False
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(462, 143)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(51, 13)
    Me.Label10.TabIndex = 19
    Me.Label10.Text = "VIP slots:"
    Me.Label10.Visible = False
    '
    'numPrivateSlots
    '
    Me.numPrivateSlots.Location = New System.Drawing.Point(519, 141)
    Me.numPrivateSlots.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
    Me.numPrivateSlots.Name = "numPrivateSlots"
    Me.numPrivateSlots.Size = New System.Drawing.Size(67, 20)
    Me.numPrivateSlots.TabIndex = 18
    Me.numPrivateSlots.Visible = False
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(9, 62)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(67, 13)
    Me.Label9.TabIndex = 17
    Me.Label9.Text = "Game mode:"
    '
    'cmbMode
    '
    Me.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbMode.FormattingEnabled = True
    Me.cmbMode.Items.AddRange(New Object() {"Classic Cooperative", "Cooperative Coin-op", "Cooperative Survival", "Beast Hunt", "Capture The Flag", "Deathmatch", "Instant Kill (Instagib)", "Last Man Standing", "Last Team Standing", "My Burden", "Team Beast Hunt", "Team Deathmatch"})
    Me.cmbMode.Location = New System.Drawing.Point(82, 59)
    Me.cmbMode.Name = "cmbMode"
    Me.cmbMode.Size = New System.Drawing.Size(134, 21)
    Me.cmbMode.TabIndex = 16
    '
    'chkSpawnInvul
    '
    Me.chkSpawnInvul.AutoSize = True
    Me.chkSpawnInvul.Checked = True
    Me.chkSpawnInvul.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkSpawnInvul.Location = New System.Drawing.Point(100, 29)
    Me.chkSpawnInvul.Name = "chkSpawnInvul"
    Me.chkSpawnInvul.Size = New System.Drawing.Size(126, 17)
    Me.chkSpawnInvul.TabIndex = 4
    Me.chkSpawnInvul.Text = "Spawn Invulnerability"
    Me.chkSpawnInvul.UseVisualStyleBackColor = True
    '
    'chkAllowPause
    '
    Me.chkAllowPause.AutoSize = True
    Me.chkAllowPause.Location = New System.Drawing.Point(100, 6)
    Me.chkAllowPause.Name = "chkAllowPause"
    Me.chkAllowPause.Size = New System.Drawing.Size(111, 17)
    Me.chkAllowPause.TabIndex = 3
    Me.chkAllowPause.Text = "Clients may pause"
    Me.chkAllowPause.UseVisualStyleBackColor = True
    '
    'chkAllowArmor
    '
    Me.chkAllowArmor.AutoSize = True
    Me.chkAllowArmor.Checked = True
    Me.chkAllowArmor.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkAllowArmor.Location = New System.Drawing.Point(6, 75)
    Me.chkAllowArmor.Name = "chkAllowArmor"
    Me.chkAllowArmor.Size = New System.Drawing.Size(81, 17)
    Me.chkAllowArmor.TabIndex = 2
    Me.chkAllowArmor.Text = "Allow Armor"
    Me.chkAllowArmor.UseVisualStyleBackColor = True
    '
    'chkAllowHealth
    '
    Me.chkAllowHealth.AutoSize = True
    Me.chkAllowHealth.Checked = True
    Me.chkAllowHealth.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkAllowHealth.Location = New System.Drawing.Point(6, 52)
    Me.chkAllowHealth.Name = "chkAllowHealth"
    Me.chkAllowHealth.Size = New System.Drawing.Size(85, 17)
    Me.chkAllowHealth.TabIndex = 1
    Me.chkAllowHealth.Text = "Allow Health"
    Me.chkAllowHealth.UseVisualStyleBackColor = True
    '
    'chkInfiniteAmmo
    '
    Me.chkInfiniteAmmo.AutoSize = True
    Me.chkInfiniteAmmo.Location = New System.Drawing.Point(6, 6)
    Me.chkInfiniteAmmo.Name = "chkInfiniteAmmo"
    Me.chkInfiniteAmmo.Size = New System.Drawing.Size(88, 17)
    Me.chkInfiniteAmmo.TabIndex = 0
    Me.chkInfiniteAmmo.Text = "Infinite ammo"
    Me.chkInfiniteAmmo.UseVisualStyleBackColor = True
    '
    'CheckBox1
    '
    Me.CheckBox1.AutoSize = True
    Me.CheckBox1.Checked = True
    Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckBox1.Location = New System.Drawing.Point(207, 164)
    Me.CheckBox1.Name = "CheckBox1"
    Me.CheckBox1.Size = New System.Drawing.Size(53, 17)
    Me.CheckBox1.TabIndex = 14
    Me.CheckBox1.Text = "Show"
    Me.CheckBox1.UseVisualStyleBackColor = True
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(11, 168)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(65, 13)
    Me.Label8.TabIndex = 13
    Me.Label8.Text = "Admin Pass:"
    '
    'txtAdminPass
    '
    Me.txtAdminPass.Location = New System.Drawing.Point(82, 165)
    Me.txtAdminPass.Name = "txtAdminPass"
    Me.txtAdminPass.Size = New System.Drawing.Size(119, 20)
    Me.txtAdminPass.TabIndex = 12
    Me.txtAdminPass.UseSystemPasswordChar = True
    '
    'numInterChat
    '
    Me.numInterChat.Location = New System.Drawing.Point(88, 49)
    Me.numInterChat.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
    Me.numInterChat.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.numInterChat.Name = "numInterChat"
    Me.numInterChat.Size = New System.Drawing.Size(45, 20)
    Me.numInterChat.TabIndex = 3
    Me.numInterChat.Value = New Decimal(New Integer() {5, 0, 0, 0})
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(3, 51)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(79, 13)
    Me.Label7.TabIndex = 2
    Me.Label7.Text = "Minute interval:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(3, 7)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(412, 13)
    Me.Label6.TabIndex = 1
    Me.Label6.Text = "Type a message to appear every # minutes. If this is left empty, the feature is d" & _
    "isabled."
    '
    'txtInterChat
    '
    Me.txtInterChat.Location = New System.Drawing.Point(6, 23)
    Me.txtInterChat.Name = "txtInterChat"
    Me.txtInterChat.Size = New System.Drawing.Size(332, 20)
    Me.txtInterChat.TabIndex = 0
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(154, 141)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(66, 13)
    Me.Label5.TabIndex = 10
    Me.Label5.Text = "Max players:"
    '
    'numPlayers
    '
    Me.numPlayers.Location = New System.Drawing.Point(226, 139)
    Me.numPlayers.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
    Me.numPlayers.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
    Me.numPlayers.Name = "numPlayers"
    Me.numPlayers.Size = New System.Drawing.Size(66, 20)
    Me.numPlayers.TabIndex = 9
    Me.numPlayers.Value = New Decimal(New Integer() {6, 0, 0, 0})
    '
    'txtLevel
    '
    Me.txtLevel.Enabled = False
    Me.txtLevel.Location = New System.Drawing.Point(82, 113)
    Me.txtLevel.Name = "txtLevel"
    Me.txtLevel.Size = New System.Drawing.Size(268, 20)
    Me.txtLevel.TabIndex = 8
    '
    'cmbLevel
    '
    Me.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbLevel.FormattingEnabled = True
    Me.cmbLevel.Location = New System.Drawing.Point(82, 86)
    Me.cmbLevel.Name = "cmbLevel"
    Me.cmbLevel.Size = New System.Drawing.Size(268, 21)
    Me.cmbLevel.TabIndex = 7
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(40, 89)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(36, 13)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Level:"
    '
    'txtServername
    '
    Me.txtServername.Location = New System.Drawing.Point(82, 33)
    Me.txtServername.Name = "txtServername"
    Me.txtServername.Size = New System.Drawing.Size(268, 20)
    Me.txtServername.TabIndex = 5
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(6, 36)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(70, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Server name:"
    '
    'lblEnumPort
    '
    Me.lblEnumPort.AutoSize = True
    Me.lblEnumPort.Location = New System.Drawing.Point(176, 9)
    Me.lblEnumPort.Name = "lblEnumPort"
    Me.lblEnumPort.Size = New System.Drawing.Size(123, 13)
    Me.lblEnumPort.TabIndex = 3
    Me.lblEnumPort.Text = "Enumeration port: 27016"
    '
    'numPort
    '
    Me.numPort.Location = New System.Drawing.Point(82, 7)
    Me.numPort.Maximum = New Decimal(New Integer() {30000, 0, 0, 0})
    Me.numPort.Minimum = New Decimal(New Integer() {20000, 0, 0, 0})
    Me.numPort.Name = "numPort"
    Me.numPort.Size = New System.Drawing.Size(88, 20)
    Me.numPort.TabIndex = 2
    Me.numPort.Value = New Decimal(New Integer() {27015, 0, 0, 0})
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(47, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(29, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Port:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(664, 394)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(34, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "v1.06"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(635, 363)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(63, 23)
    Me.Button3.TabIndex = 5
    Me.Button3.Text = "Exit"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'Button4
    '
    Me.Button4.Location = New System.Drawing.Point(553, 363)
    Me.Button4.Name = "Button4"
    Me.Button4.Size = New System.Drawing.Size(76, 23)
    Me.Button4.TabIndex = 6
    Me.Button4.Text = "Save"
    Me.Button4.UseVisualStyleBackColor = True
    '
    'ListBox1
    '
    Me.ListBox1.FormattingEnabled = True
    Me.ListBox1.Location = New System.Drawing.Point(6, 48)
    Me.ListBox1.Name = "ListBox1"
    Me.ListBox1.Size = New System.Drawing.Size(262, 212)
    Me.ListBox1.TabIndex = 7
    '
    'tmrGet
    '
    Me.tmrGet.Interval = 250
    '
    'Button5
    '
    Me.Button5.Location = New System.Drawing.Point(729, 476)
    Me.Button5.Name = "Button5"
    Me.Button5.Size = New System.Drawing.Size(77, 53)
    Me.Button5.TabIndex = 8
    Me.Button5.Text = "Connect Rcon"
    Me.Button5.UseVisualStyleBackColor = True
    Me.Button5.Visible = False
    '
    'Button6
    '
    Me.Button6.Location = New System.Drawing.Point(6, 19)
    Me.Button6.Name = "Button6"
    Me.Button6.Size = New System.Drawing.Size(106, 23)
    Me.Button6.TabIndex = 9
    Me.Button6.Text = "Get Rcon"
    Me.Button6.UseVisualStyleBackColor = True
    '
    'Button7
    '
    Me.Button7.Location = New System.Drawing.Point(729, 535)
    Me.Button7.Name = "Button7"
    Me.Button7.Size = New System.Drawing.Size(77, 53)
    Me.Button7.TabIndex = 10
    Me.Button7.Text = "Disconnect Rcon"
    Me.Button7.UseVisualStyleBackColor = True
    Me.Button7.Visible = False
    '
    'lstPlayers
    '
    Me.lstPlayers.FormattingEnabled = True
    Me.lstPlayers.Location = New System.Drawing.Point(6, 19)
    Me.lstPlayers.Name = "lstPlayers"
    Me.lstPlayers.Size = New System.Drawing.Size(262, 186)
    Me.lstPlayers.TabIndex = 11
    '
    'GroupBox4
    '
    Me.GroupBox4.Controls.Add(Me.Button9)
    Me.GroupBox4.Controls.Add(Me.Button8)
    Me.GroupBox4.Controls.Add(Me.lstPlayers)
    Me.GroupBox4.Location = New System.Drawing.Point(812, 509)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Size = New System.Drawing.Size(93, 79)
    Me.GroupBox4.TabIndex = 12
    Me.GroupBox4.TabStop = False
    Me.GroupBox4.Text = "Players"
    Me.GroupBox4.Visible = False
    '
    'Button9
    '
    Me.Button9.Enabled = False
    Me.Button9.Location = New System.Drawing.Point(84, 209)
    Me.Button9.Name = "Button9"
    Me.Button9.Size = New System.Drawing.Size(72, 23)
    Me.Button9.TabIndex = 14
    Me.Button9.Text = "Ban"
    Me.Button9.UseVisualStyleBackColor = True
    '
    'Button8
    '
    Me.Button8.Enabled = False
    Me.Button8.Location = New System.Drawing.Point(6, 209)
    Me.Button8.Name = "Button8"
    Me.Button8.Size = New System.Drawing.Size(72, 23)
    Me.Button8.TabIndex = 14
    Me.Button8.Text = "Kick"
    Me.Button8.UseVisualStyleBackColor = True
    '
    'grpDebug
    '
    Me.grpDebug.Controls.Add(Me.ListBox1)
    Me.grpDebug.Controls.Add(Me.Button6)
    Me.grpDebug.Location = New System.Drawing.Point(896, 392)
    Me.grpDebug.Name = "grpDebug"
    Me.grpDebug.Size = New System.Drawing.Size(93, 111)
    Me.grpDebug.TabIndex = 13
    Me.grpDebug.TabStop = False
    Me.grpDebug.Text = "Debugging"
    Me.grpDebug.Visible = False
    '
    'lblStatus
    '
    Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblStatus.Location = New System.Drawing.Point(98, 391)
    Me.lblStatus.Name = "lblStatus"
    Me.lblStatus.Size = New System.Drawing.Size(560, 21)
    Me.lblStatus.TabIndex = 14
    Me.lblStatus.Text = "Ready to start."
    Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Button10
    '
    Me.Button10.Location = New System.Drawing.Point(469, 363)
    Me.Button10.Name = "Button10"
    Me.Button10.Size = New System.Drawing.Size(78, 23)
    Me.Button10.TabIndex = 15
    Me.Button10.Text = "Updates"
    Me.Button10.UseVisualStyleBackColor = True
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Controls.Add(Me.TabPage3)
    Me.TabControl1.Controls.Add(Me.TabPage5)
    Me.TabControl1.Location = New System.Drawing.Point(12, 12)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(686, 347)
    Me.TabControl1.TabIndex = 16
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.numMinimal)
    Me.TabPage1.Controls.Add(Me.Label25)
    Me.TabPage1.Controls.Add(Me.Label24)
    Me.TabPage1.Controls.Add(Me.Label23)
    Me.TabPage1.Controls.Add(Me.numMaxClientBPS)
    Me.TabPage1.Controls.Add(Me.Label22)
    Me.TabPage1.Controls.Add(Me.numFPS)
    Me.TabPage1.Controls.Add(Me.Label21)
    Me.TabPage1.Controls.Add(Me.numTimeLimit)
    Me.TabPage1.Controls.Add(Me.numFragLimit)
    Me.TabPage1.Controls.Add(Me.Label20)
    Me.TabPage1.Controls.Add(Me.Label19)
    Me.TabPage1.Controls.Add(Me.Label11)
    Me.TabPage1.Controls.Add(Me.Label1)
    Me.TabPage1.Controls.Add(Me.txtClientPass)
    Me.TabPage1.Controls.Add(Me.numPort)
    Me.TabPage1.Controls.Add(Me.Label10)
    Me.TabPage1.Controls.Add(Me.lblEnumPort)
    Me.TabPage1.Controls.Add(Me.numPrivateSlots)
    Me.TabPage1.Controls.Add(Me.Label2)
    Me.TabPage1.Controls.Add(Me.Label9)
    Me.TabPage1.Controls.Add(Me.txtServername)
    Me.TabPage1.Controls.Add(Me.cmbMode)
    Me.TabPage1.Controls.Add(Me.Label4)
    Me.TabPage1.Controls.Add(Me.cmbLevel)
    Me.TabPage1.Controls.Add(Me.CheckBox1)
    Me.TabPage1.Controls.Add(Me.txtLevel)
    Me.TabPage1.Controls.Add(Me.Label8)
    Me.TabPage1.Controls.Add(Me.numPlayers)
    Me.TabPage1.Controls.Add(Me.txtAdminPass)
    Me.TabPage1.Controls.Add(Me.Label5)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(678, 321)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "General"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'numMinimal
    '
    Me.numMinimal.Location = New System.Drawing.Point(82, 139)
    Me.numMinimal.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
    Me.numMinimal.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
    Me.numMinimal.Name = "numMinimal"
    Me.numMinimal.Size = New System.Drawing.Size(66, 20)
    Me.numMinimal.TabIndex = 32
    Me.numMinimal.Value = New Decimal(New Integer() {2, 0, 0, 0})
    '
    'Label25
    '
    Me.Label25.AutoSize = True
    Me.Label25.Location = New System.Drawing.Point(13, 141)
    Me.Label25.Name = "Label25"
    Me.Label25.Size = New System.Drawing.Size(63, 13)
    Me.Label25.TabIndex = 33
    Me.Label25.Text = "Min players:"
    '
    'Label24
    '
    Me.Label24.AutoSize = True
    Me.Label24.Location = New System.Drawing.Point(155, 271)
    Me.Label24.Name = "Label24"
    Me.Label24.Size = New System.Drawing.Size(161, 13)
    Me.Label24.TabIndex = 31
    Me.Label24.Text = "Recommended is 11000 or 6000"
    '
    'Label23
    '
    Me.Label23.AutoSize = True
    Me.Label23.Location = New System.Drawing.Point(155, 245)
    Me.Label23.Name = "Label23"
    Me.Label23.Size = New System.Drawing.Size(131, 13)
    Me.Label23.TabIndex = 30
    Me.Label23.Text = "Recommended is 100-200"
    '
    'numMaxClientBPS
    '
    Me.numMaxClientBPS.Location = New System.Drawing.Point(82, 269)
    Me.numMaxClientBPS.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
    Me.numMaxClientBPS.Minimum = New Decimal(New Integer() {3000, 0, 0, 0})
    Me.numMaxClientBPS.Name = "numMaxClientBPS"
    Me.numMaxClientBPS.Size = New System.Drawing.Size(67, 20)
    Me.numMaxClientBPS.TabIndex = 29
    Me.numMaxClientBPS.Value = New Decimal(New Integer() {11000, 0, 0, 0})
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.Location = New System.Drawing.Point(21, 271)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(55, 13)
    Me.Label22.TabIndex = 28
    Me.Label22.Text = "Max BPR:"
    '
    'numFPS
    '
    Me.numFPS.Location = New System.Drawing.Point(82, 243)
    Me.numFPS.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
    Me.numFPS.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
    Me.numFPS.Name = "numFPS"
    Me.numFPS.Size = New System.Drawing.Size(67, 20)
    Me.numFPS.TabIndex = 27
    Me.numFPS.Value = New Decimal(New Integer() {100, 0, 0, 0})
    '
    'Label21
    '
    Me.Label21.AutoSize = True
    Me.Label21.Location = New System.Drawing.Point(46, 245)
    Me.Label21.Name = "Label21"
    Me.Label21.Size = New System.Drawing.Size(30, 13)
    Me.Label21.TabIndex = 26
    Me.Label21.Text = "FPS:"
    '
    'numTimeLimit
    '
    Me.numTimeLimit.Location = New System.Drawing.Point(82, 217)
    Me.numTimeLimit.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
    Me.numTimeLimit.Name = "numTimeLimit"
    Me.numTimeLimit.Size = New System.Drawing.Size(67, 20)
    Me.numTimeLimit.TabIndex = 25
    '
    'numFragLimit
    '
    Me.numFragLimit.Location = New System.Drawing.Point(82, 191)
    Me.numFragLimit.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
    Me.numFragLimit.Name = "numFragLimit"
    Me.numFragLimit.Size = New System.Drawing.Size(67, 20)
    Me.numFragLimit.TabIndex = 24
    '
    'Label20
    '
    Me.Label20.AutoSize = True
    Me.Label20.Location = New System.Drawing.Point(24, 219)
    Me.Label20.Name = "Label20"
    Me.Label20.Size = New System.Drawing.Size(53, 13)
    Me.Label20.TabIndex = 23
    Me.Label20.Text = "Time limit:"
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.Location = New System.Drawing.Point(26, 193)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(51, 13)
    Me.Label19.TabIndex = 22
    Me.Label19.Text = "Frag limit:"
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.chkDisableVoting)
    Me.TabPage2.Controls.Add(Me.chkCheats)
    Me.TabPage2.Controls.Add(Me.lblVal2)
    Me.TabPage2.Controls.Add(Me.lblVal1)
    Me.TabPage2.Controls.Add(Me.Label15)
    Me.TabPage2.Controls.Add(Me.Label14)
    Me.TabPage2.Controls.Add(Me.numExtraEnemyStrengthPerPlayer)
    Me.TabPage2.Controls.Add(Me.numExtraEnemyStrength)
    Me.TabPage2.Controls.Add(Me.Label13)
    Me.TabPage2.Controls.Add(Me.cmbDifficulty)
    Me.TabPage2.Controls.Add(Me.Label12)
    Me.TabPage2.Controls.Add(Me.chkRespawnInPlace)
    Me.TabPage2.Controls.Add(Me.chkFriendlyFire)
    Me.TabPage2.Controls.Add(Me.chkExtraEnemies)
    Me.TabPage2.Controls.Add(Me.chkWeaponsStay)
    Me.TabPage2.Controls.Add(Me.chkAmmoStays)
    Me.TabPage2.Controls.Add(Me.chkArmorStays)
    Me.TabPage2.Controls.Add(Me.chkHealthStays)
    Me.TabPage2.Controls.Add(Me.chkSpawnInvul)
    Me.TabPage2.Controls.Add(Me.chkInfiniteAmmo)
    Me.TabPage2.Controls.Add(Me.chkAllowPause)
    Me.TabPage2.Controls.Add(Me.chkAllowHealth)
    Me.TabPage2.Controls.Add(Me.chkAllowArmor)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(678, 321)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Game options"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'chkDisableVoting
    '
    Me.chkDisableVoting.AutoSize = True
    Me.chkDisableVoting.Location = New System.Drawing.Point(6, 229)
    Me.chkDisableVoting.Name = "chkDisableVoting"
    Me.chkDisableVoting.Size = New System.Drawing.Size(93, 17)
    Me.chkDisableVoting.TabIndex = 22
    Me.chkDisableVoting.Text = "Disable voting"
    Me.chkDisableVoting.UseVisualStyleBackColor = True
    '
    'chkCheats
    '
    Me.chkCheats.AutoSize = True
    Me.chkCheats.Location = New System.Drawing.Point(100, 167)
    Me.chkCheats.Name = "chkCheats"
    Me.chkCheats.Size = New System.Drawing.Size(59, 17)
    Me.chkCheats.TabIndex = 21
    Me.chkCheats.Text = "Cheats"
    Me.chkCheats.UseVisualStyleBackColor = True
    '
    'lblVal2
    '
    Me.lblVal2.AutoSize = True
    Me.lblVal2.Location = New System.Drawing.Point(368, 116)
    Me.lblVal2.Name = "lblVal2"
    Me.lblVal2.Size = New System.Drawing.Size(21, 13)
    Me.lblVal2.TabIndex = 20
    Me.lblVal2.Text = "0%"
    '
    'lblVal1
    '
    Me.lblVal1.AutoSize = True
    Me.lblVal1.Location = New System.Drawing.Point(368, 65)
    Me.lblVal1.Name = "lblVal1"
    Me.lblVal1.Size = New System.Drawing.Size(21, 13)
    Me.lblVal1.TabIndex = 19
    Me.lblVal1.Text = "0%"
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(304, 97)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(59, 13)
    Me.Label15.TabIndex = 18
    Me.Label15.Text = "(per player)"
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(254, 84)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(109, 13)
    Me.Label14.TabIndex = 17
    Me.Label14.Text = "Extra enemy strength:"
    '
    'numExtraEnemyStrengthPerPlayer
    '
    Me.numExtraEnemyStrengthPerPlayer.BackColor = System.Drawing.Color.White
    Me.numExtraEnemyStrengthPerPlayer.Location = New System.Drawing.Point(371, 84)
    Me.numExtraEnemyStrengthPerPlayer.Maximum = 400
    Me.numExtraEnemyStrengthPerPlayer.Name = "numExtraEnemyStrengthPerPlayer"
    Me.numExtraEnemyStrengthPerPlayer.Size = New System.Drawing.Size(301, 45)
    Me.numExtraEnemyStrengthPerPlayer.TabIndex = 16
    Me.numExtraEnemyStrengthPerPlayer.TickFrequency = 25
    '
    'numExtraEnemyStrength
    '
    Me.numExtraEnemyStrength.BackColor = System.Drawing.Color.White
    Me.numExtraEnemyStrength.Location = New System.Drawing.Point(371, 33)
    Me.numExtraEnemyStrength.Maximum = 400
    Me.numExtraEnemyStrength.Name = "numExtraEnemyStrength"
    Me.numExtraEnemyStrength.Size = New System.Drawing.Size(301, 45)
    Me.numExtraEnemyStrength.TabIndex = 15
    Me.numExtraEnemyStrength.TickFrequency = 25
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(254, 33)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(109, 13)
    Me.Label13.TabIndex = 14
    Me.Label13.Text = "Extra enemy strength:"
    '
    'cmbDifficulty
    '
    Me.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbDifficulty.FormattingEnabled = True
    Me.cmbDifficulty.Items.AddRange(New Object() {"Tourist", "Easy", "Normal", "Hard", "Serious", "Mental"})
    Me.cmbDifficulty.Location = New System.Drawing.Point(371, 6)
    Me.cmbDifficulty.Name = "cmbDifficulty"
    Me.cmbDifficulty.Size = New System.Drawing.Size(135, 21)
    Me.cmbDifficulty.TabIndex = 13
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(313, 9)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(50, 13)
    Me.Label12.TabIndex = 12
    Me.Label12.Text = "Difficulty:"
    '
    'chkRespawnInPlace
    '
    Me.chkRespawnInPlace.AutoSize = True
    Me.chkRespawnInPlace.Checked = True
    Me.chkRespawnInPlace.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkRespawnInPlace.Location = New System.Drawing.Point(100, 52)
    Me.chkRespawnInPlace.Name = "chkRespawnInPlace"
    Me.chkRespawnInPlace.Size = New System.Drawing.Size(111, 17)
    Me.chkRespawnInPlace.TabIndex = 11
    Me.chkRespawnInPlace.Text = "Respawn in place"
    Me.chkRespawnInPlace.UseVisualStyleBackColor = True
    '
    'chkFriendlyFire
    '
    Me.chkFriendlyFire.AutoSize = True
    Me.chkFriendlyFire.Location = New System.Drawing.Point(100, 121)
    Me.chkFriendlyFire.Name = "chkFriendlyFire"
    Me.chkFriendlyFire.Size = New System.Drawing.Size(82, 17)
    Me.chkFriendlyFire.TabIndex = 10
    Me.chkFriendlyFire.Text = "Friendly Fire"
    Me.chkFriendlyFire.UseVisualStyleBackColor = True
    '
    'chkExtraEnemies
    '
    Me.chkExtraEnemies.AutoSize = True
    Me.chkExtraEnemies.Checked = True
    Me.chkExtraEnemies.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkExtraEnemies.Location = New System.Drawing.Point(100, 98)
    Me.chkExtraEnemies.Name = "chkExtraEnemies"
    Me.chkExtraEnemies.Size = New System.Drawing.Size(93, 17)
    Me.chkExtraEnemies.TabIndex = 9
    Me.chkExtraEnemies.Text = "Extra Enemies"
    Me.chkExtraEnemies.UseVisualStyleBackColor = True
    '
    'chkWeaponsStay
    '
    Me.chkWeaponsStay.AutoSize = True
    Me.chkWeaponsStay.Checked = True
    Me.chkWeaponsStay.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkWeaponsStay.Location = New System.Drawing.Point(6, 190)
    Me.chkWeaponsStay.Name = "chkWeaponsStay"
    Me.chkWeaponsStay.Size = New System.Drawing.Size(96, 17)
    Me.chkWeaponsStay.TabIndex = 8
    Me.chkWeaponsStay.Text = "Weapons Stay"
    Me.chkWeaponsStay.UseVisualStyleBackColor = True
    '
    'chkAmmoStays
    '
    Me.chkAmmoStays.AutoSize = True
    Me.chkAmmoStays.Checked = True
    Me.chkAmmoStays.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkAmmoStays.Location = New System.Drawing.Point(6, 167)
    Me.chkAmmoStays.Name = "chkAmmoStays"
    Me.chkAmmoStays.Size = New System.Drawing.Size(84, 17)
    Me.chkAmmoStays.TabIndex = 7
    Me.chkAmmoStays.Text = "Ammo Stays"
    Me.chkAmmoStays.UseVisualStyleBackColor = True
    '
    'chkArmorStays
    '
    Me.chkArmorStays.AutoSize = True
    Me.chkArmorStays.Checked = True
    Me.chkArmorStays.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkArmorStays.Location = New System.Drawing.Point(6, 144)
    Me.chkArmorStays.Name = "chkArmorStays"
    Me.chkArmorStays.Size = New System.Drawing.Size(82, 17)
    Me.chkArmorStays.TabIndex = 6
    Me.chkArmorStays.Text = "Armor Stays"
    Me.chkArmorStays.UseVisualStyleBackColor = True
    '
    'chkHealthStays
    '
    Me.chkHealthStays.AutoSize = True
    Me.chkHealthStays.Checked = True
    Me.chkHealthStays.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkHealthStays.Location = New System.Drawing.Point(6, 121)
    Me.chkHealthStays.Name = "chkHealthStays"
    Me.chkHealthStays.Size = New System.Drawing.Size(86, 17)
    Me.chkHealthStays.TabIndex = 5
    Me.chkHealthStays.Text = "Health Stays"
    Me.chkHealthStays.UseVisualStyleBackColor = True
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.textExec)
    Me.TabPage3.Controls.Add(Me.Label16)
    Me.TabPage3.Controls.Add(Me.checkExec)
    Me.TabPage3.Controls.Add(Me.numInterChat)
    Me.TabPage3.Controls.Add(Me.Label6)
    Me.TabPage3.Controls.Add(Me.Label7)
    Me.TabPage3.Controls.Add(Me.txtInterChat)
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Size = New System.Drawing.Size(678, 321)
    Me.TabPage3.TabIndex = 2
    Me.TabPage3.Text = "Extra"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'textExec
    '
    Me.textExec.Location = New System.Drawing.Point(58, 98)
    Me.textExec.Name = "textExec"
    Me.textExec.Size = New System.Drawing.Size(195, 20)
    Me.textExec.TabIndex = 6
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(16, 101)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(36, 13)
    Me.Label16.TabIndex = 5
    Me.Label16.Text = "+exec"
    '
    'checkExec
    '
    Me.checkExec.AutoSize = True
    Me.checkExec.Location = New System.Drawing.Point(6, 75)
    Me.checkExec.Name = "checkExec"
    Me.checkExec.Size = New System.Drawing.Size(522, 17)
    Me.checkExec.TabIndex = 4
    Me.checkExec.Text = "Run +exec with a different lua file (this disables above message feature, see Eng" & _
    "lish readme for more info)"
    Me.checkExec.UseVisualStyleBackColor = True
    '
    'TabPage5
    '
    Me.TabPage5.Controls.Add(Me.GroupBox1)
    Me.TabPage5.Location = New System.Drawing.Point(4, 22)
    Me.TabPage5.Name = "TabPage5"
    Me.TabPage5.Size = New System.Drawing.Size(678, 321)
    Me.TabPage5.TabIndex = 4
    Me.TabPage5.Text = "Rcon Console"
    Me.TabPage5.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.txtRconInput)
    Me.GroupBox1.Controls.Add(Me.txtRconOutput)
    Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(672, 315)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Console"
    '
    'txtRconInput
    '
    Me.txtRconInput.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtRconInput.Location = New System.Drawing.Point(6, 289)
    Me.txtRconInput.Name = "txtRconInput"
    Me.txtRconInput.Size = New System.Drawing.Size(660, 18)
    Me.txtRconInput.TabIndex = 1
    '
    'txtRconOutput
    '
    Me.txtRconOutput.BackColor = System.Drawing.Color.White
    Me.txtRconOutput.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtRconOutput.Location = New System.Drawing.Point(6, 19)
    Me.txtRconOutput.Multiline = True
    Me.txtRconOutput.Name = "txtRconOutput"
    Me.txtRconOutput.ReadOnly = True
    Me.txtRconOutput.Size = New System.Drawing.Size(660, 264)
    Me.txtRconOutput.TabIndex = 0
    '
    'tmrSleep
    '
    Me.tmrSleep.Interval = 5000
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(704, 416)
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.Button10)
    Me.Controls.Add(Me.lblStatus)
    Me.Controls.Add(Me.grpDebug)
    Me.Controls.Add(Me.GroupBox4)
    Me.Controls.Add(Me.Button7)
    Me.Controls.Add(Me.Button5)
    Me.Controls.Add(Me.Button4)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.LinkLabel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "Form1"
    Me.Text = "Server GUI HD: The Second Encounter"
    CType(Me.numPrivateSlots, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numInterChat, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numPlayers, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numPort, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox4.ResumeLayout(False)
    Me.grpDebug.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage1.PerformLayout()
    CType(Me.numMinimal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numMaxClientBPS, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numFPS, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numTimeLimit, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numFragLimit, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPage2.ResumeLayout(False)
    Me.TabPage2.PerformLayout()
    CType(Me.numExtraEnemyStrengthPerPlayer, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.numExtraEnemyStrength, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPage3.ResumeLayout(False)
    Me.TabPage3.PerformLayout()
    Me.TabPage5.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents lblEnumPort As System.Windows.Forms.Label
  Friend WithEvents numPort As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtServername As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents txtLevel As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents numPlayers As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtInterChat As System.Windows.Forms.TextBox
  Friend WithEvents numInterChat As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Button4 As System.Windows.Forms.Button
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtAdminPass As System.Windows.Forms.TextBox
  Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
  Friend WithEvents chkInfiniteAmmo As System.Windows.Forms.CheckBox
  Friend WithEvents chkAllowArmor As System.Windows.Forms.CheckBox
  Friend WithEvents chkAllowHealth As System.Windows.Forms.CheckBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents cmbMode As System.Windows.Forms.ComboBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents numPrivateSlots As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents txtClientPass As System.Windows.Forms.TextBox
  Friend WithEvents chkAllowPause As System.Windows.Forms.CheckBox
  Friend WithEvents chkSpawnInvul As System.Windows.Forms.CheckBox
  Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
  Friend WithEvents tmrGet As System.Windows.Forms.Timer
  Friend WithEvents Button5 As System.Windows.Forms.Button
  Friend WithEvents Button6 As System.Windows.Forms.Button
  Friend WithEvents Button7 As System.Windows.Forms.Button
  Friend WithEvents lstPlayers As System.Windows.Forms.ListBox
  Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
  Friend WithEvents grpDebug As System.Windows.Forms.GroupBox
  Friend WithEvents Button9 As System.Windows.Forms.Button
  Friend WithEvents Button8 As System.Windows.Forms.Button
  Friend WithEvents lblStatus As System.Windows.Forms.Label
  Friend WithEvents Button10 As System.Windows.Forms.Button
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents chkAmmoStays As System.Windows.Forms.CheckBox
  Friend WithEvents chkArmorStays As System.Windows.Forms.CheckBox
  Friend WithEvents chkHealthStays As System.Windows.Forms.CheckBox
  Friend WithEvents chkWeaponsStay As System.Windows.Forms.CheckBox
  Friend WithEvents chkRespawnInPlace As System.Windows.Forms.CheckBox
  Friend WithEvents chkFriendlyFire As System.Windows.Forms.CheckBox
  Friend WithEvents chkExtraEnemies As System.Windows.Forms.CheckBox
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents cmbDifficulty As System.Windows.Forms.ComboBox
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents numExtraEnemyStrength As System.Windows.Forms.TrackBar
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents numExtraEnemyStrengthPerPlayer As System.Windows.Forms.TrackBar
  Friend WithEvents lblVal2 As System.Windows.Forms.Label
  Friend WithEvents lblVal1 As System.Windows.Forms.Label
  Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents txtRconInput As System.Windows.Forms.TextBox
  Friend WithEvents txtRconOutput As System.Windows.Forms.TextBox
  Friend WithEvents chkCheats As System.Windows.Forms.CheckBox
  Friend WithEvents tmrSleep As System.Windows.Forms.Timer
  Friend WithEvents numTimeLimit As System.Windows.Forms.NumericUpDown
  Friend WithEvents numFragLimit As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label20 As System.Windows.Forms.Label
  Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents numFPS As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label21 As System.Windows.Forms.Label
  Friend WithEvents Label24 As System.Windows.Forms.Label
  Friend WithEvents Label23 As System.Windows.Forms.Label
  Friend WithEvents numMaxClientBPS As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label22 As System.Windows.Forms.Label
  Friend WithEvents numMinimal As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label25 As System.Windows.Forms.Label
  Friend WithEvents chkDisableVoting As System.Windows.Forms.CheckBox
  Friend WithEvents checkExec As System.Windows.Forms.CheckBox
  Friend WithEvents textExec As System.Windows.Forms.TextBox
  Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
