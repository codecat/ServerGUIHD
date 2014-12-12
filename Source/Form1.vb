Imports System.Net.Sockets
Imports System.Text
Imports System.IO

Public Class Form1

  Const Debug As Boolean = False      ' Debugging stuff, mainly for my local PC, always leave to false for public release
  Const Internal As Boolean = False   ' Internal test stuff, leave to false for public release

  Dim WithEvents ServerProcess As Process

  Dim tcpClient As New System.Net.Sockets.TcpClient()
  Dim networkStream As NetworkStream
  Dim ignoredFirst As Boolean
  Dim ignoreLast As String
  Dim streamReader As IO.StreamReader
  Dim rconConnected As Boolean

  Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    System.Diagnostics.Process.Start("http://serioussam.net/")
  End Sub

  Private Sub numPort_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numPort.ValueChanged
    lblEnumPort.Text = "Enumeration port: " & numPort.Value + 1
  End Sub

  Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    Me.Close()
  End Sub

  Private Sub cmbLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLevel.SelectedIndexChanged
    If cmbLevel.SelectedIndex = cmbLevel.Items.Count - 1 Then
      txtLevel.Enabled = True
    Else
      txtLevel.Enabled = False
      txtLevel.Text = "Content/SeriousSamHD/Levels/"
    End If
  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Dim Args As String = ""

    Args += "+port " & numPort.Value

    If txtServername.Text <> "" Then
      Args += " +sessionname """ & txtServername.Text & """"
    End If

    Args += " +fps " & numFPS.Value

    Dim Level As String = ""
    If cmbMode.SelectedIndex = 0 Or cmbMode.SelectedIndex = 1 Or cmbMode.SelectedIndex = 3 Or cmbMode.SelectedIndex = 10 Then
      Select Case cmbLevel.SelectedIndex
        Case 0
          Level = "Content/SeriousSamHD/Levels/01_SouthAmerica/1_01_Palenque.wld"
        Case 1
          Level = "Content/SeriousSamHD/Levels/01_SouthAmerica/1_02_Palenque.wld"
        Case 2
          Level = "Content/SeriousSamHD/Levels/01_SouthAmerica/1_03_Teotihuacan.wld"
        Case 3
          Level = "Content/SeriousSamHD/Levels/01_SouthAmerica/1_04_Teotihuacan.wld"
        Case 4
          Level = "Content/SeriousSamHD/Levels/01_SouthAmerica/1_05_Teotihuacan.wld"
        Case 5
          Level = "Content/SeriousSamHD/Levels/02_Persia/2_01_Ziggurrat.wld"
        Case 6
          Level = "Content/SeriousSamHD/Levels/02_Persia/2_02_Persepolis.wld"
        Case 7
          Level = "Content/SeriousSamHD/Levels/02_Persia/2_03_Persepolis.wld"
        Case 8
          Level = "Content/SeriousSamHD/Levels/02_Persia/2_04_TowerOfBabylon.wld"
        Case 9
          Level = "Content/SeriousSamHD/Levels/03_Medieval/3_01_GothicCastle.wld"
        Case 10
          Level = "Content/SeriousSamHD/Levels/03_Medieval/3_02_LandOfDamned.wld"
        Case 11
          Level = "Content/SeriousSamHD/Levels/03_Medieval/3_03_CorridorOfDeath.wld"
        Case 12
          Level = "Content/SeriousSamHD/Levels/Z1_DemoPalenque/PalenqueDemo.wld"

        Case 13
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_01_Hatshepsut.wld"
        Case 14
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_02_SandCanyon.wld"
        Case 15
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_03_TombOfRamses.wld"
        Case 16
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_04_ValleyOfTheKings.wld"
        Case 17
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_05_MoonMountains.wld"
        Case 18
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_06_Oasis.wld"
        Case 19
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_07_Dunes.wld"
        Case 20
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_08_Suburbs.wld"
        Case 21
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_09_Sewers.wld"
        Case 22
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_10_Metropolis.wld"
        Case 23
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_11_AlleyOfSphinxes.wld"
        Case 24
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_12_Karnak.wld"
        Case 25
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_13_Luxor.wld"
        Case 26
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_14_SacredYards.wld"
        Case 27
          Level = "Content/SeriousSamHD/Levels/00_Egypt/0_15_TheGreatPyramid.wld"
        Case 28
          Level = "Content/SeriousSamHD/Levels/Z0_DemoKarnak/KarnakDemo.wld"

        Case 29
          Level = txtLevel.Text
      End Select
    ElseIf cmbMode.SelectedIndex = 5 Or cmbMode.SelectedIndex = 6 Or cmbMode.SelectedIndex = 7 Or cmbMode.SelectedIndex = 8 Or cmbMode.SelectedIndex = 9 Or cmbMode.SelectedIndex = 11 Then
      Select Case cmbLevel.SelectedIndex
        Case 0
          Level = "Content/SeriousSamHD/Levels/Z5_Other/BrkeenChevap.wld"
        Case 1
          Level = "Content/SeriousSamHD/Levels/Z5_Other/Fortress.wld"
        Case 2
          Level = "Content/SeriousSamHD/Levels/Z5_Other/Hole.wld"
        Case 3
          Level = "Content/SeriousSamHD/Levels/Z5_Other/JumpOver.wld"
        Case 4
          Level = "Content/SeriousSamHD/Levels/Z5_Other/MedievalRage.wld"
        Case 5
          Level = "Content/SeriousSamHD/Levels/Z5_Other/RoyalPurgatory.wld"
        Case 6
          Level = "Content/SeriousSamHD/Levels/Z5_Other/SunPalace.wld"
        Case 7
          Level = "Content/SeriousSamHD/Levels/Z5_Other/TheLostTomb.wld"
        Case 8
          Level = "Content/SeriousSamHD/Levels/Z5_Other/WeGotSkullsNBonesToo.wld"
        Case 9
          Level = "Content/SeriousSamHD/Levels/Z5_Other/Yodeller.wld"

        Case 10
          Level = "Content/SeriousSamHD/Levels/Z3_Other/DesertTemple.wld"
        Case 11
          Level = "Content/SeriousSamHD/Levels/Z3_Other/Flood.wld"
        Case 12
          Level = "Content/SeriousSamHD/Levels/Z3_Other/Gvide.wld"
        Case 13
          Level = "Content/SeriousSamHD/Levels/Z3_Other/HoodlumsBackyard.wld"
        Case 14
          Level = "Content/SeriousSamHD/Levels/Z3_Other/Horus_Web.wld"
        Case 15
          Level = "Content/SeriousSamHD/Levels/Z3_Other/LittleTrouble.wld"
        Case 16
          Level = "Content/SeriousSamHD/Levels/Z3_Other/SimplyOne.wld"

        Case 17
          Level = txtLevel.Text
      End Select
    ElseIf cmbMode.SelectedIndex = 4 Then
      Select Case cmbLevel.SelectedIndex
        Case 0
          Level = "Content/SeriousSamHD/Levels/Z5_Other/AshesToAshes.wld"
        Case 1
          Level = "Content/SeriousSamHD/Levels/Z5_Other/CTF_LittleTrouble.wld"
        Case 2
          Level = "Content/SeriousSamHD/Levels/Z5_Other/Flagrante.wld"
        Case 3
          Level = "Content/SeriousSamHD/Levels/Z5_Other/FortWars.wld"
        Case 4
          Level = txtLevel.Text
      End Select
    ElseIf cmbMode.SelectedIndex = 2 Then
      Select Case cmbLevel.SelectedIndex
        Case 0
          Level = "Content/SeriousSamHD/Levels/Z5_Other/BearCity.wld"
        Case 1
          Level = "Content/SeriousSamHD/Levels/Z5_Other/SV_BendOnSand.wld"
        Case 2
          Level = "Content/SeriousSamHD/Levels/Z5_Other/SV_DeathFromAbove.wld"
        Case 3
          Level = "Content/SeriousSamHD/Levels/Z5_Other/SV_DeepHole.wld"
        Case 4
          Level = "Content/SeriousSamHD/Levels/Z5_Other/SV_GreenField.wld"
        Case 5
          Level = "Content/SeriousSamHD/Levels/Z5_Other/SV_Icelander.wld"
        Case 6
          Level = "Content/SeriousSamHD/Levels/Z5_Other/SV_KleerBase.wld"
        Case 7
          Level = txtLevel.Text
      End Select
    End If
    Args += " +level """ & Level & """"

    Dim Filename As String
    If Not Debug Then
      Filename = My.Application.Info.DirectoryPath & "/Content/SeriousSamHD_TSE/SGUIHD.lua"
    Else
      Filename = "C:/Program Files (x86)/Steam/steamapps/common/serious sam hd the first encounter/Content/SeriousSamHD_TSE/SGUIHD.lua"
    End If
    If txtInterChat.Text <> "" Then
      Dim Script As String = "Wait(Delay(60));" & vbCrLf & _
                             "globals.interChat = function()" & vbCrLf & _
                             "    chatSay(""" & txtInterChat.Text & """);" & vbCrLf & _
                             "    Wait(Delay(" & numInterChat.Value * 60 & "));" & vbCrLf & _
                             "    globals.interChat();" & vbCrLf & _
                             "end" & vbCrLf & _
                             "globals.interChat();" & vbCrLf & vbCrLf
      My.Computer.FileSystem.WriteAllText(Filename, Script, False)
    End If

    Args += " +gam_bCustomizedDifficulty 1"

    If cmbMode.SelectedIndex = 0 Then
      Args += " +gamemode Cooperative"
    ElseIf cmbMode.SelectedIndex = 1 Then
      Args += " +gamemode CooperativeCoinOp"
    ElseIf cmbMode.SelectedIndex = 2 Then
      Args += " +gamemode TeamSurvival"
    ElseIf cmbMode.SelectedIndex = 3 Then
      Args += " +gamemode BeastHunt"
    ElseIf cmbMode.SelectedIndex = 4 Then
      Args += " +gamemode CaptureTheFlag"
    ElseIf cmbMode.SelectedIndex = 5 Then
      Args += " +gamemode Deathmatch"
    ElseIf cmbMode.SelectedIndex = 6 Then
      Args += " +gamemode InstantKill"
    ElseIf cmbMode.SelectedIndex = 7 Then
      Args += " +gamemode LastManStanding"
    ElseIf cmbMode.SelectedIndex = 8 Then
      Args += " +gamemode LastTeamStanding"
    ElseIf cmbMode.SelectedIndex = 9 Then
      Args += " +gamemode MyBurden"
    ElseIf cmbMode.SelectedIndex = 10 Then
      Args += " +gamemode TeamBeastHunt"
    ElseIf cmbMode.SelectedIndex = 11 Then
      Args += " +gamemode TeamDeathmatch"
    End If

    If txtAdminPass.Text <> "" Then
      Args += " +rcts_strAdminPassword """ & txtAdminPass.Text & """"
      Args += " +rcts_strWelcomeNote ""Server GUI HD Rcon"""
    End If

    Args += " +gam_ctMinPlayers " & numMinimal.Value
    Args += " +gam_ctMaxPlayers " & numPlayers.Value

    If numPrivateSlots.Value <> 0 Then
      Args += " +gam_ctPrivateSlots " & numPrivateSlots.Value
    End If

    If chkInfiniteAmmo.Checked Then
      Args += " +gam_bInfiniteAmmo 1"
    Else
      Args += " +gam_bInfiniteAmmo 0"
    End If

    If chkAllowHealth.Checked Then
      Args += " +gam_bAllowHealth 1"
    Else
      Args += " +gam_bAllowHealth 0"
    End If

    If chkAllowArmor.Checked Then
      Args += " +gam_bAllowArmor 1"
    Else
      Args += " +gam_bAllowArmor 0"
    End If

    If chkSpawnInvul.Checked Then
      Args += " +gam_bInvulnerableAfterSpawning 1"
    Else
      Args += " +gam_bInvulnerableAfterSpawning 0"
    End If

    If chkHealthStays.Checked Then
      Args += " +gam_bHealthStays 1"
    Else
      Args += " +gam_bHealthStays 0"
    End If

    If chkArmorStays.Checked Then
      Args += " +gam_bArmorStays 1"
    Else
      Args += " +gam_bArmorStays 0"
    End If

    If chkAmmoStays.Checked Then
      Args += " +gam_bAmmoStays 1"
    Else
      Args += " +gam_bAmmoStays 0"
    End If

    If chkWeaponsStay.Checked Then
      Args += " +gam_bWeaponsStay 1"
    Else
      Args += " +gam_bWeaponsStay 0"
    End If

    If chkFriendlyFire.Checked Then
      Args += " +gam_bFriendlyFire 1"
    Else
      Args += " +gam_bFriendlyFire 0"
    End If

    If chkRespawnInPlace.Checked Then
      Args += " +gam_bRespawnInPlace 1"
    Else
      Args += " +gam_bRespawnInPlace 0"
    End If

    If chkCheats.Checked Then
      Args += " +cht_bEnableCheats 2"
    Else
      Args += " +cht_bEnableCheats 0"
    End If

    Args += " +gam_gdDifficulty " & (cmbDifficulty.SelectedIndex + 1)

    Args += " +gam_iExtraEnemyStrength " & numExtraEnemyStrength.Value
    Args += " +gam_iExtraEnemyStrengthPerPlayer " & numExtraEnemyStrengthPerPlayer.Value

    Args += " +gam_ctFragsLimit " & numFragLimit.Value
    Args += " +gam_ctTimeLimit " & numTimeLimit.Value

    Args += " +ser_iMaxClientBPS " & numMaxClientBPS.Value

    If chkDisableVoting.Checked Then
      Args += " +prj_strDisabledVoteTypes ""all"""
    Else
      Args += " +prj_strDisabledVoteTypes """""
    End If

    If Not checkExec.Checked And textExec.Text <> "" Then
      Args += " +exec """ & textExec.Text & """"
    Else
      If txtInterChat.Text <> "" Then
        Args += " +exec ""Content/SeriousSamHD_TSE/SGUIHD.lua"""
      End If
    End If

    If Not Debug Then
      If Not File.Exists(My.Application.Info.DirectoryPath & "\Bin\SamHD_TSE_DedicatedServer.exe") Then
        MsgBox("You don't appear to have the dedicated server installed, or have extracted this application to the correct location.")
      Else
        ServerProcess = System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\Bin\SamHD_TSE_DedicatedServer.exe", Args)
      End If
    Else
      ServerProcess = System.Diagnostics.Process.Start("C:\Program Files (x86)\Steam\steamapps\common\serious sam hd the second encounter\Bin\SamHD_TSE_DedicatedServer.exe", Args)
    End If

    'tmrSleep.Enabled = True

    SetStatus("Started!")

    Save()
  End Sub

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    numPort.Value = My.Settings.Default.Port
    txtServername.Text = My.Settings.Default.ServerName
    cmbMode.SelectedIndex = My.Settings.Default.GameMode
    cmbLevel.SelectedIndex = My.Settings.Default.Level
    txtLevel.Text = My.Settings.Default.strLevel
    If My.Settings.Default.Level = 16 Then
      txtLevel.Enabled = True
    End If
    txtInterChat.Text = My.Settings.Default.InterChat
    numInterChat.Value = My.Settings.Default.InterChatTime
    txtAdminPass.Text = My.Settings.Default.AdminPass
    CheckBox1.Checked = My.Settings.Default.ShowPass
    chkInfiniteAmmo.Checked = My.Settings.Default.InfiniteAmmo
    txtClientPass.Text = My.Settings.Default.ClientPass
    chkAllowHealth.Checked = My.Settings.Default.AllowHealth
    chkAllowArmor.Checked = My.Settings.Default.AllowArmor
    chkAllowPause.Checked = My.Settings.Default.AllowPause
    numPlayers.Value = My.Settings.Default.MaxPlayers
    chkSpawnInvul.Checked = My.Settings.Default.SpawnInvul
    chkHealthStays.Checked = My.Settings.Default.HealthStays
    chkArmorStays.Checked = My.Settings.Default.ArmorStays
    chkAmmoStays.Checked = My.Settings.Default.AmmoStays
    chkWeaponsStay.Checked = My.Settings.Default.WeaponsStay
    chkExtraEnemies.Checked = My.Settings.Default.ExtraEnemies
    chkFriendlyFire.Checked = My.Settings.Default.FriendlyFire
    chkRespawnInPlace.Checked = My.Settings.Default.RespawnInPlace
    cmbDifficulty.SelectedIndex = My.Settings.Default.Difficulty
    numExtraEnemyStrength.Value = My.Settings.Default.ExtraEnemyStrength
    numExtraEnemyStrengthPerPlayer.Value = My.Settings.Default.ExtraEnemyStrengthPerPlayer
    lblVal1.Text = My.Settings.Default.ExtraEnemyStrength & "%"
    lblVal2.Text = My.Settings.Default.ExtraEnemyStrengthPerPlayer & "%"
    chkCheats.Checked = My.Settings.Default.Cheats
    numFragLimit.Value = My.Settings.Default.FragLimit
    numTimeLimit.Value = My.Settings.Default.TimeLimit
    numFPS.Value = My.Settings.Default.FPS
    numMaxClientBPS.Value = My.Settings.Default.MaxClientBPS
    chkDisableVoting.Checked = My.Settings.Default.DisableVoting
    checkExec.Checked = My.Settings.Default.CustomExec
    textExec.Text = My.Settings.Default.CustomExecString

    Me.Left = My.Settings.Default.WindowX
    Me.Top = My.Settings.Default.WindowY

    grpDebug.Enabled = Debug

    If Not Internal Then
      TabControl1.TabPages.Remove(TabPage5)
    End If

    If My.Application.CommandLineArgs.Contains("+start") Then
      Button1_Click(sender, e)
    End If
  End Sub

  Sub StopServer()
    Try
      ServerProcess.Kill()
    Catch ex As Exception
      ' do nothing. it's just not on probably...
    End Try
  End Sub

  Sub Save()
    My.Settings.Default.Port = numPort.Value
    My.Settings.Default.ServerName = txtServername.Text
    My.Settings.Default.Level = cmbLevel.SelectedIndex
    My.Settings.Default.strLevel = txtLevel.Text
    My.Settings.Default.InterChat = txtInterChat.Text
    My.Settings.Default.InterChatTime = numInterChat.Value
    My.Settings.Default.AdminPass = txtAdminPass.Text
    My.Settings.Default.ShowPass = CheckBox1.Checked
    My.Settings.Default.InfiniteAmmo = chkInfiniteAmmo.Checked
    My.Settings.Default.GameMode = cmbMode.SelectedIndex
    My.Settings.Default.ClientPass = txtClientPass.Text
    My.Settings.Default.AllowHealth = chkAllowHealth.Checked
    My.Settings.Default.AllowArmor = chkAllowArmor.Checked
    My.Settings.Default.AllowPause = chkAllowPause.Checked
    My.Settings.Default.MaxPlayers = numPlayers.Value
    My.Settings.Default.SpawnInvul = chkSpawnInvul.Checked
    My.Settings.Default.HealthStays = chkHealthStays.Checked
    My.Settings.Default.ArmorStays = chkArmorStays.Checked
    My.Settings.Default.AmmoStays = chkAmmoStays.Checked
    My.Settings.Default.WeaponsStay = chkWeaponsStay.Checked
    My.Settings.Default.ExtraEnemies = chkExtraEnemies.Checked
    My.Settings.Default.FriendlyFire = chkFriendlyFire.Checked
    My.Settings.Default.RespawnInPlace = chkRespawnInPlace.Checked
    My.Settings.Default.Difficulty = cmbDifficulty.SelectedIndex
    My.Settings.Default.ExtraEnemyStrength = numExtraEnemyStrength.Value
    My.Settings.Default.ExtraEnemyStrengthPerPlayer = numExtraEnemyStrengthPerPlayer.Value
    My.Settings.Default.Cheats = chkCheats.Checked
    My.Settings.Default.FragLimit = numFragLimit.Value
    My.Settings.Default.TimeLimit = numTimeLimit.Value
    My.Settings.Default.FPS = numFPS.Value
    My.Settings.Default.MaxClientBPS = numMaxClientBPS.Value
    My.Settings.Default.DisableVoting = chkDisableVoting.Checked
    My.Settings.Default.CustomExec = checkExec.Checked
    My.Settings.Default.CustomExecString = textExec.Text

    My.Settings.Default.WindowX = Me.Left
    My.Settings.Default.WindowY = Me.Top

    My.Settings.Default.Save()
  End Sub

  Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    Save()
    MsgBox("Successfully saved settings.", MsgBoxStyle.Information)
  End Sub

  Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
    txtAdminPass.UseSystemPasswordChar = Not CheckBox1.Checked
    txtClientPass.UseSystemPasswordChar = Not CheckBox1.Checked
  End Sub

  Private Sub cmbMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMode.SelectedIndexChanged
    If cmbMode.SelectedIndex = 0 Or cmbMode.SelectedIndex = 1 Or cmbMode.SelectedIndex = 3 Or cmbMode.SelectedIndex = 10 Then
      LevelsCoop()
    ElseIf cmbMode.SelectedIndex = 5 Or cmbMode.SelectedIndex = 6 Or cmbMode.SelectedIndex = 7 Or cmbMode.SelectedIndex = 8 Or cmbMode.SelectedIndex = 9 Or cmbMode.SelectedIndex = 11 Then
      LevelsDM()
    ElseIf cmbMode.SelectedIndex = 2 Then
      LevelsSurvival()
    ElseIf cmbMode.SelectedIndex = 4 Then
      LevelsCTF()
    End If
  End Sub

  Sub LevelsCoop()
    cmbLevel.Items.Clear()
    cmbLevel.Items.Add("Palenque - Sierra de Chiapas")
    cmbLevel.Items.Add("Palenque - Valley of the Jaguar")
    cmbLevel.Items.Add("Teotihuacan - The City of the Gods")
    cmbLevel.Items.Add("Teotihuacan - Serpent Yards")
    cmbLevel.Items.Add("Teotihuacan - The Pit")
    cmbLevel.Items.Add("Ziggurat")
    cmbLevel.Items.Add("Persepolis - The Elephant Atrium")
    cmbLevel.Items.Add("Persepolis - Courtyards of Gilgamesh")
    cmbLevel.Items.Add("Tower Of Babel")
    cmbLevel.Items.Add("The Citadel")
    cmbLevel.Items.Add("Land of the Damned")
    cmbLevel.Items.Add("The Grand Cathedral")
    cmbLevel.Items.Add("Palenque Demo")
    cmbLevel.Items.Add("TFE DLC: Hatshepsut")
    cmbLevel.Items.Add("TFE DLC: Sand Canyon")
    cmbLevel.Items.Add("TFE DLC: Tomb of Ramses")
    cmbLevel.Items.Add("TFE DLC: Valley of the Kings")
    cmbLevel.Items.Add("TFE DLC: Moon Mountains")
    cmbLevel.Items.Add("TFE DLC: Oasis")
    cmbLevel.Items.Add("TFE DLC: Dunes")
    cmbLevel.Items.Add("TFE DLC: Suburbs")
    cmbLevel.Items.Add("TFE DLC: Sewers")
    cmbLevel.Items.Add("TFE DLC: Metropolis")
    cmbLevel.Items.Add("TFE DLC: Alley of the Sphinxes")
    cmbLevel.Items.Add("TFE DLC: Karnak")
    cmbLevel.Items.Add("TFE DLC: Luxor")
    cmbLevel.Items.Add("TFE DLC: Sacred Yards")
    cmbLevel.Items.Add("TFE DLC: The Great Pryamid")
    cmbLevel.Items.Add("TFE DLC: Karnak Demo")
    cmbLevel.Items.Add("Other...")
    cmbLevel.SelectedIndex = 0
  End Sub

  Sub LevelsDM()
    cmbLevel.Items.Clear()
    cmbLevel.Items.Add("Brkeen Chevap")
    cmbLevel.Items.Add("Fortress")
    cmbLevel.Items.Add("Hole")
    cmbLevel.Items.Add("Jump Over")
    cmbLevel.Items.Add("Medieval Rage")
    cmbLevel.Items.Add("Royal Purgatory")
    cmbLevel.Items.Add("Sun Palace")
    cmbLevel.Items.Add("The Lost Tomb")
    cmbLevel.Items.Add("We Got Skulls'n'Bones Too")
    cmbLevel.Items.Add("Yodeller")
    cmbLevel.Items.Add("TFE DLC: Desert Temple")
    cmbLevel.Items.Add("TFE DLC: Flood")
    cmbLevel.Items.Add("TFE DLC: Gvide")
    cmbLevel.Items.Add("TFE DLC: Hoodlums Backyard")
    cmbLevel.Items.Add("TFE DLC: Horus Web")
    cmbLevel.Items.Add("TFE DLC: Little Trouble")
    cmbLevel.Items.Add("TFE DLC: Simply One")
    cmbLevel.Items.Add("Other...")
    cmbLevel.SelectedIndex = 0
  End Sub

  Sub LevelsCTF()
    cmbLevel.Items.Clear()
    cmbLevel.Items.Add("Ashes To Ashes")
    cmbLevel.Items.Add("Little Trouble")
    cmbLevel.Items.Add("Flagrante")
    cmbLevel.Items.Add("Fort Wars")
    cmbLevel.Items.Add("Other...")
    cmbLevel.SelectedIndex = 0
  End Sub

  Sub LevelsSurvival()
    cmbLevel.Items.Clear()
    cmbLevel.Items.Add("Bear City")
    cmbLevel.Items.Add("Bend On Sand")
    cmbLevel.Items.Add("Death From Above")
    cmbLevel.Items.Add("Deep Hole")
    cmbLevel.Items.Add("Green Field")
    cmbLevel.Items.Add("Icelander")
    cmbLevel.Items.Add("Kleer Base")
    cmbLevel.Items.Add("Other...")
    cmbLevel.SelectedIndex = 0
  End Sub

  Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    tmrGet.Enabled = False
    ConnectRcon()
  End Sub

  Sub AddLog(ByVal strText As String)
    If txtRconOutput.Text <> "" Then txtRconOutput.Text += vbCrLf
    txtRconOutput.Text += strText
  End Sub

  Sub SetStatus(ByVal strText As String)
    lblStatus.Text = strText
    My.Application.DoEvents()
  End Sub

  Sub ConnectRcon()
    If rconConnected Then
      AddLog("[SYS] Tried to connect while already connected.")
      Exit Sub
    End If
    SetStatus("Connecting Rcon...")
    AddLog("[SYS] Connecting Rcon...")
    ignoredFirst = False
    ignoreLast = ""
    tcpClient = New TcpClient()
    tcpClient.ReceiveTimeout = 1500
    tcpClient.Connect("127.0.0.1", numPort.Value)
    networkStream = tcpClient.GetStream()
    streamReader = New StreamReader(networkStream)
    If networkStream.CanWrite And networkStream.CanRead Then
      AddLog("[SYS] Connection initialised.")
      AddLog("[SYS] Logging in...")
      Dim Data As String
      Data = GetRcon()
      While Data <> "login:"
        Data = GetRcon()
      End While
      ' get it 2 times more
      GetRcon()
      GetRcon()
      SendRcon(txtAdminPass.Text)
      Dim LoginResult As String = GetRcon()
      If LoginResult = "Incorrect login" Then
        AddLog("[SYS] Rcon error: Incorrect login for Rcon. Rcon has to be terminated.")
        SetStatus("Couldn't login to Rcon!")
        tcpClient.Close()
      Else
        rconConnected = True
        tmrGet.Enabled = True
        AddLog("[SYS] Connected!")
      End If
    Else
      If Not networkStream.CanRead Then
        AddLog("[SYS] Rcon error: Can not read from stream. Rcon has to be terminated.")
        SetStatus("Couldn't read from stream!")
        tcpClient.Close()
      Else
        If Not networkStream.CanWrite Then
          AddLog("[SYS] Rcon error: Can not write to stream. Rcon has to be terminated.")
          SetStatus("Couldn't write to stream!")
          tcpClient.Close()
        End If
      End If
    End If
  End Sub

  Function GetRcon(Optional ByVal Report As Boolean = False, Optional ByVal DoTrim As Boolean = True)
    Dim strData As String = ""
    Try
      If Not ignoredFirst Then
        streamReader.ReadLine()
        ignoredFirst = True
        If Report Then
          AddLog("[SYS] Received telnet commands. Ignoring!")
        End If
      End If
      strData = streamReader.ReadLine()
    Catch ex As Exception
      strData = "[ERROR]"
      If Report Then
        AddLog("[SYS] Nothing received! (" & ex.Message & ")")
      End If
    End Try
    If DoTrim Then
      strData = Trim(strData)
    End If
    Return strData
  End Function

  Function SendRcon(ByVal strText As String)
    Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(strText & Chr(13))
    Dim strData As String = ""
    networkStream.Write(sendBytes, 0, sendBytes.Length)
    Return ""
  End Function

  Sub DiscardRcon()
    Try
      streamReader.ReadToEnd()
    Catch ex As Exception
      ' ignore, nothing to read
    End Try
  End Sub

  Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
    GetRcon()
  End Sub

  Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
    If rconConnected Then
      tcpClient.Close()
      rconConnected = False
      AddLog("[SYS] Disconnected Rcon.")
    End If
  End Sub

  Private Sub lstPlayers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPlayers.SelectedIndexChanged
    If lstPlayers.SelectedIndex >= 0 Then
      Button8.Enabled = True
      Button9.Enabled = True
    Else
      Button8.Enabled = False
      Button9.Enabled = False
    End If
  End Sub

  Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
    System.Diagnostics.Process.Start("https://github.com/angelog/serverguihd/")
  End Sub

  Private Sub numExtraEnemyStrength_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numExtraEnemyStrength.Scroll
    lblVal1.Text = numExtraEnemyStrength.Value & "%"
  End Sub

  Private Sub numExtraEnemyStrengthPerPlayer_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numExtraEnemyStrengthPerPlayer.Scroll
    lblVal2.Text = numExtraEnemyStrengthPerPlayer.Value & "%"
  End Sub

  Private Sub tmrGet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGet.Tick
    Dim Data As String
    Dim Cont As Boolean = True
    AddLog("[SYS] Timer Get Tick")
    While Cont
      Try
        Data = GetRcon()
        AddLog(Data)
      Catch ex As Exception
        Cont = False
      End Try
      AddLog("[SYS] End while")
    End While
  End Sub

  Private Sub txtRconInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRconInput.KeyDown
    SendRcon(txtRconInput.Text)
  End Sub

  Private Sub tmrSleep_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSleep.Tick
    ConnectRcon()
  End Sub
End Class
