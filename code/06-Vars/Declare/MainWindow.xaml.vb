

Class MainWindow
	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		' Declare with identifier, type and initializer 
		Dim cartCount As Integer = 22
		Dim taxRate As Double = 9.75

		' Declare with identifier and initializer
		' Variable type is inferred from the literal type
		Dim boxCount = 33
		Dim isFileReadOnly = False

		' Declare with identifier only
		Dim productCount
		' assign a value before using
		productCount = 44


#Region "Output"
		ShowItDetailed(cartCount, NameOf(cartCount), cartCount.GetType().Name)

		ShowItDetailed(taxRate, NameOf(taxRate), taxRate.GetType().Name)
		ShowItDetailed(boxCount, NameOf(boxCount), boxCount.GetType().Name)
		ShowItDetailed(isFileReadOnly, NameOf(isFileReadOnly), isFileReadOnly.GetType().Name)
		ShowItDetailed(productCount, NameOf(productCount), productCount.GetType().Name)
#End Region
	End Sub
	Private Sub SuffixButton_Click(sender As Object, e As RoutedEventArgs) Handles SuffixButton.Click
		'  In Visual Basic (VB), there are several literal type character suffixes
		'  you can use to specify the data type of a literal constant.
		' I or i: Integer
		' L or l: Long
		' S or s: Short

		' F or f: Single (float)
		' R or r: Double
		' D or d: Decimal
		Dim boxCounter = 20
		Dim appCounter = 20.5D

	End Sub

	Private Sub ValidIdButton_Click(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click
		' Variable name rules

		' - It must begin with an alphabetic character or an underscore (_).
		' - It must only contain alphabetic characters, decimal digits, and underscores.
		' - It must contain at least one alphabetic characterr decimal
		'    digit if it begins with an underscore.
		'	- It must not be more than 1023 characters long.

		Dim _counter As Integer
		Dim counter As Long
		Dim base3Counter As Long
		Dim widget_counter As Short

		'Dim 5counter As Short ' not a valid name

		' Naming conventions:
		' Suggestions that follow Microsoft internal guidelines
		' and are common in .NET libraries.
		' Use camel case for "local variable" .
		' (lower case first letter, capitalize rest of words).

		Dim thisIsAGoodName As String = ""
		Dim lowercasename As String = ""
		Dim UPPERCASENAME As String = ""

		' VB compiler doesn't care about case.
		' VB editor matches the initial identifier

		thisIsAGoodName = "hello"
		lowercasename = "David"

#Region "Output"
		ShowIt(_counter)
		ShowIt(counter)
		ShowIt(base3Counter)
		ShowIt(widget_counter)
		ShowIt(thisIsAGoodName)
		ShowIt(lowercasename)
		ShowIt(UPPERCASENAME)
#End Region


	End Sub



	Private Sub ChangeColorButton_Click(sender As Object, e As RoutedEventArgs) Handles RunCode3Button.Click

		' We can declare a variable of any .NET type.
		' We can instantiate the type (with the New keyword) if it has a contructor
		' We can instantiate the type if it has a factory method

		Dim simpleBrush As SolidColorBrush = New SolidColorBrush
		Dim products As List = New List

		' Provides a set of properties and methods that are used to manage cookies
		Dim siteCookie As Net.Cookie = New Net.Cookie



		Dim backBrush As New SolidColorBrush
		backBrush.Color = Colors.Orange
		MainPanel.Background = backBrush
	End Sub
	Sub ShowItDetailed(message As String, variableName As String, typeName As String)

		Dim paddedMessage = $"{variableName}: is of type ({typeName}). {vbCrLf}  Value = {message}"
		MessageTextBox.Text += paddedMessage + vbCrLf + vbCrLf
	End Sub

	Sub ShowIt(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
		Dim backBrush As New SolidColorBrush
		backBrush.Color = Colors.LightSteelBlue
		MainPanel.Background = backBrush
	End Sub


End Class
