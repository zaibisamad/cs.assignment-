Imports System
Imports System.Xml

Module Program
    Sub Main()
        'swapping first two characters of the 2 words in a string

        Dim str1, str2 As String
        Dim x, y, a, b, p, q As String
        Dim len1 As Integer
        Dim len2 As Integer

        len1 = 0
        len2 = 0
        a = ""
        b = ""
        
        Console.Write("enter a word: ")
        str1 = Console.ReadLine()
        Console.Write("enter another word: ")
        str2 = Console.ReadLine()

        len1 = Len(str1)
        len2 = Len(str2)

        x = Left(str1, 2) 'string1 ke 2 chars
        y = Left(str2, 2) 'string2 ke 2 chars
        a = Right(str1, len1 - 2) 'remaining chars of string1
        b = Right(str2, len2 - 2)  'remaining chars of string2
        p = x & b
        q = y & a


        If len2 > 2 And len1 > 2 Then
            Console.WriteLine("result:" & p & " " & q)
        Else
            Console.WriteLine("enter longer word nexxt time. ")
        End If
        Console.ReadKey()
    End Sub
End Module
