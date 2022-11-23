Public Class Form1
    Dim conex As SqlConnex

    Sub Actualizar()
        conex = New SqlConnex("biblioteca")
        Try
            conex.EjecutarSQL("SELECT * FROM libro")
            conex.MiDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(conex.miComando)
            conex.MiDataAdapter.Fill(conex.MiDataSet)
            DGVLibro.DataSource = conex.MiDataSet.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox("error")
        End Try


    End Sub

    Sub Rellenar()
        txt_genero.Text = DGVlibro.CurrentRow.Cells(1).Value
        txt_nombre.Text = DGVlibro.CurrentRow.Cells(3).Value
        txt_editorial.Text = DGVlibro.CurrentRow.Cells(4).Value
        txt_autor.Text = DGVlibro.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim conex As New SqlConnex("biblioteca")

        Try
            sql = " USE biblioteca; "
            conex.EjecutarSQL(sql)
            MsgBox("Conexion exitosa")
            Actualizar()
            conex.Dispose()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Dim sql As String
        Dim conex As New SqlConnex("biblioteca")
        Try
            sql = $"INSERT INTO libro (genero_libro, nombre, editorial, autor)
                   VALUES ( '{txt_genero.Text}','{txt_nombre.Text}', '{txt_editorial.Text}', '{txt_autor.Text}');"
            conex.EjecutarSQL(sql)
            MsgBox("Inserción exitosa")
            Actualizar()

        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub


End Class
