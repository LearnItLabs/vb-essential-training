Public Class DateWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		' declare and assign literal

		' use DateTime class

		' current date-time


		' more readable with named parameters



		'ShowIt($"literalDate: {literalDate}")
		'ShowIt($"parsedDate: {parsedDate}")
		'ShowIt($"fromDateClass: {fromDateClass}")

		'ShowLine()
		'ShowIt($"currentDate: {currentDate}")
		'ShowLine()

		'ShowIt($"readableDate: {readableDate}")
	End Sub
	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click
		Dim literalTime As Date = #5:06:10 PM#
		' more readable with named parameters
		Dim fromDateClass = New Date(year:=2007, month:=2, day:=27, hour:=16, minute:=30, second:=55)

		ShowIt($"literalTime: {literalTime}")
		ShowIt($"fromDateClass: {fromDateClass}")
		ShowIt($"fromDateClass Formatted: {fromDateClass.ToLongTimeString}")

		ShowBlankLine()
	End Sub

	Private Sub RunCode3(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

		Dim startDate, endDate As Date
		If Date.TryParse(StartDateTextBox.Text, startDate) = False Then
			ShowIt("Cannot parse the start date.")
			Exit Sub
		End If
		If Date.TryParse(EndDateTextBox.Text, endDate) = False Then

			ShowIt("Cannot parse the end date.")
			Exit Sub
		End If

		ShowIt(startDate.ToLongDateString)
		ShowIt(endDate.ToShortDateString)

		ShowIt("custom date format: " + startDate.ToString("yyyy--MM--dd"))
		ShowIt($"EndDate, Day: {endDate.Day}")
		ShowIt($"EndDate, DayOfWeek: {endDate.DayOfWeek}")
		ShowIt($"EndDate, DayOfYear: {endDate.DayOfYear}")
		ShowIt($"EndDate, IsDaylightSaving: {endDate.IsDaylightSavingTime}")

	End Sub

	Private Sub RunCode4(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		' how many days between days
		Dim startDate, endDate As Date
		If Date.TryParse(StartDateTextBox.Text, startDate) = False Then
			ShowIt("Cannot parse the start date.")
			Exit Sub
		End If
		If Date.TryParse(EndDateTextBox.Text, endDate) = False Then

			ShowIt("Cannot parse the end date.")
			Exit Sub
		End If

		Dim myTimeSpan As TimeSpan ' the distance between dates
		ShowIt("Original Date: " + startDate.ToLongDateString)
		Dim newDate = startDate.AddDays(5)
		ShowIt("Add Days: " + newDate.ToLongDateString)
		myTimeSpan = endDate.Subtract(startDate)

		ShowIt("Days between: " + myTimeSpan.TotalDays.ToString)
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
	Sub Clear()
		MessageOut.Text = ""
	End Sub

	Sub ShowLine()
		Dim lineText As New Run(New String("-"c, 68) + vbCrLf)
		lineText.Foreground = Brushes.LightBlue
		MessageOut.Inlines.Add(lineText)
	End Sub

	Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub
End Class
