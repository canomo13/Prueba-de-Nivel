Option Strict Off
Option Explicit On

Public Class Main

    Private Sub obtenerdatos()

        Dim term_name As String = Nothing
        Dim term_desc As String= Nothing
        Dim fab_name As String= Nothing
        Dim state_name As String= Nothing
        Dim fab_date As Date= Nothing
        Dim state_date As Date= Nothing


        LogicalDatabase.OpenDatabase()

        Console.WriteLine("Put the terminal id that you looking for: ")

        Dim id_term as Integer = Console.ReadLine()
        Try
            
            LogicalDatabase.Getdata(id_term, term_name, term_desc, fab_name, state_name, fab_date, state_date)
            Console.WriteLine("Los datos son de la terminal: " & id_term)
            Console.WriteLine("Nombre del Terminal: " & term_name)
            Console.WriteLine("Descripcion del Terminal: " & term_desc)
            Console.WriteLine("Nombre del fabricante: " & fab_name)
            Console.WriteLine("Nombre del estado: " & state_name)
            Console.WriteLine("Fecha de fabricacion: " & fab_date)
            Console.WriteLine("Fecha de estado: " & state_date)
           
        Catch ex As Exception
            Console.WriteLine("No se encuentra la terminal" & ex.Message)
        End Try
        
         
        
    End Sub
    
