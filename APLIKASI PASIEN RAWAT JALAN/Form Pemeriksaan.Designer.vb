<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Pemeriksaan
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
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dg_dtpemriksaan = New System.Windows.Forms.DataGridView()
        Me.cmb_namapasien = New System.Windows.Forms.ComboBox()
        Me.txt_diagnosa = New System.Windows.Forms.TextBox()
        Me.txt_nopendaftar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tglPeriksa = New System.Windows.Forms.ComboBox()
        Me.txt_nopasien = New System.Windows.Forms.TextBox()
        Me.txt_nipdokter = New System.Windows.Forms.TextBox()
        Me.cmb_namadokter = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_pencarian = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_hargaobat = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_jumlahobat = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_biayaperiksa = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_totalpembayaran = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_kodeobat = New System.Windows.Forms.TextBox()
        Me.cmb_namaobat = New System.Windows.Forms.ComboBox()
        Me.txt_resep = New System.Windows.Forms.TextBox()
        Me.btn_tutup = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        CType(Me.dg_dtpemriksaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Location = New System.Drawing.Point(419, 684)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(39, 23)
        Me.btn_ok.TabIndex = 83
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(147, 688)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 15)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = ":"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(174, 686)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(228, 20)
        Me.TextBox1.TabIndex = 81
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 688)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 15)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Pencarian"
        '
        'dg_dtpemriksaan
        '
        Me.dg_dtpemriksaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_dtpemriksaan.Location = New System.Drawing.Point(28, 413)
        Me.dg_dtpemriksaan.Name = "dg_dtpemriksaan"
        Me.dg_dtpemriksaan.Size = New System.Drawing.Size(552, 179)
        Me.dg_dtpemriksaan.TabIndex = 79
        '
        'cmb_namapasien
        '
        Me.cmb_namapasien.FormattingEnabled = True
        Me.cmb_namapasien.Location = New System.Drawing.Point(197, 108)
        Me.cmb_namapasien.Name = "cmb_namapasien"
        Me.cmb_namapasien.Size = New System.Drawing.Size(176, 21)
        Me.cmb_namapasien.TabIndex = 74
        '
        'txt_diagnosa
        '
        Me.txt_diagnosa.Location = New System.Drawing.Point(197, 180)
        Me.txt_diagnosa.Name = "txt_diagnosa"
        Me.txt_diagnosa.Size = New System.Drawing.Size(191, 20)
        Me.txt_diagnosa.TabIndex = 72
        '
        'txt_nopendaftar
        '
        Me.txt_nopendaftar.Location = New System.Drawing.Point(197, 55)
        Me.txt_nopendaftar.Name = "txt_nopendaftar"
        Me.txt_nopendaftar.Size = New System.Drawing.Size(212, 20)
        Me.txt_nopendaftar.TabIndex = 69
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(168, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 15)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(168, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 15)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(168, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 15)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(168, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 15)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(168, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 15)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(168, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 15)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Nama Obat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Resep"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Diagnosa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Nama Pasien"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 15)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Tanggal Periksa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 15)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "No.Pendaftaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 22)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "DATA PEMERIKSAAN"
        '
        'cmb_tglPeriksa
        '
        Me.cmb_tglPeriksa.FormattingEnabled = True
        Me.cmb_tglPeriksa.Location = New System.Drawing.Point(197, 81)
        Me.cmb_tglPeriksa.Name = "cmb_tglPeriksa"
        Me.cmb_tglPeriksa.Size = New System.Drawing.Size(176, 21)
        Me.cmb_tglPeriksa.TabIndex = 84
        '
        'txt_nopasien
        '
        Me.txt_nopasien.Location = New System.Drawing.Point(379, 108)
        Me.txt_nopasien.Name = "txt_nopasien"
        Me.txt_nopasien.Size = New System.Drawing.Size(201, 20)
        Me.txt_nopasien.TabIndex = 85
        '
        'txt_nipdokter
        '
        Me.txt_nipdokter.Location = New System.Drawing.Point(379, 141)
        Me.txt_nipdokter.Name = "txt_nipdokter"
        Me.txt_nipdokter.Size = New System.Drawing.Size(201, 20)
        Me.txt_nipdokter.TabIndex = 89
        '
        'cmb_namadokter
        '
        Me.cmb_namadokter.FormattingEnabled = True
        Me.cmb_namadokter.Location = New System.Drawing.Point(197, 141)
        Me.cmb_namadokter.Name = "cmb_namadokter"
        Me.cmb_namadokter.Size = New System.Drawing.Size(176, 21)
        Me.cmb_namadokter.TabIndex = 88
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 143)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 15)
        Me.Label17.TabIndex = 86
        Me.Label17.Text = "Nama Dokter"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(481, 601)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 23)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(144, 605)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(11, 15)
        Me.Label18.TabIndex = 105
        Me.Label18.Text = ":"
        '
        'txt_pencarian
        '
        Me.txt_pencarian.Location = New System.Drawing.Point(236, 603)
        Me.txt_pencarian.Name = "txt_pencarian"
        Me.txt_pencarian.Size = New System.Drawing.Size(228, 20)
        Me.txt_pencarian.TabIndex = 104
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(23, 605)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 15)
        Me.Label19.TabIndex = 103
        Me.Label19.Text = "Pencarian"
        '
        'txt_hargaobat
        '
        Me.txt_hargaobat.Location = New System.Drawing.Point(197, 252)
        Me.txt_hargaobat.Name = "txt_hargaobat"
        Me.txt_hargaobat.Size = New System.Drawing.Size(291, 20)
        Me.txt_hargaobat.TabIndex = 109
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(168, 254)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 15)
        Me.Label20.TabIndex = 108
        Me.Label20.Text = ":"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(25, 255)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 15)
        Me.Label21.TabIndex = 107
        Me.Label21.Text = "Harga Obat"
        '
        'txt_jumlahobat
        '
        Me.txt_jumlahobat.Location = New System.Drawing.Point(197, 283)
        Me.txt_jumlahobat.Name = "txt_jumlahobat"
        Me.txt_jumlahobat.Size = New System.Drawing.Size(291, 20)
        Me.txt_jumlahobat.TabIndex = 112
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(168, 285)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(11, 15)
        Me.Label22.TabIndex = 111
        Me.Label22.Text = ":"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(25, 286)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 15)
        Me.Label23.TabIndex = 110
        Me.Label23.Text = "Jumlah Obat"
        '
        'txt_biayaperiksa
        '
        Me.txt_biayaperiksa.Location = New System.Drawing.Point(197, 312)
        Me.txt_biayaperiksa.Name = "txt_biayaperiksa"
        Me.txt_biayaperiksa.Size = New System.Drawing.Size(291, 20)
        Me.txt_biayaperiksa.TabIndex = 115
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(168, 314)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(11, 15)
        Me.Label24.TabIndex = 114
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(25, 315)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(95, 15)
        Me.Label25.TabIndex = 113
        Me.Label25.Text = "Biaya Periksa"
        '
        'txt_totalpembayaran
        '
        Me.txt_totalpembayaran.Location = New System.Drawing.Point(197, 342)
        Me.txt_totalpembayaran.Name = "txt_totalpembayaran"
        Me.txt_totalpembayaran.Size = New System.Drawing.Size(291, 20)
        Me.txt_totalpembayaran.TabIndex = 118
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(168, 344)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 15)
        Me.Label26.TabIndex = 117
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(25, 345)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(125, 15)
        Me.Label27.TabIndex = 116
        Me.Label27.Text = "Total Pembayaran"
        '
        'txt_kodeobat
        '
        Me.txt_kodeobat.Location = New System.Drawing.Point(394, 217)
        Me.txt_kodeobat.Name = "txt_kodeobat"
        Me.txt_kodeobat.Size = New System.Drawing.Size(186, 20)
        Me.txt_kodeobat.TabIndex = 120
        '
        'cmb_namaobat
        '
        Me.cmb_namaobat.FormattingEnabled = True
        Me.cmb_namaobat.Location = New System.Drawing.Point(197, 217)
        Me.cmb_namaobat.Name = "cmb_namaobat"
        Me.cmb_namaobat.Size = New System.Drawing.Size(191, 21)
        Me.cmb_namaobat.TabIndex = 119
        '
        'txt_resep
        '
        Me.txt_resep.Location = New System.Drawing.Point(394, 180)
        Me.txt_resep.Name = "txt_resep"
        Me.txt_resep.Size = New System.Drawing.Size(186, 20)
        Me.txt_resep.TabIndex = 121
        '
        'btn_tutup
        '
        Me.btn_tutup.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tutup.Location = New System.Drawing.Point(419, 384)
        Me.btn_tutup.Name = "btn_tutup"
        Me.btn_tutup.Size = New System.Drawing.Size(87, 23)
        Me.btn_tutup.TabIndex = 125
        Me.btn_tutup.Text = "TUTUP"
        Me.btn_tutup.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.Location = New System.Drawing.Point(309, 384)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(87, 23)
        Me.btn_hapus.TabIndex = 124
        Me.btn_hapus.Text = "HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(197, 384)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(87, 23)
        Me.btn_edit.TabIndex = 123
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_input
        '
        Me.btn_input.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_input.Location = New System.Drawing.Point(90, 384)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(87, 23)
        Me.btn_input.TabIndex = 122
        Me.btn_input.Text = "INPUT"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'Form_Pemeriksaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 632)
        Me.Controls.Add(Me.btn_tutup)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_input)
        Me.Controls.Add(Me.txt_resep)
        Me.Controls.Add(Me.txt_kodeobat)
        Me.Controls.Add(Me.cmb_namaobat)
        Me.Controls.Add(Me.txt_totalpembayaran)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txt_biayaperiksa)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_jumlahobat)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txt_hargaobat)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_pencarian)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_nipdokter)
        Me.Controls.Add(Me.cmb_namadokter)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_nopasien)
        Me.Controls.Add(Me.cmb_tglPeriksa)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dg_dtpemriksaan)
        Me.Controls.Add(Me.cmb_namapasien)
        Me.Controls.Add(Me.txt_diagnosa)
        Me.Controls.Add(Me.txt_nopendaftar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Pemeriksaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Pemeriksaan"
        CType(Me.dg_dtpemriksaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ok As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dg_dtpemriksaan As DataGridView
    Friend WithEvents cmb_namapasien As ComboBox
    Friend WithEvents txt_diagnosa As TextBox
    Friend WithEvents txt_nopendaftar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_tglPeriksa As ComboBox
    Friend WithEvents txt_nipdokter As TextBox
    Friend WithEvents cmb_namadokter As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_nopasien As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_pencarian As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_hargaobat As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_jumlahobat As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_biayaperiksa As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_totalpembayaran As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_kodeobat As TextBox
    Friend WithEvents cmb_namaobat As ComboBox
    Friend WithEvents txt_resep As TextBox
    Friend WithEvents btn_tutup As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_input As Button
End Class
