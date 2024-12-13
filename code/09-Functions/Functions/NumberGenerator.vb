Class NumberGenerator
	Public Function GetRandomOddNumber() As Integer
		Dim candidate As Integer = GetRandomNumber(201)

		Dim odd = MakeOddNumber(candidate)
		Return odd

	End Function

	Private Shared Function GetRandomNumber(maxValue As Integer) As Integer
		Dim ran = New Random
		Dim candidate As Integer
		candidate = ran.Next(maxValue)
		Return candidate
	End Function
	Private Function MakeOddNumber(candidate As Integer) As Integer
		If Integer.IsOddInteger(candidate) Then
			Return candidate
		Else
			Return candidate + 1
		End If

	End Function

	Public Function GetRandomEvenNumber() As Integer
		Dim candidate As Integer = GetRandomNumber(201)


		Dim even = MakeOddNumber(candidate) + 1
		Return even

	End Function
End Class


