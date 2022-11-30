Imports System.Data.Odbc
Public Class Data_Dokter
    Private Sub Data_Dokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilData()
    End Sub
    Sub TampilData()
        txt_nipd.Text = ""
        txt_namad.Text = ""
        txt_spesialis.Text = ""
        txt_alamatd.Text = ""
        txt_telpd.Text = ""

        txt_nipd.Enabled = False
        txt_namad.Enabled = False
        txt_spesialis.Enabled = False
        txt_alamatd.Enabled = False
        txt_telpd.Enabled = False

        btn_input.Enabled = True
        btn_edit.Enabled = True
        btn_hapus.Enabled = True

        btn_input.Text = "Input"
        btn_edit.Text = "Edit"
        btn_hapus.Text = "Hapus"
        btn_tutup.Text = "Tutup"
        Call koneksi()
        da = New OdbcDataAdapter("Select * From tbl_dokter", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_Dokter")

        dg_dtdokter.DataSource = ds.Tables("tbl_dokter")
        dg_dtdokter.ReadOnly = True

    End Sub
    Sub SiapIsi()
        txt_nipd.Enabled = True
        txt_namad.Enabled = True
        txt_spesialis.Enabled = True
        txt_alamatd.Enabled = True
        txt_telpd.Enabled = True

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
            If txt_nipd.Text = "" Or txt_namad.Text = "" Or txt_spesialis.Text = "" Or txt_alamatd.Text = "" Or txt_telpd.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                'untuk menyimpan data yang sudah di input
                Call koneksi()
                Dim InputData As String = "Insert into tbl_dokter values('" & txt_nipd.Text & "', '" & txt_namad.Text & "', '" & txt_spesialis.Text & "', '" & txt_alamatd.Text & "', '" & txt_telpd.Text & "')"
                cmd = New OdbcCommand(InputData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call TampilData()

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
            If txt_nipd.Text = "" Or txt_namad.Text = "" Or txt_spesialis.Text = "" Or txt_alamatd.Text = "" Or txt_telpd.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                'untuk menyimpan data yang sudah di update
                Call koneksi()
                Dim UpdateData As String = "Update tbl_dokter set nip_dokter= '" & txt_nipd.Text & "', nama_dokter= '" & txt_namad.Text & "', spesialis= '" & txt_spesialis.Text & "', alamat_dokter= '" & txt_alamatd.Text & "', tlp_dokter='" & txt_telpd.Text & "'"
                cmd = New OdbcCommand(UpdateData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil")
                Call TampilData()

            End If
        End If
    End Sub


    Private Sub Btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        Me.Close()
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
            If txt_nipd.Text = "" Or txt_namad.Text = "" Or txt_spesialis.Text = "" Or txt_alamatd.Text = "" Or txt_telpd.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                'untuk menyimpan data yang sudah di update
                Call koneksi()
                Dim HapusData As String = "Delete From tbl_Dokter where no_pasien='" & txt_nipd.Text & "'"
                cmd = New OdbcCommand(HapusData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call TampilData()

            End If
        End If
    End Sub

    Private Sub Txt_nipd_TextChanged(sender As Object, e As EventArgs) Handles txt_nipd.TextChanged

    End Sub

    Private Sub txt_nipd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nipd.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OdbcCommand("Select * From tbl_Dokter where nip_dokter '" & txt_nipd.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("NIP Dokter tidak ada")
            Else
                txt_nipd.Text = dr.Item("nip_dokter")
                txt_namad.Text = dr.Item("nama_dokter")
                txt_spesialis.Text = dr.Item("spesialis")
                txt_alamatd.Text = dr.Item("alamat")
                txt_telpd.Text = dr.Item("telepon")
            End If
        End If
    End Sub



    Private Sub dg_dtdokter_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_dtdokter.CellDoubleClick
        If dg_dtdokter.RowCount > 0 Then
            Dim i As Integer
            With dg_dtdokter
                i = .CurrentRow.Index
                txt_nipd.Text = .Item(0, i).Value
                txt_namad.Text = .Item(1, i).Value
                txt_spesialis.Text = .Item(2, i).Value
                txt_alamatd.Text = .Item(3, i).Value
                txt_telpd.Text = .Item(4, i).Value
                txt_nipd.Focus()
            End With
        End If
    End Sub
End Class