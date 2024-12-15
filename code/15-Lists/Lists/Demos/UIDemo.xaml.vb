Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class UIDemo
	Private Sub AddButton_Click(sender As Object, e As RoutedEventArgs) Handles AddButton.Click
		' The ListBox is a versatile And commonly used control designed to display a list of items
		' It presents a >>collection<< of items in a vertical or horizontal list, making it easy for users to view and select from multiple options.

		' add some items to the ListBox.
		Dim currentDay = DateTime.Now.DayOfWeek

		OutputListBox.Items.Add(currentDay)
		OutputListBox.Items.Add("Blue")


		For index = 1 To 10
			OutputListBox.Items.Add($"Count {index.ToString("D2")}")
		Next

	End Sub

	Private Sub RemoveAtButton_Click(sender As Object, e As RoutedEventArgs) Handles RemoveAtButton.Click
		If OutputListBox.Items.Count <= 0 Then
			Exit Sub
		End If

		OutputListBox.Items.RemoveAt(4)
	End Sub

	Private Sub RemoveButton_Click(sender As Object, e As RoutedEventArgs) Handles RemoveButton.Click
		If OutputListBox.Items.Count <= 0 Then
			Exit Sub
		End If

		OutputListBox.Items.Remove("Blue")
	End Sub

	Private Sub GetItemButton_Click(sender As Object, e As RoutedEventArgs) Handles GetItemButton.Click
		If OutputListBox.Items.Count <= 1 Then
			Exit Sub
		End If

		' item count starts at 0
		ItemTextBlock.Text = OutputListBox.Items(1)
	End Sub
End Class
