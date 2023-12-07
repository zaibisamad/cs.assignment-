Imports System
Imports System.Reflection.PortableExecutable

Module Program
    Sub Main()
        'counting nmber of vowels in a string  

        Dim Str As String
        Dim Counter, vCount As Integer
        Dim Chr As Char

        Const vowels = "aAeEiIoOuU"

        Str = ""
        Chr = ''
        vCount = 0
        Counter = 0

        Console.Write("Enter string to look for vowels: ")
        Str = Console.ReadLine

        For Counter = 1 To Len(Str)
            Chr = Mid(Str, Counter, 1)
            If InStr(vowels, Chr) > 0 Then
                vCount = vCount + 1
            End If
        Next

        Console.WriteLine("Number of vowels in the given string = " & vCount)
        Console.ReadKey()
    End Sub
End Module
