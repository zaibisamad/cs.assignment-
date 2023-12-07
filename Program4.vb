Imports System

Module Program
    Sub Main()
        ' Finding most frequent typed letter in a string 

        Dim Char1, char2, nextChar As Char
        Dim Highest, Count, i, j As Integer
        Dim str As String

        Char1 = ""
        Highest = 0
        Count = 0

        Console.Write("Enter the string: ")
        str = Console.ReadLine

        For i = 1 To Len(str)
            nextChar = Mid(str, i, 1)
            Count = 0
            For j = 1 To Len(str)
                char2 = Mid(str, j, 1)
                If char2 = nextChar Then Count = Count + 1
            Next

            If Count > Highest Then
                Highest = Count
                Char1 = nextChar
            End If
        Next
        Console.WriteLine(Char1 & " appeared " & Highest & " times.")
        Console.ReadKey()
    End Sub
    End Module

