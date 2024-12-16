Public Class AddDemo

	' this demo uses the debugger 

	Private Sub InitButton_Click(sender As Object, e As RoutedEventArgs) Handles InitButton.Click

		' new keyword create an instance with no items
		Dim gen = New NumberGenerator
		Dim empty = New List(Of Decimal)
		Dim salesList1 As New List(Of Decimal)({33D, 44D, 55D, 0.66D})

		' init from an array
		Dim salesList2 As List(Of Decimal) = gen.GetDailySales.ToList

		' init from another List (of T))

		Dim odds As List(Of Integer) = gen.GetListOfRandomOddNumbers(listCount:=12, maxValue:=50)

		' implicit typing
		Dim moreOdds = gen.GetListOfRandomOddNumbers(listCount:=6, maxValue:=201)

		Dim salesList3 = gen.GetDailySales.ToList()
	End Sub
	Private Sub AddDemo(sender As Object, e As RoutedEventArgs) Handles AddButton.Click

		Dim colorNames As New List(Of String)

		colorNames.Add("Scarlet")
		colorNames.Add("Magenta")
		colorNames.Insert(0, "Blue")
		colorNames.AddRange({"Emerald", "Olive", "Sage", "Lavender"})

	End Sub

	Private Sub GetButton_Click(sender As Object, e As RoutedEventArgs) Handles GetButton.Click
		' Show the new methods in the BrandColors class.
		' get an item with index
		Dim brandColors = New BrandColors()
		Dim colorNames = brandColors.ColorNames

		Dim myColor = colorNames.Item(3)

		Dim firstColor = brandColors.ColorNames(0) ' no need for .Item
		Dim lastColor = brandColors.ColorNames(brandColors.ColorCount - 1)
		colorNames.Item(3) = "Saffron"
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

		colorNames.Remove("Olive")
		colorNames.RemoveAt(3)
		colorNames.RemoveRange(index:=0, 2)


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
