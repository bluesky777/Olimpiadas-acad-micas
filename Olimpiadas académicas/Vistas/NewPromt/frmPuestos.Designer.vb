<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPuestos
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
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbEntidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbPuntaje = New System.Windows.Forms.Label()
        Me.lbTiempo = New System.Windows.Forms.Label()
        Me.PicturePrimerPuesto = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PicturePrimerPuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbTitulo.Font = New System.Drawing.Font("Leelawadee", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.White
        Me.lbTitulo.Location = New System.Drawing.Point(166, 38)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(360, 32)
        Me.lbTitulo.TabIndex = 3
        Me.lbTitulo.Text = "1º Lugar de Matemáticas A"
        '
        'lbNombre
        '
        Me.lbNombre.BackColor = System.Drawing.Color.Yellow
        Me.lbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbNombre.Font = New System.Drawing.Font("Lucida Calligraphy", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.Color.Black
        Me.lbNombre.Location = New System.Drawing.Point(-1, 230)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(800, 82)
        Me.lbNombre.TabIndex = 4
        Me.lbNombre.Text = "Ratón Pérez Escobar"
        Me.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbEntidad
        '
        Me.lbEntidad.BackColor = System.Drawing.Color.Transparent
        Me.lbEntidad.Font = New System.Drawing.Font("Leelawadee", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEntidad.ForeColor = System.Drawing.Color.White
        Me.lbEntidad.Location = New System.Drawing.Point(-1, 328)
        Me.lbEntidad.Name = "lbEntidad"
        Me.lbEntidad.Size = New System.Drawing.Size(800, 31)
        Me.lbEntidad.TabIndex = 5
        Me.lbEntidad.Text = "Disneylandia Entertainment"
        Me.lbEntidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Puntaje:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Leelawadee", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 433)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tiempo:"
        '
        'lbPuntaje
        '
        Me.lbPuntaje.AutoSize = True
        Me.lbPuntaje.BackColor = System.Drawing.Color.Transparent
        Me.lbPuntaje.Font = New System.Drawing.Font("Lucida Calligraphy", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPuntaje.ForeColor = System.Drawing.Color.Yellow
        Me.lbPuntaje.Location = New System.Drawing.Point(154, 392)
        Me.lbPuntaje.Name = "lbPuntaje"
        Me.lbPuntaje.Size = New System.Drawing.Size(102, 41)
        Me.lbPuntaje.TabIndex = 8
        Me.lbPuntaje.Text = "100%"
        '
        'lbTiempo
        '
        Me.lbTiempo.AutoSize = True
        Me.lbTiempo.BackColor = System.Drawing.Color.Transparent
        Me.lbTiempo.Font = New System.Drawing.Font("Lucida Calligraphy", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTiempo.ForeColor = System.Drawing.Color.White
        Me.lbTiempo.Location = New System.Drawing.Point(155, 433)
        Me.lbTiempo.Name = "lbTiempo"
        Me.lbTiempo.Size = New System.Drawing.Size(84, 31)
        Me.lbTiempo.TabIndex = 9
        Me.lbTiempo.Text = "00:01"
        '
        'PicturePrimerPuesto
        '
        Me.PicturePrimerPuesto.Image = Global.Olimpiadas_académicas.My.Resources.Resources.winner1
        Me.PicturePrimerPuesto.Location = New System.Drawing.Point(500, -22)
        Me.PicturePrimerPuesto.Name = "PicturePrimerPuesto"
        Me.PicturePrimerPuesto.Size = New System.Drawing.Size(299, 286)
        Me.PicturePrimerPuesto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicturePrimerPuesto.TabIndex = 11
        Me.PicturePrimerPuesto.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Olimpiadas_académicas.My.Resources.Resources.copa
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 209)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frmPuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(787, 561)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbTiempo)
        Me.Controls.Add(Me.lbPuntaje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbEntidad)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbTitulo)
        Me.Controls.Add(Me.PicturePrimerPuesto)
        Me.Name = "frmPuestos"
        Me.Text = "frmPuestos"
        CType(Me.PicturePrimerPuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbTitulo As System.Windows.Forms.Label
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbEntidad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbPuntaje As System.Windows.Forms.Label
    Friend WithEvents lbTiempo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PicturePrimerPuesto As System.Windows.Forms.PictureBox
End Class
