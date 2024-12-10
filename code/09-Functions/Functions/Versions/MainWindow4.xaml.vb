Namespace V4
	Class MainWindow
		Private Sub OddButton_Click(sender As Object, e As RoutedEventArgs) Handles OddButton.Click


		End Sub

		Private Sub EvenButton_Click(sender As Object, e As RoutedEventArgs) Handles EvenButton.Click

		End Sub
		Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
			Clear()
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
End Namespace
