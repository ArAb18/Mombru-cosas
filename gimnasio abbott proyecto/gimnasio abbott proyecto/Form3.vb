Public Class Form3
    Dim conex As SqlConnex

    Sub Actualizar()
        conex = New SqlConnex("gimnasio")
        Try
            conex.EjecutarSQL("SELECT * FROM datos")
            conex.MiDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(conex.miComando)
            conex.MiDataAdapter.Fill(conex.MiDataSet)
            DGV_GYM.DataSource = conex.MiDataSet.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox("error")
        End Try


    End Sub

    Sub Rellenar()
        txt_ejercicio.Text = DGV_GYM.CurrentRow.Cells(1).Value
        txt_reps.Text = DGV_GYM.CurrentRow.Cells(3).Value
        txt_peso.Text = DGV_GYM.CurrentRow.Cells(4).Value
        txt_semana.Text = DGV_GYM.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim conex As New SqlConnex("gimnasio")

        Try
            sql = " USE gimnasio; "
            conex.EjecutarSQL(sql)
            MsgBox("Conexion exitosa")
            Actualizar()
            conex.Dispose()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Dim sql As String
        Dim conex As New SqlConnex("gimnasio")
        Try
            sql = $"INSERT INTO datos ( tipo_ejercicio , repeticiones, peso_repeticiones, semana)
                   VALUES ('{txt_ejercicio.Text}', {txt_reps.Text},{txt_peso.Text}, {txt_semana.Text});"
            conex.EjecutarSQL(sql)
            conex.Dispose()
            MsgBox("Inserción exitosa")
            Actualizar()

        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class
