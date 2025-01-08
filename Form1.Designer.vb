<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtVentas = New System.Windows.Forms.TextBox()
        Me.txtMarkenting = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregarNombre1 = New System.Windows.Forms.Button()
        Me.btnAgregarNombre2 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtVentas
        '
        Me.txtVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVentas.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentas.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtVentas.Location = New System.Drawing.Point(12, 51)
        Me.txtVentas.Multiline = True
        Me.txtVentas.Name = "txtVentas"
        Me.txtVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVentas.Size = New System.Drawing.Size(332, 219)
        Me.txtVentas.TabIndex = 0
        '
        'txtMarkenting
        '
        Me.txtMarkenting.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMarkenting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMarkenting.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarkenting.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtMarkenting.Location = New System.Drawing.Point(375, 51)
        Me.txtMarkenting.Multiline = True
        Me.txtMarkenting.Name = "txtMarkenting"
        Me.txtMarkenting.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMarkenting.Size = New System.Drawing.Size(332, 219)
        Me.txtMarkenting.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ventas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(371, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Marketing"
        '
        'btnAgregarNombre1
        '
        Me.btnAgregarNombre1.BackColor = System.Drawing.Color.IndianRed
        Me.btnAgregarNombre1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregarNombre1.ForeColor = System.Drawing.Color.White
        Me.btnAgregarNombre1.Location = New System.Drawing.Point(83, 276)
        Me.btnAgregarNombre1.Name = "btnAgregarNombre1"
        Me.btnAgregarNombre1.Size = New System.Drawing.Size(162, 52)
        Me.btnAgregarNombre1.TabIndex = 4
        Me.btnAgregarNombre1.Text = "Agregar Nombre"
        Me.btnAgregarNombre1.UseVisualStyleBackColor = False
        '
        'btnAgregarNombre2
        '
        Me.btnAgregarNombre2.BackColor = System.Drawing.Color.IndianRed
        Me.btnAgregarNombre2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregarNombre2.ForeColor = System.Drawing.Color.White
        Me.btnAgregarNombre2.Location = New System.Drawing.Point(450, 276)
        Me.btnAgregarNombre2.Name = "btnAgregarNombre2"
        Me.btnAgregarNombre2.Size = New System.Drawing.Size(162, 52)
        Me.btnAgregarNombre2.TabIndex = 5
        Me.btnAgregarNombre2.Text = "Agregar Nombre"
        Me.btnAgregarNombre2.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.IndianRed
        Me.btnSalir.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(269, 334)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(162, 52)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(726, 414)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregarNombre2)
        Me.Controls.Add(Me.btnAgregarNombre1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMarkenting)
        Me.Controls.Add(Me.txtVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Asignacion de empleados por departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVentas As TextBox
    Friend WithEvents txtMarkenting As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregarNombre1 As Button
    Friend WithEvents btnAgregarNombre2 As Button
    Friend WithEvents btnSalir As Button
End Class
