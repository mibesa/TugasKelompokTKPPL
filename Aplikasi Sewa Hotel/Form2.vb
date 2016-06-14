Public Class FormJenisKamar

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormUtama.Show()
        Me.Close()
    End Sub



    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblpilih1.LinkClicked
        FormNoKamar.Show()
        FormNoKamar.GroupBox1.Enabled = True
        FormNoKamar.GroupBox2.Enabled = False
        FormNoKamar.GroupBox3.Enabled = False
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblpilih2.LinkClicked
        FormNoKamar.Show()
        FormNoKamar.GroupBox1.Enabled = False
        FormNoKamar.GroupBox2.Enabled = True
        FormNoKamar.GroupBox3.Enabled = False
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblpilih3.LinkClicked
        FormNoKamar.Show()
        FormNoKamar.GroupBox1.Enabled = False
        FormNoKamar.GroupBox2.Enabled = False
        FormNoKamar.GroupBox3.Enabled = True
        Me.Close()
    End Sub
End Class