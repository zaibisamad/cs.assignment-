Imports System
Imports System.Collections.Specialized
Imports System.Threading

Module Program
    Sub Main()
        'Output the number of donuts 

        Dim count As Integer

        Console.WriteLine("How many donuts: ")
        count = Console.ReadLine

        If count < 10 Then
            Console.WriteLine("Donuts left are: " & count)
        ElseIf count > 10 Then
            Console.WriteLine("Number of Donuts: many")
        End If

    End Sub
End Module
