Class NumberGenerator4
	' refactored
	' refactored
	Public Function GetRandomOddNumber() As Integer
		Dim candidate As Integer = GetRandomNumber(201)
		Return GetOddNumber(candidate)

	End Function
	Public Function GetRandomEvenNumber() As Integer
		Dim candidate As Integer = GetRandomNumber(201)

		Return GetOddNumber(candidate) + 1
	End Function

	Private Function GetOddNumber(candidate As Integer) As Integer
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
