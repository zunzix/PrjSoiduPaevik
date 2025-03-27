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
        Me.btnProbleemid = New System.Windows.Forms.Button()
        CType(Me.dgvTabeliVaade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTabeliVaade
        '
        Me.dgvTabeliVaade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabeliVaade.Location = New System.Drawing.Point(16, 15)
        Me.dgvTabeliVaade.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTabeliVaade.Name = "dgvTabeliVaade"
        Me.dgvTabeliVaade.RowHeadersWidth = 51
        Me.dgvTabeliVaade.Size = New System.Drawing.Size(1035, 474)
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
        'btnProbleemid
        '
        Me.btnProbleemid.Location = New System.Drawing.Point(16, 510)
        Me.btnProbleemid.Name = "btnProbleemid"
        Me.btnProbleemid.Size = New System.Drawing.Size(99, 23)
        Me.btnProbleemid.TabIndex = 2
        Me.btnProbleemid.Text = "Probleemid"
        Me.btnProbleemid.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProbleemid.UseVisualStyleBackColor = True
        '
        'formTabeliVaade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnProbleemid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTabeliVaade)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "formTabeliVaade"
        Me.Text = "Form1"
        CType(Me.dgvTabeliVaade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTabeliVaade As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProbleemid As Button
End Class
