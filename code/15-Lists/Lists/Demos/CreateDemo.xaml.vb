Public Class CreateDemo


	Private Sub CreateNew(sender As Object, e As RoutedEventArgs) Handles CreateButton.Click

#Region "Finished Code"
		'Dim colorNamesArray(20) As String
		'Dim oddNumbersArray(10) As Integer

		Dim colorNamesList As New List(Of String)
		'Dim oddNumbersList = New List(Of Integer)

		'colorNamesArray(3) = "Blue"
		'colorNamesList.Add ("Scarlet")

		'ReDim colorNamesArray(30)
#End Region

	End Sub
	Private Sub Clear()
		OutputList.ItemsSource = Nothing
		OutputList.Items.Clear()

	End Sub

	Private Sub InitButton_Click(sender As Object, e As RoutedEventArgs) Handles InitButton.Click

		' Show the new methods in the NumberGenerator class.
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
End Class
