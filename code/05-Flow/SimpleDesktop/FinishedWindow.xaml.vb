﻿Imports System.Runtime.CompilerServices

Public Class FinishedWindow

	Private Sub AddToDoButton_Click(sender As Object, e As RoutedEventArgs) Handles AddToDoButton.Click
		ToDoList.Items.Add(TextBox1.Text)

	End Sub

	Private Sub ToDoList_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles ToDoList.SelectionChanged
		Me.TextBlock1.Text = ToDoList.SelectedItem.ToString
	End Sub
End Class
