Public Class ExitDemo
  Dim parentWin As MainWindow
  Private Sub RunButton_Click(sender As Object, e As RoutedEventArgs) Handles RunButton.Click

    Dim searchString As String = OrignalTextBox.Text
    Dim charToFind As Char = "!"c
    Dim foundIndex As Integer = -1

    For i As Integer = 0 To searchString.Length - 1
      parentWin.ShowItSimple(searchString(i).ToString)
      If searchString(i) = charToFind Then
        foundIndex = i
        ' Use Exit: To break out of the loop entirely when a certain condition is met or an early exit is required.
        Exit For
      End If
    Next

    If foundIndex <> -1 Then
      Console.WriteLine("Character '" & charToFind & "' found at index: " & foundIndex)
    Else
      Console.WriteLine("Character '" & charToFind & "' not found in the string.")
    End If


  End Sub



  Private Sub ContinueButton_Click(sender As Object, e As RoutedEventArgs) Handles ContinueButton.Click
    Dim result As String = ""
    Dim searchString As String = OrignalTextBox.Text
    Dim charToFind As Char = " "c

    For i As Integer = 0 To searchString.Length - 1

      If searchString(i) = charToFind Then

        ' Use Continue: To skip to the next iteration if certain conditions are met.
        Continue For

      End If
      parentWin.ShowItSimple(searchString(i))
    Next


  End Sub

  Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
    parentWin = Window.GetWindow(Me)


  End Sub

  Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
    parentWin.ClearIt()
  End Sub
End Class
