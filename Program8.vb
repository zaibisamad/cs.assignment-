Imports System

Module Program
    Sub Main()
        'First character used again used is replaced by *

        Dim str As String
        Dim chr1, chr2 As Char
        Dim i As Integer

        Console.Write("Enter a string: ")
        str = Console.ReadLine()
        chr1 = Left(str, 1)
        Console.WriteLine(chr1)

        For i = 1 To Len(str) - 1
            chr2 = Mid(str, (i + 1), 1)
            If chr2 = chr1 Then
                chr2 = "*"
            End If
            Console.WriteLine(chr2)
        Next
        Console.ReadKey()
    End Sub
End Module
