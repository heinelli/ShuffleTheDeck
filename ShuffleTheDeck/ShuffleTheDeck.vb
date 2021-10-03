'Elliot Heiner
'RCET 0265
'Fall 2021
'Shuffle the Deck
'

Option Strict On
Option Explicit On

Module ShuffleTheDeck

    Sub Main()
        Dim deck(12, 3) As Integer

    End Sub

    Function DrawCard()
        Dim suitValue As Integer
        Dim numberValue As Integer
        Dim suitReturn As String
        Dim numberReturn As String

        Randomize()
        suitValue = Int((4 * Rnd()) + 0)
        numberValue = Int((13 * Rnd()) + 0)

        If suitValue = 0 Then
            suitReturn = "Clubs"
        ElseIf suitValue = 1 Then
            suitReturn = "Spades"
        ElseIf suitValue = 2 Then
            suitReturn = "Hearts"
        Else
            suitReturn = "Diamonds"
        End If

        If numberValue = 0 Then
            numberReturn = "Ace"
        ElseIf numberValue = 1 Then
            numberReturn = "2"
        ElseIf numberValue = 2 Then
            numberReturn = "3"
        ElseIf numberValue = 3 Then
            numberReturn = "4"
        ElseIf numberValue = 4 Then
            numberReturn = "5"
        ElseIf numberValue = 5 Then
            numberReturn = "6"
        ElseIf numberValue = 6 Then
            numberReturn = "7"
        ElseIf numberValue = 7 Then
            numberReturn = "8"
        ElseIf numberValue = 8 Then
            numberReturn = "9"
        ElseIf numberValue = 9 Then
            numberReturn = "10"
        ElseIf numberValue = 10 Then
            numberReturn = "Jack"
        ElseIf numberValue = 11 Then
            numberReturn = "Queen"
        ElseIf numberValue = 12 Then
            numberReturn = "King"
        End If

        Return numberReturn & " of " & suitReturn
    End Function

End Module
