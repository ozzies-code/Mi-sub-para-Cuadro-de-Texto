# Mi sub para Cuadro de Texto

 Este proyecto consiste en demostrar el uso de Modulos, 
 Rutinas, y variables pasadas como valor (ByVal) y como referencia(ByRef) 
 cuando se devuelve la llamada al procedimiento que invoco la rutina

# Descripcion

 Este proyecto consiste en una aplicacion que emplea
 una rutina que sirve tanto para un equipo de ventas
 como para un equipo de marketing, para construir 
 una liosta de ambos equipos por separado haciendo 
 uso de una rutina construida en un modulo que esta disponible
 para todos los procedimientos de eventos que la llamen.
 La rutina se compone de una variable que es pasada como 
 valor (ByVal), la cual no cambiara o no devolvera una 
 copia actualizada al procedimiento que invoco la rutina
 y una variable pasada como referencia (ByRef) que si 
 se actualizara y enviara una copia del nuevo valor en memoria 
 al procedimiento que invoco la rutina.
 se cierra el programa.
 
 # Actualizacion: 07/01/2025
 # Hora: 21:53

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# My sub for Text Box

This project consists of demonstrating the use of Modules,
Routines, and variables passed as a value (ByVal) and as a reference (ByRef)
when the call to the procedure that called the routine is returned

# Description

This project consists of an application that uses
a routine that serves both a sales team and a
marketing team, to build a list of both teams 
separately using a routine built in a module that is available
to all event procedures that call it. The routine consists 
of a variable that is passed as a value (ByVal), which will not 
change or return an updated copy to the procedure that called 
the routine, and a variable passed as a reference (ByRef) that will
be updated and send a copy of the new value in memory to the
procedure that called the routine.
The program closes.

# Update: 01/07/2025
# Time: 21:53

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/228fc014-3d78-4e64-950f-74e4e2a553e2)

Code of the Project:

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

Public Class Form1
    Private Sub btnAgregarNombre1_Click(sender As Object, e As EventArgs) Handles btnAgregarNombre1.Click
        'Procedimiento de Evento

        Dim PuestoVentas As String = ""
        AgregarNombre("Ventas", PuestoVentas)
        txtVentas.Text = txtVentas.Text & PuestoVentas

    End Sub

    Private Sub btnAgregarNombre2_Click(sender As Object, e As EventArgs) Handles btnAgregarNombre2.Click
        'Procedimiento de Evento

        Dim PuestoMkt As String = ""
        AgregarNombre("Marketing", PuestoMkt)
        txtMarkenting.Text = txtMarkenting.Text & PuestoMkt
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class

