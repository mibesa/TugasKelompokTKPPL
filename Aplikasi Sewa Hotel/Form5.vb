﻿Public Class Form5

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        FormPemesanan.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        MessageBox.Show("Anda yakin ingin membatalkan pemesanan ini? ", "pemesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnpesan.Click
        MessageBox.Show("Terimakasih , pemesanan anda telah berhasil", "pemesanan", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Dim a, b As Double


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            a = 0.1
            txttotalPembayaran.Text = Label1.Text * a

        End If
    End Sub



    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            a = 0.2
            txttotalPembayaran.Text = Label1.Text * a
        End If
    End Sub



    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            b = 0.1
            txttotalPembayaran.Text = Label4.Text * b

        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            b = 0.2
            txttotalPembayaran.Text = Label4.Text * b
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles rbtunai.CheckedChanged
        txtPembayaran.Text = "Tunai"
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles rbkredit.CheckedChanged
        txtPembayaran.Text = "Kredit"
    End Sub
End Class