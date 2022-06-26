Public Class Main

    Private Sub obtenerdatos()

        Dim nombre_term As String = Nothing
        Dim desc_term As String= Nothing
        Dim nombre_fab As String= Nothing
        Dim nombre_estado As String= Nothing
        Dim fecha_fabricacion As Date= Nothing
        Dim fecha_estado As Date= Nothing


        LogicadeBasededatos.OpenDatabase()

        Console.WriteLine("Introduzca la terminal que busca")

        Dim id_term as Integer = Console.ReadLine()
        Try
            
            LogicadeBasededatos.Getdatos(id_term, nombre_term, desc_term, nombre_fab, nombre_estado, fecha_fabricacion, fecha_estado)
            Console.WriteLine("Los datos son de la terminal: " & id_term)
            Console.WriteLine("Nombre del Terminal: " & nombre_term)
            Console.WriteLine("Descripcion del Terminal: " & desc_term)
            Console.WriteLine("Nombre del fabricante: " & nombre_fab)
            Console.WriteLine("Nombre del estado: " & nombre_estado)
            Console.WriteLine("Fecha de fabricacion: " & fecha_fabricacion)
            Console.WriteLine("Fecha de estado: " & fecha_estado)
           
        Catch ex As Exception
            Console.WriteLine("No se encuentra la terminal" & ex.Message)
        End Try
        
         
        
    End Sub
    
