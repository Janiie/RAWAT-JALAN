Imports System.Data.Odbc

Public Class Data_Pasien
    Private Sub Data_Pasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilData()
    End Sub
    Sub TampilData()
        txt_nop.Text = ""
        txt_namap.Text = ""
        txt_umurp.Text = ""
        txt_alamatp.Text = ""
        txt_telp.Text = ""
        cmb_jkp.Items.Clear()
        cmb_jkp.Text = ""
        txt_nop.Enabled = False
        txt_namap.Enabled = False
        txt_umurp.Enabled = False
        txt_alamatp.Enabled = False
        txt_telp.Enabled = False
        cmb_jkp.Enabled = False

        btn_input.Enabled = True
        btn_edit.Enabled = True
        btn_hapus.Enabled = True

        btn_input.Text = "Input"
        btn_edit.Text = "Edit"
        btn_hapus.Text = "Hapus"
        btn_tutup.Text = "Tutup"
        Call koneksi()
        da = New OdbcDataAdapter("Select * From tbl_Pasien", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_Pasien")

        dg_dtpasien.DataSource = ds.Tables("tbl_pasien")
        dg_dtpasien.ReadOnly = True
    End Sub
    Sub SiapIsi()
        txt_nop.Enabled = True
        txt_namap.Enabled = True
        txt_umurp.Enabled = True
        txt_alamatp.Enabled = True
        txt_telp.Enabled = True
        cmb_jkp.Enabled = True
        cmb_jkp.Items.Add("Laki-Laki")
        cmb_jkp.Items.Add("Perempuan")
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
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
            If txt_nop.Text = "" Or txt_namap.Text = "" Or txt_umurp.Text = "" Or cmb_jkp.Text = "" Or txt_alamatp.Text = "" Or txt_telp.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                'untuk menyimpan data yang sudah di input
                Call koneksi()
                Dim InputData As String = "Insert into tbl_Pasien values('" & txt_nop.Text & "', '" & txt_namap.Text & "', '" & txt_umurp.Text & "','" & cmb_jkp.Text & "', '" & txt_alamatp.Text & "', '" & txt_telp.Text & "')"
                cmd = New OdbcCommand(InputData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call TampilData()

            End If
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
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
            If txt_nop.Text = "" Or txt_namap.Text = "" Or txt_umurp.Text = "" Or cmb_jkp.Text = "" Or txt_alamatp.Text = "" Or txt_telp.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                'untuk menyimpan data yang sudah di update
                Call koneksi()
                Dim UpdateData As String = "Update tbl_pasien set nama_pasien= '" & txt_namap.Text & "', jenis_kelamin= '" & cmb_jkp.Text & "', umur_pasien='" & txt_umurp.Text & "', alamat_pasien= '" & txt_alamatp.Text & "', tlp_pasien= '" & txt_telp.Text & "'where no_pasien='" & txt_nop.Text & "'"
                cmd = New OdbcCommand(UpdateData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil")
                Call TampilData()

            End If
        End If
    End Sub

    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        Me.Close()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
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
            If txt_nop.Text = "" Or txt_namap.Text = "" Or txt_umurp.Text = "" Or cmb_jkp.Text = "" Or txt_alamatp.Text = "" Or txt_telp.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                'untuk menyimpan data yang sudah di update
                Call koneksi()
                Dim HapusData As String = "Delete from tbl_Pasien where no_pasien='" & txt_nop.Text & "'"
                cmd = New OdbcCommand(HapusData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call TampilData()

            End If
        End If
    End Sub

    Private Sub txt_nop_TextChanged(sender As Object, e As EventArgs) Handles txt_nop.TextChanged

    End Sub

    Private Sub txt_nop_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nop.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OdbcCommand("Select * From tbl_Pasien where no_pasien '" & txt_nop.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("No Pasien tidak ada")
            Else
                txt_nop.Text = dr.Item("no_pasien")
                txt_namap.Text = dr.Item("nama_pasien")
                txt_umurp.Text = dr.Item("umur")
                cmb_jkp.Text = dr.Item("jenis_kelamin")
                txt_alamatp.Text = dr.Item("alamat")
                txt_telp.Text = dr.Item("telepon")
            End If
        End If
    End Sub

    Private Sub dg_dtpasien_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_dtpasien.CellContentDoubleClick
        If dg_dtpasien.RowCount > 0 Then
            Dim i As Integer
            With dg_dtpasien
                i = .CurrentRow.Index
                txt_nop.Text = .Item(0, i).Value
                txt_namap.Text = .Item(1, i).Value
                cmb_jkp.Text = .Item(2, i).Value
                txt_umurp.Text = .Item(3, i).Value
                txt_alamatp.Text = .Item(4, i).Value
                txt_telp.Focus()
            End With
        End If
    End Sub
End Class