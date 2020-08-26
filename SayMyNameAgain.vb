'Ian Gunter
'RCET0265
'Spring 2020
'Say My Name Again
'https://github.com/IanGunter/SayMyNameAgain.git

Option Explicit On
Option Strict On

Module SayMyNameAgain

    Sub Main()
        'Dim assigns the next work to whatever As is set as. 
        Dim Input As String
        Console.WriteLine("What Is your name")
        Input = Console.ReadLine()
        If Input = "Emily" Then Console.WriteLine("Wow " & Input & "! Thats an awesome name!")
        If Input = "Joe" Then Console.WriteLine("Wow " & Input & "! Thats an awesome name!")
        If Input = "Ian" Then Console.WriteLine("Oh, I've heard of you! " & Input & " The G!! What a pleasure to meet you.")
        Console.ReadLine()

    End Sub

End Module
