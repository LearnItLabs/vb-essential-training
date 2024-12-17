Public Class Whatx
	Private Sub OpenFileButton_Click(sender As Object, e As RoutedEventArgs) Handles OpenFileButton.Click
		FileATextBox.Text = ErrorMaker.OpenFile(System.AppDomain.CurrentDomain.BaseDirectory & "\example.txt")
	End Sub

	Private Sub OpenExceptionButton_Click(sender As Object, e As RoutedEventArgs) Handles OpenExceptionButton.Click
		FileBTextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")
	End Sub

	Private Sub DivisionButton_Click(sender As Object, e As RoutedEventArgs) Handles DivisionButton.Click
		Dim result = ErrorMaker.WorkWithNumbers(7)
	End Sub

	Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub
	Private Sub Clear()

		FileATextBox.Text = ""
		FileBTextBox.Text = ""

	End Sub

End Class
