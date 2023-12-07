Imports System

Module Program
    Sub Main()
        'adding ing to a string and swapping ing to ly 
        Dim str1 As String
        Dim x, y, z, a As String
        Dim lenstr As Integer

        str1 = ""
        x = "ing"
        y = "ly"
        a = ""

        Console.Write("Enter a string: ")
        str1 = Console.ReadLine
        lenstr = Len(str1)
        z = Right(str1, 3)

        If lenstr > 2 Then
            If z = x Then
                a = y
            Else
                a = x
            End If
            Console.WriteLine("result: " & str1 & a)
        Else
            Console.WriteLine(str1)
        End If
        Console.ReadKey()
    End Sub
End Module
