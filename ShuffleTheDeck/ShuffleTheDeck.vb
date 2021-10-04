'Elliot Heiner
'RCET 0265
'Fall 2021
'Shuffle the Deck
'

Option Strict On
Option Explicit On

Module ShuffleTheDeck

    Sub Main()
        Dim deck(12, 3) As Boolean
        Dim value As Integer
        Dim suit As Integer
        Dim numberReturn As String
        Dim suitStringReturn As String
        Dim endStatement As Boolean

        For i = 0 To 52

            suit = CardSuit(suitStringReturn)
            value = CardValue(numberReturn)
            If deck(value, suit) = True Then
                CardSuit(suitStringReturn)
                CardValue(numberReturn)
            ElseIf deck(value, suit) = False Then
                Console.WriteLine(numberReturn & " of " & suitStringReturn)
                deck(value, suit) = True
            End If




        Next
        Console.Read()
    End Sub

    'Function CheckDeck(ByRef check1 As Integer, ByRef check2 As Integer) As Boolean
    '    Dim arrayCheck(12, 3) As Boolean
    '    Dim endStatement As Boolean
    '    Dim answer As Boolean = False


    '    'If deck(value, suit) = False Then
    '    'Console.WriteLine(numberReturn & " of " & suitStringReturn)
    '    'deck(value, suit) = True
    '    'E 'lseIf deck(value, suit) = True Then
    '    'En 'd If
    '    Do While endStatement = False

    '        If arrayCheck(check1, check2) = False Then
    '            arrayCheck(check1, check2) = True
    '            answer = True
    '            endStatement = True
    '        ElseIf arrayCheck(check1, check2) = True Then
    '            endStatement = False
    '        End If
    '    Loop
    '    Return answer
    'End Function

    Function CardSuit(ByRef suitStringReturn As String) As Integer
        Dim suitValue As Integer
        Dim suitIntegerReturn As Integer

        Randomize()
        suitValue = CInt((4 * Rnd()) + 0)

        If suitValue = 0 Then
            suitStringReturn = "Clubs"
            suitIntegerReturn = 0
        ElseIf suitValue = 1 Then
            suitStringReturn = "Spades"
            suitIntegerReturn = 1
        ElseIf suitValue = 2 Then
            suitStringReturn = "Hearts"
            suitIntegerReturn = 2
        Else
            suitStringReturn = "Diamonds"
            suitIntegerReturn = 3
        End If
        Return suitIntegerReturn
    End Function

    Function CardValue(ByRef numberReturn As String) As Integer
        Dim numberValue As Integer
        Dim valueReturn As Integer

        numberValue = CInt((13 * Rnd()) + 0)

        If numberValue = 0 Then
            numberReturn = "Ace"
            valueReturn = 0
        ElseIf numberValue = 1 Then
            numberReturn = "2"
            valueReturn = 1
        ElseIf numberValue = 2 Then
            numberReturn = "3"
            valueReturn = 2
        ElseIf numberValue = 3 Then
            numberReturn = "4"
            valueReturn = 3
        ElseIf numberValue = 4 Then
            numberReturn = "5"
            valueReturn = 4
        ElseIf numberValue = 5 Then
            numberReturn = "6"
            valueReturn = 5
        ElseIf numberValue = 6 Then
            numberReturn = "7"
            valueReturn = 6
        ElseIf numberValue = 7 Then
            numberReturn = "8"
            valueReturn = 7
        ElseIf numberValue = 8 Then
            numberReturn = "9"
            valueReturn = 8
        ElseIf numberValue = 9 Then
            numberReturn = "10"
            valueReturn = 9
        ElseIf numberValue = 10 Then
            numberReturn = "Jack"
            valueReturn = 10
        ElseIf numberValue = 11 Then
            numberReturn = "Queen"
            valueReturn = 11
        ElseIf numberValue = 12 Then
            numberReturn = "King"
            valueReturn = 12
        End If
        Return valueReturn
    End Function

End Module
