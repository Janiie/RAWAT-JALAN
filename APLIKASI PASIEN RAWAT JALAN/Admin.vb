Imports System.Data.Odbc
Public Class Admin
    Sub KondisiAwal()
        txt_kdAdmin.Text = ""
        txt_nmAdmin.Text = ""
        txt_pencarian.Text = ""
        cmb_lvl.Items.Clear()
        cmb_lvl.Text = ""
        txt_kdAdmin.Enabled = False
        txt_nmAdmin.Enabled = False
        txt_pencarian.Enabled = False
        cmb_lvl.Enabled = False

        btn_input.Enabled = True
        btn_edit.Enabled = True
        btn_hapus.Enabled = True

        btn_input.Text = "Input"
        btn_edit.Text = "Edit"
        btn_hapus.Text = "Hapus"
        btn_tutup.Text = "Tutup"
        Call koneksi()
        da = New OdbcDataAdapter("Select kode_admin,nama_admin,level From tbl_Admin", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_Admin")
        dg_dtadmin.DataSource = ds.Tables("tbl_Admin")
        dg_dtadmin.ReadOnly = True

    End Sub
    Sub SiapIsi()
        txt_kdAdmin.Enabled = True
        txt_nmAdmin.Enabled = True
        txt_pencarian.Enabled = True
        cmb_lvl.Enabled = True
        cmb_lvl.Items.Add("ADMIN")
        cmb_lvl.Items.Add("USER")
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        'ketika input di klik maka tombol input akan berubah menjadi tombol simpan
        If btn_input.Text = "Input" Then
            btn_input.Text = "Simpan"
            'tombol edit & hapus akan terkunci
            btn_edit.Enabled = False
            btn_hapus.Enabled = False
            'tombol tutup akan berubah menjadi tombol batal
            btn_tutup.Text = "Batal"
            Call SiapIsi()
        Else
            'validasi untuk field yang kosong
            If txt_kdAdmin.Text = "" Or txt_nmAdmin.Text = "" Or txt_psswrd.Text = "" Or cmb_lvl.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                'untuk menyimpan data yang sudah di input
                Call koneksi()
                Dim InputData As String = "Insert into tbl_Admin values('" & txt_kdAdmin.Text & "', '" & txt_nmAdmin.Text & "', '" & txt_psswrd.Text & "','" & cmb_lvl.Text & "')"
                cmd = New OdbcCommand(InputData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call KondisiAwal()

            End If
        End If

    End Sub

    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        'ketika edit di klik maka tombol edit akan berubah menjadi tombol simpan
        If btn_edit.Text = "Edit" Then
            btn_edit.Text = "Simpan"
            'tombol edit & hapus akan terkunci
            btn_input.Enabled = False
            btn_hapus.Enabled = False
            'tombol tutup akan berubah menjadi tombol batal
            btn_tutup.Text = "Batal"
            Call SiapIsi()
        Else
            'validasi untuk field yang kosong
            If txt_kdAdmin.Text = "" Or txt_nmAdmin.Text = "" Or txt_psswrd.Text = "" Or cmb_lvl.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                'untuk menyimpan data yang sudah di update
                Call koneksi()
                Dim UpdateData As String = "Update tbl_Admin set nama_admin= '" & txt_nmAdmin.Text & "', password= '" & txt_psswrd.Text & "', level'" & cmb_lvl.Text & "', where kode_admin='" & txt_kdAdmin.Text & "'"
                cmd = New OdbcCommand(UpdateData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil")
                Call KondisiAwal()

            End If
        End If
    End Sub

    Private Sub Txt_kdAdmin_TextChanged(sender As Object, e As EventArgs) Handles txt_kdAdmin.TextChanged

    End Sub

    Private Sub txt_kdAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_kdAdmin.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OdbcCommand("Select * From tbl_admin where kode_admin '" & txt_kdAdmin.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("Kode Admin tidak ada")
            Else
                txt_kdAdmin.Text = dr.Item("kode_admin")
                txt_nmAdmin.Text = dr.Item("nama_admin")
                txt_psswrd.Text = dr.Item("password")
                cmb_lvl.Text = dr.Item("level_admin")
            End If
        End If
    End Sub

    Private Sub Btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        If btn_tutup.Text = "tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        'ketikahapus di klik maka tombol hapus akan berubah menjadi tombol delete
        If btn_hapus.Text = "Hapus" Then
            btn_hapus.Text = "Delete"
            'tombol edit & input akan terkunci
            btn_input.Enabled = False
            btn_edit.Enabled = False
            'tombol tutup akan berubah menjadi tombol batal
            btn_tutup.Text = "Batal"
            Call SiapIsi()
        Else
            'validasi untuk field yang kosong
            If txt_kdAdmin.Text = "" Or txt_nmAdmin.Text = "" Or txt_psswrd.Text = "" Or cmb_lvl.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                'untuk menyimpan data yang sudah di update
                Call koneksi()
                Dim HapusData As String = "Delete from tbl_Admin where kode_admin='" & txt_kdAdmin.Text & "'"
                cmd = New OdbcCommand(HapusData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call KondisiAwal()

            End If
        End If
    End Sub

    Private Sub dg_dtadmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_dtadmin.CellContentClick

    End Sub
End Class