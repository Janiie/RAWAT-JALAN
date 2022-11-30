Imports System.Data.Odbc
Public Class Form_Pemeriksaan
    Private Sub txt_nopendaftar_TextChanged(sender As Object, e As EventArgs) Handles txt_nopendaftar.TextChanged

    End Sub

    Private Sub Form_Pemeriksaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Sub TampilData()
        txt_nopendaftar.Text = ""
        txt_biayaperiksa.Text = ""
        txt_diagnosa.Text = ""
        txt_hargaobat.Text = ""
        txt_kodeobat.Text = ""
        txt_jumlahobat.Text = ""
        txt_nipdokter.Text = ""
        txt_nopasien.Text = ""
        txt_resep.Text = ""
        txt_totalpembayaran.Text = ""
        cmb_tglPeriksa.Items.Clear()
        cmb_namadokter.Items.Clear()
        cmb_namapasien.Items.Clear()
        cmb_namaobat.Items.Clear()

        txt_nopendaftar.Text = False
        txt_biayaperiksa.Text = False
        txt_diagnosa.Text = False
        txt_hargaobat.Text = False
        txt_kodeobat.Text = False
        txt_jumlahobat.Text = False
        txt_nipdokter.Text = False
        txt_nopasien.Text = False
        txt_resep.Text = False
        txt_totalpembayaran.Text = False
        cmb_tglPeriksa.Text = False
        cmb_namadokter.Text = False
        cmb_namapasien.Text = False
        cmb_namaobat.Text = False

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

        dg_dtpemriksaan.DataSource = ds.Tables("tbl_Pasien")
        dg_dtpemriksaan.ReadOnly = True

    End Sub
    Sub SiapIsi()

        txt_nopendaftar.Text = True
        txt_biayaperiksa.Text = True
        txt_diagnosa.Text = True
        txt_hargaobat.Text = True
        txt_kodeobat.Text = True
        txt_jumlahobat.Text = True
        txt_nipdokter.Text = True
        txt_nopasien.Text = True
        txt_resep.Text = True
        txt_totalpembayaran.Text = True

        If cmb_tglPeriksa.Text =
        cmb_namadokter.Text =
        cmb_namapasien.Text = False Then
            cmb_namaobat.Text = False
        End If
    End Sub
    Private Sub cmb_namapasien_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_namapasien.KeyPress
        If e.KeyChar = Chr(13) Then
            cmb_namapasien.Text = UCase(cmb_namapasien.Text)
            txt_nopasien.Focus()

        End If
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click

    End Sub
End Class