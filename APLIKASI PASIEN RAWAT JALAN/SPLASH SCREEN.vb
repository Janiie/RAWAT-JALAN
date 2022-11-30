Public Class SplashScreen
    'VARIABEL GLOBAL UNTUK PROGRESS YABNG AKAN DI UPDATE SETIAP INTERVAL
    Dim progress As Integer = 0

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'JALANKAN TIMER SAAT FORM DI LOAD
        Timer1.Interval = 10
        Timer1.Start()
    End Sub

    'FUNGSI YANG DIEKSEKUSI SETIAP INTERVAL
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'DAPATKAN NILAI PROGRESS YANG BARU
        Dim newProgress = progress + 1

        'PERIKSA APAKAH PROGRES KURANG DARI ATAU SAMA DENGAN 100
        If (newProgress <= 100) Then
            'JIKA IYA MAKA UPDATE TULISAN PADA LABEL
            lbl_Persentase.Text = newProgress & "%"
            'UPDATE PROGRESS BAR VALUE
            pb_loading.Value = newProgress
            'UPDATE GLOBAL VARIABEL PROGRESS SUPAYA ANGKANYA TIDAK 0 TERUS
            progress = newProgress
        Else
            'KALAU NEWPROGRESS SUDAH LEBIH DARI 100 MAKA TIMER DI STOP
            Timer1.Stop()
            'MENUTUP SPALHSCREEN DAN MENUJU KE FORM LOGIN
            Form_Utama.Show()
            Me.Hide()
        End If
    End Sub
End Class
