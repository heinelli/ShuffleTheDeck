'Elliot Heiner
'RCET 0265
'Fall 2021
'Shuffle the Deck
'

Option Strict On
Option Explicit On

Module ShuffleTheDeck

    Sub Main()
        Dim testArray(3, 3) As String

        testArray(0, 0) = "fish"
        testArray(3, 3) = "turtle"
        ReturnTest1()
        ReturnTest2()
        Console.WriteLine(testArray(ReturnTest1(), ReturnTest2()))
        Console.Read()

    End Sub

    Function ReturnTest1() As Integer
        Return 0
    End Function

    Function ReturnTest2() As Integer
        Return 0
    End Function


End Module
