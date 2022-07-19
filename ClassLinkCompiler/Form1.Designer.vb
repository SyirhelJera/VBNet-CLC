<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ClassLinkBox = New System.Windows.Forms.ListBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CNameTextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel = New System.Windows.Forms.Label()
        Me.LinkTextBox = New System.Windows.Forms.TextBox()
        Me.ClassLabel = New System.Windows.Forms.Label()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ClassLinkBox
        '
        Me.ClassLinkBox.FormattingEnabled = True
        Me.ClassLinkBox.ItemHeight = 15
        Me.ClassLinkBox.Location = New System.Drawing.Point(12, 12)
        Me.ClassLinkBox.Name = "ClassLinkBox"
        Me.ClassLinkBox.Size = New System.Drawing.Size(332, 349)
        Me.ClassLinkBox.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(350, 380)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(83, 23)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add Link"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'CNameTextBox
        '
        Me.CNameTextBox.Location = New System.Drawing.Point(126, 380)
        Me.CNameTextBox.Name = "CNameTextBox"
        Me.CNameTextBox.Size = New System.Drawing.Size(218, 23)
        Me.CNameTextBox.TabIndex = 2
        '
        'LinkLabel
        '
        Me.LinkLabel.AutoSize = True
        Me.LinkLabel.Location = New System.Drawing.Point(12, 412)
        Me.LinkLabel.Name = "LinkLabel"
        Me.LinkLabel.Size = New System.Drawing.Size(59, 15)
        Me.LinkLabel.TabIndex = 3
        Me.LinkLabel.Text = "Class Link"
        '
        'LinkTextBox
        '
        Me.LinkTextBox.Location = New System.Drawing.Point(126, 409)
        Me.LinkTextBox.Name = "LinkTextBox"
        Me.LinkTextBox.Size = New System.Drawing.Size(218, 23)
        Me.LinkTextBox.TabIndex = 5
        '
        'ClassLabel
        '
        Me.ClassLabel.AutoSize = True
        Me.ClassLabel.Location = New System.Drawing.Point(12, 388)
        Me.ClassLabel.Name = "ClassLabel"
        Me.ClassLabel.Size = New System.Drawing.Size(69, 15)
        Me.ClassLabel.TabIndex = 6
        Me.ClassLabel.Text = "Class Name"
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(350, 409)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(83, 23)
        Me.RemoveButton.TabIndex = 7
        Me.RemoveButton.Text = "Delete Link"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 450)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.ClassLabel)
        Me.Controls.Add(Me.LinkTextBox)
        Me.Controls.Add(Me.LinkLabel)
        Me.Controls.Add(Me.CNameTextBox)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ClassLinkBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class Link Compiler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClassLinkBox As ListBox
    Friend WithEvents AddButton As Button
    Friend WithEvents CNameTextBox As TextBox
    Friend WithEvents LinkLabel As Label
    Friend WithEvents LinkTextBox As TextBox
    Friend WithEvents ClassLabel As Label
    Friend WithEvents RemoveButton As Button
End Class
