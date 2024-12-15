Public Class AddDemo

	' this demo uses the debugger 


	Private Sub AddDemo(sender As Object, e As RoutedEventArgs) Handles AddButton.Click

		Dim colorNames As New List(Of String)

		' .Add ()
		' .AddRange ()

		' .Insert ()
		' .InsertRange

	End Sub

	Private Sub GetButton_Click(sender As Object, e As RoutedEventArgs) Handles GetButton.Click
		' get an item with index
		Dim brandColors = New BrandColors()
		Dim colorNames = brandColors.ColorNames

		Dim myColor = colorNames.Item(3)

		Dim firstColor = brandColors.ColorNames(0) ' no need for .Item
		Dim lastColor = brandColors.ColorNames(brandColors.ColorCount - 1)

		' Future topics
		' -- customize methods with predicate functions
		' -- iterate over list
		' -- use LINQ

		' .Find, FindLast, FindAll, 
		'Dim findReddish = brandColors.ColorNames.Find ()

	End Sub
	Private Sub RemoveButton_Click(sender As Object, e As RoutedEventArgs) Handles RemoveButton.Click
		' remove items from the list
		Dim brandColors = New BrandColors()
		Dim colorNames = brandColors.ColorNames

		'colorNames.Remove()
		'colorNames.RemoveAt()
		'colorNames.RemoveRange()


		' Future topics
		' -- customize methods with predicate functions
		'	colorNames.RemoveAll()
	End Sub


#Region "Finished Code"

#End Region

	Private Sub Clear()
		OutputList.ItemsSource = Nothing
		OutputList.Items.Clear()

	End Sub


End Class
