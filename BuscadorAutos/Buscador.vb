Imports System.IO

Public Class Buscador

    Private Sub btnAgregarAuto_Click(sender As Object, e As EventArgs) Handles btnAgregarAuto.Click
        Form1.Show()
    End Sub


    'Vamos a crear la funci'on para cargar el DataGriedView
    Public Sub cargarData()

        Try

            Dim tablaAutos As New DataTable

            tablaAutos.Columns.Add("Marca")
            tablaAutos.Columns.Add("Modelo")
            tablaAutos.Columns.Add("Cilindrada")
            tablaAutos.Columns.Add("Estilo")
            tablaAutos.Columns.Add("Año")
            tablaAutos.Columns.Add("Precio")
            tablaAutos.Columns.Add("Color")
            tablaAutos.Columns.Add("Combustible")
            tablaAutos.Columns.Add("Transmisión")
            tablaAutos.Columns.Add("Kilometraje")

            'Metemos a la tabla los Autos dentro de la lista de objetos Autos

            If listaAuto.Count > 0 Then

                For Each objAuto As Auto In listaAuto
                    tablaAutos.Rows.Add(objAuto.marca, objAuto.modelo, objAuto.cilindrada, objAuto.estilo, objAuto.fecha, objAuto.precio, objAuto.color, objAuto.combustible, objAuto.transmision, objAuto.kilometraje)
                Next

                'Asignamos los valores al dataGriedView
                dgAutos.DataSource = tablaAutos

            Else
                MessageBox.Show("No hay elementos en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargarData()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try

            If txtMarca.Text <> Nothing And txtFecha.Text <> Nothing Then
                Buscar(txtMarca.Text, txtFecha.Text, 3)
            ElseIf txtMarca.Text <> Nothing Then
                Buscar(txtMarca.Text, txtFecha.Text, 1) 'Buscamos por marca, el banderin lo indica
            ElseIf txtFecha.Text <> Nothing Then
                Buscar(txtMarca, txtFecha.Text, 2) 'Buscamos por marca, el banderin lo indica
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Creamos la funcion buscar
    Public Sub Buscar(a, b, c)

        'Vamos a crear una nueva tabla donde van a entrar los autos que coincidan
        Dim tablaAutosEncontrados As New DataTable

        tablaAutosEncontrados.Columns.Add("Marca")
        tablaAutosEncontrados.Columns.Add("Modelo")
        tablaAutosEncontrados.Columns.Add("Cilindrada")
        tablaAutosEncontrados.Columns.Add("Estilo")
        tablaAutosEncontrados.Columns.Add("Año")
        tablaAutosEncontrados.Columns.Add("Precio")
        tablaAutosEncontrados.Columns.Add("Color")
        tablaAutosEncontrados.Columns.Add("Combustible")
        tablaAutosEncontrados.Columns.Add("Transmisión")
        tablaAutosEncontrados.Columns.Add("Kilometraje")

        'Ahora vamos a recoger cada fila de listaAutos para ver si la marca coincide con el txtMarca

        If listaAuto.Count > 0 Then

            If c = 1 Then 'Buscamos por marca

                For Each objAuto As Auto In listaAuto 'Para cada objeto

                    If a = objAuto.marca Then 'Si coincide txtMarca con la marca del objAuto

                        'Se añade a la tablaAutosEncontrados el auto
                        tablaAutosEncontrados.Rows.Add(objAuto.marca, objAuto.modelo, objAuto.cilindrada, objAuto.estilo, objAuto.fecha, objAuto.precio, objAuto.color, objAuto.combustible, objAuto.transmision, objAuto.kilometraje)

                    End If
                Next

            End If

            If c = 2 Then 'Buscamos por año

                For Each objAuto As Auto In listaAuto 'Para cada objeto

                    If b = objAuto.fecha Then 'Si coincide txtMarca con la marca del objAuto

                        'Se añade a la tablaAutosEncontrados el auto
                        tablaAutosEncontrados.Rows.Add(objAuto.marca, objAuto.modelo, objAuto.cilindrada, objAuto.estilo, objAuto.fecha, objAuto.precio, objAuto.color, objAuto.combustible, objAuto.transmision, objAuto.kilometraje)

                    End If
                Next

            End If

            If c = 3 Then 'Buscamos por Marca y Año

                For Each objAuto As Auto In listaAuto 'Para cada objeto

                    If a = objAuto.marca And b = objAuto.fecha Then 'Si coincide txtMarca y txtFecha con la marca del objAuto

                        'Se añade a la tablaAutosEncontrados el auto
                        tablaAutosEncontrados.Rows.Add(objAuto.marca, objAuto.modelo, objAuto.cilindrada, objAuto.estilo, objAuto.fecha, objAuto.precio, objAuto.color, objAuto.combustible, objAuto.transmision, objAuto.kilometraje)

                    End If
                Next

            End If

            If tablaAutosEncontrados.Rows.Count > 0 Then
                'Ahora los agregamos DataGridView de autos encontrados
                dgBusqueda.DataSource = tablaAutosEncontrados
            Else
                MessageBox.Show("No se encontró ningún auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click

        Try
            'Verificamos que la lista de autos tenga elementos
            If listaAuto.Count > 0 Then
                'Configuramos el dialog
                SaveFileDialog1.Title = "Guardar archivo TXT..."
                SaveFileDialog1.Filter = "TXT|*.txt"

                'se abre el dialogo y consulta si se selecciona una ruta
                If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim urlArchivo = SaveFileDialog1.FileName

                    'instanciar la libreria
                    Dim writer As New StreamWriter(urlArchivo)
                    Dim linea As String

                    For Each objAuto As Auto In listaAuto
                        linea = objAuto.marca & ";" & objAuto.modelo & ";" & objAuto.cilindrada & ";" & objAuto.estilo & ";" & objAuto.fecha & ";" & objAuto.precio & ";" & objAuto.color & ";" & objAuto.combustible & ";" & objAuto.transmision & ";" & objAuto.kilometraje

                        'escribir la linea
                        writer.WriteLine(linea)

                        'es lo mismo que haga esto:
                        'linea = linea & Environment.NewLine
                        'writer.Write(linea)
                    Next

                    'cerrar el archivo
                    writer.Close()

                    'liberar los recursos
                    writer.Dispose()

                    MessageBox.Show("El archivo fue creado exitosamente. URL: " + urlArchivo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            'limpiamos la lista persona
            listaAuto.Clear()

            'configurar el OpenFileDialog
            OpenFileDialog1.Title = "Buscar archivo TXT..."
            OpenFileDialog1.Filter = "Archivo de texto|*.txt"

            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'url archivo
                Dim urlArchivo = OpenFileDialog1.FileName

                'instancia de lectura
                Dim reader As New StreamReader(urlArchivo)

                'recorre el archivo hasta el final (arreglo de strings)
                Do While reader.Peek <> -1
                    'leer la fila
                    Dim linea = reader.ReadLine()

                    'split de la fila
                    Dim arrayLinea = linea.Split(";")

                    'agregar valores al objeto
                    Dim objAuto As New Auto

                    objAuto.marca = arrayLinea(0)
                    objAuto.modelo = arrayLinea(1)
                    objAuto.cilindrada = arrayLinea(2)
                    objAuto.estilo = arrayLinea(3)
                    objAuto.fecha = arrayLinea(4)
                    objAuto.precio = arrayLinea(5)
                    objAuto.color = arrayLinea(6)
                    objAuto.combustible = arrayLinea(7)
                    objAuto.transmision = arrayLinea(8)
                    objAuto.kilometraje = arrayLinea(9)

                    'agrega elementos a la lista
                    listaAuto.Add(objAuto)

                Loop

                'cerrar el archivo
                reader.Close()
                reader.Dispose()

                'cargarTabla
                cargarData()

            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class