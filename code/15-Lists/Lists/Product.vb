Public Class Product

  Public Sub New()

  End Sub
  Public Sub New(productName As String, price As Decimal)
    Me.ProductName = productName
    Me.Price = price
  End Sub
  Private _productName As String
  Public Property ProductName() As String
    Get
      Return _productName
    End Get
    Set(ByVal value As String)
      _productName = value
    End Set
  End Property

  Private _price As Decimal
  Public Property Price() As Decimal
    Get
      Return _price
    End Get
    Set(ByVal value As Decimal)
      _price = value
    End Set
  End Property
End Class
