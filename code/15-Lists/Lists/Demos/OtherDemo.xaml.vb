Public Class OtherDemo

	Private _ran As Random = New Random
	Private _sortedSet As SortedSet(Of Double) = New SortedSet(Of Double)
	Private _queueOfInts As Queue(Of Integer) = New Queue(Of Integer)
	Dim _productPrices As New Dictionary(Of String, Decimal)()

	Private Sub SortedSetDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		_sortedSet = New SortedSet(Of Double)({3.3, 1.1, 4.4, 2.2, 5.5, 9.9, 8.8, 7.7, 6.6})
		OriginalList.ItemsSource = _sortedSet

	End Sub

	Private Sub AddDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Clear()
		Dim newDouble = _ran.NextDouble() * 10
		newDouble = Math.Round(newDouble, 2)
		_sortedSet.Add(newDouble)

		OriginalList.ItemsSource = _sortedSet

	End Sub

	Private Sub AddFiveDemo(sender As Object, e As RoutedEventArgs) Handles QueueButton.Click
		ClearOriginal()

		' Generate a sequence of numbers from 1 to 18 using Enumerable.Range
		'' Dim numberSequence As IEnumerable(Of Integer) = Enumerable.Range(1, 18)

		' Initialize a Queue and fill it with the generated numbers
		' _queueOfInts = New Queue(Of Integer)(numberSequence)
		'For Each number In numberSequence

		_queueOfInts.Enqueue(DateTime.Now.Millisecond)
		'Next

		OriginalList.ItemsSource = _queueOfInts
	End Sub

	Private Sub DequeueDemo(sender As Object, e As RoutedEventArgs) Handles DequeueButton.Click
		ClearOriginal()
		If _queueOfInts.Count > 0 Then
			ModifiedList.Items.Add(_queueOfInts.Dequeue)
		Else
			ModifiedList.Items.Add("Queue is empty")
		End If


		OriginalList.ItemsSource = _queueOfInts

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
	Private Sub ClearOriginal()


		OriginalList.ItemsSource = Nothing
		OriginalList.Items.Clear()

	End Sub

	Private Sub AddDictionaryButton_Click(sender As Object, e As RoutedEventArgs) Handles AddDictionaryButton.Click
		ClearOriginal()
		_productPrices.Add("Daisy Drill", 999.99D)
		_productPrices.Add("Hari Hammer", 699.99D)
		_productPrices.Add("Rina Ratchet", 399.99D)
		OriginalList.ItemsSource = _productPrices

	End Sub

	Private Sub RemoveDictionaryButton_Click(sender As Object, e As RoutedEventArgs) Handles GetDictionaryButton.Click
		Dim myKey = "Hari Hammer"
		If _productPrices.ContainsKey(myKey) Then
			' get value associate with key
			Dim price As Decimal = _productPrices.Item(myKey)
			ModifiedList.Items.Add($"Product: {myKey}, {price.ToString("C")}")
			'	Console.WriteLine("Price of " & Key & ": $" & productPrices(productName))
		Else
			ModifiedList.Items.Add($"{myKey} is not in the dictionary.")
		End If
	End Sub

#Region "Finished Code"

#End Region

End Class
