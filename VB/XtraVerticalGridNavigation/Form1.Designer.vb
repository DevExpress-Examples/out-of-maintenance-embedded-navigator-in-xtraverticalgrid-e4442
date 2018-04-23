Imports Microsoft.VisualBasic
Imports System
Namespace XtraVerticalGridNavigation
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.chUseNavigator = New System.Windows.Forms.CheckBox()
			Me.myVGridControl1 = New XtraVerticalGridNavigation.MyVGridControl()
			CType(Me.myVGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chUseNavigator
			' 
			Me.chUseNavigator.AutoSize = True
			Me.chUseNavigator.Checked = True
			Me.chUseNavigator.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chUseNavigator.Location = New System.Drawing.Point(12, 140)
			Me.chUseNavigator.Name = "chUseNavigator"
			Me.chUseNavigator.Size = New System.Drawing.Size(142, 17)
			Me.chUseNavigator.TabIndex = 1
			Me.chUseNavigator.Text = "UseEmbeddedNavigator"
			Me.chUseNavigator.UseVisualStyleBackColor = True
'			Me.chUseNavigator.CheckedChanged += New System.EventHandler(Me.chUseNavigator_CheckedChanged);
			' 
			' myVGridControl1
			' 
			Me.myVGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			' 
			' 
			' 
			Me.myVGridControl1.EmbeddedNavigator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.myVGridControl1.EmbeddedNavigator.Location = New System.Drawing.Point(1, 165)
			Me.myVGridControl1.EmbeddedNavigator.Name = ""
			Me.myVGridControl1.EmbeddedNavigator.NavigatableControl = Me.myVGridControl1
			Me.myVGridControl1.EmbeddedNavigator.Size = New System.Drawing.Size(262, 17)
			Me.myVGridControl1.EmbeddedNavigator.TabIndex = 2
			Me.myVGridControl1.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
			Me.myVGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myVGridControl1.Name = "myVGridControl1"
			Me.myVGridControl1.Size = New System.Drawing.Size(620, 183)
			Me.myVGridControl1.TabIndex = 2
			Me.myVGridControl1.UseEmbeddedNavigator = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(620, 183)
			Me.Controls.Add(Me.chUseNavigator)
			Me.Controls.Add(Me.myVGridControl1)
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Embedded Navigator"
			CType(Me.myVGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents chUseNavigator As System.Windows.Forms.CheckBox
		Private myVGridControl1 As MyVGridControl

	End Class
End Namespace

