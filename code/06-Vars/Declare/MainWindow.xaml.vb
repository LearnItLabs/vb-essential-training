﻿Imports System.Runtime.CompilerServices

Class MainWindow
	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		' Declare with identifier, type and initializer 
		Dim counter As Integer = 22
		Dim taxRate As Double = 9.75

		' Declare with identifier and initializer
		Dim counter2 = 33
		Dim isFileReadOnly = False

		'  Declare with identifier
		Dim counter3
		' assign a value before using
		counter3 = 44

		' declare variable of any .NET type that has a constructor
		'  use the New keyword
		Dim simpleBrush As SolidColorBrush = New SolidColorBrush
		Dim backBrush = New SolidColorBrush() ' see color button for example

#Region "Output"
		ShowIt(counter, NameOf(counter), counter.GetType().Name)
		ShowIt(taxRate, NameOf(taxRate), taxRate.GetType().Name)
		ShowIt(counter2, NameOf(counter2), counter2.GetType().Name)
		ShowIt(isFileReadOnly, NameOf(isFileReadOnly), isFileReadOnly.GetType().Name)
		ShowIt(counter3, NameOf(counter3), counter3.GetType().Name)
#End Region
	End Sub

	Private Sub ValidIdButton_Click(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click
		' Variable name rules
		' It must begin with an alphabetic character or an underscore (_).
		' It must only contain alphabetic characters, decimal digits, and underscores.
		' It must contain at least one alphabetic character Or decimal digit if it begins with an underscore.
		'	It must not be more than 1023 characters long.

		Dim _counter As Integer
		Dim counter As Long
		Dim base3Counter As Long
		Dim widget_counter As Short

		'Dim 5counter As Short ' not a valid name


		' suggested naming convention for "local variable" is camel case 
		' (lower case first letter, capitalize rest of words)

		Dim thisIsAGoodName As String = ""
		Dim lowercasename As String = ""
		Dim UPPERCASENAME As String = ""

		' VB compiler doesn't care about case.
		' VB editor matches the initial identifier

		thisIsAGoodName = "hello"
		lowercasename = "David"

#Region "Output"
		ShowIt(_counter)
		ShowIt(counter)
		ShowIt(base3Counter)
		ShowIt(widget_counter)
		ShowIt(thisIsAGoodName)
		ShowIt(lowercasename)
		ShowIt(UPPERCASENAME)
#End Region


	End Sub



	Private Sub ChangeColorButton_Click(sender As Object, e As RoutedEventArgs) Handles RunCode3Button.Click
		Dim backBrush As New SolidColorBrush
		backBrush.Color = Colors.Orange
		MainPanel.Background = backBrush
	End Sub
	Sub ShowIt(message As String, variableName As String, typeName As String)
		Dim paddedMessage = $"variable name: {variableName} is of type {typeName}.  Value = {message}"
		MessageTextBox.Text += paddedMessage + vbCrLf
	End Sub
	Sub ShowIt(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
		Dim backBrush As New SolidColorBrush
		backBrush.Color = Colors.LightSteelBlue
		MainPanel.Background = backBrush
	End Sub


End Class
