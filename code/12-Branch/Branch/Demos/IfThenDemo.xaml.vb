Public Class IfThenDemo
	Private Sub IfDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim odd As Integer
		Dim gen = New NumberGenerator
		odd = gen.GetRandomOddNumber(401)
		CurrentRandomOutput.Text = odd

#Region "Finished Code"
		If odd < 100 Then
			LowNumberOutput.Text &= odd.ToString & vbCrLf
		End If
#End Region

	End Sub
	Private Sub IfElseDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Dim odd As Integer
		Dim gen = New NumberGenerator
		odd = gen.GetRandomOddNumber(401)
		CurrentRandomOutput.Text = odd

#Region "Finished Code"
		If odd < 100 Then
			LowNumberOutput.Text &= odd.ToString & vbCrLf
		Else
			OtherNumberOutput.Text &= odd.ToString & vbCrLf
		End If
#End Region
	End Sub

	Private Sub IfElseIfDemo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		Dim databaseName As String = "db400"
		Dim odd As Integer
		Dim gen = New NumberGenerator
		odd = gen.GetRandomOddNumber(301)
		CurrentRandomOutput.Text = odd

#Region "Finished Code"
		If odd < 100 Then
			LowNumberOutput.Text &= odd.ToString & vbCrLf

		ElseIf odd > 200 Then
			HighNumberOutput.Text &= odd.ToString & vbCrLf
		Else
			OtherNumberOutput.Text &= odd.ToString & vbCrLf
		End If
#End Region

	End Sub
	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		LowNumberOutput.Text = ""
		HighNumberOutput.Text = ""
		OtherNumberOutput.Text = ""
	End Sub
End Class
