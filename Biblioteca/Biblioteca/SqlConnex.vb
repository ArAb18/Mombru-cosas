Imports MySql.Data.MySqlClient

Public Class SqlConnex

    Private miConexion As New MySqlConnection
    Public miComando As New MySqlCommand
    Public Conexion_Error As String
    Public MiDataAdapter As New MySqlDataAdapter
    Public MiDataSet As New DataSet




    Public Sub New(Nombre As String) 'Método Constructor

        'Consultar "connectionstring.com" para verificar cadena de conexión

        Try 'Inicia bloque para captura de excepciones

            miConexion.ConnectionString = "Server=localhost;Database=biblioteca;Uid=root;Pwd=Joacolol2004;"

            miConexion.Open() 'Abre la conexión

            miComando.Connection = miConexion 'Establece la conexión donde se ejecutarán los comandos

            Conexion_Error = "" 'Limpia el String de error

        Catch ex As Exception 'Captura el error, si lo hubiera

            Conexion_Error = ex.Message

        End Try

    End Sub



    Public Sub EjecutarSQL(SentenciaSQL As String) 'Ejecuta un comando SQL

        miComando.CommandText = SentenciaSQL 'Copia el parámetro al texto del comando

        miComando.ExecuteNonQuery() 'Ejecuta el comando

    End Sub



    Public Sub Dispose() 'Libera la memoria usada, cierra la conexion

        miConexion.Close() 'Cierra la conexión con la BDD

        miConexion.Dispose()

        miComando.Dispose()

    End Sub

End Class

