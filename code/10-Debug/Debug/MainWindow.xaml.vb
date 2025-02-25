﻿Imports System.IO

Class MainWindow

	Private Sub RunCode1(sender As Object, e As RoutedEventArgs) Handles BreakButton.Click
		Dim computerName As String
		computerName = "Webserver14"
		Dim outputText = "The current computer name is " + computerName
		ShowIt(outputText)

	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles AnotherButton.Click
		Dim x As Double
		x = 6
		' breakpoints cannot be set on comments
		' Or other non-runnable lines
		Dim y As Double = 7
		Dim result As String
		Dim fraction As Double = x / 5
		result = $"Your answer is {fraction}"

	End Sub

	Private Sub RunCode3(sender As Object, e As RoutedEventArgs) Handles StepButton.Click
		Dim odd As Integer
		Dim gen As New NumberGenerator

		odd = gen.GetRandomOddNumber(201)
		ShowIt(odd)

	End Sub



	Private Sub RunCode4(sender As Object, e As RoutedEventArgs) Handles WatchButton.Click
		Dim odd As Integer
		Dim gen As New NumberGenerator

		odd = gen.GetRandomOddNumber(201)
		CodeForWatchExample()

	End Sub

	Sub CodeForWatchExample()
		Dim sentence As String = "One word after another."
		Dim taxRate As Double = 7.8
		Dim birthDate = Date.Parse("5/5/1992")
		' use a directory that is on you hard drive
		Dim sampleDir = New DirectoryInfo("c:\VBTemp")
	End Sub

#Region "Show methods"


	Sub ShowIt(message As String)
		Dim bulletText As New Run("» ")
		MessageOut.Inlines.Add(bulletText)
		bulletText.Foreground = Brushes.SteelBlue
		Dim normalText As New Run(message + vbCrLf)
		MessageOut.Inlines.Add(message + vbCrLf)
	End Sub
	Sub ShowBlankLine()
		Dim lineText As New Run("" + vbCrLf)
		MessageOut.Inlines.Add(lineText)
	End Sub
	Sub ShowHeader(message As String)
		Dim boldText As New Run(message + vbCrLf)
		boldText.FontWeight = FontWeights.Bold
		MessageOut.Inlines.Add(boldText)

	End Sub
	Sub Clear()
		MessageOut.Text = ""
	End Sub

	Sub ShowLine()
		Dim lineText As New Run(New String("-"c, 68) + vbCrLf)
		lineText.Foreground = Brushes.LightBlue
		MessageOut.Inlines.Add(lineText)
	End Sub


#End Region


End Class
