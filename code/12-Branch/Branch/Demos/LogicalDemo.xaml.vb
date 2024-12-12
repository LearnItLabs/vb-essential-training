Public Class LogicalDemo
	Private Sub AndDemo(sender As Object, e As RoutedEventArgs) Handles ButtonE.Click

		If DayTextBox.Text = "Monday" Then
			PizzaImage.Visibility = Visibility.Visible
			CouponImage.Visibility = Visibility.Hidden
			PizzaAwardTextBox.Text += "Free Pizza!" + vbCrLf
		Else
			PizzaImage.Visibility = Visibility.Hidden
			CouponImage.Visibility = Visibility.Visible
			PizzaAwardTextBox.Text += "No Pizza, Here's a coupon." + vbCrLf
		End If
#Region "Finished Code"
		' If DayTextBox.Text = "Monday" AndAlso TimeSlider.Value < 3 Then
#End Region
	End Sub
	Private Sub OrDemo(sender As Object, e As RoutedEventArgs) Handles ButtonG.Click
		If DayTextBox.Text = "Monday" Then
			PizzaImage.Visibility = Visibility.Visible
			CouponImage.Visibility = Visibility.Hidden
			PizzaAwardTextBox.Text += "Free Pizza!" + vbCrLf
		Else
			PizzaImage.Visibility = Visibility.Hidden
			CouponImage.Visibility = Visibility.Visible
			PizzaAwardTextBox.Text += "No Pizza, Here's a coupon." + vbCrLf
		End If

#Region "Finished Code"
		'If DayTextBox.Text = "Monday" OrElse TimeSlider.Value < 3  Then
#End Region
	End Sub
End Class
