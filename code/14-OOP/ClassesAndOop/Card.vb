' Base class Card
Imports System.Runtime.Serialization
Namespace BigStarCards
  ' classes defined for a fantasy trading card game
  Public Class Card

#Region "Constructors"
    ' In Visual Basic, when you define a Sub New procedure 
    ' it acts as the constructor for the class. If you define a Sub New without parameters,
    ' it replaces the default constructor provide by .NET

    Public Sub New()
      ' The primary purpose of a constructor
      ' is to initialize the object by setting up its initial state.
      ' This typically involves assigning values to fields,
      ' initializing properties, or performing
      ' any setup required for the object to function properly.

    End Sub
    Public Sub New(name As String, description As String,
                   originalListPrice As Decimal, askingPrice As Decimal)
      ' an additional constructor that takes four parameters
      Me.Name = name
      Me.Description = description
      Me.OriginalListPrice = originalListPrice
      Me.AskingPrice = askingPrice
    End Sub

    Public Sub New(name As String, description As String)
      ' an additional constructor that takes two parameters
      Me.Name = name
      Me.Description = description
      Me.OriginalListPrice = OriginalListPrice
      Me.AskingPrice = AskingPrice
    End Sub
#End Region
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
    Public Property OriginalListPrice As Decimal
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
    ' Overload the < operator
    Public Shared Operator <(r1 As Robot, r2 As Robot) As Boolean
      Return r1.CompareTo(r2) < 0
    End Operator

    ' Overload the > operator
    Public Shared Operator >(r1 As Robot, r2 As Robot) As Boolean
      Return r1.CompareTo(r2) > 0
    End Operator
  End Class


  Public Class Cyborg
    Inherits Robot
  End Class


  Public Class Nanobot
    Inherits Robot
  End Class
End Namespace


