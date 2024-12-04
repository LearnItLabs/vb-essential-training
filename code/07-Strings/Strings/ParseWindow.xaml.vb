Option Strict Off
Public Class ParseWindow
	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim myInteger As Integer
		Dim myDouble As Double

		' code here

		ShowHeader("Integer")
		ShowIt(myInteger.ToString())
		ShowHeader("Double")
		ShowIt(myDouble.ToString())

		ShowBlankLine()

	End Sub

	Private Sub ButtonB_Click(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click

		Dim myDouble As Double

		' code here
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


End Class