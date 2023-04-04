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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.cbEstilo = New System.Windows.Forms.ComboBox()
        Me.cbCombustible = New System.Windows.Forms.ComboBox()
        Me.cbTransmision = New System.Windows.Forms.ComboBox()
        Me.txtCilindrada = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtKilometraje = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cilindrada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estilo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Año"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio ($)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Color"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(80, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Combustible"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(80, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Transmisión"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(80, 313)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Kilometraje"
        '
        'cbMarca
        '
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(149, 39)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(121, 21)
        Me.cbMarca.TabIndex = 10
        '
        'cbEstilo
        '
        Me.cbEstilo.FormattingEnabled = True
        Me.cbEstilo.Location = New System.Drawing.Point(149, 137)
        Me.cbEstilo.Name = "cbEstilo"
        Me.cbEstilo.Size = New System.Drawing.Size(121, 21)
        Me.cbEstilo.TabIndex = 11
        '
        'cbCombustible
        '
        Me.cbCombustible.FormattingEnabled = True
        Me.cbCombustible.Location = New System.Drawing.Point(150, 255)
        Me.cbCombustible.Name = "cbCombustible"
        Me.cbCombustible.Size = New System.Drawing.Size(121, 21)
        Me.cbCombustible.TabIndex = 13
        '
        'cbTransmision
        '
        Me.cbTransmision.FormattingEnabled = True
        Me.cbTransmision.Location = New System.Drawing.Point(150, 282)
        Me.cbTransmision.Name = "cbTransmision"
        Me.cbTransmision.Size = New System.Drawing.Size(121, 21)
        Me.cbTransmision.TabIndex = 14
        '
        'txtCilindrada
        '
        Me.txtCilindrada.Location = New System.Drawing.Point(150, 102)
        Me.txtCilindrada.Name = "txtCilindrada"
        Me.txtCilindrada.Size = New System.Drawing.Size(120, 20)
        Me.txtCilindrada.TabIndex = 17
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(149, 200)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(121, 20)
        Me.txtPrecio.TabIndex = 18
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(149, 229)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(122, 20)
        Me.txtColor.TabIndex = 19
        '
        'txtKilometraje
        '
        Me.txtKilometraje.Location = New System.Drawing.Point(149, 313)
        Me.txtKilometraje.Name = "txtKilometraje"
        Me.txtKilometraje.Size = New System.Drawing.Size(121, 20)
        Me.txtKilometraje.TabIndex = 20
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(150, 360)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 22
        Me.btnAgregar.Text = "Agregar Auto"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(149, 73)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(121, 20)
        Me.txtModelo.TabIndex = 23
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(149, 168)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(121, 20)
        Me.txtFecha.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 444)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtKilometraje)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtCilindrada)
        Me.Controls.Add(Me.cbTransmision)
        Me.Controls.Add(Me.cbCombustible)
        Me.Controls.Add(Me.cbEstilo)
        Me.Controls.Add(Me.cbMarca)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbMarca As ComboBox
    Friend WithEvents cbEstilo As ComboBox
    Friend WithEvents cbCombustible As ComboBox
    Friend WithEvents cbTransmision As ComboBox
    Friend WithEvents txtCilindrada As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtKilometraje As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtFecha As TextBox
End Class
