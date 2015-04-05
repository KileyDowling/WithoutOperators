Option Strict On
Imports System.Console
Module Square

    Sub Main()
        Dim soperand1 As String = ""

        Dim operand1 As Double = 0
        Dim counter As Double = 0

        Dim endResult As Double = 0

        WriteLine("Let's square stuff! Equation: operand1 ^ 2 = endResult")

        'request number from user
        soperand1 = InputBox("Please enter a positive number")
        operand1 = Val(soperand1)
        WriteLine("Operand1: " & operand1)

        'check if valid input
        If (operand1 <= -1) Then
            soperand1 = InputBox("Number Invalid! Please enter a positive number")
            operand1 = Val(soperand1)
            WriteLine("New Operand1: " & operand1)
            'second change
            If (operand1 <= -1) Then
                WriteLine("ERROR. For operand1, you entered: " & operand1 & ". You did not provide a valid input. Program end.")
            End If
        End If

        'execute program if number is greater than -1
        If (operand1 > -1) Then
            'Square up
            counter = operand1
            While (counter > 0)
                endResult = endResult + operand1
                counter -= 1
            End While
            WriteLine(operand1 & " ^ 2 = " & endResult)
        End If

        Console.ReadLine()

    End Sub

End Module
