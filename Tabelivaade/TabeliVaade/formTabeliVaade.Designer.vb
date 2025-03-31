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
        CType(Me.dgvTabeliVaade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTabeliVaade
        '
        Me.dgvTabeliVaade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabeliVaade.Location = New System.Drawing.Point(18, 127)
        Me.dgvTabeliVaade.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvTabeliVaade.Name = "dgvTabeliVaade"
        Me.dgvTabeliVaade.RowHeadersWidth = 62
        Me.dgvTabeliVaade.Size = New System.Drawing.Size(1164, 483)
        Me.dgvTabeliVaade.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(560, 622)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tabel"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btnAdd.Location = New System.Drawing.Point(18, 67)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(133, 32)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Car"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'formTabeliVaade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTabeliVaade)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "formTabeliVaade"
        Me.Text = "Form1"
        CType(Me.dgvTabeliVaade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTabeliVaade As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
End Class
