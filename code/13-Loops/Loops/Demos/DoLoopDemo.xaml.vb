﻿Public Class DoLoopDemo
	Dim parentWin As MainWindow
	Private Async Sub ButtonA_Click(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		parentWin.ClearIt()
		Dim engineStatus As Integer
		parentWin.ShowItTopDown(engineStatus.ToString("D3"))

#Region "Finished Code"

		'parentWin.ClearIt()
		'Dim engineStatus As Integer
		'Do
		'	engineStatus = Await GetEngineStatus()
		'	parentWin.ShowItTopDown(engineStatus.ToString("D3"))
		'Loop While engineStatus >= 0
#End Region

	End Sub

	Public Sub EndLessLoop()
		Do

		Loop While True
		'--------------

		Do

		Loop Until True
		'--------------

		Do While True

		Loop
		'--------------

		Do Until True

		Loop
		'--------------

		While True
			' similar to Do loop
			' only tests at beginning of loop
		End While

	End Sub

	Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)

		parentWin = Window.GetWindow(Me)

	End Sub

	Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		parentWin.ClearIt()
	End Sub
End Class
