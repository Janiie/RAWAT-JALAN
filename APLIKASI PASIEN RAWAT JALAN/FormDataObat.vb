Imports System.Data.Odbc
Public Class FormDataObat
    Private Sub FormDataObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilData()
    End Sub
    Sub TampilData()
        txt_kodeO.Text = ""
        txt_namaO.Text = ""
        Cmb_satuan.Items.Clear()
        Cmb_satuan.Text = ""
        txt_hargaO.Text = ""

        txt_kodeO.Enabled = False
        txt_namaO.Enabled = False
        Cmb_satuan.Enabled = False
        txt_hargaO.Enabled = False

        btn_input.Enabled = True
        btn_edit.Enabled = True
        btn_hapus.Enabled = True

        btn_input.Text = "Input"
        btn_edit.Text = "Edit"
        btn_hapus.Text = "Hapus"
        btn_tutup.Text = "Tutup"
        Call koneksi()
        da = New OdbcDataAdapter("Select * From tbl_obat", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_obat")

        dg_dtobat.DataSource = ds.Tables("tbl_obat")
        dg_dtobat.ReadOnly = True

    End Sub
    Sub SiapIsi()
        txt_kodeO.Enabled = True
        txt_namaO.Enabled = True
        Cmb_satuan.Enabled = True
        txt_hargaO.Enabled = True
        Cmb_satuan.Items.Add("Tablet")
        Cmb_satuan.Items.Add("capsul")
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
            If txt_kodeO.Text = "" Or txt_namaO.Text = "" Or Cmb_satuan.Text = "" Or txt_hargaO.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                'untuk menyimpan data yang sudah di input
                Call koneksi()
                Dim InputData As String = "Insert into tbl_Obat values('" & txt_kodeO.Text & "', '" & txt_namaO.Text & "', '" & Cmb_satuan.Text & "','" & txt_hargaO.Text & "')"
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
            If txt_kodeO.Text = "" Or txt_namaO.Text = "" Or Cmb_satuan.Text = "" Or txt_hargaO.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                'untuk menyimpan data yang sudah di update
                Call koneksi()
                Dim UpdateData As String = "Update tbl_obat set nama_obat='" & txt_namaO.Text & "', satuan= '" & Cmb_satuan.Text & "', harga= '" & txt_hargaO.Text & "' where kode_obat='" & txt_kodeO.Text & "'"
                cmd = New OdbcCommand(UpdateData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil")
                Call TampilData()

            End If
        End If
    End Sub


    Private Sub Btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        If btn_tutup.Text = "tutup" Then
            Me.Close()
        Else
            Call TampilData()
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
            If txt_kodeO.Text = "" Or txt_namaO.Text = "" Or Cmb_satuan.Text = "" Or txt_hargaO.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                'untuk menyimpan data yang sudah di update
                Call koneksi()
                Dim HapusData As String = "Delete From tbl_Obat where kode_obat='" & txt_kodeO.Text & "'"
                cmd = New OdbcCommand(HapusData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call TampilData()

            End If
        End If
    End Sub

    Private Sub Txt_kodeO_TextChanged(sender As Object, e As EventArgs) Handles txt_kodeO.TextChanged

    End Sub

    Private Sub txt_kodeO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_kodeO.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OdbcCommand("Select * From tbl_obat where kode_obat '" & txt_kodeO.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("Kode Obat tidak ada")
            Else
                txt_kodeO.Text = dr.Item("kode_obat")
                txt_namaO.Text = dr.Item("nama_obat")
                Cmb_satuan.Text = dr.Item("satuan")
                txt_hargaO.Text = dr.Item("harga")
            End If
        End If
    End Sub
    Private Sub dg_dtobat_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_dtobat.CellContentDoubleClick
        If dg_dtobat.RowCount > 0 Then
            Dim i As Integer
            With dg_dtobat
                i = .CurrentRow.Index
                txt_kodeO.Text = .Item(0, i).Value
                txt_namaO.Text = .Item(1, i).Value
                Cmb_satuan.Text = .Item(2, i).Value
                txt_hargaO.Text = .Item(3, i).Value
            End With
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_satuan.SelectedIndexChanged

    End Sub
End Class