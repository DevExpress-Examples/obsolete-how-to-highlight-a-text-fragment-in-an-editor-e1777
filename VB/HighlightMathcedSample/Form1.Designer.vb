Imports Microsoft.VisualBasic
Imports System
Namespace HighlightMathcedSample
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
			Me.sampleButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
			CType(Me.sampleButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' sampleButtonEdit
			' 
			Me.sampleButtonEdit.Location = New System.Drawing.Point(12, 12)
			Me.sampleButtonEdit.Name = "sampleButtonEdit"
			Me.sampleButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.sampleButtonEdit.Size = New System.Drawing.Size(268, 20)
			Me.sampleButtonEdit.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 43)
			Me.Controls.Add(Me.sampleButtonEdit)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.sampleButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private sampleButtonEdit As DevExpress.XtraEditors.ButtonEdit
	End Class
End Namespace

