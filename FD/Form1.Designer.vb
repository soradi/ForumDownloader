<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButSave = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFourmName = New System.Windows.Forms.TextBox()
        Me.txtArticleTitle = New System.Windows.Forms.TextBox()
        Me.txtArticleContent = New System.Windows.Forms.TextBox()
        Me.txtURLCHECK = New System.Windows.Forms.TextBox()
        Me.check = New System.Windows.Forms.Label()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtPattern = New System.Windows.Forms.TextBox()
        Me.WebBrowser3 = New System.Windows.Forms.WebBrowser()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButSave
        '
        Me.ButSave.Location = New System.Drawing.Point(346, 205)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(75, 23)
        Me.ButSave.TabIndex = 0
        Me.ButSave.Text = "Save"
        Me.ButSave.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(852, 486)
        Me.WebBrowser1.TabIndex = 1
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(41, 12)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(268, 20)
        Me.txtURL.TabIndex = 2
        Me.txtURL.Text = "http://fatakat.com/thread/500011212"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "URL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "عنوان المنتدى"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(346, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "عنوان الموضوع"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "الموضوع"
        '
        'txtFourmName
        '
        Me.txtFourmName.Location = New System.Drawing.Point(40, 72)
        Me.txtFourmName.Name = "txtFourmName"
        Me.txtFourmName.Size = New System.Drawing.Size(269, 20)
        Me.txtFourmName.TabIndex = 7
        '
        'txtArticleTitle
        '
        Me.txtArticleTitle.Location = New System.Drawing.Point(40, 99)
        Me.txtArticleTitle.Name = "txtArticleTitle"
        Me.txtArticleTitle.Size = New System.Drawing.Size(268, 20)
        Me.txtArticleTitle.TabIndex = 8
        '
        'txtArticleContent
        '
        Me.txtArticleContent.Location = New System.Drawing.Point(40, 126)
        Me.txtArticleContent.Name = "txtArticleContent"
        Me.txtArticleContent.Size = New System.Drawing.Size(267, 20)
        Me.txtArticleContent.TabIndex = 9
        '
        'txtURLCHECK
        '
        Me.txtURLCHECK.Location = New System.Drawing.Point(43, 41)
        Me.txtURLCHECK.Name = "txtURLCHECK"
        Me.txtURLCHECK.Size = New System.Drawing.Size(267, 20)
        Me.txtURLCHECK.TabIndex = 10
        Me.txtURLCHECK.Text = "http://fatakat.com/thread/500013027"
        '
        'check
        '
        Me.check.AutoSize = True
        Me.check.Location = New System.Drawing.Point(343, 48)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(69, 13)
        Me.check.TabIndex = 11
        Me.check.Text = "URL to check"
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(-29, 382)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.TabIndex = 12
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.WebBrowser3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPattern)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtURL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.check)
        Me.SplitContainer1.Panel1.Controls.Add(Me.WebBrowser2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtURLCHECK)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtArticleContent)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtArticleTitle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFourmName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1284, 486)
        Me.SplitContainer1.SplitterDistance = 428
        Me.SplitContainer1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "From"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(205, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(369, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Pattern"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(230, 187)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(77, 20)
        Me.txtTo.TabIndex = 15
        Me.txtTo.Text = "500013027"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(93, 187)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(76, 20)
        Me.txtFrom.TabIndex = 14
        Me.txtFrom.Text = "500011212"
        '
        'txtPattern
        '
        Me.txtPattern.Location = New System.Drawing.Point(41, 156)
        Me.txtPattern.Name = "txtPattern"
        Me.txtPattern.Size = New System.Drawing.Size(266, 20)
        Me.txtPattern.TabIndex = 13
        Me.txtPattern.Text = "http://fatakat.com/thread/*"
        '
        'WebBrowser3
        '
        Me.WebBrowser3.Location = New System.Drawing.Point(49, 247)
        Me.WebBrowser3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser3.Name = "WebBrowser3"
        Me.WebBrowser3.Size = New System.Drawing.Size(372, 188)
        Me.WebBrowser3.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 486)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButSave As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFourmName As System.Windows.Forms.TextBox
    Friend WithEvents txtArticleTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtArticleContent As System.Windows.Forms.TextBox
    Friend WithEvents txtURLCHECK As System.Windows.Forms.TextBox
    Friend WithEvents check As System.Windows.Forms.Label
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtPattern As System.Windows.Forms.TextBox
    Friend WithEvents WebBrowser3 As System.Windows.Forms.WebBrowser

End Class
