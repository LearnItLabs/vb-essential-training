Public Class ToStringDoneWindow
	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		Dim myInteger As Integer = 43218765
		Dim myLong As Long = 9988776655

		ShowHeader("No format")
		ShowIt(myInteger.ToString)
		ShowIt(myLong)
		' code here

		ShowBlankLine()
		ShowHeader("Number format (N)")
		ShowIt(myInteger.ToString("N"))
		ShowIt(myLong.ToString("N"))
		' code here

		ShowBlankLine()
		ShowHeader("Exponent format (E)")
		ShowIt(myInteger.ToString("E"))
		ShowIt(myLong.ToString("E"))
		' code here

		ShowBlankLine()
		ShowHeader("Currency format (C)")
		ShowIt(myInteger.ToString("C"))
		ShowIt(myLong.ToString("C"))
		' code here

		ShowBlankLine()
		ShowHeader("Hexadecimal")
		Dim myByte As Byte = 127
		ShowIt(myByte)
		ShowIt(myByte.ToString("X"))

		' code here


#Region "Learn More"
		' learn more about format strings
		'	https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
#End Region
	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click

		Dim myDate As Date = #10/21/2027#
		ShowIt(myDate)
		ShowIt(myDate.ToString("D"))

		' code here


#Region "Learn More"
		' learn more about data format strings
		' https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
#End Region

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

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageOut.Text = ""
	End Sub

End Class