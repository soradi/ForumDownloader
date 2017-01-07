<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadProject
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
        Me.cmbProject = New System.Windows.Forms.ComboBox()
        Me.ProjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectsDS = New FD.ProjectsDS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButDownload = New System.Windows.Forms.Button()
        Me.DGProjectPages = New System.Windows.Forms.DataGridView()
        Me.GetProjectPagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectPagesDS = New FD.ProjectPagesDS()
        Me.GetProjectPagesTableAdapter = New FD.ProjectPagesDSTableAdapters.GetProjectPagesTableAdapter()
        Me.ProjectTableAdapter = New FD.ProjectsDSTableAdapters.ProjectTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkDownloadPics = New System.Windows.Forms.CheckBox()
        Me.chkDownloadHref = New System.Windows.Forms.CheckBox()
        Me.chkNoHTML = New System.Windows.Forms.CheckBox()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.txtThreadsCount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ProjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectsDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGProjectPages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetProjectPagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectPagesDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbProject
        '
        Me.cmbProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProject.DataSource = Me.ProjectBindingSource
        Me.cmbProject.DisplayMember = "ProjectName"
        Me.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProject.FormattingEnabled = True
        Me.cmbProject.Location = New System.Drawing.Point(546, 6)
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.Size = New System.Drawing.Size(211, 21)
        Me.cmbProject.TabIndex = 0
        Me.cmbProject.ValueMember = "id"
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
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(778, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "المشروع"
        '
        'ButDownload
        '
        Me.ButDownload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButDownload.Location = New System.Drawing.Point(465, 4)
        Me.ButDownload.Name = "ButDownload"
        Me.ButDownload.Size = New System.Drawing.Size(75, 23)
        Me.ButDownload.TabIndex = 2
        Me.ButDownload.Text = "تحميل"
        Me.ButDownload.UseVisualStyleBackColor = True
        '
        'DGProjectPages
        '
        Me.DGProjectPages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGProjectPages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProjectPages.Location = New System.Drawing.Point(8, 43)
        Me.DGProjectPages.Name = "DGProjectPages"
        Me.DGProjectPages.Size = New System.Drawing.Size(819, 279)
        Me.DGProjectPages.TabIndex = 3
        Me.DGProjectPages.Visible = False
        '
        'GetProjectPagesBindingSource
        '
        Me.GetProjectPagesBindingSource.DataMember = "GetProjectPages"
        Me.GetProjectPagesBindingSource.DataSource = Me.ProjectPagesDS
        '
        'ProjectPagesDS
        '
        Me.ProjectPagesDS.DataSetName = "ProjectPagesDS"
        Me.ProjectPagesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GetProjectPagesTableAdapter
        '
        Me.GetProjectPagesTableAdapter.ClearBeforeFill = True
        '
        'ProjectTableAdapter
        '
        Me.ProjectTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'chkDownloadPics
        '
        Me.chkDownloadPics.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDownloadPics.AutoSize = True
        Me.chkDownloadPics.Checked = True
        Me.chkDownloadPics.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDownloadPics.Location = New System.Drawing.Point(357, 6)
        Me.chkDownloadPics.Name = "chkDownloadPics"
        Me.chkDownloadPics.Size = New System.Drawing.Size(82, 17)
        Me.chkDownloadPics.TabIndex = 4
        Me.chkDownloadPics.Text = "تحميل الصور"
        Me.chkDownloadPics.UseVisualStyleBackColor = True
        '
        'chkDownloadHref
        '
        Me.chkDownloadHref.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDownloadHref.AutoSize = True
        Me.chkDownloadHref.Checked = True
        Me.chkDownloadHref.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDownloadHref.Location = New System.Drawing.Point(263, 6)
        Me.chkDownloadHref.Name = "chkDownloadHref"
        Me.chkDownloadHref.Size = New System.Drawing.Size(88, 17)
        Me.chkDownloadHref.TabIndex = 5
        Me.chkDownloadHref.Text = "تحميل الروابط"
        Me.chkDownloadHref.UseVisualStyleBackColor = True
        '
        'chkNoHTML
        '
        Me.chkNoHTML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkNoHTML.AutoSize = True
        Me.chkNoHTML.Checked = True
        Me.chkNoHTML.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoHTML.Location = New System.Drawing.Point(165, 23)
        Me.chkNoHTML.Name = "chkNoHTML"
        Me.chkNoHTML.Size = New System.Drawing.Size(166, 17)
        Me.chkNoHTML.TabIndex = 6
        Me.chkNoHTML.Text = "عدم تحميل روابط على صفحات"
        Me.chkNoHTML.UseVisualStyleBackColor = True
        '
        'chkUpdate
        '
        Me.chkUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkUpdate.AutoSize = True
        Me.chkUpdate.Location = New System.Drawing.Point(134, 4)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(55, 17)
        Me.chkUpdate.TabIndex = 7
        Me.chkUpdate.Text = "تحديث"
        Me.chkUpdate.UseVisualStyleBackColor = True
        '
        'txtThreadsCount
        '
        Me.txtThreadsCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtThreadsCount.Location = New System.Drawing.Point(357, 23)
        Me.txtThreadsCount.Name = "txtThreadsCount"
        Me.txtThreadsCount.Size = New System.Drawing.Size(35, 20)
        Me.txtThreadsCount.TabIndex = 8
        Me.txtThreadsCount.Text = "80"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(398, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "التحميلات في نفس الوقت"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 600000
        '
        'DownloadProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 334)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtThreadsCount)
        Me.Controls.Add(Me.chkUpdate)
        Me.Controls.Add(Me.chkNoHTML)
        Me.Controls.Add(Me.chkDownloadHref)
        Me.Controls.Add(Me.chkDownloadPics)
        Me.Controls.Add(Me.DGProjectPages)
        Me.Controls.Add(Me.ButDownload)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbProject)
        Me.Name = "DownloadProject"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "DownloadProject"
        CType(Me.ProjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectsDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGProjectPages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetProjectPagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectPagesDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbProject As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButDownload As System.Windows.Forms.Button
    Friend WithEvents DGProjectPages As System.Windows.Forms.DataGridView
    Friend WithEvents GetProjectPagesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProjectPagesDS As FD.ProjectPagesDS
    Friend WithEvents GetProjectPagesTableAdapter As FD.ProjectPagesDSTableAdapters.GetProjectPagesTableAdapter
    Friend WithEvents ProjectsDS As FD.ProjectsDS
    Friend WithEvents ProjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProjectTableAdapter As FD.ProjectsDSTableAdapters.ProjectTableAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chkDownloadPics As System.Windows.Forms.CheckBox
    Friend WithEvents chkDownloadHref As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoHTML As System.Windows.Forms.CheckBox
    Friend WithEvents chkUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents txtThreadsCount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
