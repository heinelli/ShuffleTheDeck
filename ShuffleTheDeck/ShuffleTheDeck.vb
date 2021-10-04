'Elliot Heiner
'RCET 0265
'Fall 2021
'Shuffle the Deck
'https://github.com/heinelli/ShuffleTheDeck.git

Option Strict On
Option Explicit On
Option Compare Text

Module ShuffleTheDeck
    Sub Main()
        Dim deck(12, 3) As Boolean
        Dim clear(12, 3) As Boolean
        Dim value As Integer
        Dim suit As Integer
        Dim numberReturn As String
        Dim suitStringReturn As String
        Dim endStatement As Boolean
        Dim cardCount As Integer
        Dim input As String
        Dim shuffle As Boolean

        Console.WriteLine("Press ENTER to draw a card.
Press S to reshuffle the deck.")
        Console.ReadLine()

        'Repeat card dealings until user exits program.
        Do
            Do While endStatement = False
                suit = CardSuit(suitStringReturn)
                value = CardValue(numberReturn)

                'Shuffle deck if S is typed.
                If input = "s" Then
                    endStatement = True
                    Do Until shuffle = True
                        If deck(value, suit) = False Then
                            deck(value, suit) = True
                            cardCount += 1
                            shuffle = False
                        ElseIf deck(value, suit) = True And cardCount <> 52 Then
                            Do Until deck(value, suit) = False
                                suit = CardSuit(suitStringReturn)
                                value = CardValue(numberReturn)
                            Loop
                            deck(value, suit) = True
                            cardCount += 1
                            shuffle = False
                        Else
                            shuffle = True
                        End If
                    Loop

                    'Search for and label each card as true to signify that it has been dealt
                ElseIf deck(value, suit) = False Then
                    Console.WriteLine(numberReturn & " of " & suitStringReturn)
                    deck(value, suit) = True
                    cardCount += 1
                    endStatement = False
                ElseIf deck(value, suit) = True And cardCount <> 52 Then
                    Do Until deck(value, suit) = False
                        suit = CardSuit(suitStringReturn)
                        value = CardValue(numberReturn)
                    Loop
                    Console.WriteLine(numberReturn & " of " & suitStringReturn)
                    deck(value, suit) = True
                    cardCount += 1
                    endStatement = False
                Else
                    endStatement = True
                End If
                input = Console.ReadLine()
            Loop

            'Reset card count and shuffle the deck by setting all elements equal to false.
            cardCount = 0
            endStatement = False
            Do While endStatement = False
                suit = CardSuit(suitStringReturn)
                value = CardValue(numberReturn)

                If deck(value, suit) = True Then
                    deck(value, suit) = False
                    cardCount += 1
                    endStatement = False
                ElseIf deck(value, suit) = False And cardCount <> 52 Then
                    Do Until deck(value, suit) = True
                        suit = CardSuit(suitStringReturn)
                        value = CardValue(numberReturn)
                    Loop
                    deck(value, suit) = False
                    cardCount += 1
                    endStatement = False
                Else
                    endStatement = True
                End If
            Loop
            cardCount = 0
            endStatement = False
            Console.WriteLine("Deck shuffled")
            shuffle = False
            Console.ReadLine()
        Loop
    End Sub

    'Generate a random suit
    Function CardSuit(ByRef suitStringReturn As String) As Integer
        Dim suitValue As Integer
        Dim suitIntegerReturn As Integer
        Randomize()
        suitValue = CInt(System.Math.Floor(Rnd() * (3 + 1)))

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

    'Generate a random value
    Function CardValue(ByRef numberReturn As String) As Integer
        Dim numberValue As Integer
        Dim valueReturn As Integer
        numberValue = CInt(System.Math.Floor(Rnd() * (12 + 1)))

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
