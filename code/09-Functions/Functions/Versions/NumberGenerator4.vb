Namespace V4
	Class NumberGenerator

		' single reponsibility principle
		' a function should focus on a single task
		' be easy to understand, anyone reading the code can understand what it does

		' TASKS

		' Get a random number
		' Make a number odd
		' MAYBE
		' Get an random odd number
		' Get an random even number

		Public Function GetRandomOddNumber(maxValue As Integer) As Integer
			Dim candidate As Integer = GetRandomNumber(maxValue)
			Return MakeOddNumber(candidate)

		End Function
		Public Function GetRandomEvenNumber(maxValue As Integer) As Integer
			Dim candidate As Integer = GetRandomNumber(maxValue)

			Return MakeOddNumber(candidate) + 1
		End Function

		Private Function MakeOddNumber(candidate As Integer) As Integer
			If Integer.IsOddInteger(candidate) Then
				Return candidate
			Else
				Return candidate + 1
			End If

		End Function

		Private Function GetRandomNumber(maxValue As Integer) As Integer
			Dim ran = New Random
			Dim candidate As Integer = ran.Next(maxValue:=maxValue)
			Return candidate
		End Function
	End Class
End Namespace

