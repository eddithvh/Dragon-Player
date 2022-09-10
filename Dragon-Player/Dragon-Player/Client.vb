Imports System.IO
Public Class Client
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Animacja1.Show(Label1)
        Animacja1.Show(Label2)
        Animacja1.Show(PictureBox1)
        Animacja1.Show(Progress)

        Starter.Start()
        DragonPlayerMain.WindowState = FormWindowState.Minimized
        DragonPlayerMain.Opacity = 0
        DragonPlayerMain.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Progress.Increment(1)
        '  Label3.Text = Progress.Value & "%"

        '   If Label3.Text = "100%" Then Label3.Text = "Complated, Starting..."


        If Progress.Value = 100 Then
            Me.Hide()
            DragonPlayerMain.Show()
            DragonPlayerMain.Opacity = 100
            DragonPlayerMain.WindowState = FormWindowState.Normal
            Guna.UI.Lib.GraphicsHelper.ShadowForm(DragonPlayerMain)
            Timer1.Stop()
        End If
        If Directory.Exists("C:\DragonPlayer") Then
            'Tworzenie nadplikow.


            'NONE
        Else
            Directory.CreateDirectory("C:\DragonPlayer")
            Directory.CreateDirectory("C:\DragonPlayer\Songs")
            Directory.CreateDirectory("C:\DragonPlayer\Settings")
            Directory.CreateDirectory("C:\DragonPlayer\Data")
            Directory.CreateDirectory("C:\DragonPlayer\Logs")

            File.Create("C:\DragonPlayer\Logs\Logs.ini")
        End If

    End Sub

    Private Sub GunaGradientPanel1_Click(sender As Object, e As EventArgs) Handles GunaGradientPanel1.Click

    End Sub

    Private Sub Starter_Tick(sender As Object, e As EventArgs) Handles Starter.Tick
        Timer1.Start()

        Starter.Stop()
    End Sub
End Class
