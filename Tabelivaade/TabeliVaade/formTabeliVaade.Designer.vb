<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTabeliVaade
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvTabeliVaade = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tcTabs = New System.Windows.Forms.TabControl()
        Me.tpAutod = New System.Windows.Forms.TabPage()
        Me.tbProbleemid = New System.Windows.Forms.TabPage()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvProbleemid = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTabeliVaade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcTabs.SuspendLayout()
        Me.tbProbleemid.SuspendLayout()
        CType(Me.dgvProbleemid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTabeliVaade
        '
        Me.dgvTabeliVaade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabeliVaade.Location = New System.Drawing.Point(16, 102)
        Me.dgvTabeliVaade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvTabeliVaade.Name = "dgvTabeliVaade"
        Me.dgvTabeliVaade.RowHeadersWidth = 62
        Me.dgvTabeliVaade.Size = New System.Drawing.Size(1035, 386)
        Me.dgvTabeliVaade.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(497, 497)
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
        Me.btnAdd.Location = New System.Drawing.Point(16, 54)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(119, 26)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Car"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'tcTabs
        '
        Me.tcTabs.Controls.Add(Me.tpAutod)
        Me.tcTabs.Controls.Add(Me.tbProbleemid)
        Me.tcTabs.Location = New System.Drawing.Point(1, 1)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(1065, 541)
        Me.tcTabs.TabIndex = 3
        '
        'tpAutod
        '
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
        Me.tbProbleemid.Controls.Add(Me.btnBack)
        Me.tbProbleemid.Controls.Add(Me.dgvProbleemid)
        Me.tbProbleemid.Location = New System.Drawing.Point(4, 25)
        Me.tbProbleemid.Name = "tbProbleemid"
        Me.tbProbleemid.Padding = New System.Windows.Forms.Padding(3)
        Me.tbProbleemid.Size = New System.Drawing.Size(1057, 512)
        Me.tbProbleemid.TabIndex = 1
        Me.tbProbleemid.Text = "Problem View"
        Me.tbProbleemid.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(6, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvProbleemid
        '
        Me.dgvProbleemid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProbleemid.Location = New System.Drawing.Point(6, 35)
        Me.dgvProbleemid.Name = "dgvProbleemid"
        Me.dgvProbleemid.RowHeadersWidth = 51
        Me.dgvProbleemid.RowTemplate.Height = 24
        Me.dgvProbleemid.Size = New System.Drawing.Size(1043, 429)
        Me.dgvProbleemid.TabIndex = 0
        '
        'formTabeliVaade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTabeliVaade)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "formTabeliVaade"
        Me.Text = "Form1"
        CType(Me.dgvTabeliVaade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcTabs.ResumeLayout(False)
        Me.tbProbleemid.ResumeLayout(False)
        CType(Me.dgvProbleemid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnBack As Button
End Class
