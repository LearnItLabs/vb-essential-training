Public Class IterateDemo

	Private Sub ListOfStringsDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		Dim colorNames As New List(Of String)

		colorNames.Add("Scarlet")
		colorNames.Add("Magenta")
		colorNames.Insert(0, "Blue")
		colorNames.AddRange({"Green", "Lavender"})



		' Use For Each to loop through a collection

#Region "Finished Code"
		For Each color In colorNames
			OutputList.Items.Add(color)
		Next
#End Region

	End Sub

	Private Sub ListOfIntegersDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Dim gen As New NumberGenerator
		Dim oddNumbers = gen.GetRandomOddNumber(301)


		For Each number In oddNumbers
			OutputList.Items.Add($"{number.ToString("D3")} * 4 = {(number * 4).ToString("D4")}")
		Next

	End Sub

	Private Sub BindingDemo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		Dim compassPoints As New List(Of String)({"North", "East", "South", "West"})
		OutputList.ItemsSource = compassPoints
	End Sub
	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		OutputList.ItemsSource = Nothing
		OutputList.Items.Clear()

	End Sub

#Region "Finished Code"

#End Region
	Dim parentWin As MainWindow
	Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)

		parentWin = Window.GetWindow(Me)

	End Sub
End Class
