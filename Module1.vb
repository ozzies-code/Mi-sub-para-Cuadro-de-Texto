Module Module1
    Sub AgregarNombre(ByVal Equipo As String, ByRef CadenaDevuelta As String)
        Dim Pregunta, Nm, WrapCharacter As String
        Pregunta = "Escriba el nombre de un empleado de " & Equipo & "."
        Nm = InputBox(Pregunta, "Cuadro para introduccion de datos")
        WrapCharacter = Chr(13) + Chr(10)
        CadenaDevuelta = Nm & WrapCharacter
        'Rutina que se usa tanto para el equipo de marketing como para el equipo de ventas
    End Sub
End Module
