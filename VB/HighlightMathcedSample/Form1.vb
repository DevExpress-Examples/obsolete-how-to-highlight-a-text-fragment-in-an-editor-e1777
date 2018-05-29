Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports System.Reflection
Imports DevExpress.XtraEditors.ViewInfo

Namespace HighlightMathcedSample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			InitializeButtonEdit()
		End Sub

		Private Sub InitializeButtonEdit()
			sampleButtonEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor
			sampleButtonEdit.Text = "Uriah DXSample"
			AddHandler sampleButtonEdit.KeyDown, AddressOf OnSampleButtonEditKeyDown
		End Sub

		Private Sub OnSampleButtonEditKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			Dim letter As Char
			Dim editor As BaseEdit = CType(sender, BaseEdit)
			Dim pi As PropertyInfo = GetType(BaseEdit).GetProperty("ViewInfo", BindingFlags.Instance Or BindingFlags.NonPublic)
			Dim viewInfo As BaseEditViewInfo = CType(pi.GetValue(editor, Nothing), BaseEditViewInfo)
			Dim matchedString As New StringBuilder(viewInfo.MatchedString)

            If GetCharToSelect(editor.Text, matchedString.ToString(), letter) AndAlso Char.Parse(letter.ToString().ToUpperInvariant()) = ChrW(e.KeyValue) Then
                matchedString.Append(editor.Text.Substring(matchedString.Length, 1))
            ElseIf e.KeyCode = Keys.Back AndAlso matchedString.Length > 0 Then
                matchedString.Remove(matchedString.Length - 1, 1)
            Else
                Return
            End If

			viewInfo.MatchedString = matchedString.ToString()
			editor.Invalidate()
		End Sub

		Private Function GetCharToSelect(ByVal text As String, ByVal matchedString As String, <System.Runtime.InteropServices.Out()> ByRef letter As Char) As Boolean
			If matchedString.Length < text.Length Then
				letter = Char.Parse(text.Substring(matchedString.Length, 1))
				Return True
			End If
			letter = ControlChars.NullChar
			Return False
		End Function
	End Class
End Namespace