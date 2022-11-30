Public Class Form_Utama
    Sub Terkunci()
        LoginToolStripMenuItem1.Enabled = True
        LogoutToolStripMenuItem1.Enabled = False
        FILEToolStripMenuItem.Enabled = False
        AKTIVITAS.Enabled = False
        LAPORAN.Enabled = False
        AdminToolStripMenuItem.Enabled = False
    End Sub
    Private Sub Form_Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub DataPasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPasienToolStripMenuItem.Click
        Data_Pasien.Show()
    End Sub

    Private Sub DataDokterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDokterToolStripMenuItem.Click
        Data_Dokter.Show()
    End Sub

    Private Sub DataObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataObatToolStripMenuItem.Click
        FormDataObat.Show()
    End Sub

    Private Sub DataDiagnosaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataDiagnosaToolStripMenuItem1.Click
        Form_Pemeriksaan.Show()
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        Form_Login.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        Call Terkunci()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Admin.ShowDialog()

    End Sub
End Class