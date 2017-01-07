<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowProject
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ButSearch = New System.Windows.Forms.Button()
        Me.chkArab = New System.Windows.Forms.CheckBox()
        Me.cmbProjects = New System.Windows.Forms.ComboBox()
        Me.ProjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectsDS = New FD.ProjectsDS()
        Me.TreeViewFast1 = New FD.TreeViewFast()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ProjectTableAdapter = New FD.ProjectsDSTableAdapters.ProjectTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ProjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectsDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkArab)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbProjects)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeViewFast1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(728, 517)
        Me.SplitContainer1.SplitterDistance = 241
        Me.SplitContainer1.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(71, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(167, 20)
        Me.txtSearch.TabIndex = 4
        '
        'ButSearch
        '
        Me.ButSearch.Location = New System.Drawing.Point(2, 27)
        Me.ButSearch.Name = "ButSearch"
        Me.ButSearch.Size = New System.Drawing.Size(63, 23)
        Me.ButSearch.TabIndex = 3
        Me.ButSearch.Text = "بحث"
        Me.ButSearch.UseVisualStyleBackColor = True
        '
        'chkArab
        '
        Me.chkArab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkArab.AutoSize = True
        Me.chkArab.Checked = True
        Me.chkArab.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkArab.Location = New System.Drawing.Point(13, 7)
        Me.chkArab.Name = "chkArab"
        Me.chkArab.Size = New System.Drawing.Size(52, 17)
        Me.chkArab.TabIndex = 2
        Me.chkArab.Text = "عربي"
        Me.chkArab.UseVisualStyleBackColor = True
        '
        'cmbProjects
        '
        Me.cmbProjects.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProjects.DataSource = Me.ProjectBindingSource
        Me.cmbProjects.DisplayMember = "ProjectName"
        Me.cmbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProjects.FormattingEnabled = True
        Me.cmbProjects.Location = New System.Drawing.Point(72, 3)
        Me.cmbProjects.Name = "cmbProjects"
        Me.cmbProjects.Size = New System.Drawing.Size(166, 21)
        Me.cmbProjects.TabIndex = 1
        Me.cmbProjects.ValueMember = "id"
        '
        'ProjectBindingSource
        '
        Me.ProjectBindingSource.DataMember = "Project"
        Me.ProjectBindingSource.DataSource = Me.ProjectsDS
        '
        'ProjectsDS
        '
        Me.ProjectsDS.DataSetName = "ProjectsDS"
        Me.ProjectsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TreeViewFast1
        '
        Me.TreeViewFast1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeViewFast1.Location = New System.Drawing.Point(0, 51)
        Me.TreeViewFast1.Name = "TreeViewFast1"
        Me.TreeViewFast1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TreeViewFast1.RightToLeftLayout = True
        Me.TreeViewFast1.Size = New System.Drawing.Size(242, 466)
        Me.TreeViewFast1.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(483, 517)
        Me.WebBrowser1.TabIndex = 0
        '
        'ProjectTableAdapter
        '
        Me.ProjectTableAdapter.ClearBeforeFill = True
        '
        'ShowProject
        '
        Me.AcceptButton = Me.ButSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 517)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ShowProject"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "ShowProject"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ProjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectsDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeViewFast1 As FD.TreeViewFast
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents cmbProjects As System.Windows.Forms.ComboBox
    Friend WithEvents ProjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProjectTableAdapter As FD.ProjectsDSTableAdapters.ProjectTableAdapter
    Friend WithEvents ProjectsDS As FD.ProjectsDS
    Friend WithEvents chkArab As System.Windows.Forms.CheckBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ButSearch As System.Windows.Forms.Button
End Class
