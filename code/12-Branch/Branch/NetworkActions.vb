Class NetworkActions


	Public Function GetNetworkName() As String
		Dim gen = New NumberGenerator
		If Integer.IsOddInteger(gen.GetRandomNumber(20)) Then
			Return "River"
		Else
			Return Nothing
		End If

	End Function

	Public Function IsNetWorkAvailable(networkName As String) As Boolean
		' This method returns quickly.
		Return True
	End Function

	Public Function IsDatabaseOnline() As Boolean
		' Simulate a slow operation with a delay.
		Dim endTime As DateTime = DateTime.Now.AddSeconds(3)
		While DateTime.Now < endTime
			' Perform some  operations to keep the thread busy

			Dim squares As Double = Math.Sqrt(12345)
		End While
		Return True

	End Function
End Class
