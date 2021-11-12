Imports AXVLC
Public Class Form2

    Private Sub AbrirArquivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirArquivoToolStripMenuItem.Click
        OpenFileDialog1.Filter = "All files (*.*)|*.*"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            AxVLCPlugin21.playlist.add(OpenFileDialog1.FileName)
            AxVLCPlugin21.playlist.play()
        End If
    End Sub

    Private Sub Btnplay_Click(sender As Object, e As EventArgs) Handles btnplay.Click
        AxVLCPlugin21.playlist.play()
    End Sub

    Private Sub Btnpause_Click(sender As Object, e As EventArgs) Handles btnpause.Click
        AxVLCPlugin21.playlist.togglePause()
    End Sub
    Private Sub Btnconverte_Click(sender As Object, e As EventArgs) Handles btnconverte.Click
        Form3.Show()
    End Sub
End Class