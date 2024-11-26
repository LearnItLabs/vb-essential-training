Imports System.Runtime.CompilerServices

Public Class FinishedWindow


	Private Sub outputTheDateButton_Click(sender As Object, e As RoutedEventArgs) Handles outputTheDayButton.Click
		textBlock1.Text = DateTime.Now.DayOfWeek.ToString
		Me.Background = New SolidColorBrush(Colors.LightBlue)
	End Sub

	Private Sub textBox1_TextChanged(sender As Object, e As TextChangedEventArgs) Handles textBox1.TextChanged
		textBlock1.Text = textBox1.Text & "-"
	End Sub
End Class
