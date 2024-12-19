Imports ClassesAndOop.BigStarCards

Public Class CardDemo

	Private Sub SetButton_Click(sender As Object, e As RoutedEventArgs) Handles SetButton.Click
		Dim card = New BigStarCards.Card

		card = SetCardProperties(card)

		' read properties

		Dim salePrice = card.SalePrice ' a read only property

		Dim cardName = card.Name
		ShowHeader("Card Name")
		ShowIt(cardName)

		ShowHeader("Sale Price")
		ShowIt(salePrice)

	End Sub

	Private Shared Function SetCardProperties(card As BigStarCards.Card) As BigStarCards.Card
		' use accessor methods
		card.SetName("Branshie")
		Dim name = card.GetName()

		' set property
		card.Name = "Traxtor"
		card.Description = "Traxtor: A relentless warrior who crushes foes with unyielding strength and ferocity."
		card.OriginalListPrice = 5.95D
		card.AskingPrice = 75D
		Return card
	End Function

	Private Sub ConstructorButton_Click(sender As Object, e As RoutedEventArgs) Handles ConstructorButton.Click
		Dim card1 = New Card() ' use parameterless constructor
		Dim emberDesc As String = "A fiery spirit that ignites the battlefield with bursts of flame."

		Dim card2 = New Card("Emberling", emberDesc)

		Dim card3 = Nothing

	End Sub

	Private Sub InheritButton_Click(sender As Object, e As RoutedEventArgs) Handles InheritButton.Click
		Dim card As New BigStarCards.Card
		Dim bot As New BigStarCards.Nanobot
		Dim monster = New BigStarCards.Monster

		' work with base class properties

		monster.AskingPrice = 55D
		bot.AskingPrice = 12.44D

		' work with derived class properties
		monster.Antenna = True
		bot.BatteryLevel = 0.5


	End Sub

	Private Sub InterfaceButton_Click(sender As Object, e As RoutedEventArgs) Handles InterfaceButton.Click

		Dim bot1 As New Nanobot
		Dim bot2 As New Nanobot
		Dim monster1 = New BigStarCards.Monster
		Dim monster2 = New BigStarCards.Monster

		Dim sortedMonsters As New SortedSet(Of Monster)

		' cannot use SortedSet unless the type
		' implements IComparable (Of T)
		'sortedMonsters.Add(monster1)
		'sortedMonsters.Add(monster2)

		Dim sortedBots As New SortedSet(Of BigStarCards.Robot)

		sortedBots.Add(bot1)
		sortedBots.Add(bot2)


		'If bot1 > bot2 Then

		'End If

	End Sub

#Region "Show methods"


	Sub ShowIt(message As String)
		Dim bulletText As New Run("» ")
		MessageOut.Inlines.Add(bulletText)
		bulletText.Foreground = Brushes.SteelBlue
		Dim normalText As New Run(message + vbCrLf)
		MessageOut.Inlines.Add(message + vbCrLf)
	End Sub
	Sub ShowBlankLine()
		Dim lineText As New Run("" + vbCrLf)
		MessageOut.Inlines.Add(lineText)
	End Sub
	Sub ShowHeader(message As String)
		Dim boldText As New Run(message + vbCrLf)
		boldText.FontWeight = FontWeights.Bold
		MessageOut.Inlines.Add(boldText)

	End Sub
	Sub Clear()
		MessageOut.Text = ""
	End Sub

	Sub ShowLine()
		Dim lineText As New Run(New String("-"c, 68) + vbCrLf)
		lineText.Foreground = Brushes.LightBlue
		MessageOut.Inlines.Add(lineText)
	End Sub






#End Region
End Class
