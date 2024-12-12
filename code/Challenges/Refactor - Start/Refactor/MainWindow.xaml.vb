Class MainWindow
	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		' Challenge: Part 1
		' allow the user to enter the max value
		' by entering an integer in the NumberTextBox 
		Dim gen = New NumberGenerator
		Dim odd = gen.GetRandomOddNumber(201)

		ShowIt(odd)
	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		' Challenge: Part 1
		' allow the user to enter the max value
		' by entering an integer in the NumberTextBox 
		Dim gen = New NumberGenerator
		Dim even = gen.GetRandomEvenNumber(201)
		ShowIt(even)

	End Sub

	Private Sub RunCode3(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		' Challenge: Part 2
		' show a random squared value
		' when this button is clicked
		' 2, 4, 9, 16, 25, 36 etc.
		' reuse or refactor the code in Module NumberGenerator
	End Sub

#Region "Show methods"

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
	Sub Clear()
		MessageOut.Text = ""
	End Sub

	Sub ShowLine()
		Dim lineText As New Run(New String("-"c, 68) + vbCrLf)
		lineText.Foreground = Brushes.LightBlue
		MessageOut.Inlines.Add(lineText)
	End Sub
#End Region


End Class
