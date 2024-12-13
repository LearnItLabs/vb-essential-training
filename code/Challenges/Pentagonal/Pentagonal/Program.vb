Imports System

Module Program
	Sub Main()
		Do
			Console.ResetColor()
			Dim ringCount = Console.ReadLine()

			Dim totalDots = PentagonalDotCounter(numberOfRings:=ringCount)
			' Dim totalDots = GeneralizedDotCounter(numberOfRings:=ringCount, dimensions:=4)
			Console.ForegroundColor = ConsoleColor.Yellow
			Console.WriteLine($"Ring Count: {ringCount}, Total Dots: {totalDots}")
		Loop While True

	End Sub

	Private Function PentagonalDotCounter(numberOfRings As Integer)
		' 1 + 5 + 10 + 15 + 20
		' 1 + (5 * 1) + (5 * 2) ... + (5 * n) 
		Dim total = 1
		For counter = numberOfRings - 1 To 1 Step -1
			total += counter * 5
		Next
		Return total

	End Function
	Private Function GeneralizedDotCounter(numberOfRings As Integer, Optional dimensions As Integer = 5) As Integer
		Dim total = 1
		For counter = numberOfRings - 1 To 1 Step -1
			total += counter * dimensions
		Next
		Return total

	End Function
End Module
