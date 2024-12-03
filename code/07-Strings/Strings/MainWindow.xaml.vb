Option Strict Off
Imports System.Globalization
Imports System.Runtime.Intrinsics.X86

Partial Class MainWindow

	Private Sub CreateString_Click(sender As Object, e As RoutedEventArgs) Handles ButtonA.Click
		Dim direction = "East"
		Dim otherDirection As String = "West"
		Dim message As String = $"This string can have embedded tokens."

		' A string is an array of Unicode chars
		ShowHeader("Get Char")
		Dim myChar As Char = "%"c
		ShowIt(myChar)

		Dim firstChar = direction(0)
		ShowIt(firstChar)
		ShowLine()

		' use the constructor to build a string
		Dim line = New String("☼"c, 23)
		ShowHeader("Use constructor")
		ShowIt(direction)
		ShowIt(message)
		ShowIt(line)
		ShowLine()
		' To include double quotes within a string by doubling them up.

		Dim famousQuote = "Grabbing a paintbrush, she said, ""Imagination is more important than knowledge."" and quickly painted the small canvas."
		ShowHeader("Quotes within a string")
		ShowIt(famousQuote)




	End Sub

	Private Sub Concatenate_Click(sender As Object, e As RoutedEventArgs) Handles ButtonB.Click
		Dim teamA = TeamATextBox.Text
		Dim teamB = TeamBTextBox.Text
		' Concatenation is the process of joining two or more strings together.
		Dim message = "Don't miss this match between top-ranked (" + teamA + ") and long-time rivals (" & teamB & ")."
		ShowHeader("Concatenate")
		ShowIt(message)

		' string.format
		message = String.Format("Meet the teams: ({0}) and long-time rivals ({1}).", teamA, teamB)
		ShowHeader("String.Format")
		ShowIt(message)
		' Interpolated strings 
		' Interpolation in programming typically refers to the process of inserting values into a string.
		' This makes it easier to construct strings that include variable values without resorting to cumbersome concatenation. 
		message = $"Autographs and selfies with: ({teamA}) and long-time rivals ({teamB})."

		ShowHeader("Interpolated")
		ShowIt(message)

		' See the split/join example for another way to build a string from an array.

	End Sub

	Private Sub Search_Click(sender As Object, e As RoutedEventArgs) Handles ButtonD.Click
		Dim message = "Personalize your training experience with the skills you need."
		ShowIt(message)
		' verify if a sub string is available

		Dim periodExists = message.EndsWith(".")
		Dim wordExists = message.StartsWith("Hello")
		ShowHeader("EndsWith, StartsWith")
		ShowIt($"Period exists: {periodExists}")
		ShowIt($"Starts with word: {wordExists}")
		ShowLine()
		' finding by index
		' return -1 if not found, otherwise the index location
		Dim searchWord = SearchWordTextbox.Text
		ShowHeader("Use Contains method")
		ShowIt($"'{searchWord}' Exists: {message.Contains(searchWord)}")
		Dim wordIndex As Integer = message.IndexOf(searchWord)
		ShowHeader("Use IndexOf method")
		ShowIt($"Word Index for '{searchWord}': {wordIndex}")


	End Sub
	Private Sub Modify_Click(sender As Object, e As RoutedEventArgs) Handles ButtonE.Click

		Dim lettersWithSpaces = "  AA  "
		Dim trimmed = lettersWithSpaces.Trim(" ")

		'  trim these chars
		Dim charsToTrim = New Char() {","c, "."c, " "c, "!"c}
		Dim message = "A synonym for cinnamon, is a cinnamon synonym!!!"

		trimmed = message.TrimEnd(charsToTrim)
		ShowHeader("Trim")
		ShowIt(message)
		ShowIt(trimmed)
		ShowLine()

		Dim upper = message.ToUpper()
		Dim lower = message.ToLower()
		ShowHeader("ToUpper and ToLower")

		ShowIt(upper)
		ShowIt(lower)
		ShowLine()

		Dim replaced = message.Replace("cinnamon", "cardamom")
		ShowHeader("Replace")
		ShowIt(message)
		ShowIt(replaced)

	End Sub

	Private Sub Split_click(sender As Object, e As RoutedEventArgs) Handles ButtonF.Click
		Dim message = "Personalize your training experience with the skills you need."
		Dim words = message.Split(" "c)
		ShowIt(message)

		ShowHeader("Split into array")
		For Each word In words
			ShowIt(word)
		Next
		ShowLine()


	End Sub



	Sub ShowIt(message As String)
		Dim bulletText As New Run("» ")
		MessageTextBox.Inlines.Add(bulletText)
		bulletText.Foreground = Brushes.SteelBlue
		Dim normalText As New Run(message + vbCrLf)
		MessageTextBox.Inlines.Add(message + vbCrLf)
	End Sub
	Sub ShowBlankLine()
		Dim lineText As New Run("" + vbCrLf)
		MessageTextBox.Inlines.Add(lineText)
	End Sub
	Sub ShowHeader(message As String)
		Dim boldText As New Run(message + vbCrLf)
		boldText.FontWeight = FontWeights.Bold
		MessageTextBox.Inlines.Add(boldText)

	End Sub


	Sub ShowLine()
		Dim lineText As New Run(New String("-"c, 68) + vbCrLf)
		lineText.Foreground = Brushes.LightBlue
		MessageTextBox.Inlines.Add(lineText)
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		Clear()
	End Sub

	Private Sub Clear()
		MessageTextBox.Text = ""
	End Sub

	Private Sub ButtonC_Click(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
		Dim fruits As String() = {"banana", "cherry", "durian", "elderberry"}
		ShowIt(fruits(2))
		Dim joinedWords = String.Join("~", fruits)
		ShowHeader("Joined")
		ShowIt(joinedWords)

		joinedWords = String.Join(", ", fruits)
		ShowIt(joinedWords)
	End Sub



	'Private Sub Chars_Click(sender As Object, e As RoutedEventArgs) Handles ButtonC.Click
	'	' use indexer to get a char from string
	'	Dim message = "Now is a good time to learn .NET."
	'	Dim ninthChar = message(9)
	'	OutputToScreen(message)
	'	OutputToScreen(ninthChar)
	'End Sub

	' use IndexOfAny to search for multiple candidates
	' search stops as soon as first match is found
	' Dim invalidCharsFound As Integer = message.IndexOfAny(New Char() {"!"c, "@"c, "#"c, "$"c})
End Class