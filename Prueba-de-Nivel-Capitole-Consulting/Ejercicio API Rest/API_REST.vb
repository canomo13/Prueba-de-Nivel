Imports System.Data.OleDb

Public Class LogicadeBasededatos

Public gConnection as String 
    Private conn As New OleDbConnection(gConnection)
    Private cmd As New OleDbCommand
    Private transaction As OleDbTransaction

    Public Sub New()
        cmd.Connection = conn
    End Sub

    Public Sub ConnectionEstablish()
        conn = New OleDbConnection(gConnection)
        cmd.Connection = conn
    End Sub

    Public Function StateConnection() As Integer
        Return conn.State
    End Function

    Public Function OpenDatabase() As Boolean
        OpenDatabase = False
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            OpenDatabase = True
        End If
    End Function

    Public Function CloseDatabase() As Boolean
        CloseDatabase = False
        If conn.State <> ConnectionState.Closed Then
            conn.Close()
            CloseDatabase = True
        End If
    End Function

    Public Function transactionIni() As Boolean
        transactionIni = False
        transaction = conn.BeginTransaction()
        cmd.Transaction = transaction
        transactionIni = True
    End Function

    Public Sub transactionEndOK()
        If Not IsNothing(transaction) Then
            transaction.Commit()
    End Sub

    Public Sub Getdatos(ByVal id_terminal As Integer, ByRef nombre_term as String, ByRef desc_term as String, ByRef nombre_fab as String, ByRef nombre_estado as String, ByRef fecha_estado as String, ByRef fecha_fabricacion as String )
        
        Dim linea As OleDbDataReader = Nothing

        Try

            cmd.CommandText = "SELECT T.terminal_name, T.terminal_desc, F.fab_name, E.estado_name, T.fecha_fabricacion, T.fecha_estado  " & _
                              "FROM terminales as T, estado as E, fabricantes as F " & _
                              "WHERE T.id_terminal = '" & id_terminal

            linea = cmd.ExecuteReader
            if linea.HasRow Then
                linea.Read()
                nombre_term = linea("T.terminal_name")
                desc_term = linea("T.terminal_desc")
                nombre_fab = linea("F.fab_name")
                nombre_estado = linea("E.estado_name")
                fecha_fabricacion = linea("T.fecha_fabricacion")
                fecha_estado = linea("T.fecha_estado")

        Catch ex As Exception
            cmd.Console.WriteLine("Error")
        End Try

    End Sub

End Class
