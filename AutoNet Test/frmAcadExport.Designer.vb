<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcadExport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSource = New System.Windows.Forms.ListBox()
        Me.lstConvert = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnMoveTo = New System.Windows.Forms.Button()
        Me.btnMoveFrom = New System.Windows.Forms.Button()
        Me.lblConvert = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSaveList = New System.Windows.Forms.Button()
        Me.chkKeepName = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lstSource)
        Me.Panel2.Controls.Add(Me.lstConvert)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnAll)
        Me.Panel2.Controls.Add(Me.btnMoveTo)
        Me.Panel2.Controls.Add(Me.btnMoveFrom)
        Me.Panel2.Controls.Add(Me.lblConvert)
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(419, 433)
        Me.Panel2.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Source List (Plant3D)"
        '
        'lstSource
        '
        Me.lstSource.FormattingEnabled = True
        Me.lstSource.Items.AddRange(New Object() {"apple", "pear", "banana", "chair", "table"})
        Me.lstSource.Location = New System.Drawing.Point(3, 68)
        Me.lstSource.Name = "lstSource"
        Me.lstSource.Size = New System.Drawing.Size(201, 329)
        Me.lstSource.TabIndex = 0
        '
        'lstConvert
        '
        Me.lstConvert.FormattingEnabled = True
        Me.lstConvert.Location = New System.Drawing.Point(210, 68)
        Me.lstConvert.Name = "lstConvert"
        Me.lstConvert.Size = New System.Drawing.Size(201, 329)
        Me.lstConvert.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(97, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose drawings to convert"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(336, 403)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Remove All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(207, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Export List (AutoCAD DWG)"
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(3, 403)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(75, 23)
        Me.btnAll.TabIndex = 7
        Me.btnAll.Text = "Select All"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'btnMoveTo
        '
        Me.btnMoveTo.Location = New System.Drawing.Point(129, 403)
        Me.btnMoveTo.Name = "btnMoveTo"
        Me.btnMoveTo.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveTo.TabIndex = 5
        Me.btnMoveTo.Text = "->"
        Me.btnMoveTo.UseVisualStyleBackColor = True
        '
        'btnMoveFrom
        '
        Me.btnMoveFrom.Location = New System.Drawing.Point(210, 403)
        Me.btnMoveFrom.Name = "btnMoveFrom"
        Me.btnMoveFrom.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveFrom.TabIndex = 6
        Me.btnMoveFrom.Text = "<-"
        Me.btnMoveFrom.UseVisualStyleBackColor = True
        '
        'lblConvert
        '
        Me.lblConvert.AutoSize = True
        Me.lblConvert.BackColor = System.Drawing.Color.Transparent
        Me.lblConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvert.ForeColor = System.Drawing.Color.Red
        Me.lblConvert.Location = New System.Drawing.Point(207, 36)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(109, 13)
        Me.lblConvert.TabIndex = 16
        Me.lblConvert.Text = "No drawings selected"
        Me.lblConvert.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnSaveList)
        Me.Panel1.Controls.Add(Me.chkKeepName)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnBrowse)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPath)
        Me.Panel1.Controls.Add(Me.btnExport)
        Me.Panel1.Controls.Add(Me.lblPath)
        Me.Panel1.Location = New System.Drawing.Point(10, 449)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 111)
        Me.Panel1.TabIndex = 20
        '
        'btnSaveList
        '
        Me.btnSaveList.Location = New System.Drawing.Point(336, 3)
        Me.btnSaveList.Name = "btnSaveList"
        Me.btnSaveList.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveList.TabIndex = 15
        Me.btnSaveList.Text = "Save List"
        Me.btnSaveList.UseVisualStyleBackColor = True
        '
        'chkKeepName
        '
        Me.chkKeepName.AutoSize = True
        Me.chkKeepName.Checked = True
        Me.chkKeepName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKeepName.Enabled = False
        Me.chkKeepName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkKeepName.Location = New System.Drawing.Point(8, 9)
        Me.chkKeepName.Name = "chkKeepName"
        Me.chkKeepName.Size = New System.Drawing.Size(120, 17)
        Me.chkKeepName.TabIndex = 9
        Me.chkKeepName.Text = "Keep Original Name"
        Me.chkKeepName.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(336, 78)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(387, 52)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(24, 23)
        Me.btnBrowse.TabIndex = 12
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Export to:"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(8, 54)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(373, 20)
        Me.txtPath.TabIndex = 11
        '
        'btnExport
        '
        Me.btnExport.Enabled = False
        Me.btnExport.Location = New System.Drawing.Point(255, 78)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 13
        Me.btnExport.Text = "Start Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.BackColor = System.Drawing.Color.Transparent
        Me.lblPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.ForeColor = System.Drawing.Color.Red
        Me.lblPath.Location = New System.Drawing.Point(272, 38)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(109, 13)
        Me.lblPath.TabIndex = 17
        Me.lblPath.Text = "Field cannot be blank"
        Me.lblPath.Visible = False
        '
        'frmAcadExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(438, 570)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAcadExport"
        Me.Text = "Batch Export To Autocad "
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents lstSource As Windows.Forms.ListBox
    Friend WithEvents lstConvert As Windows.Forms.ListBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btnClear As Windows.Forms.Button
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents btnAll As Windows.Forms.Button
    Friend WithEvents btnMoveTo As Windows.Forms.Button
    Friend WithEvents btnMoveFrom As Windows.Forms.Button
    Friend WithEvents lblConvert As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btnSaveList As Windows.Forms.Button
    Friend WithEvents chkKeepName As Windows.Forms.CheckBox
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents btnBrowse As Windows.Forms.Button
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtPath As Windows.Forms.TextBox
    Friend WithEvents btnExport As Windows.Forms.Button
    Friend WithEvents lblPath As Windows.Forms.Label
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents FolderBrowserDialog1 As Windows.Forms.FolderBrowserDialog
End Class
