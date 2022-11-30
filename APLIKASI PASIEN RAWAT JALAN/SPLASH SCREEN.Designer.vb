<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.pb_loading = New System.Windows.Forms.ProgressBar()
        Me.lbl_Persentase = New System.Windows.Forms.Label()
        Me.lbl_Loading = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_loading
        '
        Me.pb_loading.Location = New System.Drawing.Point(48, 347)
        Me.pb_loading.Name = "pb_loading"
        Me.pb_loading.Size = New System.Drawing.Size(455, 10)
        Me.pb_loading.TabIndex = 10
        Me.pb_loading.UseWaitCursor = True
        '
        'lbl_Persentase
        '
        Me.lbl_Persentase.AutoSize = True
        Me.lbl_Persentase.Location = New System.Drawing.Point(312, 331)
        Me.lbl_Persentase.Name = "lbl_Persentase"
        Me.lbl_Persentase.Size = New System.Drawing.Size(13, 13)
        Me.lbl_Persentase.TabIndex = 9
        Me.lbl_Persentase.Text = "0"
        Me.lbl_Persentase.UseWaitCursor = True
        '
        'lbl_Loading
        '
        Me.lbl_Loading.AutoSize = True
        Me.lbl_Loading.Location = New System.Drawing.Point(225, 331)
        Me.lbl_Loading.Name = "lbl_Loading"
        Me.lbl_Loading.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Loading.TabIndex = 8
        Me.lbl_Loading.Text = "Loading...."
        Me.lbl_Loading.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = " APLIKASI PASIEN RAWAT JALAN"
        Me.Label1.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(456, 271)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'Timer1
        '
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(553, 376)
        Me.ControlBox = False
        Me.Controls.Add(Me.pb_loading)
        Me.Controls.Add(Me.lbl_Persentase)
        Me.Controls.Add(Me.lbl_Loading)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_loading As ProgressBar
    Friend WithEvents lbl_Persentase As Label
    Friend WithEvents lbl_Loading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
