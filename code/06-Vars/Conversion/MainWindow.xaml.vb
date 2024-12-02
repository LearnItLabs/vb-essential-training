Option Strict Off

Class MainWindow

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		Dim myInteger As Integer = Integer.MaxValue
		Dim myShort As Short = Short.MaxValue


		Dim targetShort As Short

		targetShort = NumberSlider.Value
		ShowIt(targetShort)
	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click
		Dim myInteger As Integer = Integer.MaxValue
		Dim myShort As Short = Short.MaxValue

		Dim targetShort As Short

		targetShort = Convert.ToInt16(NumberSlider.Value)

		ShowIt(targetShort.ToString)

	End Sub



	Sub ShowIt(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub



	Sub ShowLine()
		MessageTextBox.Text += "-----------" + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub

	Private Sub PropsButton_Click(sender As Object, e As RoutedEventArgs) Handles PropsButton.Click
		' Integer, Double, Boolean are .NET types
		Dim counter As Integer = 10
		' we can use Shared methods and properties of the type in our code
		Dim max = Integer.MaxValue
		Dim min = Integer.MinValue

		Dim isPos = Integer.IsPositive(10)
		Dim isOdd = Integer.IsOddInteger(15)

		Dim trailCount = Integer.TrailingZeroCount(766500)
	End Sub
End Class