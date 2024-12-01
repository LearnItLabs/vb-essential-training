Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click


		Dim title As String = "Code explorer is a WPF desktop application."
		ShowIt(title)

		Dim thisMessage As String = "Created for showing code examples. "
		ShowIt(thisMessage)


	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click

		Dim counter As Integer = 15

		ShowIt(counter)
		ShowLine()
		counter += 12
		ShowIt(counter)

	End Sub


	Sub ShowIt(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub
	Sub ShowLine()
		MessageTextBox.Text += "»-»-»-»-»-»-»-»-»-»-»-»" + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub

End Class
