Public Class FormNoKamar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1201.Click, btn1301.Click, btn1501.Click, btn1601.Click, btn1801.Click, btn2001.Click, btn2401.Click,
        btn2501.Click, btn2601.Click

        MessageBox.Show("Maaf,kamar sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn1401.Click, btn1701.Click, btn1901.Click, btn2701.Click,
         btn2301.Click, btn2201.Click, btn2101.Click
        FormPemesanan.Show()
        Me.Close()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles btn3102.Click, btn3302.Click, btn3402.Click, btn3702.Click, btn3802.Click, Button24.Click, Button22.Click

        MessageBox.Show("Maaf,kamar  sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btn3202.Click, btn3502.Click, btn3602.Click, Button21.Click, Button23.Click, Button27.Click,
        Button28.Click, Button31.Click
        FormPemesanan.Show()
        Me.Close()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles btn5503.Click
        FormPemesanan.Show()
        Me.Close()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles btn6303.Click
        FormPemesanan.Show()
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles btn5103.Click
        MessageBox.Show("Maaf,kamar  sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles btn5203.Click
        FormPemesanan.Show()
        Me.Close()
    End Sub
End Class