Class MainWindow


	Private Sub Show_Click(sender As Object, e As RoutedEventArgs) Handles ShowButton.Click
		Dim startDate As Date
		Dim interval As Integer
		If Date.TryParse(StartDateTextBox.Text, startDate) = False Then
			ShowIt("Cannot parse the start date.")
			Exit Sub
		End If
		If Integer.TryParse(IntervalTextBox.Text, interval) = False Then

			ShowIt("Cannot parse the interval.")
			Exit Sub
		End If


		ShowIt("Original Date: " + startDate.ToLongDateString)
		ShowIt("Number of days and months to add: " + interval.ToString)
		Dim newDate = startDate.AddDays(interval).AddMonths(interval)
		ShowIt("Calculated End date: " + newDate.ToLongDateString)
	End Sub
	Private Sub Clear_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
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
