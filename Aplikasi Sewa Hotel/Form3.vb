Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button4.Click, Button5.Click, Button7.Click, Button16.Click, Button12.Click,
        Button11.Click, Button10.Click

        MessageBox.Show("Maaf,kamar sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

   
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button6.Click, Button8.Click, Button15.Click,
         Button14.Click, Button13.Click, Button9.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click, Button30.Click, Button29.Click, Button26.Click, Button25.Click, Button24.Click, Button22.Click

        MessageBox.Show("Maaf,kamar sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click, Button19.Click, Button20.Click, Button21.Click, Button23.Click, Button27.Click,
        Button28.Click, Button31.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click

    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class