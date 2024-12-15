Public Class NumberGenerator

	Public Function GetRandomOddNumberOld(maxValue As Integer) As Integer
		Dim candidate As Integer = GetRandomNumber(maxValue)
		Return GetOddNumber(candidate)

	End Function

	Public Function GetDailySales() As Decimal()
		' this function returns an array
		'
		Dim temp(5) As Decimal
		temp(0) = 77.6D
		temp(0) = 124.32D
		temp(0) = 9.48D
		temp(0) = 73.81D
		temp(0) = 40D
		Return temp

	End Function

	Public Function GetListOfRandomOddNumbers(listCount As Integer, maxValue As Integer) As List(Of Integer)
		Dim oddNumbers = New List(Of Integer)
		Dim candidate As Integer
		For index = 1 To listCount
			candidate = GetRandomNumber(maxValue)
			oddNumbers.Add(GetOddNumber(candidate))

		Next

		Return oddNumbers

	End Function
	Public Function GetRandomEvenNumber(maxValue As Integer) As Integer
		Dim candidate As Integer = GetRandomNumber(maxValue)

		Return GetOddNumber(candidate) + 1
	End Function

	Private Function GetOddNumber(candidate As Integer) As Integer
		If Integer.IsOddInteger(candidate) Then
			Return candidate
		Else
			Return candidate + 1
		End If

	End Function

	Public Function GetRandomNumber(maxValue As Integer) As Integer
		Dim ran = New Random
		Dim candidate As Integer = ran.Next(maxValue:=maxValue)
		Return candidate
	End Function
End Class

