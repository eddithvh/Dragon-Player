<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mini
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mini))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Rpl = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaDragControl2 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl3 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl4 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl5 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl6 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl7 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.TrackListx = New System.Windows.Forms.ListBox()
        Me.bk = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.nxx = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Startp = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BarX = New Guna.UI.WinForms.GunaProgressBar()
        Me.JEBAC = New System.Windows.Forms.Label()
        Me.GunaTrackBarXX = New Guna.UI.WinForms.GunaTrackBar()
        Me.GunaColorTransition1 = New Guna.UI.WinForms.GunaColorTransition(Me.components)
        Me.pog = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 41)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nothing is being played now..."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'Rpl
        '
        Me.Rpl.Animated = True
        Me.Rpl.AnimationHoverSpeed = 0.07!
        Me.Rpl.AnimationSpeed = 0.03!
        Me.Rpl.BackColor = System.Drawing.Color.Transparent
        Me.Rpl.BaseColor = System.Drawing.Color.Transparent
        Me.Rpl.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Rpl.ButtonType = Guna.UI.WinForms.AdvenceButtonType.ToogleButton
        Me.Rpl.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Rpl.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Rpl.CheckedForeColor = System.Drawing.Color.White
        Me.Rpl.CheckedImage = CType(resources.GetObject("Rpl.CheckedImage"), System.Drawing.Image)
        Me.Rpl.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Rpl.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Rpl.FocusedColor = System.Drawing.Color.Empty
        Me.Rpl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Rpl.ForeColor = System.Drawing.Color.White
        Me.Rpl.Image = CType(resources.GetObject("Rpl.Image"), System.Drawing.Image)
        Me.Rpl.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Rpl.ImageSize = New System.Drawing.Size(16, 16)
        Me.Rpl.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Rpl.Location = New System.Drawing.Point(243, 47)
        Me.Rpl.Name = "Rpl"
        Me.Rpl.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Rpl.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Rpl.OnHoverForeColor = System.Drawing.Color.Silver
        Me.Rpl.OnHoverImage = Nothing
        Me.Rpl.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Rpl.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Rpl.Radius = 10
        Me.Rpl.Size = New System.Drawing.Size(27, 28)
        Me.Rpl.TabIndex = 27
        '
        'GunaDragControl2
        '
        Me.GunaDragControl2.TargetControl = Nothing
        '
        'GunaDragControl3
        '
        Me.GunaDragControl3.TargetControl = Nothing
        '
        'GunaDragControl4
        '
        Me.GunaDragControl4.TargetControl = Nothing
        '
        'GunaDragControl5
        '
        Me.GunaDragControl5.TargetControl = Nothing
        '
        'GunaDragControl6
        '
        Me.GunaDragControl6.TargetControl = Me.Label3
        '
        'GunaDragControl7
        '
        Me.GunaDragControl7.TargetControl = Me
        '
        'TrackListx
        '
        Me.TrackListx.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TrackListx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TrackListx.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TrackListx.ForeColor = System.Drawing.Color.White
        Me.TrackListx.FormattingEnabled = True
        Me.TrackListx.HorizontalExtent = 20
        Me.TrackListx.ItemHeight = 21
        Me.TrackListx.Items.AddRange(New Object() {"C:\DragonPlayer\Songs\"})
        Me.TrackListx.Location = New System.Drawing.Point(9, 118)
        Me.TrackListx.Name = "TrackListx"
        Me.TrackListx.Size = New System.Drawing.Size(358, 336)
        Me.TrackListx.TabIndex = 29
        '
        'bk
        '
        Me.bk.Animated = True
        Me.bk.AnimationHoverSpeed = 0.07!
        Me.bk.AnimationSpeed = 0.03!
        Me.bk.BackColor = System.Drawing.Color.Transparent
        Me.bk.BaseColor = System.Drawing.Color.Transparent
        Me.bk.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bk.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.bk.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bk.CheckedForeColor = System.Drawing.Color.White
        Me.bk.CheckedImage = CType(resources.GetObject("bk.CheckedImage"), System.Drawing.Image)
        Me.bk.CheckedLineColor = System.Drawing.Color.DimGray
        Me.bk.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bk.FocusedColor = System.Drawing.Color.Empty
        Me.bk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bk.ForeColor = System.Drawing.Color.White
        Me.bk.Image = CType(resources.GetObject("bk.Image"), System.Drawing.Image)
        Me.bk.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.bk.ImageSize = New System.Drawing.Size(20, 20)
        Me.bk.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.bk.Location = New System.Drawing.Point(78, 37)
        Me.bk.Name = "bk"
        Me.bk.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.bk.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bk.OnHoverForeColor = System.Drawing.Color.Silver
        Me.bk.OnHoverImage = Nothing
        Me.bk.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.bk.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.bk.Radius = 10
        Me.bk.Size = New System.Drawing.Size(34, 30)
        Me.bk.TabIndex = 32
        '
        'nxx
        '
        Me.nxx.Animated = True
        Me.nxx.AnimationHoverSpeed = 0.07!
        Me.nxx.AnimationSpeed = 0.03!
        Me.nxx.BackColor = System.Drawing.Color.Transparent
        Me.nxx.BaseColor = System.Drawing.Color.Transparent
        Me.nxx.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nxx.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.nxx.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nxx.CheckedForeColor = System.Drawing.Color.White
        Me.nxx.CheckedImage = CType(resources.GetObject("nxx.CheckedImage"), System.Drawing.Image)
        Me.nxx.CheckedLineColor = System.Drawing.Color.DimGray
        Me.nxx.DialogResult = System.Windows.Forms.DialogResult.None
        Me.nxx.FocusedColor = System.Drawing.Color.Empty
        Me.nxx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nxx.ForeColor = System.Drawing.Color.White
        Me.nxx.Image = CType(resources.GetObject("nxx.Image"), System.Drawing.Image)
        Me.nxx.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nxx.ImageSize = New System.Drawing.Size(20, 20)
        Me.nxx.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.nxx.Location = New System.Drawing.Point(158, 37)
        Me.nxx.Name = "nxx"
        Me.nxx.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.nxx.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nxx.OnHoverForeColor = System.Drawing.Color.Silver
        Me.nxx.OnHoverImage = Nothing
        Me.nxx.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.nxx.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.nxx.Radius = 10
        Me.nxx.Size = New System.Drawing.Size(34, 30)
        Me.nxx.TabIndex = 33
        '
        'Startp
        '
        Me.Startp.Animated = True
        Me.Startp.AnimationHoverSpeed = 0.07!
        Me.Startp.AnimationSpeed = 0.03!
        Me.Startp.BackColor = System.Drawing.Color.Transparent
        Me.Startp.BaseColor = System.Drawing.Color.Transparent
        Me.Startp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Startp.ButtonType = Guna.UI.WinForms.AdvenceButtonType.ToogleButton
        Me.Startp.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Startp.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Startp.CheckedForeColor = System.Drawing.Color.White
        Me.Startp.CheckedImage = CType(resources.GetObject("Startp.CheckedImage"), System.Drawing.Image)
        Me.Startp.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Startp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Startp.FocusedColor = System.Drawing.Color.Empty
        Me.Startp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Startp.ForeColor = System.Drawing.Color.White
        Me.Startp.Image = CType(resources.GetObject("Startp.Image"), System.Drawing.Image)
        Me.Startp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Startp.ImageSize = New System.Drawing.Size(14, 14)
        Me.Startp.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Startp.Location = New System.Drawing.Point(118, 37)
        Me.Startp.Name = "Startp"
        Me.Startp.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Startp.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Startp.OnHoverForeColor = System.Drawing.Color.Silver
        Me.Startp.OnHoverImage = Nothing
        Me.Startp.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Startp.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Startp.Radius = 10
        Me.Startp.Size = New System.Drawing.Size(34, 30)
        Me.Startp.TabIndex = 34
        '
        'BarX
        '
        Me.BarX.BorderColor = System.Drawing.Color.Black
        Me.BarX.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.BarX.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarX.IdleColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BarX.Location = New System.Drawing.Point(0, 96)
        Me.BarX.Name = "BarX"
        Me.BarX.ProgressMaxColor = System.Drawing.Color.White
        Me.BarX.ProgressMinColor = System.Drawing.Color.Silver
        Me.BarX.Size = New System.Drawing.Size(270, 5)
        Me.BarX.TabIndex = 36
        '
        'JEBAC
        '
        Me.JEBAC.AutoSize = True
        Me.JEBAC.BackColor = System.Drawing.Color.Transparent
        Me.JEBAC.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.JEBAC.ForeColor = System.Drawing.Color.White
        Me.JEBAC.Location = New System.Drawing.Point(251, 4)
        Me.JEBAC.Name = "JEBAC"
        Me.JEBAC.Size = New System.Drawing.Size(13, 18)
        Me.JEBAC.TabIndex = 37
        Me.JEBAC.Text = "-"
        Me.JEBAC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaTrackBarXX
        '
        Me.GunaTrackBarXX.Location = New System.Drawing.Point(87, 67)
        Me.GunaTrackBarXX.Name = "GunaTrackBarXX"
        Me.GunaTrackBarXX.Size = New System.Drawing.Size(97, 22)
        Me.GunaTrackBarXX.TabIndex = 38
        Me.GunaTrackBarXX.TrackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.GunaTrackBarXX.TrackHoverColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.GunaTrackBarXX.TrackIdleColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.GunaTrackBarXX.TrackPressedColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.GunaTrackBarXX.Value = 20
        '
        'GunaColorTransition1
        '
        Me.GunaColorTransition1.ColorArray = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Orange}
        Me.GunaColorTransition1.EndColor = System.Drawing.Color.Silver
        Me.GunaColorTransition1.Interval = 5
        Me.GunaColorTransition1.ProgessValue = 55
        Me.GunaColorTransition1.StartColor = System.Drawing.Color.Blue
        '
        'pog
        '
        Me.pog.Enabled = True
        '
        'mini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(270, 101)
        Me.Controls.Add(Me.GunaTrackBarXX)
        Me.Controls.Add(Me.JEBAC)
        Me.Controls.Add(Me.BarX)
        Me.Controls.Add(Me.Startp)
        Me.Controls.Add(Me.nxx)
        Me.Controls.Add(Me.bk)
        Me.Controls.Add(Me.TrackListx)
        Me.Controls.Add(Me.Rpl)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(255, 77)
        Me.Name = "mini"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mini"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Rpl As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl2 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl3 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl4 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl5 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl6 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl7 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents TrackListx As ListBox
    Friend WithEvents bk As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents nxx As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Startp As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BarX As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents JEBAC As Label
    Friend WithEvents GunaTrackBarXX As Guna.UI.WinForms.GunaTrackBar
    Friend WithEvents GunaColorTransition1 As Guna.UI.WinForms.GunaColorTransition
    Friend WithEvents pog As Timer
End Class
