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
        Me.dgvProblemsList = New System.Windows.Forms.DataGridView()
        Me.tpHistory = New System.Windows.Forms.TabPage()
        Me.tpHistoryDetails = New System.Windows.Forms.TabPage()
        Me.tcTabs.SuspendLayout()
        Me.tpCarsList.SuspendLayout()
        CType(Me.dgvCarsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpProblems.SuspendLayout()
        CType(Me.dgvProblemsList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tcTabs.Location = New System.Drawing.Point(2, 3)
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.Size = New System.Drawing.Size(797, 445)
        Me.tcTabs.TabIndex = 0
        '
        'tpLogin
        '
        Me.tpLogin.Location = New System.Drawing.Point(4, 28)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Size = New System.Drawing.Size(789, 413)
        Me.tpLogin.TabIndex = 5
        Me.tpLogin.Text = "Login"
        Me.tpLogin.UseVisualStyleBackColor = True
        '
        'tpGroups
        '
        Me.tpGroups.Location = New System.Drawing.Point(4, 28)
        Me.tpGroups.Name = "tpGroups"
        Me.tpGroups.Size = New System.Drawing.Size(789, 413)
        Me.tpGroups.TabIndex = 6
        Me.tpGroups.Text = "Groups"
        Me.tpGroups.UseVisualStyleBackColor = True
        '
        'tpCarsList
        '
        Me.tpCarsList.Controls.Add(Me.btnCarBack)
        Me.tpCarsList.Controls.Add(Me.btnAddCar)
        Me.tpCarsList.Controls.Add(Me.dgvCarsList)
        Me.tpCarsList.Location = New System.Drawing.Point(4, 28)
        Me.tpCarsList.Name = "tpCarsList"
        Me.tpCarsList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCarsList.Size = New System.Drawing.Size(789, 413)
        Me.tpCarsList.TabIndex = 0
        Me.tpCarsList.Text = "Cars"
        Me.tpCarsList.UseVisualStyleBackColor = True
        '
        'btnCarBack
        '
        Me.btnCarBack.Location = New System.Drawing.Point(7, 6)
        Me.btnCarBack.Name = "btnCarBack"
        Me.btnCarBack.Size = New System.Drawing.Size(75, 23)
        Me.btnCarBack.TabIndex = 2
        Me.btnCarBack.Text = "Back"
        Me.btnCarBack.UseVisualStyleBackColor = True
        '
        'btnAddCar
        '
        Me.btnAddCar.Location = New System.Drawing.Point(707, 6)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCar.TabIndex = 1
        Me.btnAddCar.Text = "Add car"
        Me.btnAddCar.UseVisualStyleBackColor = True
        '
        'dgvCarsList
        '
        Me.dgvCarsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarsList.Location = New System.Drawing.Point(6, 35)
        Me.dgvCarsList.Name = "dgvCarsList"
        Me.dgvCarsList.RowHeadersWidth = 51
        Me.dgvCarsList.RowTemplate.Height = 24
        Me.dgvCarsList.Size = New System.Drawing.Size(777, 375)
        Me.dgvCarsList.TabIndex = 0
        '
        'tpCarDetails
        '
        Me.tpCarDetails.Location = New System.Drawing.Point(4, 28)
        Me.tpCarDetails.Name = "tpCarDetails"
        Me.tpCarDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCarDetails.Size = New System.Drawing.Size(789, 413)
        Me.tpCarDetails.TabIndex = 1
        Me.tpCarDetails.Text = "Car Details"
        Me.tpCarDetails.UseVisualStyleBackColor = True
        '
        'tpProblems
        '
        Me.tpProblems.Controls.Add(Me.btnProblemBack)
        Me.tpProblems.Controls.Add(Me.dgvProblemsList)
        Me.tpProblems.Location = New System.Drawing.Point(4, 28)
        Me.tpProblems.Name = "tpProblems"
        Me.tpProblems.Size = New System.Drawing.Size(789, 413)
        Me.tpProblems.TabIndex = 2
        Me.tpProblems.Text = "Car Problems"
        Me.tpProblems.UseVisualStyleBackColor = True
        '
        'btnProblemBack
        '
        Me.btnProblemBack.Location = New System.Drawing.Point(7, 7)
        Me.btnProblemBack.Name = "btnProblemBack"
        Me.btnProblemBack.Size = New System.Drawing.Size(75, 23)
        Me.btnProblemBack.TabIndex = 1
        Me.btnProblemBack.Text = "Back"
        Me.btnProblemBack.UseVisualStyleBackColor = True
        '
        'dgvProblemsList
        '
        Me.dgvProblemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProblemsList.Location = New System.Drawing.Point(6, 36)
        Me.dgvProblemsList.Name = "dgvProblemsList"
        Me.dgvProblemsList.RowHeadersWidth = 51
        Me.dgvProblemsList.RowTemplate.Height = 24
        Me.dgvProblemsList.Size = New System.Drawing.Size(776, 374)
        Me.dgvProblemsList.TabIndex = 0
        '
        'tpHistory
        '
        Me.tpHistory.Location = New System.Drawing.Point(4, 28)
        Me.tpHistory.Name = "tpHistory"
        Me.tpHistory.Size = New System.Drawing.Size(789, 413)
        Me.tpHistory.TabIndex = 3
        Me.tpHistory.Text = "Car History"
        Me.tpHistory.UseVisualStyleBackColor = True
        '
        'tpHistoryDetails
        '
        Me.tpHistoryDetails.Location = New System.Drawing.Point(4, 28)
        Me.tpHistoryDetails.Name = "tpHistoryDetails"
        Me.tpHistoryDetails.Size = New System.Drawing.Size(789, 413)
        Me.tpHistoryDetails.TabIndex = 4
        Me.tpHistoryDetails.Text = "History Details"
        Me.tpHistoryDetails.UseVisualStyleBackColor = True
        '
        'formTableViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tcTabs)
        Me.Name = "formTableViewer"
        Me.Text = "Car Logbook"
        Me.tcTabs.ResumeLayout(False)
        Me.tpCarsList.ResumeLayout(False)
        CType(Me.dgvCarsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpProblems.ResumeLayout(False)
        CType(Me.dgvProblemsList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvProblemsList As DataGridView
    Friend WithEvents btnCarBack As Button
    Friend WithEvents btnProblemBack As Button
End Class
