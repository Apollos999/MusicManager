Imports System.ComponentModel

Public Class FormMusicManager
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonProjetar2.Click
        Dim pathPPT As String
        pathPPT = CurDir() + "\MUSICAS\" + ListBoxLetras1.SelectedItem.ToString.ToUpper.Replace(".TXT", ".PPT")
        If FileIO.FileSystem.GetFileInfo(pathPPT).Exists Then
            System.Diagnostics.Process.Start("POWERPNT.EXE", "/s """ + pathPPT + """")
        End If
    End Sub

    Private Sub ButtonProjetar1_Click(sender As Object, e As EventArgs) Handles ButtonProjetar1.Click
        ProjetarPPT()
    End Sub

    Sub ProjetarPPT()
        Dim pathPPT, item As String
        For Each item In ListBoxExec.SelectedItems()
            pathPPT = CurDir() + "\" + item
            If FileIO.FileSystem.GetFileInfo(pathPPT).Exists Then
                System.Diagnostics.Process.Start("POWERPNT.EXE", "/s """ + pathPPT + """")
            End If
        Next
    End Sub

    Private Sub FormMusicManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item, music As String
        LoadFolderStructure()
        LoadFiles()
        LoadMusicFiles()
        If FileIO.FileSystem.FileExists(CurDir() & "\Music.txt") Then
            music = FileIO.FileSystem.ReadAllText(CurDir() & "\Music.txt")
            For Each item In music.Split(vbNewLine)
                If item.Length > 3 Then
                    ListBoxExec.Items.Add(item.Trim)
                End If
            Next
        End If
    End Sub

    Sub LoadFolderStructure()
        Dim SubPaths As ObjectModel.ReadOnlyCollection(Of String)
        Dim path As String
        SubPaths = FileIO.FileSystem.GetDirectories(CurDir())
        For Each path In SubPaths
            ComboBoxArquivos1.Items.Add(path.Replace(CurDir() + "\", ""))
        Next
        ComboBoxArquivos1.Text = "MUSICAS"
    End Sub

    Sub LoadFiles()
        Dim SelectedPath, file As String
        Dim SubFiles As ObjectModel.ReadOnlyCollection(Of String)
        SelectedPath = CurDir() + "\" + ComboBoxArquivos1.Text
        SubFiles = FileIO.FileSystem.GetFiles(SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, {"*.ppt", "*.pptx"})
        CheckedListBoxMusicas1.Items.Clear()
        For Each file In SubFiles
            CheckedListBoxMusicas1.Items.Add(file.Replace(CurDir() + "\", "").Replace(ComboBoxArquivos1.Text & "\", ""))
        Next
    End Sub

    Sub LoadMusicFiles()
        Dim SelectedPath, file As String
        Dim SubFiles As ObjectModel.ReadOnlyCollection(Of String)
        SelectedPath = CurDir() + "\MUSICAS"
        SubFiles = FileIO.FileSystem.GetFiles(SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, {"*.txt"})
        ListBoxLetras1.Items.Clear()
        For Each file In SubFiles
            ListBoxLetras1.Items.Add(file.Replace(CurDir() + "\MUSICAS", ""))
        Next
    End Sub

    Private Sub ComboBoxArquivos1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxArquivos1.SelectedIndexChanged
        LoadFiles()
        CheckedListBoxMusicas1.Select()
    End Sub

    Private Sub ButtonAdicionar1_Click(sender As Object, e As EventArgs) Handles ButtonAdicionar1.Click
        Dim execItem As String
        Dim i As Integer
        For i = 0 To CheckedListBoxMusicas1.CheckedItems().Count - 1
            execItem = CheckedListBoxMusicas1.CheckedItems().Item(i)
            If ListBoxExec.FindStringExact(ComboBoxArquivos1.Text & "\" & execItem) = -1 Then
                ListBoxExec.Items.Add(ComboBoxArquivos1.Text & "\" & execItem)
            End If
        Next
        TextBoxPesquisa1.Text = ""
    End Sub

    Private Sub ButtonNovo1_Click(sender As Object, e As EventArgs) Handles ButtonNovo1.Click
        TextBoxNome1.Text = ""
        TextBoxLetra1.Text = ""
        TextBoxNome1.Select()
    End Sub

    Private Sub ButtonTrash1_Click(sender As Object, e As EventArgs) Handles ButtonTrash1.Click
        Dim selectedItem, i As Integer
        For i = ListBoxExec.SelectedIndices.Count - 1 To 0 Step -1
            ListBoxExec.Items.Remove(ListBoxExec.Items.Item(ListBoxExec.SelectedIndices.Item(i)))
        Next
        selectedItem = ListBoxLetras1.SelectedIndex
        If selectedItem > 0 Then
            ListBoxExec.SetSelected(selectedItem - 1, True)
        End If
    End Sub

    Private Sub ButtonExcluir1_Click(sender As Object, e As EventArgs) Handles ButtonExcluir1.Click
        Dim selectedItem As Integer
        Dim pathLetra, parentPath As String
        If MsgBox("Deseja realmente excluir a música selecionada?", vbQuestion + vbOKCancel) = vbOK Then
            pathLetra = CurDir() + "\MUSICAS\" + ListBoxLetras1.SelectedItem
            If pathLetra <> CurDir() + "\" Then
                parentPath = FileIO.FileSystem.GetParentPath(pathLetra)
                If FileIO.FileSystem.GetFileInfo(pathLetra).Exists Then
                End If
                If FileIO.FileSystem.GetFileInfo(pathLetra.Replace(".txt", ".ppt").Replace(".TXT", ".ppt")).Exists Then
                    FileIO.FileSystem.DeleteDirectory(parentPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
            End If
            selectedItem = ListBoxLetras1.SelectedIndex
            ListBoxLetras1.Items.Remove(ListBoxLetras1.SelectedItem)
            If selectedItem > 0 Then
                ListBoxLetras1.SetSelected(selectedItem - 1, True)
            End If
        End If
    End Sub

    Private Sub ButtonUp1_Click(sender As Object, e As EventArgs) Handles ButtonUp1.Click
        Dim selectedItem As Integer
        selectedItem = ListBoxExec.SelectedIndex
        If selectedItem > 0 Then
            ListBoxExec.Items.Insert(selectedItem - 1, ListBoxExec.SelectedItem)
            ListBoxExec.Items.RemoveAt(selectedItem + 1)
            ListBoxExec.SetSelected(selectedItem - 1, True)
        End If
    End Sub

    Private Sub ButtonDown1_Click(sender As Object, e As EventArgs) Handles ButtonDown1.Click
        Dim selectedItem As Integer
        selectedItem = ListBoxExec.SelectedIndex
        If selectedItem < ListBoxExec.Items.Count - 1 And selectedItem >= 0 Then
            ListBoxExec.Items.Insert(selectedItem + 2, ListBoxExec.SelectedItem)
            ListBoxExec.Items.RemoveAt(selectedItem)
            ListBoxExec.SetSelected(selectedItem + 1, True)
        End If
    End Sub

    Private Sub ButtonPesquisar1_Click(sender As Object, e As EventArgs) Handles ButtonPesquisar1.Click
        Pesquisar()
    End Sub

    Sub Pesquisar()
        Dim pesquisa As CheckedListBox.ObjectCollection
        Dim novapesquisa As CheckedListBox
        Dim item As String
        novapesquisa = New CheckedListBox
        pesquisa = New CheckedListBox.ObjectCollection(novapesquisa)
        pesquisa.AddRange(CheckedListBoxMusicas1.Items())
        CheckedListBoxMusicas1.Items.Clear()
        For Each item In pesquisa
            If InStr(item.ToString.ToUpper, TextBoxPesquisa1.Text.ToUpper) > 0 Then
                CheckedListBoxMusicas1.Items.Add(item)
            End If
        Next
        If TextBoxPesquisa1.Text = "" Then
            CheckedListBoxMusicas1.Items.Clear()
            LoadFiles()
        End If
    End Sub

    Private Sub TextBoxPesquisa1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPesquisa1.TextChanged
        Dim pesquisa As CheckedListBox.ObjectCollection
        Dim novapesquisa As CheckedListBox
        novapesquisa = New CheckedListBox
        Dim item As String
        pesquisa = New CheckedListBox.ObjectCollection(novapesquisa)
        pesquisa.AddRange(CheckedListBoxMusicas1.Items())
        CheckedListBoxMusicas1.Items.Clear()
        For Each item In pesquisa
            If InStr(item.ToString.ToUpper, TextBoxPesquisa1.Text.ToUpper) > 0 Then
                CheckedListBoxMusicas1.Items.Add(item)
            End If
        Next
        If TextBoxPesquisa1.Text = "" Then
            CheckedListBoxMusicas1.Items.Clear()
            LoadFiles()
        End If
    End Sub

    Private Sub ButtonSalvar1_Click(sender As Object, e As EventArgs) Handles ButtonSalvar1.Click
        SalvarPPT()
    End Sub

    Sub SalvarPPT()
        Dim i As Integer
        Dim objPPT, objPresentation, objSlide As Object
        Dim encodingPTBR As New Globalization.CultureInfo("pt-BR")
        Dim strLine As String
        FileIO.FileSystem.CreateDirectory(CurDir() & "\MUSICAS\" & TextBoxNome1.Text)
        FileIO.FileSystem.WriteAllText(CurDir() & "\MUSICAS\" & TextBoxNome1.Text & "\" & TextBoxNome1.Text & ".txt", TextBoxLetra1.Text, False, System.Text.Encoding.GetEncoding(encodingPTBR.TextInfo.ANSICodePage))
        objPPT = CreateObject("PowerPoint.Application")
        objPPT.Visible = True
        objPresentation = objPPT.Presentations.Add
        objPresentation.ApplyTemplate(CurDir() & "\TEMPLATE.pot")
        For Each strLine In TextBoxLetra1.Text.Split(";")
            objSlide = objPresentation.Slides.Add(1, 11)
        Next
        i = 1
        For Each strLine In TextBoxLetra1.Text.Split(";")
            objPresentation.Slides.Item(i).Shapes.Range(1).TextFrame.TextRange.Text = UCase(strLine)
            objPresentation.Slides.Item(i).Shapes.Range(1).Top = 200
            objPresentation.Slides.Item(i).Shapes.Range(1).TextFrame.TextRange.Font.Size = 36
            i = i + 1
        Next
        objPresentation.SaveAs(CurDir() & "\MUSICAS\" & TextBoxNome1.Text & "\" & TextBoxNome1.Text & ".ppt")
        objPresentation.Close
        objPPT.Quit
        LoadMusicFiles()
    End Sub
    Private Sub ListBoxLetras1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLetras1.SelectedIndexChanged
        Dim letra As IO.StreamReader
        Dim encodingPTBR As New Globalization.CultureInfo("pt-BR")
        Dim pathLetra, historyPath, item As String
        pathLetra = CurDir() + "\MUSICAS\" + ListBoxLetras1.SelectedItem
        If pathLetra <> CurDir() + "\" Then
            If FileIO.FileSystem.GetFileInfo(pathLetra).Exists Then
                TextBoxNome1.Text = FileIO.FileSystem.GetFileInfo(pathLetra).Name.Replace(".TXT", "").Replace(".txt", "")
                letra = FileIO.FileSystem.OpenTextFileReader(pathLetra, System.Text.Encoding.GetEncoding(encodingPTBR.TextInfo.ANSICodePage))
                TextBoxLetra1.Text = letra.ReadToEnd
                letra.Close()
            End If
            historyPath = FileIO.FileSystem.GetParentPath(CurDir() + "\MUSICAS\" + ListBoxLetras1.SelectedItem) & "\history.dat"
            ComboBoxHistory1.Items.Clear()
            LabelHistory1.Text = "Execuções: 0"
            If FileIO.FileSystem.GetFileInfo(historyPath).Exists Then
                For Each item In FileIO.FileSystem.OpenTextFileReader(historyPath, System.Text.Encoding.GetEncoding(encodingPTBR.TextInfo.ANSICodePage)).ReadToEnd.Split(vbNewLine)
                    If item.Length > 5 And ComboBoxHistory1.FindStringExact(item.Trim) = -1 Then
                        ComboBoxHistory1.Items.Add(item.Trim)
                    End If
                Next
                LabelHistory1.Text = "Execuções: " & ComboBoxHistory1.Items.Count
                ComboBoxHistory1.Text = ComboBoxHistory1.Items.Item(ComboBoxHistory1.Items.Count - 1)
            End If
        End If
    End Sub

    Private Sub ListBoxExec_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBoxExec.MouseDoubleClick
        'ProjetarPPT()
    End Sub

    Private Sub ListBoxExec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBoxExec.KeyPress
        If e.KeyChar = ChrW(13) Then
            ProjetarPPT()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPesquisa2.TextChanged
        Dim pesquisa As ListBox.ObjectCollection
        Dim novapesquisa As ListBox
        novapesquisa = New ListBox
        Dim item As String
        pesquisa = New ListBox.ObjectCollection(novapesquisa)
        pesquisa.AddRange(ListBoxLetras1.Items())
        ListBoxLetras1.Items.Clear()
        For Each item In pesquisa
            If InStr(item.ToString.ToUpper, TextBoxPesquisa2.Text.ToUpper) > 0 Then
                ListBoxLetras1.Items.Add(item)
            End If
        Next
        If TextBoxPesquisa2.Text = "" Then
            ListBoxLetras1.Items.Clear()
            LoadMusicFiles()
        End If
    End Sub

    Private Sub FormMusicManager_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim item, itemList, history, musicPath As String
        Dim encodingPTBR As New Globalization.CultureInfo("pt-BR")
        If ListBoxExec.Items.Count > 0 Then
            If MsgBox("Deseja salvar a lista atual?", vbQuestion + vbYesNo) = vbYes Then
                itemList = ""
                history = ""
                For Each item In ListBoxExec.Items
                    itemList = itemList & item & vbNewLine
                    history = history & Date.Today & vbNewLine
                    musicPath = FileIO.FileSystem.GetParentPath(CurDir() & "\" & item)
                    FileIO.FileSystem.WriteAllText(musicPath & "\History.dat", history, True, System.Text.Encoding.GetEncoding(encodingPTBR.TextInfo.ANSICodePage))
                Next
                FileIO.FileSystem.WriteAllText(CurDir() & "\Music.txt", itemList, False, System.Text.Encoding.GetEncoding(encodingPTBR.TextInfo.ANSICodePage))
            End If
        End If
    End Sub
End Class
