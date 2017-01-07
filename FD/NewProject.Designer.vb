<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProject
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
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkHideChk = New System.Windows.Forms.CheckBox()
        Me.ButAddAttribute = New System.Windows.Forms.Button()
        Me.DGProjectAttributes = New System.Windows.Forms.DataGridView()
        Me.الخاصيةDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.المسارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GetProjectAttributesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FDDataSet = New FD.FDDataSet()
        Me.ButAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtXpath = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbAttribute = New System.Windows.Forms.ComboBox()
        Me.AttributBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttribDS = New FD.AttribDS()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtPattern = New System.Windows.Forms.TextBox()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.txtURLCHECK = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblchk = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkUseCheck = New System.Windows.Forms.CheckBox()
        Me.WebBrowser3 = New System.Windows.Forms.WebBrowser()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.GetProjectAttributesTableAdapter = New FD.FDDataSetTableAdapters.GetProjectAttributesTableAdapter()
        Me.AttributTableAdapter = New FD.AttribDSTableAdapters.AttributTableAdapter()
        Me.chk1256 = New System.Windows.Forms.CheckBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGProjectAttributes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetProjectAttributesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttributBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttribDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(857, 611)
        Me.SplitContainer1.SplitterDistance = 379
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.ButSave)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtTo)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtFrom)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtPattern)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtURL)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtURLCHECK)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblchk)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtName)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer3.Panel1.Controls.Add(Me.chkUseCheck)
        Me.SplitContainer3.Panel1.Controls.Add(Me.chk1256)
        Me.SplitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.WebBrowser3)
        Me.SplitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer3.Size = New System.Drawing.Size(857, 611)
        Me.SplitContainer3.SplitterDistance = 447
        Me.SplitContainer3.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkHideChk)
        Me.Panel1.Controls.Add(Me.ButAddAttribute)
        Me.Panel1.Controls.Add(Me.DGProjectAttributes)
        Me.Panel1.Controls.Add(Me.ButAdd)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtXpath)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmbAttribute)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(857, 611)
        Me.Panel1.TabIndex = 26
        Me.Panel1.Visible = False
        '
        'chkHideChk
        '
        Me.chkHideChk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkHideChk.AutoSize = True
        Me.chkHideChk.Location = New System.Drawing.Point(643, 79)
        Me.chkHideChk.Name = "chkHideChk"
        Me.chkHideChk.Size = New System.Drawing.Size(112, 17)
        Me.chkHideChk.TabIndex = 29
        Me.chkHideChk.Text = "اخف صفحة الاختبار"
        Me.chkHideChk.UseVisualStyleBackColor = True
        Me.chkHideChk.Visible = False
        '
        'ButAddAttribute
        '
        Me.ButAddAttribute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButAddAttribute.Location = New System.Drawing.Point(550, 18)
        Me.ButAddAttribute.Name = "ButAddAttribute"
        Me.ButAddAttribute.Size = New System.Drawing.Size(24, 24)
        Me.ButAddAttribute.TabIndex = 28
        Me.ButAddAttribute.Text = "+"
        Me.ButAddAttribute.UseVisualStyleBackColor = True
        '
        'DGProjectAttributes
        '
        Me.DGProjectAttributes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGProjectAttributes.AutoGenerateColumns = False
        Me.DGProjectAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProjectAttributes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.الخاصيةDataGridViewTextBoxColumn, Me.المسارDataGridViewTextBoxColumn})
        Me.DGProjectAttributes.DataSource = Me.GetProjectAttributesBindingSource
        Me.DGProjectAttributes.Location = New System.Drawing.Point(548, 106)
        Me.DGProjectAttributes.Name = "DGProjectAttributes"
        Me.DGProjectAttributes.Size = New System.Drawing.Size(297, 110)
        Me.DGProjectAttributes.TabIndex = 27
        '
        'الخاصيةDataGridViewTextBoxColumn
        '
        Me.الخاصيةDataGridViewTextBoxColumn.DataPropertyName = "الخاصية"
        Me.الخاصيةDataGridViewTextBoxColumn.HeaderText = "الخاصية"
        Me.الخاصيةDataGridViewTextBoxColumn.Name = "الخاصيةDataGridViewTextBoxColumn"
        '
        'المسارDataGridViewTextBoxColumn
        '
        Me.المسارDataGridViewTextBoxColumn.DataPropertyName = "المسار"
        Me.المسارDataGridViewTextBoxColumn.HeaderText = "المسار"
        Me.المسارDataGridViewTextBoxColumn.Name = "المسارDataGridViewTextBoxColumn"
        '
        'GetProjectAttributesBindingSource
        '
        Me.GetProjectAttributesBindingSource.DataMember = "GetProjectAttributes"
        Me.GetProjectAttributesBindingSource.DataSource = Me.FDDataSet
        '
        'FDDataSet
        '
        Me.FDDataSet.DataSetName = "FDDataSet"
        Me.FDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButAdd
        '
        Me.ButAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButAdd.Location = New System.Drawing.Point(764, 77)
        Me.ButAdd.Name = "ButAdd"
        Me.ButAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButAdd.TabIndex = 26
        Me.ButAdd.Text = "أضف"
        Me.ButAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(797, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "المسار"
        '
        'txtXpath
        '
        Me.txtXpath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtXpath.Location = New System.Drawing.Point(548, 48)
        Me.txtXpath.Name = "txtXpath"
        Me.txtXpath.Size = New System.Drawing.Size(212, 20)
        Me.txtXpath.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(794, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "الخاصية"
        '
        'cmbAttribute
        '
        Me.cmbAttribute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAttribute.DataSource = Me.AttributBindingSource
        Me.cmbAttribute.DisplayMember = "AttributName"
        Me.cmbAttribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAttribute.FormattingEnabled = True
        Me.cmbAttribute.Location = New System.Drawing.Point(578, 16)
        Me.cmbAttribute.Name = "cmbAttribute"
        Me.cmbAttribute.Size = New System.Drawing.Size(179, 21)
        Me.cmbAttribute.TabIndex = 23
        Me.cmbAttribute.ValueMember = "id"
        '
        'AttributBindingSource
        '
        Me.AttributBindingSource.DataMember = "Attribut"
        Me.AttributBindingSource.DataSource = Me.AttribDS
        '
        'AttribDS
        '
        Me.AttribDS.DataSetName = "AttribDS"
        Me.AttribDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButSave
        '
        Me.ButSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButSave.Location = New System.Drawing.Point(767, 193)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(75, 23)
        Me.ButSave.TabIndex = 21
        Me.ButSave.Text = "حفظ"
        Me.ButSave.UseVisualStyleBackColor = True
        '
        'txtTo
        '
        Me.txtTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTo.Location = New System.Drawing.Point(498, 142)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTo.Size = New System.Drawing.Size(77, 20)
        Me.txtTo.TabIndex = 20
        Me.txtTo.Text = "500013027"
        '
        'txtFrom
        '
        Me.txtFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFrom.Location = New System.Drawing.Point(680, 142)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFrom.Size = New System.Drawing.Size(76, 20)
        Me.txtFrom.TabIndex = 19
        Me.txtFrom.Text = "500011212"
        '
        'txtPattern
        '
        Me.txtPattern.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPattern.Location = New System.Drawing.Point(488, 48)
        Me.txtPattern.Name = "txtPattern"
        Me.txtPattern.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPattern.Size = New System.Drawing.Size(266, 20)
        Me.txtPattern.TabIndex = 18
        Me.txtPattern.Text = "http://fatakat.com/thread/*"
        '
        'txtURL
        '
        Me.txtURL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURL.Location = New System.Drawing.Point(635, 79)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtURL.Size = New System.Drawing.Size(120, 20)
        Me.txtURL.TabIndex = 16
        Me.txtURL.Text = "500011212"
        '
        'txtURLCHECK
        '
        Me.txtURLCHECK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURLCHECK.Location = New System.Drawing.Point(635, 108)
        Me.txtURLCHECK.Name = "txtURLCHECK"
        Me.txtURLCHECK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtURLCHECK.Size = New System.Drawing.Size(121, 20)
        Me.txtURLCHECK.TabIndex = 17
        Me.txtURLCHECK.Text = "500013027"
        Me.txtURLCHECK.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(639, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "الى"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(824, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "من"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(779, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "شكل العنوان"
        '
        'lblchk
        '
        Me.lblchk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblchk.AutoSize = True
        Me.lblchk.Location = New System.Drawing.Point(762, 115)
        Me.lblchk.Name = "lblchk"
        Me.lblchk.Size = New System.Drawing.Size(83, 13)
        Me.lblchk.TabIndex = 3
        Me.lblchk.Text = "العنوان الاختباري"
        Me.lblchk.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(807, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "العنوان"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, -23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "اسم المشروع"
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(487, 14)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(266, 20)
        Me.txtName.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(771, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "اسم المشروع"
        '
        'chkUseCheck
        '
        Me.chkUseCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkUseCheck.AutoSize = True
        Me.chkUseCheck.Location = New System.Drawing.Point(487, 79)
        Me.chkUseCheck.Name = "chkUseCheck"
        Me.chkUseCheck.Size = New System.Drawing.Size(131, 17)
        Me.chkUseCheck.TabIndex = 29
        Me.chkUseCheck.Text = "استخدم عنوان اختباري"
        Me.chkUseCheck.UseVisualStyleBackColor = True
        '
        'WebBrowser3
        '
        Me.WebBrowser3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser3.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser3.Name = "WebBrowser3"
        Me.WebBrowser3.ScriptErrorsSuppressed = True
        Me.WebBrowser3.Size = New System.Drawing.Size(150, 46)
        Me.WebBrowser3.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.WebBrowser2)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.Size = New System.Drawing.Size(96, 100)
        Me.SplitContainer2.SplitterDistance = 49
        Me.SplitContainer2.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(49, 100)
        Me.WebBrowser1.TabIndex = 0
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScriptErrorsSuppressed = True
        Me.WebBrowser2.Size = New System.Drawing.Size(43, 100)
        Me.WebBrowser2.TabIndex = 0
        '
        'GetProjectAttributesTableAdapter
        '
        Me.GetProjectAttributesTableAdapter.ClearBeforeFill = True
        '
        'AttributTableAdapter
        '
        Me.AttributTableAdapter.ClearBeforeFill = True
        '
        'chk1256
        '
        Me.chk1256.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk1256.AutoSize = True
        Me.chk1256.Location = New System.Drawing.Point(534, 110)
        Me.chk1256.Name = "chk1256"
        Me.chk1256.Size = New System.Drawing.Size(84, 17)
        Me.chk1256.TabIndex = 30
        Me.chk1256.Text = "Arabic-1256"
        Me.chk1256.UseVisualStyleBackColor = True
        '
        'NewProject
        '
        Me.AcceptButton = Me.ButSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 611)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "NewProject"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "NewProject"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGProjectAttributes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetProjectAttributesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttributBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttribDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblchk As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser3 As System.Windows.Forms.WebBrowser
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtPattern As System.Windows.Forms.TextBox
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents txtURLCHECK As System.Windows.Forms.TextBox
    Friend WithEvents ButSave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbAttribute As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DGProjectAttributes As System.Windows.Forms.DataGridView
    Friend WithEvents الخاصيةDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents المسارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GetProjectAttributesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FDDataSet As FD.FDDataSet
    Friend WithEvents ButAdd As System.Windows.Forms.Button
    Friend WithEvents txtXpath As System.Windows.Forms.TextBox
    Friend WithEvents GetProjectAttributesTableAdapter As FD.FDDataSetTableAdapters.GetProjectAttributesTableAdapter
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AttribDS As FD.AttribDS
    Friend WithEvents AttributBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AttributTableAdapter As FD.AttribDSTableAdapters.AttributTableAdapter
    Friend WithEvents ButAddAttribute As System.Windows.Forms.Button
    Friend WithEvents chkUseCheck As System.Windows.Forms.CheckBox
    Friend WithEvents chkHideChk As System.Windows.Forms.CheckBox
    Friend WithEvents chk1256 As System.Windows.Forms.CheckBox
End Class
