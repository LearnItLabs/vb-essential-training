Imports System.Diagnostics.Metrics

Public Class ForLoopDemo
	Dim parentWin As MainWindow
	Private Sub ForDemo(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		'	parentWin.ShowIt(index.ToString("D2"))


#Region "Finished Code"
		'parentWin.ShowHeader("For Loop")
		'For index = 1 To 10

		'	parentWin.ShowIt(index.ToString("D2"))
		'Next

#End Region

	End Sub

	Private Sub StepDemo(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

#Region "Finished Code"
		'parentWin.ShowHeader("For Loop, with step")
		'For counter = 21 To 200 Step 5
		'	parentWin.ShowIt(counter.ToString("D3"))
		'Next
#End Region

	End Sub

	Private Sub DownDemo(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
#Region "Finished Code"
		'parentWin.ShowHeader("For Loop, step  - 5")
		'For index = 100 To 50 Step -5
		'	parentWin.ShowIt(index.ToString("D3"))

		'Next
#End Region

	End Sub

	Private Sub ButtonD_Click(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click
		' variables  can be use for the loop values.
		For index = StartSlider.Value To EndSlider.Value Step StepSlider.Value
			parentWin.ShowIt(index)
		Next

	End Sub

	Private Sub NestedDraw1(sender As Object, e As RoutedEventArgs) Handles ButtonF.Click

		ClearPoints()
		For x = 100 To 400 Step 30
			For y = 360 To 480 Step 20
				Dim point As New Point(x, y)
				polyline1.Points.Add(point)
			Next
		Next
	End Sub

	Private Sub NestedDraw2(sender As Object, e As RoutedEventArgs) Handles ButtonG.Click
		ClearPoints()
		Dim ran = New Random
		Dim xStep = ran.Next(30, 85)
		Dim yStep = ran.Next(40, 85)
		Dim xStartPos = ran.Next(200, 450)
		Dim yStartPos = ran.Next(100, 357)

		For x = xStartPos To 750 Step xStep
			For y = yStartPos To 480 Step yStep
				'	Dim point As New Point(x + ran.Next(4, 20), y + randomStep)
				Dim point As New Point(x, y + (60 * Math.Sin(x)))
				polyline2.Points.Add(point)
			Next
		Next
	End Sub


	Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
		parentWin = Window.GetWindow(Me)


	End Sub




	Private Sub ButtonClear2_Click(sender As Object, e As RoutedEventArgs) Handles ButtonClear2.Click
		parentWin.ClearIt()
	End Sub

	Private Sub ButtonClear3_Click(sender As Object, e As RoutedEventArgs) Handles ButtonClear3.Click
		ClearPoints()
	End Sub

	Private Sub ClearPoints()
		polyline1.Points.Clear()
		polyline2.Points.Clear()
	End Sub
End Class
