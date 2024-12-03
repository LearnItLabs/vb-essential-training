Imports System.Text
Imports System.Windows.Threading

Public Class StringBuilderWindow
	Const maxLoops As Integer = 4000
	Private Sub ButtonA_Click(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		' Create a new StringBuilder instance
		Dim builder As New StringBuilder
		builder.Append("apricot ") '<
		builder.Append("banana ")  '<
		builder.Append("apricot ") '<
		ShowHeader("Append")
		ShowIt(builder.ToString)   '<

		builder.Replace("apricot", "cherry") '<
		ShowHeader("Replace")
		ShowIt(builder.ToString)

		ShowHeader("Insert")
		builder.Insert(6, " durian") '<
		ShowIt(builder.ToString)
		' insert other types
		builder.Append(345.67D)      '<
		builder.Append("elderberry")
		ShowHeader("More Inserts")
		ShowIt(builder.ToString)

		builder.Remove(4, 13)        '<
		ShowHeader("Remove")
		ShowIt(builder.ToString)

		builder.Clear()
		builder.Append("Starting fresh!")

		ShowHeader("Clear contents")
		ShowIt(builder.ToString)

	End Sub

	Private Sub ButtonB_Click(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Dim bigString As String = String.Empty
		Dim startTime As DateTime = DateTime.Now

		For counter As Integer = maxLoops To 1 Step -1

			bigString &= $"{counter} Concatenation example" & Constants.vbCrLf

		Next counter

		Me.MessageOut.Text = bigString
		ConcatTextBox.Text = DateTime.Now.Subtract(startTime).TotalMilliseconds.ToString("N")

	End Sub


	Private Sub ButtonD_Click(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click
		' use the StringBuilder class
		Dim startTime As DateTime = DateTime.Now
		Dim builder As New Text.StringBuilder()

		For counter As Integer = maxLoops To 1 Step -1
			builder.Append($"{counter} String Builder example" & Constants.vbCrLf)

		Next counter
		builder.Replace("example", "demo")
		Me.OtherMessageOut.Text = builder.ToString()
		BuilderTextbox.Text = DateTime.Now.Subtract(startTime).TotalMilliseconds.ToString("N")
	End Sub

	Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Me.MessageOut.Text = ""
		Me.OtherMessageOut.Text = ""
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
