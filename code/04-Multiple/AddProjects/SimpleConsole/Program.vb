Imports System

Public Class Program
	Sub Main(args As String())

		Console.Write("Today is ...")
		Console.ForegroundColor = ConsoleColor.Yellow
		Console.WriteLine(DateTime.Now.DayOfWeek.ToString)
		Console.ResetColor()
		Console.ReadLine()


	End Sub
End Class
