Public Class frmPuestos

    Private Sub frmPuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Arreglamos la apariencia del formulario
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.BackColor = Color.Black
        Me.AutoScroll = True

        lbNombre.Width = Me.Width
        lbEntidad.Width = Me.Width

    End Sub


    ' Para buscar todos lo que concuerden
    Dim idCatTemp As Integer
    Public Sub mostrarPuesto(ByRef DatosClientes As List(Of clsDatosDeUnCliente), lugar As Integer)

        DatosClientes.Sort(AddressOf Me.CompareExamenesConTiempo)

        Dim Ganador As New clsDatosDeUnCliente
        Ganador = DatosClientes(lugar - 1)

        Me.lbTitulo.Text = lugar & "º puesto de " & Ganador.Categoria
        Me.lbNombre.Text = Ganador.Nombre
        Me.lbEntidad.Text = Ganador.Entidad
        Me.lbTiempo.Text = Ganador.TiempoExamPuesto.TimeOfDay.ToString.Remove(0, 3) & " min"
        Me.lbPuntaje.Text = Ganador.PuntajeExam & "%"


        If lugar = 1 Then
            With lbNombre
                .BackColor = Color.Yellow
                .ForeColor = Color.Black
            End With

            With PicturePrimerPuesto
                .Visible = True
                .Left = Me.Width - .Width
            End With


        Else
            With lbNombre
                .BackColor = Color.DarkBlue
                    .ForeColor = Color.White
            End With

            PicturePrimerPuesto.Visible = False

        End If

        PictureBox1.Visible = True
        PictureBox1.Top = 0
        PictureBox1.Left = 0
    End Sub



    Private Function CompareExamenesConTiempo(ByVal Datos1 As clsDatosDeUnCliente, ByVal Datos2 As clsDatosDeUnCliente) As Integer
        If Datos1.PuntajeExam = Datos2.PuntajeExam Then
            'MsgBox(Datos1.TiempoExamPuesto & " - 2: " & Datos2.TiempoExamPuesto)
            If Datos1.TiempoExamPuesto = Datos2.TiempoExamPuesto Then
                If Datos1.Nombre = Nothing Then
                    Return 1
                ElseIf Datos2.Nombre = Nothing Then
                    Return 0
                End If
                Return Datos1.Nombre.CompareTo(Datos2.Nombre)
            Else

                Return Datos1.TiempoExamPuesto.CompareTo(Datos2.TiempoExamPuesto)
            End If

        Else
            Return Datos2.PuntajeExam.CompareTo(Datos1.PuntajeExam)
        End If

    End Function




End Class