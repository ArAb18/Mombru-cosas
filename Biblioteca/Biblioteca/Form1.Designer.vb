<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVlibro = New System.Windows.Forms.DataGridView()
        Me.txt_genero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_autor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_editorial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVlibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(72, 364)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 2
        Me.btn_Agregar.Text = "Agregar libro"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(335, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Biblioteca"
        '
        'DGVlibro
        '
        Me.DGVlibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVlibro.Location = New System.Drawing.Point(319, 115)
        Me.DGVlibro.Name = "DGVlibro"
        Me.DGVlibro.Size = New System.Drawing.Size(448, 244)
        Me.DGVlibro.TabIndex = 4
        '
        'txt_genero
        '
        Me.txt_genero.Location = New System.Drawing.Point(67, 171)
        Me.txt_genero.Name = "txt_genero"
        Me.txt_genero.Size = New System.Drawing.Size(100, 20)
        Me.txt_genero.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Genero"
        '
        'txt_autor
        '
        Me.txt_autor.Location = New System.Drawing.Point(67, 246)
        Me.txt_autor.Name = "txt_autor"
        Me.txt_autor.Size = New System.Drawing.Size(100, 20)
        Me.txt_autor.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Autor"
        '
        'txt_editorial
        '
        Me.txt_editorial.Location = New System.Drawing.Point(67, 285)
        Me.txt_editorial.Name = "txt_editorial"
        Me.txt_editorial.Size = New System.Drawing.Size(100, 20)
        Me.txt_editorial.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Editorial"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(67, 207)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "nombre"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_editorial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_autor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_genero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGVlibro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGVlibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVlibro As DataGridView
    Friend WithEvents txt_genero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_autor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_editorial As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label1 As Label
End Class
