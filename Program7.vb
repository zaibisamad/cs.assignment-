Imports System

Module Program
    Sub Main()
        'Output the first and last 2 characters of the string 

        Dim str1, str2 As String
        Dim last2 As String
        Dim first2 As String

        str1 = ""

        Console.Write("Enter a string: ")
        str1 = Console.ReadLine()

        first2 = Left(str1, 2)
        last2 = Right(str1, 2)


        If Len(str1) < 3 Then
            Console.WriteLine("Result:" & str1)
        Else
            Console.WriteLine("Result: " & first2 & last2)
        End If
        Console.ReadLine()
    End Sub
End Module
