<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTabeliVaade
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
        Me.dgvTabeliVaade = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tcTabs = New System.Windows.Forms.TabControl()
        Me.tpAutod = New System.Windows.Forms.TabPage()
        Me.tbProbleemid = New System.Windows.Forms.TabPage()
        Me.btnBackProb = New System.Windows.Forms.Button()
        Me.dgvProbleemid = New System.Windows.Forms.DataGridView()
        Me.tpKindlustus = New System.Windows.Forms.TabPage()
        Me.dgvKindlustus = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTabeliVaade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcTabs.SuspendLayout()
        Me.tpAutod.SuspendLayout()
        Me.tbProbleemid.SuspendLayout()
        CType(Me.dgvProbleemid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpKindlustus.SuspendLayout()
        CType(Me.dgvKindlustus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTabeliVaade
        '
        Me.dgvTabeliVaade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabeliVaade.Location = New System.Drawing.Point(7, 46)
        Me.dgvTabeliVaade.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTabeliVaade.Name = "dgvTabeliVaade"
        Me.dgvTabeliVaade.RowHeadersWidth = 62
        Me.dgvTabeliVaade.Size = New System.Drawing.Size(1046, 422)
        Me.dgvTabeliVaade.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(498, 498)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tabel"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btnAdd.Location = New System.Drawing.Point(3, 5)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 26)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Car"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'tcTabs
        '
        Me.tcTabs.Controls.Add(Me.tpAutod)
        Me.tcTabs.Controls.Add(Me.tbProbleemid)
        Me.tcTabs.Controls.Add(Me.tpKindlustus)
        Me.tcTabs.Location = New System.Drawing.Point(1, 1)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(1065, 541)
        Me.tcTabs.TabIndex = 3
        '
        'tpAutod
        '
        Me.tpAutod.Controls.Add(Me.btnAdd)
        Me.tpAutod.Controls.Add(Me.dgvTabeliVaade)
        Me.tpAutod.Location = New System.Drawing.Point(4, 25)
        Me.tpAutod.Name = "tpAutod"
        Me.tpAutod.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAutod.Size = New System.Drawing.Size(1057, 512)
        Me.tpAutod.TabIndex = 0
        Me.tpAutod.Text = "Car View"
        Me.tpAutod.UseVisualStyleBackColor = True
        '
        'tbProbleemid
        '
        Me.tbProbleemid.Controls.Add(Me.btnBackProb)
        Me.tbProbleemid.Controls.Add(Me.dgvProbleemid)
        Me.tbProbleemid.Location = New System.Drawing.Point(4, 25)
        Me.tbProbleemid.Name = "tbProbleemid"
        Me.tbProbleemid.Padding = New System.Windows.Forms.Padding(3)
        Me.tbProbleemid.Size = New System.Drawing.Size(1057, 512)
        Me.tbProbleemid.TabIndex = 1
        Me.tbProbleemid.Text = "Problem View"
        Me.tbProbleemid.UseVisualStyleBackColor = True
        '
        'btnBackProb
        '
        Me.btnBackProb.Location = New System.Drawing.Point(6, 6)
        Me.btnBackProb.Name = "btnBackProb"
        Me.btnBackProb.Size = New System.Drawing.Size(75, 23)
        Me.btnBackProb.TabIndex = 1
        Me.btnBackProb.Text = "Back"
        Me.btnBackProb.UseVisualStyleBackColor = True
        '
        'dgvProbleemid
        '
        Me.dgvProbleemid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProbleemid.Location = New System.Drawing.Point(6, 40)
        Me.dgvProbleemid.Name = "dgvProbleemid"
        Me.dgvProbleemid.RowHeadersWidth = 51
        Me.dgvProbleemid.RowTemplate.Height = 24
        Me.dgvProbleemid.Size = New System.Drawing.Size(1043, 429)
        Me.dgvProbleemid.TabIndex = 0
        '
        'tpKindlustus
        '
        Me.tpKindlustus.Controls.Add(Me.dgvKindlustus)
        Me.tpKindlustus.Location = New System.Drawing.Point(4, 25)
        Me.tpKindlustus.Name = "tpKindlustus"
        Me.tpKindlustus.Size = New System.Drawing.Size(1057, 512)
        Me.tpKindlustus.TabIndex = 2
        Me.tpKindlustus.Text = "Kindlustus"
        Me.tpKindlustus.UseVisualStyleBackColor = True
        '
        'dgvKindlustus
        '
        Me.dgvKindlustus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKindlustus.Location = New System.Drawing.Point(7, 40)
        Me.dgvKindlustus.Name = "dgvKindlustus"
        Me.dgvKindlustus.RowHeadersWidth = 51
        Me.dgvKindlustus.RowTemplate.Height = 24
        Me.dgvKindlustus.Size = New System.Drawing.Size(1043, 429)
        Me.dgvKindlustus.TabIndex = 0
        '
        'formTabeliVaade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tcTabs)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "formTabeliVaade"
        Me.Text = "Form1"
        CType(Me.dgvTabeliVaade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcTabs.ResumeLayout(False)
        Me.tpAutod.ResumeLayout(False)
        Me.tbProbleemid.ResumeLayout(False)
        CType(Me.dgvProbleemid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpKindlustus.ResumeLayout(False)
        CType(Me.dgvKindlustus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTabeliVaade As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents tcTabs As TabControl
    Friend WithEvents tpAutod As TabPage
    Friend WithEvents tbProbleemid As TabPage
    Friend WithEvents dgvProbleemid As DataGridView
    Friend WithEvents btnBackProb As Button
    Friend WithEvents tpKindlustus As TabPage
    Friend WithEvents dgvKindlustus As DataGridView
End Class
