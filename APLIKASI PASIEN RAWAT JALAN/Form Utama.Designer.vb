<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Utama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDokterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataPasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAporanDataDiagnosaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDiagnosaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AKTIVITASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDiagnosaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AKTIVITAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.FILEToolStripMenuItem, Me.AKTIVITAS, Me.LAPORAN})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem1, Me.LogoutToolStripMenuItem1, Me.AdminToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(58, 20)
        Me.ToolStripMenuItem1.Text = "ADMIN"
        Me.ToolStripMenuItem1.ToolTipText = "Admin"
        '
        'LoginToolStripMenuItem1
        '
        Me.LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        Me.LoginToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem1.Text = "Login"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPasienToolStripMenuItem, Me.DataDokterToolStripMenuItem, Me.DataObatToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'DataPasienToolStripMenuItem
        '
        Me.DataPasienToolStripMenuItem.Name = "DataPasienToolStripMenuItem"
        Me.DataPasienToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataPasienToolStripMenuItem.Text = "Data Pasien"
        '
        'DataDokterToolStripMenuItem
        '
        Me.DataDokterToolStripMenuItem.Name = "DataDokterToolStripMenuItem"
        Me.DataDokterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataDokterToolStripMenuItem.Text = "Data Dokter"
        '
        'DataObatToolStripMenuItem
        '
        Me.DataObatToolStripMenuItem.Name = "DataObatToolStripMenuItem"
        Me.DataObatToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataObatToolStripMenuItem.Text = "Data Obat"
        '
        'LAPORAN
        '
        Me.LAPORAN.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDataPasienToolStripMenuItem, Me.LAporanDataDiagnosaToolStripMenuItem})
        Me.LAPORAN.Name = "LAPORAN"
        Me.LAPORAN.Size = New System.Drawing.Size(73, 20)
        Me.LAPORAN.Text = "LAPORAN"
        '
        'LaporanDataPasienToolStripMenuItem
        '
        Me.LaporanDataPasienToolStripMenuItem.Name = "LaporanDataPasienToolStripMenuItem"
        Me.LaporanDataPasienToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.LaporanDataPasienToolStripMenuItem.Text = "Laporan Data Pasien"
        '
        'LAporanDataDiagnosaToolStripMenuItem
        '
        Me.LAporanDataDiagnosaToolStripMenuItem.Name = "LAporanDataDiagnosaToolStripMenuItem"
        Me.LAporanDataDiagnosaToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.LAporanDataDiagnosaToolStripMenuItem.Text = "Laporan Data Diagnosa"
        '
        'DataDiagnosaToolStripMenuItem
        '
        Me.DataDiagnosaToolStripMenuItem.Name = "DataDiagnosaToolStripMenuItem"
        Me.DataDiagnosaToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DataDiagnosaToolStripMenuItem.Text = "Data Diagnosa"
        '
        'AKTIVITASToolStripMenuItem
        '
        Me.AKTIVITASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataDiagnosaToolStripMenuItem})
        Me.AKTIVITASToolStripMenuItem.Name = "AKTIVITASToolStripMenuItem"
        Me.AKTIVITASToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.AKTIVITASToolStripMenuItem.Text = "AKTIVITAS"
        '
        'DataDiagnosaToolStripMenuItem1
        '
        Me.DataDiagnosaToolStripMenuItem1.Name = "DataDiagnosaToolStripMenuItem1"
        Me.DataDiagnosaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DataDiagnosaToolStripMenuItem1.Text = "Data Diagnosa"
        '
        'AKTIVITAS
        '
        Me.AKTIVITAS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataDiagnosaToolStripMenuItem1})
        Me.AKTIVITAS.Name = "AKTIVITAS"
        Me.AKTIVITAS.Size = New System.Drawing.Size(72, 20)
        Me.AKTIVITAS.Text = "AKTIVITAS"
        '
        'Form_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form_Utama"
        Me.Text = "Form_Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPasienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataDokterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataObatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataDiagnosaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AKTIVITASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LAPORAN As ToolStripMenuItem
    Friend WithEvents LaporanDataPasienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LAporanDataDiagnosaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AKTIVITAS As ToolStripMenuItem
    Friend WithEvents DataDiagnosaToolStripMenuItem1 As ToolStripMenuItem
End Class
