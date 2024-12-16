Public Class PredicateDemo

	' A predicate function is a function that returns a Boolean value,
	' typically used for filtering collections.
	' A standalone function
	Public Function IsMultipleOf5(number As Integer) As Boolean
		Return number Mod 5 = 0
	End Function

	Private Sub BasicsButton_Click(sender As Object, e As RoutedEventArgs) Handles BasicsButton.Click
		Dim gen As New NumberGenerator
		' how to use a standalone predicate
		Dim odds = gen.GetListOfRandomOddNumbers(listCount:=120, maxValue:=601)
		Dim filtered As List(Of Integer)


		filtered = odds.FindAll(AddressOf IsMultipleOf5)
		OriginalList.ItemsSource = odds
		ModifiedList.ItemsSource = filtered
	End Sub
	Private Sub InLineButton_Click(sender As Object, e As RoutedEventArgs) Handles InLineButton.Click
		' Now, let's rewrite the IsMultipleOf5 predicate function as a lambda expression.
		' A lambda expression is an anonymous function that you can use wherever a delegate is required.
		Dim gen As New NumberGenerator
		Dim odds = gen.GetListOfRandomOddNumbers(listCount:=120, maxValue:=601)

		Dim filtered As New List(Of Integer)


		filtered = odds.FindAll(Function(number) number Mod 5 = 0)
		'filtered = odds.FindAll(Function(x) x > 50 And x < 100)
		OriginalList.ItemsSource = odds
		ModifiedList.ItemsSource = filtered


	End Sub
	Private Sub RemoveAButton_Click(sender As Object, e As RoutedEventArgs) Handles RemoveAButton.Click
		Dim gen As New NumberGenerator
		Dim odds = gen.GetListOfRandomOddNumbers(listCount:=30, maxValue:=601)
		' Create a filtered version of the original list
		Dim oddCopy As New List(Of Integer)(odds)

		Dim removeCount = odds.RemoveAll(Function(x) x > 50)
		Dim filtered As New List(Of Integer)
		OriginalList.ItemsSource = oddCopy
		ModifiedList.ItemsSource = odds

	End Sub

	Private Sub RemoveButton_Click(sender As Object, e As RoutedEventArgs) Handles RemoveBButton.Click
		' remove items from the list

		Dim brandColors = New BrandColors()
		Dim colorNames = brandColors.ColorNames
		' Create a filtered version of the original list
		Dim filtered = colorNames.FindAll(Function(x) x.StartsWith("S"))

		OriginalList.ItemsSource = colorNames
		ModifiedList.ItemsSource = filtered

	End Sub
	Private Sub Clear()
		ModifiedList.ItemsSource = Nothing
		ModifiedList.Items.Clear()

		OriginalList.ItemsSource = Nothing
		OriginalList.Items.Clear()

	End Sub

	Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub


End Class
