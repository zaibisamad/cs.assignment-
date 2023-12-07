Imports System
Imports System.Net.Security
Imports System.Threading.Channels

Module Program
    Sub Main()
        'finding alphabets and digits ina string

        Dim Str As String
        Dim i As Integer
        Dim Chr As Char
        Dim alpha, digits, x As Integer
        alpha = 0
        digits = 0
        x = 0

        Console.Write("Enter the string: ")
        Str = UCase(Console.ReadLine)

        x = Len(Str)

        For i = 1 To Len(Str)
            Chr = Mid(Str, i, 1)
            If Chr >= "A" And Chr <= "Z" Then
                alpha = alpha + 1
            ElseIf (Chr >= "0") And (Chr <= "9") Then
                digits = digits + 1
            End If
        Next

        Console.WriteLine("The length of the string is " & x)
        Console.WriteLine("Number of alphabets in the string are " & alpha)
        Console.WriteLine("Number of digits in the string are " & digits)
    End Sub
End Module
