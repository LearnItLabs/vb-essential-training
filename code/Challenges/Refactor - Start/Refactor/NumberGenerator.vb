Public Class NumberGenerator


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
