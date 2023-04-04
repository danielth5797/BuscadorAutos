Public Class Form1

    'Inicializamos la clase Buscador para poder cargar el DataGriedView
    Public Buscador As Buscador = New Buscador()

    Private arMarca = {"Kia", "Mercedes Benz", "Toyota", "Ford"}
    Private arEstilo = {"Sedan", "HatchBack", "SUV", "Pick-Up", "Camioneta"}
    Private arCombustible = {"Gasolina", "Diesel"}
    Private arTransmision = {"Manual", "Automática"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Cargarmos los combo
            'Combo Marca
            cbMarca.Items.AddRange(arMarca)
            cbMarca.SelectedIndex = 0

            'Combo Estilo
            cbEstilo.Items.AddRange(arEstilo)
            cbEstilo.SelectedIndex = 0

            'Combo Combustible
            cbCombustible.Items.AddRange(arCombustible)
            cbCombustible.SelectedIndex = 0

            'Combo Transmision
            cbTransmision.Items.AddRange(arTransmision)
            cbTransmision.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try

            'Obtenemos los valores de los TextBox
            Dim marca = cbMarca.Text
            Dim modelo = txtModelo.Text
            Dim cilindrada = txtCilindrada.Text
            Dim estilo = cbEstilo.Text
            Dim fecha = txtFecha.Text
            Dim precio = txtPrecio.Text
            Dim color = txtColor.Text
            Dim combustible = cbCombustible.Text
            Dim transmision = cbTransmision.Text
            Dim kilometraje = txtKilometraje.Text

            'Todos los campos vuelven a su estado original
            cbMarca.SelectedIndex = 0
            txtModelo.Clear()
            txtCilindrada.Clear()
            cbEstilo.SelectedIndex = 0
            txtFecha.Clear()
            txtPrecio.Clear()
            txtColor.Clear()
            cbCombustible.SelectedIndex = 0
            cbTransmision.SelectedIndex = 0
            txtKilometraje.Clear()

            'Validamos si hay algun campo vacio
            If String.IsNullOrEmpty(marca) Or String.IsNullOrEmpty(modelo) Or String.IsNullOrEmpty(cilindrada) Or String.IsNullOrEmpty(precio) Or String.IsNullOrEmpty(color) Or String.IsNullOrEmpty(kilometraje) Then
                MessageBox.Show("Debe llenar todos los espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else 'Si no hay ningun campo vacio

                'Una vez llenado los campos, vamos a crear un objeto Auto para el auto agregado y llenar cada atributo
                Dim objAuto As New Auto
                objAuto.marca = marca
                objAuto.modelo = modelo
                objAuto.cilindrada = cilindrada
                objAuto.estilo = estilo
                objAuto.fecha = fecha
                objAuto.precio = precio
                objAuto.color = color
                objAuto.combustible = combustible
                objAuto.transmision = transmision
                objAuto.kilometraje = kilometraje

                'Una vez llenado los atributos de Auto, vamos a agregar al objeto a la lista tipo Auto
                listaAuto.Add(objAuto)

                MessageBox.Show("Se agregó el auto exitosamente")

                'Llenamos el DataGridView
                Buscador.cargarData()

            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
