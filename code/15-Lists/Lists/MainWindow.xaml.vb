Class MainWindow
	'Public Sub ShowItTopDown(message As String)

	'	Dim normalText As New Run(message + ", ")
	'	If MessageOut.Inlines.Count = 0 Then
	'		MessageOut.Inlines.Add(normalText)
	'	Else
	'		MessageOut.Inlines.InsertBefore(MessageOut.Inlines.FirstInline, normalText)
	'		'Dim bulletText As New Run("» ")
	'		'MessageOut.Inlines.InsertBefore(MessageOut.Inlines.FirstInline, bulletText)
	'		'bulletText.Foreground = Brushes.SteelBlue
	'	End If


	'End Sub
	'Public Sub ShowIt(message As String)
	'	Dim bulletText As New Run("» ")
	'	MessageOut.Inlines.Add(bulletText)
	'	bulletText.Foreground = Brushes.SteelBlue
	'	Dim normalText As New Run(message + vbCrLf)
	'	MessageOut.Inlines.Add(message + vbCrLf)
	'End Sub
	'Public Sub ShowItSimple(message As String)

	'	MessageOut.Text &= message

	'End Sub
	'Public Sub ShowBlankLine()
	'	Dim lineText As New Run("" + vbCrLf)
	'	MessageOut.Inlines.Add(lineText)
	'End Sub
	'Public Sub ShowHeader(message As String)
	'	Dim boldText As New Run(message + vbCrLf)
	'	boldText.FontWeight = FontWeights.Bold
	'	MessageOut.Inlines.Add(boldText)

	'End Sub
	'Sub ClearIt()
	'	MessageOut.Text = ""
	'End Sub
End Class
