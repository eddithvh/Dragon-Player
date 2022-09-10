<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DragonPlayerMain
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DragonPlayerMain))
        Dim Animation2 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaAdvenceButton7 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GunaAdvenceButton6 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton5 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.TrackList = New System.Windows.Forms.ListBox()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Bar = New Guna.UI.WinForms.GunaProgressBar()
        Me.PlayerX = New AxWMPLib.AxWindowsMediaPlayer()
        Me.hhide = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MiniPlayerX = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Rpl = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Avek = New Guna.UI.WinForms.GunaCircleButton()
        Me.volbtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaTrackBarX = New Guna.UI.WinForms.GunaTrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Startp = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.trackposition = New Guna.UI.WinForms.GunaTrackBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.AAOp = New System.Windows.Forms.OpenFileDialog()
        Me.ChangeAvatar = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Anim = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.Anim2S = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.checking = New System.Windows.Forms.Timer(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.ICONx = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BgzP = New System.Windows.Forms.OpenFileDialog()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GunaGradientPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaGradientPanel1
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.Panel2)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaImageButton1)
        Me.GunaGradientPanel1.Controls.Add(Me.Bar)
        Me.GunaGradientPanel1.Controls.Add(Me.PlayerX)
        Me.GunaGradientPanel1.Controls.Add(Me.hhide)
        Me.GunaGradientPanel1.Controls.Add(Me.Label2)
        Me.GunaGradientPanel1.Controls.Add(Me.Panel1)
        Me.GunaGradientPanel1.Controls.Add(Me.Label7)
        Me.GunaGradientPanel1.Controls.Add(Me.Label1)
        Me.Anim2S.SetDecoration(Me.GunaGradientPanel1, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.GunaGradientPanel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(1222, 777)
        Me.GunaGradientPanel1.TabIndex = 1
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel2.Controls.Add(Me.GunaAdvenceButton7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.GunaAdvenceButton6)
        Me.Panel2.Controls.Add(Me.GunaAdvenceButton5)
        Me.Panel2.Controls.Add(Me.GunaAdvenceButton4)
        Me.Panel2.Controls.Add(Me.GunaAdvenceButton1)
        Me.Panel2.Controls.Add(Me.TrackList)
        Me.Anim2S.SetDecoration(Me.Panel2, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.Panel2, Guna.UI.Animation.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(505, 644)
        Me.Panel2.TabIndex = 11
        Me.Panel2.Visible = False
        '
        'GunaAdvenceButton7
        '
        Me.GunaAdvenceButton7.Animated = True
        Me.GunaAdvenceButton7.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton7.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton7.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton7.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton7.BorderSize = 1
        Me.GunaAdvenceButton7.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.GunaAdvenceButton7.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton7.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton7.CheckedImage = CType(resources.GetObject("GunaAdvenceButton7.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton7.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Anim2S.SetDecoration(Me.GunaAdvenceButton7, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.GunaAdvenceButton7, Guna.UI.Animation.DecorationType.None)
        Me.GunaAdvenceButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton7.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton7.ForeColor = System.Drawing.Color.Silver
        Me.GunaAdvenceButton7.Image = Nothing
        Me.GunaAdvenceButton7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton7.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton7.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton7.Location = New System.Drawing.Point(398, 608)
        Me.GunaAdvenceButton7.Name = "GunaAdvenceButton7"
        Me.GunaAdvenceButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton7.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton7.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton7.OnHoverImage = Nothing
        Me.GunaAdvenceButton7.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton7.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton7.Radius = 5
        Me.GunaAdvenceButton7.Size = New System.Drawing.Size(80, 30)
        Me.GunaAdvenceButton7.TabIndex = 22
        Me.GunaAdvenceButton7.Text = "Open folder"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Anim.SetDecoration(Me.Label8, Guna.UI.Animation.DecorationType.None)
        Me.Anim2S.SetDecoration(Me.Label8, Guna.UI.Animation.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(228, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 29)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Playlist"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.Anim.SetDecoration(Me.PictureBox4, Guna.UI.Animation.DecorationType.None)
        Me.Anim2S.SetDecoration(Me.PictureBox4, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(184, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'Panel4
        '
        Me.Anim2S.SetDecoration(Me.Panel4, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.Panel4, Guna.UI.Animation.DecorationType.None)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 644)
        Me.Panel4.TabIndex = 19
        '
        'GunaAdvenceButton6
        '
        Me.GunaAdvenceButton6.Animated = True
        Me.GunaAdvenceButton6.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton6.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton6.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton6.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton6.BorderSize = 1
        Me.GunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.GunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.CheckedImage = CType(resources.GetObject("GunaAdvenceButton6.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Anim2S.SetDecoration(Me.GunaAdvenceButton6, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.GunaAdvenceButton6, Guna.UI.Animation.DecorationType.None)
        Me.GunaAdvenceButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton6.ForeColor = System.Drawing.Color.Silver
        Me.GunaAdvenceButton6.Image = Nothing
        Me.GunaAdvenceButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton6.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton6.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton6.Location = New System.Drawing.Point(253, 608)
        Me.GunaAdvenceButton6.Name = "GunaAdvenceButton6"
        Me.GunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.OnHoverImage = Nothing
        Me.GunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton6.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton6.Radius = 5
        Me.GunaAdvenceButton6.Size = New System.Drawing.Size(80, 30)
        Me.GunaAdvenceButton6.TabIndex = 18
        Me.GunaAdvenceButton6.Text = "Open folder"
        '
        'GunaAdvenceButton5
        '
        Me.GunaAdvenceButton5.Animated = True
        Me.GunaAdvenceButton5.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton5.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton5.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton5.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton5.BorderSize = 1
        Me.GunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.GunaAdvenceButton5.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.CheckedImage = CType(resources.GetObject("GunaAdvenceButton5.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Anim2S.SetDecoration(Me.GunaAdvenceButton5, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.GunaAdvenceButton5, Guna.UI.Animation.DecorationType.None)
        Me.GunaAdvenceButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton5.ForeColor = System.Drawing.Color.Silver
        Me.GunaAdvenceButton5.Image = Nothing
        Me.GunaAdvenceButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton5.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.Location = New System.Drawing.Point(151, 608)
        Me.GunaAdvenceButton5.Name = "GunaAdvenceButton5"
        Me.GunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.OnHoverImage = Nothing
        Me.GunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton5.Radius = 5
        Me.GunaAdvenceButton5.Size = New System.Drawing.Size(96, 30)
        Me.GunaAdvenceButton5.TabIndex = 17
        Me.GunaAdvenceButton5.Text = "Refresh playlist"
        '
        'GunaAdvenceButton4
        '
        Me.GunaAdvenceButton4.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton4.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton4.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.CheckedImage = CType(resources.GetObject("GunaAdvenceButton4.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Anim2S.SetDecoration(Me.GunaAdvenceButton4, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.GunaAdvenceButton4, Guna.UI.Animation.DecorationType.None)
        Me.GunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton4.Image = CType(resources.GetObject("GunaAdvenceButton4.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton4.ImageSize = New System.Drawing.Size(24, 24)
        Me.GunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.Location = New System.Drawing.Point(12, 12)
        Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
        Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.OnHoverImage = Nothing
        Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton4.Radius = 10
        Me.GunaAdvenceButton4.Size = New System.Drawing.Size(35, 34)
        Me.GunaAdvenceButton4.TabIndex = 16
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = True
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton1.BorderSize = 1
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Anim2S.SetDecoration(Me.GunaAdvenceButton1, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.GunaAdvenceButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.Silver
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(16, 608)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton1.Radius = 5
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(129, 30)
        Me.GunaAdvenceButton1.TabIndex = 13
        Me.GunaAdvenceButton1.Text = "Add songs to playlist"
        '
        'TrackList
        '
        Me.TrackList.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TrackList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Anim2S.SetDecoration(Me.TrackList, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.TrackList, Guna.UI.Animation.DecorationType.None)
        Me.TrackList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TrackList.ForeColor = System.Drawing.Color.White
        Me.TrackList.FormattingEnabled = True
        Me.TrackList.HorizontalExtent = 20
        Me.TrackList.ItemHeight = 21
        Me.TrackList.Items.AddRange(New Object() {"C:\DragonPlayer\Songs\"})
        Me.TrackList.Location = New System.Drawing.Point(-162, 49)
        Me.TrackList.Name = "TrackList"
        Me.TrackList.Size = New System.Drawing.Size(664, 546)
        Me.TrackList.TabIndex = 10
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.AnimationHoverSpeed = 0.07!
        Me.GunaImageButton1.AnimationSpeed = 0.03!
        Me.GunaImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaImageButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaImageButton1.BorderColor = System.Drawing.Color.White
        Me.Anim2S.SetDecoration(Me.GunaImageButton1, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.GunaImageButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaImageButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaImageButton1.ForeColor = System.Drawing.Color.White
        Me.GunaImageButton1.Image = Global.Dragon_Player.My.Resources.Resources.bigcd1
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(364, 364)
        Me.GunaImageButton1.Location = New System.Drawing.Point(429, 116)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.GunaImageButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaImageButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaImageButton1.Size = New System.Drawing.Size(364, 364)
        Me.GunaImageButton1.TabIndex = 23
        '
        'Bar
        '
        Me.Bar.BackColor = System.Drawing.Color.Transparent
        Me.Bar.BorderColor = System.Drawing.Color.Black
        Me.Bar.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.Anim.SetDecoration(Me.Bar, Guna.UI.Animation.DecorationType.None)
        Me.Anim2S.SetDecoration(Me.Bar, Guna.UI.Animation.DecorationType.None)
        Me.Bar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar.IdleColor = System.Drawing.Color.Transparent
        Me.Bar.Location = New System.Drawing.Point(0, 644)
        Me.Bar.Maximum = 99999
        Me.Bar.Name = "Bar"
        Me.Bar.ProgressMaxColor = System.Drawing.Color.RoyalBlue
        Me.Bar.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Bar.Radius = 1
        Me.Bar.Size = New System.Drawing.Size(1222, 2)
        Me.Bar.TabIndex = 20
        '
        'PlayerX
        '
        Me.Anim.SetDecoration(Me.PlayerX, Guna.UI.Animation.DecorationType.None)
        Me.PlayerX.Enabled = True
        Me.PlayerX.Location = New System.Drawing.Point(1145, 559)
        Me.PlayerX.Name = "PlayerX"
        Me.PlayerX.OcxState = CType(resources.GetObject("PlayerX.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PlayerX.Size = New System.Drawing.Size(52, 36)
        Me.PlayerX.TabIndex = 9
        Me.PlayerX.Visible = False
        '
        'hhide
        '
        Me.hhide.AnimationHoverSpeed = 0.07!
        Me.hhide.AnimationSpeed = 0.03!
        Me.hhide.BackColor = System.Drawing.Color.Transparent
        Me.hhide.BaseColor = System.Drawing.Color.Transparent
        Me.hhide.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hhide.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.hhide.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hhide.CheckedForeColor = System.Drawing.Color.White
        Me.hhide.CheckedImage = CType(resources.GetObject("hhide.CheckedImage"), System.Drawing.Image)
        Me.hhide.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Anim2S.SetDecoration(Me.hhide, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.hhide, Guna.UI.Animation.DecorationType.None)
        Me.hhide.DialogResult = System.Windows.Forms.DialogResult.None
        Me.hhide.FocusedColor = System.Drawing.Color.Empty
        Me.hhide.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.hhide.ForeColor = System.Drawing.Color.Silver
        Me.hhide.Image = CType(resources.GetObject("hhide.Image"), System.Drawing.Image)
        Me.hhide.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.hhide.ImageSize = New System.Drawing.Size(24, 24)
        Me.hhide.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.hhide.Location = New System.Drawing.Point(12, 9)
        Me.hhide.Name = "hhide"
        Me.hhide.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.hhide.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hhide.OnHoverForeColor = System.Drawing.Color.White
        Me.hhide.OnHoverImage = Nothing
        Me.hhide.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.hhide.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.hhide.Radius = 10
        Me.hhide.Size = New System.Drawing.Size(35, 34)
        Me.hhide.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Anim.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.Anim2S.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1190, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "-"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MiniPlayerX)
        Me.Panel1.Controls.Add(Me.Rpl)
        Me.Panel1.Controls.Add(Me.Avek)
        Me.Panel1.Controls.Add(Me.volbtn)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GunaTrackBarX)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.GunaAdvenceButton3)
        Me.Panel1.Controls.Add(Me.GunaAdvenceButton2)
        Me.Panel1.Controls.Add(Me.Startp)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.trackposition)
        Me.Anim2S.SetDecoration(Me.Panel1, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.Panel1, Guna.UI.Animation.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 646)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1222, 131)
        Me.Panel1.TabIndex = 3
        '
        'MiniPlayerX
        '
        Me.MiniPlayerX.Animated = True
        Me.MiniPlayerX.AnimationHoverSpeed = 0.07!
        Me.MiniPlayerX.AnimationSpeed = 0.03!
        Me.MiniPlayerX.BackColor = System.Drawing.Color.Transparent
        Me.MiniPlayerX.BaseColor = System.Drawing.Color.Transparent
        Me.MiniPlayerX.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MiniPlayerX.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.MiniPlayerX.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MiniPlayerX.CheckedForeColor = System.Drawing.Color.White
        Me.MiniPlayerX.CheckedImage = CType(resources.GetObject("MiniPlayerX.CheckedImage"), System.Drawing.Image)
        Me.MiniPlayerX.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Anim2S.SetDecoration(Me.MiniPlayerX, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.MiniPlayerX, Guna.UI.Animation.DecorationType.None)
        Me.MiniPlayerX.DialogResult = System.Windows.Forms.DialogResult.None
        Me.MiniPlayerX.FocusedColor = System.Drawing.Color.Empty
        Me.MiniPlayerX.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MiniPlayerX.ForeColor = System.Drawing.Color.White
        Me.MiniPlayerX.Image = CType(resources.GetObject("MiniPlayerX.Image"), System.Drawing.Image)
        Me.MiniPlayerX.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MiniPlayerX.ImageSize = New System.Drawing.Size(20, 20)
        Me.MiniPlayerX.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MiniPlayerX.Location = New System.Drawing.Point(1178, 89)
        Me.MiniPlayerX.Name = "MiniPlayerX"
        Me.MiniPlayerX.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.MiniPlayerX.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MiniPlayerX.OnHoverForeColor = System.Drawing.Color.Silver
        Me.MiniPlayerX.OnHoverImage = Nothing
        Me.MiniPlayerX.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MiniPlayerX.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.MiniPlayerX.Radius = 10
        Me.MiniPlayerX.Size = New System.Drawing.Size(34, 30)
        Me.MiniPlayerX.TabIndex = 24
        Me.MiniPlayerX.Text = "off"
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
        Me.Anim2S.SetDecoration(Me.Rpl, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.Rpl, Guna.UI.Animation.DecorationType.None)
        Me.Rpl.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Rpl.FocusedColor = System.Drawing.Color.Empty
        Me.Rpl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Rpl.ForeColor = System.Drawing.Color.White
        Me.Rpl.Image = CType(resources.GetObject("Rpl.Image"), System.Drawing.Image)
        Me.Rpl.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Rpl.ImageSize = New System.Drawing.Size(20, 20)
        Me.Rpl.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Rpl.Location = New System.Drawing.Point(669, 80)
        Me.Rpl.Name = "Rpl"
        Me.Rpl.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Rpl.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Rpl.OnHoverForeColor = System.Drawing.Color.Silver
        Me.Rpl.OnHoverImage = Nothing
        Me.Rpl.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Rpl.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Rpl.Radius = 10
        Me.Rpl.Size = New System.Drawing.Size(34, 30)
        Me.Rpl.TabIndex = 23
        '
        'Avek
        '
        Me.Avek.AnimationHoverSpeed = 0.07!
        Me.Avek.AnimationSpeed = 0.03!
        Me.Avek.BaseColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Avek.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Avek.BorderSize = 10
        Me.Anim2S.SetDecoration(Me.Avek, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.Avek, Guna.UI.Animation.DecorationType.None)
        Me.Avek.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Avek.FocusedColor = System.Drawing.Color.Empty
        Me.Avek.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Avek.ForeColor = System.Drawing.Color.White
        Me.Avek.Image = Nothing
        Me.Avek.ImageSize = New System.Drawing.Size(92, 92)
        Me.Avek.Location = New System.Drawing.Point(37, 19)
        Me.Avek.Name = "Avek"
        Me.Avek.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Avek.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Avek.OnHoverForeColor = System.Drawing.Color.White
        Me.Avek.OnHoverImage = Nothing
        Me.Avek.OnPressedColor = System.Drawing.Color.Black
        Me.Avek.Size = New System.Drawing.Size(92, 92)
        Me.Avek.TabIndex = 22
        '
        'volbtn
        '
        Me.volbtn.AnimationHoverSpeed = 0.07!
        Me.volbtn.AnimationSpeed = 0.03!
        Me.volbtn.BackColor = System.Drawing.Color.Transparent
        Me.volbtn.BaseColor = System.Drawing.Color.Transparent
        Me.volbtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.volbtn.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.volbtn.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.volbtn.CheckedForeColor = System.Drawing.Color.White
        Me.volbtn.CheckedImage = CType(resources.GetObject("volbtn.CheckedImage"), System.Drawing.Image)
        Me.volbtn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Anim2S.SetDecoration(Me.volbtn, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.volbtn, Guna.UI.Animation.DecorationType.None)
        Me.volbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.volbtn.FocusedColor = System.Drawing.Color.Empty
        Me.volbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.volbtn.ForeColor = System.Drawing.Color.Silver
        Me.volbtn.Image = CType(resources.GetObject("volbtn.Image"), System.Drawing.Image)
        Me.volbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.volbtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.volbtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.volbtn.Location = New System.Drawing.Point(1145, 52)
        Me.volbtn.Name = "volbtn"
        Me.volbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.volbtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.volbtn.OnHoverForeColor = System.Drawing.Color.White
        Me.volbtn.OnHoverImage = Nothing
        Me.volbtn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.volbtn.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.volbtn.Radius = 10
        Me.volbtn.Size = New System.Drawing.Size(30, 27)
        Me.volbtn.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Anim.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.Anim2S.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1175, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "20%"
        '
        'GunaTrackBarX
        '
        Me.Anim2S.SetDecoration(Me.GunaTrackBarX, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.GunaTrackBarX, Guna.UI.Animation.DecorationType.None)
        Me.GunaTrackBarX.Location = New System.Drawing.Point(1073, 54)
        Me.GunaTrackBarX.Name = "GunaTrackBarX"
        Me.GunaTrackBarX.Size = New System.Drawing.Size(101, 23)
        Me.GunaTrackBarX.TabIndex = 11
        Me.GunaTrackBarX.TrackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.GunaTrackBarX.TrackHoverColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.GunaTrackBarX.TrackIdleColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.GunaTrackBarX.TrackPressedColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.GunaTrackBarX.Value = 20
        Me.GunaTrackBarX.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Anim.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.Anim2S.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(215, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "00:00"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.Animated = True
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = CType(resources.GetObject("GunaAdvenceButton3.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Anim2S.SetDecoration(Me.GunaAdvenceButton3, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.GunaAdvenceButton3, Guna.UI.Animation.DecorationType.None)
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.Image = CType(resources.GetObject("GunaAdvenceButton3.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(540, 80)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.Silver
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton3.Radius = 10
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(34, 30)
        Me.GunaAdvenceButton3.TabIndex = 9
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.Animated = True
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = CType(resources.GetObject("GunaAdvenceButton2.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Anim2S.SetDecoration(Me.GunaAdvenceButton2, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.GunaAdvenceButton2, Guna.UI.Animation.DecorationType.None)
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = CType(resources.GetObject("GunaAdvenceButton2.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(620, 80)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.Silver
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaAdvenceButton2.Radius = 10
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(34, 30)
        Me.GunaAdvenceButton2.TabIndex = 8
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
        Me.Anim2S.SetDecoration(Me.Startp, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.Startp, Guna.UI.Animation.DecorationType.None)
        Me.Startp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Startp.FocusedColor = System.Drawing.Color.Empty
        Me.Startp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Startp.ForeColor = System.Drawing.Color.White
        Me.Startp.Image = CType(resources.GetObject("Startp.Image"), System.Drawing.Image)
        Me.Startp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Startp.ImageSize = New System.Drawing.Size(14, 14)
        Me.Startp.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Startp.Location = New System.Drawing.Point(580, 80)
        Me.Startp.Name = "Startp"
        Me.Startp.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Startp.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Startp.OnHoverForeColor = System.Drawing.Color.Silver
        Me.Startp.OnHoverImage = Nothing
        Me.Startp.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Startp.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Startp.Radius = 10
        Me.Startp.Size = New System.Drawing.Size(34, 30)
        Me.Startp.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Anim.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.Anim2S.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1003, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "00:00"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Anim.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.Anim2S.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(139, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(945, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nothing is being played now..."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'trackposition
        '
        Me.Anim2S.SetDecoration(Me.trackposition, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me.trackposition, Guna.UI.Animation.DecorationType.None)
        Me.trackposition.Location = New System.Drawing.Point(269, 53)
        Me.trackposition.Name = "trackposition"
        Me.trackposition.Size = New System.Drawing.Size(732, 23)
        Me.trackposition.TabIndex = 5
        Me.trackposition.TrackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.trackposition.TrackHoverColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.trackposition.TrackIdleColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.trackposition.TrackPressedColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.trackposition.Value = 0
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Anim.SetDecoration(Me.Label7, Guna.UI.Animation.DecorationType.None)
        Me.Anim2S.SetDecoration(Me.Label7, Guna.UI.Animation.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(393, 512)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(436, 76)
        Me.Label7.TabIndex = 18
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Anim.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Anim2S.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(419, 483)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'AAOp
        '
        Me.AAOp.FileName = "Select your song"
        Me.AAOp.Filter = "MP3-Files|*.mp3|WMA-Files|*.wma"""
        Me.AAOp.Multiselect = True
        Me.AAOp.Tag = "mp3"
        Me.AAOp.Title = "Select song"
        '
        'ChangeAvatar
        '
        Me.ChangeAvatar.FileName = "AVEK"
        Me.ChangeAvatar.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png"
        '
        'Timer1
        '
        '
        'Anim
        '
        Me.Anim.AnimationType = Guna.UI.Animation.AnimationType.Transparent
        Me.Anim.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 1.0!
        Me.Anim.DefaultAnimation = Animation2
        '
        'Anim2S
        '
        Me.Anim2S.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        Me.Anim2S.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Anim2S.DefaultAnimation = Animation1
        '
        'checking
        '
        Me.checking.Interval = 1000
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 98
        Me.GunaElipse2.TargetControl = Me.Avek
        '
        'ICONx
        '
        Me.ICONx.BalloonTipText = "DragonPlayer"
        Me.ICONx.BalloonTipTitle = "DragonPlayer"
        Me.ICONx.Icon = CType(resources.GetObject("ICONx.Icon"), System.Drawing.Icon)
        Me.ICONx.Text = "Dragon-Player"
        Me.ICONx.Visible = True
        '
        'BgzP
        '
        Me.BgzP.FileName = "Select image"
        Me.BgzP.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png"
        Me.BgzP.Title = "Select image"
        '
        'DragonPlayerMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 777)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.Anim2S.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.Anim.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DragonPlayerMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DragonPlayerMain"
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents PlayerX As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AAOp As OpenFileDialog
    Friend WithEvents ChangeAvatar As OpenFileDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TrackList As ListBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Anim As Guna.UI.WinForms.GunaTransition
    Friend WithEvents hhide As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Anim2S As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents checking As Timer
    Friend WithEvents GunaAdvenceButton6 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton5 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents ICONx As NotifyIcon
    Friend WithEvents Bar As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Rpl As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Avek As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents volbtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label6 As Label
    Friend WithEvents GunaTrackBarX As Guna.UI.WinForms.GunaTrackBar
    Friend WithEvents Label5 As Label
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Startp As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents trackposition As Guna.UI.WinForms.GunaTrackBar
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents BgzP As OpenFileDialog
    Friend WithEvents MiniPlayerX As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton7 As Guna.UI.WinForms.GunaAdvenceButton
End Class
