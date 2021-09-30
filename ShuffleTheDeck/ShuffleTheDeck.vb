Module ShuffleTheDeck

    Sub Main()
        Console.WriteLine(DrawCard())
        Console.Read()
    End Sub

    Function DrawCard()
        Dim suitValue As Integer
        Dim numberValue As Integer
        Randomize()
        suitValue = Int((3 * Rnd()) + 1)
        numberValue = Int((13 * Rnd()) + 1)
        Return CInt(suitValue & numberValue)
    End Function

End Module
