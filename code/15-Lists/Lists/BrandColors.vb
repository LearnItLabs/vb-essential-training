Public Class BrandColors

	Public Sub New()
		Dim temp As New List(Of String)

		temp.Add("Scarlet")
		temp.Add("Magenta")
		temp.Insert(0, "SkyBlue")
		temp.AddRange({"Emerald", "Olive", "Sage", "Lavender"})
		Me.ColorNames = temp
	End Sub
	Private _colorNames As List(Of String)
	Public Property ColorNames() As List(Of String)
		Get

			Return _colorNames
		End Get
		Set(ByVal value As List(Of String))
			_colorNames = value
		End Set
	End Property

	Private _colorCount As Integer
	Public ReadOnly Property ColorCount() As Integer
		Get
			Return Me.ColorNames.Count
		End Get

	End Property

End Class
