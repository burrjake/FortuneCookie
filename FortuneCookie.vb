'Jake Burrell
'RCET0265
'Fall 2020
'Fortune Cookie
'https://github.com/burrjake/FortuneCookie.git

Option Strict On
Option Explicit On
Option Compare Text

Module FortuneCookie

    Sub Main()
        Dim randomNumber As Integer
        Dim quitProgram As Boolean

        quitProgram = False

        'greet user and tell program name
        Console.WriteLine("Welcome to Fortune Cookie.")

        Do While quitProgram = False

            'prompt user to continue by pressing enter
            Console.WriteLine("Press enter to receive a fortune or wisdom.")
            Console.ReadLine()

            'generate random number
            Randomize()
            randomNumber = CInt(Int((Rnd() * 6) + 1))

            'give a fortune based on what random number was generated
            If randomNumber = 1 Then
                Console.WriteLine("A good time to finish up old tasks.")
            ElseIf randomNumber = 2 Then
                Console.WriteLine("A hunch is creativity trying to tell you something.")
            ElseIf randomNumber = 3 Then
                Console.WriteLine("A lifetime of happiness lies ahead of you.")
            ElseIf randomNumber = 4 Then
                Console.WriteLine("A light heart carries you through all the hard times.")
            ElseIf randomNumber = 5 Then
                Console.WriteLine("Accept something that you cannot change, and you will feel better.")
            ElseIf randomNumber = 6 Then
                Console.WriteLine("All will go well with your new project.")
            Else
                Console.WriteLine("A person of words and not deeds is like a garden full of weeds.")
            End If

            'prompt user either or not they want to quit
            Console.WriteLine("Press Enter to run, again. Enter Q to quit")
            'if q is entered stop loop and close program
            If Console.ReadLine() = "q" Then
                quitProgram = True
                'if q is not entered clear text and continue program loop
            Else
                quitProgram = False
            End If
            Console.Clear()
        Loop
    End Sub

End Module
