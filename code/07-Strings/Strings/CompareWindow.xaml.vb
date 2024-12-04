Imports System.Reflection.Metadata

Public Class CompareWindow
	Private Sub ButtonA_Click(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

	End Sub

	Sub ShowIt(message As String)
		Dim bulletText As New Run("» ")
		MessageOut.Inlines.Add(bulletText)
		bulletText.Foreground = Brushes.SteelBlue
		Dim normalText As New Run(message + vbCrLf)
		MessageOut.Inlines.Add(message + vbCrLf)
	End Sub
	Sub ShowBlankLine()
		Dim lineText As New Run("" + vbCrLf)
		MessageOut.Inlines.Add(lineText)
	End Sub
	Sub ShowHeader(message As String)
		Dim boldText As New Run(message + vbCrLf)
		boldText.FontWeight = FontWeights.Bold
		MessageOut.Inlines.Add(boldText)

	End Sub

	Sub ShowLine()
		Dim lineText As New Run(New String("-"c, 68) + vbCrLf)
		lineText.Foreground = Brushes.LightBlue
		MessageOut.Inlines.Add(lineText)
	End Sub
	Sub Clear()
		If MessageOut IsNot Nothing Then
			MessageOut.Text = ""
		End If

	End Sub

	Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs)
		Dim areEqual As Boolean = False
		Dim compareValue As Integer = 0

		Dim first As String = FirstTextBox.Text
		Dim second As String = SecondTextBox.Text
		Clear()

		areEqual = first.Equals(second)
		ShowHeader("Are Equal")
		ShowIt(areEqual)

		areEqual = first.Equals(second, StringComparison.OrdinalIgnoreCase)
		ShowHeader("Are Equal (ignore case)")
		ShowIt(areEqual)

		compareValue = first.CompareTo(second) ' returns 1,0,-1

		' comparing number values is easy to understand
		' 6.7 => 7.9 = -1
		' 6.7 => 6.7 = 0
		' 6.7 => 2.3 = 1

		' what about strings?
		' camped => campus = ?
		' Hablo => Habló
		' SEATTLE => seattle


		ShowHeader("CompareTo")
		ShowIt(compareValue)

		' ' returns a range of number -114, 0, 256
		compareValue = String.Compare(first, second, StringComparison.Ordinal)

		ShowHeader("Compare")
		ShowIt(compareValue)
	End Sub

	Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
		AddHandler FirstTextBox.TextChanged, AddressOf TextBox_TextChanged
		AddHandler SecondTextBox.TextChanged, AddressOf TextBox_TextChanged
	End Sub


End Class
