Option Strict Off
Public Class ParseWindow
	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		Dim myInteger As Integer
		Dim myDouble As Double

		' code here

		ShowIt("--Integer------")
		ShowIt(myInteger.ToString())
		ShowIt("--Double------")
		ShowIt(myDouble.ToString())

		ShowBlankLine()

	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click

		Dim myDouble As Double

		' code here


	End Sub



	Sub ShowIt(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub
	Sub ShowBlankLine()
		MessageTextBox.Text += vbCrLf
	End Sub


	Sub ShowLine()
		MessageTextBox.Text += "-----------" + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		MessageTextBox.Text = ""
	End Sub
End Class