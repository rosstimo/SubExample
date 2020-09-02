Module SubExample



    Sub Main()
        Dim x As Integer
        Dim y As Integer
        ''this code runs at start up
        Console.WriteLine("In Sub Main")

        ''Call the example Sub
        'ASubExample()

        'Console.WriteLine("Back In Sub Main")

        'SubWithArguments("Secret code")

        x = 5I
        y = 3I
        Console.WriteLine(x)

        Console.ReadLine()
        VariableScope()
        Console.WriteLine("Back In Sub Main")
        Console.WriteLine(x)
        Console.ReadLine()
    End Sub

    Sub ASubExample()
        'This code only runs when it is "called"
        Console.WriteLine("In Sub ASubExample")
        Console.ReadLine()
    End Sub

    Sub SubWithArguments(message As String)

        Console.WriteLine(message)

    End Sub

    Sub VariableScope()
        Dim x As Integer
        Console.WriteLine("In Sub VariableScope")

        x = 7I
        'y = 3I
        Console.WriteLine(x)

        Console.ReadLine()

    End Sub


End Module
