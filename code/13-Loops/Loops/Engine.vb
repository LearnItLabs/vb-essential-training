Module Engine
	Dim _ran = New Random

	Public Async Function GetEngineStatus() As Task(Of Integer)
		Await Task.Delay(1)
		Dim candidate As Integer = _ran.Next(minValue:=-10, maxValue:=300)
		Return candidate
	End Function
End Module
