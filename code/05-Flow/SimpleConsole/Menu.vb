Imports System.Diagnostics
Module Menu
	Private Sub Main()
		Dim currentChar As ConsoleKeyInfo
		Console.ForegroundColor = ConsoleColor.White
		Console.WriteLine("Select from the menu.")
		Console.ForegroundColor = ConsoleColor.Yellow
		Console.WriteLine("1. Current Day")
		Console.WriteLine("2. Current time.")
		Console.WriteLine("3. Suprise me.")
		Console.ResetColor()
		Console.WriteLine()

		Do

			currentChar = Console.ReadKey(intercept:=True)
			If currentChar.KeyChar = "1"c Then
				Console.WriteLine(DateTime.Now.DayOfWeek.ToString)
			End If
			If currentChar.KeyChar = "2"c Then
				Console.WriteLine(DateTime.Now.ToShortTimeString)
			End If
			If currentChar.KeyChar = "3"c Then
				Console.Write("Processor Count: ")
				Console.WriteLine(System.Environment.ProcessorCount)
			End If

		Loop While currentChar.KeyChar <> " "c
	End Sub
End Module
