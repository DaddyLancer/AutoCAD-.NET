Public Class frmAcadExport
    Dim errCount As Integer = 0
    Private Sub btnMoveTo_Click(sender As Object, e As EventArgs) Handles btnMoveTo.Click
        Try

            Dim selectedItems = (From i In lstSource.SelectedItems).ToArray()
            For Each selectedItem In selectedItems
                lstConvert.Items.Add(selectedItem)
                lstSource.Items.Remove(selectedItem)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMoveFrom_Click(sender As Object, e As EventArgs) Handles btnMoveFrom.Click
        Try

            Dim selectedItems = (From i In lstConvert.SelectedItems).ToArray()
            For Each selectedItem In selectedItems
                lstSource.Items.Add(selectedItem)
                lstConvert.Items.Remove(selectedItem)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            For Item = 0 To lstConvert.Items.Count() - 1
                lstSource.Items.Add(lstConvert.Items.Item(Item))
            Next
        Catch ex As Exception
        End Try
        lstConvert.Items.Clear()
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Try
            For Item = 0 To lstSource.Items.Count() - 1
                lstConvert.Items.Add(lstSource.Items.Item(Item))
            Next
        Catch ex As Exception
        End Try
        lstSource.Items.Clear()
    End Sub

    Private Sub frmAcadExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ACAD Export\"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
                txtPath.Text = FolderBrowserDialog1.SelectedPath
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If System.IO.Directory.Exists(txtPath.Text) = False Then
            If MsgBox("Folder doesn't exist, create it?", MsgBoxStyle.YesNo, "Folder not found") = MsgBoxResult.Yes Then
                Dim tried As Boolean = False
                Try
                    System.IO.Directory.CreateDirectory(txtPath.Text)
                    tried = True
                Catch ex As Exception
                    tried = False
                    MsgBox("Something went wrong, while trying to create the folder." & vbCrLf & vbCrLf & "Here's what we know: " & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Oops...")
                End Try
                If tried = True Then
                    If System.IO.Directory.Exists(txtPath.Text) = False Then
                        MsgBox("Something went wrong - Folder was not created.", MsgBoxStyle.OkOnly, "Oops...")
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim errorCount As Integer = 0

        If lstConvert.Items.Count >= 1 Then
            lblConvert.Visible = False
        Else
            errorCount = +1
            lblConvert.Visible = True
        End If

        If String.IsNullOrWhiteSpace(txtPath.Text) = True Then
            errorCount = +1
            lblPath.Visible = True
        Else
            lblPath.Visible = False
        End If

        If errorCount = 0 Then
            btnExport.Enabled = True
        Else
            btnExport.Enabled = False
        End If

    End Sub

End Class