Public Class ExtensionDemo
	Private Sub CustomButton_Click(sender As Object, e As RoutedEventArgs) Handles CustomButton.Click

		Dim courseTitle As String = "visual basic essential training"
		Dim fixedCourseTitle As String

		fixedCourseTitle = courseTitle.ToTitleCase

		OriginalList.Items.Add(courseTitle)
		OriginalList.Items.Add(fixedCourseTitle)
	End Sub

	Private Sub EnumerableButton_Click(sender As Object, e As RoutedEventArgs) Handles EnumerableButton.Click
		' LINQ offers powerful tools for querying data collections.
		' The Enumerable class serves as a core class for performing LINQ query operations.

		' It has a couple Shared methods
		' Empty is a lightweight, static method that does not allocate memory for new objects,
		' making it more efficient compared to creating a new empty list or array.
		Dim empty = Enumerable.Empty(Of Decimal)

		Dim numbers = Enumerable.Range(start:=20, count:=300).ToList()
		Dim repeated As List(Of String) = Enumerable.Repeat("Hello, ", 12).ToList



	End Sub
	Public Function GetProducts() As List(Of Product)
		Dim gen As New NumberGenerator
		Dim productsAvailable As Boolean
		If Not productsAvailable Then
			Return Enumerable.Empty(Of Product)()
		End If

		' Return actual product list when available
		Return gen.GetDailyProductSales
	End Function

	Private Sub ExtensionButton_Click(sender As Object, e As RoutedEventArgs) Handles ExtensionButton.Click
		' use the Enumerable extension methods with any class
		' that implements the IEnumerable or IEnumerable (Of T) interface
		Dim compassPoints As New List(Of String)({"North", "East", "South", "West"})
		Dim smallNumbers = New List(Of Double)({3.3, 4.4, 1.1, 2.2, 5.5, 8.8, 9.9, 6.6, 7.7})

		' List(Of T) implements a set of methods
		' Add, AddRange, Clear, Contains, Exists, Find, IndexOf
		' Insert, Remove, Sort, TrueForAll

		' Enumerable extension methods
		'  All, Any, Append, Average, Count
		' Distinct, Exists, Find, First, Last, etc.

		' similar functions 
		' Add (List) and Append (Enumerable)
		' Contains (List) and Contains (Enumerable)
		' Count (List) and Count (Enumerable)
		' FindAll (List) and Where (Enumerable)
		' IndexOf (List) and Select (Enumerable)
		' Sort (List) and OrderBy/OrderByDescending (Enumerable)

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
