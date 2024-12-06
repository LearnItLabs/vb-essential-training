Option Strict On
Imports System.Globalization

Public Class ParseWindow
	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim myInteger As Integer
		Dim myDouble As Double

		'' code here
		'myInteger = InputTextBox.Text
		'myDouble = InputTextBox.Text

		ShowHeader("Integer")
		ShowIt(myInteger.ToString())
		ShowHeader("Double")
		ShowIt(myDouble.ToString())

		ShowBlankLine()

	End Sub

	Private Sub ButtonB_Click(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Dim myInteger As Integer
		Dim myDouble As Double
		Dim didParse As Boolean
		' code here
		'myInteger = Integer.Parse(InputTextBox.Text)

		didParse = Integer.TryParse(InputTextBox.Text, myInteger)
		'didParse = Integer.TryParse(InputTextBox.Text, NumberStyles.AllowThousands Or NumberStyles.Currency, Nothing, myInteger)

		If didParse Then
			ShowHeader("Integer")
			ShowIt(myInteger.ToString())
		Else
			ShowHeader("Error")
			ShowIt("Cannot parse to Integer. Try again")
		End If

		didParse = Double.TryParse(InputTextBox.Text, myDouble)
		If didParse Then
			ShowHeader("Double")
			ShowIt(myDouble.ToString())
		Else
			ShowHeader("Error")
			ShowIt("Cannot parse to Double. Try again")
		End If

		'ShowHeader("Double")
		'ShowIt(myDouble.ToString())

		'ShowHeader("Error")
		'ShowIt("Cannot parse. Try again")
		ShowBlankLine()
	End Sub

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

	Sub ShowLine()
		Dim lineText As New Run(New String("-"c, 68) + vbCrLf)
		lineText.Foreground = Brushes.LightBlue
		MessageOut.Inlines.Add(lineText)
	End Sub
	Sub Clear()
		MessageOut.Text = ""
	End Sub

	Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub ButtonA_Click(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click

	End Sub
End Class