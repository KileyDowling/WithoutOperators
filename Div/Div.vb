
Option Strict On
Imports System.Console

Module Div

    Sub Main()
        Dim soperand1 As String = ""
        Dim soperand2 As String = ""

        Dim operand1 As Double = 0
        Dim operand2 As Double = 0
        Dim counter As Double = 0

        Dim endResult As Double = 0

        WriteLine("Let's divide! Equation: operand1 / operand2 = endResult")

        'request number from user
        soperand1 = InputBox("Please enter a positive number")
        operand1 = Val(soperand1)
        WriteLine("Operand1: " & operand1)

        soperand2 = InputBox("Please enter a second positive number")
        operand2 = Val(soperand2)
        WriteLine("Operand2: " & operand2)

        'check if valid input
        If (operand1 <= -1) Then
            soperand1 = InputBox("Number Invalid! Please enter a positive number")
            operand1 = Val(soperand1)
            WriteLine("New Operand1: " & operand1)
        End If

        If (operand2 <= -1) Then
            soperand2 = InputBox("Number Invalid! Please enter a second positive number")
            operand2 = Val(soperand2)
            WriteLine("New Operand2: " & operand2)
        End If

        If (operand1 <= -1 Or operand2 <= -1) Then
            WriteLine("ERROR. For operand1, you entered: " & operand1 & ". For operand2, you entered: " & operand2 & ". You did not provide a valid input. Program end.")
        End If

        'execute program if first number is greater than -1
        If (operand1 > -1) Then
            'execute program if second number is greater than 0
            If (operand2 > 0) Then
                'execute programa as long as operand2 is less than or equal to operand1, or if operand1 is 0
                If (operand2 <= operand1 Or operand1 = 0) Then
                    'divide!
                    For counter = operand1 To operand2 Step -operand2
                        endResult += 1
                    Next counter
                    WriteLine(operand1 & " / " & operand2 & " = " & endResult)
                Else
                    'operand2 is greater than operand1 and would return a decimal
                    WriteLine("This program is unable to return decimals")

                End If
            Else
                'dividing by 0
                WriteLine(operand1 & " / " & operand2 & " = Not a number")
            End If
        End If

        Console.ReadLine()

    End Sub

End Module