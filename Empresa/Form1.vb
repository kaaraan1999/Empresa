Imports System.Data.SQLite
Imports System.Data
Public Class GestionEmpresa
    Private idtrabajadores As Integer
    Private idproveedores As Integer
    Private permisos As Integer
    Private connectionString As String = String.Empty
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionString = String.Format("Data Source=Empresa.db; Version=3")
    End Sub

    'Funcion Comprobar usuario
    Private Function ValidarUsuario(usuario As String, pass As String) As Integer
        Dim esValido As Integer = -1
        Dim infoUsuario As DataRow = Nothing
        Dim sql As String = "SELECT * FROM USUARIOS WHERE Usuario = @usuario"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@usuario", usuario)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoUsuario = dt.Rows(0)
                            If infoUsuario("Pass").Equals(pass) Then
                                If infoUsuario("Permiso") = 0 Then
                                    esValido = 0
                                ElseIf infoUsuario("Permiso") = 1 Then
                                    esValido = 1
                                ElseIf infoUsuario("Permiso") = 2 Then
                                    esValido = 2
                                ElseIf infoUsuario("Permiso") = 3 Then
                                    esValido = 3
                                ElseIf infoUsuario("Permiso") = 4 Then
                                    esValido = 4
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return esValido
    End Function

    'Funcion buscar trabajador
    Private Function BuscarTrabajador(DNI As String) As String
        Dim existe As String = ""
        Dim infoTrabajador As DataRow = Nothing
        Dim sql As String = "SELECT * FROM TRABAJADORES WHERE DNI = @DNI"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@DNI", DNI)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoTrabajador = dt.Rows(0)
                            existe = infoTrabajador("DNI")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return existe
    End Function

    'Funcion buscar datos del trabajador
    Private Function BuscarDatosTrabajador(DNI As String) As ArrayList
        Dim trabajador As New ArrayList
        Dim infoTrabajador As DataRow = Nothing
        Dim sql As String = "SELECT * FROM TRABAJADORES WHERE DNI = @dni"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@dni", DNI)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoTrabajador = dt.Rows(0)
                            trabajador.Add(infoTrabajador("IDTIPOTRABAJADOR"))
                            trabajador.Add(infoTrabajador("NOMBRE"))
                            trabajador.Add(infoTrabajador("APELLIDO"))
                            trabajador.Add(infoTrabajador("EDAD"))
                            trabajador.Add(infoTrabajador("ANYOSTRABAJADOS"))
                            trabajador.Add(infoTrabajador("DNI"))
                            trabajador.Add(infoTrabajador("TELEFONO"))
                            trabajador.Add(infoTrabajador("EMAIL"))
                            trabajador.Add(infoTrabajador("SEXO"))
                            trabajador.Add(infoTrabajador("IDTRABAJADOR"))
                        End If
                    End Using
                End Using
                End Using
        Catch ex As Exception

        End Try
        Return trabajador
    End Function

    'Funcion insertar trabajador
    Private Function Insertar(nombre As String, apellido As String, DNI As String, email As String, tel As String, fechaNac As Date, tipoTrabajador As String, sexo As String) As Boolean
        Dim insertado As Integer
        Dim todaysdate As Date = Now
        Dim anyosTrabajados = 0
        Dim tipo = 0
        Dim edad As Integer = todaysdate.Year - fechaNac.Year
        Dim sql As String = "INSERT INTO TRABAJADORES (IDTIPOTRABAJADOR,NOMBRE,APELLIDO,EDAD,ANYOSTRABAJADOS,DNI,TELEFONO,EMAIL,SEXO) VALUES (@idtipotrabajador,@nombre,@apellido,@edad,@anyostrabajados,@dni,@tel,@email,@sexo)"
        If tipoTrabajador.ToLower.Equals("fijo") Then
            tipo = 1
        ElseIf tipoTrabajador.ToLower.Equals("temporal") Then
            tipo = 2
        ElseIf tipoTrabajador.ToLower.Equals("en practicas") Then
            tipo = 3
        End If

        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idtipotrabajador", tipo)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@edad", edad)
                    cmd.Parameters.AddWithValue("@anyostrabajados", anyosTrabajados)
                    cmd.Parameters.AddWithValue("@dni", DNI)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@tel", tel)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.CommandText = sql
                    conn.Open()
                    Dim ressadded As Integer = cmd.ExecuteNonQuery()
                    insertado = ressadded
                    conn.Close()
                End Using
            End Using
        Catch ex As Exception

        End Try
        If insertado > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Update trabajador
    Private Function modificarTrabajadores(idtrabajador As Integer, tipotrabajador As Integer, nombre As String, apellido As String, DNI As String, email As String, tel As String, edad As Integer, anyostrabajados As Integer, sexo As String) As Boolean
        Dim ejecutado As Boolean = False
        Dim sql As String = "UPDATE TRABAJADORES SET IDTIPOTRABAJADOR=@tipotrabajador,NOMBRE=@nombre,APELLIDO=@apellido,EDAD=@edad,ANYOSTRABAJADOS=@anyostrabajados,DNI=@dni,TELEFONO=@tel,EMAIL=@email,SEXO=@sexo WHERE IDTRABAJADOR=@idtrabajador"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idtrabajador", idtrabajador)
                    cmd.Parameters.AddWithValue("@tipotrabajador", tipotrabajador)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@edad", edad)
                    cmd.Parameters.AddWithValue("@anyostrabajados", anyostrabajados)
                    cmd.Parameters.AddWithValue("@dni", DNI)
                    cmd.Parameters.AddWithValue("@tel", tel)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.CommandText = sql
                    conn.Open()
                    Dim ressadded As Integer = cmd.ExecuteNonQuery()
                    If ressadded > 0 Then
                        ejecutado = True
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return ejecutado
    End Function

    'Baja trabajador
    Private Function eliminarTrabajador(dni As String) As Boolean
        Dim ejecutado As Boolean = False
        Dim sql As String = "DELETE FROM TRABAJADORES WHERE DNI=@dni"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@dni", dni)
                    cmd.CommandText = sql
                    conn.Open()
                    Dim eliminado As Integer = cmd.ExecuteNonQuery()
                    If eliminado > 0 Then
                        ejecutado = True
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return ejecutado
    End Function

    'Insertar proveedor
    Private Function InsertarProveedor(nombreEmpresa As String, nombre As String, apellido As String, cif As String, tipoProveedor As String, direccion As String, telefono As String, email As String) As Boolean
        Dim insertado As Boolean = False
        Dim idtipoproveedor As Integer
        If tipoProveedor.ToLower.Equals("limpieza") Then
            idtipoproveedor = 1
        ElseIf tipoProveedor.ToLower.Equals("electricidad") Then
            idtipoproveedor = 2
        ElseIf tipoProveedor.ToLower.Equals("carpinteria") Then
            idtipoproveedor = 3
        ElseIf tipoProveedor.ToLower.Equals("albañileria") Then
            idtipoproveedor = 4
        ElseIf tipoProveedor.ToLower.Equals("fontaneria") Then
            idtipoproveedor = 5
        End If
        Dim sql As String = "INSERT INTO PROVEEDORES (IDTIPOPROVEEDOR,NOMBRE,NOMBREEMPRESA,APELLIDO,DNI,DIRECCION,TELEFONO,EMAIL) VALUES (@idtipoproveedor,@nombre,@nombreempresa,@apellido,@dni,@direccion,@telefono,@email)"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idtipoproveedor", idtipoproveedor)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@nombreempresa", nombreEmpresa)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@dni", cif)
                    cmd.Parameters.AddWithValue("@direccion", direccion)
                    cmd.Parameters.AddWithValue("@telefono", telefono)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.CommandText = sql
                    conn.Open()
                    Dim ressadded As Integer = cmd.ExecuteNonQuery()
                    If ressadded > 0 Then
                        insertado = True
                    End If
                    conn.Close()
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return insertado
    End Function

    'Buscar proveedor
    Private Function BuscarProveedor(DNI As String) As String
        Dim existe As String = ""
        Dim infoProveedor As DataRow = Nothing
        Dim sql As String = "SELECT * FROM PROVEEDORES WHERE DNI = @DNI"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@DNI", DNI)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoProveedor = dt.Rows(0)
                            existe = infoProveedor("DNI")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return existe
    End Function

    'Funcion buscar datos del proveedor
    Private Function BuscarDatosProveedor(DNI As String) As ArrayList
        Dim proveedor As New ArrayList
        proveedor.Clear()
        Dim infoProveedor As DataRow = Nothing
        Dim sql As String = "SELECT * FROM PROVEEDORES WHERE DNI = @dni"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@dni", DNI)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoProveedor = dt.Rows(0)
                            proveedor.Add(infoProveedor("IDTIPOPROVEEDOR"))
                            proveedor.Add(infoProveedor("NOMBRE"))
                            proveedor.Add(infoProveedor("APELLIDO"))
                            proveedor.Add(infoProveedor("DNI"))
                            proveedor.Add(infoProveedor("DIRECCION"))
                            proveedor.Add(infoProveedor("TELEFONO"))
                            proveedor.Add(infoProveedor("EMAIL"))
                            proveedor.Add(infoProveedor("NOMBREEMPRESA"))
                            proveedor.Add(infoProveedor("IDPROVEEDOR"))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return proveedor
    End Function

    'Update proveedor
    Private Function modificarProveedores(idproveedor As Integer, tipoproveedor As Integer, nombreEmpresa As String, nombre As String, apellido As String, CIF As String, email As String, tel As String, direccion As String) As Boolean
        Dim ejecutado As Boolean = False
        Dim sql As String = "UPDATE PROVEEDORES SET IDTIPOPROVEEDOR=@tipoproveedor,NOMBRE=@nombre,APELLIDO=@apellido,DNI=@cif,DIRECCION=@direccion,TELEFONO=@tel,EMAIL=@email,NOMBREEMPRESA=@nombreEmpresa WHERE IDPROVEEDOR=@idproveedor"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idproveedor", idproveedor)
                    cmd.Parameters.AddWithValue("@tipoproveedor", tipoproveedor)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@cif", CIF)
                    cmd.Parameters.AddWithValue("@direccion", direccion)
                    cmd.Parameters.AddWithValue("@tel", tel)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@nombreEmpresa", nombreEmpresa)
                    cmd.CommandText = sql
                    conn.Open()
                    Dim ressadded As Integer = cmd.ExecuteNonQuery()
                    If ressadded > 0 Then
                        ejecutado = True
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return ejecutado
    End Function

    'Elimiar proveedor
    Private Function eliminarProveedor(dni As String) As Boolean
        Dim ejecutado As Boolean = False
        Dim sql As String = "DELETE FROM PROVEEDORES WHERE DNI=@cif"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@cif", dni)
                    cmd.CommandText = sql
                    conn.Open()
                    Dim eliminado As Integer = cmd.ExecuteNonQuery()
                    If eliminado > 0 Then
                        ejecutado = True
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return ejecutado
    End Function

    'Buscar Cliente
    Private Function BuscarCliente(DNI As String) As String
        Dim existe As String = ""
        Dim infoProveedor As DataRow = Nothing
        Dim sql As String = "SELECT * FROM CLIENTES WHERE DNI = @DNI"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@DNI", DNI)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoProveedor = dt.Rows(0)
                            existe = infoProveedor("DNI")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return existe
    End Function

    'Buscar Datos del Cliente (nombre, apellido, dni, direccion, telefono, email)
    Private Function BuscarDatosCliente(DNI As String) As ArrayList
        Dim cliente As New ArrayList
        cliente.Clear()
        Dim infoCliente As DataRow = Nothing
        Dim sql As String = "SELECT * FROM CLIENTES WHERE DNI = @dni"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@dni", DNI)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoCliente = dt.Rows(0)
                            cliente.Add(infoCliente("NOMBRE"))
                            cliente.Add(infoCliente("APELLIDO"))
                            cliente.Add(infoCliente("DNI"))
                            cliente.Add(infoCliente("DIRECCION"))
                            cliente.Add(infoCliente("TELEFONO"))
                            cliente.Add(infoCliente("EMAIL"))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return cliente
    End Function

    'Buscar Datos del Cliente (fecha contratacion y coste)
    Private Function BuscarDatosClienteV2(DNI As String) As ArrayList
        Dim cliente As New ArrayList
        cliente.Clear()
        Dim infoCliente As DataRow = Nothing
        Dim sql As String = "SELECT * FROM CONTRATACIONES,CLIENTES WHERE CLIENTES.DNI=@dni AND CLIENTES.IDCLIENTE=CONTRATACIONES.IDCLIENTE"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@dni", DNI)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoCliente = dt.Rows(0)
                            cliente.Add(infoCliente("FECHAINICIO"))
                            cliente.Add(infoCliente("COSTE"))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return cliente
    End Function

    'Buscar Datos del Cliente (tipo servicio)
    Private Function BuscarDatosClienteV3(DNI As String) As String
        Dim servicio As String
        servicio = ""
        Dim infoCliente As DataRow = Nothing
        Dim sql As String = "SELECT * FROM TIPOSERVICIOS,SERVICIOSXCONTRATACIONES,SERVICIOS,CONTRATACIONES,CLIENTES WHERE TIPOSERVICIOS.IDTIPOSERVICIO=SERVICIOS.IDTIPOSERVICIO AND SERVICIOS.IDSERVICIO=SERVICIOSXCONTRATACIONES.IDSERVICIO AND CLIENTES.DNI=@dni AND CLIENTES.IDCLIENTE=CONTRATACIONES.IDCLIENTE AND CONTRATACIONES.IDCONTRATACION=SERVICIOSXCONTRATACIONES.IDCONTRATACION"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@dni", DNI)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoCliente = dt.Rows(0)
                            servicio = infoCliente("NOMBRE")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return servicio
    End Function

    'Insertar contratacion (cliente)
    Private Function InsertarCliente(nombre As String, apellido As String, dni As String, direccion As String, telefono As String, email As String) As String
        Dim ejecutado = ""
        Dim sql As String = "INSERT INTO CLIENTES (NOMBRE,APELLIDO,DNI,DIRECCION,TELEFONO,EMAIL) VALUES (@nombre,@apellido,@dni,@direccion,@telefono,@email)"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@dni", dni)
                    cmd.Parameters.AddWithValue("@direccion", direccion)
                    cmd.Parameters.AddWithValue("@telefono", telefono)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.CommandText = sql
                    conn.Open()
                    Dim ressadded As Integer = cmd.ExecuteNonQuery()
                    If ressadded > 0 Then
                        ejecutado = dni
                    End If
                    conn.Close()
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return ejecutado
    End Function

    'Devuelve dni del cliente
    Private Function BuscarIDCliente(DNI As String) As Integer
        Dim servicio As Integer
        servicio = -1
        Dim infoCliente As DataRow = Nothing
        Dim sql As String = "SELECT * FROM CLIENTES WHERE DNI=@dni"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@dni", DNI)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoCliente = dt.Rows(0)
                            servicio = infoCliente("IDCLIENTE")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return servicio
    End Function

    'Insercion de Contratacion
    Private Function InsertarContratacion(idcliente As Integer, coste As Double, fechaInicio As Date) As Boolean
        Dim ejecutado = False
        Dim null = "NULL"
        Dim sql As String = "INSERT INTO CONTRATACIONES (IDCLIENTE,FECHAINICIO,FECHAFIN,COSTE) VALUES (@idcliente,@fechainicio,@fechafin,@coste)"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idcliente", idcliente)
                    cmd.Parameters.AddWithValue("@fechainicio", fechaInicio.ToShortDateString())
                    cmd.Parameters.AddWithValue("@fechafin", null)
                    cmd.Parameters.AddWithValue("@coste", coste)
                    cmd.CommandText = sql
                    conn.Open()
                    Dim ressadded As Integer = cmd.ExecuteNonQuery()
                    If ressadded > 0 Then
                        ejecutado = True
                    End If
                    conn.Close()
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return ejecutado
    End Function

    'Buscar ID de la contratacion
    Private Function BuscarIDContratacion(idCliente As Integer, coste As Double) As Integer
        Dim idContratacion As Integer
        idContratacion = -1
        Dim infoCliente As DataRow = Nothing
        Dim sql As String = "SELECT * FROM CONTRATACIONES WHERE IDCLIENTE=@idcliente AND COSTE=@coste"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idcliente", idCliente)
                    cmd.Parameters.AddWithValue("@coste", coste)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoCliente = dt.Rows(0)
                            idContratacion = infoCliente("IDCONTRATACION")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return idContratacion
    End Function

    'Funcion buscar trabajador
    Private Function BuscarIdTrabajador(nombre As String) As Integer
        Dim existe = -1
        Dim infoTrabajador As DataRow = Nothing
        Dim sql As String = "SELECT * FROM TRABAJADORES WHERE NOMBRE=@nombre"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoTrabajador = dt.Rows(0)
                            existe = infoTrabajador("IDTRABAJADOR")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return existe
    End Function

    'INSERTAR SERVICIO
    Private Function InsertarServicio(idtiposervicio As Integer, idtrabajador As Integer) As Boolean
        Dim idServicio = False
        Dim sql As String = "INSERT INTO SERVICIOS (IDTIPOSERVICIO,IDTRABAJADOR) VALUES (@idtiposervicio,@idtrabajador)"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idtiposervicio", idtiposervicio)
                    cmd.Parameters.AddWithValue("@idtrabajador", idtrabajador)
                    cmd.CommandText = sql
                    conn.Open()
                    Dim ressadded As Integer = cmd.ExecuteNonQuery()
                    If ressadded > 0 Then
                        idServicio = True
                    End If
                    conn.Close()
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return idServicio
    End Function

    'Funcion buscar servicio
    Private Function BuscarIdServicio(idtiposervicio As Integer, idtrabajador As Integer) As Integer
        Dim existe As Integer
        Dim infoTrabajador As DataRow = Nothing
        Dim sql As String = "SELECT * FROM SERVICIOS WHERE IDTIPOSERVICIO = @idtiposervicio AND IDTRABAJADOR = @idtrabajador ORDER BY IDSERVICIO DESC"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idtiposervicio", idtiposervicio)
                    cmd.Parameters.AddWithValue("@idtrabajador", idtrabajador)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoTrabajador = dt.Rows(0)
                            existe = infoTrabajador("IDSERVICIO")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return existe
    End Function

    'Funcion insertar servicio y contratacion en la tabla "SERVICIOXCONTRATACION"
    Private Function InsertarServicioXContratacion(idservicio As Integer, idcontratacion As Integer) As Boolean
        Dim idServicios = False
        Dim sql As String = "INSERT INTO SERVICIOSXCONTRATACIONES (IDSERVICIO,IDCONTRATACION) VALUES (@idservicio,@idcontratacion)"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idservicio", idServicio)
                    cmd.Parameters.AddWithValue("@idcontratacion", idcontratacion)
                    cmd.CommandText = sql
                    conn.Open()
                    Dim ressadded As Integer = cmd.ExecuteNonQuery()
                    If ressadded > 0 Then
                        idServicios = True
                    End If
                    conn.Close()
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return idServicios
    End Function

    'SELECT COMPROBAR CONTRATACIONES EN CURSO
    Private Function ComprobarContratacionEnCurso(idcliente As Integer, fechainicio As String) As String
        Dim existe As String
        Dim infoTrabajador As DataRow = Nothing
        Dim sql As String = "SELECT * FROM CONTRATACIONES WHERE IDCLIENTE=@idcliente AND FECHAINICIO=@fechainicio"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idcliente", idcliente)
                    cmd.Parameters.AddWithValue("@fechainicio", fechainicio)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoTrabajador = dt.Rows(0)
                            existe = infoTrabajador("FECHAFIN")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return existe
    End Function

    'SELECT USER PASS
    Private Function ConseguirUserPass(IDTrabajador As Integer) As ArrayList
        Dim trabajador As New ArrayList
        trabajador.Clear()
        Dim infoCliente As DataRow = Nothing
        Dim sql As String = "SELECT * FROM USUARIOS WHERE IDUsuario=@idusuario"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idusuario", IDTrabajador)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoCliente = dt.Rows(0)
                            trabajador.Add(infoCliente("Usuario"))
                            trabajador.Add(infoCliente("Pass"))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return trabajador
    End Function

    'Cambiar la fecha de fechafin
    Private Function finalizarContratacion(idcliente As Integer, fechainicio As String) As Boolean
        Dim ejecutado = False
        Dim fechafin As Date = Now.ToShortDateString()
        Dim sql As String = "UPDATE CONTRATACIONES SET FECHAFIN=@fechafin WHERE IDCLIENTE=@idcliente AND FECHAINICIO=@fechainicio"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@fechafin", fechafin)
                    cmd.Parameters.AddWithValue("@idcliente", idcliente)
                    cmd.Parameters.AddWithValue("@fechainicio", fechainicio)
                    cmd.CommandText = sql
                    conn.Open()
                    Dim ressadded As Integer = cmd.ExecuteNonQuery()
                    If ressadded > 0 Then
                        ejecutado = True
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return ejecutado
    End Function

    'Datos fabrica
    Private Function datosFabrica(DNI As String) As ArrayList
        Dim cliente As New ArrayList
        cliente.Clear()
        Dim infoCliente As DataRow = Nothing
        Dim sql As String = "SELECT * FROM FABRICAS WHERE CIF=@cif"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@cif", DNI)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoCliente = dt.Rows(0)
                            cliente.Add(infoCliente("DIRECCION"))
                            cliente.Add(infoCliente("TELEFONO"))
                            cliente.Add(infoCliente("EMAIL"))
                            cliente.Add(infoCliente("IDENCARGADO"))
                            cliente.Add(infoCliente("IDTIPOPRODUCCION"))
                            cliente.Add(infoCliente("IDTIPOPRODUCTO"))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return cliente
    End Function

    'Datos fabrica ENCARGADO
    Private Function datosFabricaEncargado(idencargado As Integer) As String
        Dim existe = ""
        Dim infoTrabajador As DataRow = Nothing
        Dim sql As String = "SELECT * FROM TRABAJADORES WHERE IDTRABAJADOR=@idencargado"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idencargado", idencargado)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoTrabajador = dt.Rows(0)
                            existe = infoTrabajador("NOMBRE")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return existe
    End Function

    'Datos fabrica TIPO PRODUCCION
    Private Function datosFabricaTipoProduccion(idtipoproduccion As Integer) As String
        Dim existe = ""
        Dim infoTrabajador As DataRow = Nothing
        Dim sql As String = "SELECT * FROM TIPOPRODUCCIONES WHERE IDTIPOPRODUCCION=@idtipoproduccion"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idtipoproduccion", idtipoproduccion)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoTrabajador = dt.Rows(0)
                            existe = infoTrabajador("NOMBRE")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return existe
    End Function

    'Datos fabrica TIPO PRODUCTO
    Private Function datosFabricaTipoProducto(idtipoproducto As Integer) As String
        Dim existe = ""
        Dim infoTrabajador As DataRow = Nothing
        Dim sql As String = "SELECT * FROM TIPOPRODUCTOS WHERE IDTIPOPRODUCTO=@idtipoproducto"
        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@idtipoproducto", idtipoproducto)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            infoTrabajador = dt.Rows(0)
                            existe = infoTrabajador("NOMBRE")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return existe
    End Function

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Dim validar = ValidarUsuario(txtUsuario.Text.Trim, txtPass.Text.Trim)
        permisos = ValidarUsuario(txtUsuario.Text.Trim, txtPass.Text.Trim)
        If validar <> -1 Then
            If validar = 0 Then
                Login.Visible = False
                Menu.Visible = True
                Trabajador.Visible = False
                MenuModificarTrabajador.Visible = False
                DarAltaTrabajador.Visible = False
                InformacionTrabajador.Visible = False
                ModificarTrabajador.Visible = False
                BajaTrabajador.Visible = False
                MenuProveedores.Visible = False
                AltaProveedor.Visible = False
                BusquedaModificarProveedor.Visible = False
                ModificarProveedor.Visible = False
                ConsultarProveedor.Visible = False
                BajaProveedor.Visible = False
                MenuClientes.Visible = False
                ClientesAtendidos.Visible = False
                NuevaContratacion.Visible = False
                ContratacionesEnCurso.Visible = False
                CancelarContratacion.Visible = False
                MenuFabrica.Visible = False
                txtUsuario.Clear()
                txtPass.Clear()
            ElseIf validar = 1 Then
                Login.Visible = False
                Menu.Visible = False
                Trabajador.Visible = False
                MenuModificarTrabajador.Visible = False
                DarAltaTrabajador.Visible = False
                InformacionTrabajador.Visible = False
                ModificarTrabajador.Visible = False
                BajaTrabajador.Visible = False
                MenuProveedores.Visible = True
                AltaProveedor.Visible = False
                BusquedaModificarProveedor.Visible = False
                ModificarProveedor.Visible = False
                ConsultarProveedor.Visible = False
                BajaProveedor.Visible = False
                MenuClientes.Visible = False
                ClientesAtendidos.Visible = False
                NuevaContratacion.Visible = False
                ContratacionesEnCurso.Visible = False
                CancelarContratacion.Visible = False
                MenuFabrica.Visible = False
                txtUsuario.Clear()
                txtPass.Clear()
            ElseIf validar = 2 Then
                Login.Visible = False
                Menu.Visible = False
                Trabajador.Visible = True
                MenuModificarTrabajador.Visible = False
                DarAltaTrabajador.Visible = False
                InformacionTrabajador.Visible = False
                ModificarTrabajador.Visible = False
                BajaTrabajador.Visible = False
                MenuProveedores.Visible = False
                AltaProveedor.Visible = False
                BusquedaModificarProveedor.Visible = False
                ModificarProveedor.Visible = False
                ConsultarProveedor.Visible = False
                BajaProveedor.Visible = False
                MenuClientes.Visible = False
                ClientesAtendidos.Visible = False
                NuevaContratacion.Visible = False
                ContratacionesEnCurso.Visible = False
                CancelarContratacion.Visible = False
                MenuFabrica.Visible = False
                txtUsuario.Clear()
                txtPass.Clear()
            ElseIf validar = 3 Then
                Login.Visible = False
                Menu.Visible = False
                Trabajador.Visible = False
                MenuModificarTrabajador.Visible = False
                DarAltaTrabajador.Visible = False
                InformacionTrabajador.Visible = False
                ModificarTrabajador.Visible = False
                BajaTrabajador.Visible = False
                MenuProveedores.Visible = False
                AltaProveedor.Visible = False
                BusquedaModificarProveedor.Visible = False
                ModificarProveedor.Visible = False
                ConsultarProveedor.Visible = False
                BajaProveedor.Visible = False
                MenuClientes.Visible = True
                ClientesAtendidos.Visible = False
                NuevaContratacion.Visible = False
                ContratacionesEnCurso.Visible = False
                CancelarContratacion.Visible = False
                MenuFabrica.Visible = False
                txtUsuario.Clear()
                txtPass.Clear()
            ElseIf validar = 4 Then
                Login.Visible = False
                Menu.Visible = False
                Trabajador.Visible = False
                MenuModificarTrabajador.Visible = False
                DarAltaTrabajador.Visible = False
                InformacionTrabajador.Visible = False
                ModificarTrabajador.Visible = False
                BajaTrabajador.Visible = False
                MenuProveedores.Visible = False
                AltaProveedor.Visible = False
                BusquedaModificarProveedor.Visible = False
                ModificarProveedor.Visible = False
                ConsultarProveedor.Visible = False
                BajaProveedor.Visible = False
                MenuClientes.Visible = False
                ClientesAtendidos.Visible = False
                NuevaContratacion.Visible = False
                ContratacionesEnCurso.Visible = False
                CancelarContratacion.Visible = False
                MenuFabrica.Visible = True
                txtUsuario.Clear()
                txtPass.Clear()
            End If

        Else
            MsgBox("Error, usuario incorrecto")
        End If
    End Sub

    Private Sub btnTrabajadores_Click(sender As Object, e As EventArgs) Handles btnTrabajadores.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = True
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnAltaTrabajador_Click(sender As Object, e As EventArgs) Handles btnAltaTrabajador.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = True
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnConsultarTrabajador_Click(sender As Object, e As EventArgs) Handles btnConsultarTrabajador.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = True
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
        txtConsultarTrabajadorNombre.ReadOnly = True
        txtConsultarTrabajadorTipoTrabajador.ReadOnly = True
        txtConsultarTrabajadorApellido.ReadOnly = True
        txtConsultarTrabajadorEdad.ReadOnly = True
        txtConsultarTrabajadorAnyosTrabajados.ReadOnly = True
        txtConsultarTrabajadorTel.ReadOnly = True
        txtConsultarTrabajadorEmail.ReadOnly = True
        txtConsultarTrabajadorUsuario.ReadOnly = True
        txtConsultarTrabajadorPass.ReadOnly = True
        txtConsultarTrabajadorSexo.ReadOnly = True
        txtConsultarTrabajadorNombre.Clear()
        txtConsultarTrabajadorApellido.Clear()
        txtConsultarTrabajadorTipoTrabajador.Clear()
        txtConsultarTrabajadorEdad.Clear()
        txtConsultarTrabajadorAnyosTrabajados.Clear()
        txtConsultarTrabajadorTel.Clear()
        txtConsultarTrabajadorEmail.Clear()
        txtConsultarTrabajadorUsuario.Clear()
        txtConsultarTrabajadorPass.Clear()
        txtConsultarTrabajadorSexo.Clear()
        txtConsultarTrabajadorDNI.Clear()
    End Sub

    Private Sub btnModificarTrabajador_Click(sender As Object, e As EventArgs) Handles btnModificarTrabajador.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = True
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnBajaTrabajador_Click(sender As Object, e As EventArgs) Handles btnBajaTrabajador.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = True
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnAtrasMenuTrabajador_Click(sender As Object, e As EventArgs) Handles btnAtrasMenuTrabajador.Click
        If permisos = 0 Then
            Login.Visible = False
            Menu.Visible = True
            Trabajador.Visible = False
            MenuModificarTrabajador.Visible = False
            DarAltaTrabajador.Visible = False
            InformacionTrabajador.Visible = False
            ModificarTrabajador.Visible = False
            BajaTrabajador.Visible = False
            MenuProveedores.Visible = False
            AltaProveedor.Visible = False
            BusquedaModificarProveedor.Visible = False
            ModificarProveedor.Visible = False
            ConsultarProveedor.Visible = False
            BajaProveedor.Visible = False
            MenuClientes.Visible = False
            ClientesAtendidos.Visible = False
            NuevaContratacion.Visible = False
            ContratacionesEnCurso.Visible = False
            CancelarContratacion.Visible = False
            MenuFabrica.Visible = False
        Else
            MsgBox("Error, usted no puede acceder al menú del administrador.")
        End If

    End Sub

    Private Sub btnSalirMenuTrabajador_Click(sender As Object, e As EventArgs) Handles btnSalirMenuTrabajador.Click
        Login.Visible = True
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnAltaTrabajadoresAceptar_Click(sender As Object, e As EventArgs) Handles btnAltaTrabajadoresAceptar.Click
        Dim nombre = txtAltaTrabajadorNombre.Text.Trim
        Dim apellido = txtAltaTrabajadorApellido.Text.Trim
        Dim DNI = txtAltaTrabajadorDNI.Text.Trim
        Dim email = txtAltaTrabajadorEmail.Text.Trim
        Dim tel = txtAltaTrabajadorTel.Text.Trim
        Dim sexo = txtAltaTrabajadorSexo.Text.Trim
        Dim fechaNac = DateAltaTrabajadorNacimiento.Value
        Dim tipoTrabajador = txtAltaTrabajadorTipo.Text.Trim
        Dim todaysdate As Date = Now


        If nombre.Equals("") Or apellido.Equals("") Or DNI.Equals("") Or email.Equals("") Or tel.Equals("") Or tipoTrabajador.Equals("") Or sexo.Equals("") Then
            MsgBox("Error, hay algún campo no rellenado. Compruebe todos los campos.")
        Else
            If Insertar(nombre, apellido, DNI, email, tel, fechaNac, tipoTrabajador, sexo) = True Then
                MsgBox("Se ha insertado el trabajador correctamente")
                Login.Visible = False
                Menu.Visible = False
                Trabajador.Visible = True
                MenuModificarTrabajador.Visible = False
                DarAltaTrabajador.Visible = False
                InformacionTrabajador.Visible = False
                ModificarTrabajador.Visible = False
                BajaTrabajador.Visible = False
                MenuProveedores.Visible = False
                AltaProveedor.Visible = False
                BusquedaModificarProveedor.Visible = False
                ModificarProveedor.Visible = False
                ConsultarProveedor.Visible = False
                BajaProveedor.Visible = False
                MenuClientes.Visible = False
                ClientesAtendidos.Visible = False
                NuevaContratacion.Visible = False
                ContratacionesEnCurso.Visible = False
                CancelarContratacion.Visible = False
                MenuFabrica.Visible = False

                txtAltaTrabajadorNombre.Clear()
                txtAltaTrabajadorApellido.Clear()
                txtAltaTrabajadorEmail.Clear()
                txtAltaTrabajadorTel.Clear()
                txtAltaTrabajadorSexo.Clear()
                txtAltaTrabajadorTipo.Clear()
                txtAltaTrabajadorDNI.Clear()
                DateAltaTrabajadorNacimiento.ResetText()
            Else
                MsgBox("Ha ocurrido un error, compruebe los datos introducidos")
            End If
        End If
    End Sub

    Private Sub btnAltaTrabajadoresCancelar_Click(sender As Object, e As EventArgs) Handles btnAltaTrabajadoresCancelar.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = True
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
        txtAltaTrabajadorNombre.Clear()
        txtAltaTrabajadorApellido.Clear()
        txtAltaTrabajadorEmail.Clear()
        txtAltaTrabajadorTel.Clear()
        txtAltaTrabajadorSexo.Clear()
        txtAltaTrabajadorTipo.Clear()
        txtAltaTrabajadorDNI.Clear()
        DateAltaTrabajadorNacimiento.ResetText()
    End Sub

    Private Sub btnModificacionTrabajadorCancelar_Click(sender As Object, e As EventArgs) Handles btnModificacionTrabajadorCancelar.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = True
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
        txtMenuModificacionTrabajadorDNI.Clear()
    End Sub

    Private Sub btnModificacionTrabajadorAtras_Click(sender As Object, e As EventArgs) Handles btnConsultarTrabajadorAtras.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = True
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
        txtMenuModificarTrabajadorNombre.Clear()
        txtMenuModificarTrabajadorApellido.Clear()
        txtMenuModificarTrabajadorDNI.Clear()
        txtMenuModificarTrabajadorTipo.Clear()
        txtMenuModificarTrabajadorEmail.Clear()
        txtMenuModificarTrabajadorTel.Clear()
        txtMenuModificarTrabajadorSexo.Clear()

    End Sub

    Private Sub btnBajaTrabajadorCancelar_Click(sender As Object, e As EventArgs) Handles btnBajaTrabajadorCancelar.Click
        Login.Visible = False
        Menu.Visible = True
        Trabajador.Visible = False
        DarAltaTrabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        BajaTrabajador.Visible = False
        txtBajaTrabajadorDNI.Clear()
        txtBajaTrabajadorRazon.Clear()
    End Sub

    Private Sub btnBajaTrabajadorAceptar_Click(sender As Object, e As EventArgs) Handles btnBajaTrabajadorAceptar.Click
        If BuscarTrabajador(txtBajaTrabajadorDNI.Text.Trim).Equals("") Then
            MsgBox("Error, no hay ningún trabajador con ese DNI.")
        Else
            If eliminarTrabajador(txtBajaTrabajadorDNI.Text.Trim) = True Then
                MsgBox("El trabajador se ha dado de baja correctamente.")
                Login.Visible = False
                Menu.Visible = False
                Trabajador.Visible = True
                MenuModificarTrabajador.Visible = False
                DarAltaTrabajador.Visible = False
                InformacionTrabajador.Visible = False
                ModificarTrabajador.Visible = False
                BajaTrabajador.Visible = False
                MenuProveedores.Visible = False
                AltaProveedor.Visible = False
                BusquedaModificarProveedor.Visible = False
                ModificarProveedor.Visible = False
                ConsultarProveedor.Visible = False
                BajaProveedor.Visible = False
                MenuClientes.Visible = False
                ClientesAtendidos.Visible = False
                NuevaContratacion.Visible = False
                ContratacionesEnCurso.Visible = False
                CancelarContratacion.Visible = False
                MenuFabrica.Visible = False
                txtBajaTrabajadorDNI.Clear()
                txtBajaTrabajadorRazon.Clear()
            Else
                MsgBox("Ha habido un error a la hora de eliminar el trabajador. Pongase en contacto con el administrador.")
            End If
        End If
    End Sub

    Private Sub btnModificacionTrabajadorBuscar_Click(sender As Object, e As EventArgs) Handles btnModificacionTrabajadorBuscar.Click
        Dim datosTrabajador As New ArrayList
        Dim tipo = ""
        Dim dni = BuscarTrabajador(txtMenuModificacionTrabajadorDNI.Text.Trim)
        If dni.Equals("") Then
            MsgBox("Error, no hay ningún trabajador con dicho DNI")
        Else
            datosTrabajador = BuscarDatosTrabajador(dni)
            If datosTrabajador(0) = 1 Then
                tipo = "fijo"
            ElseIf datosTrabajador(0) = 2 Then
                tipo = "temporal"
            ElseIf datosTrabajador(0) = 3 Then
                tipo = "En Practicas"
            End If
            datosTrabajador = BuscarDatosTrabajador(BuscarTrabajador(txtMenuModificacionTrabajadorDNI.Text.Trim))
            txtMenuModificarTrabajadorTipo.Text = tipo
            txtMenuModificarTrabajadorNombre.Text = datosTrabajador(1).ToString.Trim
            txtMenuModificarTrabajadorApellido.Text = datosTrabajador(2).ToString.Trim
            txtMenuModificarTrabajadorEdad.Text = datosTrabajador(3).ToString.Trim
            txtMenuModificarTrabajadorAnyosTrabajados.Text = datosTrabajador(4).ToString.Trim
            txtMenuModificarTrabajadorDNI.Text = datosTrabajador(5).ToString.Trim
            txtMenuModificarTrabajadorTel.Text = datosTrabajador(6).ToString.Trim
            txtMenuModificarTrabajadorEmail.Text = datosTrabajador(7).ToString.Trim
            txtMenuModificarTrabajadorSexo.Text = datosTrabajador(8).ToString.Trim
            idtrabajadores = datosTrabajador(9)
            Login.Visible = False
            Menu.Visible = False
            Trabajador.Visible = False
            MenuModificarTrabajador.Visible = False
            DarAltaTrabajador.Visible = False
            InformacionTrabajador.Visible = False
            ModificarTrabajador.Visible = True
            BajaTrabajador.Visible = False
            MenuProveedores.Visible = False
            AltaProveedor.Visible = False
            BusquedaModificarProveedor.Visible = False
            ModificarProveedor.Visible = False
            ConsultarProveedor.Visible = False
            BajaProveedor.Visible = False
            MenuClientes.Visible = False
            ClientesAtendidos.Visible = False
            NuevaContratacion.Visible = False
            ContratacionesEnCurso.Visible = False
            CancelarContratacion.Visible = False
            MenuFabrica.Visible = False
        End If
        txtMenuModificacionTrabajadorDNI.Clear()
        datosTrabajador.Clear()
    End Sub

    Private Sub btnMenuModificarTrabajadorAceptar_Click(sender As Object, e As EventArgs) Handles btnMenuModificarTrabajadorAceptar.Click
        Dim tipo As Integer
        Dim idtrabajador = idtrabajadores
        If txtMenuModificarTrabajadorTipo.Text.Trim.ToLower.Equals("fijo") Then
            tipo = 1
        ElseIf txtMenuModificarTrabajadorTipo.Text.Trim.ToLower.Equals("temporal") Then
            tipo = 2
        ElseIf txtMenuModificarTrabajadorTipo.Text.Trim.ToLower.Equals("en practicas") Then
            tipo = 3
        End If
        If txtMenuModificarTrabajadorNombre.Text.Trim.Equals("") Or txtMenuModificarTrabajadorApellido.Text.Trim.Equals("") Or txtMenuModificarTrabajadorTipo.Text.Trim.Equals("") Or txtMenuModificarTrabajadorDNI.Text.Trim.Equals("") Or txtMenuModificarTrabajadorEdad.Text.Trim.Equals("") Or txtMenuModificarTrabajadorAnyosTrabajados.Text.Trim.Equals("") Or txtMenuModificarTrabajadorTel.Text.Trim.Equals("") Or txtMenuModificarTrabajadorEmail.Text.Trim.Equals("") Or txtMenuModificarTrabajadorSexo.Text.Trim.Equals("") Then
            MsgBox("Error, hay algun campo vacío. Compruebe todos los campos por favor.")
        Else
            If modificarTrabajadores(idtrabajador, tipo, txtMenuModificarTrabajadorNombre.Text.Trim, txtMenuModificarTrabajadorApellido.Text.Trim, txtMenuModificarTrabajadorDNI.Text.Trim, txtMenuModificarTrabajadorEmail.Text.Trim, txtMenuModificarTrabajadorTel.Text.Trim, txtMenuModificarTrabajadorEdad.Text.Trim, txtMenuModificarTrabajadorAnyosTrabajados.Text.Trim, txtMenuModificarTrabajadorSexo.Text.Trim) = True Then
                MsgBox("¡El trabajador ha sido modificado correctamente!")
                Login.Visible = False
                Menu.Visible = False
                Trabajador.Visible = True
                MenuModificarTrabajador.Visible = False
                DarAltaTrabajador.Visible = False
                InformacionTrabajador.Visible = False
                ModificarTrabajador.Visible = False
                BajaTrabajador.Visible = False
                MenuProveedores.Visible = False
                AltaProveedor.Visible = False
                BusquedaModificarProveedor.Visible = False
                ModificarProveedor.Visible = False
                ConsultarProveedor.Visible = False
                BajaProveedor.Visible = False
                MenuClientes.Visible = False
                ClientesAtendidos.Visible = False
                NuevaContratacion.Visible = False
                ContratacionesEnCurso.Visible = False
                CancelarContratacion.Visible = False
                MenuFabrica.Visible = False
                txtMenuModificarTrabajadorNombre.Clear()
                txtMenuModificarTrabajadorApellido.Clear()
                txtMenuModificarTrabajadorTipo.Clear()
                txtMenuModificarTrabajadorDNI.Clear()
                txtMenuModificarTrabajadorEdad.Clear()
                txtMenuModificarTrabajadorAnyosTrabajados.Clear()
                txtMenuModificarTrabajadorTel.Clear()
                txtMenuModificarTrabajadorEmail.Clear()
                txtMenuModificarTrabajadorSexo.Clear()
            Else
                MsgBox("Error, algo ha salido mal, compruebe los datos modificados.")
            End If
        End If
    End Sub

    Private Sub btnMenuModificarTrabajadorCancelar_Click(sender As Object, e As EventArgs) Handles btnMenuModificarTrabajadorCancelar.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = True
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
        txtMenuModificarTrabajadorNombre.Clear()
        txtMenuModificarTrabajadorApellido.Clear()
        txtMenuModificarTrabajadorTipo.Clear()
        txtMenuModificarTrabajadorDNI.Clear()
        txtMenuModificarTrabajadorEdad.Clear()
        txtMenuModificarTrabajadorAnyosTrabajados.Clear()
        txtMenuModificarTrabajadorTel.Clear()
        txtMenuModificarTrabajadorEmail.Clear()
        txtMenuModificarTrabajadorSexo.Clear()
    End Sub

    Private Sub btnAñadirProveedor_Click(sender As Object, e As EventArgs) Handles btnAñadirProveedor.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = True
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnModificarProveedor_Click(sender As Object, e As EventArgs) Handles btnModificarProveedor.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = True
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnConsultarProveedor_Click(sender As Object, e As EventArgs) Handles btnConsultarProveedor.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = True
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnBajaProveedor_Click(sender As Object, e As EventArgs) Handles btnBajaProveedor.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = True
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnAltaProveedorCancelar_Click(sender As Object, e As EventArgs) Handles btnAltaProveedorCancelar.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = True
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
        txtAltaProveedorNombreEmpresa.Clear()
        txtAltaProveedorNombre.Clear()
        txtAltaProveedorApellido.Clear()
        txtAltaProveedorCIF.Clear()
        txtAltaProveedorDireccion.Clear()
        txtAltaProveedorEmail.Clear()
        txtAltaProveedorTelefono.Clear()
        txtAltaProveedorTipo.Clear()
        txtAltaProveedorTipo.Clear()
    End Sub

    Private Sub btnAltaProveedorAceptar_Click(sender As Object, e As EventArgs) Handles btnAltaProveedorAceptar.Click
        If txtAltaProveedorNombreEmpresa.Text.Trim.Equals("") Or txtAltaProveedorNombre.Text.Trim.Equals("") Or txtAltaProveedorApellido.Text.Trim.Equals("") Or txtAltaProveedorCIF.Text.Trim.Equals("") Or txtAltaProveedorTipo.Text.Trim.Equals("") Or txtAltaProveedorDireccion.Text.Trim.Equals("") Or txtAltaProveedorTelefono.Text.Trim.Equals("") Or txtAltaProveedorEmail.Text.Trim.Equals("") Then
            MsgBox("Error, hay algún campo vacío.")
        Else
            If InsertarProveedor(txtAltaProveedorNombreEmpresa.Text.Trim, txtAltaProveedorNombre.Text.Trim, txtAltaProveedorApellido.Text.Trim, txtAltaProveedorCIF.Text.Trim, txtAltaProveedorTipo.Text.Trim, txtAltaProveedorDireccion.Text.Trim, txtAltaProveedorTelefono.Text.Trim, txtAltaProveedorEmail.Text.Trim) = True Then
                MsgBox("El proveedor se ha añadido correctamente!")
                Login.Visible = False
                Menu.Visible = False
                Trabajador.Visible = False
                MenuModificarTrabajador.Visible = False
                DarAltaTrabajador.Visible = False
                InformacionTrabajador.Visible = False
                ModificarTrabajador.Visible = False
                BajaTrabajador.Visible = False
                MenuProveedores.Visible = True
                AltaProveedor.Visible = False
                BusquedaModificarProveedor.Visible = False
                ModificarProveedor.Visible = False
                ConsultarProveedor.Visible = False
                BajaProveedor.Visible = False
                MenuClientes.Visible = False
                ClientesAtendidos.Visible = False
                NuevaContratacion.Visible = False
                ContratacionesEnCurso.Visible = False
                CancelarContratacion.Visible = False
                MenuFabrica.Visible = False
                txtAltaProveedorNombreEmpresa.Clear()
                txtAltaProveedorNombre.Clear()
                txtAltaProveedorApellido.Clear()
                txtAltaProveedorCIF.Clear()
                txtAltaProveedorDireccion.Clear()
                txtAltaProveedorEmail.Clear()
                txtAltaProveedorTelefono.Clear()
                txtAltaProveedorTipo.Clear()
                txtAltaProveedorTipo.Clear()
            Else
                MsgBox("Ha habido algún error, contacte con el administrador.")
            End If
        End If

    End Sub

    Private Sub btnBusquedaModificacionProveedorCancelar_Click(sender As Object, e As EventArgs) Handles btnBusquedaModificacionProveedorCancelar.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = True
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnBusquedaModificacionProveedorBuscar_Click(sender As Object, e As EventArgs) Handles btnBusquedaModificacionProveedorBuscar.Click
        Dim proveedor As ArrayList
        Dim tipoProveedor = ""
        If BuscarProveedor(txtBusquedaModificarProveedorCIF.Text.Trim).Equals("") Then
            MsgBox("Error, no existe ningún proveedor con dicho CIF")
            MsgBox(BuscarProveedor(txtBusquedaModificarProveedorCIF.Text.Trim))
        Else
            proveedor = BuscarDatosProveedor(txtBusquedaModificarProveedorCIF.Text.Trim)
            If proveedor(0) = 1 Then
                tipoProveedor = "Limpieza"
            ElseIf proveedor(0) = 2 Then
                tipoProveedor = "Electricidad"
            ElseIf proveedor(0) = 3 Then
                tipoProveedor = "Carpinteria"
            ElseIf proveedor(0) = 4 Then
                tipoProveedor = "Albañileria"
            ElseIf proveedor(0) = 5 Then
                tipoProveedor = "Fontaneria"
            End If
            idproveedores = proveedor(8)
            txtModificarProveedorNombreEmpresa.Text = proveedor(7).ToString.Trim
            txtModificarProveedorNombre.Text = proveedor(1).ToString.Trim
            txtModificarProveedorApellido.Text = proveedor(2).ToString.Trim
            txtModificarProveedorCIF.Text = proveedor(3).ToString.Trim
            txtModificarProveedorDireccion.Text = proveedor(4).ToString.Trim
            txtModificarProveedorTelefono.Text = proveedor(5).ToString.Trim
            txtModificarProveedorEmail.Text = proveedor(6).ToString.Trim
            txtModificarProveedorTipo.Text = tipoProveedor
            Login.Visible = False
            Menu.Visible = False
            Trabajador.Visible = False
            MenuModificarTrabajador.Visible = False
            DarAltaTrabajador.Visible = False
            InformacionTrabajador.Visible = False
            ModificarTrabajador.Visible = False
            BajaTrabajador.Visible = False
            MenuProveedores.Visible = False
            AltaProveedor.Visible = False
            BusquedaModificarProveedor.Visible = False
            ModificarProveedor.Visible = True
            ConsultarProveedor.Visible = False
            BajaProveedor.Visible = False
            MenuClientes.Visible = False
            ClientesAtendidos.Visible = False
            NuevaContratacion.Visible = False
            ContratacionesEnCurso.Visible = False
            CancelarContratacion.Visible = False
            MenuFabrica.Visible = False
            txtBusquedaModificarProveedorCIF.Clear()
            proveedor.Clear()
        End If
    End Sub

    Private Sub btnModificarProveedorCancelar_Click(sender As Object, e As EventArgs) Handles btnModificarProveedorCancelar.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = True
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
        txtModificarProveedorNombreEmpresa.Clear()
        txtModificarProveedorNombre.Clear()
        txtModificarProveedorApellido.Clear()
        txtModificarProveedorCIF.Clear()
        txtModificarProveedorDireccion.Clear()
        txtModificarProveedorTelefono.Clear()
        txtModificarProveedorEmail.Clear()
        txtModificarProveedorTipo.Clear()
    End Sub

    Private Sub btnModificarProveedorAceptar_Click(sender As Object, e As EventArgs) Handles btnModificarProveedorAceptar.Click
        Dim idproveedor = idproveedores
        Dim tipoproveedor As Integer
        If txtModificarProveedorTipo.Text.Trim.ToLower.Equals("limpieza") Then
            tipoproveedor = 1
        ElseIf txtModificarProveedorTipo.Text.Trim.ToLower.Equals("electricidad") Then
            tipoproveedor = 2
        ElseIf txtModificarProveedorTipo.Text.Trim.ToLower.Equals("carpinteria") Then
            tipoproveedor = 3
        ElseIf txtModificarProveedorTipo.Text.Trim.ToLower.Equals("albañileria") Then
            tipoproveedor = 4
        ElseIf txtModificarProveedorTipo.Text.Trim.ToLower.Equals("fontaneria") Then
            tipoproveedor = 5
        End If

        If txtModificarProveedorNombreEmpresa.Text.Trim.Equals("") Or txtModificarProveedorNombre.Text.Trim.Equals("") Or txtModificarProveedorApellido.Text.Trim.Equals("") Or txtModificarProveedorCIF.Text.Trim.Equals("") Or txtModificarProveedorDireccion.Text.Trim.Equals("") Or txtModificarProveedorTelefono.Text.Trim.Equals("") Or txtModificarProveedorEmail.Text.Trim.Equals("") Or txtModificarProveedorTipo.Text.Trim.Equals("") Then
            MsgBox("Error, hay algún campo vacío")
        Else
            If modificarProveedores(idproveedor, tipoproveedor, txtModificarProveedorNombreEmpresa.Text.Trim, txtModificarProveedorNombre.Text.Trim, txtModificarProveedorApellido.Text.Trim, txtModificarProveedorCIF.Text.Trim, txtModificarProveedorEmail.Text.Trim, txtModificarProveedorTelefono.Text.Trim, txtModificarProveedorDireccion.Text.Trim) = True Then
                MsgBox("Se han modificado los datos correctamente")
                Login.Visible = False
                Menu.Visible = False
                Trabajador.Visible = False
                MenuModificarTrabajador.Visible = False
                DarAltaTrabajador.Visible = False
                InformacionTrabajador.Visible = False
                ModificarTrabajador.Visible = False
                BajaTrabajador.Visible = False
                MenuProveedores.Visible = True
                AltaProveedor.Visible = False
                BusquedaModificarProveedor.Visible = False
                ModificarProveedor.Visible = False
                ConsultarProveedor.Visible = False
                BajaProveedor.Visible = False
                MenuClientes.Visible = False
                ClientesAtendidos.Visible = False
                NuevaContratacion.Visible = False
                ContratacionesEnCurso.Visible = False
                CancelarContratacion.Visible = False
                MenuFabrica.Visible = False
                txtModificarProveedorNombreEmpresa.Clear()
                txtModificarProveedorNombre.Clear()
                txtModificarProveedorApellido.Clear()
                txtModificarProveedorCIF.Clear()
                txtModificarProveedorDireccion.Clear()
                txtModificarProveedorTelefono.Clear()
                txtModificarProveedorEmail.Clear()
                txtModificarProveedorTipo.Clear()
            Else
                MsgBox("Ha ocurrido un error, comuniquese con el administrador.")
            End If
        End If
    End Sub

    Private Sub btnBusquedaConsultarProveedorCancelar_Click(sender As Object, e As EventArgs)
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = True
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnConsultarProveedorCancelar_Click(sender As Object, e As EventArgs) Handles btnConsultarProveedorCancelar.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = True
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
        txtConsultarProveedorCIFBusqueda.Clear()
        txtConsultarProveedorNombreEmpresa.Clear()
        txtConsultarProveedorCIF.Clear()
        txtConsultarProveedorNombre.Clear()
        txtConsultarProveedorApellido.Clear()
        txtConsultarProveedorDireccion.Clear()
        txtConsultarProveedorTelefono.Clear()
        txtConsultarProveedorEmail.Clear()
        txtConsultarProveedorTipo.Clear()
    End Sub

    Private Sub btnConsultarProveedorAceptar_Click(sender As Object, e As EventArgs)
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = True
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
        txtConsultarProveedorNombreEmpresa.Clear()
        txtConsultarProveedorNombre.Clear()
        txtConsultarProveedorApellido.Clear()
        txtConsultarProveedorCIF.Clear()
        txtConsultarProveedorDireccion.Clear()
        txtConsultarProveedorTelefono.Clear()
        txtConsultarProveedorEmail.Clear()
        txtConsultarProveedorTipo.Clear()
    End Sub

    Private Sub btnBajaProveedorCancelar_Click(sender As Object, e As EventArgs) Handles btnBajaProveedorCancelar.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = True
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnBajaProveedorAceptar_Click(sender As Object, e As EventArgs) Handles btnBajaProveedorAceptar.Click
        If txtBajaProveedorDNI.Text.Trim.Equals("") Or txtBajaProveedorRazon.Text.Trim.Equals("") Then
            MsgBox("Error, hay un o varios campos vacios.")
        Else
            If BuscarProveedor(txtBajaProveedorDNI.Text.Trim).Equals("") Then
                MsgBox("Error, no hay ningún proveedor con dicho CIF.")
            Else
                If eliminarProveedor(txtBajaProveedorDNI.Text.Trim) = True Then
                    MsgBox("El proveedor se ha eliminado correctamente.")
                    Login.Visible = False
                    Menu.Visible = False
                    Trabajador.Visible = False
                    MenuModificarTrabajador.Visible = False
                    DarAltaTrabajador.Visible = False
                    InformacionTrabajador.Visible = False
                    ModificarTrabajador.Visible = False
                    BajaTrabajador.Visible = False
                    MenuProveedores.Visible = True
                    AltaProveedor.Visible = False
                    BusquedaModificarProveedor.Visible = False
                    ModificarProveedor.Visible = False
                    ConsultarProveedor.Visible = False
                    BajaProveedor.Visible = False
                    MenuClientes.Visible = False
                    ClientesAtendidos.Visible = False
                    NuevaContratacion.Visible = False
                    ContratacionesEnCurso.Visible = False
                    CancelarContratacion.Visible = False
                    MenuFabrica.Visible = False
                    txtBajaProveedorDNI.Clear()
                Else
                    MsgBox("Ha ocurrido un error, comuniquese con el administrador.")
                End If
            End If
        End If
    End Sub

    Private Sub btnMenuClientesAtendidos_Click(sender As Object, e As EventArgs) Handles btnMenuClientesAtendidos.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = True
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnMenuClientesNContratacion_Click(sender As Object, e As EventArgs) Handles btnMenuClientesNContratacion.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = True
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnMenuClientesCContrataciones_Click(sender As Object, e As EventArgs) Handles btnMenuClientesCContrataciones.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = True
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnMenuClientesFContratacion_Click(sender As Object, e As EventArgs) Handles btnMenuClientesFContratacion.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = True
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnMenuClientesSalir_Click(sender As Object, e As EventArgs) Handles btnMenuClientesSalir.Click
        Login.Visible = True
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnClientesAtendidosAtras_Click(sender As Object, e As EventArgs) Handles btnClientesAtendidosAtras.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = True
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
        txtClientesAtendidosNombre.Clear()
        txtClientesAtendidosApellidos.Clear()
        txtClientesAtendidosDNI.Clear()
        txtClientesAtendidosDireccion.Clear()
        txtClientesAtendidosTelefono.Clear()
        txtClientesAtendidosEmail.Clear()
        txtClientesAtendidosCoste.Clear()
        txtClientesAtendidosFecha.Clear()
        txtClientesAtendidosTipoServicio.Clear()
    End Sub

    Private Sub btnNuevaContratacionCancelar_Click(sender As Object, e As EventArgs) Handles btnNuevaContratacionCancelar.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = True
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
        txtNuevaContratacionNombre.Clear()
        txtNuevaContratacionApellidos.Clear()
        txtNuevaContratacionDNI.Clear()
        txtNuevaContratacionDireccion.Clear()
        txtNuevaContratacionTelefono.Clear()
        txtNuevaContratacionEmail.Clear()
        txtNuevaContratacionTipoServicio.Clear()
        txtNuevaContratacionCoste.Clear()
        DateTimePickerNuevaContratacion.ResetText()
    End Sub

    Private Sub btnNuevaContratacionAceptar_Click(sender As Object, e As EventArgs) Handles btnNuevaContratacionAceptar.Click
        Dim dni As String
        Dim idcontratacion As Integer
        Dim idcliente As Integer
        Dim tipoServicio As Integer
        Dim idTrabajador As Integer
        Dim nombreTrabajador As String
        Dim idServicios = 0
        If txtNuevaContratacionNombre.Text.Trim.Equals("") Or txtNuevaContratacionApellidos.Text.Trim.Equals("") Or txtNuevaContratacionDNI.Text.Trim.Equals("") Or txtNuevaContratacionDireccion.Text.Trim.Equals("") Or txtNuevaContratacionTelefono.Text.Trim.Equals("") Or txtNuevaContratacionEmail.Text.Trim.Equals("") Or txtNuevaContratacionTipoServicio.Text.Trim.Equals("") Or txtNuevaContratacionCoste.Text.Trim.Equals("") Then
            MsgBox("Error, hay un campo vacío")
        Else
            dni = InsertarCliente(txtNuevaContratacionNombre.Text.Trim, txtNuevaContratacionApellidos.Text.Trim, txtNuevaContratacionDNI.Text.Trim, txtNuevaContratacionDireccion.Text.Trim, txtNuevaContratacionTelefono.Text.Trim, txtNuevaContratacionEmail.Text.Trim)
            If dni.Equals("") Then
                MsgBox("Ha habido un error con la insercion del dni")
            Else
                idcliente = BuscarIDCliente(dni)
                If idcliente = -1 Then
                    MsgBox("Error, ha habido un error con el ID del Cliente")
                Else
                    If InsertarContratacion(idcliente, txtNuevaContratacionCoste.Text.Trim, DateTimePickerNuevaContratacion.Value.Date) = False Then
                        MsgBox("Error, no se ha insertado la contratación")
                    Else
                        idcontratacion = BuscarIDContratacion(idcliente, txtNuevaContratacionCoste.Text)
                        If idcontratacion = -1 Then
                            MsgBox("Ha habido un error al insertar la tabla contratación")
                        Else
                            If txtNuevaContratacionTipoServicio.Text.ToLower.Trim.Equals("basico") Then
                                tipoServicio = 1
                            ElseIf txtNuevaContratacionTipoServicio.Text.ToLower.Trim.Equals("urgente") Then
                                tipoServicio = 2
                            ElseIf txtNuevaContratacionTipoServicio.Text.ToLower.Trim.Equals("especial") Then
                                tipoServicio = 3
                            End If
                            nombreTrabajador = CBNuevaContratacionTrabajador.SelectedItem
                            idtrabajadores = BuscarIdTrabajador(nombreTrabajador)
                            If InsertarServicio(tipoServicio, idtrabajadores) = True Then
                                idServicios = BuscarIdServicio(tipoServicio, idtrabajadores)
                                MsgBox("ID servicios: " & idServicios)
                                If idServicios <> 0 Then
                                    If InsertarServicioXContratacion(idServicios, idcontratacion) = True Then
                                        MsgBox("Se ha añadido la contratacion correctamente.")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            End If
            Login.Visible = False
            Menu.Visible = False
            Trabajador.Visible = False
            MenuModificarTrabajador.Visible = False
            DarAltaTrabajador.Visible = False
            InformacionTrabajador.Visible = False
            ModificarTrabajador.Visible = False
            BajaTrabajador.Visible = False
            MenuProveedores.Visible = False
            AltaProveedor.Visible = False
            BusquedaModificarProveedor.Visible = False
            ModificarProveedor.Visible = False
            ConsultarProveedor.Visible = False
            BajaProveedor.Visible = False
            MenuClientes.Visible = True
            ClientesAtendidos.Visible = False
            NuevaContratacion.Visible = False
            ContratacionesEnCurso.Visible = False
            CancelarContratacion.Visible = False
            MenuFabrica.Visible = False
            txtNuevaContratacionNombre.Clear()
            txtNuevaContratacionApellidos.Clear()
            txtNuevaContratacionDNI.Clear()
            txtNuevaContratacionDireccion.Clear()
            txtNuevaContratacionTelefono.Clear()
            txtNuevaContratacionEmail.Clear()
            txtNuevaContratacionTipoServicio.Clear()
            txtNuevaContratacionCoste.Clear()
            DateTimePickerNuevaContratacion.ResetText()
        End If
    End Sub

    Private Sub btnConsultaContratacionesAtras_Click(sender As Object, e As EventArgs) Handles btnConsultaContratacionesAtras.Click
        txtConsultaContratacionesNombre.Clear()
        txtConsultaContratacionesApellidos.Clear()
        txtConsultaContratacionesDNI.Clear()
        txtConsultaContratacionesDireccion.Clear()
        txtConsultaContratacionesTelefono.Clear()
        txtConsultaContratacionesEmail.Clear()
        txtConsultaContratacionesCoste.Clear()
        txtConsultaContratacionesFecha.Clear()
        txtConsultaContratacionesTipoServicio.Clear()
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = True
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnCancelarContratacionCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelarContratacionCancelar.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = True
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
        DateTimeCancelarContratacionFecha.ResetText()
        txtCancelarContratacionRazon.Clear()
        txtCancelarContratacionDNI.Clear()
    End Sub

    Private Sub btnCancelarContratacionAceptar_Click(sender As Object, e As EventArgs) Handles btnCancelarContratacionAceptar.Click
        Dim idcliente As Integer
        Dim fecha As Date = Now
        Dim null As String
        If txtCancelarContratacionDNI.Text.Trim.Equals("") Then
            MsgBox("Error, el campo del DNI está vacio.")
        Else
            If BuscarCliente(txtCancelarContratacionDNI.Text.Trim).Equals("") Then
                MsgBox("Error, no hay ningún cliente con ese DNI")
            Else
                idcliente = BuscarIDCliente(txtCancelarContratacionDNI.Text.Trim)
                null = ComprobarContratacionEnCurso(idcliente, DateTimeCancelarContratacionFecha.Value.ToShortDateString.ToString)
                If ComprobarContratacionEnCurso(idcliente, DateTimeCancelarContratacionFecha.Value.ToShortDateString.ToString).Equals("NULL") Then
                    If finalizarContratacion(idcliente, DateTimeCancelarContratacionFecha.Value.ToShortDateString.ToString) = True Then
                        MsgBox("Se ha cancelado correctamente")
                        Login.Visible = False
                        Menu.Visible = False
                        Trabajador.Visible = False
                        MenuModificarTrabajador.Visible = False
                        DarAltaTrabajador.Visible = False
                        InformacionTrabajador.Visible = False
                        ModificarTrabajador.Visible = False
                        BajaTrabajador.Visible = False
                        MenuProveedores.Visible = False
                        AltaProveedor.Visible = False
                        BusquedaModificarProveedor.Visible = False
                        ModificarProveedor.Visible = False
                        ConsultarProveedor.Visible = False
                        BajaProveedor.Visible = False
                        MenuClientes.Visible = True
                        ClientesAtendidos.Visible = False
                        NuevaContratacion.Visible = False
                        ContratacionesEnCurso.Visible = False
                        CancelarContratacion.Visible = False
                        MenuFabrica.Visible = False
                        DateTimeCancelarContratacionFecha.ResetText()
                        txtCancelarContratacionRazon.Clear()
                        txtCancelarContratacionDNI.Clear()
                    Else
                        MsgBox("Ha habido un error")
                    End If
                Else
                    MsgBox("Error, No hay ninguna contratacion en curso.")
                End If

            End If
        End If
    End Sub

    Private Sub btnMenuFabricaSalir_Click(sender As Object, e As EventArgs) Handles btnMenuFabricaSalir.Click
        Login.Visible = True
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = True
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = True
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnFabricas_Click(sender As Object, e As EventArgs) Handles btnFabricas.Click
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = True
    End Sub

    Private Sub btnClientesAtendidosBuscar_Click(sender As Object, e As EventArgs) Handles btnClientesAtendidosBuscar.Click
        Dim datosCliente As ArrayList
        Dim datosClienteV2 As ArrayList
        If BuscarCliente(txtClientesAtendidosBusqueda.Text.Trim).Equals("") Then
            MsgBox("Error, no hay ningún cliente con dicho DNI.")
        Else
            txtClientesAtendidosNombre.Clear()
            txtClientesAtendidosApellidos.Clear()
            txtClientesAtendidosDNI.Clear()
            txtClientesAtendidosDireccion.Clear()
            txtClientesAtendidosTelefono.Clear()
            txtClientesAtendidosEmail.Clear()
            txtClientesAtendidosCoste.Clear()
            txtClientesAtendidosFecha.Clear()
            txtClientesAtendidosTipoServicio.Clear()
            datosCliente = BuscarDatosCliente(txtClientesAtendidosBusqueda.Text.Trim)
            datosClienteV2 = BuscarDatosClienteV2(txtClientesAtendidosBusqueda.Text.Trim)
            txtClientesAtendidosNombre.Text = datosCliente(0).ToString.Trim
            txtClientesAtendidosApellidos.Text = datosCliente(1).ToString.Trim
            txtClientesAtendidosDNI.Text = datosCliente(2).ToString.Trim
            txtClientesAtendidosDireccion.Text = datosCliente(3).ToString.Trim
            txtClientesAtendidosTelefono.Text = datosCliente(4).ToString.Trim
            txtClientesAtendidosEmail.Text = datosCliente(5).ToString.Trim
            txtClientesAtendidosCoste.Text = datosClienteV2(1).ToString.Trim & " €"
            txtClientesAtendidosFecha.Text = datosClienteV2(0).ToString.Trim
            txtClientesAtendidosTipoServicio.Text = BuscarDatosClienteV3(txtClientesAtendidosBusqueda.Text.Trim).Trim
        End If
    End Sub

    Private Sub btnConsultaContratacionesBusqueda_Click(sender As Object, e As EventArgs) Handles btnConsultaContratacionesBusqueda.Click
        Dim cliente As ArrayList
        Dim clientev2 As ArrayList
        If txtConsultaContratacionesBusqueda.Text.Trim.Equals("") Then
            MsgBox("Error, no se ha introducido el DNI del cliente.")
        Else
            txtConsultaContratacionesNombre.Clear()
            txtConsultaContratacionesApellidos.Clear()
            txtConsultaContratacionesDNI.Clear()
            txtConsultaContratacionesDireccion.Clear()
            txtConsultaContratacionesTelefono.Clear()
            txtConsultaContratacionesEmail.Clear()
            txtConsultaContratacionesCoste.Clear()
            txtConsultaContratacionesFecha.Clear()
            txtConsultaContratacionesTipoServicio.Clear()
            cliente = BuscarDatosCliente(txtConsultaContratacionesBusqueda.Text.Trim)
            clientev2 = BuscarDatosClienteV2(txtConsultaContratacionesBusqueda.Text.Trim)
            txtConsultaContratacionesNombre.Text = cliente(0).ToString
            txtConsultaContratacionesApellidos.Text = cliente(1).ToString
            txtConsultaContratacionesDNI.Text = cliente(2).ToString
            txtConsultaContratacionesDireccion.Text = cliente(3).ToString
            txtConsultaContratacionesTelefono.Text = cliente(4).ToString
            txtConsultaContratacionesEmail.Text = cliente(5).ToString
            txtConsultaContratacionesCoste.Text = clientev2(1).ToString
            txtConsultaContratacionesFecha.Text = clientev2(0).ToString
            txtConsultaContratacionesTipoServicio.Text = BuscarDatosClienteV3(txtConsultaContratacionesBusqueda.Text.Trim).ToString
        End If

    End Sub

    Private Sub btnMenuFabricaCIF_Click(sender As Object, e As EventArgs) Handles btnMenuFabricaCIF.Click
        Dim datosfabricas As ArrayList
        If txtMenuFabricaCIF.Text.Trim.Equals("") Then
            MsgBox("Eror, el campo está vacio")
        Else
            datosfabricas = datosFabrica(txtMenuFabricaCIF.Text.Trim)
            If datosFabrica(0).ToString.Equals("") Then
                MsgBox("Error, no se ha encontrado dicha empresa")
            Else
                txtMenuFabricaDireccion.Clear()
                txtMenuFabricaTelefono.Clear()
                txtMenuFabricaEmail.Clear()
                txtMenuFabricaEncargado.Clear()
                txtMenuFabricaProduccion.Clear()
                txtMenuFabricaMaterial.Clear()
                txtMenuFabricaDireccion.Text = datosfabricas(0).ToString
                txtMenuFabricaTelefono.Text = datosfabricas(1).ToString
                txtMenuFabricaEmail.Text = datosfabricas(2).ToString.Trim
                txtMenuFabricaEncargado.Text = datosFabricaEncargado(datosfabricas(3)).ToString
                txtMenuFabricaProduccion.Text = datosFabricaTipoProduccion(datosfabricas(4)).ToString
                txtMenuFabricaMaterial.Text = datosFabricaTipoProducto(datosfabricas(5)).ToString
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConsultarProveedorAtras.Click
        If permisos = 0 Then
            Login.Visible = False
            Menu.Visible = True
            Trabajador.Visible = False
            MenuModificarTrabajador.Visible = False
            DarAltaTrabajador.Visible = False
            InformacionTrabajador.Visible = False
            ModificarTrabajador.Visible = False
            BajaTrabajador.Visible = False
            MenuProveedores.Visible = False
            AltaProveedor.Visible = False
            BusquedaModificarProveedor.Visible = False
            ModificarProveedor.Visible = False
            ConsultarProveedor.Visible = False
            BajaProveedor.Visible = False
            MenuClientes.Visible = False
            ClientesAtendidos.Visible = False
            NuevaContratacion.Visible = False
            ContratacionesEnCurso.Visible = False
            CancelarContratacion.Visible = False
            MenuFabrica.Visible = False
        Else
            MsgBox("Error, usted no puede acceder al menú del administrador.")
        End If
    End Sub

    Private Sub btnConsultarProveedorSailr_Click(sender As Object, e As EventArgs) Handles btnConsultarProveedorSailr.Click
        Login.Visible = True
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnMenuClientesAtras_Click(sender As Object, e As EventArgs) Handles btnMenuClientesAtras.Click
        If permisos = 0 Then
            Login.Visible = False
            Menu.Visible = True
            Trabajador.Visible = False
            MenuModificarTrabajador.Visible = False
            DarAltaTrabajador.Visible = False
            InformacionTrabajador.Visible = False
            ModificarTrabajador.Visible = False
            BajaTrabajador.Visible = False
            MenuProveedores.Visible = False
            AltaProveedor.Visible = False
            BusquedaModificarProveedor.Visible = False
            ModificarProveedor.Visible = False
            ConsultarProveedor.Visible = False
            BajaProveedor.Visible = False
            MenuClientes.Visible = False
            ClientesAtendidos.Visible = False
            NuevaContratacion.Visible = False
            ContratacionesEnCurso.Visible = False
            CancelarContratacion.Visible = False
            MenuFabrica.Visible = False
        Else
            MsgBox("Error, usted no puede acceder al menú del administrador.")
        End If
    End Sub

    Private Sub btnMenuFabricaAtras_Click(sender As Object, e As EventArgs) Handles btnMenuFabricaAtras.Click
        If permisos = 0 Then
            Login.Visible = False
            Menu.Visible = True
            Trabajador.Visible = False
            MenuModificarTrabajador.Visible = False
            DarAltaTrabajador.Visible = False
            InformacionTrabajador.Visible = False
            ModificarTrabajador.Visible = False
            BajaTrabajador.Visible = False
            MenuProveedores.Visible = False
            AltaProveedor.Visible = False
            BusquedaModificarProveedor.Visible = False
            ModificarProveedor.Visible = False
            ConsultarProveedor.Visible = False
            BajaProveedor.Visible = False
            MenuClientes.Visible = False
            ClientesAtendidos.Visible = False
            NuevaContratacion.Visible = False
            ContratacionesEnCurso.Visible = False
            CancelarContratacion.Visible = False
            MenuFabrica.Visible = False
        Else
            MsgBox("Error, usted no puede acceder al menú del administrador.")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Login.Visible = True
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = False
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnConsultarTrabajadorBuscar_Click(sender As Object, e As EventArgs) Handles btnConsultarTrabajadorBuscar.Click
        Dim infotrabajador As ArrayList
        Dim userpass As ArrayList
        Dim sexo = ""
        Dim tipo = ""
        If txtConsultarTrabajadorDNI.Text.Equals("") Then
            MsgBox("Error, el campo está vacío")
        Else
            infotrabajador = BuscarDatosTrabajador(txtConsultarTrabajadorDNI.Text.Trim)
            txtConsultarTrabajadorNombre.ReadOnly = True
            txtConsultarTrabajadorTipoTrabajador.ReadOnly = True
            txtConsultarTrabajadorApellido.ReadOnly = True
            txtConsultarTrabajadorEdad.ReadOnly = True
            txtConsultarTrabajadorAnyosTrabajados.ReadOnly = True
            txtConsultarTrabajadorTel.ReadOnly = True
            txtConsultarTrabajadorEmail.ReadOnly = True
            txtConsultarTrabajadorUsuario.ReadOnly = True
            txtConsultarTrabajadorPass.ReadOnly = True
            txtConsultarTrabajadorSexo.ReadOnly = True
            If infotrabajador(0) = 1 Then
                tipo = "fijo"
            ElseIf infotrabajador(0) = 2 Then
                tipo = "temporal"
            ElseIf infotrabajador(0) = 3 Then
                tipo = "En Practicas"
            End If
            If infotrabajador(8).Equals("m") Then
                sexo = "Masculino"
            ElseIf infotrabajador(8).Equals("f") Then
                sexo = "Femenino"
            End If
            userpass = ConseguirUserPass(infotrabajador(9))
            txtConsultarTrabajadorTipoTrabajador.Text = tipo
            txtConsultarTrabajadorNombre.Text = infotrabajador(1).ToString
            txtConsultarTrabajadorApellido.Text = infotrabajador(2).ToString
            txtConsultarTrabajadorEdad.Text = infotrabajador(3).ToString
            txtConsultarTrabajadorAnyosTrabajados.Text = infotrabajador(4).ToString
            txtConsultarTrabajadorTel.Text = infotrabajador(6).ToString
            txtConsultarTrabajadorEmail.Text = infotrabajador(7).ToString
            txtConsultarTrabajadorUsuario.Text = userpass(0).ToString
            txtConsultarTrabajadorPass.Text = userpass(1).ToString
            txtConsultarTrabajadorSexo.Text = sexo
        End If
        Login.Visible = False
        Menu.Visible = False
        Trabajador.Visible = False
        MenuModificarTrabajador.Visible = False
        DarAltaTrabajador.Visible = False
        InformacionTrabajador.Visible = True
        ModificarTrabajador.Visible = False
        BajaTrabajador.Visible = False
        MenuProveedores.Visible = False
        AltaProveedor.Visible = False
        BusquedaModificarProveedor.Visible = False
        ModificarProveedor.Visible = False
        ConsultarProveedor.Visible = False
        BajaProveedor.Visible = False
        MenuClientes.Visible = False
        ClientesAtendidos.Visible = False
        NuevaContratacion.Visible = False
        ContratacionesEnCurso.Visible = False
        CancelarContratacion.Visible = False
        MenuFabrica.Visible = False
    End Sub

    Private Sub btnConsultarProveedorBuscar_Click(sender As Object, e As EventArgs) Handles btnConsultarProveedorBuscar.Click
        Dim proveedor As ArrayList
        Dim tipoproveedor = ""
        If BuscarDatosProveedor(txtConsultarProveedorCIFBusqueda.Text.Trim).Equals("") Then
            MsgBox("Error, no hay ningún proveedor con dicho CIF.")
        Else
            proveedor = BuscarDatosProveedor(txtConsultarProveedorCIFBusqueda.Text.Trim)
            If proveedor(0) = 1 Then
                tipoproveedor = "Limpieza"
            ElseIf proveedor(0) = 2 Then
                tipoproveedor = "Electricidad"
            ElseIf proveedor(0) = 3 Then
                tipoproveedor = "Carpinteria"
            ElseIf proveedor(0) = 4 Then
                tipoproveedor = "Albañileria"
            ElseIf proveedor(0) = 5 Then
                tipoproveedor = "Fontaneria"
            End If
            txtConsultarProveedorNombreEmpresa.ReadOnly = True
            txtConsultarProveedorNombre.ReadOnly = True
            txtConsultarProveedorApellido.ReadOnly = True
            txtConsultarProveedorCIF.ReadOnly = True
            txtConsultarProveedorDireccion.ReadOnly = True
            txtConsultarProveedorTelefono.ReadOnly = True
            txtConsultarProveedorEmail.ReadOnly = True
            txtConsultarProveedorTipo.ReadOnly = True
            txtConsultarProveedorNombreEmpresa.Text = proveedor(7).ToString
            txtConsultarProveedorNombre.Text = proveedor(1).ToString
            txtConsultarProveedorApellido.Text = proveedor(2).ToString
            txtConsultarProveedorCIF.Text = proveedor(3).ToString
            txtConsultarProveedorDireccion.Text = proveedor(4).ToString
            txtConsultarProveedorTelefono.Text = proveedor(5).ToString
            txtConsultarProveedorEmail.Text = proveedor(6).ToString
            txtConsultarProveedorTipo.Text = tipoproveedor
        End If
    End Sub
End Class