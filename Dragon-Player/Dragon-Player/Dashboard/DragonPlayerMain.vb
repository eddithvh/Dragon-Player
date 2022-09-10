Imports System.IO
Imports System.Net
Imports AxWMPLib

Public Class DragonPlayerMain
    'Dimowanie (ussles)
    Dim files As Collections.ObjectModel.ReadOnlyCollection(Of String)
    Dim titles As New List(Of String)
    Dim CurrentPlaying As Integer = 0
    Dim PreviouslyPlaying As Integer = 0
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()

    End Sub

    Private Sub updatePlayer()
        ' Display track name
        Try
            Label3.Text = "Now playing,  ♬ " & PlayerX.currentMedia.name
            mini.Label3.Text = "♬" & PlayerX.currentMedia.name
            ' Update TrackPostion and ProgressBar
            With trackposition
                .Minimum = 0
                .Maximum = CInt(PlayerX.currentMedia.duration)
                .Value = CInt(PlayerX.Ctlcontrols.currentPosition())
            End With

            With Bar
                .Minimum = 0
                .Maximum = CInt(PlayerX.currentMedia.duration)
                .Value = CInt(PlayerX.Ctlcontrols.currentPosition())
            End With

            ' Display Current Time Position and Duration, Album
            Label4.Text = PlayerX.currentMedia.durationString
            Label1.Text = PlayerX.Ctlcontrols.currentItem.getItemInfo("Artist") '& " | Album - " & PlayerX.Ctlcontrols.currentItem.getItemInfo("Album")
            Label7.Text = PlayerX.Ctlcontrols.currentItem.getItemInfo("Title")
            Label5.Text = PlayerX.Ctlcontrols.currentPositionString


            ' Is the CurrentPlaying Track No. is different to the Previous Track number.
            If CurrentPlaying <> PreviouslyPlaying Then
                ' Yes, 
                ' Set the forecolor of the corrisponding track, assiociated with the previous playing track, with the control color
                TrackList.Items(PreviouslyPlaying).ForeColor = System.Drawing.SystemColors.WindowFrame
            End If


            'autoplay when song is end


            'Replay if
            If Rpl.Checked = True Then

                PlayerX.settings.setMode("Loop", True)

            End If

            If Rpl.Checked = False Then
                Try
                    If PlayerX.playState = WMPLib.WMPPlayState.wmppsStopped Then

                        TrackList.SelectedIndex = Me.TrackList.SelectedIndex + 1
                        checking.Start()


                    End If
                Catch ex As Exception
                    TrackList.SelectedIndex = Me.TrackList.SelectedIndex - 1
                End Try

                PlayerX.settings.setMode("Loop", False)
            End If

        Catch ex As Exception

        End Try


        'LOGI
        Try
            'Logs
            'My.Computer.FileSystem.WriteAllText("C:\DragonPlayer\Logs\Logs.ini", DateAndTime.TimeString("hh/mm" & " Playin: " & PlayerX.currentMedia.name), True)

        Catch ex As Exception

        End Try
        Try










            With mini.BarX
                .Minimum = 1
                .Maximum = CInt(PlayerX.currentMedia.duration)
                .Value = CInt(PlayerX.Ctlcontrols.currentPosition())
            End With

        Catch ex As Exception

        End Try


    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles Startp.Click
        Try

            If Startp.Checked = True Then
                PlayerX.Ctlcontrols.pause()

            Else
                PlayerX.Ctlcontrols.play()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'updating info about player
        updatePlayer()
    End Sub


    Private Sub trackposition_Scroll(sender As Object, e As ScrollEventArgs) Handles trackposition.Scroll
        Try
            PlayerX.Ctlcontrols.currentPosition = trackposition.Value

        Catch ex As Exception

        End Try
    End Sub


    Private Sub GunaAdvenceButton1_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        'Adding new song to lib.
        Try
            AAOp.ShowDialog()
            IO.File.Copy(AAOp.FileName, "C:\DragonPlayer\Songs\" & IO.Path.GetFileName(AAOp.SafeFileName), True)


            'logs
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\DragonPlayer\Logs\Logs.ini", True)
            file.WriteLine("[" & DateAndTime.TimeString & "/" & DateAndTime.DateString & "] " & " Adding file: " & AAOp.SafeFileName & vbNewLine)
            file.Close()

        Catch ex As Exception
            MsgBox("Plik istnieje lub nie istnieje i ... go wie tak naprawde.")
        End Try
    End Sub

    Private Sub DragonPlayerMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loading shadow

        'Loading library C:\Dragonplayer\songs\*
        Try
            TrackList.Items.AddRange(IO.Directory.GetFiles("C:\DragonPlayer\Songs\", "*.mp3*"))
            TrackList.SelectedIndex = 0
            TrackList.Items.Remove(TrackList.SelectedItem)
            TrackList.SelectedIndex = 0
            If TrackList.SelectedIndex = 0 Then
                PlayerX.Ctlcontrols.stop()
            End If
            PlayerX.settings.volume = 20
        Catch ex As Exception

        End Try

        Try
            'Loading avatar 
            Avek.Image = Image.FromFile("C:\DragonPlayer\Data\avatar.png")
            GunaImageButton1.Image = Image.FromFile("C:\DragonPlayer\Data\bgz.png")

        Catch ex As Exception
            'Img from url
            Dim tClient As WebClient = New WebClient

            Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData("https://i.imgur.com/2LoEKPH.png")))

            Avek.Image = tImage

        End Try

        Try 'Loading BGZ
            GunaImageButton1.Image = Image.FromFile("C:\DragonPlayer\Data\bgz.png")
        Catch ex As Exception
            GunaImageButton1.Image = My.Resources.bigcd1
        End Try
        PlayerX.Ctlcontrols.pause()
    End Sub


    Private Sub DragonPlayerMain_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        'ending
        Client.Close()
    End Sub


    Private Sub GunaVTrackBar1_Scroll(sender As Object, e As ScrollEventArgs)
        'Set player volume
        PlayerX.settings.volume = GunaTrackBarX.Value
    End Sub

    Private Sub volbtn_Click(sender As Object, e As EventArgs) Handles volbtn.Click
        'Animation for volume icon/trackbar
        Anim.Show(GunaTrackBarX)
        Anim.Hide(volbtn)

    End Sub

    Private Sub GunaTrackBarX_Scroll(sender As Object, e As ScrollEventArgs) Handles GunaTrackBarX.Scroll
        'Interaction trackbar volume with player/text.
        Label6.Text = GunaTrackBarX.Value & "%"
        PlayerX.settings.volume = GunaTrackBarX.Value


    End Sub

    Private Sub GunaTrackBarX_MouseLeave(sender As Object, e As EventArgs) Handles GunaTrackBarX.MouseLeave
        'Hiding animation for volume control
        Anim.Hide(GunaTrackBarX)
        Anim.Show(volbtn)

    End Sub

    Private Sub hhide_Click(sender As Object, e As EventArgs) Handles hhide.Click
        Anim2S.Show(Panel2)
    End Sub

    Private Sub GunaAdvenceButton4_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        Anim2S.Hide(Panel2)
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        'Refreshing playlist
        Try
            TrackList.Items.Clear()
            TrackList.Items.AddRange(IO.Directory.GetFiles("C:\DragonPlayer\Songs\"))

            'logs
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\DragonPlayer\Logs\Logs.ini", True)
            file.WriteLine("[" & DateAndTime.TimeString & "/" & DateAndTime.DateString & "] " & " Refreshin playlist" & vbNewLine)
            file.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        'Open playlist folder directory
        Try
            Process.Start("C:\DragonPlayer\Songs\")

            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\DragonPlayer\Logs\Logs.ini", True)
            file.WriteLine("[" & DateAndTime.TimeString & "/" & DateAndTime.DateString & "] " & " Directory playlist open" & vbNewLine)
            file.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TrackList_SelectedValueChanged(sender As Object, e As EventArgs) Handles TrackList.SelectedValueChanged
        'Changing song by selecting on listbox. / Adding Duration, Song name in bottom panel.
        Try
            PlayerX.URL = TrackList.SelectedItem
            PlayerX.Ctlcontrols.play()
            Label3.Text = PlayerX.currentMedia.name
            Label5.Text = PlayerX.currentMedia.durationString()
            Timer1.Start()


            Try
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("C:\DragonPlayer\Logs\Logs.ini", True)
                file.WriteLine("[" & DateAndTime.TimeString & "/" & DateAndTime.DateString & "] " & " Now Playing: " & PlayerX.currentMedia.name & vbNewLine)
                file.Close()
            Catch ex As Exception

            End Try


            If TrackList.SelectedItem = "" Then
                PlayerX.Ctlcontrols.stop()
                Timer1.Stop()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AAOp_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AAOp.FileOk

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click

        'next song
        Try
            TrackList.SelectedIndex = Me.TrackList.SelectedIndex + 1

        Catch ex As Exception
            TrackList.SelectedIndex = Me.TrackList.SelectedIndex - 1
        End Try
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click

        'back song
        Try
            TrackList.SelectedIndex = Me.TrackList.SelectedIndex - 1

        Catch ex As Exception
            TrackList.SelectedIndex = Me.TrackList.SelectedIndex + 1
        End Try
    End Sub

    Private Sub Avek_Click(sender As Object, e As EventArgs) Handles Avek.Click
        'Chaning avatar img
        Try
            ChangeAvatar.ShowDialog()
            'IO.File.Copy(ChangeAvatar.FileName, "C:\DragonPlayer\Data\" & IO.Path.GetFileName("avatar.png", overwrite:=True), True)
            'My.Computer.FileSystem.CopyFile(ChangeAvatar.FileName, "C:\DragonPlayer\Data\avatar.png", overwrite:=True)

            'Checking if this same file exists 'avatar+png'. If no - Nothing, If yes - Removin it and replace with new from openfiledialog (filename).
            If File.Exists("C:\DragonPlayer\Data\avatar.png") Then
                Avek.Image.Dispose()
                File.Delete("C:\DragonPlayer\Data\avatar.png")
            End If

            File.Copy(ChangeAvatar.FileName, "C:\DragonPlayer\Data\" + "avatar.png")

        Catch ex As Exception
            Avek.Image = My.Resources.bed
        End Try


        'Applyin & refreshin
        Try
            Avek.Image = Image.FromFile("C:\DragonPlayer\Data\avatar.png")
        Catch ex As Exception

        End Try


        'logs
        Try
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\DragonPlayer\Logs\Logs.ini", True)
            file.WriteLine("[" & DateAndTime.TimeString & "/" & DateAndTime.DateString & "] " & " Changing avatar to: " & ChangeAvatar.SafeFileName & " -Deleting old from memory" & vbNewLine)
            file.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GunaGradientPanel1_Click(sender As Object, e As EventArgs) Handles GunaGradientPanel1.Click

    End Sub

    Private Sub TrackList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TrackList.SelectedIndexChanged

    End Sub

    Private Sub GunaTrackBarX_ValueChanged(sender As Object, e As EventArgs) Handles GunaTrackBarX.ValueChanged
        Try
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\DragonPlayer\Logs\Logs.ini", True)
            file.WriteLine("[" & DateAndTime.TimeString & "/" & DateAndTime.DateString & "] " & " Changed volume: " & GunaTrackBarX.Value & "%" & vbNewLine)
            file.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ICON_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ICONx.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub ICONx_MouseClick(sender As Object, e As MouseEventArgs) Handles ICONx.MouseClick
        Me.Show()
    End Sub

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaImageButton1.Click
        Try
            BgzP.ShowDialog()

            If File.Exists("C:\DragonPlayer\Data\bgz.png") Then
                GunaImageButton1.Image.Dispose()
                ' GunaImageButton1.Image = Image.FromFile("C:\DragonPlayer\Data\bgz.png")
                File.Delete("C:\DragonPlayer\Data\bgz.png")
            End If

            File.Copy(BgzP.FileName, "C:\DragonPlayer\Data\" + "bgz.png")



        Catch ex As Exception

        End Try
        'Applyin & refreshin
        Try
            GunaImageButton1.Image = Image.FromFile("C:\DragonPlayer\Data\bgz.png")
        Catch ex As Exception

            GunaImageButton1.Image = My.Resources.bigcd1

        End Try

    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles MiniPlayerX.Click
        mini.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        '...'
    End Sub

    Private Sub GunaAdvenceButton7_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click

    End Sub
End Class