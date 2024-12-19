Public Class LinqDemo

	Private Sub Sum_Click(sender As Object, e As RoutedEventArgs) Handles SumButton.Click
		Clear()
		Dim numbers = New List(Of Integer)({2, 4, 5, 6, 8, 20, 35, 50, 65, 89})
		Dim total As Integer = numbers.Sum
		Dim average As Double = numbers.Average
		Dim subsetAverage As Double = numbers.Take(4).Average

		OriginalList.Items.Add("Integers : 2, 4, 5, 6, 8, 20, 35, 50, 65, 89")
		OriginalList.Items.Add($"Total: {total}")
		OriginalList.Items.Add($"Average: {average}")
		OriginalList.Items.Add($"Average of four values: {subsetAverage}")
	End Sub




	Private Sub MaxButton_Click(sender As Object, e As RoutedEventArgs) Handles MaxButton.Click
		Clear()
		Dim doubleList = New List(Of Double)({3.3, 4.4, 1.1, 2.2, 5.5, 8.8, 9.9, 6.6, 7.7})

		Dim maxValue = doubleList.Max
		Dim lastNumber = doubleList.Last

		OriginalList.ItemsSource = doubleList
		ModifiedList.Items.Add($"Last number in list: {lastNumber}")
		ModifiedList.Items.Add($"Highest number in list: {maxValue}")
	End Sub

	Private Sub WhereButton_Click(sender As Object, e As RoutedEventArgs) Handles WhereButton.Click
		Clear()
		' where
		Dim integerList = Enumerable.Range(1, 300).ToList()

		Dim listOf25s = integerList.Where(Function(x) x Mod 25 = 0 Or x < 10)

		OriginalList.ItemsSource = integerList
		ModifiedList.ItemsSource = listOf25s
	End Sub

	Private Sub OrderByButton_Click(sender As Object, e As RoutedEventArgs) Handles OrderByButton.Click
		Clear()
		Dim words = New List(Of String)({"bb-1-bb", "zz-3-zz", "rr-6-rr", "aa-5-aa"})
		Dim numbers = New List(Of Integer)({12, 4, 25, 61, 82, 20, 35, 50, 65, 89})

		' default sort
		Dim orderedWords = words.OrderBy(Function(x) x)
		Dim orderedInts = numbers.OrderBy(Function(x) x)


		OriginalList.ItemsSource = words
		ModifiedList.ItemsSource = orderedWords
	End Sub
	Private Sub OrderByIntButton_Click(sender As Object, e As RoutedEventArgs) Handles OrderByIntButton.Click
		Clear()
		Dim numbers = New List(Of Integer)({12, 4, 25, 61, 82, 20, 35, 50, 65, 89})

		' default sort
		Dim orderedInts = numbers.OrderBy(Function(x) x)


		OriginalList.ItemsSource = numbers
		ModifiedList.ItemsSource = orderedInts
	End Sub
	Private Sub OrderByCustomButton_Click(sender As Object, e As RoutedEventArgs) Handles OrderByCustomButton.Click
		Clear()
		Dim words = New List(Of String)({"aa-5-aa", "bb-1-bb", "rr-6-rr", "zz-3-zz"})

		' default sor
		Dim orderedWords = words.OrderBy(Of String)(Function(x) x.Chars(3))


		OriginalList.ItemsSource = words
		ModifiedList.ItemsSource = orderedWords
	End Sub


	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		ModifiedList.ItemsSource = Nothing
		ModifiedList.Items.Clear()

		OriginalList.ItemsSource = Nothing
		OriginalList.Items.Clear()

	End Sub


End Class
