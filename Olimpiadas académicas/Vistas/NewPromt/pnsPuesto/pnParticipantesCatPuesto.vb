Public Class pnParticipantesCatPuesto
    Inherits Panel

    Public Participantes As New List(Of clsDatosDeUnCliente)
    Public panelesParticipantes As New List(Of pnParticipantePuest)
    Dim distanciaVPart As Integer = 72
    Public idCategoria As Integer
    Dim frmPuest As frmPuestos
    Public lbTituloCategoria As New Label

    Dim xspace As Integer = 10
    Dim yspace As Integer = 10
    Public AnchoElemento As Integer = 210
    Public AlturaElemento As Integer = 70
    Dim alturaTitulo As Integer = 40


    Sub New(ByRef frmPuest As frmPuestos)
        Me.frmPuest = frmPuest
        Me.Height = frmPuest.Height - 20
    End Sub

    Public Sub mostrarParticipantes()


        'Averiguaré en donde pondré el siguiente panel. Para ello, averiguaré cuantos pnParticipantes hay
        Dim AnchoPaneles As Integer = 10 ' Inicia en diez para que el primero no golpee el borde del form
        For Each pnPart As pnParticipantesCatPuesto In Me.frmPuest.Controls
            AnchoPaneles += pnPart.Width + 10
        Next

        ' La posición será lo que miden todos los pnResultado mas una distancia entre sí
        Me.Left = AnchoPaneles

        Me.frmPuest.Controls.Add(Me)



        Dim m_categ As New modCategoria
        Dim categ As String = m_categ.getCampoRaw(Participantes(0).idCategoria, "CatNombre")

        lbTituloCategoria.AutoSize = True
        Me.lbTituloCategoria.Text = categ
        lbTituloCategoria.Font = New Font("Arial", 20, FontStyle.Bold)
        'lbTituloCategoria.Height = 35
        lbTituloCategoria.ForeColor = Color.White
        lbTituloCategoria.Top = 0
        lbTituloCategoria.Left = 2
        'MsgBox("width/2: " & (Me.Width / 2) & " - lbTituloCategoria.Width/2: " & lbTituloCategoria.Width / 2 & "  -  lbTituloCategoria.Left: " & lbTituloCategoria.Left)
        Me.Controls.Add(lbTituloCategoria)

    End Sub


    Sub CrearPanelesParticiantes()
        Try
            Me.lbTituloCategoria.Text = Participantes(0).Categoria
        Catch ex As Exception

        End Try


        ' Quito los paneles agregados
        Me.panelesParticipantes.Clear()

        For Each Parti As clsDatosDeUnCliente In Me.Participantes

            ' Creo el panel de un particpante, le doy posición y lo agrego al panel de la categoría (me)
            Dim pnDatosParticipante As New pnParticipantePuest(Parti, Me)
            Me.panelesParticipantes.Add(pnDatosParticipante)
        Next

    End Sub


End Class





Public Class pnParticipantePuest
    Inherits Panel


    Dim lbNombre As New Label
    Dim lbEntidad As New Label
    Dim lbPuntaje As New Label


    Sub New(ByRef datosParticipante As clsDatosDeUnCliente, ByRef pnParent As pnParticipantesCatPuesto)

        Me.Width = pnParent.AnchoElemento
        Me.Height = pnParent.AlturaElemento


        If pnParent.HorizontalScroll.Visible = True Then
            pnParent.Width = Me.Width + 20
        Else
            'pnParent.Width = Me.Width + 5
        End If



        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle

        With Me.lbPuntaje
            .Width = 60
            .Text = datosParticipante.PregCorrectas
            .Top = 2
            .Left = Me.Width - Me.Width - 1
            .Font = New Font("Arial", 20, FontStyle.Bold)
            .Height = 50
            .TextAlign = ContentAlignment.MiddleCenter
            .BackColor = Color.Blue
            .ForeColor = Color.White
            .Visible = False
        End With


        With Me.lbNombre
            .Text = datosParticipante.Nombre
            .Top = 2
            .Left = 2
            .Font = New Font("Arial", 22)
            '.Width = Me.Width - 4

            .AutoSize = True
            '.Height = 40
            .TextAlign = ContentAlignment.MiddleCenter
            .ForeColor = Color.White
        End With

        With Me.lbEntidad
            .Text = datosParticipante.Entidad
            .Top = Me.lbNombre.Height + Me.lbNombre.Top + 10
            .Left = Me.lbNombre.Left
            .Font = New Font("Arial", 15, FontStyle.Italic)
            '.Width = Me.lbNombre.Width
            '.Height = Me.Height / 2 - 20
            .AutoSize = True
            .TextAlign = ContentAlignment.MiddleCenter
            .ForeColor = Color.White
        End With

        Dim NombreOld As String = datosParticipante.idExamen & datosParticipante.Nombre
        Dim NombreNuevo As String = NombreOld.Replace(" ", Nothing)
        Me.Name = NombreNuevo

        'MsgBox("nombreBox: " & Me.Name & " - top: " & Me.Top & " - left: " & Me.Left)

        Me.Controls.Add(lbPuntaje)
        Me.Controls.Add(lbNombre)
        Me.Controls.Add(lbEntidad)


        Me.BackColor = Color.Black
        lbNombre.ForeColor = Color.White
        lbEntidad.ForeColor = Color.White

    End Sub




End Class
