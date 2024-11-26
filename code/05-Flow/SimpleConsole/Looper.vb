Imports System.Threading
Module Looper
	Private Sub Main()

		Dim currentChar

		Do

			currentChar = Console.ReadKey.KeyChar
			Console.Write(".....")
			For index = 1 To 30
				Console.Write(currentChar)
			Next
			Console.WriteLine(".....")


		Loop While currentChar <> " "c

	End Sub
End Module
