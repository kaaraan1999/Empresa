<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionEmpresa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionEmpresa))
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.btnRecuperarAcc = New System.Windows.Forms.Button()
        Me.Login = New System.Windows.Forms.Panel()
        Me.Menu = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnFabricas = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnTrabajadores = New System.Windows.Forms.Button()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Trabajador = New System.Windows.Forms.Panel()
        Me.btnSalirMenuTrabajador = New System.Windows.Forms.Button()
        Me.btnAtrasMenuTrabajador = New System.Windows.Forms.Button()
        Me.btnBajaTrabajador = New System.Windows.Forms.Button()
        Me.btnModificarTrabajador = New System.Windows.Forms.Button()
        Me.btnConsultarTrabajador = New System.Windows.Forms.Button()
        Me.btnAltaTrabajador = New System.Windows.Forms.Button()
        Me.lblMenuTrabajador = New System.Windows.Forms.Label()
        Me.MenuModificarTrabajador = New System.Windows.Forms.Panel()
        Me.btnModificacionTrabajadorBuscar = New System.Windows.Forms.Button()
        Me.btnModificacionTrabajadorCancelar = New System.Windows.Forms.Button()
        Me.txtMenuModificacionTrabajadorDNI = New System.Windows.Forms.TextBox()
        Me.lblMenuModificacionTrabajadorDNI = New System.Windows.Forms.Label()
        Me.lblModificacionTrabajador = New System.Windows.Forms.Label()
        Me.DarAltaTrabajador = New System.Windows.Forms.Panel()
        Me.txtAltaTrabajadorTipo = New System.Windows.Forms.TextBox()
        Me.lblAltaTrabajadorTipo = New System.Windows.Forms.Label()
        Me.txtAltaTrabajadorSexo = New System.Windows.Forms.TextBox()
        Me.lblAltaTrabajadorSexo = New System.Windows.Forms.Label()
        Me.btnAltaTrabajadoresAceptar = New System.Windows.Forms.Button()
        Me.btnAltaTrabajadoresCancelar = New System.Windows.Forms.Button()
        Me.txtAltaTrabajadorTel = New System.Windows.Forms.TextBox()
        Me.txtAltaTrabajadorEmail = New System.Windows.Forms.TextBox()
        Me.lblAltaTrabajadorTel = New System.Windows.Forms.Label()
        Me.lblAltaTrabajadorEmail = New System.Windows.Forms.Label()
        Me.txtAltaTrabajadorDNI = New System.Windows.Forms.TextBox()
        Me.lblAltaTrabajadorDNI = New System.Windows.Forms.Label()
        Me.txtAltaTrabajadorApellido = New System.Windows.Forms.TextBox()
        Me.txtAltaTrabajadorNombre = New System.Windows.Forms.TextBox()
        Me.DateAltaTrabajadorNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblAltaTrabajadorNacimiento = New System.Windows.Forms.Label()
        Me.lblAltaTrabajadorApellido = New System.Windows.Forms.Label()
        Me.lblAltaTrabajadorNombre = New System.Windows.Forms.Label()
        Me.lblAltaTrabajador = New System.Windows.Forms.Label()
        Me.InformacionTrabajador = New System.Windows.Forms.Panel()
        Me.btnConsultarTrabajadorBuscar = New System.Windows.Forms.Button()
        Me.txtConsultarTrabajadorEdad = New System.Windows.Forms.TextBox()
        Me.txtConsultarTrabajadorPass = New System.Windows.Forms.TextBox()
        Me.lblConsultarTrabajadorPass = New System.Windows.Forms.Label()
        Me.txtConsultarTrabajadorUsuario = New System.Windows.Forms.TextBox()
        Me.lblConsultarTrabajadorUsuario = New System.Windows.Forms.Label()
        Me.lblInformacionTrabajador = New System.Windows.Forms.Label()
        Me.txtConsultarTrabajadorSexo = New System.Windows.Forms.TextBox()
        Me.lblConsultarTrabajadorSexo = New System.Windows.Forms.Label()
        Me.btnConsultarTrabajadorAtras = New System.Windows.Forms.Button()
        Me.txtConsultarTrabajadorTel = New System.Windows.Forms.TextBox()
        Me.txtConsultarTrabajadorEmail = New System.Windows.Forms.TextBox()
        Me.lblConsultarTrabajadorTel = New System.Windows.Forms.Label()
        Me.lblConsultarTrabajadorEmail = New System.Windows.Forms.Label()
        Me.txtConsultarTrabajadorDNI = New System.Windows.Forms.TextBox()
        Me.lblConsultarTrabajadorDNI = New System.Windows.Forms.Label()
        Me.txtConsultarTrabajadorTipoTrabajador = New System.Windows.Forms.TextBox()
        Me.txtConsultarTrabajadorApellido = New System.Windows.Forms.TextBox()
        Me.txtConsultarTrabajadorNombre = New System.Windows.Forms.TextBox()
        Me.lblConsultarTrabajadorTipoTrabajador = New System.Windows.Forms.Label()
        Me.lblConsultarTrabajadorEdad = New System.Windows.Forms.Label()
        Me.lblConsultarTrabajadorApellido = New System.Windows.Forms.Label()
        Me.lblConsultarTrabajadorNombre = New System.Windows.Forms.Label()
        Me.BajaTrabajador = New System.Windows.Forms.Panel()
        Me.btnBajaTrabajadorCancelar = New System.Windows.Forms.Button()
        Me.btnBajaTrabajadorAceptar = New System.Windows.Forms.Button()
        Me.txtBajaTrabajadorRazon = New System.Windows.Forms.TextBox()
        Me.lblBajaTrabajadorRazon = New System.Windows.Forms.Label()
        Me.txtBajaTrabajadorDNI = New System.Windows.Forms.TextBox()
        Me.lblBajaTrabajadorDNI = New System.Windows.Forms.Label()
        Me.lblMenuBajaTrabajador = New System.Windows.Forms.Label()
        Me.ModificarTrabajador = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMenuModificarTrabajadorAnyosTrabajados = New System.Windows.Forms.TextBox()
        Me.txtMenuModificarTrabajadorEdad = New System.Windows.Forms.TextBox()
        Me.txtMenuModificarTrabajadorSexo = New System.Windows.Forms.TextBox()
        Me.lblMenuModificarTrabajadorSexo = New System.Windows.Forms.Label()
        Me.btnMenuModificarTrabajadorAceptar = New System.Windows.Forms.Button()
        Me.btnMenuModificarTrabajadorCancelar = New System.Windows.Forms.Button()
        Me.txtMenuModificarTrabajadorTel = New System.Windows.Forms.TextBox()
        Me.txtMenuModificarTrabajadorEmail = New System.Windows.Forms.TextBox()
        Me.lblMenuModificarTrabajadorTel = New System.Windows.Forms.Label()
        Me.lblMenuModificarTrabajadorEmail = New System.Windows.Forms.Label()
        Me.txtMenuModificarTrabajadorDNI = New System.Windows.Forms.TextBox()
        Me.lblMenuModificarTrabajadorDNI = New System.Windows.Forms.Label()
        Me.txtMenuModificarTrabajadorTipo = New System.Windows.Forms.TextBox()
        Me.txtMenuModificarTrabajadorApellido = New System.Windows.Forms.TextBox()
        Me.txtMenuModificarTrabajadorNombre = New System.Windows.Forms.TextBox()
        Me.lblMenuModificarTrabajadorEspecialidad = New System.Windows.Forms.Label()
        Me.lblMenuModificarTrabajadorNacimiento = New System.Windows.Forms.Label()
        Me.lblMenuModificarTrabajadorApellido = New System.Windows.Forms.Label()
        Me.lblMenuModificarTrabajadorNombre = New System.Windows.Forms.Label()
        Me.lblModificarTrabajador = New System.Windows.Forms.Label()
        Me.MenuProveedores = New System.Windows.Forms.Panel()
        Me.btnConsultarProveedorSailr = New System.Windows.Forms.Button()
        Me.btnConsultarProveedorAtras = New System.Windows.Forms.Button()
        Me.btnBajaProveedor = New System.Windows.Forms.Button()
        Me.btnConsultarProveedor = New System.Windows.Forms.Button()
        Me.btnModificarProveedor = New System.Windows.Forms.Button()
        Me.btnAñadirProveedor = New System.Windows.Forms.Button()
        Me.lblMenuProveedores = New System.Windows.Forms.Label()
        Me.AltaProveedor = New System.Windows.Forms.Panel()
        Me.btnAltaProveedorAceptar = New System.Windows.Forms.Button()
        Me.btnAltaProveedorCancelar = New System.Windows.Forms.Button()
        Me.txtAltaProveedorEmail = New System.Windows.Forms.TextBox()
        Me.txtAltaProveedorTelefono = New System.Windows.Forms.TextBox()
        Me.txtAltaProveedorDireccion = New System.Windows.Forms.TextBox()
        Me.lblAltaProveedorEmail = New System.Windows.Forms.Label()
        Me.lblAltaProveedorTelefono = New System.Windows.Forms.Label()
        Me.lblAltaProveedorDireccion = New System.Windows.Forms.Label()
        Me.txtAltaProveedorTipo = New System.Windows.Forms.TextBox()
        Me.txtAltaProveedorCIF = New System.Windows.Forms.TextBox()
        Me.txtAltaProveedorApellido = New System.Windows.Forms.TextBox()
        Me.txtAltaProveedorNombre = New System.Windows.Forms.TextBox()
        Me.txtAltaProveedorNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.lblAltaProveedorApellido = New System.Windows.Forms.Label()
        Me.lblAltaProveedorTipo = New System.Windows.Forms.Label()
        Me.lblAltaProveedorCIF = New System.Windows.Forms.Label()
        Me.lblAltaProveedorNombre = New System.Windows.Forms.Label()
        Me.lblAltaProveedorNombreEmpresa = New System.Windows.Forms.Label()
        Me.lblMenuAltaProveedor = New System.Windows.Forms.Label()
        Me.BusquedaModificarProveedor = New System.Windows.Forms.Panel()
        Me.btnBusquedaModificacionProveedorBuscar = New System.Windows.Forms.Button()
        Me.btnBusquedaModificacionProveedorCancelar = New System.Windows.Forms.Button()
        Me.txtBusquedaModificarProveedorCIF = New System.Windows.Forms.TextBox()
        Me.lblBusquedaModificarProveedorCIF = New System.Windows.Forms.Label()
        Me.lblBusquedaModificarProveedorTexto = New System.Windows.Forms.Label()
        Me.lblBusquedaModificarProveedor = New System.Windows.Forms.Label()
        Me.ModificarProveedor = New System.Windows.Forms.Panel()
        Me.btnModificarProveedorAceptar = New System.Windows.Forms.Button()
        Me.btnModificarProveedorCancelar = New System.Windows.Forms.Button()
        Me.txtModificarProveedorEmail = New System.Windows.Forms.TextBox()
        Me.txtModificarProveedorTelefono = New System.Windows.Forms.TextBox()
        Me.txtModificarProveedorDireccion = New System.Windows.Forms.TextBox()
        Me.lblModificarProveedorEmail = New System.Windows.Forms.Label()
        Me.lblModificarProveedorTelefono = New System.Windows.Forms.Label()
        Me.lblModificarProveedorDireccion = New System.Windows.Forms.Label()
        Me.txtModificarProveedorTipo = New System.Windows.Forms.TextBox()
        Me.txtModificarProveedorCIF = New System.Windows.Forms.TextBox()
        Me.txtModificarProveedorApellido = New System.Windows.Forms.TextBox()
        Me.txtModificarProveedorNombre = New System.Windows.Forms.TextBox()
        Me.txtModificarProveedorNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.lblModificarProveedorApellido = New System.Windows.Forms.Label()
        Me.lblModificarProveedorTipo = New System.Windows.Forms.Label()
        Me.lblModificarProveedorCIF = New System.Windows.Forms.Label()
        Me.lblModificarProveedorNombre = New System.Windows.Forms.Label()
        Me.lblModificarProveedorNombreEmpresa = New System.Windows.Forms.Label()
        Me.lblModificarProveedor = New System.Windows.Forms.Label()
        Me.ConsultarProveedor = New System.Windows.Forms.Panel()
        Me.btnConsultarProveedorCancelar = New System.Windows.Forms.Button()
        Me.txtConsultarProveedorEmail = New System.Windows.Forms.TextBox()
        Me.txtConsultarProveedorTelefono = New System.Windows.Forms.TextBox()
        Me.txtConsultarProveedorDireccion = New System.Windows.Forms.TextBox()
        Me.lblConsultarProveedorEmail = New System.Windows.Forms.Label()
        Me.lblConsultarProveedorTelefono = New System.Windows.Forms.Label()
        Me.lblConsultarProveedorDireccion = New System.Windows.Forms.Label()
        Me.txtConsultarProveedorTipo = New System.Windows.Forms.TextBox()
        Me.txtConsultarProveedorCIF = New System.Windows.Forms.TextBox()
        Me.txtConsultarProveedorApellido = New System.Windows.Forms.TextBox()
        Me.txtConsultarProveedorNombre = New System.Windows.Forms.TextBox()
        Me.txtConsultarProveedorNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.lblConsultarProveedorApellido = New System.Windows.Forms.Label()
        Me.lblConsultarProveedorTipos = New System.Windows.Forms.Label()
        Me.lblConsultarProveedorCIF = New System.Windows.Forms.Label()
        Me.lblConsultarProveedorNombre = New System.Windows.Forms.Label()
        Me.lblConsultarProveedorNombreEmpresa = New System.Windows.Forms.Label()
        Me.lblConsultarProveedor = New System.Windows.Forms.Label()
        Me.BajaProveedor = New System.Windows.Forms.Panel()
        Me.btnBajaProveedorAceptar = New System.Windows.Forms.Button()
        Me.btnBajaProveedorCancelar = New System.Windows.Forms.Button()
        Me.txtBajaProveedorRazon = New System.Windows.Forms.TextBox()
        Me.lblBajaProveedorRazon = New System.Windows.Forms.Label()
        Me.txtBajaProveedorDNI = New System.Windows.Forms.TextBox()
        Me.lblBajaProveedorDNI = New System.Windows.Forms.Label()
        Me.lblMenuBajaProveedor = New System.Windows.Forms.Label()
        Me.MenuClientes = New System.Windows.Forms.Panel()
        Me.btnMenuClientesAtras = New System.Windows.Forms.Button()
        Me.btnMenuClientesFContratacion = New System.Windows.Forms.Button()
        Me.btnMenuClientesSalir = New System.Windows.Forms.Button()
        Me.btnMenuClientesCContrataciones = New System.Windows.Forms.Button()
        Me.btnMenuClientesNContratacion = New System.Windows.Forms.Button()
        Me.btnMenuClientesAtendidos = New System.Windows.Forms.Button()
        Me.lblMenuClientes = New System.Windows.Forms.Label()
        Me.ClientesAtendidos = New System.Windows.Forms.Panel()
        Me.txtClientesAtendidosFecha = New System.Windows.Forms.TextBox()
        Me.lblClientesAtendidosFecha = New System.Windows.Forms.Label()
        Me.btnClientesAtendidosAtras = New System.Windows.Forms.Button()
        Me.btnClientesAtendidosBuscar = New System.Windows.Forms.Button()
        Me.txtClientesAtendidosCoste = New System.Windows.Forms.TextBox()
        Me.lblClientesAtendidosCoste = New System.Windows.Forms.Label()
        Me.txtClientesAtendidosTipoServicio = New System.Windows.Forms.TextBox()
        Me.lblClientesAtendidosTipoServicio = New System.Windows.Forms.Label()
        Me.txtClientesAtendidosEmail = New System.Windows.Forms.TextBox()
        Me.lblClientesAtendidosEmail = New System.Windows.Forms.Label()
        Me.txtClientesAtendidosTelefono = New System.Windows.Forms.TextBox()
        Me.lblClientesAtendidosTelefono = New System.Windows.Forms.Label()
        Me.txtClientesAtendidosDireccion = New System.Windows.Forms.TextBox()
        Me.lblClientesAtendidosDireccion = New System.Windows.Forms.Label()
        Me.txtClientesAtendidosDNI = New System.Windows.Forms.TextBox()
        Me.lblClientesAtendidosDNI = New System.Windows.Forms.Label()
        Me.txtClientesAtendidosApellidos = New System.Windows.Forms.TextBox()
        Me.lblClientesAtendidosApellidos = New System.Windows.Forms.Label()
        Me.lblClientesAtendidosNombre = New System.Windows.Forms.Label()
        Me.lblClientesAtendidosInformacion = New System.Windows.Forms.Label()
        Me.txtClientesAtendidosNombre = New System.Windows.Forms.TextBox()
        Me.lblClientesAtendidosBusqueda = New System.Windows.Forms.Label()
        Me.txtClientesAtendidosBusqueda = New System.Windows.Forms.TextBox()
        Me.lblMenuClientesAtendidos = New System.Windows.Forms.Label()
        Me.NuevaContratacion = New System.Windows.Forms.Panel()
        Me.CBNuevaContratacionTrabajador = New System.Windows.Forms.ComboBox()
        Me.lblNuevaContratacionTrabajador = New System.Windows.Forms.Label()
        Me.DateTimePickerNuevaContratacion = New System.Windows.Forms.DateTimePicker()
        Me.btnNuevaContratacionAceptar = New System.Windows.Forms.Button()
        Me.btnNuevaContratacionCancelar = New System.Windows.Forms.Button()
        Me.lblNuevaContratacionFechaContratacion = New System.Windows.Forms.Label()
        Me.txtNuevaContratacionCoste = New System.Windows.Forms.TextBox()
        Me.lblNuevaContratacionCoste = New System.Windows.Forms.Label()
        Me.txtNuevaContratacionTipoServicio = New System.Windows.Forms.TextBox()
        Me.lblNuevaContratacionTipoServicio = New System.Windows.Forms.Label()
        Me.txtNuevaContratacionEmail = New System.Windows.Forms.TextBox()
        Me.lblNuevaContratacionEmail = New System.Windows.Forms.Label()
        Me.txtNuevaContratacionTelefono = New System.Windows.Forms.TextBox()
        Me.lblNuevaContratacionTelefono = New System.Windows.Forms.Label()
        Me.txtNuevaContratacionDireccion = New System.Windows.Forms.TextBox()
        Me.lblNuevaContratacionDireccion = New System.Windows.Forms.Label()
        Me.txtNuevaContratacionDNI = New System.Windows.Forms.TextBox()
        Me.lblNuevaContratacionDNI = New System.Windows.Forms.Label()
        Me.txtNuevaContratacionApellidos = New System.Windows.Forms.TextBox()
        Me.lblNuevaContratacionApellidos = New System.Windows.Forms.Label()
        Me.lblNuevaContratacionNombre = New System.Windows.Forms.Label()
        Me.lblNuevaContratacionInfoCliente = New System.Windows.Forms.Label()
        Me.txtNuevaContratacionNombre = New System.Windows.Forms.TextBox()
        Me.lblNuevaContratacion = New System.Windows.Forms.Label()
        Me.ContratacionesEnCurso = New System.Windows.Forms.Panel()
        Me.txtConsultaContratacionesFecha = New System.Windows.Forms.TextBox()
        Me.lblConsultaContratacionesFecha = New System.Windows.Forms.Label()
        Me.btnConsultaContratacionesAtras = New System.Windows.Forms.Button()
        Me.btnConsultaContratacionesBusqueda = New System.Windows.Forms.Button()
        Me.txtConsultaContratacionesCoste = New System.Windows.Forms.TextBox()
        Me.lblConsultaContratacionesCoste = New System.Windows.Forms.Label()
        Me.txtConsultaContratacionesTipoServicio = New System.Windows.Forms.TextBox()
        Me.lblConsultaContratacionesTipoServicio = New System.Windows.Forms.Label()
        Me.txtConsultaContratacionesEmail = New System.Windows.Forms.TextBox()
        Me.lblConsultaContratacionesEmail = New System.Windows.Forms.Label()
        Me.txtConsultaContratacionesTelefono = New System.Windows.Forms.TextBox()
        Me.lblConsultaContratacionesTelefono = New System.Windows.Forms.Label()
        Me.txtConsultaContratacionesDireccion = New System.Windows.Forms.TextBox()
        Me.lblConsultaContratacionesDireccion = New System.Windows.Forms.Label()
        Me.txtConsultaContratacionesDNI = New System.Windows.Forms.TextBox()
        Me.lblConsultaContratacionesDNI = New System.Windows.Forms.Label()
        Me.txtConsultaContratacionesApellidos = New System.Windows.Forms.TextBox()
        Me.lblConsultaContratacionesApellidos = New System.Windows.Forms.Label()
        Me.lblConsultaContratacionesNombre = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtConsultaContratacionesNombre = New System.Windows.Forms.TextBox()
        Me.lblConsultaContratacionesBusqueda = New System.Windows.Forms.Label()
        Me.txtConsultaContratacionesBusqueda = New System.Windows.Forms.TextBox()
        Me.lblConsultaContrataciones = New System.Windows.Forms.Label()
        Me.CancelarContratacion = New System.Windows.Forms.Panel()
        Me.DateTimeCancelarContratacionFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblCancelarContratacionFecha = New System.Windows.Forms.Label()
        Me.btnCancelarContratacionAceptar = New System.Windows.Forms.Button()
        Me.btnCancelarContratacionCancelar = New System.Windows.Forms.Button()
        Me.lblCancelarContratacionRazon = New System.Windows.Forms.Label()
        Me.txtCancelarContratacionRazon = New System.Windows.Forms.TextBox()
        Me.lblCancelarContratacionDNI = New System.Windows.Forms.Label()
        Me.txtCancelarContratacionDNI = New System.Windows.Forms.TextBox()
        Me.lblCancelarContratacion = New System.Windows.Forms.Label()
        Me.MenuFabrica = New System.Windows.Forms.Panel()
        Me.btnMenuFabricaAtras = New System.Windows.Forms.Button()
        Me.btnMenuFabricaSalir = New System.Windows.Forms.Button()
        Me.lblMenuFabricaEmail = New System.Windows.Forms.Label()
        Me.txtMenuFabricaEmail = New System.Windows.Forms.TextBox()
        Me.lblMenuFabricaTelefono = New System.Windows.Forms.Label()
        Me.txtMenuFabricaTelefono = New System.Windows.Forms.TextBox()
        Me.lblMenuFabricaDireccion = New System.Windows.Forms.Label()
        Me.txtMenuFabricaDireccion = New System.Windows.Forms.TextBox()
        Me.lblMenuFabricaProduccion = New System.Windows.Forms.Label()
        Me.txtMenuFabricaProduccion = New System.Windows.Forms.TextBox()
        Me.lblMenuFabricaMaterial = New System.Windows.Forms.Label()
        Me.txtMenuFabricaMaterial = New System.Windows.Forms.TextBox()
        Me.lblMenuFabricaEncargado = New System.Windows.Forms.Label()
        Me.txtMenuFabricaEncargado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMenuFabricaTitulo = New System.Windows.Forms.Label()
        Me.lblMenuFabricaCIF = New System.Windows.Forms.Label()
        Me.txtMenuFabricaCIF = New System.Windows.Forms.TextBox()
        Me.btnMenuFabricaCIF = New System.Windows.Forms.Button()
        Me.lblMenuFabrica = New System.Windows.Forms.Label()
        Me.txtConsultarTrabajadorAnyosTrabajados = New System.Windows.Forms.TextBox()
        Me.lblConsultarTrabajadorAnyosTrabajados = New System.Windows.Forms.Label()
        Me.txtConsultarProveedorCIFBusqueda = New System.Windows.Forms.TextBox()
        Me.lblConsultarProveedorCIFBusqueda = New System.Windows.Forms.Label()
        Me.btnConsultarProveedorBuscar = New System.Windows.Forms.Button()
        Me.Login.SuspendLayout()
        Me.Menu.SuspendLayout()
        Me.Trabajador.SuspendLayout()
        Me.MenuModificarTrabajador.SuspendLayout()
        Me.DarAltaTrabajador.SuspendLayout()
        Me.InformacionTrabajador.SuspendLayout()
        Me.BajaTrabajador.SuspendLayout()
        Me.ModificarTrabajador.SuspendLayout()
        Me.MenuProveedores.SuspendLayout()
        Me.AltaProveedor.SuspendLayout()
        Me.BusquedaModificarProveedor.SuspendLayout()
        Me.ModificarProveedor.SuspendLayout()
        Me.ConsultarProveedor.SuspendLayout()
        Me.BajaProveedor.SuspendLayout()
        Me.MenuClientes.SuspendLayout()
        Me.ClientesAtendidos.SuspendLayout()
        Me.NuevaContratacion.SuspendLayout()
        Me.ContratacionesEnCurso.SuspendLayout()
        Me.CancelarContratacion.SuspendLayout()
        Me.MenuFabrica.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft YaHei", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(268, 58)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(252, 43)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Login Empresa"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(117, 209)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(177, 22)
        Me.txtUsuario.TabIndex = 1
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(461, 209)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(177, 22)
        Me.txtPass.TabIndex = 2
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(156, 146)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(85, 27)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(488, 146)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(119, 27)
        Me.lblPass.TabIndex = 4
        Me.lblPass.Text = "Contraseña"
        '
        'btnAcceder
        '
        Me.btnAcceder.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceder.Location = New System.Drawing.Point(472, 320)
        Me.btnAcceder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(135, 57)
        Me.btnAcceder.TabIndex = 5
        Me.btnAcceder.Text = "Acceder"
        Me.btnAcceder.UseVisualStyleBackColor = True
        '
        'btnRecuperarAcc
        '
        Me.btnRecuperarAcc.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuperarAcc.Location = New System.Drawing.Point(160, 320)
        Me.btnRecuperarAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRecuperarAcc.Name = "btnRecuperarAcc"
        Me.btnRecuperarAcc.Size = New System.Drawing.Size(135, 57)
        Me.btnRecuperarAcc.TabIndex = 6
        Me.btnRecuperarAcc.Text = "Recuperar Contraseña"
        Me.btnRecuperarAcc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRecuperarAcc.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.Login.AutoSize = True
        Me.Login.Controls.Add(Me.lblLogin)
        Me.Login.Controls.Add(Me.btnAcceder)
        Me.Login.Controls.Add(Me.btnRecuperarAcc)
        Me.Login.Controls.Add(Me.lblUsuario)
        Me.Login.Controls.Add(Me.txtUsuario)
        Me.Login.Controls.Add(Me.txtPass)
        Me.Login.Controls.Add(Me.lblPass)
        Me.Login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Login.Location = New System.Drawing.Point(0, 0)
        Me.Login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(773, 422)
        Me.Login.TabIndex = 7
        '
        'Menu
        '
        Me.Menu.AutoSize = True
        Me.Menu.Controls.Add(Me.btnSalir)
        Me.Menu.Controls.Add(Me.btnFabricas)
        Me.Menu.Controls.Add(Me.btnClientes)
        Me.Menu.Controls.Add(Me.btnProveedores)
        Me.Menu.Controls.Add(Me.btnTrabajadores)
        Me.Menu.Controls.Add(Me.lblMenu)
        Me.Menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Menu.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(773, 422)
        Me.Menu.TabIndex = 7
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(592, 361)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(125, 40)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnFabricas
        '
        Me.btnFabricas.Location = New System.Drawing.Point(454, 274)
        Me.btnFabricas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFabricas.Name = "btnFabricas"
        Me.btnFabricas.Size = New System.Drawing.Size(149, 66)
        Me.btnFabricas.TabIndex = 4
        Me.btnFabricas.Text = "Fabricas"
        Me.btnFabricas.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(185, 274)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(149, 66)
        Me.btnClientes.TabIndex = 3
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.Location = New System.Drawing.Point(454, 149)
        Me.btnProveedores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(149, 66)
        Me.btnProveedores.TabIndex = 2
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnTrabajadores
        '
        Me.btnTrabajadores.Location = New System.Drawing.Point(183, 149)
        Me.btnTrabajadores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTrabajadores.Name = "btnTrabajadores"
        Me.btnTrabajadores.Size = New System.Drawing.Size(149, 66)
        Me.btnTrabajadores.TabIndex = 1
        Me.btnTrabajadores.Text = "Trabajadores"
        Me.btnTrabajadores.UseVisualStyleBackColor = True
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Microsoft YaHei", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(325, 42)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(145, 57)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Menú"
        '
        'Trabajador
        '
        Me.Trabajador.AutoSize = True
        Me.Trabajador.Controls.Add(Me.btnSalirMenuTrabajador)
        Me.Trabajador.Controls.Add(Me.btnAtrasMenuTrabajador)
        Me.Trabajador.Controls.Add(Me.btnBajaTrabajador)
        Me.Trabajador.Controls.Add(Me.btnModificarTrabajador)
        Me.Trabajador.Controls.Add(Me.btnConsultarTrabajador)
        Me.Trabajador.Controls.Add(Me.btnAltaTrabajador)
        Me.Trabajador.Controls.Add(Me.lblMenuTrabajador)
        Me.Trabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Trabajador.Location = New System.Drawing.Point(0, 0)
        Me.Trabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Trabajador.Name = "Trabajador"
        Me.Trabajador.Size = New System.Drawing.Size(773, 422)
        Me.Trabajador.TabIndex = 5
        '
        'btnSalirMenuTrabajador
        '
        Me.btnSalirMenuTrabajador.Location = New System.Drawing.Point(524, 373)
        Me.btnSalirMenuTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalirMenuTrabajador.Name = "btnSalirMenuTrabajador"
        Me.btnSalirMenuTrabajador.Size = New System.Drawing.Size(133, 36)
        Me.btnSalirMenuTrabajador.TabIndex = 6
        Me.btnSalirMenuTrabajador.Text = "Salir"
        Me.btnSalirMenuTrabajador.UseVisualStyleBackColor = True
        '
        'btnAtrasMenuTrabajador
        '
        Me.btnAtrasMenuTrabajador.Location = New System.Drawing.Point(129, 373)
        Me.btnAtrasMenuTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAtrasMenuTrabajador.Name = "btnAtrasMenuTrabajador"
        Me.btnAtrasMenuTrabajador.Size = New System.Drawing.Size(133, 36)
        Me.btnAtrasMenuTrabajador.TabIndex = 5
        Me.btnAtrasMenuTrabajador.Text = "Atrás"
        Me.btnAtrasMenuTrabajador.UseVisualStyleBackColor = True
        '
        'btnBajaTrabajador
        '
        Me.btnBajaTrabajador.Location = New System.Drawing.Point(472, 257)
        Me.btnBajaTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBajaTrabajador.Name = "btnBajaTrabajador"
        Me.btnBajaTrabajador.Size = New System.Drawing.Size(131, 66)
        Me.btnBajaTrabajador.TabIndex = 4
        Me.btnBajaTrabajador.Text = "Dar de Baja"
        Me.btnBajaTrabajador.UseVisualStyleBackColor = True
        '
        'btnModificarTrabajador
        '
        Me.btnModificarTrabajador.Location = New System.Drawing.Point(213, 257)
        Me.btnModificarTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModificarTrabajador.Name = "btnModificarTrabajador"
        Me.btnModificarTrabajador.Size = New System.Drawing.Size(131, 66)
        Me.btnModificarTrabajador.TabIndex = 3
        Me.btnModificarTrabajador.Text = "Modificar Trabajador"
        Me.btnModificarTrabajador.UseVisualStyleBackColor = True
        '
        'btnConsultarTrabajador
        '
        Me.btnConsultarTrabajador.Location = New System.Drawing.Point(472, 137)
        Me.btnConsultarTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConsultarTrabajador.Name = "btnConsultarTrabajador"
        Me.btnConsultarTrabajador.Size = New System.Drawing.Size(131, 66)
        Me.btnConsultarTrabajador.TabIndex = 2
        Me.btnConsultarTrabajador.Text = "Consultar Trabajador"
        Me.btnConsultarTrabajador.UseVisualStyleBackColor = True
        '
        'btnAltaTrabajador
        '
        Me.btnAltaTrabajador.Location = New System.Drawing.Point(213, 137)
        Me.btnAltaTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAltaTrabajador.Name = "btnAltaTrabajador"
        Me.btnAltaTrabajador.Size = New System.Drawing.Size(131, 66)
        Me.btnAltaTrabajador.TabIndex = 1
        Me.btnAltaTrabajador.Text = "Dar de Alta"
        Me.btnAltaTrabajador.UseVisualStyleBackColor = True
        '
        'lblMenuTrabajador
        '
        Me.lblMenuTrabajador.AutoSize = True
        Me.lblMenuTrabajador.Font = New System.Drawing.Font("Microsoft YaHei", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuTrabajador.Location = New System.Drawing.Point(244, 46)
        Me.lblMenuTrabajador.Name = "lblMenuTrabajador"
        Me.lblMenuTrabajador.Size = New System.Drawing.Size(325, 43)
        Me.lblMenuTrabajador.TabIndex = 0
        Me.lblMenuTrabajador.Text = "Menú Trabajadores"
        '
        'MenuModificarTrabajador
        '
        Me.MenuModificarTrabajador.Controls.Add(Me.btnModificacionTrabajadorBuscar)
        Me.MenuModificarTrabajador.Controls.Add(Me.btnModificacionTrabajadorCancelar)
        Me.MenuModificarTrabajador.Controls.Add(Me.txtMenuModificacionTrabajadorDNI)
        Me.MenuModificarTrabajador.Controls.Add(Me.lblMenuModificacionTrabajadorDNI)
        Me.MenuModificarTrabajador.Controls.Add(Me.lblModificacionTrabajador)
        Me.MenuModificarTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuModificarTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.MenuModificarTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MenuModificarTrabajador.Name = "MenuModificarTrabajador"
        Me.MenuModificarTrabajador.Size = New System.Drawing.Size(773, 422)
        Me.MenuModificarTrabajador.TabIndex = 7
        '
        'btnModificacionTrabajadorBuscar
        '
        Me.btnModificacionTrabajadorBuscar.Location = New System.Drawing.Point(517, 364)
        Me.btnModificacionTrabajadorBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModificacionTrabajadorBuscar.Name = "btnModificacionTrabajadorBuscar"
        Me.btnModificacionTrabajadorBuscar.Size = New System.Drawing.Size(125, 37)
        Me.btnModificacionTrabajadorBuscar.TabIndex = 4
        Me.btnModificacionTrabajadorBuscar.Text = "Buscar"
        Me.btnModificacionTrabajadorBuscar.UseVisualStyleBackColor = True
        '
        'btnModificacionTrabajadorCancelar
        '
        Me.btnModificacionTrabajadorCancelar.Location = New System.Drawing.Point(169, 366)
        Me.btnModificacionTrabajadorCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModificacionTrabajadorCancelar.Name = "btnModificacionTrabajadorCancelar"
        Me.btnModificacionTrabajadorCancelar.Size = New System.Drawing.Size(125, 37)
        Me.btnModificacionTrabajadorCancelar.TabIndex = 3
        Me.btnModificacionTrabajadorCancelar.Text = "Cancelar"
        Me.btnModificacionTrabajadorCancelar.UseVisualStyleBackColor = True
        '
        'txtMenuModificacionTrabajadorDNI
        '
        Me.txtMenuModificacionTrabajadorDNI.Location = New System.Drawing.Point(216, 210)
        Me.txtMenuModificacionTrabajadorDNI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMenuModificacionTrabajadorDNI.Name = "txtMenuModificacionTrabajadorDNI"
        Me.txtMenuModificacionTrabajadorDNI.Size = New System.Drawing.Size(167, 22)
        Me.txtMenuModificacionTrabajadorDNI.TabIndex = 2
        '
        'lblMenuModificacionTrabajadorDNI
        '
        Me.lblMenuModificacionTrabajadorDNI.AutoSize = True
        Me.lblMenuModificacionTrabajadorDNI.Location = New System.Drawing.Point(145, 217)
        Me.lblMenuModificacionTrabajadorDNI.Name = "lblMenuModificacionTrabajadorDNI"
        Me.lblMenuModificacionTrabajadorDNI.Size = New System.Drawing.Size(31, 17)
        Me.lblMenuModificacionTrabajadorDNI.TabIndex = 1
        Me.lblMenuModificacionTrabajadorDNI.Text = "DNI"
        '
        'lblModificacionTrabajador
        '
        Me.lblModificacionTrabajador.AutoSize = True
        Me.lblModificacionTrabajador.Font = New System.Drawing.Font("Microsoft YaHei", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificacionTrabajador.Location = New System.Drawing.Point(141, 48)
        Me.lblModificacionTrabajador.Name = "lblModificacionTrabajador"
        Me.lblModificacionTrabajador.Size = New System.Drawing.Size(506, 43)
        Me.lblModificacionTrabajador.TabIndex = 0
        Me.lblModificacionTrabajador.Text = "Menú Modificación Trabajador"
        '
        'DarAltaTrabajador
        '
        Me.DarAltaTrabajador.Controls.Add(Me.txtAltaTrabajadorTipo)
        Me.DarAltaTrabajador.Controls.Add(Me.lblAltaTrabajadorTipo)
        Me.DarAltaTrabajador.Controls.Add(Me.txtAltaTrabajadorSexo)
        Me.DarAltaTrabajador.Controls.Add(Me.lblAltaTrabajadorSexo)
        Me.DarAltaTrabajador.Controls.Add(Me.btnAltaTrabajadoresAceptar)
        Me.DarAltaTrabajador.Controls.Add(Me.btnAltaTrabajadoresCancelar)
        Me.DarAltaTrabajador.Controls.Add(Me.txtAltaTrabajadorTel)
        Me.DarAltaTrabajador.Controls.Add(Me.txtAltaTrabajadorEmail)
        Me.DarAltaTrabajador.Controls.Add(Me.lblAltaTrabajadorTel)
        Me.DarAltaTrabajador.Controls.Add(Me.lblAltaTrabajadorEmail)
        Me.DarAltaTrabajador.Controls.Add(Me.txtAltaTrabajadorDNI)
        Me.DarAltaTrabajador.Controls.Add(Me.lblAltaTrabajadorDNI)
        Me.DarAltaTrabajador.Controls.Add(Me.txtAltaTrabajadorApellido)
        Me.DarAltaTrabajador.Controls.Add(Me.txtAltaTrabajadorNombre)
        Me.DarAltaTrabajador.Controls.Add(Me.DateAltaTrabajadorNacimiento)
        Me.DarAltaTrabajador.Controls.Add(Me.lblAltaTrabajadorNacimiento)
        Me.DarAltaTrabajador.Controls.Add(Me.lblAltaTrabajadorApellido)
        Me.DarAltaTrabajador.Controls.Add(Me.lblAltaTrabajadorNombre)
        Me.DarAltaTrabajador.Controls.Add(Me.lblAltaTrabajador)
        Me.DarAltaTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DarAltaTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.DarAltaTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DarAltaTrabajador.Name = "DarAltaTrabajador"
        Me.DarAltaTrabajador.Size = New System.Drawing.Size(773, 422)
        Me.DarAltaTrabajador.TabIndex = 7
        '
        'txtAltaTrabajadorTipo
        '
        Me.txtAltaTrabajadorTipo.Location = New System.Drawing.Point(251, 309)
        Me.txtAltaTrabajadorTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaTrabajadorTipo.Name = "txtAltaTrabajadorTipo"
        Me.txtAltaTrabajadorTipo.Size = New System.Drawing.Size(183, 22)
        Me.txtAltaTrabajadorTipo.TabIndex = 20
        '
        'lblAltaTrabajadorTipo
        '
        Me.lblAltaTrabajadorTipo.AutoSize = True
        Me.lblAltaTrabajadorTipo.Location = New System.Drawing.Point(56, 312)
        Me.lblAltaTrabajadorTipo.Name = "lblAltaTrabajadorTipo"
        Me.lblAltaTrabajadorTipo.Size = New System.Drawing.Size(110, 17)
        Me.lblAltaTrabajadorTipo.TabIndex = 19
        Me.lblAltaTrabajadorTipo.Text = "Tipo Trabajador"
        '
        'txtAltaTrabajadorSexo
        '
        Me.txtAltaTrabajadorSexo.Location = New System.Drawing.Point(565, 217)
        Me.txtAltaTrabajadorSexo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaTrabajadorSexo.Name = "txtAltaTrabajadorSexo"
        Me.txtAltaTrabajadorSexo.Size = New System.Drawing.Size(183, 22)
        Me.txtAltaTrabajadorSexo.TabIndex = 18
        '
        'lblAltaTrabajadorSexo
        '
        Me.lblAltaTrabajadorSexo.AutoSize = True
        Me.lblAltaTrabajadorSexo.Location = New System.Drawing.Point(453, 220)
        Me.lblAltaTrabajadorSexo.Name = "lblAltaTrabajadorSexo"
        Me.lblAltaTrabajadorSexo.Size = New System.Drawing.Size(39, 17)
        Me.lblAltaTrabajadorSexo.TabIndex = 17
        Me.lblAltaTrabajadorSexo.Text = "Sexo"
        '
        'btnAltaTrabajadoresAceptar
        '
        Me.btnAltaTrabajadoresAceptar.Location = New System.Drawing.Point(499, 373)
        Me.btnAltaTrabajadoresAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAltaTrabajadoresAceptar.Name = "btnAltaTrabajadoresAceptar"
        Me.btnAltaTrabajadoresAceptar.Size = New System.Drawing.Size(140, 38)
        Me.btnAltaTrabajadoresAceptar.TabIndex = 16
        Me.btnAltaTrabajadoresAceptar.Text = "Aceptar"
        Me.btnAltaTrabajadoresAceptar.UseVisualStyleBackColor = True
        '
        'btnAltaTrabajadoresCancelar
        '
        Me.btnAltaTrabajadoresCancelar.Location = New System.Drawing.Point(160, 371)
        Me.btnAltaTrabajadoresCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAltaTrabajadoresCancelar.Name = "btnAltaTrabajadoresCancelar"
        Me.btnAltaTrabajadoresCancelar.Size = New System.Drawing.Size(140, 38)
        Me.btnAltaTrabajadoresCancelar.TabIndex = 15
        Me.btnAltaTrabajadoresCancelar.Text = "Cancelar"
        Me.btnAltaTrabajadoresCancelar.UseVisualStyleBackColor = True
        '
        'txtAltaTrabajadorTel
        '
        Me.txtAltaTrabajadorTel.Location = New System.Drawing.Point(565, 168)
        Me.txtAltaTrabajadorTel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaTrabajadorTel.Name = "txtAltaTrabajadorTel"
        Me.txtAltaTrabajadorTel.Size = New System.Drawing.Size(183, 22)
        Me.txtAltaTrabajadorTel.TabIndex = 14
        '
        'txtAltaTrabajadorEmail
        '
        Me.txtAltaTrabajadorEmail.Location = New System.Drawing.Point(565, 113)
        Me.txtAltaTrabajadorEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaTrabajadorEmail.Name = "txtAltaTrabajadorEmail"
        Me.txtAltaTrabajadorEmail.Size = New System.Drawing.Size(183, 22)
        Me.txtAltaTrabajadorEmail.TabIndex = 13
        '
        'lblAltaTrabajadorTel
        '
        Me.lblAltaTrabajadorTel.AutoSize = True
        Me.lblAltaTrabajadorTel.Location = New System.Drawing.Point(453, 173)
        Me.lblAltaTrabajadorTel.Name = "lblAltaTrabajadorTel"
        Me.lblAltaTrabajadorTel.Size = New System.Drawing.Size(83, 17)
        Me.lblAltaTrabajadorTel.TabIndex = 12
        Me.lblAltaTrabajadorTel.Text = "Nº Telefono"
        '
        'lblAltaTrabajadorEmail
        '
        Me.lblAltaTrabajadorEmail.AutoSize = True
        Me.lblAltaTrabajadorEmail.Location = New System.Drawing.Point(453, 115)
        Me.lblAltaTrabajadorEmail.Name = "lblAltaTrabajadorEmail"
        Me.lblAltaTrabajadorEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblAltaTrabajadorEmail.TabIndex = 11
        Me.lblAltaTrabajadorEmail.Text = "Email"
        '
        'txtAltaTrabajadorDNI
        '
        Me.txtAltaTrabajadorDNI.Location = New System.Drawing.Point(251, 217)
        Me.txtAltaTrabajadorDNI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaTrabajadorDNI.Name = "txtAltaTrabajadorDNI"
        Me.txtAltaTrabajadorDNI.Size = New System.Drawing.Size(183, 22)
        Me.txtAltaTrabajadorDNI.TabIndex = 10
        '
        'lblAltaTrabajadorDNI
        '
        Me.lblAltaTrabajadorDNI.AutoSize = True
        Me.lblAltaTrabajadorDNI.Location = New System.Drawing.Point(56, 219)
        Me.lblAltaTrabajadorDNI.Name = "lblAltaTrabajadorDNI"
        Me.lblAltaTrabajadorDNI.Size = New System.Drawing.Size(31, 17)
        Me.lblAltaTrabajadorDNI.TabIndex = 9
        Me.lblAltaTrabajadorDNI.Text = "DNI"
        '
        'txtAltaTrabajadorApellido
        '
        Me.txtAltaTrabajadorApellido.Location = New System.Drawing.Point(252, 165)
        Me.txtAltaTrabajadorApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaTrabajadorApellido.Name = "txtAltaTrabajadorApellido"
        Me.txtAltaTrabajadorApellido.Size = New System.Drawing.Size(183, 22)
        Me.txtAltaTrabajadorApellido.TabIndex = 7
        '
        'txtAltaTrabajadorNombre
        '
        Me.txtAltaTrabajadorNombre.Location = New System.Drawing.Point(252, 110)
        Me.txtAltaTrabajadorNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaTrabajadorNombre.Name = "txtAltaTrabajadorNombre"
        Me.txtAltaTrabajadorNombre.Size = New System.Drawing.Size(183, 22)
        Me.txtAltaTrabajadorNombre.TabIndex = 6
        '
        'DateAltaTrabajadorNacimiento
        '
        Me.DateAltaTrabajadorNacimiento.Location = New System.Drawing.Point(251, 265)
        Me.DateAltaTrabajadorNacimiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateAltaTrabajadorNacimiento.Name = "DateAltaTrabajadorNacimiento"
        Me.DateAltaTrabajadorNacimiento.Size = New System.Drawing.Size(361, 22)
        Me.DateAltaTrabajadorNacimiento.TabIndex = 4
        '
        'lblAltaTrabajadorNacimiento
        '
        Me.lblAltaTrabajadorNacimiento.AutoSize = True
        Me.lblAltaTrabajadorNacimiento.Location = New System.Drawing.Point(56, 265)
        Me.lblAltaTrabajadorNacimiento.Name = "lblAltaTrabajadorNacimiento"
        Me.lblAltaTrabajadorNacimiento.Size = New System.Drawing.Size(141, 17)
        Me.lblAltaTrabajadorNacimiento.TabIndex = 3
        Me.lblAltaTrabajadorNacimiento.Text = "Fecha de Nacimiento"
        '
        'lblAltaTrabajadorApellido
        '
        Me.lblAltaTrabajadorApellido.AutoSize = True
        Me.lblAltaTrabajadorApellido.Location = New System.Drawing.Point(56, 165)
        Me.lblAltaTrabajadorApellido.Name = "lblAltaTrabajadorApellido"
        Me.lblAltaTrabajadorApellido.Size = New System.Drawing.Size(58, 17)
        Me.lblAltaTrabajadorApellido.TabIndex = 2
        Me.lblAltaTrabajadorApellido.Text = "Apellido"
        '
        'lblAltaTrabajadorNombre
        '
        Me.lblAltaTrabajadorNombre.AutoSize = True
        Me.lblAltaTrabajadorNombre.Location = New System.Drawing.Point(56, 110)
        Me.lblAltaTrabajadorNombre.Name = "lblAltaTrabajadorNombre"
        Me.lblAltaTrabajadorNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblAltaTrabajadorNombre.TabIndex = 1
        Me.lblAltaTrabajadorNombre.Text = "Nombre"
        '
        'lblAltaTrabajador
        '
        Me.lblAltaTrabajador.AutoSize = True
        Me.lblAltaTrabajador.Font = New System.Drawing.Font("Microsoft YaHei", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaTrabajador.Location = New System.Drawing.Point(243, 34)
        Me.lblAltaTrabajador.Name = "lblAltaTrabajador"
        Me.lblAltaTrabajador.Size = New System.Drawing.Size(312, 43)
        Me.lblAltaTrabajador.TabIndex = 0
        Me.lblAltaTrabajador.Text = "Alta de Trabajador"
        '
        'InformacionTrabajador
        '
        Me.InformacionTrabajador.Controls.Add(Me.txtConsultarTrabajadorAnyosTrabajados)
        Me.InformacionTrabajador.Controls.Add(Me.lblConsultarTrabajadorAnyosTrabajados)
        Me.InformacionTrabajador.Controls.Add(Me.btnConsultarTrabajadorBuscar)
        Me.InformacionTrabajador.Controls.Add(Me.txtConsultarTrabajadorEdad)
        Me.InformacionTrabajador.Controls.Add(Me.txtConsultarTrabajadorPass)
        Me.InformacionTrabajador.Controls.Add(Me.lblConsultarTrabajadorPass)
        Me.InformacionTrabajador.Controls.Add(Me.txtConsultarTrabajadorUsuario)
        Me.InformacionTrabajador.Controls.Add(Me.lblConsultarTrabajadorUsuario)
        Me.InformacionTrabajador.Controls.Add(Me.lblInformacionTrabajador)
        Me.InformacionTrabajador.Controls.Add(Me.txtConsultarTrabajadorSexo)
        Me.InformacionTrabajador.Controls.Add(Me.lblConsultarTrabajadorSexo)
        Me.InformacionTrabajador.Controls.Add(Me.btnConsultarTrabajadorAtras)
        Me.InformacionTrabajador.Controls.Add(Me.txtConsultarTrabajadorTel)
        Me.InformacionTrabajador.Controls.Add(Me.txtConsultarTrabajadorEmail)
        Me.InformacionTrabajador.Controls.Add(Me.lblConsultarTrabajadorTel)
        Me.InformacionTrabajador.Controls.Add(Me.lblConsultarTrabajadorEmail)
        Me.InformacionTrabajador.Controls.Add(Me.txtConsultarTrabajadorDNI)
        Me.InformacionTrabajador.Controls.Add(Me.lblConsultarTrabajadorDNI)
        Me.InformacionTrabajador.Controls.Add(Me.txtConsultarTrabajadorTipoTrabajador)
        Me.InformacionTrabajador.Controls.Add(Me.txtConsultarTrabajadorApellido)
        Me.InformacionTrabajador.Controls.Add(Me.txtConsultarTrabajadorNombre)
        Me.InformacionTrabajador.Controls.Add(Me.lblConsultarTrabajadorTipoTrabajador)
        Me.InformacionTrabajador.Controls.Add(Me.lblConsultarTrabajadorEdad)
        Me.InformacionTrabajador.Controls.Add(Me.lblConsultarTrabajadorApellido)
        Me.InformacionTrabajador.Controls.Add(Me.lblConsultarTrabajadorNombre)
        Me.InformacionTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InformacionTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.InformacionTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InformacionTrabajador.Name = "InformacionTrabajador"
        Me.InformacionTrabajador.Size = New System.Drawing.Size(773, 422)
        Me.InformacionTrabajador.TabIndex = 5
        '
        'btnConsultarTrabajadorBuscar
        '
        Me.btnConsultarTrabajadorBuscar.Location = New System.Drawing.Point(551, 69)
        Me.btnConsultarTrabajadorBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConsultarTrabajadorBuscar.Name = "btnConsultarTrabajadorBuscar"
        Me.btnConsultarTrabajadorBuscar.Size = New System.Drawing.Size(140, 38)
        Me.btnConsultarTrabajadorBuscar.TabIndex = 43
        Me.btnConsultarTrabajadorBuscar.Text = "Buscar"
        Me.btnConsultarTrabajadorBuscar.UseVisualStyleBackColor = True
        '
        'txtConsultarTrabajadorEdad
        '
        Me.txtConsultarTrabajadorEdad.Location = New System.Drawing.Point(209, 273)
        Me.txtConsultarTrabajadorEdad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarTrabajadorEdad.Name = "txtConsultarTrabajadorEdad"
        Me.txtConsultarTrabajadorEdad.Size = New System.Drawing.Size(183, 22)
        Me.txtConsultarTrabajadorEdad.TabIndex = 42
        '
        'txtConsultarTrabajadorPass
        '
        Me.txtConsultarTrabajadorPass.Location = New System.Drawing.Point(547, 327)
        Me.txtConsultarTrabajadorPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarTrabajadorPass.Name = "txtConsultarTrabajadorPass"
        Me.txtConsultarTrabajadorPass.Size = New System.Drawing.Size(183, 22)
        Me.txtConsultarTrabajadorPass.TabIndex = 41
        '
        'lblConsultarTrabajadorPass
        '
        Me.lblConsultarTrabajadorPass.AutoSize = True
        Me.lblConsultarTrabajadorPass.Location = New System.Drawing.Point(423, 330)
        Me.lblConsultarTrabajadorPass.Name = "lblConsultarTrabajadorPass"
        Me.lblConsultarTrabajadorPass.Size = New System.Drawing.Size(81, 17)
        Me.lblConsultarTrabajadorPass.TabIndex = 40
        Me.lblConsultarTrabajadorPass.Text = "Contraseña"
        '
        'txtConsultarTrabajadorUsuario
        '
        Me.txtConsultarTrabajadorUsuario.Location = New System.Drawing.Point(547, 277)
        Me.txtConsultarTrabajadorUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarTrabajadorUsuario.Name = "txtConsultarTrabajadorUsuario"
        Me.txtConsultarTrabajadorUsuario.Size = New System.Drawing.Size(183, 22)
        Me.txtConsultarTrabajadorUsuario.TabIndex = 39
        '
        'lblConsultarTrabajadorUsuario
        '
        Me.lblConsultarTrabajadorUsuario.AutoSize = True
        Me.lblConsultarTrabajadorUsuario.Location = New System.Drawing.Point(427, 279)
        Me.lblConsultarTrabajadorUsuario.Name = "lblConsultarTrabajadorUsuario"
        Me.lblConsultarTrabajadorUsuario.Size = New System.Drawing.Size(57, 17)
        Me.lblConsultarTrabajadorUsuario.TabIndex = 38
        Me.lblConsultarTrabajadorUsuario.Text = "Usuario"
        '
        'lblInformacionTrabajador
        '
        Me.lblInformacionTrabajador.AutoSize = True
        Me.lblInformacionTrabajador.Font = New System.Drawing.Font("Microsoft YaHei", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformacionTrabajador.Location = New System.Drawing.Point(209, 15)
        Me.lblInformacionTrabajador.Name = "lblInformacionTrabajador"
        Me.lblInformacionTrabajador.Size = New System.Drawing.Size(391, 43)
        Me.lblInformacionTrabajador.TabIndex = 37
        Me.lblInformacionTrabajador.Text = "Información Trabajador"
        '
        'txtConsultarTrabajadorSexo
        '
        Me.txtConsultarTrabajadorSexo.Location = New System.Drawing.Point(209, 228)
        Me.txtConsultarTrabajadorSexo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarTrabajadorSexo.Name = "txtConsultarTrabajadorSexo"
        Me.txtConsultarTrabajadorSexo.Size = New System.Drawing.Size(183, 22)
        Me.txtConsultarTrabajadorSexo.TabIndex = 36
        '
        'lblConsultarTrabajadorSexo
        '
        Me.lblConsultarTrabajadorSexo.AutoSize = True
        Me.lblConsultarTrabajadorSexo.Location = New System.Drawing.Point(87, 230)
        Me.lblConsultarTrabajadorSexo.Name = "lblConsultarTrabajadorSexo"
        Me.lblConsultarTrabajadorSexo.Size = New System.Drawing.Size(39, 17)
        Me.lblConsultarTrabajadorSexo.TabIndex = 35
        Me.lblConsultarTrabajadorSexo.Text = "Sexo"
        '
        'btnConsultarTrabajadorAtras
        '
        Me.btnConsultarTrabajadorAtras.Location = New System.Drawing.Point(79, 368)
        Me.btnConsultarTrabajadorAtras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConsultarTrabajadorAtras.Name = "btnConsultarTrabajadorAtras"
        Me.btnConsultarTrabajadorAtras.Size = New System.Drawing.Size(140, 38)
        Me.btnConsultarTrabajadorAtras.TabIndex = 33
        Me.btnConsultarTrabajadorAtras.Text = "Atrás"
        Me.btnConsultarTrabajadorAtras.UseVisualStyleBackColor = True
        '
        'txtConsultarTrabajadorTel
        '
        Me.txtConsultarTrabajadorTel.Location = New System.Drawing.Point(547, 230)
        Me.txtConsultarTrabajadorTel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarTrabajadorTel.Name = "txtConsultarTrabajadorTel"
        Me.txtConsultarTrabajadorTel.Size = New System.Drawing.Size(183, 22)
        Me.txtConsultarTrabajadorTel.TabIndex = 32
        '
        'txtConsultarTrabajadorEmail
        '
        Me.txtConsultarTrabajadorEmail.Location = New System.Drawing.Point(547, 182)
        Me.txtConsultarTrabajadorEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarTrabajadorEmail.Name = "txtConsultarTrabajadorEmail"
        Me.txtConsultarTrabajadorEmail.Size = New System.Drawing.Size(183, 22)
        Me.txtConsultarTrabajadorEmail.TabIndex = 31
        '
        'lblConsultarTrabajadorTel
        '
        Me.lblConsultarTrabajadorTel.AutoSize = True
        Me.lblConsultarTrabajadorTel.Location = New System.Drawing.Point(426, 236)
        Me.lblConsultarTrabajadorTel.Name = "lblConsultarTrabajadorTel"
        Me.lblConsultarTrabajadorTel.Size = New System.Drawing.Size(83, 17)
        Me.lblConsultarTrabajadorTel.TabIndex = 30
        Me.lblConsultarTrabajadorTel.Text = "Nº Telefono"
        '
        'lblConsultarTrabajadorEmail
        '
        Me.lblConsultarTrabajadorEmail.AutoSize = True
        Me.lblConsultarTrabajadorEmail.Location = New System.Drawing.Point(427, 185)
        Me.lblConsultarTrabajadorEmail.Name = "lblConsultarTrabajadorEmail"
        Me.lblConsultarTrabajadorEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblConsultarTrabajadorEmail.TabIndex = 29
        Me.lblConsultarTrabajadorEmail.Text = "Email"
        '
        'txtConsultarTrabajadorDNI
        '
        Me.txtConsultarTrabajadorDNI.Location = New System.Drawing.Point(415, 75)
        Me.txtConsultarTrabajadorDNI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarTrabajadorDNI.Name = "txtConsultarTrabajadorDNI"
        Me.txtConsultarTrabajadorDNI.Size = New System.Drawing.Size(116, 22)
        Me.txtConsultarTrabajadorDNI.TabIndex = 28
        '
        'lblConsultarTrabajadorDNI
        '
        Me.lblConsultarTrabajadorDNI.AutoSize = True
        Me.lblConsultarTrabajadorDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultarTrabajadorDNI.Location = New System.Drawing.Point(81, 77)
        Me.lblConsultarTrabajadorDNI.Name = "lblConsultarTrabajadorDNI"
        Me.lblConsultarTrabajadorDNI.Size = New System.Drawing.Size(283, 20)
        Me.lblConsultarTrabajadorDNI.TabIndex = 27
        Me.lblConsultarTrabajadorDNI.Text = "Introduzca el DNI del Trabajador"
        '
        'txtConsultarTrabajadorTipoTrabajador
        '
        Me.txtConsultarTrabajadorTipoTrabajador.Location = New System.Drawing.Point(209, 326)
        Me.txtConsultarTrabajadorTipoTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarTrabajadorTipoTrabajador.Name = "txtConsultarTrabajadorTipoTrabajador"
        Me.txtConsultarTrabajadorTipoTrabajador.Size = New System.Drawing.Size(183, 22)
        Me.txtConsultarTrabajadorTipoTrabajador.TabIndex = 26
        '
        'txtConsultarTrabajadorApellido
        '
        Me.txtConsultarTrabajadorApellido.Location = New System.Drawing.Point(209, 179)
        Me.txtConsultarTrabajadorApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarTrabajadorApellido.Name = "txtConsultarTrabajadorApellido"
        Me.txtConsultarTrabajadorApellido.Size = New System.Drawing.Size(183, 22)
        Me.txtConsultarTrabajadorApellido.TabIndex = 25
        '
        'txtConsultarTrabajadorNombre
        '
        Me.txtConsultarTrabajadorNombre.Location = New System.Drawing.Point(209, 129)
        Me.txtConsultarTrabajadorNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarTrabajadorNombre.Name = "txtConsultarTrabajadorNombre"
        Me.txtConsultarTrabajadorNombre.Size = New System.Drawing.Size(183, 22)
        Me.txtConsultarTrabajadorNombre.TabIndex = 24
        '
        'lblConsultarTrabajadorTipoTrabajador
        '
        Me.lblConsultarTrabajadorTipoTrabajador.AutoSize = True
        Me.lblConsultarTrabajadorTipoTrabajador.Location = New System.Drawing.Point(87, 332)
        Me.lblConsultarTrabajadorTipoTrabajador.Name = "lblConsultarTrabajadorTipoTrabajador"
        Me.lblConsultarTrabajadorTipoTrabajador.Size = New System.Drawing.Size(110, 17)
        Me.lblConsultarTrabajadorTipoTrabajador.TabIndex = 23
        Me.lblConsultarTrabajadorTipoTrabajador.Text = "Tipo Trabajador"
        '
        'lblConsultarTrabajadorEdad
        '
        Me.lblConsultarTrabajadorEdad.AutoSize = True
        Me.lblConsultarTrabajadorEdad.Location = New System.Drawing.Point(87, 280)
        Me.lblConsultarTrabajadorEdad.Name = "lblConsultarTrabajadorEdad"
        Me.lblConsultarTrabajadorEdad.Size = New System.Drawing.Size(41, 17)
        Me.lblConsultarTrabajadorEdad.TabIndex = 21
        Me.lblConsultarTrabajadorEdad.Text = "Edad"
        '
        'lblConsultarTrabajadorApellido
        '
        Me.lblConsultarTrabajadorApellido.AutoSize = True
        Me.lblConsultarTrabajadorApellido.Location = New System.Drawing.Point(87, 186)
        Me.lblConsultarTrabajadorApellido.Name = "lblConsultarTrabajadorApellido"
        Me.lblConsultarTrabajadorApellido.Size = New System.Drawing.Size(58, 17)
        Me.lblConsultarTrabajadorApellido.TabIndex = 20
        Me.lblConsultarTrabajadorApellido.Text = "Apellido"
        '
        'lblConsultarTrabajadorNombre
        '
        Me.lblConsultarTrabajadorNombre.AutoSize = True
        Me.lblConsultarTrabajadorNombre.Location = New System.Drawing.Point(87, 131)
        Me.lblConsultarTrabajadorNombre.Name = "lblConsultarTrabajadorNombre"
        Me.lblConsultarTrabajadorNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblConsultarTrabajadorNombre.TabIndex = 19
        Me.lblConsultarTrabajadorNombre.Text = "Nombre"
        '
        'BajaTrabajador
        '
        Me.BajaTrabajador.Controls.Add(Me.btnBajaTrabajadorCancelar)
        Me.BajaTrabajador.Controls.Add(Me.btnBajaTrabajadorAceptar)
        Me.BajaTrabajador.Controls.Add(Me.txtBajaTrabajadorRazon)
        Me.BajaTrabajador.Controls.Add(Me.lblBajaTrabajadorRazon)
        Me.BajaTrabajador.Controls.Add(Me.txtBajaTrabajadorDNI)
        Me.BajaTrabajador.Controls.Add(Me.lblBajaTrabajadorDNI)
        Me.BajaTrabajador.Controls.Add(Me.lblMenuBajaTrabajador)
        Me.BajaTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BajaTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.BajaTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BajaTrabajador.Name = "BajaTrabajador"
        Me.BajaTrabajador.Size = New System.Drawing.Size(773, 422)
        Me.BajaTrabajador.TabIndex = 19
        '
        'btnBajaTrabajadorCancelar
        '
        Me.btnBajaTrabajadorCancelar.Location = New System.Drawing.Point(148, 358)
        Me.btnBajaTrabajadorCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBajaTrabajadorCancelar.Name = "btnBajaTrabajadorCancelar"
        Me.btnBajaTrabajadorCancelar.Size = New System.Drawing.Size(127, 37)
        Me.btnBajaTrabajadorCancelar.TabIndex = 5
        Me.btnBajaTrabajadorCancelar.Text = "Cancelar"
        Me.btnBajaTrabajadorCancelar.UseVisualStyleBackColor = True
        '
        'btnBajaTrabajadorAceptar
        '
        Me.btnBajaTrabajadorAceptar.Location = New System.Drawing.Point(515, 364)
        Me.btnBajaTrabajadorAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBajaTrabajadorAceptar.Name = "btnBajaTrabajadorAceptar"
        Me.btnBajaTrabajadorAceptar.Size = New System.Drawing.Size(127, 37)
        Me.btnBajaTrabajadorAceptar.TabIndex = 6
        Me.btnBajaTrabajadorAceptar.Text = "Aceptar"
        Me.btnBajaTrabajadorAceptar.UseVisualStyleBackColor = True
        '
        'txtBajaTrabajadorRazon
        '
        Me.txtBajaTrabajadorRazon.Location = New System.Drawing.Point(215, 268)
        Me.txtBajaTrabajadorRazon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBajaTrabajadorRazon.Name = "txtBajaTrabajadorRazon"
        Me.txtBajaTrabajadorRazon.Size = New System.Drawing.Size(405, 22)
        Me.txtBajaTrabajadorRazon.TabIndex = 4
        '
        'lblBajaTrabajadorRazon
        '
        Me.lblBajaTrabajadorRazon.AutoSize = True
        Me.lblBajaTrabajadorRazon.Location = New System.Drawing.Point(127, 271)
        Me.lblBajaTrabajadorRazon.Name = "lblBajaTrabajadorRazon"
        Me.lblBajaTrabajadorRazon.Size = New System.Drawing.Size(49, 17)
        Me.lblBajaTrabajadorRazon.TabIndex = 3
        Me.lblBajaTrabajadorRazon.Text = "Razón"
        '
        'txtBajaTrabajadorDNI
        '
        Me.txtBajaTrabajadorDNI.Location = New System.Drawing.Point(215, 162)
        Me.txtBajaTrabajadorDNI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBajaTrabajadorDNI.Name = "txtBajaTrabajadorDNI"
        Me.txtBajaTrabajadorDNI.Size = New System.Drawing.Size(167, 22)
        Me.txtBajaTrabajadorDNI.TabIndex = 2
        '
        'lblBajaTrabajadorDNI
        '
        Me.lblBajaTrabajadorDNI.AutoSize = True
        Me.lblBajaTrabajadorDNI.Location = New System.Drawing.Point(127, 165)
        Me.lblBajaTrabajadorDNI.Name = "lblBajaTrabajadorDNI"
        Me.lblBajaTrabajadorDNI.Size = New System.Drawing.Size(31, 17)
        Me.lblBajaTrabajadorDNI.TabIndex = 1
        Me.lblBajaTrabajadorDNI.Text = "DNI"
        '
        'lblMenuBajaTrabajador
        '
        Me.lblMenuBajaTrabajador.AutoSize = True
        Me.lblMenuBajaTrabajador.Font = New System.Drawing.Font("Microsoft YaHei", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuBajaTrabajador.Location = New System.Drawing.Point(201, 47)
        Me.lblMenuBajaTrabajador.Name = "lblMenuBajaTrabajador"
        Me.lblMenuBajaTrabajador.Size = New System.Drawing.Size(367, 43)
        Me.lblMenuBajaTrabajador.TabIndex = 0
        Me.lblMenuBajaTrabajador.Text = "Menú Baja Trabajador"
        '
        'ModificarTrabajador
        '
        Me.ModificarTrabajador.Controls.Add(Me.Label2)
        Me.ModificarTrabajador.Controls.Add(Me.txtMenuModificarTrabajadorAnyosTrabajados)
        Me.ModificarTrabajador.Controls.Add(Me.txtMenuModificarTrabajadorEdad)
        Me.ModificarTrabajador.Controls.Add(Me.txtMenuModificarTrabajadorSexo)
        Me.ModificarTrabajador.Controls.Add(Me.lblMenuModificarTrabajadorSexo)
        Me.ModificarTrabajador.Controls.Add(Me.btnMenuModificarTrabajadorAceptar)
        Me.ModificarTrabajador.Controls.Add(Me.btnMenuModificarTrabajadorCancelar)
        Me.ModificarTrabajador.Controls.Add(Me.txtMenuModificarTrabajadorTel)
        Me.ModificarTrabajador.Controls.Add(Me.txtMenuModificarTrabajadorEmail)
        Me.ModificarTrabajador.Controls.Add(Me.lblMenuModificarTrabajadorTel)
        Me.ModificarTrabajador.Controls.Add(Me.lblMenuModificarTrabajadorEmail)
        Me.ModificarTrabajador.Controls.Add(Me.txtMenuModificarTrabajadorDNI)
        Me.ModificarTrabajador.Controls.Add(Me.lblMenuModificarTrabajadorDNI)
        Me.ModificarTrabajador.Controls.Add(Me.txtMenuModificarTrabajadorTipo)
        Me.ModificarTrabajador.Controls.Add(Me.txtMenuModificarTrabajadorApellido)
        Me.ModificarTrabajador.Controls.Add(Me.txtMenuModificarTrabajadorNombre)
        Me.ModificarTrabajador.Controls.Add(Me.lblMenuModificarTrabajadorEspecialidad)
        Me.ModificarTrabajador.Controls.Add(Me.lblMenuModificarTrabajadorNacimiento)
        Me.ModificarTrabajador.Controls.Add(Me.lblMenuModificarTrabajadorApellido)
        Me.ModificarTrabajador.Controls.Add(Me.lblMenuModificarTrabajadorNombre)
        Me.ModificarTrabajador.Controls.Add(Me.lblModificarTrabajador)
        Me.ModificarTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModificarTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.ModificarTrabajador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ModificarTrabajador.Name = "ModificarTrabajador"
        Me.ModificarTrabajador.Size = New System.Drawing.Size(773, 422)
        Me.ModificarTrabajador.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(452, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Años Trabajados"
        '
        'txtMenuModificarTrabajadorAnyosTrabajados
        '
        Me.txtMenuModificarTrabajadorAnyosTrabajados.Location = New System.Drawing.Point(585, 113)
        Me.txtMenuModificarTrabajadorAnyosTrabajados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMenuModificarTrabajadorAnyosTrabajados.Name = "txtMenuModificarTrabajadorAnyosTrabajados"
        Me.txtMenuModificarTrabajadorAnyosTrabajados.Size = New System.Drawing.Size(142, 22)
        Me.txtMenuModificarTrabajadorAnyosTrabajados.TabIndex = 39
        '
        'txtMenuModificarTrabajadorEdad
        '
        Me.txtMenuModificarTrabajadorEdad.Location = New System.Drawing.Point(239, 244)
        Me.txtMenuModificarTrabajadorEdad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMenuModificarTrabajadorEdad.Name = "txtMenuModificarTrabajadorEdad"
        Me.txtMenuModificarTrabajadorEdad.Size = New System.Drawing.Size(183, 22)
        Me.txtMenuModificarTrabajadorEdad.TabIndex = 38
        '
        'txtMenuModificarTrabajadorSexo
        '
        Me.txtMenuModificarTrabajadorSexo.Location = New System.Drawing.Point(548, 293)
        Me.txtMenuModificarTrabajadorSexo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMenuModificarTrabajadorSexo.Name = "txtMenuModificarTrabajadorSexo"
        Me.txtMenuModificarTrabajadorSexo.Size = New System.Drawing.Size(183, 22)
        Me.txtMenuModificarTrabajadorSexo.TabIndex = 37
        '
        'lblMenuModificarTrabajadorSexo
        '
        Me.lblMenuModificarTrabajadorSexo.AutoSize = True
        Me.lblMenuModificarTrabajadorSexo.Location = New System.Drawing.Point(456, 289)
        Me.lblMenuModificarTrabajadorSexo.Name = "lblMenuModificarTrabajadorSexo"
        Me.lblMenuModificarTrabajadorSexo.Size = New System.Drawing.Size(39, 17)
        Me.lblMenuModificarTrabajadorSexo.TabIndex = 36
        Me.lblMenuModificarTrabajadorSexo.Text = "Sexo"
        '
        'btnMenuModificarTrabajadorAceptar
        '
        Me.btnMenuModificarTrabajadorAceptar.Location = New System.Drawing.Point(512, 365)
        Me.btnMenuModificarTrabajadorAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuModificarTrabajadorAceptar.Name = "btnMenuModificarTrabajadorAceptar"
        Me.btnMenuModificarTrabajadorAceptar.Size = New System.Drawing.Size(140, 38)
        Me.btnMenuModificarTrabajadorAceptar.TabIndex = 35
        Me.btnMenuModificarTrabajadorAceptar.Text = "Aceptar"
        Me.btnMenuModificarTrabajadorAceptar.UseVisualStyleBackColor = True
        '
        'btnMenuModificarTrabajadorCancelar
        '
        Me.btnMenuModificarTrabajadorCancelar.Location = New System.Drawing.Point(149, 368)
        Me.btnMenuModificarTrabajadorCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuModificarTrabajadorCancelar.Name = "btnMenuModificarTrabajadorCancelar"
        Me.btnMenuModificarTrabajadorCancelar.Size = New System.Drawing.Size(140, 38)
        Me.btnMenuModificarTrabajadorCancelar.TabIndex = 34
        Me.btnMenuModificarTrabajadorCancelar.Text = "Cancelar"
        Me.btnMenuModificarTrabajadorCancelar.UseVisualStyleBackColor = True
        '
        'txtMenuModificarTrabajadorTel
        '
        Me.txtMenuModificarTrabajadorTel.Location = New System.Drawing.Point(546, 231)
        Me.txtMenuModificarTrabajadorTel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMenuModificarTrabajadorTel.Name = "txtMenuModificarTrabajadorTel"
        Me.txtMenuModificarTrabajadorTel.Size = New System.Drawing.Size(183, 22)
        Me.txtMenuModificarTrabajadorTel.TabIndex = 33
        '
        'txtMenuModificarTrabajadorEmail
        '
        Me.txtMenuModificarTrabajadorEmail.Location = New System.Drawing.Point(546, 178)
        Me.txtMenuModificarTrabajadorEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMenuModificarTrabajadorEmail.Name = "txtMenuModificarTrabajadorEmail"
        Me.txtMenuModificarTrabajadorEmail.Size = New System.Drawing.Size(183, 22)
        Me.txtMenuModificarTrabajadorEmail.TabIndex = 32
        '
        'lblMenuModificarTrabajadorTel
        '
        Me.lblMenuModificarTrabajadorTel.AutoSize = True
        Me.lblMenuModificarTrabajadorTel.Location = New System.Drawing.Point(454, 231)
        Me.lblMenuModificarTrabajadorTel.Name = "lblMenuModificarTrabajadorTel"
        Me.lblMenuModificarTrabajadorTel.Size = New System.Drawing.Size(83, 17)
        Me.lblMenuModificarTrabajadorTel.TabIndex = 31
        Me.lblMenuModificarTrabajadorTel.Text = "Nº Telefono"
        '
        'lblMenuModificarTrabajadorEmail
        '
        Me.lblMenuModificarTrabajadorEmail.AutoSize = True
        Me.lblMenuModificarTrabajadorEmail.Location = New System.Drawing.Point(454, 175)
        Me.lblMenuModificarTrabajadorEmail.Name = "lblMenuModificarTrabajadorEmail"
        Me.lblMenuModificarTrabajadorEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblMenuModificarTrabajadorEmail.TabIndex = 30
        Me.lblMenuModificarTrabajadorEmail.Text = "Email"
        '
        'txtMenuModificarTrabajadorDNI
        '
        Me.txtMenuModificarTrabajadorDNI.Location = New System.Drawing.Point(239, 199)
        Me.txtMenuModificarTrabajadorDNI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMenuModificarTrabajadorDNI.Name = "txtMenuModificarTrabajadorDNI"
        Me.txtMenuModificarTrabajadorDNI.Size = New System.Drawing.Size(183, 22)
        Me.txtMenuModificarTrabajadorDNI.TabIndex = 29
        '
        'lblMenuModificarTrabajadorDNI
        '
        Me.lblMenuModificarTrabajadorDNI.AutoSize = True
        Me.lblMenuModificarTrabajadorDNI.Location = New System.Drawing.Point(45, 203)
        Me.lblMenuModificarTrabajadorDNI.Name = "lblMenuModificarTrabajadorDNI"
        Me.lblMenuModificarTrabajadorDNI.Size = New System.Drawing.Size(31, 17)
        Me.lblMenuModificarTrabajadorDNI.TabIndex = 28
        Me.lblMenuModificarTrabajadorDNI.Text = "DNI"
        '
        'txtMenuModificarTrabajadorTipo
        '
        Me.txtMenuModificarTrabajadorTipo.Location = New System.Drawing.Point(239, 306)
        Me.txtMenuModificarTrabajadorTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMenuModificarTrabajadorTipo.Name = "txtMenuModificarTrabajadorTipo"
        Me.txtMenuModificarTrabajadorTipo.Size = New System.Drawing.Size(183, 22)
        Me.txtMenuModificarTrabajadorTipo.TabIndex = 27
        '
        'txtMenuModificarTrabajadorApellido
        '
        Me.txtMenuModificarTrabajadorApellido.Location = New System.Drawing.Point(241, 149)
        Me.txtMenuModificarTrabajadorApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMenuModificarTrabajadorApellido.Name = "txtMenuModificarTrabajadorApellido"
        Me.txtMenuModificarTrabajadorApellido.Size = New System.Drawing.Size(183, 22)
        Me.txtMenuModificarTrabajadorApellido.TabIndex = 26
        '
        'txtMenuModificarTrabajadorNombre
        '
        Me.txtMenuModificarTrabajadorNombre.Location = New System.Drawing.Point(241, 94)
        Me.txtMenuModificarTrabajadorNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMenuModificarTrabajadorNombre.Name = "txtMenuModificarTrabajadorNombre"
        Me.txtMenuModificarTrabajadorNombre.Size = New System.Drawing.Size(183, 22)
        Me.txtMenuModificarTrabajadorNombre.TabIndex = 25
        '
        'lblMenuModificarTrabajadorEspecialidad
        '
        Me.lblMenuModificarTrabajadorEspecialidad.AutoSize = True
        Me.lblMenuModificarTrabajadorEspecialidad.Location = New System.Drawing.Point(45, 308)
        Me.lblMenuModificarTrabajadorEspecialidad.Name = "lblMenuModificarTrabajadorEspecialidad"
        Me.lblMenuModificarTrabajadorEspecialidad.Size = New System.Drawing.Size(138, 21)
        Me.lblMenuModificarTrabajadorEspecialidad.TabIndex = 24
        Me.lblMenuModificarTrabajadorEspecialidad.Text = "Tipo Trabajador"
        '
        'lblMenuModificarTrabajadorNacimiento
        '
        Me.lblMenuModificarTrabajadorNacimiento.AutoSize = True
        Me.lblMenuModificarTrabajadorNacimiento.Location = New System.Drawing.Point(45, 249)
        Me.lblMenuModificarTrabajadorNacimiento.Name = "lblMenuModificarTrabajadorNacimiento"
        Me.lblMenuModificarTrabajadorNacimiento.Size = New System.Drawing.Size(41, 17)
        Me.lblMenuModificarTrabajadorNacimiento.TabIndex = 22
        Me.lblMenuModificarTrabajadorNacimiento.Text = "Edad"
        '
        'lblMenuModificarTrabajadorApellido
        '
        Me.lblMenuModificarTrabajadorApellido.AutoSize = True
        Me.lblMenuModificarTrabajadorApellido.Location = New System.Drawing.Point(45, 149)
        Me.lblMenuModificarTrabajadorApellido.Name = "lblMenuModificarTrabajadorApellido"
        Me.lblMenuModificarTrabajadorApellido.Size = New System.Drawing.Size(58, 17)
        Me.lblMenuModificarTrabajadorApellido.TabIndex = 21
        Me.lblMenuModificarTrabajadorApellido.Text = "Apellido"
        '
        'lblMenuModificarTrabajadorNombre
        '
        Me.lblMenuModificarTrabajadorNombre.AutoSize = True
        Me.lblMenuModificarTrabajadorNombre.Location = New System.Drawing.Point(45, 94)
        Me.lblMenuModificarTrabajadorNombre.Name = "lblMenuModificarTrabajadorNombre"
        Me.lblMenuModificarTrabajadorNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblMenuModificarTrabajadorNombre.TabIndex = 20
        Me.lblMenuModificarTrabajadorNombre.Text = "Nombre"
        '
        'lblModificarTrabajador
        '
        Me.lblModificarTrabajador.AutoSize = True
        Me.lblModificarTrabajador.Font = New System.Drawing.Font("Microsoft YaHei", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarTrabajador.Location = New System.Drawing.Point(237, 26)
        Me.lblModificarTrabajador.Name = "lblModificarTrabajador"
        Me.lblModificarTrabajador.Size = New System.Drawing.Size(351, 43)
        Me.lblModificarTrabajador.TabIndex = 19
        Me.lblModificarTrabajador.Text = "Modificar Trabajador"
        '
        'MenuProveedores
        '
        Me.MenuProveedores.Controls.Add(Me.btnConsultarProveedorSailr)
        Me.MenuProveedores.Controls.Add(Me.btnConsultarProveedorAtras)
        Me.MenuProveedores.Controls.Add(Me.btnBajaProveedor)
        Me.MenuProveedores.Controls.Add(Me.btnConsultarProveedor)
        Me.MenuProveedores.Controls.Add(Me.btnModificarProveedor)
        Me.MenuProveedores.Controls.Add(Me.btnAñadirProveedor)
        Me.MenuProveedores.Controls.Add(Me.lblMenuProveedores)
        Me.MenuProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuProveedores.Location = New System.Drawing.Point(0, 0)
        Me.MenuProveedores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MenuProveedores.Name = "MenuProveedores"
        Me.MenuProveedores.Size = New System.Drawing.Size(773, 422)
        Me.MenuProveedores.TabIndex = 7
        '
        'btnConsultarProveedorSailr
        '
        Me.btnConsultarProveedorSailr.Location = New System.Drawing.Point(536, 351)
        Me.btnConsultarProveedorSailr.Name = "btnConsultarProveedorSailr"
        Me.btnConsultarProveedorSailr.Size = New System.Drawing.Size(116, 41)
        Me.btnConsultarProveedorSailr.TabIndex = 6
        Me.btnConsultarProveedorSailr.Text = "Salir"
        Me.btnConsultarProveedorSailr.UseVisualStyleBackColor = True
        '
        'btnConsultarProveedorAtras
        '
        Me.btnConsultarProveedorAtras.Location = New System.Drawing.Point(112, 353)
        Me.btnConsultarProveedorAtras.Name = "btnConsultarProveedorAtras"
        Me.btnConsultarProveedorAtras.Size = New System.Drawing.Size(116, 41)
        Me.btnConsultarProveedorAtras.TabIndex = 5
        Me.btnConsultarProveedorAtras.Text = "Atras"
        Me.btnConsultarProveedorAtras.UseVisualStyleBackColor = True
        '
        'btnBajaProveedor
        '
        Me.btnBajaProveedor.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaProveedor.Location = New System.Drawing.Point(429, 247)
        Me.btnBajaProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBajaProveedor.Name = "btnBajaProveedor"
        Me.btnBajaProveedor.Size = New System.Drawing.Size(139, 62)
        Me.btnBajaProveedor.TabIndex = 4
        Me.btnBajaProveedor.Text = "Baja Proveedor"
        Me.btnBajaProveedor.UseVisualStyleBackColor = True
        '
        'btnConsultarProveedor
        '
        Me.btnConsultarProveedor.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarProveedor.Location = New System.Drawing.Point(209, 249)
        Me.btnConsultarProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConsultarProveedor.Name = "btnConsultarProveedor"
        Me.btnConsultarProveedor.Size = New System.Drawing.Size(139, 60)
        Me.btnConsultarProveedor.TabIndex = 3
        Me.btnConsultarProveedor.Text = "Consultar Proveedor"
        Me.btnConsultarProveedor.UseVisualStyleBackColor = True
        '
        'btnModificarProveedor
        '
        Me.btnModificarProveedor.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProveedor.Location = New System.Drawing.Point(429, 137)
        Me.btnModificarProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModificarProveedor.Name = "btnModificarProveedor"
        Me.btnModificarProveedor.Size = New System.Drawing.Size(139, 62)
        Me.btnModificarProveedor.TabIndex = 2
        Me.btnModificarProveedor.Text = "Modificar Proveedor"
        Me.btnModificarProveedor.UseVisualStyleBackColor = True
        '
        'btnAñadirProveedor
        '
        Me.btnAñadirProveedor.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadirProveedor.Location = New System.Drawing.Point(209, 135)
        Me.btnAñadirProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAñadirProveedor.Name = "btnAñadirProveedor"
        Me.btnAñadirProveedor.Size = New System.Drawing.Size(139, 62)
        Me.btnAñadirProveedor.TabIndex = 1
        Me.btnAñadirProveedor.Text = "Añadir Proveedor"
        Me.btnAñadirProveedor.UseVisualStyleBackColor = True
        '
        'lblMenuProveedores
        '
        Me.lblMenuProveedores.AutoSize = True
        Me.lblMenuProveedores.Font = New System.Drawing.Font("Microsoft YaHei", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuProveedores.Location = New System.Drawing.Point(119, 33)
        Me.lblMenuProveedores.Name = "lblMenuProveedores"
        Me.lblMenuProveedores.Size = New System.Drawing.Size(583, 57)
        Me.lblMenuProveedores.TabIndex = 0
        Me.lblMenuProveedores.Text = "Menú Gestión Proveedores"
        '
        'AltaProveedor
        '
        Me.AltaProveedor.Controls.Add(Me.btnAltaProveedorAceptar)
        Me.AltaProveedor.Controls.Add(Me.btnAltaProveedorCancelar)
        Me.AltaProveedor.Controls.Add(Me.txtAltaProveedorEmail)
        Me.AltaProveedor.Controls.Add(Me.txtAltaProveedorTelefono)
        Me.AltaProveedor.Controls.Add(Me.txtAltaProveedorDireccion)
        Me.AltaProveedor.Controls.Add(Me.lblAltaProveedorEmail)
        Me.AltaProveedor.Controls.Add(Me.lblAltaProveedorTelefono)
        Me.AltaProveedor.Controls.Add(Me.lblAltaProveedorDireccion)
        Me.AltaProveedor.Controls.Add(Me.txtAltaProveedorTipo)
        Me.AltaProveedor.Controls.Add(Me.txtAltaProveedorCIF)
        Me.AltaProveedor.Controls.Add(Me.txtAltaProveedorApellido)
        Me.AltaProveedor.Controls.Add(Me.txtAltaProveedorNombre)
        Me.AltaProveedor.Controls.Add(Me.txtAltaProveedorNombreEmpresa)
        Me.AltaProveedor.Controls.Add(Me.lblAltaProveedorApellido)
        Me.AltaProveedor.Controls.Add(Me.lblAltaProveedorTipo)
        Me.AltaProveedor.Controls.Add(Me.lblAltaProveedorCIF)
        Me.AltaProveedor.Controls.Add(Me.lblAltaProveedorNombre)
        Me.AltaProveedor.Controls.Add(Me.lblAltaProveedorNombreEmpresa)
        Me.AltaProveedor.Controls.Add(Me.lblMenuAltaProveedor)
        Me.AltaProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AltaProveedor.Location = New System.Drawing.Point(0, 0)
        Me.AltaProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AltaProveedor.Name = "AltaProveedor"
        Me.AltaProveedor.Size = New System.Drawing.Size(773, 422)
        Me.AltaProveedor.TabIndex = 7
        '
        'btnAltaProveedorAceptar
        '
        Me.btnAltaProveedorAceptar.Location = New System.Drawing.Point(499, 350)
        Me.btnAltaProveedorAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAltaProveedorAceptar.Name = "btnAltaProveedorAceptar"
        Me.btnAltaProveedorAceptar.Size = New System.Drawing.Size(131, 39)
        Me.btnAltaProveedorAceptar.TabIndex = 18
        Me.btnAltaProveedorAceptar.Text = "Aceptar"
        Me.btnAltaProveedorAceptar.UseVisualStyleBackColor = True
        '
        'btnAltaProveedorCancelar
        '
        Me.btnAltaProveedorCancelar.Location = New System.Drawing.Point(185, 350)
        Me.btnAltaProveedorCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAltaProveedorCancelar.Name = "btnAltaProveedorCancelar"
        Me.btnAltaProveedorCancelar.Size = New System.Drawing.Size(131, 39)
        Me.btnAltaProveedorCancelar.TabIndex = 17
        Me.btnAltaProveedorCancelar.Text = "Cancelar"
        Me.btnAltaProveedorCancelar.UseVisualStyleBackColor = True
        '
        'txtAltaProveedorEmail
        '
        Me.txtAltaProveedorEmail.Location = New System.Drawing.Point(547, 246)
        Me.txtAltaProveedorEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaProveedorEmail.Name = "txtAltaProveedorEmail"
        Me.txtAltaProveedorEmail.Size = New System.Drawing.Size(167, 22)
        Me.txtAltaProveedorEmail.TabIndex = 16
        '
        'txtAltaProveedorTelefono
        '
        Me.txtAltaProveedorTelefono.Location = New System.Drawing.Point(547, 208)
        Me.txtAltaProveedorTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaProveedorTelefono.Name = "txtAltaProveedorTelefono"
        Me.txtAltaProveedorTelefono.Size = New System.Drawing.Size(167, 22)
        Me.txtAltaProveedorTelefono.TabIndex = 15
        '
        'txtAltaProveedorDireccion
        '
        Me.txtAltaProveedorDireccion.Location = New System.Drawing.Point(547, 162)
        Me.txtAltaProveedorDireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaProveedorDireccion.Name = "txtAltaProveedorDireccion"
        Me.txtAltaProveedorDireccion.Size = New System.Drawing.Size(167, 22)
        Me.txtAltaProveedorDireccion.TabIndex = 14
        '
        'lblAltaProveedorEmail
        '
        Me.lblAltaProveedorEmail.AutoSize = True
        Me.lblAltaProveedorEmail.Location = New System.Drawing.Point(468, 247)
        Me.lblAltaProveedorEmail.Name = "lblAltaProveedorEmail"
        Me.lblAltaProveedorEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblAltaProveedorEmail.TabIndex = 13
        Me.lblAltaProveedorEmail.Text = "Email"
        '
        'lblAltaProveedorTelefono
        '
        Me.lblAltaProveedorTelefono.AutoSize = True
        Me.lblAltaProveedorTelefono.Location = New System.Drawing.Point(468, 209)
        Me.lblAltaProveedorTelefono.Name = "lblAltaProveedorTelefono"
        Me.lblAltaProveedorTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblAltaProveedorTelefono.TabIndex = 12
        Me.lblAltaProveedorTelefono.Text = "Teléfono"
        '
        'lblAltaProveedorDireccion
        '
        Me.lblAltaProveedorDireccion.AutoSize = True
        Me.lblAltaProveedorDireccion.Location = New System.Drawing.Point(468, 165)
        Me.lblAltaProveedorDireccion.Name = "lblAltaProveedorDireccion"
        Me.lblAltaProveedorDireccion.Size = New System.Drawing.Size(67, 17)
        Me.lblAltaProveedorDireccion.TabIndex = 11
        Me.lblAltaProveedorDireccion.Text = "Dirección"
        '
        'txtAltaProveedorTipo
        '
        Me.txtAltaProveedorTipo.Location = New System.Drawing.Point(252, 286)
        Me.txtAltaProveedorTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaProveedorTipo.Name = "txtAltaProveedorTipo"
        Me.txtAltaProveedorTipo.Size = New System.Drawing.Size(167, 22)
        Me.txtAltaProveedorTipo.TabIndex = 10
        '
        'txtAltaProveedorCIF
        '
        Me.txtAltaProveedorCIF.Location = New System.Drawing.Point(252, 251)
        Me.txtAltaProveedorCIF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaProveedorCIF.Name = "txtAltaProveedorCIF"
        Me.txtAltaProveedorCIF.Size = New System.Drawing.Size(167, 22)
        Me.txtAltaProveedorCIF.TabIndex = 9
        '
        'txtAltaProveedorApellido
        '
        Me.txtAltaProveedorApellido.Location = New System.Drawing.Point(252, 217)
        Me.txtAltaProveedorApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaProveedorApellido.Name = "txtAltaProveedorApellido"
        Me.txtAltaProveedorApellido.Size = New System.Drawing.Size(167, 22)
        Me.txtAltaProveedorApellido.TabIndex = 8
        '
        'txtAltaProveedorNombre
        '
        Me.txtAltaProveedorNombre.Location = New System.Drawing.Point(252, 178)
        Me.txtAltaProveedorNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaProveedorNombre.Name = "txtAltaProveedorNombre"
        Me.txtAltaProveedorNombre.Size = New System.Drawing.Size(167, 22)
        Me.txtAltaProveedorNombre.TabIndex = 7
        '
        'txtAltaProveedorNombreEmpresa
        '
        Me.txtAltaProveedorNombreEmpresa.Location = New System.Drawing.Point(252, 135)
        Me.txtAltaProveedorNombreEmpresa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAltaProveedorNombreEmpresa.Name = "txtAltaProveedorNombreEmpresa"
        Me.txtAltaProveedorNombreEmpresa.Size = New System.Drawing.Size(167, 22)
        Me.txtAltaProveedorNombreEmpresa.TabIndex = 6
        '
        'lblAltaProveedorApellido
        '
        Me.lblAltaProveedorApellido.AutoSize = True
        Me.lblAltaProveedorApellido.Location = New System.Drawing.Point(91, 220)
        Me.lblAltaProveedorApellido.Name = "lblAltaProveedorApellido"
        Me.lblAltaProveedorApellido.Size = New System.Drawing.Size(58, 17)
        Me.lblAltaProveedorApellido.TabIndex = 5
        Me.lblAltaProveedorApellido.Text = "Apellido"
        '
        'lblAltaProveedorTipo
        '
        Me.lblAltaProveedorTipo.AutoSize = True
        Me.lblAltaProveedorTipo.Location = New System.Drawing.Point(91, 288)
        Me.lblAltaProveedorTipo.Name = "lblAltaProveedorTipo"
        Me.lblAltaProveedorTipo.Size = New System.Drawing.Size(126, 17)
        Me.lblAltaProveedorTipo.TabIndex = 4
        Me.lblAltaProveedorTipo.Text = "Tipo de Proveedor"
        '
        'lblAltaProveedorCIF
        '
        Me.lblAltaProveedorCIF.AutoSize = True
        Me.lblAltaProveedorCIF.Location = New System.Drawing.Point(91, 252)
        Me.lblAltaProveedorCIF.Name = "lblAltaProveedorCIF"
        Me.lblAltaProveedorCIF.Size = New System.Drawing.Size(28, 17)
        Me.lblAltaProveedorCIF.TabIndex = 3
        Me.lblAltaProveedorCIF.Text = "CIF"
        '
        'lblAltaProveedorNombre
        '
        Me.lblAltaProveedorNombre.AutoSize = True
        Me.lblAltaProveedorNombre.Location = New System.Drawing.Point(91, 182)
        Me.lblAltaProveedorNombre.Name = "lblAltaProveedorNombre"
        Me.lblAltaProveedorNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblAltaProveedorNombre.TabIndex = 2
        Me.lblAltaProveedorNombre.Text = "Nombre "
        '
        'lblAltaProveedorNombreEmpresa
        '
        Me.lblAltaProveedorNombreEmpresa.AutoSize = True
        Me.lblAltaProveedorNombreEmpresa.Location = New System.Drawing.Point(91, 138)
        Me.lblAltaProveedorNombreEmpresa.Name = "lblAltaProveedorNombreEmpresa"
        Me.lblAltaProveedorNombreEmpresa.Size = New System.Drawing.Size(153, 17)
        Me.lblAltaProveedorNombreEmpresa.TabIndex = 1
        Me.lblAltaProveedorNombreEmpresa.Text = "Nombre de la Empresa"
        '
        'lblMenuAltaProveedor
        '
        Me.lblMenuAltaProveedor.AutoSize = True
        Me.lblMenuAltaProveedor.Font = New System.Drawing.Font("Microsoft YaHei", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuAltaProveedor.Location = New System.Drawing.Point(175, 39)
        Me.lblMenuAltaProveedor.Name = "lblMenuAltaProveedor"
        Me.lblMenuAltaProveedor.Size = New System.Drawing.Size(463, 57)
        Me.lblMenuAltaProveedor.TabIndex = 0
        Me.lblMenuAltaProveedor.Text = "Menú Alta Proveedor"
        '
        'BusquedaModificarProveedor
        '
        Me.BusquedaModificarProveedor.Controls.Add(Me.btnBusquedaModificacionProveedorBuscar)
        Me.BusquedaModificarProveedor.Controls.Add(Me.btnBusquedaModificacionProveedorCancelar)
        Me.BusquedaModificarProveedor.Controls.Add(Me.txtBusquedaModificarProveedorCIF)
        Me.BusquedaModificarProveedor.Controls.Add(Me.lblBusquedaModificarProveedorCIF)
        Me.BusquedaModificarProveedor.Controls.Add(Me.lblBusquedaModificarProveedorTexto)
        Me.BusquedaModificarProveedor.Controls.Add(Me.lblBusquedaModificarProveedor)
        Me.BusquedaModificarProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BusquedaModificarProveedor.Location = New System.Drawing.Point(0, 0)
        Me.BusquedaModificarProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BusquedaModificarProveedor.Name = "BusquedaModificarProveedor"
        Me.BusquedaModificarProveedor.Size = New System.Drawing.Size(773, 422)
        Me.BusquedaModificarProveedor.TabIndex = 7
        '
        'btnBusquedaModificacionProveedorBuscar
        '
        Me.btnBusquedaModificacionProveedorBuscar.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusquedaModificacionProveedorBuscar.Location = New System.Drawing.Point(515, 315)
        Me.btnBusquedaModificacionProveedorBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBusquedaModificacionProveedorBuscar.Name = "btnBusquedaModificacionProveedorBuscar"
        Me.btnBusquedaModificacionProveedorBuscar.Size = New System.Drawing.Size(115, 46)
        Me.btnBusquedaModificacionProveedorBuscar.TabIndex = 5
        Me.btnBusquedaModificacionProveedorBuscar.Text = "Buscar"
        Me.btnBusquedaModificacionProveedorBuscar.UseVisualStyleBackColor = True
        '
        'btnBusquedaModificacionProveedorCancelar
        '
        Me.btnBusquedaModificacionProveedorCancelar.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusquedaModificacionProveedorCancelar.Location = New System.Drawing.Point(160, 315)
        Me.btnBusquedaModificacionProveedorCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBusquedaModificacionProveedorCancelar.Name = "btnBusquedaModificacionProveedorCancelar"
        Me.btnBusquedaModificacionProveedorCancelar.Size = New System.Drawing.Size(115, 46)
        Me.btnBusquedaModificacionProveedorCancelar.TabIndex = 4
        Me.btnBusquedaModificacionProveedorCancelar.Text = "Cancelar"
        Me.btnBusquedaModificacionProveedorCancelar.UseVisualStyleBackColor = True
        '
        'txtBusquedaModificarProveedorCIF
        '
        Me.txtBusquedaModificarProveedorCIF.Location = New System.Drawing.Point(331, 209)
        Me.txtBusquedaModificarProveedorCIF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBusquedaModificarProveedorCIF.Name = "txtBusquedaModificarProveedorCIF"
        Me.txtBusquedaModificarProveedorCIF.Size = New System.Drawing.Size(169, 22)
        Me.txtBusquedaModificarProveedorCIF.TabIndex = 3
        '
        'lblBusquedaModificarProveedorCIF
        '
        Me.lblBusquedaModificarProveedorCIF.AutoSize = True
        Me.lblBusquedaModificarProveedorCIF.Location = New System.Drawing.Point(271, 212)
        Me.lblBusquedaModificarProveedorCIF.Name = "lblBusquedaModificarProveedorCIF"
        Me.lblBusquedaModificarProveedorCIF.Size = New System.Drawing.Size(28, 17)
        Me.lblBusquedaModificarProveedorCIF.TabIndex = 2
        Me.lblBusquedaModificarProveedorCIF.Text = "CIF"
        '
        'lblBusquedaModificarProveedorTexto
        '
        Me.lblBusquedaModificarProveedorTexto.AutoSize = True
        Me.lblBusquedaModificarProveedorTexto.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusquedaModificarProveedorTexto.Location = New System.Drawing.Point(161, 113)
        Me.lblBusquedaModificarProveedorTexto.Name = "lblBusquedaModificarProveedorTexto"
        Me.lblBusquedaModificarProveedorTexto.Size = New System.Drawing.Size(472, 23)
        Me.lblBusquedaModificarProveedorTexto.TabIndex = 1
        Me.lblBusquedaModificarProveedorTexto.Text = "Introduzca el CIF de la empresa para realizar la búsqueda"
        '
        'lblBusquedaModificarProveedor
        '
        Me.lblBusquedaModificarProveedor.AutoSize = True
        Me.lblBusquedaModificarProveedor.Font = New System.Drawing.Font("Microsoft YaHei", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusquedaModificarProveedor.Location = New System.Drawing.Point(75, 39)
        Me.lblBusquedaModificarProveedor.Name = "lblBusquedaModificarProveedor"
        Me.lblBusquedaModificarProveedor.Size = New System.Drawing.Size(663, 57)
        Me.lblBusquedaModificarProveedor.TabIndex = 0
        Me.lblBusquedaModificarProveedor.Text = "Búsqueda Modificar Proveedor"
        '
        'ModificarProveedor
        '
        Me.ModificarProveedor.Controls.Add(Me.btnModificarProveedorAceptar)
        Me.ModificarProveedor.Controls.Add(Me.btnModificarProveedorCancelar)
        Me.ModificarProveedor.Controls.Add(Me.txtModificarProveedorEmail)
        Me.ModificarProveedor.Controls.Add(Me.txtModificarProveedorTelefono)
        Me.ModificarProveedor.Controls.Add(Me.txtModificarProveedorDireccion)
        Me.ModificarProveedor.Controls.Add(Me.lblModificarProveedorEmail)
        Me.ModificarProveedor.Controls.Add(Me.lblModificarProveedorTelefono)
        Me.ModificarProveedor.Controls.Add(Me.lblModificarProveedorDireccion)
        Me.ModificarProveedor.Controls.Add(Me.txtModificarProveedorTipo)
        Me.ModificarProveedor.Controls.Add(Me.txtModificarProveedorCIF)
        Me.ModificarProveedor.Controls.Add(Me.txtModificarProveedorApellido)
        Me.ModificarProveedor.Controls.Add(Me.txtModificarProveedorNombre)
        Me.ModificarProveedor.Controls.Add(Me.txtModificarProveedorNombreEmpresa)
        Me.ModificarProveedor.Controls.Add(Me.lblModificarProveedorApellido)
        Me.ModificarProveedor.Controls.Add(Me.lblModificarProveedorTipo)
        Me.ModificarProveedor.Controls.Add(Me.lblModificarProveedorCIF)
        Me.ModificarProveedor.Controls.Add(Me.lblModificarProveedorNombre)
        Me.ModificarProveedor.Controls.Add(Me.lblModificarProveedorNombreEmpresa)
        Me.ModificarProveedor.Controls.Add(Me.lblModificarProveedor)
        Me.ModificarProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModificarProveedor.Location = New System.Drawing.Point(0, 0)
        Me.ModificarProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ModificarProveedor.Name = "ModificarProveedor"
        Me.ModificarProveedor.Size = New System.Drawing.Size(773, 422)
        Me.ModificarProveedor.TabIndex = 7
        '
        'btnModificarProveedorAceptar
        '
        Me.btnModificarProveedorAceptar.Location = New System.Drawing.Point(497, 350)
        Me.btnModificarProveedorAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModificarProveedorAceptar.Name = "btnModificarProveedorAceptar"
        Me.btnModificarProveedorAceptar.Size = New System.Drawing.Size(131, 39)
        Me.btnModificarProveedorAceptar.TabIndex = 37
        Me.btnModificarProveedorAceptar.Text = "Aceptar"
        Me.btnModificarProveedorAceptar.UseVisualStyleBackColor = True
        '
        'btnModificarProveedorCancelar
        '
        Me.btnModificarProveedorCancelar.Location = New System.Drawing.Point(184, 350)
        Me.btnModificarProveedorCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModificarProveedorCancelar.Name = "btnModificarProveedorCancelar"
        Me.btnModificarProveedorCancelar.Size = New System.Drawing.Size(131, 39)
        Me.btnModificarProveedorCancelar.TabIndex = 36
        Me.btnModificarProveedorCancelar.Text = "Cancelar"
        Me.btnModificarProveedorCancelar.UseVisualStyleBackColor = True
        '
        'txtModificarProveedorEmail
        '
        Me.txtModificarProveedorEmail.Location = New System.Drawing.Point(547, 245)
        Me.txtModificarProveedorEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModificarProveedorEmail.Name = "txtModificarProveedorEmail"
        Me.txtModificarProveedorEmail.Size = New System.Drawing.Size(167, 22)
        Me.txtModificarProveedorEmail.TabIndex = 35
        '
        'txtModificarProveedorTelefono
        '
        Me.txtModificarProveedorTelefono.Location = New System.Drawing.Point(547, 207)
        Me.txtModificarProveedorTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModificarProveedorTelefono.Name = "txtModificarProveedorTelefono"
        Me.txtModificarProveedorTelefono.Size = New System.Drawing.Size(167, 22)
        Me.txtModificarProveedorTelefono.TabIndex = 34
        '
        'txtModificarProveedorDireccion
        '
        Me.txtModificarProveedorDireccion.Location = New System.Drawing.Point(547, 162)
        Me.txtModificarProveedorDireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModificarProveedorDireccion.Name = "txtModificarProveedorDireccion"
        Me.txtModificarProveedorDireccion.Size = New System.Drawing.Size(167, 22)
        Me.txtModificarProveedorDireccion.TabIndex = 33
        '
        'lblModificarProveedorEmail
        '
        Me.lblModificarProveedorEmail.AutoSize = True
        Me.lblModificarProveedorEmail.Location = New System.Drawing.Point(469, 247)
        Me.lblModificarProveedorEmail.Name = "lblModificarProveedorEmail"
        Me.lblModificarProveedorEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblModificarProveedorEmail.TabIndex = 32
        Me.lblModificarProveedorEmail.Text = "Email"
        '
        'lblModificarProveedorTelefono
        '
        Me.lblModificarProveedorTelefono.AutoSize = True
        Me.lblModificarProveedorTelefono.Location = New System.Drawing.Point(467, 208)
        Me.lblModificarProveedorTelefono.Name = "lblModificarProveedorTelefono"
        Me.lblModificarProveedorTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblModificarProveedorTelefono.TabIndex = 31
        Me.lblModificarProveedorTelefono.Text = "Teléfono"
        '
        'lblModificarProveedorDireccion
        '
        Me.lblModificarProveedorDireccion.AutoSize = True
        Me.lblModificarProveedorDireccion.Location = New System.Drawing.Point(467, 164)
        Me.lblModificarProveedorDireccion.Name = "lblModificarProveedorDireccion"
        Me.lblModificarProveedorDireccion.Size = New System.Drawing.Size(67, 17)
        Me.lblModificarProveedorDireccion.TabIndex = 30
        Me.lblModificarProveedorDireccion.Text = "Dirección"
        '
        'txtModificarProveedorTipo
        '
        Me.txtModificarProveedorTipo.Location = New System.Drawing.Point(251, 284)
        Me.txtModificarProveedorTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModificarProveedorTipo.Name = "txtModificarProveedorTipo"
        Me.txtModificarProveedorTipo.Size = New System.Drawing.Size(167, 22)
        Me.txtModificarProveedorTipo.TabIndex = 29
        '
        'txtModificarProveedorCIF
        '
        Me.txtModificarProveedorCIF.Location = New System.Drawing.Point(251, 250)
        Me.txtModificarProveedorCIF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModificarProveedorCIF.Name = "txtModificarProveedorCIF"
        Me.txtModificarProveedorCIF.Size = New System.Drawing.Size(167, 22)
        Me.txtModificarProveedorCIF.TabIndex = 28
        '
        'txtModificarProveedorApellido
        '
        Me.txtModificarProveedorApellido.Location = New System.Drawing.Point(251, 217)
        Me.txtModificarProveedorApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModificarProveedorApellido.Name = "txtModificarProveedorApellido"
        Me.txtModificarProveedorApellido.Size = New System.Drawing.Size(167, 22)
        Me.txtModificarProveedorApellido.TabIndex = 27
        '
        'txtModificarProveedorNombre
        '
        Me.txtModificarProveedorNombre.Location = New System.Drawing.Point(251, 178)
        Me.txtModificarProveedorNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModificarProveedorNombre.Name = "txtModificarProveedorNombre"
        Me.txtModificarProveedorNombre.Size = New System.Drawing.Size(167, 22)
        Me.txtModificarProveedorNombre.TabIndex = 26
        '
        'txtModificarProveedorNombreEmpresa
        '
        Me.txtModificarProveedorNombreEmpresa.Location = New System.Drawing.Point(251, 134)
        Me.txtModificarProveedorNombreEmpresa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModificarProveedorNombreEmpresa.Name = "txtModificarProveedorNombreEmpresa"
        Me.txtModificarProveedorNombreEmpresa.Size = New System.Drawing.Size(167, 22)
        Me.txtModificarProveedorNombreEmpresa.TabIndex = 25
        '
        'lblModificarProveedorApellido
        '
        Me.lblModificarProveedorApellido.AutoSize = True
        Me.lblModificarProveedorApellido.Location = New System.Drawing.Point(91, 219)
        Me.lblModificarProveedorApellido.Name = "lblModificarProveedorApellido"
        Me.lblModificarProveedorApellido.Size = New System.Drawing.Size(58, 17)
        Me.lblModificarProveedorApellido.TabIndex = 24
        Me.lblModificarProveedorApellido.Text = "Apellido"
        '
        'lblModificarProveedorTipo
        '
        Me.lblModificarProveedorTipo.AutoSize = True
        Me.lblModificarProveedorTipo.Location = New System.Drawing.Point(91, 287)
        Me.lblModificarProveedorTipo.Name = "lblModificarProveedorTipo"
        Me.lblModificarProveedorTipo.Size = New System.Drawing.Size(126, 17)
        Me.lblModificarProveedorTipo.TabIndex = 23
        Me.lblModificarProveedorTipo.Text = "Tipo de Proveedor"
        '
        'lblModificarProveedorCIF
        '
        Me.lblModificarProveedorCIF.AutoSize = True
        Me.lblModificarProveedorCIF.Location = New System.Drawing.Point(91, 251)
        Me.lblModificarProveedorCIF.Name = "lblModificarProveedorCIF"
        Me.lblModificarProveedorCIF.Size = New System.Drawing.Size(28, 17)
        Me.lblModificarProveedorCIF.TabIndex = 22
        Me.lblModificarProveedorCIF.Text = "CIF"
        '
        'lblModificarProveedorNombre
        '
        Me.lblModificarProveedorNombre.AutoSize = True
        Me.lblModificarProveedorNombre.Location = New System.Drawing.Point(91, 181)
        Me.lblModificarProveedorNombre.Name = "lblModificarProveedorNombre"
        Me.lblModificarProveedorNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblModificarProveedorNombre.TabIndex = 21
        Me.lblModificarProveedorNombre.Text = "Nombre "
        '
        'lblModificarProveedorNombreEmpresa
        '
        Me.lblModificarProveedorNombreEmpresa.AutoSize = True
        Me.lblModificarProveedorNombreEmpresa.Location = New System.Drawing.Point(91, 137)
        Me.lblModificarProveedorNombreEmpresa.Name = "lblModificarProveedorNombreEmpresa"
        Me.lblModificarProveedorNombreEmpresa.Size = New System.Drawing.Size(153, 17)
        Me.lblModificarProveedorNombreEmpresa.TabIndex = 20
        Me.lblModificarProveedorNombreEmpresa.Text = "Nombre de la Empresa"
        '
        'lblModificarProveedor
        '
        Me.lblModificarProveedor.AutoSize = True
        Me.lblModificarProveedor.Font = New System.Drawing.Font("Microsoft YaHei", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarProveedor.Location = New System.Drawing.Point(184, 39)
        Me.lblModificarProveedor.Name = "lblModificarProveedor"
        Me.lblModificarProveedor.Size = New System.Drawing.Size(445, 57)
        Me.lblModificarProveedor.TabIndex = 0
        Me.lblModificarProveedor.Text = "Modificar Proveedor"
        '
        'ConsultarProveedor
        '
        Me.ConsultarProveedor.Controls.Add(Me.btnConsultarProveedorBuscar)
        Me.ConsultarProveedor.Controls.Add(Me.txtConsultarProveedorCIFBusqueda)
        Me.ConsultarProveedor.Controls.Add(Me.lblConsultarProveedorCIFBusqueda)
        Me.ConsultarProveedor.Controls.Add(Me.btnConsultarProveedorCancelar)
        Me.ConsultarProveedor.Controls.Add(Me.txtConsultarProveedorEmail)
        Me.ConsultarProveedor.Controls.Add(Me.txtConsultarProveedorTelefono)
        Me.ConsultarProveedor.Controls.Add(Me.txtConsultarProveedorDireccion)
        Me.ConsultarProveedor.Controls.Add(Me.lblConsultarProveedorEmail)
        Me.ConsultarProveedor.Controls.Add(Me.lblConsultarProveedorTelefono)
        Me.ConsultarProveedor.Controls.Add(Me.lblConsultarProveedorDireccion)
        Me.ConsultarProveedor.Controls.Add(Me.txtConsultarProveedorTipo)
        Me.ConsultarProveedor.Controls.Add(Me.txtConsultarProveedorCIF)
        Me.ConsultarProveedor.Controls.Add(Me.txtConsultarProveedorApellido)
        Me.ConsultarProveedor.Controls.Add(Me.txtConsultarProveedorNombre)
        Me.ConsultarProveedor.Controls.Add(Me.txtConsultarProveedorNombreEmpresa)
        Me.ConsultarProveedor.Controls.Add(Me.lblConsultarProveedorApellido)
        Me.ConsultarProveedor.Controls.Add(Me.lblConsultarProveedorTipos)
        Me.ConsultarProveedor.Controls.Add(Me.lblConsultarProveedorCIF)
        Me.ConsultarProveedor.Controls.Add(Me.lblConsultarProveedorNombre)
        Me.ConsultarProveedor.Controls.Add(Me.lblConsultarProveedorNombreEmpresa)
        Me.ConsultarProveedor.Controls.Add(Me.lblConsultarProveedor)
        Me.ConsultarProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsultarProveedor.Location = New System.Drawing.Point(0, 0)
        Me.ConsultarProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConsultarProveedor.Name = "ConsultarProveedor"
        Me.ConsultarProveedor.Size = New System.Drawing.Size(773, 422)
        Me.ConsultarProveedor.TabIndex = 7
        '
        'btnConsultarProveedorCancelar
        '
        Me.btnConsultarProveedorCancelar.Location = New System.Drawing.Point(123, 348)
        Me.btnConsultarProveedorCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConsultarProveedorCancelar.Name = "btnConsultarProveedorCancelar"
        Me.btnConsultarProveedorCancelar.Size = New System.Drawing.Size(131, 39)
        Me.btnConsultarProveedorCancelar.TabIndex = 55
        Me.btnConsultarProveedorCancelar.Text = "Atrás"
        Me.btnConsultarProveedorCancelar.UseVisualStyleBackColor = True
        '
        'txtConsultarProveedorEmail
        '
        Me.txtConsultarProveedorEmail.Location = New System.Drawing.Point(582, 289)
        Me.txtConsultarProveedorEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarProveedorEmail.Name = "txtConsultarProveedorEmail"
        Me.txtConsultarProveedorEmail.Size = New System.Drawing.Size(167, 22)
        Me.txtConsultarProveedorEmail.TabIndex = 54
        '
        'txtConsultarProveedorTelefono
        '
        Me.txtConsultarProveedorTelefono.Location = New System.Drawing.Point(582, 251)
        Me.txtConsultarProveedorTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarProveedorTelefono.Name = "txtConsultarProveedorTelefono"
        Me.txtConsultarProveedorTelefono.Size = New System.Drawing.Size(167, 22)
        Me.txtConsultarProveedorTelefono.TabIndex = 53
        '
        'txtConsultarProveedorDireccion
        '
        Me.txtConsultarProveedorDireccion.Location = New System.Drawing.Point(582, 206)
        Me.txtConsultarProveedorDireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarProveedorDireccion.Name = "txtConsultarProveedorDireccion"
        Me.txtConsultarProveedorDireccion.Size = New System.Drawing.Size(167, 22)
        Me.txtConsultarProveedorDireccion.TabIndex = 52
        '
        'lblConsultarProveedorEmail
        '
        Me.lblConsultarProveedorEmail.AutoSize = True
        Me.lblConsultarProveedorEmail.Location = New System.Drawing.Point(425, 282)
        Me.lblConsultarProveedorEmail.Name = "lblConsultarProveedorEmail"
        Me.lblConsultarProveedorEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblConsultarProveedorEmail.TabIndex = 51
        Me.lblConsultarProveedorEmail.Text = "Email"
        '
        'lblConsultarProveedorTelefono
        '
        Me.lblConsultarProveedorTelefono.AutoSize = True
        Me.lblConsultarProveedorTelefono.Location = New System.Drawing.Point(425, 244)
        Me.lblConsultarProveedorTelefono.Name = "lblConsultarProveedorTelefono"
        Me.lblConsultarProveedorTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblConsultarProveedorTelefono.TabIndex = 50
        Me.lblConsultarProveedorTelefono.Text = "Teléfono"
        '
        'lblConsultarProveedorDireccion
        '
        Me.lblConsultarProveedorDireccion.AutoSize = True
        Me.lblConsultarProveedorDireccion.Location = New System.Drawing.Point(425, 199)
        Me.lblConsultarProveedorDireccion.Name = "lblConsultarProveedorDireccion"
        Me.lblConsultarProveedorDireccion.Size = New System.Drawing.Size(67, 17)
        Me.lblConsultarProveedorDireccion.TabIndex = 49
        Me.lblConsultarProveedorDireccion.Text = "Dirección"
        '
        'txtConsultarProveedorTipo
        '
        Me.txtConsultarProveedorTipo.Location = New System.Drawing.Point(582, 161)
        Me.txtConsultarProveedorTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarProveedorTipo.Name = "txtConsultarProveedorTipo"
        Me.txtConsultarProveedorTipo.Size = New System.Drawing.Size(167, 22)
        Me.txtConsultarProveedorTipo.TabIndex = 48
        '
        'txtConsultarProveedorCIF
        '
        Me.txtConsultarProveedorCIF.Location = New System.Drawing.Point(209, 286)
        Me.txtConsultarProveedorCIF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarProveedorCIF.Name = "txtConsultarProveedorCIF"
        Me.txtConsultarProveedorCIF.Size = New System.Drawing.Size(167, 22)
        Me.txtConsultarProveedorCIF.TabIndex = 47
        '
        'txtConsultarProveedorApellido
        '
        Me.txtConsultarProveedorApellido.Location = New System.Drawing.Point(209, 252)
        Me.txtConsultarProveedorApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarProveedorApellido.Name = "txtConsultarProveedorApellido"
        Me.txtConsultarProveedorApellido.Size = New System.Drawing.Size(167, 22)
        Me.txtConsultarProveedorApellido.TabIndex = 46
        '
        'txtConsultarProveedorNombre
        '
        Me.txtConsultarProveedorNombre.Location = New System.Drawing.Point(209, 214)
        Me.txtConsultarProveedorNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarProveedorNombre.Name = "txtConsultarProveedorNombre"
        Me.txtConsultarProveedorNombre.Size = New System.Drawing.Size(167, 22)
        Me.txtConsultarProveedorNombre.TabIndex = 45
        '
        'txtConsultarProveedorNombreEmpresa
        '
        Me.txtConsultarProveedorNombreEmpresa.Location = New System.Drawing.Point(209, 170)
        Me.txtConsultarProveedorNombreEmpresa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarProveedorNombreEmpresa.Name = "txtConsultarProveedorNombreEmpresa"
        Me.txtConsultarProveedorNombreEmpresa.Size = New System.Drawing.Size(167, 22)
        Me.txtConsultarProveedorNombreEmpresa.TabIndex = 44
        '
        'lblConsultarProveedorApellido
        '
        Me.lblConsultarProveedorApellido.AutoSize = True
        Me.lblConsultarProveedorApellido.Location = New System.Drawing.Point(49, 255)
        Me.lblConsultarProveedorApellido.Name = "lblConsultarProveedorApellido"
        Me.lblConsultarProveedorApellido.Size = New System.Drawing.Size(58, 17)
        Me.lblConsultarProveedorApellido.TabIndex = 43
        Me.lblConsultarProveedorApellido.Text = "Apellido"
        '
        'lblConsultarProveedorTipos
        '
        Me.lblConsultarProveedorTipos.AutoSize = True
        Me.lblConsultarProveedorTipos.Location = New System.Drawing.Point(422, 164)
        Me.lblConsultarProveedorTipos.Name = "lblConsultarProveedorTipos"
        Me.lblConsultarProveedorTipos.Size = New System.Drawing.Size(126, 17)
        Me.lblConsultarProveedorTipos.TabIndex = 42
        Me.lblConsultarProveedorTipos.Text = "Tipo de Proveedor"
        '
        'lblConsultarProveedorCIF
        '
        Me.lblConsultarProveedorCIF.AutoSize = True
        Me.lblConsultarProveedorCIF.Location = New System.Drawing.Point(49, 287)
        Me.lblConsultarProveedorCIF.Name = "lblConsultarProveedorCIF"
        Me.lblConsultarProveedorCIF.Size = New System.Drawing.Size(28, 17)
        Me.lblConsultarProveedorCIF.TabIndex = 41
        Me.lblConsultarProveedorCIF.Text = "CIF"
        '
        'lblConsultarProveedorNombre
        '
        Me.lblConsultarProveedorNombre.AutoSize = True
        Me.lblConsultarProveedorNombre.Location = New System.Drawing.Point(49, 217)
        Me.lblConsultarProveedorNombre.Name = "lblConsultarProveedorNombre"
        Me.lblConsultarProveedorNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblConsultarProveedorNombre.TabIndex = 40
        Me.lblConsultarProveedorNombre.Text = "Nombre "
        '
        'lblConsultarProveedorNombreEmpresa
        '
        Me.lblConsultarProveedorNombreEmpresa.AutoSize = True
        Me.lblConsultarProveedorNombreEmpresa.Location = New System.Drawing.Point(49, 172)
        Me.lblConsultarProveedorNombreEmpresa.Name = "lblConsultarProveedorNombreEmpresa"
        Me.lblConsultarProveedorNombreEmpresa.Size = New System.Drawing.Size(153, 17)
        Me.lblConsultarProveedorNombreEmpresa.TabIndex = 39
        Me.lblConsultarProveedorNombreEmpresa.Text = "Nombre de la Empresa"
        '
        'lblConsultarProveedor
        '
        Me.lblConsultarProveedor.AutoSize = True
        Me.lblConsultarProveedor.Font = New System.Drawing.Font("Microsoft YaHei", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultarProveedor.Location = New System.Drawing.Point(182, 15)
        Me.lblConsultarProveedor.Name = "lblConsultarProveedor"
        Me.lblConsultarProveedor.Size = New System.Drawing.Size(446, 57)
        Me.lblConsultarProveedor.TabIndex = 38
        Me.lblConsultarProveedor.Text = "Consultar Proveedor"
        '
        'BajaProveedor
        '
        Me.BajaProveedor.Controls.Add(Me.btnBajaProveedorAceptar)
        Me.BajaProveedor.Controls.Add(Me.btnBajaProveedorCancelar)
        Me.BajaProveedor.Controls.Add(Me.txtBajaProveedorRazon)
        Me.BajaProveedor.Controls.Add(Me.lblBajaProveedorRazon)
        Me.BajaProveedor.Controls.Add(Me.txtBajaProveedorDNI)
        Me.BajaProveedor.Controls.Add(Me.lblBajaProveedorDNI)
        Me.BajaProveedor.Controls.Add(Me.lblMenuBajaProveedor)
        Me.BajaProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BajaProveedor.Location = New System.Drawing.Point(0, 0)
        Me.BajaProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BajaProveedor.Name = "BajaProveedor"
        Me.BajaProveedor.Size = New System.Drawing.Size(773, 422)
        Me.BajaProveedor.TabIndex = 7
        '
        'btnBajaProveedorAceptar
        '
        Me.btnBajaProveedorAceptar.Location = New System.Drawing.Point(531, 353)
        Me.btnBajaProveedorAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBajaProveedorAceptar.Name = "btnBajaProveedorAceptar"
        Me.btnBajaProveedorAceptar.Size = New System.Drawing.Size(127, 37)
        Me.btnBajaProveedorAceptar.TabIndex = 13
        Me.btnBajaProveedorAceptar.Text = "Aceptar"
        Me.btnBajaProveedorAceptar.UseVisualStyleBackColor = True
        '
        'btnBajaProveedorCancelar
        '
        Me.btnBajaProveedorCancelar.Location = New System.Drawing.Point(165, 347)
        Me.btnBajaProveedorCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBajaProveedorCancelar.Name = "btnBajaProveedorCancelar"
        Me.btnBajaProveedorCancelar.Size = New System.Drawing.Size(127, 37)
        Me.btnBajaProveedorCancelar.TabIndex = 12
        Me.btnBajaProveedorCancelar.Text = "Cancelar"
        Me.btnBajaProveedorCancelar.UseVisualStyleBackColor = True
        '
        'txtBajaProveedorRazon
        '
        Me.txtBajaProveedorRazon.Location = New System.Drawing.Point(232, 257)
        Me.txtBajaProveedorRazon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBajaProveedorRazon.Name = "txtBajaProveedorRazon"
        Me.txtBajaProveedorRazon.Size = New System.Drawing.Size(405, 22)
        Me.txtBajaProveedorRazon.TabIndex = 11
        '
        'lblBajaProveedorRazon
        '
        Me.lblBajaProveedorRazon.AutoSize = True
        Me.lblBajaProveedorRazon.Location = New System.Drawing.Point(144, 260)
        Me.lblBajaProveedorRazon.Name = "lblBajaProveedorRazon"
        Me.lblBajaProveedorRazon.Size = New System.Drawing.Size(49, 17)
        Me.lblBajaProveedorRazon.TabIndex = 10
        Me.lblBajaProveedorRazon.Text = "Razón"
        '
        'txtBajaProveedorDNI
        '
        Me.txtBajaProveedorDNI.Location = New System.Drawing.Point(232, 151)
        Me.txtBajaProveedorDNI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBajaProveedorDNI.Name = "txtBajaProveedorDNI"
        Me.txtBajaProveedorDNI.Size = New System.Drawing.Size(167, 22)
        Me.txtBajaProveedorDNI.TabIndex = 9
        '
        'lblBajaProveedorDNI
        '
        Me.lblBajaProveedorDNI.AutoSize = True
        Me.lblBajaProveedorDNI.Location = New System.Drawing.Point(144, 154)
        Me.lblBajaProveedorDNI.Name = "lblBajaProveedorDNI"
        Me.lblBajaProveedorDNI.Size = New System.Drawing.Size(31, 17)
        Me.lblBajaProveedorDNI.TabIndex = 8
        Me.lblBajaProveedorDNI.Text = "DNI"
        '
        'lblMenuBajaProveedor
        '
        Me.lblMenuBajaProveedor.AutoSize = True
        Me.lblMenuBajaProveedor.Font = New System.Drawing.Font("Microsoft YaHei", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuBajaProveedor.Location = New System.Drawing.Point(224, 38)
        Me.lblMenuBajaProveedor.Name = "lblMenuBajaProveedor"
        Me.lblMenuBajaProveedor.Size = New System.Drawing.Size(360, 43)
        Me.lblMenuBajaProveedor.TabIndex = 7
        Me.lblMenuBajaProveedor.Text = "Menú Baja Proveedor"
        '
        'MenuClientes
        '
        Me.MenuClientes.Controls.Add(Me.btnMenuClientesAtras)
        Me.MenuClientes.Controls.Add(Me.btnMenuClientesFContratacion)
        Me.MenuClientes.Controls.Add(Me.btnMenuClientesSalir)
        Me.MenuClientes.Controls.Add(Me.btnMenuClientesCContrataciones)
        Me.MenuClientes.Controls.Add(Me.btnMenuClientesNContratacion)
        Me.MenuClientes.Controls.Add(Me.btnMenuClientesAtendidos)
        Me.MenuClientes.Controls.Add(Me.lblMenuClientes)
        Me.MenuClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuClientes.Location = New System.Drawing.Point(0, 0)
        Me.MenuClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MenuClientes.Name = "MenuClientes"
        Me.MenuClientes.Size = New System.Drawing.Size(773, 422)
        Me.MenuClientes.TabIndex = 7
        '
        'btnMenuClientesAtras
        '
        Me.btnMenuClientesAtras.Location = New System.Drawing.Point(91, 336)
        Me.btnMenuClientesAtras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuClientesAtras.Name = "btnMenuClientesAtras"
        Me.btnMenuClientesAtras.Size = New System.Drawing.Size(128, 37)
        Me.btnMenuClientesAtras.TabIndex = 8
        Me.btnMenuClientesAtras.Text = "Salir"
        Me.btnMenuClientesAtras.UseVisualStyleBackColor = True
        '
        'btnMenuClientesFContratacion
        '
        Me.btnMenuClientesFContratacion.Location = New System.Drawing.Point(472, 245)
        Me.btnMenuClientesFContratacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuClientesFContratacion.Name = "btnMenuClientesFContratacion"
        Me.btnMenuClientesFContratacion.Size = New System.Drawing.Size(147, 55)
        Me.btnMenuClientesFContratacion.TabIndex = 7
        Me.btnMenuClientesFContratacion.Text = "Finalizar Contratación"
        Me.btnMenuClientesFContratacion.UseVisualStyleBackColor = True
        '
        'btnMenuClientesSalir
        '
        Me.btnMenuClientesSalir.Location = New System.Drawing.Point(591, 336)
        Me.btnMenuClientesSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuClientesSalir.Name = "btnMenuClientesSalir"
        Me.btnMenuClientesSalir.Size = New System.Drawing.Size(128, 37)
        Me.btnMenuClientesSalir.TabIndex = 6
        Me.btnMenuClientesSalir.Text = "Salir"
        Me.btnMenuClientesSalir.UseVisualStyleBackColor = True
        '
        'btnMenuClientesCContrataciones
        '
        Me.btnMenuClientesCContrataciones.Location = New System.Drawing.Point(167, 245)
        Me.btnMenuClientesCContrataciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuClientesCContrataciones.Name = "btnMenuClientesCContrataciones"
        Me.btnMenuClientesCContrataciones.Size = New System.Drawing.Size(147, 55)
        Me.btnMenuClientesCContrataciones.TabIndex = 4
        Me.btnMenuClientesCContrataciones.Text = "Contrataciones en curso"
        Me.btnMenuClientesCContrataciones.UseVisualStyleBackColor = True
        '
        'btnMenuClientesNContratacion
        '
        Me.btnMenuClientesNContratacion.Location = New System.Drawing.Point(471, 143)
        Me.btnMenuClientesNContratacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuClientesNContratacion.Name = "btnMenuClientesNContratacion"
        Me.btnMenuClientesNContratacion.Size = New System.Drawing.Size(147, 55)
        Me.btnMenuClientesNContratacion.TabIndex = 3
        Me.btnMenuClientesNContratacion.Text = "Nueva Contratación"
        Me.btnMenuClientesNContratacion.UseVisualStyleBackColor = True
        '
        'btnMenuClientesAtendidos
        '
        Me.btnMenuClientesAtendidos.Location = New System.Drawing.Point(165, 142)
        Me.btnMenuClientesAtendidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuClientesAtendidos.Name = "btnMenuClientesAtendidos"
        Me.btnMenuClientesAtendidos.Size = New System.Drawing.Size(147, 55)
        Me.btnMenuClientesAtendidos.TabIndex = 2
        Me.btnMenuClientesAtendidos.Text = "Clientes Atendidos"
        Me.btnMenuClientesAtendidos.UseVisualStyleBackColor = True
        '
        'lblMenuClientes
        '
        Me.lblMenuClientes.AutoSize = True
        Me.lblMenuClientes.Font = New System.Drawing.Font("Microsoft YaHei", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuClientes.Location = New System.Drawing.Point(180, 28)
        Me.lblMenuClientes.Name = "lblMenuClientes"
        Me.lblMenuClientes.Size = New System.Drawing.Size(385, 57)
        Me.lblMenuClientes.TabIndex = 1
        Me.lblMenuClientes.Text = "Menú de Clientes"
        '
        'ClientesAtendidos
        '
        Me.ClientesAtendidos.Controls.Add(Me.txtClientesAtendidosFecha)
        Me.ClientesAtendidos.Controls.Add(Me.lblClientesAtendidosFecha)
        Me.ClientesAtendidos.Controls.Add(Me.btnClientesAtendidosAtras)
        Me.ClientesAtendidos.Controls.Add(Me.btnClientesAtendidosBuscar)
        Me.ClientesAtendidos.Controls.Add(Me.txtClientesAtendidosCoste)
        Me.ClientesAtendidos.Controls.Add(Me.lblClientesAtendidosCoste)
        Me.ClientesAtendidos.Controls.Add(Me.txtClientesAtendidosTipoServicio)
        Me.ClientesAtendidos.Controls.Add(Me.lblClientesAtendidosTipoServicio)
        Me.ClientesAtendidos.Controls.Add(Me.txtClientesAtendidosEmail)
        Me.ClientesAtendidos.Controls.Add(Me.lblClientesAtendidosEmail)
        Me.ClientesAtendidos.Controls.Add(Me.txtClientesAtendidosTelefono)
        Me.ClientesAtendidos.Controls.Add(Me.lblClientesAtendidosTelefono)
        Me.ClientesAtendidos.Controls.Add(Me.txtClientesAtendidosDireccion)
        Me.ClientesAtendidos.Controls.Add(Me.lblClientesAtendidosDireccion)
        Me.ClientesAtendidos.Controls.Add(Me.txtClientesAtendidosDNI)
        Me.ClientesAtendidos.Controls.Add(Me.lblClientesAtendidosDNI)
        Me.ClientesAtendidos.Controls.Add(Me.txtClientesAtendidosApellidos)
        Me.ClientesAtendidos.Controls.Add(Me.lblClientesAtendidosApellidos)
        Me.ClientesAtendidos.Controls.Add(Me.lblClientesAtendidosNombre)
        Me.ClientesAtendidos.Controls.Add(Me.lblClientesAtendidosInformacion)
        Me.ClientesAtendidos.Controls.Add(Me.txtClientesAtendidosNombre)
        Me.ClientesAtendidos.Controls.Add(Me.lblClientesAtendidosBusqueda)
        Me.ClientesAtendidos.Controls.Add(Me.txtClientesAtendidosBusqueda)
        Me.ClientesAtendidos.Controls.Add(Me.lblMenuClientesAtendidos)
        Me.ClientesAtendidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClientesAtendidos.Location = New System.Drawing.Point(0, 0)
        Me.ClientesAtendidos.Margin = New System.Windows.Forms.Padding(4)
        Me.ClientesAtendidos.Name = "ClientesAtendidos"
        Me.ClientesAtendidos.Size = New System.Drawing.Size(773, 422)
        Me.ClientesAtendidos.TabIndex = 7
        '
        'txtClientesAtendidosFecha
        '
        Me.txtClientesAtendidosFecha.Location = New System.Drawing.Point(525, 361)
        Me.txtClientesAtendidosFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientesAtendidosFecha.Name = "txtClientesAtendidosFecha"
        Me.txtClientesAtendidosFecha.Size = New System.Drawing.Size(132, 22)
        Me.txtClientesAtendidosFecha.TabIndex = 24
        '
        'lblClientesAtendidosFecha
        '
        Me.lblClientesAtendidosFecha.AutoSize = True
        Me.lblClientesAtendidosFecha.Location = New System.Drawing.Point(392, 362)
        Me.lblClientesAtendidosFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientesAtendidosFecha.Name = "lblClientesAtendidosFecha"
        Me.lblClientesAtendidosFecha.Size = New System.Drawing.Size(131, 17)
        Me.lblClientesAtendidosFecha.TabIndex = 23
        Me.lblClientesAtendidosFecha.Text = "Fecha Contratación"
        Me.lblClientesAtendidosFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnClientesAtendidosAtras
        '
        Me.btnClientesAtendidosAtras.Location = New System.Drawing.Point(81, 357)
        Me.btnClientesAtendidosAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClientesAtendidosAtras.Name = "btnClientesAtendidosAtras"
        Me.btnClientesAtendidosAtras.Size = New System.Drawing.Size(136, 37)
        Me.btnClientesAtendidosAtras.TabIndex = 22
        Me.btnClientesAtendidosAtras.Text = "Atrás"
        Me.btnClientesAtendidosAtras.UseVisualStyleBackColor = True
        '
        'btnClientesAtendidosBuscar
        '
        Me.btnClientesAtendidosBuscar.Location = New System.Drawing.Point(531, 92)
        Me.btnClientesAtendidosBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClientesAtendidosBuscar.Name = "btnClientesAtendidosBuscar"
        Me.btnClientesAtendidosBuscar.Size = New System.Drawing.Size(136, 39)
        Me.btnClientesAtendidosBuscar.TabIndex = 21
        Me.btnClientesAtendidosBuscar.Text = "Buscar"
        Me.btnClientesAtendidosBuscar.UseVisualStyleBackColor = True
        '
        'txtClientesAtendidosCoste
        '
        Me.txtClientesAtendidosCoste.Location = New System.Drawing.Point(525, 318)
        Me.txtClientesAtendidosCoste.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientesAtendidosCoste.Name = "txtClientesAtendidosCoste"
        Me.txtClientesAtendidosCoste.Size = New System.Drawing.Size(132, 22)
        Me.txtClientesAtendidosCoste.TabIndex = 20
        '
        'lblClientesAtendidosCoste
        '
        Me.lblClientesAtendidosCoste.AutoSize = True
        Me.lblClientesAtendidosCoste.Location = New System.Drawing.Point(392, 319)
        Me.lblClientesAtendidosCoste.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientesAtendidosCoste.Name = "lblClientesAtendidosCoste"
        Me.lblClientesAtendidosCoste.Size = New System.Drawing.Size(44, 17)
        Me.lblClientesAtendidosCoste.TabIndex = 19
        Me.lblClientesAtendidosCoste.Text = "Coste"
        Me.lblClientesAtendidosCoste.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtClientesAtendidosTipoServicio
        '
        Me.txtClientesAtendidosTipoServicio.Location = New System.Drawing.Point(525, 276)
        Me.txtClientesAtendidosTipoServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientesAtendidosTipoServicio.Name = "txtClientesAtendidosTipoServicio"
        Me.txtClientesAtendidosTipoServicio.Size = New System.Drawing.Size(132, 22)
        Me.txtClientesAtendidosTipoServicio.TabIndex = 18
        '
        'lblClientesAtendidosTipoServicio
        '
        Me.lblClientesAtendidosTipoServicio.AutoSize = True
        Me.lblClientesAtendidosTipoServicio.Location = New System.Drawing.Point(392, 276)
        Me.lblClientesAtendidosTipoServicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientesAtendidosTipoServicio.Name = "lblClientesAtendidosTipoServicio"
        Me.lblClientesAtendidosTipoServicio.Size = New System.Drawing.Size(110, 17)
        Me.lblClientesAtendidosTipoServicio.TabIndex = 17
        Me.lblClientesAtendidosTipoServicio.Text = "Tipo de Servicio"
        Me.lblClientesAtendidosTipoServicio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtClientesAtendidosEmail
        '
        Me.txtClientesAtendidosEmail.Location = New System.Drawing.Point(525, 234)
        Me.txtClientesAtendidosEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientesAtendidosEmail.Name = "txtClientesAtendidosEmail"
        Me.txtClientesAtendidosEmail.Size = New System.Drawing.Size(132, 22)
        Me.txtClientesAtendidosEmail.TabIndex = 16
        '
        'lblClientesAtendidosEmail
        '
        Me.lblClientesAtendidosEmail.AutoSize = True
        Me.lblClientesAtendidosEmail.Location = New System.Drawing.Point(391, 233)
        Me.lblClientesAtendidosEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientesAtendidosEmail.Name = "lblClientesAtendidosEmail"
        Me.lblClientesAtendidosEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblClientesAtendidosEmail.TabIndex = 15
        Me.lblClientesAtendidosEmail.Text = "Email"
        Me.lblClientesAtendidosEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtClientesAtendidosTelefono
        '
        Me.txtClientesAtendidosTelefono.Location = New System.Drawing.Point(525, 193)
        Me.txtClientesAtendidosTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientesAtendidosTelefono.Name = "txtClientesAtendidosTelefono"
        Me.txtClientesAtendidosTelefono.Size = New System.Drawing.Size(132, 22)
        Me.txtClientesAtendidosTelefono.TabIndex = 14
        '
        'lblClientesAtendidosTelefono
        '
        Me.lblClientesAtendidosTelefono.AutoSize = True
        Me.lblClientesAtendidosTelefono.Location = New System.Drawing.Point(392, 194)
        Me.lblClientesAtendidosTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientesAtendidosTelefono.Name = "lblClientesAtendidosTelefono"
        Me.lblClientesAtendidosTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblClientesAtendidosTelefono.TabIndex = 13
        Me.lblClientesAtendidosTelefono.Text = "Teléfono"
        Me.lblClientesAtendidosTelefono.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtClientesAtendidosDireccion
        '
        Me.txtClientesAtendidosDireccion.Location = New System.Drawing.Point(201, 315)
        Me.txtClientesAtendidosDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientesAtendidosDireccion.Name = "txtClientesAtendidosDireccion"
        Me.txtClientesAtendidosDireccion.Size = New System.Drawing.Size(132, 22)
        Me.txtClientesAtendidosDireccion.TabIndex = 12
        '
        'lblClientesAtendidosDireccion
        '
        Me.lblClientesAtendidosDireccion.AutoSize = True
        Me.lblClientesAtendidosDireccion.Location = New System.Drawing.Point(120, 318)
        Me.lblClientesAtendidosDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientesAtendidosDireccion.Name = "lblClientesAtendidosDireccion"
        Me.lblClientesAtendidosDireccion.Size = New System.Drawing.Size(67, 17)
        Me.lblClientesAtendidosDireccion.TabIndex = 11
        Me.lblClientesAtendidosDireccion.Text = "Dirección"
        Me.lblClientesAtendidosDireccion.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtClientesAtendidosDNI
        '
        Me.txtClientesAtendidosDNI.Location = New System.Drawing.Point(201, 274)
        Me.txtClientesAtendidosDNI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientesAtendidosDNI.Name = "txtClientesAtendidosDNI"
        Me.txtClientesAtendidosDNI.Size = New System.Drawing.Size(132, 22)
        Me.txtClientesAtendidosDNI.TabIndex = 10
        '
        'lblClientesAtendidosDNI
        '
        Me.lblClientesAtendidosDNI.AutoSize = True
        Me.lblClientesAtendidosDNI.Location = New System.Drawing.Point(120, 277)
        Me.lblClientesAtendidosDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientesAtendidosDNI.Name = "lblClientesAtendidosDNI"
        Me.lblClientesAtendidosDNI.Size = New System.Drawing.Size(31, 17)
        Me.lblClientesAtendidosDNI.TabIndex = 9
        Me.lblClientesAtendidosDNI.Text = "DNI"
        Me.lblClientesAtendidosDNI.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtClientesAtendidosApellidos
        '
        Me.txtClientesAtendidosApellidos.Location = New System.Drawing.Point(201, 233)
        Me.txtClientesAtendidosApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientesAtendidosApellidos.Name = "txtClientesAtendidosApellidos"
        Me.txtClientesAtendidosApellidos.Size = New System.Drawing.Size(132, 22)
        Me.txtClientesAtendidosApellidos.TabIndex = 8
        '
        'lblClientesAtendidosApellidos
        '
        Me.lblClientesAtendidosApellidos.AutoSize = True
        Me.lblClientesAtendidosApellidos.Location = New System.Drawing.Point(119, 236)
        Me.lblClientesAtendidosApellidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientesAtendidosApellidos.Name = "lblClientesAtendidosApellidos"
        Me.lblClientesAtendidosApellidos.Size = New System.Drawing.Size(65, 17)
        Me.lblClientesAtendidosApellidos.TabIndex = 7
        Me.lblClientesAtendidosApellidos.Text = "Apellidos"
        Me.lblClientesAtendidosApellidos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblClientesAtendidosNombre
        '
        Me.lblClientesAtendidosNombre.AutoSize = True
        Me.lblClientesAtendidosNombre.Location = New System.Drawing.Point(119, 197)
        Me.lblClientesAtendidosNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientesAtendidosNombre.Name = "lblClientesAtendidosNombre"
        Me.lblClientesAtendidosNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblClientesAtendidosNombre.TabIndex = 6
        Me.lblClientesAtendidosNombre.Text = "Nombre"
        '
        'lblClientesAtendidosInformacion
        '
        Me.lblClientesAtendidosInformacion.AutoSize = True
        Me.lblClientesAtendidosInformacion.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientesAtendidosInformacion.Location = New System.Drawing.Point(271, 144)
        Me.lblClientesAtendidosInformacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientesAtendidosInformacion.Name = "lblClientesAtendidosInformacion"
        Me.lblClientesAtendidosInformacion.Size = New System.Drawing.Size(230, 27)
        Me.lblClientesAtendidosInformacion.TabIndex = 5
        Me.lblClientesAtendidosInformacion.Text = "Información del cliente"
        '
        'txtClientesAtendidosNombre
        '
        Me.txtClientesAtendidosNombre.Location = New System.Drawing.Point(201, 192)
        Me.txtClientesAtendidosNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientesAtendidosNombre.Name = "txtClientesAtendidosNombre"
        Me.txtClientesAtendidosNombre.Size = New System.Drawing.Size(132, 22)
        Me.txtClientesAtendidosNombre.TabIndex = 4
        '
        'lblClientesAtendidosBusqueda
        '
        Me.lblClientesAtendidosBusqueda.AutoSize = True
        Me.lblClientesAtendidosBusqueda.Location = New System.Drawing.Point(145, 101)
        Me.lblClientesAtendidosBusqueda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientesAtendidosBusqueda.Name = "lblClientesAtendidosBusqueda"
        Me.lblClientesAtendidosBusqueda.Size = New System.Drawing.Size(186, 17)
        Me.lblClientesAtendidosBusqueda.TabIndex = 3
        Me.lblClientesAtendidosBusqueda.Text = "Introduzca el DNI del Cliente"
        '
        'txtClientesAtendidosBusqueda
        '
        Me.txtClientesAtendidosBusqueda.Location = New System.Drawing.Point(356, 97)
        Me.txtClientesAtendidosBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientesAtendidosBusqueda.Name = "txtClientesAtendidosBusqueda"
        Me.txtClientesAtendidosBusqueda.Size = New System.Drawing.Size(132, 22)
        Me.txtClientesAtendidosBusqueda.TabIndex = 2
        '
        'lblMenuClientesAtendidos
        '
        Me.lblMenuClientesAtendidos.AutoSize = True
        Me.lblMenuClientesAtendidos.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuClientesAtendidos.Location = New System.Drawing.Point(209, 28)
        Me.lblMenuClientesAtendidos.Name = "lblMenuClientesAtendidos"
        Me.lblMenuClientesAtendidos.Size = New System.Drawing.Size(327, 45)
        Me.lblMenuClientesAtendidos.TabIndex = 1
        Me.lblMenuClientesAtendidos.Text = "Clientes Atendidos"
        '
        'NuevaContratacion
        '
        Me.NuevaContratacion.Controls.Add(Me.CBNuevaContratacionTrabajador)
        Me.NuevaContratacion.Controls.Add(Me.lblNuevaContratacionTrabajador)
        Me.NuevaContratacion.Controls.Add(Me.DateTimePickerNuevaContratacion)
        Me.NuevaContratacion.Controls.Add(Me.btnNuevaContratacionAceptar)
        Me.NuevaContratacion.Controls.Add(Me.btnNuevaContratacionCancelar)
        Me.NuevaContratacion.Controls.Add(Me.lblNuevaContratacionFechaContratacion)
        Me.NuevaContratacion.Controls.Add(Me.txtNuevaContratacionCoste)
        Me.NuevaContratacion.Controls.Add(Me.lblNuevaContratacionCoste)
        Me.NuevaContratacion.Controls.Add(Me.txtNuevaContratacionTipoServicio)
        Me.NuevaContratacion.Controls.Add(Me.lblNuevaContratacionTipoServicio)
        Me.NuevaContratacion.Controls.Add(Me.txtNuevaContratacionEmail)
        Me.NuevaContratacion.Controls.Add(Me.lblNuevaContratacionEmail)
        Me.NuevaContratacion.Controls.Add(Me.txtNuevaContratacionTelefono)
        Me.NuevaContratacion.Controls.Add(Me.lblNuevaContratacionTelefono)
        Me.NuevaContratacion.Controls.Add(Me.txtNuevaContratacionDireccion)
        Me.NuevaContratacion.Controls.Add(Me.lblNuevaContratacionDireccion)
        Me.NuevaContratacion.Controls.Add(Me.txtNuevaContratacionDNI)
        Me.NuevaContratacion.Controls.Add(Me.lblNuevaContratacionDNI)
        Me.NuevaContratacion.Controls.Add(Me.txtNuevaContratacionApellidos)
        Me.NuevaContratacion.Controls.Add(Me.lblNuevaContratacionApellidos)
        Me.NuevaContratacion.Controls.Add(Me.lblNuevaContratacionNombre)
        Me.NuevaContratacion.Controls.Add(Me.lblNuevaContratacionInfoCliente)
        Me.NuevaContratacion.Controls.Add(Me.txtNuevaContratacionNombre)
        Me.NuevaContratacion.Controls.Add(Me.lblNuevaContratacion)
        Me.NuevaContratacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NuevaContratacion.Location = New System.Drawing.Point(0, 0)
        Me.NuevaContratacion.Margin = New System.Windows.Forms.Padding(4)
        Me.NuevaContratacion.Name = "NuevaContratacion"
        Me.NuevaContratacion.Size = New System.Drawing.Size(773, 422)
        Me.NuevaContratacion.TabIndex = 7
        '
        'CBNuevaContratacionTrabajador
        '
        Me.CBNuevaContratacionTrabajador.FormattingEnabled = True
        Me.CBNuevaContratacionTrabajador.IntegralHeight = False
        Me.CBNuevaContratacionTrabajador.Items.AddRange(New Object() {"Garmine", "Chandler", "Zenaida", "Randall", "Naomi", "Timon", "Tamekah", "Imelda", "Brittany"})
        Me.CBNuevaContratacionTrabajador.Location = New System.Drawing.Point(582, 308)
        Me.CBNuevaContratacionTrabajador.Name = "CBNuevaContratacionTrabajador"
        Me.CBNuevaContratacionTrabajador.Size = New System.Drawing.Size(128, 24)
        Me.CBNuevaContratacionTrabajador.TabIndex = 48
        '
        'lblNuevaContratacionTrabajador
        '
        Me.lblNuevaContratacionTrabajador.AutoSize = True
        Me.lblNuevaContratacionTrabajador.Location = New System.Drawing.Point(449, 312)
        Me.lblNuevaContratacionTrabajador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevaContratacionTrabajador.Name = "lblNuevaContratacionTrabajador"
        Me.lblNuevaContratacionTrabajador.Size = New System.Drawing.Size(78, 17)
        Me.lblNuevaContratacionTrabajador.TabIndex = 47
        Me.lblNuevaContratacionTrabajador.Text = "Trabajador"
        Me.lblNuevaContratacionTrabajador.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DateTimePickerNuevaContratacion
        '
        Me.DateTimePickerNuevaContratacion.Location = New System.Drawing.Point(180, 309)
        Me.DateTimePickerNuevaContratacion.Name = "DateTimePickerNuevaContratacion"
        Me.DateTimePickerNuevaContratacion.Size = New System.Drawing.Size(258, 22)
        Me.DateTimePickerNuevaContratacion.TabIndex = 46
        '
        'btnNuevaContratacionAceptar
        '
        Me.btnNuevaContratacionAceptar.Location = New System.Drawing.Point(591, 353)
        Me.btnNuevaContratacionAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevaContratacionAceptar.Name = "btnNuevaContratacionAceptar"
        Me.btnNuevaContratacionAceptar.Size = New System.Drawing.Size(135, 37)
        Me.btnNuevaContratacionAceptar.TabIndex = 45
        Me.btnNuevaContratacionAceptar.Text = "Aceptar"
        Me.btnNuevaContratacionAceptar.UseVisualStyleBackColor = True
        '
        'btnNuevaContratacionCancelar
        '
        Me.btnNuevaContratacionCancelar.Location = New System.Drawing.Point(55, 353)
        Me.btnNuevaContratacionCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevaContratacionCancelar.Name = "btnNuevaContratacionCancelar"
        Me.btnNuevaContratacionCancelar.Size = New System.Drawing.Size(135, 37)
        Me.btnNuevaContratacionCancelar.TabIndex = 44
        Me.btnNuevaContratacionCancelar.Text = "Cancelar"
        Me.btnNuevaContratacionCancelar.UseVisualStyleBackColor = True
        '
        'lblNuevaContratacionFechaContratacion
        '
        Me.lblNuevaContratacionFechaContratacion.AutoSize = True
        Me.lblNuevaContratacionFechaContratacion.Location = New System.Drawing.Point(42, 310)
        Me.lblNuevaContratacionFechaContratacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevaContratacionFechaContratacion.Name = "lblNuevaContratacionFechaContratacion"
        Me.lblNuevaContratacionFechaContratacion.Size = New System.Drawing.Size(131, 17)
        Me.lblNuevaContratacionFechaContratacion.TabIndex = 42
        Me.lblNuevaContratacionFechaContratacion.Text = "Fecha Contratación"
        Me.lblNuevaContratacionFechaContratacion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNuevaContratacionCoste
        '
        Me.txtNuevaContratacionCoste.Location = New System.Drawing.Point(582, 265)
        Me.txtNuevaContratacionCoste.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNuevaContratacionCoste.Name = "txtNuevaContratacionCoste"
        Me.txtNuevaContratacionCoste.Size = New System.Drawing.Size(132, 22)
        Me.txtNuevaContratacionCoste.TabIndex = 41
        '
        'lblNuevaContratacionCoste
        '
        Me.lblNuevaContratacionCoste.AutoSize = True
        Me.lblNuevaContratacionCoste.Location = New System.Drawing.Point(449, 266)
        Me.lblNuevaContratacionCoste.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevaContratacionCoste.Name = "lblNuevaContratacionCoste"
        Me.lblNuevaContratacionCoste.Size = New System.Drawing.Size(44, 17)
        Me.lblNuevaContratacionCoste.TabIndex = 40
        Me.lblNuevaContratacionCoste.Text = "Coste"
        Me.lblNuevaContratacionCoste.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNuevaContratacionTipoServicio
        '
        Me.txtNuevaContratacionTipoServicio.Location = New System.Drawing.Point(582, 223)
        Me.txtNuevaContratacionTipoServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNuevaContratacionTipoServicio.Name = "txtNuevaContratacionTipoServicio"
        Me.txtNuevaContratacionTipoServicio.Size = New System.Drawing.Size(132, 22)
        Me.txtNuevaContratacionTipoServicio.TabIndex = 39
        '
        'lblNuevaContratacionTipoServicio
        '
        Me.lblNuevaContratacionTipoServicio.AutoSize = True
        Me.lblNuevaContratacionTipoServicio.Location = New System.Drawing.Point(449, 223)
        Me.lblNuevaContratacionTipoServicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevaContratacionTipoServicio.Name = "lblNuevaContratacionTipoServicio"
        Me.lblNuevaContratacionTipoServicio.Size = New System.Drawing.Size(110, 17)
        Me.lblNuevaContratacionTipoServicio.TabIndex = 38
        Me.lblNuevaContratacionTipoServicio.Text = "Tipo de Servicio"
        Me.lblNuevaContratacionTipoServicio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNuevaContratacionEmail
        '
        Me.txtNuevaContratacionEmail.Location = New System.Drawing.Point(582, 181)
        Me.txtNuevaContratacionEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNuevaContratacionEmail.Name = "txtNuevaContratacionEmail"
        Me.txtNuevaContratacionEmail.Size = New System.Drawing.Size(132, 22)
        Me.txtNuevaContratacionEmail.TabIndex = 37
        '
        'lblNuevaContratacionEmail
        '
        Me.lblNuevaContratacionEmail.AutoSize = True
        Me.lblNuevaContratacionEmail.Location = New System.Drawing.Point(447, 180)
        Me.lblNuevaContratacionEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevaContratacionEmail.Name = "lblNuevaContratacionEmail"
        Me.lblNuevaContratacionEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblNuevaContratacionEmail.TabIndex = 36
        Me.lblNuevaContratacionEmail.Text = "Email"
        Me.lblNuevaContratacionEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtNuevaContratacionTelefono
        '
        Me.txtNuevaContratacionTelefono.Location = New System.Drawing.Point(582, 140)
        Me.txtNuevaContratacionTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNuevaContratacionTelefono.Name = "txtNuevaContratacionTelefono"
        Me.txtNuevaContratacionTelefono.Size = New System.Drawing.Size(132, 22)
        Me.txtNuevaContratacionTelefono.TabIndex = 35
        '
        'lblNuevaContratacionTelefono
        '
        Me.lblNuevaContratacionTelefono.AutoSize = True
        Me.lblNuevaContratacionTelefono.Location = New System.Drawing.Point(449, 142)
        Me.lblNuevaContratacionTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevaContratacionTelefono.Name = "lblNuevaContratacionTelefono"
        Me.lblNuevaContratacionTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblNuevaContratacionTelefono.TabIndex = 34
        Me.lblNuevaContratacionTelefono.Text = "Teléfono"
        Me.lblNuevaContratacionTelefono.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtNuevaContratacionDireccion
        '
        Me.txtNuevaContratacionDireccion.Location = New System.Drawing.Point(123, 264)
        Me.txtNuevaContratacionDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNuevaContratacionDireccion.Name = "txtNuevaContratacionDireccion"
        Me.txtNuevaContratacionDireccion.Size = New System.Drawing.Size(132, 22)
        Me.txtNuevaContratacionDireccion.TabIndex = 33
        '
        'lblNuevaContratacionDireccion
        '
        Me.lblNuevaContratacionDireccion.AutoSize = True
        Me.lblNuevaContratacionDireccion.Location = New System.Drawing.Point(42, 267)
        Me.lblNuevaContratacionDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevaContratacionDireccion.Name = "lblNuevaContratacionDireccion"
        Me.lblNuevaContratacionDireccion.Size = New System.Drawing.Size(67, 17)
        Me.lblNuevaContratacionDireccion.TabIndex = 32
        Me.lblNuevaContratacionDireccion.Text = "Dirección"
        Me.lblNuevaContratacionDireccion.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtNuevaContratacionDNI
        '
        Me.txtNuevaContratacionDNI.Location = New System.Drawing.Point(123, 224)
        Me.txtNuevaContratacionDNI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNuevaContratacionDNI.Name = "txtNuevaContratacionDNI"
        Me.txtNuevaContratacionDNI.Size = New System.Drawing.Size(132, 22)
        Me.txtNuevaContratacionDNI.TabIndex = 31
        '
        'lblNuevaContratacionDNI
        '
        Me.lblNuevaContratacionDNI.AutoSize = True
        Me.lblNuevaContratacionDNI.Location = New System.Drawing.Point(42, 226)
        Me.lblNuevaContratacionDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevaContratacionDNI.Name = "lblNuevaContratacionDNI"
        Me.lblNuevaContratacionDNI.Size = New System.Drawing.Size(31, 17)
        Me.lblNuevaContratacionDNI.TabIndex = 30
        Me.lblNuevaContratacionDNI.Text = "DNI"
        Me.lblNuevaContratacionDNI.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtNuevaContratacionApellidos
        '
        Me.txtNuevaContratacionApellidos.Location = New System.Drawing.Point(123, 182)
        Me.txtNuevaContratacionApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNuevaContratacionApellidos.Name = "txtNuevaContratacionApellidos"
        Me.txtNuevaContratacionApellidos.Size = New System.Drawing.Size(132, 22)
        Me.txtNuevaContratacionApellidos.TabIndex = 29
        '
        'lblNuevaContratacionApellidos
        '
        Me.lblNuevaContratacionApellidos.AutoSize = True
        Me.lblNuevaContratacionApellidos.Location = New System.Drawing.Point(40, 186)
        Me.lblNuevaContratacionApellidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevaContratacionApellidos.Name = "lblNuevaContratacionApellidos"
        Me.lblNuevaContratacionApellidos.Size = New System.Drawing.Size(65, 17)
        Me.lblNuevaContratacionApellidos.TabIndex = 28
        Me.lblNuevaContratacionApellidos.Text = "Apellidos"
        Me.lblNuevaContratacionApellidos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblNuevaContratacionNombre
        '
        Me.lblNuevaContratacionNombre.AutoSize = True
        Me.lblNuevaContratacionNombre.Location = New System.Drawing.Point(40, 146)
        Me.lblNuevaContratacionNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevaContratacionNombre.Name = "lblNuevaContratacionNombre"
        Me.lblNuevaContratacionNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNuevaContratacionNombre.TabIndex = 27
        Me.lblNuevaContratacionNombre.Text = "Nombre"
        '
        'lblNuevaContratacionInfoCliente
        '
        Me.lblNuevaContratacionInfoCliente.AutoSize = True
        Me.lblNuevaContratacionInfoCliente.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevaContratacionInfoCliente.Location = New System.Drawing.Point(269, 97)
        Me.lblNuevaContratacionInfoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevaContratacionInfoCliente.Name = "lblNuevaContratacionInfoCliente"
        Me.lblNuevaContratacionInfoCliente.Size = New System.Drawing.Size(230, 27)
        Me.lblNuevaContratacionInfoCliente.TabIndex = 26
        Me.lblNuevaContratacionInfoCliente.Text = "Información del cliente"
        '
        'txtNuevaContratacionNombre
        '
        Me.txtNuevaContratacionNombre.Location = New System.Drawing.Point(123, 141)
        Me.txtNuevaContratacionNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNuevaContratacionNombre.Name = "txtNuevaContratacionNombre"
        Me.txtNuevaContratacionNombre.Size = New System.Drawing.Size(132, 22)
        Me.txtNuevaContratacionNombre.TabIndex = 25
        '
        'lblNuevaContratacion
        '
        Me.lblNuevaContratacion.AutoSize = True
        Me.lblNuevaContratacion.Font = New System.Drawing.Font("Microsoft YaHei", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevaContratacion.Location = New System.Drawing.Point(209, 38)
        Me.lblNuevaContratacion.Name = "lblNuevaContratacion"
        Me.lblNuevaContratacion.Size = New System.Drawing.Size(333, 43)
        Me.lblNuevaContratacion.TabIndex = 1
        Me.lblNuevaContratacion.Text = "Nueva Contratación"
        '
        'ContratacionesEnCurso
        '
        Me.ContratacionesEnCurso.Controls.Add(Me.txtConsultaContratacionesFecha)
        Me.ContratacionesEnCurso.Controls.Add(Me.lblConsultaContratacionesFecha)
        Me.ContratacionesEnCurso.Controls.Add(Me.btnConsultaContratacionesAtras)
        Me.ContratacionesEnCurso.Controls.Add(Me.btnConsultaContratacionesBusqueda)
        Me.ContratacionesEnCurso.Controls.Add(Me.txtConsultaContratacionesCoste)
        Me.ContratacionesEnCurso.Controls.Add(Me.lblConsultaContratacionesCoste)
        Me.ContratacionesEnCurso.Controls.Add(Me.txtConsultaContratacionesTipoServicio)
        Me.ContratacionesEnCurso.Controls.Add(Me.lblConsultaContratacionesTipoServicio)
        Me.ContratacionesEnCurso.Controls.Add(Me.txtConsultaContratacionesEmail)
        Me.ContratacionesEnCurso.Controls.Add(Me.lblConsultaContratacionesEmail)
        Me.ContratacionesEnCurso.Controls.Add(Me.txtConsultaContratacionesTelefono)
        Me.ContratacionesEnCurso.Controls.Add(Me.lblConsultaContratacionesTelefono)
        Me.ContratacionesEnCurso.Controls.Add(Me.txtConsultaContratacionesDireccion)
        Me.ContratacionesEnCurso.Controls.Add(Me.lblConsultaContratacionesDireccion)
        Me.ContratacionesEnCurso.Controls.Add(Me.txtConsultaContratacionesDNI)
        Me.ContratacionesEnCurso.Controls.Add(Me.lblConsultaContratacionesDNI)
        Me.ContratacionesEnCurso.Controls.Add(Me.txtConsultaContratacionesApellidos)
        Me.ContratacionesEnCurso.Controls.Add(Me.lblConsultaContratacionesApellidos)
        Me.ContratacionesEnCurso.Controls.Add(Me.lblConsultaContratacionesNombre)
        Me.ContratacionesEnCurso.Controls.Add(Me.Label11)
        Me.ContratacionesEnCurso.Controls.Add(Me.txtConsultaContratacionesNombre)
        Me.ContratacionesEnCurso.Controls.Add(Me.lblConsultaContratacionesBusqueda)
        Me.ContratacionesEnCurso.Controls.Add(Me.txtConsultaContratacionesBusqueda)
        Me.ContratacionesEnCurso.Controls.Add(Me.lblConsultaContrataciones)
        Me.ContratacionesEnCurso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContratacionesEnCurso.Location = New System.Drawing.Point(0, 0)
        Me.ContratacionesEnCurso.Margin = New System.Windows.Forms.Padding(4)
        Me.ContratacionesEnCurso.Name = "ContratacionesEnCurso"
        Me.ContratacionesEnCurso.Size = New System.Drawing.Size(773, 422)
        Me.ContratacionesEnCurso.TabIndex = 8
        '
        'txtConsultaContratacionesFecha
        '
        Me.txtConsultaContratacionesFecha.Location = New System.Drawing.Point(512, 353)
        Me.txtConsultaContratacionesFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConsultaContratacionesFecha.Name = "txtConsultaContratacionesFecha"
        Me.txtConsultaContratacionesFecha.Size = New System.Drawing.Size(132, 22)
        Me.txtConsultaContratacionesFecha.TabIndex = 47
        '
        'lblConsultaContratacionesFecha
        '
        Me.lblConsultaContratacionesFecha.AutoSize = True
        Me.lblConsultaContratacionesFecha.Location = New System.Drawing.Point(379, 354)
        Me.lblConsultaContratacionesFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsultaContratacionesFecha.Name = "lblConsultaContratacionesFecha"
        Me.lblConsultaContratacionesFecha.Size = New System.Drawing.Size(83, 17)
        Me.lblConsultaContratacionesFecha.TabIndex = 46
        Me.lblConsultaContratacionesFecha.Text = "Fecha Inicio"
        Me.lblConsultaContratacionesFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnConsultaContratacionesAtras
        '
        Me.btnConsultaContratacionesAtras.Location = New System.Drawing.Point(81, 358)
        Me.btnConsultaContratacionesAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultaContratacionesAtras.Name = "btnConsultaContratacionesAtras"
        Me.btnConsultaContratacionesAtras.Size = New System.Drawing.Size(136, 39)
        Me.btnConsultaContratacionesAtras.TabIndex = 45
        Me.btnConsultaContratacionesAtras.Text = "Atrás"
        Me.btnConsultaContratacionesAtras.UseVisualStyleBackColor = True
        '
        'btnConsultaContratacionesBusqueda
        '
        Me.btnConsultaContratacionesBusqueda.Location = New System.Drawing.Point(516, 86)
        Me.btnConsultaContratacionesBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultaContratacionesBusqueda.Name = "btnConsultaContratacionesBusqueda"
        Me.btnConsultaContratacionesBusqueda.Size = New System.Drawing.Size(136, 39)
        Me.btnConsultaContratacionesBusqueda.TabIndex = 44
        Me.btnConsultaContratacionesBusqueda.Text = "Buscar"
        Me.btnConsultaContratacionesBusqueda.UseVisualStyleBackColor = True
        '
        'txtConsultaContratacionesCoste
        '
        Me.txtConsultaContratacionesCoste.Location = New System.Drawing.Point(512, 318)
        Me.txtConsultaContratacionesCoste.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConsultaContratacionesCoste.Name = "txtConsultaContratacionesCoste"
        Me.txtConsultaContratacionesCoste.Size = New System.Drawing.Size(132, 22)
        Me.txtConsultaContratacionesCoste.TabIndex = 43
        '
        'lblConsultaContratacionesCoste
        '
        Me.lblConsultaContratacionesCoste.AutoSize = True
        Me.lblConsultaContratacionesCoste.Location = New System.Drawing.Point(379, 319)
        Me.lblConsultaContratacionesCoste.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsultaContratacionesCoste.Name = "lblConsultaContratacionesCoste"
        Me.lblConsultaContratacionesCoste.Size = New System.Drawing.Size(128, 17)
        Me.lblConsultaContratacionesCoste.TabIndex = 42
        Me.lblConsultaContratacionesCoste.Text = "Coste Presupuesto"
        Me.lblConsultaContratacionesCoste.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtConsultaContratacionesTipoServicio
        '
        Me.txtConsultaContratacionesTipoServicio.Location = New System.Drawing.Point(512, 276)
        Me.txtConsultaContratacionesTipoServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConsultaContratacionesTipoServicio.Name = "txtConsultaContratacionesTipoServicio"
        Me.txtConsultaContratacionesTipoServicio.Size = New System.Drawing.Size(132, 22)
        Me.txtConsultaContratacionesTipoServicio.TabIndex = 41
        '
        'lblConsultaContratacionesTipoServicio
        '
        Me.lblConsultaContratacionesTipoServicio.AutoSize = True
        Me.lblConsultaContratacionesTipoServicio.Location = New System.Drawing.Point(379, 276)
        Me.lblConsultaContratacionesTipoServicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsultaContratacionesTipoServicio.Name = "lblConsultaContratacionesTipoServicio"
        Me.lblConsultaContratacionesTipoServicio.Size = New System.Drawing.Size(110, 17)
        Me.lblConsultaContratacionesTipoServicio.TabIndex = 40
        Me.lblConsultaContratacionesTipoServicio.Text = "Tipo de Servicio"
        Me.lblConsultaContratacionesTipoServicio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtConsultaContratacionesEmail
        '
        Me.txtConsultaContratacionesEmail.Location = New System.Drawing.Point(512, 234)
        Me.txtConsultaContratacionesEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConsultaContratacionesEmail.Name = "txtConsultaContratacionesEmail"
        Me.txtConsultaContratacionesEmail.Size = New System.Drawing.Size(132, 22)
        Me.txtConsultaContratacionesEmail.TabIndex = 39
        '
        'lblConsultaContratacionesEmail
        '
        Me.lblConsultaContratacionesEmail.AutoSize = True
        Me.lblConsultaContratacionesEmail.Location = New System.Drawing.Point(377, 233)
        Me.lblConsultaContratacionesEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsultaContratacionesEmail.Name = "lblConsultaContratacionesEmail"
        Me.lblConsultaContratacionesEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblConsultaContratacionesEmail.TabIndex = 38
        Me.lblConsultaContratacionesEmail.Text = "Email"
        Me.lblConsultaContratacionesEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtConsultaContratacionesTelefono
        '
        Me.txtConsultaContratacionesTelefono.Location = New System.Drawing.Point(512, 193)
        Me.txtConsultaContratacionesTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConsultaContratacionesTelefono.Name = "txtConsultaContratacionesTelefono"
        Me.txtConsultaContratacionesTelefono.Size = New System.Drawing.Size(132, 22)
        Me.txtConsultaContratacionesTelefono.TabIndex = 37
        '
        'lblConsultaContratacionesTelefono
        '
        Me.lblConsultaContratacionesTelefono.AutoSize = True
        Me.lblConsultaContratacionesTelefono.Location = New System.Drawing.Point(379, 194)
        Me.lblConsultaContratacionesTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsultaContratacionesTelefono.Name = "lblConsultaContratacionesTelefono"
        Me.lblConsultaContratacionesTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblConsultaContratacionesTelefono.TabIndex = 36
        Me.lblConsultaContratacionesTelefono.Text = "Teléfono"
        Me.lblConsultaContratacionesTelefono.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtConsultaContratacionesDireccion
        '
        Me.txtConsultaContratacionesDireccion.Location = New System.Drawing.Point(188, 315)
        Me.txtConsultaContratacionesDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConsultaContratacionesDireccion.Name = "txtConsultaContratacionesDireccion"
        Me.txtConsultaContratacionesDireccion.Size = New System.Drawing.Size(132, 22)
        Me.txtConsultaContratacionesDireccion.TabIndex = 35
        '
        'lblConsultaContratacionesDireccion
        '
        Me.lblConsultaContratacionesDireccion.AutoSize = True
        Me.lblConsultaContratacionesDireccion.Location = New System.Drawing.Point(107, 318)
        Me.lblConsultaContratacionesDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsultaContratacionesDireccion.Name = "lblConsultaContratacionesDireccion"
        Me.lblConsultaContratacionesDireccion.Size = New System.Drawing.Size(67, 17)
        Me.lblConsultaContratacionesDireccion.TabIndex = 34
        Me.lblConsultaContratacionesDireccion.Text = "Dirección"
        Me.lblConsultaContratacionesDireccion.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtConsultaContratacionesDNI
        '
        Me.txtConsultaContratacionesDNI.Location = New System.Drawing.Point(188, 274)
        Me.txtConsultaContratacionesDNI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConsultaContratacionesDNI.Name = "txtConsultaContratacionesDNI"
        Me.txtConsultaContratacionesDNI.Size = New System.Drawing.Size(132, 22)
        Me.txtConsultaContratacionesDNI.TabIndex = 33
        '
        'lblConsultaContratacionesDNI
        '
        Me.lblConsultaContratacionesDNI.AutoSize = True
        Me.lblConsultaContratacionesDNI.Location = New System.Drawing.Point(107, 277)
        Me.lblConsultaContratacionesDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsultaContratacionesDNI.Name = "lblConsultaContratacionesDNI"
        Me.lblConsultaContratacionesDNI.Size = New System.Drawing.Size(31, 17)
        Me.lblConsultaContratacionesDNI.TabIndex = 32
        Me.lblConsultaContratacionesDNI.Text = "DNI"
        Me.lblConsultaContratacionesDNI.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtConsultaContratacionesApellidos
        '
        Me.txtConsultaContratacionesApellidos.Location = New System.Drawing.Point(188, 233)
        Me.txtConsultaContratacionesApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConsultaContratacionesApellidos.Name = "txtConsultaContratacionesApellidos"
        Me.txtConsultaContratacionesApellidos.Size = New System.Drawing.Size(132, 22)
        Me.txtConsultaContratacionesApellidos.TabIndex = 31
        '
        'lblConsultaContratacionesApellidos
        '
        Me.lblConsultaContratacionesApellidos.AutoSize = True
        Me.lblConsultaContratacionesApellidos.Location = New System.Drawing.Point(105, 236)
        Me.lblConsultaContratacionesApellidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsultaContratacionesApellidos.Name = "lblConsultaContratacionesApellidos"
        Me.lblConsultaContratacionesApellidos.Size = New System.Drawing.Size(65, 17)
        Me.lblConsultaContratacionesApellidos.TabIndex = 30
        Me.lblConsultaContratacionesApellidos.Text = "Apellidos"
        Me.lblConsultaContratacionesApellidos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblConsultaContratacionesNombre
        '
        Me.lblConsultaContratacionesNombre.AutoSize = True
        Me.lblConsultaContratacionesNombre.Location = New System.Drawing.Point(105, 197)
        Me.lblConsultaContratacionesNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsultaContratacionesNombre.Name = "lblConsultaContratacionesNombre"
        Me.lblConsultaContratacionesNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblConsultaContratacionesNombre.TabIndex = 29
        Me.lblConsultaContratacionesNombre.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(324, 145)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 27)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Información"
        '
        'txtConsultaContratacionesNombre
        '
        Me.txtConsultaContratacionesNombre.Location = New System.Drawing.Point(188, 192)
        Me.txtConsultaContratacionesNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConsultaContratacionesNombre.Name = "txtConsultaContratacionesNombre"
        Me.txtConsultaContratacionesNombre.Size = New System.Drawing.Size(132, 22)
        Me.txtConsultaContratacionesNombre.TabIndex = 27
        '
        'lblConsultaContratacionesBusqueda
        '
        Me.lblConsultaContratacionesBusqueda.AutoSize = True
        Me.lblConsultaContratacionesBusqueda.Location = New System.Drawing.Point(132, 101)
        Me.lblConsultaContratacionesBusqueda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsultaContratacionesBusqueda.Name = "lblConsultaContratacionesBusqueda"
        Me.lblConsultaContratacionesBusqueda.Size = New System.Drawing.Size(186, 17)
        Me.lblConsultaContratacionesBusqueda.TabIndex = 26
        Me.lblConsultaContratacionesBusqueda.Text = "Introduzca el DNI del Cliente"
        '
        'txtConsultaContratacionesBusqueda
        '
        Me.txtConsultaContratacionesBusqueda.Location = New System.Drawing.Point(343, 97)
        Me.txtConsultaContratacionesBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConsultaContratacionesBusqueda.Name = "txtConsultaContratacionesBusqueda"
        Me.txtConsultaContratacionesBusqueda.Size = New System.Drawing.Size(132, 22)
        Me.txtConsultaContratacionesBusqueda.TabIndex = 25
        '
        'lblConsultaContrataciones
        '
        Me.lblConsultaContrataciones.AutoSize = True
        Me.lblConsultaContrataciones.Font = New System.Drawing.Font("Microsoft YaHei", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaContrataciones.Location = New System.Drawing.Point(76, 26)
        Me.lblConsultaContrataciones.Name = "lblConsultaContrataciones"
        Me.lblConsultaContrataciones.Size = New System.Drawing.Size(594, 57)
        Me.lblConsultaContrataciones.TabIndex = 2
        Me.lblConsultaContrataciones.Text = "Consulta de Contrataciones"
        '
        'CancelarContratacion
        '
        Me.CancelarContratacion.Controls.Add(Me.DateTimeCancelarContratacionFecha)
        Me.CancelarContratacion.Controls.Add(Me.lblCancelarContratacionFecha)
        Me.CancelarContratacion.Controls.Add(Me.btnCancelarContratacionAceptar)
        Me.CancelarContratacion.Controls.Add(Me.btnCancelarContratacionCancelar)
        Me.CancelarContratacion.Controls.Add(Me.lblCancelarContratacionRazon)
        Me.CancelarContratacion.Controls.Add(Me.txtCancelarContratacionRazon)
        Me.CancelarContratacion.Controls.Add(Me.lblCancelarContratacionDNI)
        Me.CancelarContratacion.Controls.Add(Me.txtCancelarContratacionDNI)
        Me.CancelarContratacion.Controls.Add(Me.lblCancelarContratacion)
        Me.CancelarContratacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelarContratacion.Location = New System.Drawing.Point(0, 0)
        Me.CancelarContratacion.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelarContratacion.Name = "CancelarContratacion"
        Me.CancelarContratacion.Size = New System.Drawing.Size(773, 422)
        Me.CancelarContratacion.TabIndex = 7
        '
        'DateTimeCancelarContratacionFecha
        '
        Me.DateTimeCancelarContratacionFecha.Location = New System.Drawing.Point(329, 182)
        Me.DateTimeCancelarContratacionFecha.Name = "DateTimeCancelarContratacionFecha"
        Me.DateTimeCancelarContratacionFecha.Size = New System.Drawing.Size(283, 22)
        Me.DateTimeCancelarContratacionFecha.TabIndex = 37
        '
        'lblCancelarContratacionFecha
        '
        Me.lblCancelarContratacionFecha.AutoSize = True
        Me.lblCancelarContratacionFecha.Location = New System.Drawing.Point(223, 184)
        Me.lblCancelarContratacionFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCancelarContratacionFecha.Name = "lblCancelarContratacionFecha"
        Me.lblCancelarContratacionFecha.Size = New System.Drawing.Size(83, 17)
        Me.lblCancelarContratacionFecha.TabIndex = 36
        Me.lblCancelarContratacionFecha.Text = "Fecha Inicio"
        '
        'btnCancelarContratacionAceptar
        '
        Me.btnCancelarContratacionAceptar.Location = New System.Drawing.Point(592, 337)
        Me.btnCancelarContratacionAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelarContratacionAceptar.Name = "btnCancelarContratacionAceptar"
        Me.btnCancelarContratacionAceptar.Size = New System.Drawing.Size(123, 41)
        Me.btnCancelarContratacionAceptar.TabIndex = 34
        Me.btnCancelarContratacionAceptar.Text = "Aceptar"
        Me.btnCancelarContratacionAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelarContratacionCancelar
        '
        Me.btnCancelarContratacionCancelar.Location = New System.Drawing.Point(91, 341)
        Me.btnCancelarContratacionCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelarContratacionCancelar.Name = "btnCancelarContratacionCancelar"
        Me.btnCancelarContratacionCancelar.Size = New System.Drawing.Size(123, 41)
        Me.btnCancelarContratacionCancelar.TabIndex = 33
        Me.btnCancelarContratacionCancelar.Text = "Cancelar"
        Me.btnCancelarContratacionCancelar.UseVisualStyleBackColor = True
        '
        'lblCancelarContratacionRazon
        '
        Me.lblCancelarContratacionRazon.AutoSize = True
        Me.lblCancelarContratacionRazon.Location = New System.Drawing.Point(223, 243)
        Me.lblCancelarContratacionRazon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCancelarContratacionRazon.Name = "lblCancelarContratacionRazon"
        Me.lblCancelarContratacionRazon.Size = New System.Drawing.Size(49, 17)
        Me.lblCancelarContratacionRazon.TabIndex = 29
        Me.lblCancelarContratacionRazon.Text = "Razón"
        '
        'txtCancelarContratacionRazon
        '
        Me.txtCancelarContratacionRazon.Location = New System.Drawing.Point(288, 239)
        Me.txtCancelarContratacionRazon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCancelarContratacionRazon.Multiline = True
        Me.txtCancelarContratacionRazon.Name = "txtCancelarContratacionRazon"
        Me.txtCancelarContratacionRazon.Size = New System.Drawing.Size(273, 63)
        Me.txtCancelarContratacionRazon.TabIndex = 28
        '
        'lblCancelarContratacionDNI
        '
        Me.lblCancelarContratacionDNI.AutoSize = True
        Me.lblCancelarContratacionDNI.Location = New System.Drawing.Point(223, 124)
        Me.lblCancelarContratacionDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCancelarContratacionDNI.Name = "lblCancelarContratacionDNI"
        Me.lblCancelarContratacionDNI.Size = New System.Drawing.Size(186, 17)
        Me.lblCancelarContratacionDNI.TabIndex = 27
        Me.lblCancelarContratacionDNI.Text = "Introduzca el DNI del Cliente"
        '
        'txtCancelarContratacionDNI
        '
        Me.txtCancelarContratacionDNI.Location = New System.Drawing.Point(429, 118)
        Me.txtCancelarContratacionDNI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCancelarContratacionDNI.Name = "txtCancelarContratacionDNI"
        Me.txtCancelarContratacionDNI.Size = New System.Drawing.Size(132, 22)
        Me.txtCancelarContratacionDNI.TabIndex = 26
        '
        'lblCancelarContratacion
        '
        Me.lblCancelarContratacion.AutoSize = True
        Me.lblCancelarContratacion.Font = New System.Drawing.Font("Microsoft YaHei", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelarContratacion.Location = New System.Drawing.Point(183, 39)
        Me.lblCancelarContratacion.Name = "lblCancelarContratacion"
        Me.lblCancelarContratacion.Size = New System.Drawing.Size(368, 43)
        Me.lblCancelarContratacion.TabIndex = 1
        Me.lblCancelarContratacion.Text = "Cancelar Contratación"
        '
        'MenuFabrica
        '
        Me.MenuFabrica.Controls.Add(Me.btnMenuFabricaAtras)
        Me.MenuFabrica.Controls.Add(Me.btnMenuFabricaSalir)
        Me.MenuFabrica.Controls.Add(Me.lblMenuFabricaEmail)
        Me.MenuFabrica.Controls.Add(Me.txtMenuFabricaEmail)
        Me.MenuFabrica.Controls.Add(Me.lblMenuFabricaTelefono)
        Me.MenuFabrica.Controls.Add(Me.txtMenuFabricaTelefono)
        Me.MenuFabrica.Controls.Add(Me.lblMenuFabricaDireccion)
        Me.MenuFabrica.Controls.Add(Me.txtMenuFabricaDireccion)
        Me.MenuFabrica.Controls.Add(Me.lblMenuFabricaProduccion)
        Me.MenuFabrica.Controls.Add(Me.txtMenuFabricaProduccion)
        Me.MenuFabrica.Controls.Add(Me.lblMenuFabricaMaterial)
        Me.MenuFabrica.Controls.Add(Me.txtMenuFabricaMaterial)
        Me.MenuFabrica.Controls.Add(Me.lblMenuFabricaEncargado)
        Me.MenuFabrica.Controls.Add(Me.txtMenuFabricaEncargado)
        Me.MenuFabrica.Controls.Add(Me.Label1)
        Me.MenuFabrica.Controls.Add(Me.lblMenuFabricaTitulo)
        Me.MenuFabrica.Controls.Add(Me.lblMenuFabricaCIF)
        Me.MenuFabrica.Controls.Add(Me.txtMenuFabricaCIF)
        Me.MenuFabrica.Controls.Add(Me.btnMenuFabricaCIF)
        Me.MenuFabrica.Controls.Add(Me.lblMenuFabrica)
        Me.MenuFabrica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuFabrica.Location = New System.Drawing.Point(0, 0)
        Me.MenuFabrica.Margin = New System.Windows.Forms.Padding(4)
        Me.MenuFabrica.Name = "MenuFabrica"
        Me.MenuFabrica.Size = New System.Drawing.Size(773, 422)
        Me.MenuFabrica.TabIndex = 7
        '
        'btnMenuFabricaAtras
        '
        Me.btnMenuFabricaAtras.Location = New System.Drawing.Point(59, 371)
        Me.btnMenuFabricaAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMenuFabricaAtras.Name = "btnMenuFabricaAtras"
        Me.btnMenuFabricaAtras.Size = New System.Drawing.Size(111, 32)
        Me.btnMenuFabricaAtras.TabIndex = 20
        Me.btnMenuFabricaAtras.Text = "Atras"
        Me.btnMenuFabricaAtras.UseVisualStyleBackColor = True
        '
        'btnMenuFabricaSalir
        '
        Me.btnMenuFabricaSalir.Location = New System.Drawing.Point(592, 371)
        Me.btnMenuFabricaSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMenuFabricaSalir.Name = "btnMenuFabricaSalir"
        Me.btnMenuFabricaSalir.Size = New System.Drawing.Size(111, 32)
        Me.btnMenuFabricaSalir.TabIndex = 19
        Me.btnMenuFabricaSalir.Text = "Salir"
        Me.btnMenuFabricaSalir.UseVisualStyleBackColor = True
        '
        'lblMenuFabricaEmail
        '
        Me.lblMenuFabricaEmail.AutoSize = True
        Me.lblMenuFabricaEmail.Location = New System.Drawing.Point(412, 321)
        Me.lblMenuFabricaEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenuFabricaEmail.Name = "lblMenuFabricaEmail"
        Me.lblMenuFabricaEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblMenuFabricaEmail.TabIndex = 18
        Me.lblMenuFabricaEmail.Text = "Email"
        '
        'txtMenuFabricaEmail
        '
        Me.txtMenuFabricaEmail.Location = New System.Drawing.Point(495, 315)
        Me.txtMenuFabricaEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMenuFabricaEmail.Name = "txtMenuFabricaEmail"
        Me.txtMenuFabricaEmail.Size = New System.Drawing.Size(132, 22)
        Me.txtMenuFabricaEmail.TabIndex = 17
        '
        'lblMenuFabricaTelefono
        '
        Me.lblMenuFabricaTelefono.AutoSize = True
        Me.lblMenuFabricaTelefono.Location = New System.Drawing.Point(412, 274)
        Me.lblMenuFabricaTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenuFabricaTelefono.Name = "lblMenuFabricaTelefono"
        Me.lblMenuFabricaTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblMenuFabricaTelefono.TabIndex = 16
        Me.lblMenuFabricaTelefono.Text = "Teléfono"
        '
        'txtMenuFabricaTelefono
        '
        Me.txtMenuFabricaTelefono.Location = New System.Drawing.Point(495, 268)
        Me.txtMenuFabricaTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMenuFabricaTelefono.Name = "txtMenuFabricaTelefono"
        Me.txtMenuFabricaTelefono.Size = New System.Drawing.Size(132, 22)
        Me.txtMenuFabricaTelefono.TabIndex = 15
        '
        'lblMenuFabricaDireccion
        '
        Me.lblMenuFabricaDireccion.AutoSize = True
        Me.lblMenuFabricaDireccion.Location = New System.Drawing.Point(412, 233)
        Me.lblMenuFabricaDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenuFabricaDireccion.Name = "lblMenuFabricaDireccion"
        Me.lblMenuFabricaDireccion.Size = New System.Drawing.Size(67, 17)
        Me.lblMenuFabricaDireccion.TabIndex = 14
        Me.lblMenuFabricaDireccion.Text = "Dirección"
        '
        'txtMenuFabricaDireccion
        '
        Me.txtMenuFabricaDireccion.Location = New System.Drawing.Point(495, 226)
        Me.txtMenuFabricaDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMenuFabricaDireccion.Name = "txtMenuFabricaDireccion"
        Me.txtMenuFabricaDireccion.Size = New System.Drawing.Size(132, 22)
        Me.txtMenuFabricaDireccion.TabIndex = 13
        '
        'lblMenuFabricaProduccion
        '
        Me.lblMenuFabricaProduccion.AutoSize = True
        Me.lblMenuFabricaProduccion.Location = New System.Drawing.Point(119, 321)
        Me.lblMenuFabricaProduccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenuFabricaProduccion.Name = "lblMenuFabricaProduccion"
        Me.lblMenuFabricaProduccion.Size = New System.Drawing.Size(79, 17)
        Me.lblMenuFabricaProduccion.TabIndex = 12
        Me.lblMenuFabricaProduccion.Text = "Producción"
        '
        'txtMenuFabricaProduccion
        '
        Me.txtMenuFabricaProduccion.Location = New System.Drawing.Point(201, 315)
        Me.txtMenuFabricaProduccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMenuFabricaProduccion.Name = "txtMenuFabricaProduccion"
        Me.txtMenuFabricaProduccion.Size = New System.Drawing.Size(132, 22)
        Me.txtMenuFabricaProduccion.TabIndex = 11
        '
        'lblMenuFabricaMaterial
        '
        Me.lblMenuFabricaMaterial.AutoSize = True
        Me.lblMenuFabricaMaterial.Location = New System.Drawing.Point(119, 274)
        Me.lblMenuFabricaMaterial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenuFabricaMaterial.Name = "lblMenuFabricaMaterial"
        Me.lblMenuFabricaMaterial.Size = New System.Drawing.Size(58, 17)
        Me.lblMenuFabricaMaterial.TabIndex = 10
        Me.lblMenuFabricaMaterial.Text = "Material"
        '
        'txtMenuFabricaMaterial
        '
        Me.txtMenuFabricaMaterial.Location = New System.Drawing.Point(201, 268)
        Me.txtMenuFabricaMaterial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMenuFabricaMaterial.Name = "txtMenuFabricaMaterial"
        Me.txtMenuFabricaMaterial.Size = New System.Drawing.Size(132, 22)
        Me.txtMenuFabricaMaterial.TabIndex = 9
        '
        'lblMenuFabricaEncargado
        '
        Me.lblMenuFabricaEncargado.AutoSize = True
        Me.lblMenuFabricaEncargado.Location = New System.Drawing.Point(119, 233)
        Me.lblMenuFabricaEncargado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenuFabricaEncargado.Name = "lblMenuFabricaEncargado"
        Me.lblMenuFabricaEncargado.Size = New System.Drawing.Size(77, 17)
        Me.lblMenuFabricaEncargado.TabIndex = 8
        Me.lblMenuFabricaEncargado.Text = "Encargado"
        '
        'txtMenuFabricaEncargado
        '
        Me.txtMenuFabricaEncargado.Location = New System.Drawing.Point(201, 226)
        Me.txtMenuFabricaEncargado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMenuFabricaEncargado.Name = "txtMenuFabricaEncargado"
        Me.txtMenuFabricaEncargado.Size = New System.Drawing.Size(132, 22)
        Me.txtMenuFabricaEncargado.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(329, 190)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Información"
        '
        'lblMenuFabricaTitulo
        '
        Me.lblMenuFabricaTitulo.AutoSize = True
        Me.lblMenuFabricaTitulo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuFabricaTitulo.Location = New System.Drawing.Point(272, 102)
        Me.lblMenuFabricaTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenuFabricaTitulo.Name = "lblMenuFabricaTitulo"
        Me.lblMenuFabricaTitulo.Size = New System.Drawing.Size(265, 23)
        Me.lblMenuFabricaTitulo.TabIndex = 5
        Me.lblMenuFabricaTitulo.Text = "Introduzca el CIF de la emrpesa"
        '
        'lblMenuFabricaCIF
        '
        Me.lblMenuFabricaCIF.AutoSize = True
        Me.lblMenuFabricaCIF.Location = New System.Drawing.Point(233, 153)
        Me.lblMenuFabricaCIF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenuFabricaCIF.Name = "lblMenuFabricaCIF"
        Me.lblMenuFabricaCIF.Size = New System.Drawing.Size(28, 17)
        Me.lblMenuFabricaCIF.TabIndex = 4
        Me.lblMenuFabricaCIF.Text = "CIF"
        '
        'txtMenuFabricaCIF
        '
        Me.txtMenuFabricaCIF.Location = New System.Drawing.Point(279, 146)
        Me.txtMenuFabricaCIF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMenuFabricaCIF.Name = "txtMenuFabricaCIF"
        Me.txtMenuFabricaCIF.Size = New System.Drawing.Size(132, 22)
        Me.txtMenuFabricaCIF.TabIndex = 3
        '
        'btnMenuFabricaCIF
        '
        Me.btnMenuFabricaCIF.Location = New System.Drawing.Point(448, 146)
        Me.btnMenuFabricaCIF.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMenuFabricaCIF.Name = "btnMenuFabricaCIF"
        Me.btnMenuFabricaCIF.Size = New System.Drawing.Size(100, 28)
        Me.btnMenuFabricaCIF.TabIndex = 2
        Me.btnMenuFabricaCIF.Text = "Buscar"
        Me.btnMenuFabricaCIF.UseVisualStyleBackColor = True
        '
        'lblMenuFabrica
        '
        Me.lblMenuFabrica.AutoSize = True
        Me.lblMenuFabrica.Font = New System.Drawing.Font("Microsoft YaHei", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuFabrica.Location = New System.Drawing.Point(235, 33)
        Me.lblMenuFabrica.Name = "lblMenuFabrica"
        Me.lblMenuFabrica.Size = New System.Drawing.Size(310, 57)
        Me.lblMenuFabrica.TabIndex = 1
        Me.lblMenuFabrica.Text = "Menú Fabrica"
        '
        'txtConsultarTrabajadorAnyosTrabajados
        '
        Me.txtConsultarTrabajadorAnyosTrabajados.Location = New System.Drawing.Point(546, 134)
        Me.txtConsultarTrabajadorAnyosTrabajados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarTrabajadorAnyosTrabajados.Name = "txtConsultarTrabajadorAnyosTrabajados"
        Me.txtConsultarTrabajadorAnyosTrabajados.Size = New System.Drawing.Size(183, 22)
        Me.txtConsultarTrabajadorAnyosTrabajados.TabIndex = 45
        '
        'lblConsultarTrabajadorAnyosTrabajados
        '
        Me.lblConsultarTrabajadorAnyosTrabajados.AutoSize = True
        Me.lblConsultarTrabajadorAnyosTrabajados.Location = New System.Drawing.Point(425, 134)
        Me.lblConsultarTrabajadorAnyosTrabajados.Name = "lblConsultarTrabajadorAnyosTrabajados"
        Me.lblConsultarTrabajadorAnyosTrabajados.Size = New System.Drawing.Size(145, 21)
        Me.lblConsultarTrabajadorAnyosTrabajados.TabIndex = 44
        Me.lblConsultarTrabajadorAnyosTrabajados.Text = "Años Trabajados"
        '
        'txtConsultarProveedorCIFBusqueda
        '
        Me.txtConsultarProveedorCIFBusqueda.Location = New System.Drawing.Point(391, 107)
        Me.txtConsultarProveedorCIFBusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsultarProveedorCIFBusqueda.Name = "txtConsultarProveedorCIFBusqueda"
        Me.txtConsultarProveedorCIFBusqueda.Size = New System.Drawing.Size(167, 22)
        Me.txtConsultarProveedorCIFBusqueda.TabIndex = 57
        '
        'lblConsultarProveedorCIFBusqueda
        '
        Me.lblConsultarProveedorCIFBusqueda.AutoSize = True
        Me.lblConsultarProveedorCIFBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultarProveedorCIFBusqueda.Location = New System.Drawing.Point(125, 109)
        Me.lblConsultarProveedorCIFBusqueda.Name = "lblConsultarProveedorCIFBusqueda"
        Me.lblConsultarProveedorCIFBusqueda.Size = New System.Drawing.Size(250, 20)
        Me.lblConsultarProveedorCIFBusqueda.TabIndex = 56
        Me.lblConsultarProveedorCIFBusqueda.Text = "Inserte el CIF de la Empresa"
        '
        'btnConsultarProveedorBuscar
        '
        Me.btnConsultarProveedorBuscar.Location = New System.Drawing.Point(576, 99)
        Me.btnConsultarProveedorBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConsultarProveedorBuscar.Name = "btnConsultarProveedorBuscar"
        Me.btnConsultarProveedorBuscar.Size = New System.Drawing.Size(131, 39)
        Me.btnConsultarProveedorBuscar.TabIndex = 58
        Me.btnConsultarProveedorBuscar.Text = "Buscar"
        Me.btnConsultarProveedorBuscar.UseVisualStyleBackColor = True
        '
        'GestionEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 422)
        Me.Controls.Add(Me.MenuProveedores)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.Trabajador)
        Me.Controls.Add(Me.InformacionTrabajador)
        Me.Controls.Add(Me.DarAltaTrabajador)
        Me.Controls.Add(Me.MenuModificarTrabajador)
        Me.Controls.Add(Me.ModificarTrabajador)
        Me.Controls.Add(Me.BajaTrabajador)
        Me.Controls.Add(Me.AltaProveedor)
        Me.Controls.Add(Me.ConsultarProveedor)
        Me.Controls.Add(Me.BusquedaModificarProveedor)
        Me.Controls.Add(Me.ModificarProveedor)
        Me.Controls.Add(Me.BajaProveedor)
        Me.Controls.Add(Me.MenuClientes)
        Me.Controls.Add(Me.ClientesAtendidos)
        Me.Controls.Add(Me.NuevaContratacion)
        Me.Controls.Add(Me.ContratacionesEnCurso)
        Me.Controls.Add(Me.CancelarContratacion)
        Me.Controls.Add(Me.MenuFabrica)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GestionEmpresa"
        Me.Text = "Gestión de la Empresa"
        Me.Login.ResumeLayout(False)
        Me.Login.PerformLayout()
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.Trabajador.ResumeLayout(False)
        Me.Trabajador.PerformLayout()
        Me.MenuModificarTrabajador.ResumeLayout(False)
        Me.MenuModificarTrabajador.PerformLayout()
        Me.DarAltaTrabajador.ResumeLayout(False)
        Me.DarAltaTrabajador.PerformLayout()
        Me.InformacionTrabajador.ResumeLayout(False)
        Me.InformacionTrabajador.PerformLayout()
        Me.BajaTrabajador.ResumeLayout(False)
        Me.BajaTrabajador.PerformLayout()
        Me.ModificarTrabajador.ResumeLayout(False)
        Me.ModificarTrabajador.PerformLayout()
        Me.MenuProveedores.ResumeLayout(False)
        Me.MenuProveedores.PerformLayout()
        Me.AltaProveedor.ResumeLayout(False)
        Me.AltaProveedor.PerformLayout()
        Me.BusquedaModificarProveedor.ResumeLayout(False)
        Me.BusquedaModificarProveedor.PerformLayout()
        Me.ModificarProveedor.ResumeLayout(False)
        Me.ModificarProveedor.PerformLayout()
        Me.ConsultarProveedor.ResumeLayout(False)
        Me.ConsultarProveedor.PerformLayout()
        Me.BajaProveedor.ResumeLayout(False)
        Me.BajaProveedor.PerformLayout()
        Me.MenuClientes.ResumeLayout(False)
        Me.MenuClientes.PerformLayout()
        Me.ClientesAtendidos.ResumeLayout(False)
        Me.ClientesAtendidos.PerformLayout()
        Me.NuevaContratacion.ResumeLayout(False)
        Me.NuevaContratacion.PerformLayout()
        Me.ContratacionesEnCurso.ResumeLayout(False)
        Me.ContratacionesEnCurso.PerformLayout()
        Me.CancelarContratacion.ResumeLayout(False)
        Me.CancelarContratacion.PerformLayout()
        Me.MenuFabrica.ResumeLayout(False)
        Me.MenuFabrica.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents btnAcceder As Button
    Friend WithEvents btnRecuperarAcc As Button
    Friend WithEvents Login As Panel
    Friend WithEvents Menu As Panel
    Friend WithEvents Trabajador As Panel
    Friend WithEvents btnFabricas As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnTrabajadores As Button
    Friend WithEvents lblMenu As Label
    Friend WithEvents DarAltaTrabajador As Panel
    Friend WithEvents DateAltaTrabajadorNacimiento As DateTimePicker
    Friend WithEvents lblAltaTrabajadorNacimiento As Label
    Friend WithEvents lblAltaTrabajadorApellido As Label
    Friend WithEvents lblAltaTrabajadorNombre As Label
    Friend WithEvents lblAltaTrabajador As Label
    Friend WithEvents btnSalirMenuTrabajador As Button
    Friend WithEvents btnAtrasMenuTrabajador As Button
    Friend WithEvents btnBajaTrabajador As Button
    Friend WithEvents btnModificarTrabajador As Button
    Friend WithEvents btnConsultarTrabajador As Button
    Friend WithEvents btnAltaTrabajador As Button
    Friend WithEvents lblMenuTrabajador As Label
    Friend WithEvents txtAltaTrabajadorApellido As TextBox
    Friend WithEvents txtAltaTrabajadorNombre As TextBox
    Friend WithEvents txtAltaTrabajadorDNI As TextBox
    Friend WithEvents lblAltaTrabajadorDNI As Label
    Friend WithEvents txtAltaTrabajadorTel As TextBox
    Friend WithEvents txtAltaTrabajadorEmail As TextBox
    Friend WithEvents lblAltaTrabajadorTel As Label
    Friend WithEvents lblAltaTrabajadorEmail As Label
    Friend WithEvents btnAltaTrabajadoresAceptar As Button
    Friend WithEvents btnAltaTrabajadoresCancelar As Button
    Friend WithEvents txtAltaTrabajadorSexo As TextBox
    Friend WithEvents lblAltaTrabajadorSexo As Label
    Friend WithEvents BajaTrabajador As Panel
    Friend WithEvents lblMenuBajaTrabajador As Label
    Friend WithEvents MenuModificarTrabajador As Panel
    Friend WithEvents btnModificacionTrabajadorBuscar As Button
    Friend WithEvents btnModificacionTrabajadorCancelar As Button
    Friend WithEvents txtMenuModificacionTrabajadorDNI As TextBox
    Friend WithEvents lblMenuModificacionTrabajadorDNI As Label
    Friend WithEvents lblModificacionTrabajador As Label
    Friend WithEvents btnBajaTrabajadorAceptar As Button
    Friend WithEvents btnBajaTrabajadorCancelar As Button
    Friend WithEvents txtBajaTrabajadorRazon As TextBox
    Friend WithEvents lblBajaTrabajadorRazon As Label
    Friend WithEvents txtBajaTrabajadorDNI As TextBox
    Friend WithEvents lblBajaTrabajadorDNI As Label
    Friend WithEvents InformacionTrabajador As Panel
    Friend WithEvents txtConsultarTrabajadorSexo As TextBox
    Friend WithEvents lblConsultarTrabajadorSexo As Label
    Friend WithEvents btnConsultarTrabajadorAtras As Button
    Friend WithEvents txtConsultarTrabajadorTel As TextBox
    Friend WithEvents txtConsultarTrabajadorEmail As TextBox
    Friend WithEvents lblConsultarTrabajadorTel As Label
    Friend WithEvents lblConsultarTrabajadorEmail As Label
    Friend WithEvents txtConsultarTrabajadorDNI As TextBox
    Friend WithEvents lblConsultarTrabajadorDNI As Label
    Friend WithEvents txtConsultarTrabajadorTipoTrabajador As TextBox
    Friend WithEvents txtConsultarTrabajadorApellido As TextBox
    Friend WithEvents txtConsultarTrabajadorNombre As TextBox
    Friend WithEvents lblConsultarTrabajadorTipoTrabajador As Label
    Friend WithEvents lblConsultarTrabajadorEdad As Label
    Friend WithEvents lblConsultarTrabajadorApellido As Label
    Friend WithEvents lblConsultarTrabajadorNombre As Label
    Friend WithEvents lblInformacionTrabajador As Label
    Friend WithEvents ModificarTrabajador As Panel
    Friend WithEvents txtMenuModificarTrabajadorSexo As TextBox
    Friend WithEvents lblMenuModificarTrabajadorSexo As Label
    Friend WithEvents btnMenuModificarTrabajadorAceptar As Button
    Friend WithEvents btnMenuModificarTrabajadorCancelar As Button
    Friend WithEvents txtMenuModificarTrabajadorTel As TextBox
    Friend WithEvents txtMenuModificarTrabajadorEmail As TextBox
    Friend WithEvents lblMenuModificarTrabajadorTel As Label
    Friend WithEvents lblMenuModificarTrabajadorEmail As Label
    Friend WithEvents txtMenuModificarTrabajadorDNI As TextBox
    Friend WithEvents lblMenuModificarTrabajadorDNI As Label
    Friend WithEvents txtMenuModificarTrabajadorTipo As TextBox
    Friend WithEvents txtMenuModificarTrabajadorApellido As TextBox
    Friend WithEvents txtMenuModificarTrabajadorNombre As TextBox
    Friend WithEvents lblMenuModificarTrabajadorEspecialidad As Label
    Friend WithEvents lblMenuModificarTrabajadorNacimiento As Label
    Friend WithEvents lblMenuModificarTrabajadorApellido As Label
    Friend WithEvents lblMenuModificarTrabajadorNombre As Label
    Friend WithEvents lblModificarTrabajador As Label
    Friend WithEvents MenuProveedores As Panel
    Friend WithEvents btnBajaProveedor As Button
    Friend WithEvents btnConsultarProveedor As Button
    Friend WithEvents btnModificarProveedor As Button
    Friend WithEvents btnAñadirProveedor As Button
    Friend WithEvents lblMenuProveedores As Label
    Friend WithEvents AltaProveedor As Panel
    Friend WithEvents lblAltaProveedorTipo As Label
    Friend WithEvents lblAltaProveedorCIF As Label
    Friend WithEvents lblAltaProveedorNombre As Label
    Friend WithEvents lblAltaProveedorNombreEmpresa As Label
    Friend WithEvents lblMenuAltaProveedor As Label
    Friend WithEvents btnAltaProveedorAceptar As Button
    Friend WithEvents btnAltaProveedorCancelar As Button
    Friend WithEvents txtAltaProveedorEmail As TextBox
    Friend WithEvents txtAltaProveedorTelefono As TextBox
    Friend WithEvents txtAltaProveedorDireccion As TextBox
    Friend WithEvents lblAltaProveedorEmail As Label
    Friend WithEvents lblAltaProveedorTelefono As Label
    Friend WithEvents lblAltaProveedorDireccion As Label
    Friend WithEvents txtAltaProveedorTipo As TextBox
    Friend WithEvents txtAltaProveedorCIF As TextBox
    Friend WithEvents txtAltaProveedorApellido As TextBox
    Friend WithEvents txtAltaProveedorNombre As TextBox
    Friend WithEvents txtAltaProveedorNombreEmpresa As TextBox
    Friend WithEvents lblAltaProveedorApellido As Label
    Friend WithEvents BusquedaModificarProveedor As Panel
    Friend WithEvents btnBusquedaModificacionProveedorBuscar As Button
    Friend WithEvents btnBusquedaModificacionProveedorCancelar As Button
    Friend WithEvents txtBusquedaModificarProveedorCIF As TextBox
    Friend WithEvents lblBusquedaModificarProveedorCIF As Label
    Friend WithEvents lblBusquedaModificarProveedorTexto As Label
    Friend WithEvents lblBusquedaModificarProveedor As Label
    Friend WithEvents ModificarProveedor As Panel
    Friend WithEvents lblModificarProveedor As Label
    Friend WithEvents btnModificarProveedorAceptar As Button
    Friend WithEvents btnModificarProveedorCancelar As Button
    Friend WithEvents txtModificarProveedorEmail As TextBox
    Friend WithEvents txtModificarProveedorTelefono As TextBox
    Friend WithEvents txtModificarProveedorDireccion As TextBox
    Friend WithEvents lblModificarProveedorEmail As Label
    Friend WithEvents lblModificarProveedorTelefono As Label
    Friend WithEvents lblModificarProveedorDireccion As Label
    Friend WithEvents txtModificarProveedorTipo As TextBox
    Friend WithEvents txtModificarProveedorCIF As TextBox
    Friend WithEvents txtModificarProveedorApellido As TextBox
    Friend WithEvents txtModificarProveedorNombre As TextBox
    Friend WithEvents txtModificarProveedorNombreEmpresa As TextBox
    Friend WithEvents lblModificarProveedorApellido As Label
    Friend WithEvents lblModificarProveedorTipo As Label
    Friend WithEvents lblModificarProveedorCIF As Label
    Friend WithEvents lblModificarProveedorNombre As Label
    Friend WithEvents lblModificarProveedorNombreEmpresa As Label
    Friend WithEvents ConsultarProveedor As Panel
    Friend WithEvents btnConsultarProveedorCancelar As Button
    Friend WithEvents txtConsultarProveedorEmail As TextBox
    Friend WithEvents txtConsultarProveedorTelefono As TextBox
    Friend WithEvents txtConsultarProveedorDireccion As TextBox
    Friend WithEvents lblConsultarProveedorEmail As Label
    Friend WithEvents lblConsultarProveedorTelefono As Label
    Friend WithEvents lblConsultarProveedorDireccion As Label
    Friend WithEvents txtConsultarProveedorTipo As TextBox
    Friend WithEvents txtConsultarProveedorCIF As TextBox
    Friend WithEvents txtConsultarProveedorApellido As TextBox
    Friend WithEvents txtConsultarProveedorNombre As TextBox
    Friend WithEvents txtConsultarProveedorNombreEmpresa As TextBox
    Friend WithEvents lblConsultarProveedorApellido As Label
    Friend WithEvents lblConsultarProveedorTipos As Label
    Friend WithEvents lblConsultarProveedorCIF As Label
    Friend WithEvents lblConsultarProveedorNombre As Label
    Friend WithEvents lblConsultarProveedorNombreEmpresa As Label
    Friend WithEvents lblConsultarProveedor As Label
    Friend WithEvents BajaProveedor As Panel
    Friend WithEvents btnBajaProveedorAceptar As Button
    Friend WithEvents btnBajaProveedorCancelar As Button
    Friend WithEvents txtBajaProveedorRazon As TextBox
    Friend WithEvents lblBajaProveedorRazon As Label
    Friend WithEvents txtBajaProveedorDNI As TextBox
    Friend WithEvents lblBajaProveedorDNI As Label
    Friend WithEvents lblMenuBajaProveedor As Label
    Friend WithEvents MenuClientes As Panel
    Friend WithEvents lblMenuClientes As Label
    Friend WithEvents btnMenuClientesCContrataciones As Button
    Friend WithEvents btnMenuClientesNContratacion As Button
    Friend WithEvents btnMenuClientesAtendidos As Button
    Friend WithEvents btnMenuClientesSalir As Button
    Friend WithEvents ClientesAtendidos As Panel
    Friend WithEvents lblMenuClientesAtendidos As Label
    Friend WithEvents lblClientesAtendidosApellidos As Label
    Friend WithEvents lblClientesAtendidosNombre As Label
    Friend WithEvents lblClientesAtendidosInformacion As Label
    Friend WithEvents txtClientesAtendidosNombre As TextBox
    Friend WithEvents lblClientesAtendidosBusqueda As Label
    Friend WithEvents txtClientesAtendidosBusqueda As TextBox
    Friend WithEvents txtClientesAtendidosCoste As TextBox
    Friend WithEvents lblClientesAtendidosCoste As Label
    Friend WithEvents txtClientesAtendidosTipoServicio As TextBox
    Friend WithEvents lblClientesAtendidosTipoServicio As Label
    Friend WithEvents txtClientesAtendidosEmail As TextBox
    Friend WithEvents lblClientesAtendidosEmail As Label
    Friend WithEvents txtClientesAtendidosTelefono As TextBox
    Friend WithEvents lblClientesAtendidosTelefono As Label
    Friend WithEvents txtClientesAtendidosDireccion As TextBox
    Friend WithEvents lblClientesAtendidosDireccion As Label
    Friend WithEvents txtClientesAtendidosDNI As TextBox
    Friend WithEvents lblClientesAtendidosDNI As Label
    Friend WithEvents txtClientesAtendidosApellidos As TextBox
    Friend WithEvents btnClientesAtendidosAtras As Button
    Friend WithEvents btnClientesAtendidosBuscar As Button
    Friend WithEvents txtClientesAtendidosFecha As TextBox
    Friend WithEvents lblClientesAtendidosFecha As Label
    Friend WithEvents btnMenuClientesFContratacion As Button
    Friend WithEvents NuevaContratacion As Panel
    Friend WithEvents lblNuevaContratacion As Label
    Friend WithEvents btnNuevaContratacionAceptar As Button
    Friend WithEvents btnNuevaContratacionCancelar As Button
    Friend WithEvents lblNuevaContratacionFechaContratacion As Label
    Friend WithEvents txtNuevaContratacionCoste As TextBox
    Friend WithEvents lblNuevaContratacionCoste As Label
    Friend WithEvents txtNuevaContratacionTipoServicio As TextBox
    Friend WithEvents lblNuevaContratacionTipoServicio As Label
    Friend WithEvents txtNuevaContratacionEmail As TextBox
    Friend WithEvents lblNuevaContratacionEmail As Label
    Friend WithEvents txtNuevaContratacionTelefono As TextBox
    Friend WithEvents lblNuevaContratacionTelefono As Label
    Friend WithEvents txtNuevaContratacionDireccion As TextBox
    Friend WithEvents lblNuevaContratacionDireccion As Label
    Friend WithEvents txtNuevaContratacionDNI As TextBox
    Friend WithEvents lblNuevaContratacionDNI As Label
    Friend WithEvents txtNuevaContratacionApellidos As TextBox
    Friend WithEvents lblNuevaContratacionApellidos As Label
    Friend WithEvents lblNuevaContratacionNombre As Label
    Friend WithEvents lblNuevaContratacionInfoCliente As Label
    Friend WithEvents txtNuevaContratacionNombre As TextBox
    Friend WithEvents ContratacionesEnCurso As Panel
    Friend WithEvents lblConsultaContrataciones As Label
    Friend WithEvents btnConsultaContratacionesBusqueda As Button
    Friend WithEvents txtConsultaContratacionesCoste As TextBox
    Friend WithEvents lblConsultaContratacionesCoste As Label
    Friend WithEvents txtConsultaContratacionesTipoServicio As TextBox
    Friend WithEvents lblConsultaContratacionesTipoServicio As Label
    Friend WithEvents txtConsultaContratacionesEmail As TextBox
    Friend WithEvents lblConsultaContratacionesEmail As Label
    Friend WithEvents txtConsultaContratacionesTelefono As TextBox
    Friend WithEvents lblConsultaContratacionesTelefono As Label
    Friend WithEvents txtConsultaContratacionesDireccion As TextBox
    Friend WithEvents lblConsultaContratacionesDireccion As Label
    Friend WithEvents txtConsultaContratacionesDNI As TextBox
    Friend WithEvents lblConsultaContratacionesDNI As Label
    Friend WithEvents txtConsultaContratacionesApellidos As TextBox
    Friend WithEvents lblConsultaContratacionesApellidos As Label
    Friend WithEvents lblConsultaContratacionesNombre As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtConsultaContratacionesNombre As TextBox
    Friend WithEvents lblConsultaContratacionesBusqueda As Label
    Friend WithEvents txtConsultaContratacionesBusqueda As TextBox
    Friend WithEvents btnConsultaContratacionesAtras As Button
    Friend WithEvents CancelarContratacion As Panel
    Friend WithEvents lblCancelarContratacion As Label
    Friend WithEvents btnCancelarContratacionAceptar As Button
    Friend WithEvents btnCancelarContratacionCancelar As Button
    Friend WithEvents lblCancelarContratacionRazon As Label
    Friend WithEvents txtCancelarContratacionRazon As TextBox
    Friend WithEvents lblCancelarContratacionDNI As Label
    Friend WithEvents txtCancelarContratacionDNI As TextBox
    Friend WithEvents MenuFabrica As Panel
    Friend WithEvents lblMenuFabrica As Label
    Friend WithEvents lblMenuFabricaProduccion As Label
    Friend WithEvents txtMenuFabricaProduccion As TextBox
    Friend WithEvents lblMenuFabricaMaterial As Label
    Friend WithEvents txtMenuFabricaMaterial As TextBox
    Friend WithEvents lblMenuFabricaEncargado As Label
    Friend WithEvents txtMenuFabricaEncargado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMenuFabricaTitulo As Label
    Friend WithEvents lblMenuFabricaCIF As Label
    Friend WithEvents txtMenuFabricaCIF As TextBox
    Friend WithEvents btnMenuFabricaCIF As Button
    Friend WithEvents lblMenuFabricaEmail As Label
    Friend WithEvents txtMenuFabricaEmail As TextBox
    Friend WithEvents lblMenuFabricaTelefono As Label
    Friend WithEvents txtMenuFabricaTelefono As TextBox
    Friend WithEvents lblMenuFabricaDireccion As Label
    Friend WithEvents txtMenuFabricaDireccion As TextBox
    Friend WithEvents btnMenuFabricaSalir As Button
    Friend WithEvents txtAltaTrabajadorTipo As TextBox
    Friend WithEvents lblAltaTrabajadorTipo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMenuModificarTrabajadorAnyosTrabajados As TextBox
    Friend WithEvents txtMenuModificarTrabajadorEdad As TextBox
    Friend WithEvents DateTimePickerNuevaContratacion As DateTimePicker
    Friend WithEvents CBNuevaContratacionTrabajador As ComboBox
    Friend WithEvents lblNuevaContratacionTrabajador As Label
    Friend WithEvents txtConsultaContratacionesFecha As TextBox
    Friend WithEvents lblConsultaContratacionesFecha As Label
    Friend WithEvents DateTimeCancelarContratacionFecha As DateTimePicker
    Friend WithEvents lblCancelarContratacionFecha As Label
    Friend WithEvents btnConsultarProveedorAtras As Button
    Friend WithEvents btnConsultarProveedorSailr As Button
    Friend WithEvents btnMenuClientesAtras As Button
    Friend WithEvents btnMenuFabricaAtras As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtConsultarTrabajadorPass As TextBox
    Friend WithEvents lblConsultarTrabajadorPass As Label
    Friend WithEvents txtConsultarTrabajadorUsuario As TextBox
    Friend WithEvents lblConsultarTrabajadorUsuario As Label
    Friend WithEvents txtConsultarTrabajadorEdad As TextBox
    Friend WithEvents btnConsultarTrabajadorBuscar As Button
    Friend WithEvents txtConsultarTrabajadorAnyosTrabajados As TextBox
    Friend WithEvents lblConsultarTrabajadorAnyosTrabajados As Label
    Friend WithEvents btnConsultarProveedorBuscar As Button
    Friend WithEvents txtConsultarProveedorCIFBusqueda As TextBox
    Friend WithEvents lblConsultarProveedorCIFBusqueda As Label
End Class
