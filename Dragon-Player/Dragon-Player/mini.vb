Public Class mini
    Private Sub mini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DragonPlayerMain.Hide()
            Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
            'loc
            Dim x As Integer
            Dim y As Integer
            x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
            Me.Location = New Point(x - 20, y - 25)


            TrackListx.Items.AddRange(IO.Directory.GetFiles("C:\DragonPlayer\Songs\", "*.mp3*"))
            TrackListx.SelectedIndex = DragonPlayerMain.TrackList.SelectedIndex
            TrackListx.SelectedIndex = 0
            TrackListx.Items.Remove(TrackListx.SelectedItem)
            TrackListx.SelectedIndex = DragonPlayerMain.TrackList.SelectedIndex
        Catch ex As Exception

        End Try
        GunaTrackBarXX.Value = DragonPlayerMain.GunaTrackBarX.Value

    End Sub
    Private Sub mini_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        'changing status for live.
        DragonPlayerMain.Show()
    End Sub

    Private Sub Rpl_Click(sender As Object, e As EventArgs) Handles Rpl.Click
        If Rpl.Checked = True Then
            DragonPlayerMain.Rpl.Checked = True
        Else
            DragonPlayerMain.Rpl.Checked = False
        End If
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub





    Private Sub Startp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TrackListx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TrackListx.SelectedIndexChanged

    End Sub

    Private Sub TrackListx_SelectedValueChanged(sender As Object, e As EventArgs) Handles TrackListx.SelectedValueChanged
        'Changing song by selecting on listbox. / Adding Duration, Song name in bottom panel.
        Try
            DragonPlayerMain.PlayerX.URL = TrackListx.SelectedItem
            DragonPlayerMain.PlayerX.Ctlcontrols.play()
            DragonPlayerMain.Label3.Text = DragonPlayerMain.PlayerX.currentMedia.name
            DragonPlayerMain.Label5.Text = DragonPlayerMain.PlayerX.currentMedia.durationString()
            DragonPlayerMain.Timer1.Start()




            If TrackListx.SelectedItem = "" Then
                'DragonPlayerMain.PlayerX.Ctlcontrols.stop()
                '  DragonPlayerMain.Timer1.Stop()
            End If
        Catch ex As Exception

        End Try
    End Sub


    'replace.dog(dog)
    Private Sub bk_Click(sender As Object, e As EventArgs) Handles bk.Click
        Try
            TrackListx.SelectedIndex = Me.TrackListx.SelectedIndex - 1
        Catch ex As Exception
            TrackListx.SelectedIndex = Me.TrackListx.SelectedIndex - 1
        End Try
    End Sub

    Private Sub nxx_Click(sender As Object, e As EventArgs) Handles nxx.Click
        Try
            TrackListx.SelectedIndex = Me.TrackListx.SelectedIndex + 1
        Catch ex As Exception
            TrackListx.SelectedIndex = Me.TrackListx.SelectedIndex + 1
        End Try
    End Sub

    Private Sub Startp_Click_1(sender As Object, e As EventArgs) Handles Startp.Click
        Try

            If Startp.Checked = True Then
                DragonPlayerMain.PlayerX.Ctlcontrols.pause()

            Else
                DragonPlayerMain.PlayerX.Ctlcontrols.play()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub JEBAC_Click(sender As Object, e As EventArgs) Handles JEBAC.Click
        Me.Close()
    End Sub

    Private Sub GunaTrackBarX_Scroll(sender As Object, e As ScrollEventArgs) Handles GunaTrackBarXX.Scroll

    End Sub

    Private Sub GunaTrackBarX_ValueChanged(sender As Object, e As EventArgs) Handles GunaTrackBarXX.ValueChanged
        DragonPlayerMain.PlayerX.settings.volume = GunaTrackBarXX.Value
    End Sub

    Private Sub pog_Tick(sender As Object, e As EventArgs) Handles pog.Tick
        BarX.ProgressMaxColor = GunaColorTransition1.Value
        BarX.ProgressMinColor = GunaColorTransition1.Value
    End Sub
End Class