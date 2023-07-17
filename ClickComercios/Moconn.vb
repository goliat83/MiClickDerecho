Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.Data.SqlClient
Imports iTextSharp.text.pdf


Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Module Moconn


    Public db_actual As String = "miclickdb"
    Public version_miclick As String = ""
    Public shostname As String = System.Net.Dns.GetHostName
    Public hostname As String = "servidor"
    Public castor As String = "" ' puede ir xamp,mysql,sql
    Public ClickFolder As String = Application.StartupPath.ToString
    Public DOMO As String = ""



    Public VersionActual As String = ""
    Public NuevaVersion As String = ""
    Public Function VersionApp() As String

        VersionActual = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString

        Return VersionActual
    End Function


    Public adn As String = ""
    Public miadn() As String
    Public midata() As String
    Public mi_port As String = "3307"



    Public conexdbnopass As New MySqlConnection("data source=localhost; user id=root; password=''; port=3307;Connect Timeout=28800")
    Public conexdb As New MySqlConnection("data source=localhost; user id=root; password='Radiobemba'; port=3307;Connect Timeout=28800")
    Public conex_miclick As New MySqlConnection("data source=167.114.216.134; user id=aparquea_goliat; password='Radiob3mba@_';database=aparquea_mydata; port=3306;Connect Timeout=30")



    '  === cuando es el SERVIDOR CONETA LOCAL==========================================================================================================================
    Public conex As New MySqlConnection("data source=localhost; user id=root; password='Radiobemba';database=" & db_actual & "; port=3307;Connect Timeout=28800")
    '  ===============================================================================================================================================================

    '  === cuando es el cliente BUSCA RED =============================================================================================================================
    Public conexRED As New MySqlConnection("data source=" & hostname & "; user id=goliat; password='goliat';database=" & db_actual & "; port=3307;Connect Timeout=28800")
    '  ==============================================================================================================================================================

    '  === cuando es el nube BUSCA nube =============================================================================================================================
    Public conexCloud As New MySqlConnection("")
    '  ==============================================================================================================================================================


    Public MSconex As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\miclick\Datos\micdb.mdf;Integrated Security=True")
    Public MSda As SqlDataAdapter


    Public num_nomina_global As String
    Public ultimo_recibo_egreso, ultimo_recibo_egreso_nomina, ultimo_recibo_ingreso As Long

    Public VIENE_IMPR_RECIBO As String = ""

    Public VISITA_MAPA, VISITA_WEB As String
    Public PRUEBAS As Boolean = True

    Public da As MySqlDataAdapter
    Public da_databases As MySqlDataAdapter
    Public da_databasesE As MySqlDataAdapter

    Public da_data_local As MySqlDataAdapter
    Public da_data_cloud As MySqlDataAdapter

    Public da_cocina_pedidos As MySqlDataAdapter
    Public da_cocina_prods As MySqlDataAdapter

    Public da_emplist As MySqlDataAdapter
    Public da_emppermisos As MySqlDataAdapter
    Public da_empmediospagos As MySqlDataAdapter

    Public dA_imprimir_prods As MySqlDataAdapter
    Public da_combo_CUENTAS_PUC As MySqlDataAdapter

    Public dA_permisos As MySqlDataAdapter

    Public da_comprobantesgenerales As MySqlDataAdapter

    Public da_infor_fecha_turno As MySqlDataAdapter
    Public da_infor_detalle_turno As MySqlDataAdapter

    Public da_CXP As MySqlDataAdapter
    Public da_CXC As MySqlDataAdapter


    Public Da_IMPRIMIRPRODS As MySqlDataAdapter
    Public da_prodscombo As MySqlDataAdapter
    Public da_impuestosVentas As MySqlDataAdapter
    Public da_impuestosVentas2 As MySqlDataAdapter

    Public da_domiciliarios As MySqlDataAdapter
    Public dt_domiciliarios As DataTable


    Public da_meseros As MySqlDataAdapter
    Public da_up As MySqlDataAdapter
    Public da_combo_puc As MySqlDataAdapter
    Public da_combo_puc_filtro As MySqlDataAdapter

    Public da_combo_puc_cuenta1 As MySqlDataAdapter
    Public da_combo_puc_cuenta2 As MySqlDataAdapter


    Public da_combo_ctapuc_vender_cat As MySqlDataAdapter
    Public da_combo_ctapuc_inv_cat As MySqlDataAdapter
    Public da_combo_ctapuc_costo_cat As MySqlDataAdapter
    Public da_combo_ctapuc_dev_cat As MySqlDataAdapter

    Public da_combo_ctapuc_imp As MySqlDataAdapter

    Public da_combo_ctapuc_mi As MySqlDataAdapter
    Public dt_combo_ctapuc_mi As DataTable

    Public da_combo_ctapuc_cg As MySqlDataAdapter
    Public dt_combo_ctapuc_cg As DataTable

    Public da_combo_ctapuc_cE As MySqlDataAdapter
    Public dt_combo_ctapuc_cE As DataTable

    Public da_saldosprods As MySqlDataAdapter
    Public da_comprasprods As MySqlDataAdapter
    Public da_BODEGAS As New MySqlDataAdapter
    Public da_SALDOS As New MySqlDataAdapter
    Public da_MESAS As New MySqlDataAdapter
    Public da_mensajeros As New MySqlDataAdapter
    Public da_cajas As New MySqlDataAdapter
    Public da_bancos As New MySqlDataAdapter

    Public da_COMBO_CREDITO As New MySqlDataAdapter
    Public da_COMBO_CARTERA As New MySqlDataAdapter

    Public da_MEDIOS_PAGO As New MySqlDataAdapter
    Public da_bodegas_config As New MySqlDataAdapter

    Public da_COMBO_cuentas_paracierre As New MySqlDataAdapter
    Public da_COMBO_cuentas_paraabrir As New MySqlDataAdapter

    Public da_COMBO_cuentas_parapagos As New MySqlDataAdapter
    Public da_COMBO_MEDIOS_PAGO As New MySqlDataAdapter
    Public da_comboorigenmov As New MySqlDataAdapter
    Public da_combodestinomov As New MySqlDataAdapter
    Public da_MOVIMIENTOS_GRID As New MySqlDataAdapter
    Public da_COMBO_terceros As New MySqlDataAdapter
    Public da_COMBO_docs_conta As New MySqlDataAdapter
    Public da_COMBO_TIPOdocs_conta As New MySqlDataAdapter
    Public da_cartera_grid As New MySqlDataAdapter
    Public da_cartera_DETALLE As New MySqlDataAdapter

    Public da_credito_grid As New MySqlDataAdapter
    Public da_credito_DETALLE As New MySqlDataAdapter

    Public da_COMBO_docs_conta_COMP As New MySqlDataAdapter
    Public da_conta_COMBO1 As New MySqlDataAdapter

    Public da_VENTAS As New MySqlDataAdapter
    Public da_COMPRAS As New MySqlDataAdapter
    Public da_combo_puc_comp As New MySqlDataAdapter
    Public da_puc_COMP_DET As New MySqlDataAdapter
    Public da_DOCS_GRID As New MySqlDataAdapter
    Public da_puc As New MySqlDataAdapter
    Public da_det_comp As New MySqlDataAdapter
    Public da_puc_COMP As New MySqlDataAdapter
    Public da_combo_CUENTAS_DOCS As New MySqlDataAdapter

    Public da_prodlist As New MySqlDataAdapter
    Public da_comboMeseros As New MySqlDataAdapter
    Public da_contact As New MySqlDataAdapter
    Public da_contact_mov As New MySqlDataAdapter
    Public da_contact_filtro_compra As New MySqlDataAdapter
    Public da_cli_cartera As New MySqlDataAdapter
    Public da_cli_credito As New MySqlDataAdapter

    Public da_lotes As New MySqlDataAdapter

    Public da_CATEGORIAS_TEMP As New MySqlDataAdapter
    Public da_pdf As New MySqlDataAdapter
    Public dt_DOCS_GRID As DataTable

    Public dt As DataTable
    Public dt_databasesE As DataTable
    Public dt_databases As DataTable

    Public dt_data_local As DataTable

    Public dt_data_cloud As DataTable

    Public dt_cli_cartera As DataTable
    Public dt_cli_credito As DataTable

    Public dt_cocina_pedidos As DataTable
    Public dt_cocina_prods As DataTable

    Public dt_combo_puc_cuenta1 As DataTable
    Public dt_combo_puc_cuenta2 As DataTable

    Public dt_cartera_DETALLE As DataTable
    Public dt_cREDITO_DETALLE As DataTable

    Public dt_cartera_grid As DataTable
    Public dt_emplist As DataTable
    Public dt_empmediospagos As DataTable
    Public dt_emppermisos As DataTable

    Public dt_COMBO_cuentas_PUC As DataTable
    Public dt_comprobantesgenerales As DataTable
    Public dT_conta_COMBO1 As New DataTable

    Public dt_infor_fecha_turno As DataTable
    Public dt_infor_detalle_turno As DataTable

    Public dt_combo_docs_conta As DataTable
    Public dt_combo_TIPOdocs_conta As DataTable

    Public dt_combo_ctapuc_vender_cat As DataTable
    Public dt_combo_ctapuc_inv_cat As DataTable
    Public dt_combo_ctapuc_costo_cat As DataTable
    Public dt_combo_ctapuc_dev_cat As DataTable
    Public dt_combo_ctapuc_imp As DataTable

    Public dt_CXP As DataTable
    Public dt_CXC As DataTable

    Public dt_MOVIMIENTOS_GRID As DataTable

    Public dt_pdf As DataTable
    Public dt_up As DataTable
    Public dt_cajas As DataTable
    Public dt_bancos As DataTable

    Public dt_MEDIOS_PAGO As DataTable
    Public dt_bodegas_config As DataTable

    Public dt_COMBO_MEDIOS_PAGO As DataTable
    Public dt_puc As DataTable
    Public dt_det_comp As DataTable

    Public dt_puc_COMP As DataTable
    Public dt_puc_COMP_DET As DataTable
    Public dt_combo_terceros As DataTable
    Public dt_combo_CUENTAS_DOCS As DataTable
    Public dt_combo_puc As DataTable
    Public dt_combo_puc_comp As DataTable
    Public dt_combo_docs_conta_COMP As DataTable
    Public dt_combo_puc_filtro As DataTable

    Public dt_conductores_combo As DataTable
    Public dt_ayudante_combo As DataTable
    Public dt_RUTAS_COMBO As DataTable
    Public dt_tecnicos_COMBO As DataTable

    Public dt_impuestosVentas As DataTable
    Public dt_impuestosVentas2 As DataTable

    Public dt_COMBO_cuentas_paracierre As DataTable
    Public dt_COMBO_cuentas_paraabrir As DataTable


    Public dT_COMBO_CREDITO As New DataTable
    Public dT_COMBO_CARTERA As New DataTable
    Public DT_CREDITO_GRID As New DataTable
    Public dt_COMBO_CAJA As DataTable
    Public dt_COMBO_BANCO As DataTable
    Public dt_COMBO_cuentas_parapagos As DataTable
    Public dt_comboorigenmov As DataTable
    Public dt_combodestinomov As DataTable

    Public dt_permisos As DataTable
    Public dt_prodscombo As DataTable
    Public dt_saldosprods As DataTable



    Public dt_categorias_TEMP As DataTable
    Public dt_imprimir_prods As DataTable
    Public dt_comprasprods As DataTable
    Public dt_BODEGAS As New DataTable
    Public dt_empleados As DataTable
    Public dt_vendedores As DataTable
    Public dt_clientes As DataTable
    Public dt_saldos As DataTable
    Public dt_destino As DataTable
    Public DT_ORIGEN As DataTable
    Public DT_MESAS As DataTable
    Public DT_mensajeros As DataTable
    Public DT_VENTAS As DataTable
    Public DT_COMPRAS As DataTable
    Public DT_contact As DataTable
    Public DT_contact_mov As DataTable
    Public DT_contact_filtro_compra As DataTable


    Public DT_lotes As DataTable


    Public DT_prodlist As DataTable
    Public DT_meseros As DataTable

    Public sql As String
    Public ds As DataSet


    Public dr As MySqlDataReader
    Public dr_consecutivos As MySqlDataReader
    Public cmd As New MySqlCommand

    Public da2 As MySqlDataAdapter
    Public dt2 As DataTable
    Public sql2 As String
    Public ds2 As DataSet
    Public dr2 As MySqlDataReader
    Public cmd2 As New MySqlCommand

    Public consecutivo As Long
    Public consecutivo_CXC As Long

    Public consecutivo_domicilios As Long


    Public que_movimiento As String = ""
    Public que_movimiento_cod As String = ""


    Public MAILS_NUEVOS As String
    Public usr_mail_mail As String
    Public usr_pass_mail As String

    Public ESTADO_CONEXION_LOCAL As Boolean = False
    Public ESTADO_CONEXION_REMOTA As Boolean = False

    Public venta_con_domicilio As String
    Public domicilio_ID, domiciliario, domiciliovr As String

    Public LinkActualizacion As String

    Public comex_medios_pago() As String

    Public comex_lic_tipo As String
    Public comex_lic_producto As String
    Public comex_lic_freg As String
    Public comex_lic_fini As String
    Public comex_lic_ffin As String

    Public comex_lic_nit As String
    Public comex_lic_propietario As String
    Public comex_lic_nequipos As String
    Public comex_lic_serial As String
    Public comex_lic_acivetcode As String
    Public comex_lic_razonsocial As String

    Public comex_lic_email As String
    Public comex_licenciaserial As String
    Public comex_lic_estado As String
    Public comex_lic_regimen As String

    Public comex_PAGO_efectivo, comex_PAGO_datafono, comex_PAGO_consignacion, comex_PAGO_CREDITO_cobrar, comex_PAGO_CREDITO_pagar, comex_metodoinv, comex_fondo, comex_propina, comex_propinavr, comex_backups, comex_buscarpor, comex_cuenta_cierre, comex_cuenta_ventas, comex_balanzacom, comex_imppos, comex_impstandard, comex_impcomanda As String
    Public comex_PAGO_efectivo_nombre, comex_PAGO_datafono_nombre, comex_PAGO_consignacion_nombre, comex_PAGO_CREDITO_cobrar_nombre, comex_PAGO_CREDITO_pagar_nombre, comex_cocina, comex_bodega_ventas, comex_bodega_compras, comex_bodega_produccion As String
    Public COMEX_CLOUDCODE As String
    Public COMEX_propina_txt As String = "Advertencia propina: 
se informa a los consumidores que este establecimiento de comercio sugiere a sus
consumidores una propina correspon diente al % del valor de la cuenta, el cual 
podrá ser aceptado, rechazado o modificado por usted, de acuerdo con su valoración
del servicio prestado. Al momento de solicitar la cuenta, indíquele a la persona que 
lo atiende si quiere que dicho valor sea o no incluido en la factura o indíquele el 
valor que quiere dar como propina"

    Public COMEX_propina_txt2 As String = "En caso de que tenga algún inconveniente con el cobro de la propina, comuníquese 
con la Línea de Atención de la Superintendencia de Industria para que radique su 
queja a los teléfonos: En Bogotá, 6513240, para el resto del país línea gratuita 
nacional: 018000-910165"


    Public VENTAS_DOMICILIO As String
    Public VENTAS_DOMICILIO_ID_VENTA As String
    Public Sub buscar_actualizaciones()
        Try
            sql = "SELECT * FROM actualizaciones where software='MiClickDerecho' and documento='" & comex_nit & "'"
            da_up = New MySqlDataAdapter(sql, conex_miclick)
            dt_up = New DataTable
            da_up.Fill(dt_up)
            For Each row As DataRow In dt_up.Rows
                NuevaVersion = row.Item("version")
                LinkActualizacion = row.Item("link")

            Next
        Catch ex As Exception
            'If ex.ToString.Contains("timeout") = True Then MsgBox("el servidor esta fuera de linea")
            da_up.Dispose()
            dt_up.Dispose()
            conex_miclick.Close()
        End Try
        da_up.Dispose()
        dt_up.Dispose()
        conex_miclick.Close()

    End Sub

    ' PROBAR CONEXION
    Public Sub VERIFICAR_CONEXION_LOCAL()
ini:
        Dim pasw As String = ""
        If castor = "xamp" Then pasw = "Radiobemba"
        If castor = "portable" Then pasw = "Radiobemba"

        conex = New MySqlConnection("data source=" & hostname & "; user id=root; password='" & pasw & "';database=" & db_actual & "; port=" & mi_port & ";Connect Timeout=28800")
        If adn = "c" Then conex = conexRED
        If adn = "n" Then conex = conexCloud
        ESTADO_CONEXION_LOCAL = False
        Try
            conex.Open()
            ESTADO_CONEXION_LOCAL = True
        Catch ex As Exception
            ESTADO_CONEXION_LOCAL = False
            conex.Close()

            If ex.ToString.Contains("Access denied for user") Then


            End If
            If ex.ToString.Contains("Unknown database") Then

            End If


        Finally
            conex.Close()
        End Try



    End Sub


    Public Sub VERIFICAR_CONEXION_REMOTA()
        ESTADO_CONEXION_REMOTA = False

        If My.Computer.Network.IsAvailable() Then
            Try
                If My.Computer.Network.Ping("www.google.com", 1000) Then
                    ESTADO_CONEXION_REMOTA = True
                Else
                    ESTADO_CONEXION_REMOTA = False
                End If
            Catch ex As PingException
                ESTADO_CONEXION_REMOTA = False

            End Try
        Else
            ESTADO_CONEXION_REMOTA = False
        End If
    End Sub

    Public Sub CONSECUTIVOs(ByVal tabla As String)

        consecutivo = 0
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select max(CONS) + 1 from " & tabla & ""
        conex.Open()
        Try
            dr_consecutivos = cmd.ExecuteReader()
            If dr_consecutivos.Read() Then
                consecutivo = dr_consecutivos(0)
            Else
                consecutivo = 1
            End If
        Catch ex As Exception
            consecutivo = 1
            conex.Close()
        End Try
        conex.Close()
    End Sub


    Public Sub load_data_comex(ByVal ITEM As String)
        Try
            sql = "SELECT * FROM data_comex WHERE cons =" & ITEM & ""
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                comex_nit = row.Item("nit")
                comex_DV = row.Item("dv")
                comex_razonsocial = row.Item("razonsocial")
                comex_nombrecomercial = row.Item("nombrecomercial")
                comex_nombrepropietario = row.Item("nombrepropietario")
                comex_sucursal = row.Item("sucursal")
                comex_cels = row.Item("cels")
                comex_tels = row.Item("tels")
                comex_dircomercio = row.Item("dircomercio")
                comex_passmail = row.Item("passmail")
                comex_email = row.Item("emaiL")
                comex_sitioweb = row.Item("sitioweb")
                comex_regimen = row.Item("regimen")
                comex_logo = row.Item("logo")
                logo_empresa = row.Item("logo")
                logo_empresa_imprimir = row.Item("logoimp")
                comex_Resdian = row.Item("resdian")
                comex_fechadian = row.Item("fechadian")
                comex_prefijo = row.Item("prefijo")
                comex_intervalo = row.Item("intervalo")
                comex_intervalo2 = row.Item("intervalofin")
                comex_mesas = row.Item("mesas")
                comex_formatofactura = row.Item("formatofactura")
                comex_listaprecios = row.Item("listaprecios")
                comex_listaprecios2 = row.Item("listaprecios2")
                comex_rotulovendedor = row.Item("rotuloempventas")
                comex_ciudad = row.Item("ciudad")
                'comex_demo = row.Item("DEMO")
                'comex_ini_demo = row.Item("fechademo")
                'comex_fin_demo = row.Item("findemo")
                'comex_licenciatipo = row.Item("LICENCIATIPO")
                'comex_licenciaestado = row.Item("licenciaestado")
                comex_annoactual = row.Item("annoactual")
                comex_metodoinv = row.Item("metodoinv")
                comex_costo = row.Item("costeo")
                comex_fondo = row.Item("fondo")
                comex_propina = row.Item("propina")
                comex_propinavr = row.Item("propinavr")
                comex_salones = row.Item("salones")
                comex_bodega_ventas = row.Item("bodventas")
                comex_bodega_compras = row.Item("bodcompras")
                comex_bodega_produccion = row.Item("bodcompras")
                comex_backups = row.Item("backups")
                comex_buscarpor = row.Item("buscarpor")
                comex_cuenta_cierre = row.Item("cajacierre")
                comex_cuenta_ventas = row.Item("cajaventas")
                comex_balanzacom = row.Item("balanzacom")

                comex_imppos = row.Item("imppos")
                comex_impstandard = row.Item("impstandard")
                comex_impcomanda = row.Item("impcomanda")

            Next
        Catch ex As Exception
            MsgBox("Error al cargar los parameros del comercio. " & Chr(13) & Chr(13) & Strings.Left(ex.Message, 50), vbExclamation)

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


        Try
            sql = "SELECT * FROM data_cloud WHERE cons =1"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                comex_hst = row.Item("data_hst")
                comex_db = row.Item("data_bd")
                comex_usr = row.Item("data_usr")
                comex_psw = row.Item("data_psw")
            Next
        Catch ex As Exception
            MsgBox("Error al cargar los parameros del servicio de nube. " & Chr(13) & Chr(13) & Strings.Left(ex.Message, 50), vbExclamation)

        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()


    End Sub

    Public conex_cloud As New MySqlConnection("data source=" & comex_hst & "; user id=" & comex_usr & "; password='" & comex_psw & "';database=" & comex_db & "; port=3306")

    Public Sub load_data_mediospagos()
        Try
            sql = "SELECT * FROM medios_pago"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            For Each row As DataRow In dt.Rows
                'If row.Item("mediopago") = "EFECTIVO" Then comex_PAGO_efectivo = row.Item("CUENTA") : comex_PAGO_efectivo_nombre = row.Item("nombre")
                'If row.Item("mediopago") = "DATAFONO" Then comex_PAGO_datafono = row.Item("CUENTA") : comex_PAGO_datafono_nombre = row.Item("nombre")
                'If row.Item("mediopago") = "CONSIGNACION" Then comex_PAGO_consignacion = row.Item("CUENTA") : comex_PAGO_consignacion_nombre = row.Item("nombre")
                'If row.Item("mediopago") = "CREDITO" Then comex_PAGO_CREDITO_pagar = row.Item("CUENTA") : comex_PAGO_CREDITO_pagar_nombre = row.Item("nombre")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conex.Close()
        da.Dispose()
        dt.Dispose()

    End Sub

    Public Sub load_databases()
        Try
            sql = "show databases like '%miclickdb%'"
            da_databases = New MySqlDataAdapter(sql, conex)
            dt_databases = New DataTable
            da_databases.Fill(dt_databases)

        Catch ex As Exception
            MsgBox("error al tratar de leer las instancias.", vbExclamation)

        End Try
        conex.Close()
        da_databases.Dispose()
        dt_databases.Dispose()

    End Sub
    Public Sub load_databases_elements()
        Try
            sql = "SHOW FULL TABLES FROM miclickdb"
            da_databasesE = New MySqlDataAdapter(sql, conex)
            dt_databasesE = New DataTable
            da_databasesE.Fill(dt_databasesE)

        Catch ex As Exception
        End Try
        conex.Close()
        da_databasesE.Dispose()
        dt_databasesE.Dispose()
    End Sub



    Public Sub load_permisos_EMPLEADO()
        sql = "SELECT * FROM permisos where CODEMPLEADO=" & CInt(usrcod) & ""
        da = New MySqlDataAdapter(sql, conex)
        dt_permisos = New DataTable
        Try
            da.Fill(dt_permisos)
            For Each row As DataRow In dt_permisos.Rows
                If row.Item("permiso").ToString = "Acceso al Modulo Ventas" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(1) = "SI"
                If row.Item("permiso").ToString = "Acceso al Modulo Inventarios" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(2) = "SI"
                If row.Item("permiso").ToString = "Acceso al Modulo Gastos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(3) = "SI"
                If row.Item("permiso").ToString = "Acceso al Modulo Contactos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(4) = "SI"
                If row.Item("permiso").ToString = "Acceso al Modulo Informes" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(5) = "SI"
                If row.Item("permiso").ToString = "Acceso al Modulo Contabilidad" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(6) = "SI"
                If row.Item("permiso").ToString = "Acceso al Modulo Administración" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(7) = "SI"
                If row.Item("permiso").ToString = "Ver Productos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(8) = "SI"
                If row.Item("permiso").ToString = "Crear Productos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(9) = "SI"
                If row.Item("permiso").ToString = "Modificar Productos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(10) = "SI"
                If row.Item("permiso").ToString = "Eliminar Productos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(11) = "SI"
                If row.Item("permiso").ToString = "Ver Movimientos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(12) = "SI"
                If row.Item("permiso").ToString = "Crear Movimientos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(13) = "SI"
                If row.Item("permiso").ToString = "Modificar Movimientos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(14) = "SI"
                If row.Item("permiso").ToString = "Consultar Bodega" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(15) = "SI"
                If row.Item("permiso").ToString = "Crear Categorias" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(16) = "SI"
                If row.Item("permiso").ToString = "Modificar Categorias" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(17) = "SI"
                If row.Item("permiso").ToString = "Eliminar Categorias" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(18) = "SI"
                If row.Item("permiso").ToString = "Consultar Pedidos a Proveedores" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(19) = "SI"
                If row.Item("permiso").ToString = "Crear Pedidos a Proveedores" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(20) = "SI"
                If row.Item("permiso").ToString = "Modificar Pedidos a Proveedores" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(21) = "SI"
                If row.Item("permiso").ToString = "Eliminar Pedidos a Proveedores" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(22) = "SI"
                If row.Item("permiso").ToString = "Permitir Registrar Gastos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(23) = "SI"
                If row.Item("permiso").ToString = "Permitir Registrar Recibos de Caja" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(24) = "SI"
                If row.Item("permiso").ToString = "Permitir Crear Contactos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(25) = "SI"
                If row.Item("permiso").ToString = "Permitir Crear Contactos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(26) = "SI"
                If row.Item("permiso").ToString = "Permitir Eliminar Contactos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(27) = "SI"
                If row.Item("permiso").ToString = "Acceso al Modulo Cocina" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(28) = "SI"
                If row.Item("permiso").ToString = "Cambiar Precios en las Ventas" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(29) = "SI"
                If row.Item("permiso").ToString = "Consultar Turnos de Caja" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(30) = "SI"
                If row.Item("permiso").ToString = "Consultar Informe Diario" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(31) = "SI"
                If row.Item("permiso").ToString = "Hacer Descuentos" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(32) = "SI"
                If row.Item("permiso").ToString = "Modificar el Precio de Venta" And row.Item("ESTADO").ToString = "SI" Then PERMISO_1(33) = "SI"



                If row.Item("permiso").ToString = "Acceso al Modulo Ventas" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(1) = "NO"
                If row.Item("permiso").ToString = "Acceso al Modulo Inventarios" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(2) = "NO"
                If row.Item("permiso").ToString = "Acceso al Modulo Gastos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(3) = "NO"
                If row.Item("permiso").ToString = "Acceso al Modulo Contactos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(4) = "NO"
                If row.Item("permiso").ToString = "Acceso al Modulo Informes" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(5) = "NO"
                If row.Item("permiso").ToString = "Acceso al Modulo Contabilidad" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(6) = "NO"
                If row.Item("permiso").ToString = "Acceso al Modulo Administración" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(7) = "NO"
                If row.Item("permiso").ToString = "Ver Productos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(8) = "NO"
                If row.Item("permiso").ToString = "Crear Productos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(9) = "NO"
                If row.Item("permiso").ToString = "Modificar Productos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(10) = "NO"
                If row.Item("permiso").ToString = "Eliminar Productos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(11) = "NO"
                If row.Item("permiso").ToString = "Ver Movimientos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(12) = "NO"
                If row.Item("permiso").ToString = "Crear Movimientos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(13) = "NO"
                If row.Item("permiso").ToString = "Modificar Movimientos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(14) = "NO"
                If row.Item("permiso").ToString = "Consultar Bodega" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(15) = "NO"
                If row.Item("permiso").ToString = "Crear Categorias" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(16) = "NO"
                If row.Item("permiso").ToString = "Modificar Categorias" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(17) = "NO"
                If row.Item("permiso").ToString = "Eliminar Categorias" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(18) = "NO"
                If row.Item("permiso").ToString = "Consultar Pedidos a Proveedores" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(19) = "NO"
                If row.Item("permiso").ToString = "Crear Pedidos a Proveedores" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(20) = "NO"
                If row.Item("permiso").ToString = "Modificar Pedidos a Proveedores" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(21) = "NO"
                If row.Item("permiso").ToString = "Eliminar Pedidos a Proveedores" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(22) = "NO"
                If row.Item("permiso").ToString = "Permitir Registrar Gastos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(23) = "NO"
                If row.Item("permiso").ToString = "Permitir Registrar Recibos de Caja" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(24) = "NO"
                If row.Item("permiso").ToString = "Permitir Crear Contactos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(25) = "NO"
                If row.Item("permiso").ToString = "Permitir Crear Contactos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(26) = "NO"
                If row.Item("permiso").ToString = "Permitir Eliminar Contactos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(27) = "NO"
                If row.Item("permiso").ToString = "Acceso al Modulo Cocina" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(28) = "NO"
                If row.Item("permiso").ToString = "Cambiar Precios en las Ventas" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(29) = "NO"
                If row.Item("permiso").ToString = "Consultar Turnos de Caja" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(30) = "NO"
                If row.Item("permiso").ToString = "Consultar Informe Diario" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(31) = "NO"
                If row.Item("permiso").ToString = "Hacer Descuentos" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(32) = "NO"
                If row.Item("permiso").ToString = "Modificar el Precio de Venta" And row.Item("ESTADO").ToString = "NO" Then PERMISO_1(33) = "NO"

            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        'dt_permisos.Dispose()
        conex.Close()
    End Sub

    Public Function geringo(ByVal Input As String) As String

        Try
            Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("goliat17") 'La clave debe ser de 8 caracteres
            Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
            Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
            Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
            des.Key = EncryptionKey
            des.IV = IV

            Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
        Catch ex As Exception

        Finally

        End Try

    End Function
    Public Function geringa(ByVal Input As String) As String
        Try
            Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("goliat17") 'La clave debe ser de 8 caracteres
            Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
            Dim buffer() As Byte = Convert.FromBase64String(Input)
            Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
            des.Key = EncryptionKey
            des.IV = IV
            Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
        Catch ex As Exception

        End Try

    End Function

    Public Sub load_permisos_generales()
        sql = "SELECT * FROM permisos_generales"
        da = New MySqlDataAdapter(sql, conex)
        dt_permisos = New DataTable
        Try
            da.Fill(dt_permisos)
            For Each row As DataRow In dt_permisos.Rows

                If row.Item("permiso").ToString = "Permitir Asignar Ventas" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(1) = "NO"
                If row.Item("permiso").ToString = "Permitir Asignar Ventas" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(1) = "SI"
                If row.Item("permiso").ToString = "Facturar Sin Existencias" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(3) = "NO"
                If row.Item("permiso").ToString = "Facturar Sin Existencias" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(3) = "SI"
                If row.Item("permiso").ToString = "Domicilios" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(4) = "NO"
                If row.Item("permiso").ToString = "Domicilios" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(4) = "SI"
                If row.Item("permiso").ToString = "Responsable de Impuestos" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(5) = "NO"
                If row.Item("permiso").ToString = "Responsable de Impuestos" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(5) = "SI"
                If row.Item("permiso").ToString = "Habilitar Turnos" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(6) = "NO"
                If row.Item("permiso").ToString = "Habilitar Turnos" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(6) = "SI"
                If row.Item("permiso").ToString = "Guardar Facturas" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(7) = "NO"
                If row.Item("permiso").ToString = "Guardar Facturas" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(7) = "SI"
                If row.Item("permiso").ToString = "Permitir Facturar a Mesas" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(8) = "NO"
                If row.Item("permiso").ToString = "Permitir Facturar a Mesas" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(8) = "SI"
                If row.Item("permiso").ToString = "Permitir Descuentos en Ventas Directas" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(9) = "NO"
                If row.Item("permiso").ToString = "Permitir Descuentos en Ventas Directas" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(9) = "SI"
                If row.Item("permiso").ToString = "Habilitar Opciones de Cocina" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(10) = "NO"
                If row.Item("permiso").ToString = "Habilitar Opciones de Cocina" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(10) = "SI"
                If row.Item("permiso").ToString = "Buscar Por Lotes" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(11) = "NO"
                If row.Item("permiso").ToString = "Buscar Por Lotes" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(11) = "SI"
                If row.Item("permiso").ToString = "Modulo de Bienes" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(12) = "NO"
                If row.Item("permiso").ToString = "Modulo de Bienes" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(12) = "SI"
                If row.Item("permiso").ToString = "Modulo de Contratos" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(13) = "NO"
                If row.Item("permiso").ToString = "Modulo de Contratos" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(13) = "SI"
                If row.Item("permiso").ToString = "Propina Predeterminada" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(14) = "NO"
                If row.Item("permiso").ToString = "Propina Predeterminada" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(14) = "SI"
                If row.Item("permiso").ToString = "Imprimir Leyenda Propina" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(15) = "NO"
                If row.Item("permiso").ToString = "Imprimir Leyenda Propina" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(15) = "SI"
                If row.Item("permiso").ToString = "Modulo de Produccion" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(16) = "NO"
                If row.Item("permiso").ToString = "Modulo de Produccion" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(16) = "SI"
                If row.Item("permiso").ToString = "Buscar Actualizaciones" And row.Item("ESTADO").ToString = "NO" Then PERMISO__general(17) = "NO"
                If row.Item("permiso").ToString = "Buscar Actualizaciones" And row.Item("ESTADO").ToString = "SI" Then PERMISO__general(17) = "SI"

            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        da.Dispose()
        'dt_permisos.Dispose()
        conex.Close()

    End Sub

    Public CodMovimientoVer = ""
    Public TipoMovimientoVer = ""

    'turno actual
    Public turno_actual_global, turno_actual_global_ID, turno_actualfecha, turno_actual_inicio, turno_actual_caja, turno_actual_fin, turno_actual_estado, turno_actual_base, turno_actual_global_empleado As String

    Public SERIAL_DD As String
    Public SERIAL_board As String

    Public SERIAL_PROC As String
    Public winver As String = GetWinVersion()

    Public PRIMERA_VEZ, SOY_DEMO As String

    Public lic_vence As String


    ' USUARIO QUE INGRESA AL SISTEA
    Public USR_COD, USR_DOC, USR_NOM, USR_PASS, USR_TIPO As String

    'variables de usuario del sistema
    Public usrnom, usrdoc, usrcod, usrcontact, usrpass, usrtipo, USRCARGO, usrAUTORIZADOR As String
    Public actualizar_mis_datos As Boolean = False
    'variables factura
    Public new_fact_num, new_venta_num, new_venta_num2, new_compra_num As String
    Public fact_saveok As Integer = 0
    Public compra_saveok As Integer = 0


    'VARIABLES PRODUCTO GLOBAL
    Public PROD_COD, PROD_NOMBRE, PROD_categoria, PROD_descripcion, PROD_COD_BAR, PROD_precio_venta, PROD_precio_compra, imagepath, PROD_CANT As String
    Public AUTOLOAD_PROD As String = ""

    Public usar_imagenes, rutaimagenes As String
    Public comex_nit, comex_DV, comex_nombrecomercial, comex_razonsocial, comex_nombrepropietario, comex_propietariodoc, comex_nombrecontador, comex_contadordoc, comex_dircomercio, comex_cels, comex_tels, comex_email, comex_passmail, comex_sitioweb, comex_sucursal, comex_regimen, comex_logo, comex_formatofactura, comex_mesas, comex_salones, comex_annoactual, comex_listaprecios, comex_listaprecios2, comex_ciudad, comex_hst, comex_db, comex_usr, comex_psw As String
    Public comex_fechadian, comex_Resdian, comex_prefijo, comex_intervalo, comex_intervalo2, comex_rotulovendedor, comex_costo As String
    Public logo_empresa_imprimir, logo_empresa As String
    Public comex_parametro_factsinsaldo As Boolean

    ' variables para imprimir la factura venta
    Public que_imprime As String = ""
    Public imp_titulo1, imp_titulo2, imp_dir, imp_tels, imp_propietario, imp_regimen, imp_nit, imp_resdian, imp_intervalo, imp_propina As String
    Public imp_clienteDoc, imp_clienteNom, ImpClienteDir, imp_clienteTel, imp_clientemail, imp_factunum, imp_fecha_factu, imp_hora_factu, imp_prod, imp_cant, imp_vrtotal, imp_totalVenta As String
    Public imp_Descuento, imp_subtotal, Imp_baseimp, imp_impuesto, imp_totalapagar, imp_efectivo, imp_cambio, imp_cajero, imp_mesero, IMP_MEDIODEPAGO, imp_comprobante, imp_puntos As String

    Public CONTINUE_PREVENTA_COD As Integer
    Public CONTINUE_PRECOMPRA_COD As Integer

    Public propina, propinavr As String

    'cliente
    Public venta_cliente_doc, venta_cliente_tipodoc, venta_cliente_dv, venta_cliente_nom, venta_cliente_razonsocial, venta_cliente_tel, venta_cliente_tel2, venta_cliente_dir, venta_cliente_ciudad, venta_cliente_mail, venta_cliente_sitioweb, venta_cliente_naturaleza, venta_cliente_tipocontribuyente, venta_cliente_declarante, venta_cliente_autoretenedor, retefuentecompra, venta_cliente_ruta, venta_cliente_codruta As String
    Public pedido_cliente_doc, pedido_cliente_tipodoc, pedido_cliente_dv, pedido_cliente_nom, pedido_cliente_razonsocial, pedido_cliente_tel, pedido_cliente_tel2, pedido_cliente_dir, pedido_cliente_ciudad, pedido_cliente_mail, pedido_cliente_sitioweb, pedido_cliente_naturaleza, pedido_cliente_tipocontribuyente, pedido_cliente_declarante, pedido_cliente_autoretenedor As String

    'cliente
    Public COMPRA_PROV_doc, COMPRA_PROV_nom, COMPRA_PROV_tel, COMPRA_PROV_dir As String

    'PERMISOS
    Public PERMISO_1(99) As String
    Public PERMISO__general(99) As String

    Public ID_VENTA_VER As String
    Public ID_compra_VER As String
    Public ID_gasto_VER As String
    Public ID_rc_VER As String

    Public id_dom_impr As String

    Public ID_VENTA_dev As String
    Public ID_comprA_dev As String

    Public id_devolucion As String
    Public tipo_devolucion As String

    Dim rutamiapp As String = My.Application.Info.DirectoryPath
    Public f_solicitante As Form


    Public ver_cxc As String
    Public ver_cxp As String







End Module