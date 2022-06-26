Module VBModule
    Sub Main()

        'Pedimos por linea de consola que introduzcan un texto para su inversión
        
        Console.WriteLine("Introduzca texto a invertir")
        
        Dim testString As String = Console.ReadLine()

        'Utilizamos StrReverse para invertir el texto de la variable testString                
        Dim revString As String = StrReverse(testString)
        
        'Devuelve la cadena invertada
        Console.WriteLine(revString)
        
        Console.ReadLine()
    End Sub
End Module