Public Class ToStringWindow
	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		Dim myInteger As Integer = 43218765
		Dim myLong As Long = 9988776655

		ShowIt("--No format--")
		' code here

		ShowBlankLine()
		ShowIt("--Number------")
		' code here

		ShowBlankLine()
		ShowIt("--Exponent-------")
		' code here

		ShowBlankLine()
		ShowIt("--Currency--------")
		' code here

		ShowBlankLine()
		ShowIt("--Hexadecimal--------")
		' code here


#Region "Learn More"
		' learn more about format strings
		'	https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
#End Region
	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click


		ShowIt("--Date--------")
		' code here


#Region "Learn More"
		' learn more about data format strings
		' https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
#End Region

	End Sub



	Sub ShowIt(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub
	Sub ShowBlankLine()
		MessageTextBox.Text += vbCrLf
	End Sub

	Sub ShowFormatted(message As String, number As Object)
		Dim formatted As IFormattable = number
		'Dim newString = formatted.ToString("G", Nothing)
		MessageTextBox.Text += $"{message} {formatted.ToString("N0", Nothing)}{vbCrLf}"
	End Sub

	Sub ShowLine()
		MessageTextBox.Text += "-----------" + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub

End Class