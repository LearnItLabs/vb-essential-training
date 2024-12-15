Public Class CreateDemo


	Private Sub CreateNew(sender As Object, e As RoutedEventArgs) Handles CreateButton.Click

#Region "Finished Code"
		'Dim colorNamesArray(20) As String
		'Dim oddNumbersArray(10) As Integer

		' Dim colorNamesList As New List(Of String)
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


End Class
