Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Media.Animation

Class MainWindow

	Private Sub Var_Click(sender As Object, e As RoutedEventArgs) Handles VarButton.Click
		' declare the variables
		Dim date1 As Date
		Dim date2 As DateTime
		Dim dateOnly1 As DateOnly
		Dim timeOnly1 As TimeOnly


		ShowIt($"Date: {date1}")
		ShowIt($"DateTime: {date2}")
		ShowLine()
		ShowIt($"DateOnly: {dateOnly1}")


		ShowIt($"TimeOnly: {timeOnly1}")
		ShowLine()


	End Sub

	Private Sub Init_Click(sender As Object, e As RoutedEventArgs) Handles InitButton.Click

		' declare and assign literal
		Dim literalDate As DateOnly
		Dim parsedDate As Date
		' best to use TryParse!


		' use DateTime class
		Dim fromDateClass As Date


		' current date-time
		Dim currentDate As Date


		' more readable with named parameters
		Dim readableDate As Date

		ShowIt($"literalDate: {literalDate}")
		ShowIt($"parsedDate: {parsedDate}")
		ShowIt($"fromDateClass: {fromDateClass}")

		ShowLine()
		ShowIt($"currentDate: {currentDate}")
		ShowLine()

		ShowIt($"readableDate: {readableDate}")

	End Sub
	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles DateOnlyButton.Click
		' DateOnly initialize
		'	Cannot directly assign a date literal to a DateOnly variable.
		'	Use its constructor or parsing methods to create an instance.

		' Dim literalDate As DateOnly = #3/3/1953#

		Dim newDate As DateOnly = New DateOnly(1963, 4, 4)
		Dim parsedDate As DateOnly = DateOnly.Parse(#3/3/1993#)



		ShowIt($"newDate: {newDate}")
		ShowIt($"parsedDate: {parsedDate}")

	End Sub
	Private Sub Time_Click(sender As Object, e As RoutedEventArgs) Handles TimeButton.Click
		Dim literalTime As Date = #5:06:10 PM#
		' more readable with named parameters
		Dim fromDateClass = New Date(year:=2007, month:=2, day:=27, hour:=16, minute:=30, second:=55)

		ShowIt($"literalTime: {literalTime}")
		ShowIt($"fromDateClass: {fromDateClass}")
		'ShowIt($"fromDateClass Formatted: {fromDateClass.ToLongTimeString}")
		ShowBlankLine()

		Dim newTime As TimeOnly = New TimeOnly(11, 46)
		Dim parsedDate As TimeOnly = TimeOnly.Parse(#9:17:10 PM#)
		ShowIt($"newTime: {newTime}")
		ShowIt($"parsedDate: {parsedDate}")

		ShowBlankLine()


	End Sub


	Private Sub Format_Click(sender As Object, e As RoutedEventArgs) Handles FormatButton.Click
		Dim startDate, endDate As DateOnly
		If DateOnly.TryParse(StartDateTextBox.Text, startDate) = False Then
			ShowIt("Cannot parse the start date.")
			Exit Sub
		End If
		If DateOnly.TryParse(EndDateTextBox.Text, endDate) = False Then

			ShowIt("Cannot parse the end date.")
			Exit Sub
		End If

		ShowIt($"ToString: {startDate.ToString}")
		ShowIt($"LongDate: {startDate.ToLongDateString}")

		ShowIt($"ShortDate: {endDate.ToShortDateString}")

		ShowIt("custom date format: " + startDate.ToString("yyyy--MM--dd"))
		ShowIt($"EndDate, Day: {endDate.Day}")
		ShowIt($"EndDate, DayOfWeek: {endDate.DayOfWeek}")
		ShowIt($"EndDate, DayOfYear: {endDate.DayOfYear}")
		Dim time As TimeOnly = New TimeOnly(hour:=11, minute:=43)
		ShowIt($"TimeOnly, Hour: {time.Hour}")
	End Sub

	Private Sub Methods_Click(sender As Object, e As RoutedEventArgs) Handles MethodsButton.Click
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
		Dim newDate = startDate.Subtract(5)
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
