Public Class Form2

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub


 
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Form3.Show()
        Form3.GroupBox1.Enabled = True
        Form3.GroupBox2.Enabled = False
        Form3.GroupBox3.Enabled = False
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form3.Show()
        Form3.GroupBox1.Enabled = False
        Form3.GroupBox2.Enabled = True
        Form3.GroupBox3.Enabled = False
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form3.Show()
        Form3.GroupBox1.Enabled = False
        Form3.GroupBox2.Enabled = False
        Form3.GroupBox3.Enabled = True
        Me.Close()
    End Sub
End Class