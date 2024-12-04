Public Class CompareWindow
	Private Sub ButtonA_Click(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		' Using Equals method
		'Dim foundEquals As Boolean = False
		'Dim fruit
		'foundEquals =
		'For Each fruit In fruits
		'	If fruit.Equals(fruitToCheck, StringComparison.OrdinalIgnoreCase) Then
		'		foundEquals = True
		'		Exit For
		'	End If
		'Next
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
		Clear()

		areEqual = FirstTextBox.Text.Equals(SecondTextBox.Text)
		ShowHeader("Are Equal")
		ShowIt(areEqual)

		compareValue = FirstTextBox.Text.CompareTo(SecondTextBox.Text)
		ShowHeader("Compare")
		ShowIt(compareValue)
	End Sub

	Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
		AddHandler FirstTextBox.TextChanged, AddressOf TextBox_TextChanged
		AddHandler SecondTextBox.TextChanged, AddressOf TextBox_TextChanged
	End Sub


End Class
