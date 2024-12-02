Class MainWindow
	' Class-level scope:
	' - The variable is visible to all code within the class.
	' - In Object-Oriented Programming (OOP), such variables are referred to as fields.
	' - Fields are members of the class type and can be accessed by all methods within the class.


	Private primaryBrush As New SolidColorBrush

	' underscore naming convention
	' preferred by some OOP programmers
	Private _accentBrush As New SolidColorBrush


	Private Sub RunCode(sender As Object, e As RoutedEventArgs) Handles RunCodeButton.Click
		' Variables have both scope and lifetime.

		' Scope:
		' - Scope determines the visibility of a variable to other parts of the code.
		' - Variables within the same scope cannot share the same name.

		' Lifetime:
		' - Lifetime refers to the duration for which
		'   the variable's allocated memory remains available.
		' - The lifetime of a variable depends on where it is declared.


		Dim cartCounter As Integer = 15
		'Dim counter As Long = 20



		' The variable 'cartCounter' is a local variable.
		' - Local variables are only accessible within the method where they are declared.
		' - Any code within this method can access and modify 'cartCounter'.


		If cartCounter > 10 Then
			cartCounter += 1
			Dim message As String = "block scope"
			' 'message' is a block-scoped variable. 
			' - It is declared within this 'if' statement. 
			' - 'message' is only accessible inside this statment. 
			' - Any code outside this statement cannot access 'message'.
			ShowIt(message)

		End If
		If cartCounter > 20 Then
			Dim message As String = "block scope"
			' we can declare the same variable name, as it doesn't confict 
			' with block-scope variables declared elsewhere.
			ShowIt(message)
		End If
		' What is the scope, can we use this variable here?
		'	message = "Cannot access this variable"

	End Sub

	Private Sub RunCode2(sender As Object, e As RoutedEventArgs) Handles RunCode2Button.Click
		primaryBrush.Color = Colors.Orange
		MainPanel.Background = primaryBrush

	End Sub
	Private Sub RunCode3Button_Click(sender As Object, e As RoutedEventArgs) Handles RunCode3Button.Click
		_accentBrush.Color = Colors.Purple
		MessageTextBox.Foreground = primaryBrush
		MessageTextBox.Background = _accentBrush
	End Sub

	Sub ShowIt(message As String)
		MessageTextBox.Text += message + vbCrLf
	End Sub

	Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
		MessageTextBox.Text = ""
	End Sub


End Class
