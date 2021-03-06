﻿Option Strict On
Imports System.Console

Module Module1

    Sub Main()

        Dim soperand1 As String = ""
        Dim soperand2 As String = ""

        Dim operand1 As Double = 0
        Dim operand2 As Double = 0
        Dim counter As Double = 0

        Dim endResult As Double = 0

        Dim _wrongValue As Boolean = False
        Dim goodValue As Boolean = False

        Dim wrongCountOne As Integer
        Dim wrongCountTwo As Integer


        WriteLine("Let's mod! Equation: operand1 MOD operand2 = endResult")

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

        If (goodValue = True) Then
            wrongCountTwo = 0
            While (Not _wrongValue)
                'request number from user
                soperand2 = InputBox("Please enter a second positive number")
                operand2 = Val(soperand2)
                WriteLine("Operand2: " & operand2)

                'check if valid input
                If (operand2 <= -1) Then
                    wrongCountTwo += 1
                    WriteLine("Number Invalid!")
                Else
                    _wrongValue = True
                End If

                If (wrongCountTwo > 1) Then
                    _wrongValue = True
                    WriteLine("ERROR. Too many wrong values!")
                End If
            End While

            'check if operand2 is greater than operand1
            If (operand2 > operand1) Then
                WriteLine(operand1 & " Mod " & operand2 & " = " & operand1)

                'execute program if first number is greater than -1
            ElseIf (operand1 > -1) Then
                'execute program if second number is greater than 0
                If (operand2 > 0) Then
                    'mod!
                    For counter = operand1 To operand2 Step -operand2
                        endResult = counter - operand2
                    Next counter
                    WriteLine(operand1 & " Mod " & operand2 & " = " & endResult)

                Else
                    'dividing by 0
                    WriteLine(operand1 & " Mod " & operand2 & " = Not a number")
                End If
            End If
        End If
        Console.WriteLine("Good-bye")
        Console.ReadLine()

    End Sub

End Module
