Module GlobalVariables

    Public gDatabasePath As String = Application.StartupPath.ToString & "\"
    Public gDataBaseName As String = "Prueba.accdb"
    Public gConnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & gDatabasePath & gDataBaseName & ";Jet OLEDB:Database"

End Module