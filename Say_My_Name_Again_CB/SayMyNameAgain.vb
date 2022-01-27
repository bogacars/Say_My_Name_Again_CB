'Carson Bogart
'RCET 0265
'Spring 2022
'Say My name...Again
'https://github.com/bogacars/Say_My_Name_Again_CB.git


Option Explicit On
Option Strict On
Option Compare Text
Module SayMyNameAgain

    Sub Main()
        Dim userResponse As String
        'asks for user input
        Console.WriteLine("Enter your name")
        userResponse = Console.ReadLine()
        'userRespnse will select between the below code
        If userResponse = "Emily" Then
            'if emily is typed then the message will display
            Console.WriteLine("Hello Emily!")
        ElseIf userResponse = "Joe" Then
            'if joe is typed then the message will display
            Console.WriteLine("Howdy Joe!")
        ElseIf userResponse = "Carson" Then
            Console.WriteLine("Hey Carson I was hoping you'd type your name")
            Console.WriteLine("You have a pretty cool name")
            Console.Beep()
        Else
            'will only trigger if none of the above is typed
            Console.WriteLine("Uh oh I'm broke now")
        End If
        'promtps the user how to exit the program
        Console.WriteLine("Press enter to exit")
        Console.ReadLine()
    End Sub

End Module
