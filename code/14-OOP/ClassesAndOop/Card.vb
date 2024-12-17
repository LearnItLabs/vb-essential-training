' Base class Card
Imports System.Runtime.Serialization

' classes defined for a fantasy trading card game
Public Class Card

  Private _name As String
  Public Property Name() As String
    Get
      Return _name
    End Get
    Set(ByVal value As String)
      _name = value
    End Set
  End Property
  ' Auto-implemented properties
  Public Property Description As String
  Public Property ListPrice As Decimal
  Public Property AskingPrice As Decimal


  Public ReadOnly Property Discount As Decimal
    Get
      Return AskingPrice * 0.45D
    End Get
  End Property


  Public ReadOnly Property SalePrice As Decimal
    Get
      Return AskingPrice - Discount
    End Get
  End Property


  Public ReadOnly Property TypeName As String
    Get
      Return Me.GetType().FullName
    End Get
  End Property
End Class


Public Class Creature
  Inherits Card

  Public Property EyeCount As Integer
  Public Property Spikes As Boolean
  Public Property Antenna As Boolean
End Class


Public Class Monster
  Inherits Creature
End Class


Public Class Robot
  Inherits Card
  Implements IComparable(Of Robot)


  Public Property BatteryLevel As Decimal

  Public Function CompareTo(other As Robot) As Integer Implements IComparable(Of Robot).CompareTo
    If other Is Nothing Then
      Return 1 ' Treat current instance as greater if other is null
    End If

    ' Compare BatteryLevel
    Return Me.BatteryLevel.CompareTo(other.BatteryLevel)
  End Function
End Class


Public Class Cyborg
  Inherits Robot
End Class


Public Class Nanobot
  Inherits Robot
End Class

