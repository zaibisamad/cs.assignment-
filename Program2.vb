Imports System

Module Program
    Sub Main()
        'truncating and replacing a character in a string
        Dim STR1, STR2, Char1, Char2, Char3 As String
        Dim COUNT As Integer
        STR1 = ""
        STR2 = ""

        Console.Write("Enter a string: ")
        STR1 = Console.ReadLine()
        Console.Write("What to replace: ")
        Char1 = Console.ReadLine()
        Console.Write("Enter character to replace with: ")
        Char2 = Console.ReadLine

        For COUNT = 1 To Len(STR1)
            Char3 = Mid(STR1, COUNT, 1)
            If Char1 <> Char3 Then
                STR2 = STR2 & Char3
            Else
                STR2 = STR2 & Char2
            End If
        Next COUNT
        Console.WriteLine(STR2)
        Console.ReadKey()

    End Sub
End Module
