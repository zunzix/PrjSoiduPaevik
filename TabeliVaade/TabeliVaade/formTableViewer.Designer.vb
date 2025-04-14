<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTableViewer
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
        Me.tcTabs = New System.Windows.Forms.TabControl()
        Me.tpLogin = New System.Windows.Forms.TabPage()
        Me.tpGroups = New System.Windows.Forms.TabPage()
        Me.tpCarsList = New System.Windows.Forms.TabPage()
        Me.btnCarBack = New System.Windows.Forms.Button()
        Me.btnAddCar = New System.Windows.Forms.Button()
        Me.dgvCarsList = New System.Windows.Forms.DataGridView()
        Me.tpCarDetails = New System.Windows.Forms.TabPage()
        Me.tpProblems = New System.Windows.Forms.TabPage()
        Me.btnProblemBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tpHistory = New System.Windows.Forms.TabPage()
        Me.tpHistoryDetails = New System.Windows.Forms.TabPage()
        Me.tpAddCar = New System.Windows.Forms.TabPage()
        Me.tcTabs.SuspendLayout()
        Me.tpCarsList.SuspendLayout()
        CType(Me.dgvCarsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpProblems.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcTabs
        '
        Me.tcTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcTabs.Controls.Add(Me.tpLogin)
        Me.tcTabs.Controls.Add(Me.tpGroups)
        Me.tcTabs.Controls.Add(Me.tpCarsList)
        Me.tcTabs.Controls.Add(Me.tpCarDetails)
        Me.tcTabs.Controls.Add(Me.tpProblems)
        Me.tcTabs.Controls.Add(Me.tpHistory)
        Me.tcTabs.Controls.Add(Me.tpHistoryDetails)
        Me.tcTabs.Controls.Add(Me.tpAddCar)
        Me.tcTabs.Location = New System.Drawing.Point(2, 4)
        Me.tcTabs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(897, 556)
        Me.tcTabs.TabIndex = 0
        '
        'tpLogin
        '
        Me.tpLogin.Location = New System.Drawing.Point(4, 32)
        Me.tpLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Size = New System.Drawing.Size(889, 520)
        Me.tpLogin.TabIndex = 5
        Me.tpLogin.Text = "Login"
        Me.tpLogin.UseVisualStyleBackColor = True
        '
        'tpGroups
        '
        Me.tpGroups.Location = New System.Drawing.Point(4, 32)
        Me.tpGroups.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpGroups.Name = "tpGroups"
        Me.tpGroups.Size = New System.Drawing.Size(889, 520)
        Me.tpGroups.TabIndex = 6
        Me.tpGroups.Text = "Groups"
        Me.tpGroups.UseVisualStyleBackColor = True
        '
        'tpCarsList
        '
        Me.tpCarsList.Controls.Add(Me.btnCarBack)
        Me.tpCarsList.Controls.Add(Me.btnAddCar)
        Me.tpCarsList.Controls.Add(Me.dgvCarsList)
        Me.tpCarsList.Location = New System.Drawing.Point(4, 32)
        Me.tpCarsList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpCarsList.Name = "tpCarsList"
        Me.tpCarsList.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpCarsList.Size = New System.Drawing.Size(889, 520)
        Me.tpCarsList.TabIndex = 0
        Me.tpCarsList.Text = "Cars"
        Me.tpCarsList.UseVisualStyleBackColor = True
        '
        'btnCarBack
        '
        Me.btnCarBack.Location = New System.Drawing.Point(8, 8)
        Me.btnCarBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCarBack.Name = "btnCarBack"
        Me.btnCarBack.Size = New System.Drawing.Size(84, 29)
        Me.btnCarBack.TabIndex = 2
        Me.btnCarBack.Text = "Back"
        Me.btnCarBack.UseVisualStyleBackColor = True
        '
        'btnAddCar
        '
        Me.btnAddCar.Location = New System.Drawing.Point(795, 8)
        Me.btnAddCar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(84, 29)
        Me.btnAddCar.TabIndex = 1
        Me.btnAddCar.Text = "Add car"
        Me.btnAddCar.UseVisualStyleBackColor = True
        '
        'dgvCarsList
        '
        Me.dgvCarsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarsList.Location = New System.Drawing.Point(7, 44)
        Me.dgvCarsList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvCarsList.Name = "dgvCarsList"
        Me.dgvCarsList.RowHeadersWidth = 51
        Me.dgvCarsList.RowTemplate.Height = 24
        Me.dgvCarsList.Size = New System.Drawing.Size(874, 469)
        Me.dgvCarsList.TabIndex = 0
        '
        'tpCarDetails
        '
        Me.tpCarDetails.Location = New System.Drawing.Point(4, 32)
        Me.tpCarDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpCarDetails.Name = "tpCarDetails"
        Me.tpCarDetails.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpCarDetails.Size = New System.Drawing.Size(889, 520)
        Me.tpCarDetails.TabIndex = 1
        Me.tpCarDetails.Text = "Car Details"
        Me.tpCarDetails.UseVisualStyleBackColor = True
        '
        'tpProblems
        '
        Me.tpProblems.Controls.Add(Me.btnProblemBack)
        Me.tpProblems.Controls.Add(Me.DataGridView1)
        Me.tpProblems.Location = New System.Drawing.Point(4, 32)
        Me.tpProblems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpProblems.Name = "tpProblems"
        Me.tpProblems.Size = New System.Drawing.Size(889, 520)
        Me.tpProblems.TabIndex = 2
        Me.tpProblems.Text = "Car Problems"
        Me.tpProblems.UseVisualStyleBackColor = True
        '
        'btnProblemBack
        '
        Me.btnProblemBack.Location = New System.Drawing.Point(8, 9)
        Me.btnProblemBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnProblemBack.Name = "btnProblemBack"
        Me.btnProblemBack.Size = New System.Drawing.Size(84, 29)
        Me.btnProblemBack.TabIndex = 1
        Me.btnProblemBack.Text = "Back"
        Me.btnProblemBack.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 45)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(873, 468)
        Me.DataGridView1.TabIndex = 0
        '
        'tpHistory
        '
        Me.tpHistory.Location = New System.Drawing.Point(4, 32)
        Me.tpHistory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpHistory.Name = "tpHistory"
        Me.tpHistory.Size = New System.Drawing.Size(889, 520)
        Me.tpHistory.TabIndex = 3
        Me.tpHistory.Text = "Car History"
        Me.tpHistory.UseVisualStyleBackColor = True
        '
        'tpHistoryDetails
        '
        Me.tpHistoryDetails.Location = New System.Drawing.Point(4, 32)
        Me.tpHistoryDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpHistoryDetails.Name = "tpHistoryDetails"
        Me.tpHistoryDetails.Size = New System.Drawing.Size(889, 520)
        Me.tpHistoryDetails.TabIndex = 4
        Me.tpHistoryDetails.Text = "History Details"
        Me.tpHistoryDetails.UseVisualStyleBackColor = True
        '
        'tpAddCar
        '
        Me.tpAddCar.Location = New System.Drawing.Point(4, 32)
        Me.tpAddCar.Name = "tpAddCar"
        Me.tpAddCar.Size = New System.Drawing.Size(889, 520)
        Me.tpAddCar.TabIndex = 7
        Me.tpAddCar.Text = "tpAddCar"
        Me.tpAddCar.UseVisualStyleBackColor = True
        '
        'formTableViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.tcTabs)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formTableViewer"
        Me.Text = "Car Logbook"
        Me.tcTabs.ResumeLayout(False)
        Me.tpCarsList.ResumeLayout(False)
        CType(Me.dgvCarsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpProblems.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcTabs As TabControl
    Friend WithEvents tpCarsList As TabPage
    Friend WithEvents tpCarDetails As TabPage
    Friend WithEvents tpProblems As TabPage
    Friend WithEvents tpHistory As TabPage
    Friend WithEvents tpHistoryDetails As TabPage
    Friend WithEvents tpLogin As TabPage
    Friend WithEvents tpGroups As TabPage
    Friend WithEvents btnAddCar As Button
    Friend WithEvents dgvCarsList As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCarBack As Button
    Friend WithEvents btnProblemBack As Button
    Friend WithEvents tpAddCar As TabPage
End Class
