Imports System.Data.Odbc
Public Class Form_Login
    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        'TUTUP SAAT KLIK CANCEL
        Me.Hide()
    End Sub
    Sub Terbuka()
        Form_Utama.LoginToolStripMenuItem1.Enabled = False
        Form_Utama.LogoutToolStripMenuItem1.Enabled = True
        Form_Utama.AdminToolStripMenuItem.Enabled = True
        Form_Utama.FILEToolStripMenuItem.Enabled = True
        Form_Utama.AKTIVITAS.Enabled = True
        Form_Utama.LAPORAN.Enabled = True
    End Sub
    Sub kondisiAwal()
        txt_kdAdmin.Text = ""
        txt_Password.Text = ""
    End Sub
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If txt_kdAdmin.Text = "" Or txt_Password.Text = " " Then
            MsgBox("KODE ADMIN DAN PASSWORD TIDAK BOLEH KOSONG")
        Else
            Call koneksi()
            cmd = New OdbcCommand("Select * from tbl_admin where kode_admin= '" & txt_kdAdmin.Text & "' AND password = '" & txt_Password.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Me.Close()
                Call Terbuka()
            Else
                MsgBox("KODE ADMIN ATAU PASSWORD SALAH")
            End If

        End If
    End Sub

    Private Sub Txt_Username_TextChanged(sender As Object, e As EventArgs) Handles txt_kdAdmin.TextChanged

    End Sub

    Private Sub txt_Username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_kdAdmin.KeyPress
        'ganti txt menjadi keypress, 
        If e.KeyChar = Chr(13) Then
            txt_Password.Focus()
        End If
    End Sub

    Private Sub Txt_Password_TextChanged(sender As Object, e As EventArgs) Handles txt_Password.TextChanged

    End Sub

    Private Sub txt_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Password.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_Login.Focus()
        End If
    End Sub

    Private Sub Form_Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
End Class