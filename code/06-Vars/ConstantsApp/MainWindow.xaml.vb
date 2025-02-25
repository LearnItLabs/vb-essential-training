﻿Option Strict Off
Class MainWindow
	Public Const DocFileExtension As String = ".paper"

	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		' constants are usually declared at the module or class level

		Const StandardCommisionRate As Decimal = 4.5D
		Const EPIC_COMMISION_RATE As Byte = 7.75D
		ShowIt(DocFileExtension)
		ShowIt(StandardCommisionRate)
		ShowIt(EPIC_COMMISION_RATE)
	End Sub

	Private Sub BuiltInButton_Click(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click

		' Constants are members of some .NET classes.

		Dim circumference As Double
		Dim diameter As Double = 4
		circumference = Math.PI * diameter


		' VB language has some legacy constants that start with "vb"
		' They are defined in the built-in Constants module
		Dim null = Constants.vbNull

		Dim result = MsgBox("Hello") ' the old VB message box!
		If result = vbCancel Then
			' If maintaining legacy VB code, using the VB constants
			' can still be useful for consistency and simplicity.
		End If

		If result = Constants.vbOK Then
			' If maintaining legacy VB code, using the VB constants
			' can still be useful for consistency and simplicity.
		End If

	End Sub
	Sub ShowIt(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub

	Private Sub EnumButton_Click(sender As Object, e As RoutedEventArgs) Handles EnumButton.Click
		Dim currentDay As DayOfWeek 'Represents the days of the week.
		currentDay = DayOfWeek.Sunday
		' currentDay = 24 ' this should not be allowed!

		' Specifies constants that define foreground and background colors for the console.
		Dim color As ConsoleColor
		color = ConsoleColor.Yellow

		' Get directory paths to system special folders.
		Dim currentFolder As Environment.SpecialFolder
		currentFolder = Environment.SpecialFolder.Favorites

	End Sub

	Private Sub EnumButton2_Click(sender As Object, e As RoutedEventArgs) Handles EnumButton2.Click
		Dim currentSeason As Seasons
		currentSeason = Seasons.Spring

		If currentSeason = Seasons.Summer Then
			ShowIt("Forecast of warm sunny days...")
		End If
	End Sub
End Class
