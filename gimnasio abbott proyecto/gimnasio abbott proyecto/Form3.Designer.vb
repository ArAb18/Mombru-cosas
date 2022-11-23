<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.DGV_GYM = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_semana = New System.Windows.Forms.TextBox()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.txt_reps = New System.Windows.Forms.TextBox()
        Me.txt_ejercicio = New System.Windows.Forms.TextBox()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGV_GYM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_GYM
        '
        Me.DGV_GYM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_GYM.Location = New System.Drawing.Point(441, 149)
        Me.DGV_GYM.Name = "DGV_GYM"
        Me.DGV_GYM.Size = New System.Drawing.Size(318, 204)
        Me.DGV_GYM.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GIMNASIO"
        '
        'txt_semana
        '
        Me.txt_semana.Location = New System.Drawing.Point(178, 273)
        Me.txt_semana.Name = "txt_semana"
        Me.txt_semana.Size = New System.Drawing.Size(100, 20)
        Me.txt_semana.TabIndex = 19
        Me.txt_semana.Text = "-"
        '
        'txt_peso
        '
        Me.txt_peso.Location = New System.Drawing.Point(178, 236)
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(100, 20)
        Me.txt_peso.TabIndex = 18
        '
        'txt_reps
        '
        Me.txt_reps.Location = New System.Drawing.Point(178, 191)
        Me.txt_reps.Name = "txt_reps"
        Me.txt_reps.Size = New System.Drawing.Size(100, 20)
        Me.txt_reps.TabIndex = 17
        '
        'txt_ejercicio
        '
        Me.txt_ejercicio.Location = New System.Drawing.Point(178, 149)
        Me.txt_ejercicio.Name = "txt_ejercicio"
        Me.txt_ejercicio.Size = New System.Drawing.Size(100, 20)
        Me.txt_ejercicio.TabIndex = 16
        '
        'btn_insertar
        '
        Me.btn_insertar.Location = New System.Drawing.Point(79, 334)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(127, 43)
        Me.btn_insertar.TabIndex = 15
        Me.btn_insertar.Text = "Insertar Datos"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "SEMANA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "PESO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "REPETICIONES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "EJERCICIO"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_semana)
        Me.Controls.Add(Me.txt_peso)
        Me.Controls.Add(Me.txt_reps)
        Me.Controls.Add(Me.txt_ejercicio)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_GYM)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DGV_GYM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_GYM As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_semana As TextBox
    Friend WithEvents txt_peso As TextBox
    Friend WithEvents txt_reps As TextBox
    Friend WithEvents txt_ejercicio As TextBox
    Friend WithEvents btn_insertar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
