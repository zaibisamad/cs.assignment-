Imports System
Imports System.Reflection.PortableExecutable
Imports System.Xml

Module Program
    Sub Main()
        'finding if all the alphabets are in a string 
        Dim str1, alphaStr As String
        Dim nextChar As Char
        Dim i As Integer
        Dim isPangram As Boolean

        str1 = ""
        alphaStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        nextChar = ""
        i = 0
        isPangram = True

        Console.Write("Enter String: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)

        For i = 1 To Len(alphaStr)
            nextChar = Mid(alphaStr, i, 1)
            If InStr(str1, nextChar) = 0 Then
                isPangram = False
                Exit For
            End If
        Next

        If isPangram = True Then
            Console.WriteLine("Sentence contains all alphabets.")
        Else
            Console.WriteLine("Sentence does not contain all alphabets")
        End If
        Console.ReadKey()
    End Sub
End Module
