Public Class FormUtama

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPemesanan.Click
        Text = "Form Jenis Kamar"
        FormJenisKamar.Show()

    End Sub


    Private Sub btnHalamanAwal_Click(sender As Object, e As EventArgs) Handles btnHalamanAwal.Click
        Text = "Form Utama"
    End Sub
End Class
