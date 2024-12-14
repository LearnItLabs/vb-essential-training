Public Class CreateDemo


	Private Sub NewDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

#Region "Finished Code"
		'Dim colorNamesArray(20) As String
		'Dim oddNumbersArray(10) As Integer

		'Dim colorNamesList As New List(Of String)
		'Dim oddNumbersList = New List(Of Integer)

		'colorNamesArray(3) = "Blue"

		'ReDim colorNamesArray(30)
#End Region

	End Sub



	Dim parentWin As MainWindow
	Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)

		parentWin = Window.GetWindow(Me)

	End Sub
End Class
