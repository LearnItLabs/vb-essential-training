Public Class AddDemo

	' this demo uses the debugger 
	Private Sub InitializeList(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click

		Dim colorNames As New List(Of String)
		Dim colorNames2 = New List(Of String)

	End Sub

	Private Sub ListOfStringsDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

		Dim colorNames As New List(Of String)




	End Sub
	Private Sub ListOfIntegersDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Dim gen As New NumberGenerator
		Dim oddNumbers = New List(Of Integer)
		For index = 1 To 30
			oddNumbers.Add(gen.GetRandomOddNumberOld(201))

		Next

	End Sub

	Private Sub List2Button_Click(sender As Object, e As RoutedEventArgs) Handles List2Button.Click
		' have the NumberGenerator class return a List(of T)
		Dim gen As New NumberGenerator
		Dim oddNumbers = New List(Of Integer)
		oddNumbers = gen.GetRandomOddNumber(305)

	End Sub

#Region "Finished Code"

#End Region
	Dim parentWin As MainWindow
	Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)

		parentWin = Window.GetWindow(Me)

	End Sub


End Class
