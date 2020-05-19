<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.Options = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Options.SuspendLayout()
		Me.SuspendLayout()
		'
		'RichTextBox1
		'
		Me.RichTextBox1.BackColor = System.Drawing.Color.White
		Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(334, 237)
		Me.RichTextBox1.TabIndex = 0
		Me.RichTextBox1.Text = ""
		'
		'Options
		'
		Me.Options.BackColor = System.Drawing.Color.Transparent
		Me.Options.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
		Me.Options.Location = New System.Drawing.Point(0, 0)
		Me.Options.Name = "Options"
		Me.Options.Size = New System.Drawing.Size(334, 24)
		Me.Options.TabIndex = 1
		Me.Options.Text = "Option"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(334, 261)
		Me.Controls.Add(Me.RichTextBox1)
		Me.Controls.Add(Me.Options)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.Options
		Me.MinimumSize = New System.Drawing.Size(350, 300)
		Me.Name = "Main"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "WriteMe"
		Me.Options.ResumeLayout(False)
		Me.Options.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents Options As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
End Class
