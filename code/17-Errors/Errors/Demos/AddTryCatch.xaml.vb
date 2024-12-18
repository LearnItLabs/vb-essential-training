Imports System.Diagnostics.Metrics

Public Class AddTryCatch

	Dim _counter As Integer = 0
	Private Sub ButtonA_Click(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Try
			_counter += 1
			FileATextBox.Text = _counter
			FileBTextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")

		Catch

		End Try
	End Sub

	Private Sub ButtonB_Click(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Try
			_counter += 1
			FileATextBox.Text = _counter

			FileBTextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")
		Catch ex As Exception
			MessageBox.Show($"Something went wrong { ex.Message}")
		End Try
	End Sub

	Private Sub ButtonC_Click(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		Try
			_counter += 1
			FileATextBox.Text = _counter
			FileBTextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")
			Dim result = ErrorMaker.WorkWithNumbers(7)

		Catch ex As System.IO.FileNotFoundException
			MessageBox.Show($"Cannot access the file  { ex.FileName}")
		Catch ex As OverflowException
			MessageBox.Show($"This looks like a division error")
		Catch ex As Exception
			MessageBox.Show($"Something went wrong { ex.Message}")

		End Try
	End Sub

	Private Sub ButtonD_Click(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click
		Try
			_counter += 1
			Dim result As Integer = GetDataFromList(20)
			FileATextBox.Text = _counter
			FileBTextBox.Text = ErrorMaker.OpenFile("c:\nofile.txt")
			result = ErrorMaker.WorkWithNumbers(7)

		Catch ex As System.IO.FileNotFoundException
			MessageBox.Show($"Cannot access the file  { ex.FileName}")
		Catch ex As OverflowException
			MessageBox.Show($"This looks like a division error")
		Catch ex As Exception

			' this block is for unexpected exceptions
			' best log the exception
			MessageBox.Show($"Something went wrong { ex.Message}")
			My.
			'My.Log.WriteException(ex, TraceEventType.Critical, "Add a custom log message")
		End Try

	End Sub
End Class
