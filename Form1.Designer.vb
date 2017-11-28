<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMusicManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMusicManager))
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxPesquisa2 = New System.Windows.Forms.TextBox()
        Me.TextBoxNome1 = New System.Windows.Forms.TextBox()
        Me.TextBoxLetra1 = New System.Windows.Forms.TextBox()
        Me.ListBoxLetras1 = New System.Windows.Forms.ListBox()
        Me.ButtonNovo1 = New System.Windows.Forms.Button()
        Me.ButtonSalvar1 = New System.Windows.Forms.Button()
        Me.ButtonExcluir1 = New System.Windows.Forms.Button()
        Me.ButtonProjetar2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonPesquisar1 = New System.Windows.Forms.Button()
        Me.TextBoxPesquisa1 = New System.Windows.Forms.TextBox()
        Me.ButtonAdicionar1 = New System.Windows.Forms.Button()
        Me.CheckedListBoxMusicas1 = New System.Windows.Forms.CheckedListBox()
        Me.ComboBoxArquivos1 = New System.Windows.Forms.ComboBox()
        Me.ButtonTrash1 = New System.Windows.Forms.Button()
        Me.ButtonProjetar1 = New System.Windows.Forms.Button()
        Me.ButtonDown1 = New System.Windows.Forms.Button()
        Me.ButtonUp1 = New System.Windows.Forms.Button()
        Me.ListBoxExec = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ComboBoxHistory1 = New System.Windows.Forms.ComboBox()
        Me.LabelHistory1 = New System.Windows.Forms.Label()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LabelHistory1)
        Me.TabPage2.Controls.Add(Me.ComboBoxHistory1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TextBoxPesquisa2)
        Me.TabPage2.Controls.Add(Me.TextBoxNome1)
        Me.TabPage2.Controls.Add(Me.TextBoxLetra1)
        Me.TabPage2.Controls.Add(Me.ListBoxLetras1)
        Me.TabPage2.Controls.Add(Me.ButtonNovo1)
        Me.TabPage2.Controls.Add(Me.ButtonSalvar1)
        Me.TabPage2.Controls.Add(Me.ButtonExcluir1)
        Me.TabPage2.Controls.Add(Me.ButtonProjetar2)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(728, 393)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Letras"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.MusicManager.My.Resources.Resources.search
        Me.Button1.Location = New System.Drawing.Point(549, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 20)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxPesquisa2
        '
        Me.TextBoxPesquisa2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPesquisa2.Location = New System.Drawing.Point(286, 22)
        Me.TextBoxPesquisa2.Name = "TextBoxPesquisa2"
        Me.TextBoxPesquisa2.Size = New System.Drawing.Size(262, 20)
        Me.TextBoxPesquisa2.TabIndex = 12
        '
        'TextBoxNome1
        '
        Me.TextBoxNome1.Location = New System.Drawing.Point(12, 22)
        Me.TextBoxNome1.Name = "TextBoxNome1"
        Me.TextBoxNome1.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxNome1.TabIndex = 1
        '
        'TextBoxLetra1
        '
        Me.TextBoxLetra1.Location = New System.Drawing.Point(9, 61)
        Me.TextBoxLetra1.Multiline = True
        Me.TextBoxLetra1.Name = "TextBoxLetra1"
        Me.TextBoxLetra1.Size = New System.Drawing.Size(258, 290)
        Me.TextBoxLetra1.TabIndex = 0
        '
        'ListBoxLetras1
        '
        Me.ListBoxLetras1.FormattingEnabled = True
        Me.ListBoxLetras1.Location = New System.Drawing.Point(286, 48)
        Me.ListBoxLetras1.Name = "ListBoxLetras1"
        Me.ListBoxLetras1.Size = New System.Drawing.Size(425, 303)
        Me.ListBoxLetras1.TabIndex = 11
        '
        'ButtonNovo1
        '
        Me.ButtonNovo1.Location = New System.Drawing.Point(9, 357)
        Me.ButtonNovo1.Name = "ButtonNovo1"
        Me.ButtonNovo1.Size = New System.Drawing.Size(125, 30)
        Me.ButtonNovo1.TabIndex = 10
        Me.ButtonNovo1.Text = "Novo"
        Me.ButtonNovo1.UseVisualStyleBackColor = True
        '
        'ButtonSalvar1
        '
        Me.ButtonSalvar1.Location = New System.Drawing.Point(142, 357)
        Me.ButtonSalvar1.Name = "ButtonSalvar1"
        Me.ButtonSalvar1.Size = New System.Drawing.Size(125, 30)
        Me.ButtonSalvar1.TabIndex = 9
        Me.ButtonSalvar1.Text = "Salvar"
        Me.ButtonSalvar1.UseVisualStyleBackColor = True
        '
        'ButtonExcluir1
        '
        Me.ButtonExcluir1.Image = Global.MusicManager.My.Resources.Resources.trash
        Me.ButtonExcluir1.Location = New System.Drawing.Point(286, 357)
        Me.ButtonExcluir1.Name = "ButtonExcluir1"
        Me.ButtonExcluir1.Size = New System.Drawing.Size(29, 30)
        Me.ButtonExcluir1.TabIndex = 8
        Me.ButtonExcluir1.UseVisualStyleBackColor = True
        '
        'ButtonProjetar2
        '
        Me.ButtonProjetar2.Image = Global.MusicManager.My.Resources.Resources.projector_with_big_len1
        Me.ButtonProjetar2.Location = New System.Drawing.Point(316, 357)
        Me.ButtonProjetar2.Name = "ButtonProjetar2"
        Me.ButtonProjetar2.Size = New System.Drawing.Size(395, 30)
        Me.ButtonProjetar2.TabIndex = 7
        Me.ButtonProjetar2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Letra"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.ButtonPesquisar1)
        Me.TabPage1.Controls.Add(Me.TextBoxPesquisa1)
        Me.TabPage1.Controls.Add(Me.ButtonAdicionar1)
        Me.TabPage1.Controls.Add(Me.CheckedListBoxMusicas1)
        Me.TabPage1.Controls.Add(Me.ComboBoxArquivos1)
        Me.TabPage1.Controls.Add(Me.ButtonTrash1)
        Me.TabPage1.Controls.Add(Me.ButtonProjetar1)
        Me.TabPage1.Controls.Add(Me.ButtonDown1)
        Me.TabPage1.Controls.Add(Me.ButtonUp1)
        Me.TabPage1.Controls.Add(Me.ListBoxExec)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(728, 393)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Projeção"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(347, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Arquivos"
        '
        'ButtonPesquisar1
        '
        Me.ButtonPesquisar1.AutoEllipsis = True
        Me.ButtonPesquisar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPesquisar1.Image = Global.MusicManager.My.Resources.Resources.search
        Me.ButtonPesquisar1.Location = New System.Drawing.Point(608, 49)
        Me.ButtonPesquisar1.Name = "ButtonPesquisar1"
        Me.ButtonPesquisar1.Size = New System.Drawing.Size(27, 20)
        Me.ButtonPesquisar1.TabIndex = 9
        Me.ButtonPesquisar1.UseVisualStyleBackColor = True
        '
        'TextBoxPesquisa1
        '
        Me.TextBoxPesquisa1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPesquisa1.Location = New System.Drawing.Point(345, 49)
        Me.TextBoxPesquisa1.Name = "TextBoxPesquisa1"
        Me.TextBoxPesquisa1.Size = New System.Drawing.Size(262, 20)
        Me.TextBoxPesquisa1.TabIndex = 8
        Me.TextBoxPesquisa1.Tag = ""
        '
        'ButtonAdicionar1
        '
        Me.ButtonAdicionar1.Location = New System.Drawing.Point(345, 364)
        Me.ButtonAdicionar1.Name = "ButtonAdicionar1"
        Me.ButtonAdicionar1.Size = New System.Drawing.Size(377, 26)
        Me.ButtonAdicionar1.TabIndex = 7
        Me.ButtonAdicionar1.Text = "<< Adicionar"
        Me.ButtonAdicionar1.UseVisualStyleBackColor = True
        '
        'CheckedListBoxMusicas1
        '
        Me.CheckedListBoxMusicas1.CheckOnClick = True
        Me.CheckedListBoxMusicas1.FormattingEnabled = True
        Me.CheckedListBoxMusicas1.Location = New System.Drawing.Point(345, 71)
        Me.CheckedListBoxMusicas1.Name = "CheckedListBoxMusicas1"
        Me.CheckedListBoxMusicas1.Size = New System.Drawing.Size(377, 289)
        Me.CheckedListBoxMusicas1.TabIndex = 6
        '
        'ComboBoxArquivos1
        '
        Me.ComboBoxArquivos1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxArquivos1.FormattingEnabled = True
        Me.ComboBoxArquivos1.Location = New System.Drawing.Point(345, 22)
        Me.ComboBoxArquivos1.Name = "ComboBoxArquivos1"
        Me.ComboBoxArquivos1.Size = New System.Drawing.Size(290, 21)
        Me.ComboBoxArquivos1.TabIndex = 5
        '
        'ButtonTrash1
        '
        Me.ButtonTrash1.Image = Global.MusicManager.My.Resources.Resources.trash
        Me.ButtonTrash1.Location = New System.Drawing.Point(315, 58)
        Me.ButtonTrash1.Name = "ButtonTrash1"
        Me.ButtonTrash1.Size = New System.Drawing.Size(26, 27)
        Me.ButtonTrash1.TabIndex = 4
        Me.ButtonTrash1.UseVisualStyleBackColor = True
        '
        'ButtonProjetar1
        '
        Me.ButtonProjetar1.Image = Global.MusicManager.My.Resources.Resources.projector_with_big_len1
        Me.ButtonProjetar1.Location = New System.Drawing.Point(6, 364)
        Me.ButtonProjetar1.Name = "ButtonProjetar1"
        Me.ButtonProjetar1.Size = New System.Drawing.Size(309, 26)
        Me.ButtonProjetar1.TabIndex = 3
        Me.ButtonProjetar1.UseVisualStyleBackColor = True
        '
        'ButtonDown1
        '
        Me.ButtonDown1.Image = Global.MusicManager.My.Resources.Resources.arrow_angle_pointing_down
        Me.ButtonDown1.Location = New System.Drawing.Point(315, 32)
        Me.ButtonDown1.Name = "ButtonDown1"
        Me.ButtonDown1.Size = New System.Drawing.Size(26, 27)
        Me.ButtonDown1.TabIndex = 2
        Me.ButtonDown1.UseVisualStyleBackColor = True
        '
        'ButtonUp1
        '
        Me.ButtonUp1.Image = Global.MusicManager.My.Resources.Resources.level_up
        Me.ButtonUp1.Location = New System.Drawing.Point(315, 6)
        Me.ButtonUp1.Name = "ButtonUp1"
        Me.ButtonUp1.Size = New System.Drawing.Size(26, 27)
        Me.ButtonUp1.TabIndex = 1
        Me.ButtonUp1.UseVisualStyleBackColor = True
        '
        'ListBoxExec
        '
        Me.ListBoxExec.FormattingEnabled = True
        Me.ListBoxExec.Location = New System.Drawing.Point(6, 6)
        Me.ListBoxExec.Name = "ListBoxExec"
        Me.ListBoxExec.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBoxExec.Size = New System.Drawing.Size(309, 355)
        Me.ListBoxExec.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(736, 419)
        Me.TabControl1.TabIndex = 0
        '
        'ComboBoxHistory1
        '
        Me.ComboBoxHistory1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxHistory1.FormattingEnabled = True
        Me.ComboBoxHistory1.Location = New System.Drawing.Point(582, 21)
        Me.ComboBoxHistory1.Name = "ComboBoxHistory1"
        Me.ComboBoxHistory1.Size = New System.Drawing.Size(129, 21)
        Me.ComboBoxHistory1.TabIndex = 14
        '
        'LabelHistory1
        '
        Me.LabelHistory1.AutoSize = True
        Me.LabelHistory1.Location = New System.Drawing.Point(582, 6)
        Me.LabelHistory1.Name = "LabelHistory1"
        Me.LabelHistory1.Size = New System.Drawing.Size(72, 13)
        Me.LabelHistory1.TabIndex = 15
        Me.LabelHistory1.Text = "Execuções: 0"
        Me.LabelHistory1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormMusicManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 443)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMusicManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Music Manger 2018"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxPesquisa2 As TextBox
    Friend WithEvents TextBoxNome1 As TextBox
    Friend WithEvents TextBoxLetra1 As TextBox
    Friend WithEvents ListBoxLetras1 As ListBox
    Friend WithEvents ButtonNovo1 As Button
    Friend WithEvents ButtonSalvar1 As Button
    Friend WithEvents ButtonExcluir1 As Button
    Friend WithEvents ButtonProjetar2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonPesquisar1 As Button
    Friend WithEvents TextBoxPesquisa1 As TextBox
    Friend WithEvents ButtonAdicionar1 As Button
    Friend WithEvents CheckedListBoxMusicas1 As CheckedListBox
    Friend WithEvents ComboBoxArquivos1 As ComboBox
    Friend WithEvents ButtonTrash1 As Button
    Friend WithEvents ButtonProjetar1 As Button
    Friend WithEvents ButtonDown1 As Button
    Friend WithEvents ButtonUp1 As Button
    Friend WithEvents ListBoxExec As ListBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents LabelHistory1 As Label
    Friend WithEvents ComboBoxHistory1 As ComboBox
End Class
