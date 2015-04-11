Option Strict On
Imports System.Console
Module Square

    Sub Main()
        Dim soperand1 As String = ""

        Dim operand1 As Double = 0
        Dim counter As Double = 0

        Dim endResult As Double = 0

        Dim _wrongValue As Boolean = False
        Dim goodValue As Boolean = False

        Dim wrongCountOne As Integer

        WriteLine("Let's square stuff! Equation: operand1 ^ 2 = endResult")

        wrongCountOne = 0
        While (Not _wrongValue And Not goodValue)
            'request number from user
            soperand1 = InputBox("Please enter a positive number")
            operand1 = Val(soperand1)
            WriteLine("Operand1: " & operand1)

            'check if valid input
            If (operand1 <= -1) Then
                wrongCountOne += 1
                WriteLine("Number Invalid!")
            Else
                goodValue = True
            End If

            If (wrongCountOne > 1) Then
                _wrongValue = True
                WriteLine("ERROR. Too many wrong values!")
            End If
        End While

        If (operand1 > -1) Then
            'Square up
            counter = operand1
            While (counter > 0)
                endResult = endResult + operand1
                counter -= 1
            End While
            WriteLine(operand1 & " ^ 2 = " & endResult)
        End If
        Console.WriteLine("Good-bye")
        Console.ReadLine()

    End Sub
End Module
