Public Class IterateDemo

	Private Sub ListOfStringsDemo(sender As Object, e As RoutedEventArgs) Handles LoopStringButton.Click
		' For Each loop  allows us to iterate over collections
		' and other types that implement
		' the IEnumerable or IEnumerable(Of T) interfaces

		Dim brandColors = New BrandColors()
		Dim colorNames = brandColors.ColorNames



		' Use For Each to loop through a collection

#Region "Finished Code"
		'For Each color In colorNames
		'	OutputList.Items.Add(color)
		'Next
#End Region

	End Sub

	Private Sub ListOfProducts(sender As Object, e As RoutedEventArgs) Handles LoopProductButton.Click
		Dim gen As New NumberGenerator
		Dim totalSales As Decimal


		For Each sold In gen.GetDailyProductSales
			totalSales += sold.Price
			OutputList.Items.Add($"Product: {sold.ProductName}, {sold.Price.ToString("C")} ")
		Next
		OutputList.Items.Add($"Total sales for : {DateTime.Now.ToString("MMMM dd")}, {totalSales.ToString("C")} ")
	End Sub

	Private Sub BindCompassDemo(sender As Object, e As RoutedEventArgs) Handles BindCompassButton.Click
		Dim compassPoints As New List(Of String)({"North", "East", "South", "West"})
		OutputList.ItemsSource = compassPoints
	End Sub


	Private Sub BindProductsDemo(sender As Object, e As RoutedEventArgs) Handles BindProductButton.Click
		Dim gen As New NumberGenerator
		OutputList.ItemsSource = gen.GetDailyProductSales
		ModifiedList.ItemsSource = gen.GetDailyProductSales
	End Sub
	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		OutputList.ItemsSource = Nothing
		OutputList.Items.Clear()

		ModifiedList.ItemsSource = Nothing
		ModifiedList.Items.Clear()

	End Sub

	Private Sub LoopStringButton_Click(sender As Object, e As RoutedEventArgs)

	End Sub

#Region "Finished Code"

#End Region


End Class
