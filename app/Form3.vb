Public Class Form3
    Dim InputVideo As String = ""
    Dim WithEvents proc As New Process
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        proc.StartInfo.FileName = System.IO.Path.Combine(Application.StartupPath, "ffmpeg.exe")
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        proc.StartInfo.RedirectStandardInput = True
        proc.EnableRaisingEvents = True
    End Sub
    Private Sub AbrirArquivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirArquivoToolStripMenuItem.Click
        Dim diag2 As New OpenFileDialog
        diag2.Filter = "All files (*.*)|*.*"
        If diag2.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim InputVideo = diag2.FileName
            txt1.Text = diag2.FileName
        End If

    End Sub

    Private Sub btnconvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconvert.Click
        Dim sfd As New SaveFileDialog
        sfd.Title = "Save Video As..."
        sfd.FileName = "Untitled"
        sfd.DefaultExt = "avi"
        sfd.AddExtension = True
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim saveas As String = Chr(34) & sfd.FileName & Chr(34)
            InputVideo = "-i " & Chr(34) & InputVideo & Chr(34)
            proc.StartInfo.Arguments = InputVideo & "-b:v 16M -vcodec msmpeg4 -acodec wmav2" & saveas
            proc.Start()
        End If
    End Sub
    Private Sub proc_Exited(ByVal sender As Object, ByVal e As System.EventArgs) Handles proc.Exited
        MessageBox.Show("Video convertido!")
    End Sub
End Class
