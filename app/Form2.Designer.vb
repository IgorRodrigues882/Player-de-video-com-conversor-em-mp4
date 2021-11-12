<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbrirArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnplay = New System.Windows.Forms.Button()
        Me.btnpause = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnconverte = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxVLCPlugin21 = New AxAXVLC.AxVLCPlugin2()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirArquivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(720, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbrirArquivoToolStripMenuItem
        '
        Me.AbrirArquivoToolStripMenuItem.Name = "AbrirArquivoToolStripMenuItem"
        Me.AbrirArquivoToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.AbrirArquivoToolStripMenuItem.Text = "Abrir arquivo"
        '
        'btnplay
        '
        Me.btnplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnplay.BackColor = System.Drawing.Color.DimGray
        Me.btnplay.Location = New System.Drawing.Point(323, 343)
        Me.btnplay.Name = "btnplay"
        Me.btnplay.Size = New System.Drawing.Size(72, 25)
        Me.btnplay.TabIndex = 3
        Me.btnplay.Text = "Play" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnplay.UseVisualStyleBackColor = False
        '
        'btnpause
        '
        Me.btnpause.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnpause.BackColor = System.Drawing.Color.DimGray
        Me.btnpause.Location = New System.Drawing.Point(598, 343)
        Me.btnpause.Name = "btnpause"
        Me.btnpause.Size = New System.Drawing.Size(72, 25)
        Me.btnpause.TabIndex = 4
        Me.btnpause.Text = "Pause"
        Me.btnpause.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Arquivos de midia (*.mp4)|"
        Me.OpenFileDialog1.Title = "Abrir arquivo"
        '
        'btnconverte
        '
        Me.btnconverte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnconverte.BackColor = System.Drawing.Color.DimGray
        Me.btnconverte.Location = New System.Drawing.Point(20, 343)
        Me.btnconverte.Name = "btnconverte"
        Me.btnconverte.Size = New System.Drawing.Size(62, 25)
        Me.btnconverte.TabIndex = 10
        Me.btnconverte.Text = "Converter"
        Me.btnconverte.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-2, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "conversão em MP4"
        '
        'AxVLCPlugin21
        '
        Me.AxVLCPlugin21.Enabled = True
        Me.AxVLCPlugin21.Location = New System.Drawing.Point(1, 27)
        Me.AxVLCPlugin21.Name = "AxVLCPlugin21"
        Me.AxVLCPlugin21.OcxState = CType(resources.GetObject("AxVLCPlugin21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPlugin21.Size = New System.Drawing.Size(719, 310)
        Me.AxVLCPlugin21.TabIndex = 12
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(720, 392)
        Me.Controls.Add(Me.AxVLCPlugin21)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnconverte)
        Me.Controls.Add(Me.btnpause)
        Me.Controls.Add(Me.btnplay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Player de amor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AbrirArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnplay As Button
    Friend WithEvents btnpause As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnconverte As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AxVLCPlugin21 As AxAXVLC.AxVLCPlugin2
End Class
