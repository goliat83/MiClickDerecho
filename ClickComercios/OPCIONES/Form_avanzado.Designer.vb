<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_avanzado
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_avanzado))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Button_restore = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ComboBox_tablas = New System.Windows.Forms.ComboBox()
        Me.BTN_elim_tabla = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button_procesar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.OpenFileDialog_mail = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label_info = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BackgroundWorker_up_do = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_cerrar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage3.SuspendLayout()
        Me.MetroTabPage4.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold
        Me.MetroTabControl1.Location = New System.Drawing.Point(13, 47)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(922, 460)
        Me.MetroTabControl1.TabIndex = 505
        Me.MetroTabControl1.UseCustomBackColor = True
        Me.MetroTabControl1.UseCustomForeColor = True
        Me.MetroTabControl1.UseSelectable = True
        Me.MetroTabControl1.UseStyleColors = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.cuadro_blanco
        Me.MetroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroTabPage1.Controls.Add(Me.Button_restore)
        Me.MetroTabPage1.Controls.Add(Me.Button16)
        Me.MetroTabPage1.Controls.Add(Me.Button1)
        Me.MetroTabPage1.Controls.Add(Me.Button11)
        Me.MetroTabPage1.Controls.Add(Me.Button6)
        Me.MetroTabPage1.Controls.Add(Me.Button9)
        Me.MetroTabPage1.Controls.Add(Me.ComboBox_tablas)
        Me.MetroTabPage1.Controls.Add(Me.BTN_elim_tabla)
        Me.MetroTabPage1.Controls.Add(Me.Label13)
        Me.MetroTabPage1.Controls.Add(Me.DataGridView2)
        Me.MetroTabPage1.Controls.Add(Me.Button14)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(914, 418)
        Me.MetroTabPage1.TabIndex = 2
        Me.MetroTabPage1.Text = "    Información    "
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'Button_restore
        '
        Me.Button_restore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_restore.BackColor = System.Drawing.Color.Transparent
        Me.Button_restore.BackgroundImage = CType(resources.GetObject("Button_restore.BackgroundImage"), System.Drawing.Image)
        Me.Button_restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_restore.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_restore.FlatAppearance.BorderSize = 0
        Me.Button_restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_restore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_restore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_restore.ForeColor = System.Drawing.Color.White
        Me.Button_restore.Location = New System.Drawing.Point(338, 376)
        Me.Button_restore.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.Button_restore.Name = "Button_restore"
        Me.Button_restore.Size = New System.Drawing.Size(195, 31)
        Me.Button_restore.TabIndex = 508
        Me.Button_restore.Text = "Restaurar Copia de Seguridad"
        Me.Button_restore.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button16.BackColor = System.Drawing.Color.Transparent
        Me.Button16.BackgroundImage = CType(resources.GetObject("Button16.BackgroundImage"), System.Drawing.Image)
        Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button16.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.White
        Me.Button16.Location = New System.Drawing.Point(419, 45)
        Me.Button16.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(110, 29)
        Me.Button16.TabIndex = 645
        Me.Button16.Text = "Ver datos"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(21, 376)
        Me.Button1.Margin = New System.Windows.Forms.Padding(10, 30, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 31)
        Me.Button1.TabIndex = 526
        Me.Button1.Text = "Permisos Generales"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(175, 376)
        Me.Button11.Margin = New System.Windows.Forms.Padding(10, 30, 3, 3)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(150, 31)
        Me.Button11.TabIndex = 527
        Me.Button11.Text = "Permisos Empleados"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(781, 45)
        Me.Button6.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(110, 29)
        Me.Button6.TabIndex = 520
        Me.Button6.Text = "Importar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(658, 46)
        Me.Button9.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(110, 29)
        Me.Button9.TabIndex = 521
        Me.Button9.Text = "Exportar"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'ComboBox_tablas
        '
        Me.ComboBox_tablas.AutoCompleteCustomSource.AddRange(New String() {"MEDELLIN - ANTIOQUIA", "ABEJORRAL - ANTIOQUIA", "ABRIAQUI - ANTIOQUIA", "ALEJANDRIA - ANTIOQUIA", "AMAGA - ANTIOQUIA", "AMALFI - ANTIOQUIA", "ANDES - ANTIOQUIA", "ANGELOPOLIS - ANTIOQUIA", "ANGOSTURA - ANTIOQUIA", "ANORI - ANTIOQUIA", "SANTAFE DE ANTIOQUIA - ANTIOQUIA", "ANZA - ANTIOQUIA", "APARTADO - ANTIOQUIA", "ARBOLETES - ANTIOQUIA", "ARGELIA - ANTIOQUIA", "ARMENIA - ANTIOQUIA", "BARBOSA - ANTIOQUIA", "BELMIRA - ANTIOQUIA", "BELLO - ANTIOQUIA", "BETANIA - ANTIOQUIA", "BETULIA - ANTIOQUIA", "CIUDAD BOLIVAR - ANTIOQUIA", "BRICEÑO - ANTIOQUIA", "BURITICA - ANTIOQUIA", "CACERES - ANTIOQUIA", "CAICEDO - ANTIOQUIA", "CALDAS - ANTIOQUIA", "CAMPAMENTO - ANTIOQUIA", "CAÑASGORDAS - ANTIOQUIA", "CARACOLI - ANTIOQUIA", "CARAMANTA - ANTIOQUIA", "CAREPA - ANTIOQUIA", "EL CARMEN DE VIBORAL - ANTIOQUIA", "CAROLINA - ANTIOQUIA", "CAUCASIA - ANTIOQUIA", "CHIGORODO - ANTIOQUIA", "CISNEROS - ANTIOQUIA", "COCORNA - ANTIOQUIA", "CONCEPCION - ANTIOQUIA", "CONCORDIA - ANTIOQUIA", "COPACABANA - ANTIOQUIA", "DABEIBA - ANTIOQUIA", "DON MATIAS - ANTIOQUIA", "EBEJICO - ANTIOQUIA", "EL BAGRE - ANTIOQUIA", "ENTRERRIOS - ANTIOQUIA", "ENVIGADO - ANTIOQUIA", "FREDONIA - ANTIOQUIA", "FRONTINO - ANTIOQUIA", "GIRALDO - ANTIOQUIA", "GIRARDOTA - ANTIOQUIA", "GOMEZ PLATA - ANTIOQUIA", "GRANADA - ANTIOQUIA", "GUADALUPE - ANTIOQUIA", "GUARNE - ANTIOQUIA", "GUATAPE - ANTIOQUIA", "HELICONIA - ANTIOQUIA", "HISPANIA - ANTIOQUIA", "ITAGUI - ANTIOQUIA", "ITUANGO - ANTIOQUIA", "JARDIN - ANTIOQUIA", "JERICO - ANTIOQUIA", "LA CEJA - ANTIOQUIA", "LA ESTRELLA - ANTIOQUIA", "LA PINTADA - ANTIOQUIA", "LA UNION - ANTIOQUIA", "LIBORINA - ANTIOQUIA", "MACEO - ANTIOQUIA", "MARINILLA - ANTIOQUIA", "MONTEBELLO - ANTIOQUIA", "MURINDO - ANTIOQUIA", "MUTATA - ANTIOQUIA", "NARIÑO - ANTIOQUIA", "NECOCLI - ANTIOQUIA", "NECHI - ANTIOQUIA", "OLAYA - ANTIOQUIA", "PEÐOL - ANTIOQUIA", "PEQUE - ANTIOQUIA", "PUEBLORRICO - ANTIOQUIA", "PUERTO BERRIO - ANTIOQUIA", "PUERTO NARE - ANTIOQUIA", "PUERTO TRIUNFO - ANTIOQUIA", "REMEDIOS - ANTIOQUIA", "RETIRO - ANTIOQUIA", "RIONEGRO - ANTIOQUIA", "SABANALARGA - ANTIOQUIA", "SABANETA - ANTIOQUIA", "SALGAR - ANTIOQUIA", "SAN ANDRES DE CUERQUIA - ANTIOQUIA", "SAN CARLOS - ANTIOQUIA", "SAN FRANCISCO - ANTIOQUIA", "SAN JERONIMO - ANTIOQUIA", "SAN JOSE DE LA MONTAÑA - ANTIOQUIA", "SAN JUAN DE URABA - ANTIOQUIA", "SAN LUIS - ANTIOQUIA", "SAN PEDRO - ANTIOQUIA", "SAN PEDRO DE URABA - ANTIOQUIA", "SAN RAFAEL - ANTIOQUIA", "SAN ROQUE - ANTIOQUIA", "SAN VICENTE - ANTIOQUIA", "SANTA BARBARA - ANTIOQUIA", "SANTA ROSA DE OSOS - ANTIOQUIA", "SANTO DOMINGO - ANTIOQUIA", "EL SANTUARIO - ANTIOQUIA", "SEGOVIA - ANTIOQUIA", "SONSON - ANTIOQUIA", "SOPETRAN - ANTIOQUIA", "TAMESIS - ANTIOQUIA", "TARAZA - ANTIOQUIA", "TARSO - ANTIOQUIA", "TITIRIBI - ANTIOQUIA", "TOLEDO - ANTIOQUIA", "TURBO - ANTIOQUIA", "URAMITA - ANTIOQUIA", "URRAO - ANTIOQUIA", "VALDIVIA - ANTIOQUIA", "VALPARAISO - ANTIOQUIA", "VEGACHI - ANTIOQUIA", "VENECIA - ANTIOQUIA", "VIGIA DEL FUERTE - ANTIOQUIA", "YALI - ANTIOQUIA", "YARUMAL - ANTIOQUIA", "YOLOMBO - ANTIOQUIA", "YONDO - ANTIOQUIA", "ZARAGOZA - ANTIOQUIA", "BARRANQUILLA - ATLANTICO", "BARANOA - ATLANTICO", "CAMPO DE LA CRUZ - ATLANTICO", "CANDELARIA - ATLANTICO", "GALAPA - ATLANTICO", "JUAN DE ACOSTA - ATLANTICO", "LURUACO - ATLANTICO", "MALAMBO - ATLANTICO", "MANATI - ATLANTICO", "PALMAR DE VARELA - ATLANTICO", "PIOJO - ATLANTICO", "POLONUEVO - ATLANTICO", "PONEDERA - ATLANTICO", "PUERTO COLOMBIA - ATLANTICO", "REPELON - ATLANTICO", "SABANAGRANDE - ATLANTICO", "SABANALARGA - ATLANTICO", "SANTA LUCIA - ATLANTICO", "SANTO TOMAS - ATLANTICO", "SOLEDAD - ATLANTICO", "SUAN - ATLANTICO", "TUBARA - ATLANTICO", "USIACURI - ATLANTICO", "BOGOTA, D.C. - BOGOTA", "CARTAGENA - BOLIVAR", "ACHI - BOLIVAR", "ALTOS DEL ROSARIO - BOLIVAR", "ARENAL - BOLIVAR", "ARJONA - BOLIVAR", "ARROYOHONDO - BOLIVAR", "BARRANCO DE LOBA - BOLIVAR", "CALAMAR - BOLIVAR", "CANTAGALLO - BOLIVAR", "CICUCO - BOLIVAR", "CORDOBA - BOLIVAR", "CLEMENCIA - BOLIVAR", "EL CARMEN DE BOLIVAR - BOLIVAR", "EL GUAMO - BOLIVAR", "EL PEÑON - BOLIVAR", "HATILLO DE LOBA - BOLIVAR", "MAGANGUE - BOLIVAR", "MAHATES - BOLIVAR", "MARGARITA - BOLIVAR", "MARIA LA BAJA - BOLIVAR", "MONTECRISTO - BOLIVAR", "MOMPOS - BOLIVAR", "NOROSI - BOLIVAR", "MORALES - BOLIVAR", "PINILLOS - BOLIVAR", "REGIDOR - BOLIVAR", "RIO VIEJO - BOLIVAR", "SAN CRISTOBAL - BOLIVAR", "SAN ESTANISLAO - BOLIVAR", "SAN FERNANDO - BOLIVAR", "SAN JACINTO - BOLIVAR", "SAN JACINTO DEL CAUCA - BOLIVAR", "SAN JUAN NEPOMUCENO - BOLIVAR", "SAN MARTIN DE LOBA - BOLIVAR", "SAN PABLO - BOLIVAR", "SANTA CATALINA - BOLIVAR", "SANTA ROSA - BOLIVAR", "SANTA ROSA DEL SUR - BOLIVAR", "SIMITI - BOLIVAR", "SOPLAVIENTO - BOLIVAR", "TALAIGUA NUEVO - BOLIVAR", "TIQUISIO - BOLIVAR", "TURBACO - BOLIVAR", "TURBANA - BOLIVAR", "VILLANUEVA - BOLIVAR", "ZAMBRANO - BOLIVAR", "TUNJA - BOYACA", "ALMEIDA - BOYACA", "AQUITANIA - BOYACA", "ARCABUCO - BOYACA", "BELEN - BOYACA", "BERBEO - BOYACA", "BETEITIVA - BOYACA", "BOAVITA - BOYACA", "BOYACA - BOYACA", "BRICEÑO - BOYACA", "BUENAVISTA - BOYACA", "BUSBANZA - BOYACA", "CALDAS - BOYACA", "CAMPOHERMOSO - BOYACA", "CERINZA - BOYACA", "CHINAVITA - BOYACA", "CHIQUINQUIRA - BOYACA", "CHISCAS - BOYACA", "CHITA - BOYACA", "CHITARAQUE - BOYACA", "CHIVATA - BOYACA", "CIENEGA - BOYACA", "COMBITA - BOYACA", "COPER - BOYACA", "CORRALES - BOYACA", "COVARACHIA - BOYACA", "CUBARA - BOYACA", "CUCAITA - BOYACA", "CUITIVA - BOYACA", "CHIQUIZA - BOYACA", "CHIVOR - BOYACA", "DUITAMA - BOYACA", "EL COCUY - BOYACA", "EL ESPINO - BOYACA", "FIRAVITOBA - BOYACA", "FLORESTA - BOYACA", "GACHANTIVA - BOYACA", "GAMEZA - BOYACA", "GARAGOA - BOYACA", "GUACAMAYAS - BOYACA", "GUATEQUE - BOYACA", "GUAYATA - BOYACA", "GsICAN - BOYACA", "IZA - BOYACA", "JENESANO - BOYACA", "JERICO - BOYACA", "LABRANZAGRANDE - BOYACA", "LA CAPILLA - BOYACA", "LA VICTORIA - BOYACA", "LA UVITA - BOYACA", "VILLA DE LEYVA - BOYACA", "MACANAL - BOYACA", "MARIPI - BOYACA", "MIRAFLORES - BOYACA", "MONGUA - BOYACA", "MONGUI - BOYACA", "MONIQUIRA - BOYACA", "MOTAVITA - BOYACA", "MUZO - BOYACA", "NOBSA - BOYACA", "NUEVO COLON - BOYACA", "OICATA - BOYACA", "OTANCHE - BOYACA", "PACHAVITA - BOYACA", "PAEZ - BOYACA", "PAIPA - BOYACA", "PAJARITO - BOYACA", "PANQUEBA - BOYACA", "PAUNA - BOYACA", "PAYA - BOYACA", "PAZ DE RIO - BOYACA", "PESCA - BOYACA", "PISBA - BOYACA", "PUERTO BOYACA - BOYACA", "QUIPAMA - BOYACA", "RAMIRIQUI - BOYACA", "RAQUIRA - BOYACA", "RONDON - BOYACA", "SABOYA - BOYACA", "SACHICA - BOYACA", "SAMACA - BOYACA", "SAN EDUARDO - BOYACA", "SAN JOSE DE PARE - BOYACA", "SAN LUIS DE GACENO - BOYACA", "SAN MATEO - BOYACA", "SAN MIGUEL DE SEMA - BOYACA", "SAN PABLO DE BORBUR - BOYACA", "SANTANA - BOYACA", "SANTA MARIA - BOYACA", "SANTA ROSA DE VITERBO - BOYACA", "SANTA SOFIA - BOYACA", "SATIVANORTE - BOYACA", "SATIVASUR - BOYACA", "SIACHOQUE - BOYACA", "SOATA - BOYACA", "SOCOTA - BOYACA", "SOCHA - BOYACA", "SOGAMOSO - BOYACA", "SOMONDOCO - BOYACA", "SORA - BOYACA", "SOTAQUIRA - BOYACA", "SORACA - BOYACA", "SUSACON - BOYACA", "SUTAMARCHAN - BOYACA", "SUTATENZA - BOYACA", "TASCO - BOYACA", "TENZA - BOYACA", "TIBANA - BOYACA", "TIBASOSA - BOYACA", "TINJACA - BOYACA", "TIPACOQUE - BOYACA", "TOCA - BOYACA", "TOGsI - BOYACA", "TOPAGA - BOYACA", "TOTA - BOYACA", "TUNUNGUA - BOYACA", "TURMEQUE - BOYACA", "TUTA - BOYACA", "TUTAZA - BOYACA", "UMBITA - BOYACA", "VENTAQUEMADA - BOYACA", "VIRACACHA - BOYACA", "ZETAQUIRA - BOYACA", "MANIZALES - CALDAS", "AGUADAS - CALDAS", "ANSERMA - CALDAS", "ARANZAZU - CALDAS", "BELALCAZAR - CALDAS", "CHINCHINA - CALDAS", "FILADELFIA - CALDAS", "LA DORADA - CALDAS", "LA MERCED - CALDAS", "MANZANARES - CALDAS", "MARMATO - CALDAS", "MARQUETALIA - CALDAS", "MARULANDA - CALDAS", "NEIRA - CALDAS", "NORCASIA - CALDAS", "PACORA - CALDAS", "PALESTINA - CALDAS", "PENSILVANIA - CALDAS", "RIOSUCIO - CALDAS", "RISARALDA - CALDAS", "SALAMINA - CALDAS", "SAMANA - CALDAS", "SAN JOSE - CALDAS", "SUPIA - CALDAS", "VICTORIA - CALDAS", "VILLAMARIA - CALDAS", "VITERBO - CALDAS", "FLORENCIA - CAQUETA", "ALBANIA - CAQUETA", "BELEN DE LOS ANDAQUIES - CAQUETA", "CARTAGENA DEL CHAIRA - CAQUETA", "CURILLO - CAQUETA", "EL DONCELLO - CAQUETA", "EL PAUJIL - CAQUETA", "LA MONTAÑITA - CAQUETA", "MILAN - CAQUETA", "MORELIA - CAQUETA", "PUERTO RICO - CAQUETA", "SAN JOSE DEL FRAGUA - CAQUETA", "SAN VICENTE DEL CAGUAN - CAQUETA", "SOLANO - CAQUETA", "SOLITA - CAQUETA", "VALPARAISO - CAQUETA", "POPAYAN - CAUCA", "ALMAGUER - CAUCA", "ARGELIA - CAUCA", "BALBOA - CAUCA", "BOLIVAR - CAUCA", "BUENOS AIRES - CAUCA", "CAJIBIO - CAUCA", "CALDONO - CAUCA", "CALOTO - CAUCA", "CORINTO - CAUCA", "EL TAMBO - CAUCA", "FLORENCIA - CAUCA", "GUACHENE - CAUCA", "GUAPI - CAUCA", "INZA - CAUCA", "JAMBALO - CAUCA", "LA SIERRA - CAUCA", "LA VEGA - CAUCA", "LOPEZ - CAUCA", "MERCADERES - CAUCA", "MIRANDA - CAUCA", "MORALES - CAUCA", "PADILLA - CAUCA", "PAEZ - CAUCA", "PATIA - CAUCA", "PIAMONTE - CAUCA", "PIENDAMO - CAUCA", "PUERTO TEJADA - CAUCA", "PURACE - CAUCA", "ROSAS - CAUCA", "SAN SEBASTIAN - CAUCA", "SANTANDER DE QUILICHAO - CAUCA", "SANTA ROSA - CAUCA", "SILVIA - CAUCA", "SOTARA - CAUCA", "SUAREZ - CAUCA", "SUCRE - CAUCA", "TIMBIO - CAUCA", "TIMBIQUI - CAUCA", "TORIBIO - CAUCA", "TOTORO - CAUCA", "VILLA RICA - CAUCA", "VALLEDUPAR - CESAR", "AGUACHICA - CESAR", "AGUSTIN CODAZZI - CESAR", "ASTREA - CESAR", "BECERRIL - CESAR", "BOSCONIA - CESAR", "CHIMICHAGUA - CESAR", "CHIRIGUANA - CESAR", "CURUMANI - CESAR", "EL COPEY - CESAR", "EL PASO - CESAR", "GAMARRA - CESAR", "GONZALEZ - CESAR", "LA GLORIA - CESAR", "LA JAGUA DE IBIRICO - CESAR", "MANAURE - CESAR", "PAILITAS - CESAR", "PELAYA - CESAR", "PUEBLO BELLO - CESAR", "RIO DE ORO - CESAR", "LA PAZ - CESAR", "SAN ALBERTO - CESAR", "SAN DIEGO - CESAR", "SAN MARTIN - CESAR", "TAMALAMEQUE - CESAR", "MONTERIA - CORDOBA", "AYAPEL - CORDOBA", "BUENAVISTA - CORDOBA", "CANALETE - CORDOBA", "CERETE - CORDOBA", "CHIMA - CORDOBA", "CHINU - CORDOBA", "CIENAGA DE ORO - CORDOBA", "COTORRA - CORDOBA", "LA APARTADA - CORDOBA", "LORICA - CORDOBA", "LOS CORDOBAS - CORDOBA", "MOMIL - CORDOBA", "MONTELIBANO - CORDOBA", "MOÑITOS - CORDOBA", "PLANETA RICA - CORDOBA", "PUEBLO NUEVO - CORDOBA", "PUERTO ESCONDIDO - CORDOBA", "PUERTO LIBERTADOR - CORDOBA", "PURISIMA - CORDOBA", "SAHAGUN - CORDOBA", "SAN ANDRES SOTAVENTO - CORDOBA", "SAN ANTERO - CORDOBA", "SAN BERNARDO DEL VIENTO - CORDOBA", "SAN CARLOS - CORDOBA", "SAN PELAYO - CORDOBA", "TIERRALTA - CORDOBA", "VALENCIA - CORDOBA", "AGUA DE DIOS - CUNDINAMARCA", "ALBAN - CUNDINAMARCA", "ANAPOIMA - CUNDINAMARCA", "ANOLAIMA - CUNDINAMARCA", "ARBELAEZ - CUNDINAMARCA", "BELTRAN - CUNDINAMARCA", "BITUIMA - CUNDINAMARCA", "BOJACA - CUNDINAMARCA", "CABRERA - CUNDINAMARCA", "CACHIPAY - CUNDINAMARCA", "CAJICA - CUNDINAMARCA", "CAPARRAPI - CUNDINAMARCA", "CAQUEZA - CUNDINAMARCA", "CARMEN DE CARUPA - CUNDINAMARCA", "CHAGUANI - CUNDINAMARCA", "CHIA - CUNDINAMARCA", "CHIPAQUE - CUNDINAMARCA", "CHOACHI - CUNDINAMARCA", "CHOCONTA - CUNDINAMARCA", "COGUA - CUNDINAMARCA", "COTA - CUNDINAMARCA", "CUCUNUBA - CUNDINAMARCA", "EL COLEGIO - CUNDINAMARCA", "EL PEÑON - CUNDINAMARCA", "EL ROSAL - CUNDINAMARCA", "FACATATIVA - CUNDINAMARCA", "FOMEQUE - CUNDINAMARCA", "FOSCA - CUNDINAMARCA", "FUNZA - CUNDINAMARCA", "FUQUENE - CUNDINAMARCA", "FUSAGASUGA - CUNDINAMARCA", "GACHALA - CUNDINAMARCA", "GACHANCIPA - CUNDINAMARCA", "GACHETA - CUNDINAMARCA", "GAMA - CUNDINAMARCA", "GIRARDOT - CUNDINAMARCA", "GRANADA - CUNDINAMARCA", "GUACHETA - CUNDINAMARCA", "GUADUAS - CUNDINAMARCA", "GUASCA - CUNDINAMARCA", "GUATAQUI - CUNDINAMARCA", "GUATAVITA - CUNDINAMARCA", "GUAYABAL DE SIQUIMA - CUNDINAMARCA", "GUAYABETAL - CUNDINAMARCA", "GUTIERREZ - CUNDINAMARCA", "JERUSALEN - CUNDINAMARCA", "JUNIN - CUNDINAMARCA", "LA CALERA - CUNDINAMARCA", "LA MESA - CUNDINAMARCA", "LA PALMA - CUNDINAMARCA", "LA PEÑA - CUNDINAMARCA", "LA VEGA - CUNDINAMARCA", "LENGUAZAQUE - CUNDINAMARCA", "MACHETA - CUNDINAMARCA", "MADRID - CUNDINAMARCA", "MANTA - CUNDINAMARCA", "MEDINA - CUNDINAMARCA", "MOSQUERA - CUNDINAMARCA", "NARIÑO - CUNDINAMARCA", "NEMOCON - CUNDINAMARCA", "NILO - CUNDINAMARCA", "NIMAIMA - CUNDINAMARCA", "NOCAIMA - CUNDINAMARCA", "VENECIA - CUNDINAMARCA", "PACHO - CUNDINAMARCA", "PAIME - CUNDINAMARCA", "PANDI - CUNDINAMARCA", "PARATEBUENO - CUNDINAMARCA", "PASCA - CUNDINAMARCA", "PUERTO SALGAR - CUNDINAMARCA", "PULI - CUNDINAMARCA", "QUEBRADANEGRA - CUNDINAMARCA", "QUETAME - CUNDINAMARCA", "QUIPILE - CUNDINAMARCA", "APULO - CUNDINAMARCA", "RICAURTE - CUNDINAMARCA", "SAN ANTONIO DEL TEQUENDAMA - CUNDINAMARCA", "SAN BERNARDO - CUNDINAMARCA", "SAN CAYETANO - CUNDINAMARCA", "SAN FRANCISCO - CUNDINAMARCA", "SAN JUAN DE RIO SECO - CUNDINAMARCA", "SASAIMA - CUNDINAMARCA", "SESQUILE - CUNDINAMARCA", "SIBATE - CUNDINAMARCA", "SILVANIA - CUNDINAMARCA", "SIMIJACA - CUNDINAMARCA", "SOACHA - CUNDINAMARCA", "SOPO - CUNDINAMARCA", "SUBACHOQUE - CUNDINAMARCA", "SUESCA - CUNDINAMARCA", "SUPATA - CUNDINAMARCA", "SUSA - CUNDINAMARCA", "SUTATAUSA - CUNDINAMARCA", "TABIO - CUNDINAMARCA", "TAUSA - CUNDINAMARCA", "TENA - CUNDINAMARCA", "TENJO - CUNDINAMARCA", "TIBACUY - CUNDINAMARCA", "TIBIRITA - CUNDINAMARCA", "TOCAIMA - CUNDINAMARCA", "TOCANCIPA - CUNDINAMARCA", "TOPAIPI - CUNDINAMARCA", "UBALA - CUNDINAMARCA", "UBAQUE - CUNDINAMARCA", "VILLA DE SAN DIEGO DE UBATE - CUNDINAMARCA", "UNE - CUNDINAMARCA", "UTICA - CUNDINAMARCA", "VERGARA - CUNDINAMARCA", "VIANI - CUNDINAMARCA", "VILLAGOMEZ - CUNDINAMARCA", "VILLAPINZON - CUNDINAMARCA", "VILLETA - CUNDINAMARCA", "VIOTA - CUNDINAMARCA", "YACOPI - CUNDINAMARCA", "ZIPACON - CUNDINAMARCA", "ZIPAQUIRA - CUNDINAMARCA", "QUIBDO - CHOCO", "ACANDI - CHOCO", "ALTO BAUDO - CHOCO", "ATRATO - CHOCO", "BAGADO - CHOCO", "BAHIA SOLANO - CHOCO", "BAJO BAUDO - CHOCO", "BOJAYA - CHOCO", "EL CANTON DEL SAN PABLO - CHOCO", "CARMEN DEL DARIEN - CHOCO", "CERTEGUI - CHOCO", "CONDOTO - CHOCO", "EL CARMEN DE ATRATO - CHOCO", "EL LITORAL DEL SAN JUAN - CHOCO", "ISTMINA - CHOCO", "JURADO - CHOCO", "LLORO - CHOCO", "MEDIO ATRATO - CHOCO", "MEDIO BAUDO - CHOCO", "MEDIO SAN JUAN - CHOCO", "NOVITA - CHOCO", "NUQUI - CHOCO", "RIO IRO - CHOCO", "RIO QUITO - CHOCO", "RIOSUCIO - CHOCO", "SAN JOSE DEL PALMAR - CHOCO", "SIPI - CHOCO", "TADO - CHOCO", "UNGUIA - CHOCO", "UNION PANAMERICANA - CHOCO", "NEIVA - HUILA", "ACEVEDO - HUILA", "AGRADO - HUILA", "AIPE - HUILA", "ALGECIRAS - HUILA", "ALTAMIRA - HUILA", "BARAYA - HUILA", "CAMPOALEGRE - HUILA", "COLOMBIA - HUILA", "ELIAS - HUILA", "GARZON - HUILA", "GIGANTE - HUILA", "GUADALUPE - HUILA", "HOBO - HUILA", "IQUIRA - HUILA", "ISNOS - HUILA", "LA ARGENTINA - HUILA", "LA PLATA - HUILA", "NATAGA - HUILA", "OPORAPA - HUILA", "PAICOL - HUILA", "PALERMO - HUILA", "PALESTINA - HUILA", "PITAL - HUILA", "PITALITO - HUILA", "RIVERA - HUILA", "SALADOBLANCO - HUILA", "SAN AGUSTIN - HUILA", "SANTA MARIA - HUILA", "SUAZA - HUILA", "TARQUI - HUILA", "TESALIA - HUILA", "TELLO - HUILA", "TERUEL - HUILA", "TIMANA - HUILA", "VILLAVIEJA - HUILA", "YAGUARA - HUILA", "RIOHACHA - LA GUAJIRA", "ALBANIA - LA GUAJIRA", "BARRANCAS - LA GUAJIRA", "DIBULLA - LA GUAJIRA", "DISTRACCION - LA GUAJIRA", "EL MOLINO - LA GUAJIRA", "FONSECA - LA GUAJIRA", "HATONUEVO - LA GUAJIRA", "LA JAGUA DEL PILAR - LA GUAJIRA", "MAICAO - LA GUAJIRA", "MANAURE - LA GUAJIRA", "SAN JUAN DEL CESAR - LA GUAJIRA", "URIBIA - LA GUAJIRA", "URUMITA - LA GUAJIRA", "VILLANUEVA - LA GUAJIRA", "SANTA MARTA - MAGDALENA", "ALGARROBO - MAGDALENA", "ARACATACA - MAGDALENA", "ARIGUANI - MAGDALENA", "CERRO SAN ANTONIO - MAGDALENA", "CHIBOLO - MAGDALENA", "CIENAGA - MAGDALENA", "CONCORDIA - MAGDALENA", "EL BANCO - MAGDALENA", "EL PIÑON - MAGDALENA", "EL RETEN - MAGDALENA", "FUNDACION - MAGDALENA", "GUAMAL - MAGDALENA", "NUEVA GRANADA - MAGDALENA", "PEDRAZA - MAGDALENA", "PIJIÑO DEL CARMEN - MAGDALENA", "PIVIJAY - MAGDALENA", "PLATO - MAGDALENA", "PUEBLOVIEJO - MAGDALENA", "REMOLINO - MAGDALENA", "SABANAS DE SAN ANGEL - MAGDALENA", "SALAMINA - MAGDALENA", "SAN SEBASTIAN DE BUENAVISTA - MAGDALENA", "SAN ZENON - MAGDALENA", "SANTA ANA - MAGDALENA", "SANTA BARBARA DE PINTO - MAGDALENA", "SITIONUEVO - MAGDALENA", "TENERIFE - MAGDALENA", "ZAPAYAN - MAGDALENA", "ZONA BANANERA - MAGDALENA", "VILLAVICENCIO - META", "ACACIAS - META", "BARRANCA DE UPIA - META", "CABUYARO - META", "CASTILLA LA NUEVA - META", "CUBARRAL - META", "CUMARAL - META", "EL CALVARIO - META", "EL CASTILLO - META", "EL DORADO - META", "FUENTE DE ORO - META", "GRANADA - META", "GUAMAL - META", "MAPIRIPAN - META", "MESETAS - META", "LA MACARENA - META", "URIBE - META", "LEJANIAS - META", "PUERTO CONCORDIA - META", "PUERTO GAITAN - META", "PUERTO LOPEZ - META", "PUERTO LLERAS - META", "PUERTO RICO - META", "RESTREPO - META", "SAN CARLOS DE GUAROA - META", "SAN JUAN DE ARAMA - META", "SAN JUANITO - META", "SAN MARTIN - META", "VISTAHERMOSA - META", "PASTO - NARIÑO", "ALBAN - NARIÑO", "ALDANA - NARIÑO", "ANCUYA - NARIÑO", "ARBOLEDA - NARIÑO", "BARBACOAS - NARIÑO", "BELEN - NARIÑO", "BUESACO - NARIÑO", "COLON - NARIÑO", "CONSACA - NARIÑO", "CONTADERO - NARIÑO", "CORDOBA - NARIÑO", "CUASPUD - NARIÑO", "CUMBAL - NARIÑO", "CUMBITARA - NARIÑO", "CHACHAGsI - NARIÑO", "EL CHARCO - NARIÑO", "EL PEÑOL - NARIÑO", "EL ROSARIO - NARIÑO", "EL TABLON DE GOMEZ - NARIÑO", "EL TAMBO - NARIÑO", "FUNES - NARIÑO", "GUACHUCAL - NARIÑO", "GUAITARILLA - NARIÑO", "GUALMATAN - NARIÑO", "ILES - NARIÑO", "IMUES - NARIÑO", "IPIALES - NARIÑO", "LA CRUZ - NARIÑO", "LA FLORIDA - NARIÑO", "LA LLANADA - NARIÑO", "LA TOLA - NARIÑO", "LA UNION - NARIÑO", "LEIVA - NARIÑO", "LINARES - NARIÑO", "LOS ANDES - NARIÑO", "MAGsI - NARIÑO", "MALLAMA - NARIÑO", "MOSQUERA - NARIÑO", "NARIÑO - NARIÑO", "OLAYA HERRERA - NARIÑO", "OSPINA - NARIÑO", "FRANCISCO PIZARRO - NARIÑO", "POLICARPA - NARIÑO", "POTOSI - NARIÑO", "PROVIDENCIA - NARIÑO", "PUERRES - NARIÑO", "PUPIALES - NARIÑO", "RICAURTE - NARIÑO", "ROBERTO PAYAN - NARIÑO", "SAMANIEGO - NARIÑO", "SANDONA - NARIÑO", "SAN BERNARDO - NARIÑO", "SAN LORENZO - NARIÑO", "SAN PABLO - NARIÑO", "SAN PEDRO DE CARTAGO - NARIÑO", "SANTA BARBARA - NARIÑO", "SANTACRUZ - NARIÑO", "SAPUYES - NARIÑO", "TAMINANGO - NARIÑO", "TANGUA - NARIÑO", "SAN ANDRES DE TUMACO - NARIÑO", "TUQUERRES - NARIÑO", "YACUANQUER - NARIÑO", "CUCUTA - N. DE SANTANDER", "ABREGO - N. DE SANTANDER", "ARBOLEDAS - N. DE SANTANDER", "BOCHALEMA - N. DE SANTANDER", "BUCARASICA - N. DE SANTANDER", "CACOTA - N. DE SANTANDER", "CACHIRA - N. DE SANTANDER", "CHINACOTA - N. DE SANTANDER", "CHITAGA - N. DE SANTANDER", "CONVENCION - N. DE SANTANDER", "CUCUTILLA - N. DE SANTANDER", "DURANIA - N. DE SANTANDER", "EL CARMEN - N. DE SANTANDER", "EL TARRA - N. DE SANTANDER", "EL ZULIA - N. DE SANTANDER", "GRAMALOTE - N. DE SANTANDER", "HACARI - N. DE SANTANDER", "HERRAN - N. DE SANTANDER", "LABATECA - N. DE SANTANDER", "LA ESPERANZA - N. DE SANTANDER", "LA PLAYA - N. DE SANTANDER", "LOS PATIOS - N. DE SANTANDER", "LOURDES - N. DE SANTANDER", "MUTISCUA - N. DE SANTANDER", "OCAÑA - N. DE SANTANDER", "PAMPLONA - N. DE SANTANDER", "PAMPLONITA - N. DE SANTANDER", "PUERTO SANTANDER - N. DE SANTANDER", "RAGONVALIA - N. DE SANTANDER", "SALAZAR - N. DE SANTANDER", "SAN CALIXTO - N. DE SANTANDER", "SAN CAYETANO - N. DE SANTANDER", "SANTIAGO - N. DE SANTANDER", "SARDINATA - N. DE SANTANDER", "SILOS - N. DE SANTANDER", "TEORAMA - N. DE SANTANDER", "TIBU - N. DE SANTANDER", "TOLEDO - N. DE SANTANDER", "VILLA CARO - N. DE SANTANDER", "VILLA DEL ROSARIO - N. DE SANTANDER", "ARMENIA - QUINDIO", "BUENAVISTA - QUINDIO", "CALARCA - QUINDIO", "CIRCASIA - QUINDIO", "CORDOBA - QUINDIO", "FILANDIA - QUINDIO", "GENOVA - QUINDIO", "LA TEBAIDA - QUINDIO", "MONTENEGRO - QUINDIO", "PIJAO - QUINDIO", "QUIMBAYA - QUINDIO", "SALENTO - QUINDIO", "PEREIRA - RISARALDA", "APIA - RISARALDA", "BALBOA - RISARALDA", "BELEN DE UMBRIA - RISARALDA", "DOSQUEBRADAS - RISARALDA", "GUATICA - RISARALDA", "LA CELIA - RISARALDA", "LA VIRGINIA - RISARALDA", "MARSELLA - RISARALDA", "MISTRATO - RISARALDA", "PUEBLO RICO - RISARALDA", "QUINCHIA - RISARALDA", "SANTA ROSA DE CABAL - RISARALDA", "SANTUARIO - RISARALDA", "BUCARAMANGA - SANTANDER", "AGUADA - SANTANDER", "ALBANIA - SANTANDER", "ARATOCA - SANTANDER", "BARBOSA - SANTANDER", "BARICHARA - SANTANDER", "BARRANCABERMEJA - SANTANDER", "BETULIA - SANTANDER", "BOLIVAR - SANTANDER", "CABRERA - SANTANDER", "CALIFORNIA - SANTANDER", "CAPITANEJO - SANTANDER", "CARCASI - SANTANDER", "CEPITA - SANTANDER", "CERRITO - SANTANDER", "CHARALA - SANTANDER", "CHARTA - SANTANDER", "CHIMA - SANTANDER", "CHIPATA - SANTANDER", "CIMITARRA - SANTANDER", "CONCEPCION - SANTANDER", "CONFINES - SANTANDER", "CONTRATACION - SANTANDER", "COROMORO - SANTANDER", "CURITI - SANTANDER", "EL CARMEN DE CHUCURI - SANTANDER", "EL GUACAMAYO - SANTANDER", "EL PEÑON - SANTANDER", "EL PLAYON - SANTANDER", "ENCINO - SANTANDER", "ENCISO - SANTANDER", "FLORIAN - SANTANDER", "FLORIDABLANCA - SANTANDER", "GALAN - SANTANDER", "GAMBITA - SANTANDER", "GIRON - SANTANDER", "GUACA - SANTANDER", "GUADALUPE - SANTANDER", "GUAPOTA - SANTANDER", "GUAVATA - SANTANDER", "GsEPSA - SANTANDER", "HATO - SANTANDER", "JESUS MARIA - SANTANDER", "JORDAN - SANTANDER", "LA BELLEZA - SANTANDER", "LANDAZURI - SANTANDER", "LA PAZ - SANTANDER", "LEBRIJA - SANTANDER", "LOS SANTOS - SANTANDER", "MACARAVITA - SANTANDER", "MALAGA - SANTANDER", "MATANZA - SANTANDER", "MOGOTES - SANTANDER", "MOLAGAVITA - SANTANDER", "OCAMONTE - SANTANDER", "OIBA - SANTANDER", "ONZAGA - SANTANDER", "PALMAR - SANTANDER", "PALMAS DEL SOCORRO - SANTANDER", "PARAMO - SANTANDER", "PIEDECUESTA - SANTANDER", "PINCHOTE - SANTANDER", "PUENTE NACIONAL - SANTANDER", "PUERTO PARRA - SANTANDER", "PUERTO WILCHES - SANTANDER", "RIONEGRO - SANTANDER", "SABANA DE TORRES - SANTANDER", "SAN ANDRES - SANTANDER", "SAN BENITO - SANTANDER", "SAN GIL - SANTANDER", "SAN JOAQUIN - SANTANDER", "SAN JOSE DE MIRANDA - SANTANDER", "SAN MIGUEL - SANTANDER", "SAN VICENTE DE CHUCURI - SANTANDER", "SANTA BARBARA - SANTANDER", "SANTA HELENA DEL OPON - SANTANDER", "SIMACOTA - SANTANDER", "SOCORRO - SANTANDER", "SUAITA - SANTANDER", "SUCRE - SANTANDER", "SURATA - SANTANDER", "TONA - SANTANDER", "VALLE DE SAN JOSE - SANTANDER", "VELEZ - SANTANDER", "VETAS - SANTANDER", "VILLANUEVA - SANTANDER", "ZAPATOCA - SANTANDER", "SINCELEJO - SUCRE", "BUENAVISTA - SUCRE", "CAIMITO - SUCRE", "COLOSO - SUCRE", "COROZAL - SUCRE", "COVEÑAS - SUCRE", "CHALAN - SUCRE", "EL ROBLE - SUCRE", "GALERAS - SUCRE", "GUARANDA - SUCRE", "LA UNION - SUCRE", "LOS PALMITOS - SUCRE", "MAJAGUAL - SUCRE", "MORROA - SUCRE", "OVEJAS - SUCRE", "PALMITO - SUCRE", "SAMPUES - SUCRE", "SAN BENITO ABAD - SUCRE", "SAN JUAN DE BETULIA - SUCRE", "SAN MARCOS - SUCRE", "SAN ONOFRE - SUCRE", "SAN PEDRO - SUCRE", "SAN LUIS DE SINCE - SUCRE", "SUCRE - SUCRE", "SANTIAGO DE TOLU - SUCRE", "TOLU VIEJO - SUCRE", "IBAGUE - TOLIMA", "ALPUJARRA - TOLIMA", "ALVARADO - TOLIMA", "AMBALEMA - TOLIMA", "ANZOATEGUI - TOLIMA", "ARMERO - TOLIMA", "ATACO - TOLIMA", "CAJAMARCA - TOLIMA", "CARMEN DE APICALA - TOLIMA", "CASABIANCA - TOLIMA", "CHAPARRAL - TOLIMA", "COELLO - TOLIMA", "COYAIMA - TOLIMA", "CUNDAY - TOLIMA", "DOLORES - TOLIMA", "ESPINAL - TOLIMA", "FALAN - TOLIMA", "FLANDES - TOLIMA", "FRESNO - TOLIMA", "GUAMO - TOLIMA", "HERVEO - TOLIMA", "HONDA - TOLIMA", "ICONONZO - TOLIMA", "LERIDA - TOLIMA", "LIBANO - TOLIMA", "MARIQUITA - TOLIMA", "MELGAR - TOLIMA", "MURILLO - TOLIMA", "NATAGAIMA - TOLIMA", "ORTEGA - TOLIMA", "PALOCABILDO - TOLIMA", "PIEDRAS - TOLIMA", "PLANADAS - TOLIMA", "PRADO - TOLIMA", "PURIFICACION - TOLIMA", "RIOBLANCO - TOLIMA", "RONCESVALLES - TOLIMA", "ROVIRA - TOLIMA", "SALDAÑA - TOLIMA", "SAN ANTONIO - TOLIMA", "SAN LUIS - TOLIMA", "SANTA ISABEL - TOLIMA", "SUAREZ - TOLIMA", "VALLE DE SAN JUAN - TOLIMA", "VENADILLO - TOLIMA", "VILLAHERMOSA - TOLIMA", "VILLARRICA - TOLIMA", "CALI - VALLE DEL CAUCA", "ALCALA - VALLE DEL CAUCA", "ANDALUCIA - VALLE DEL CAUCA", "ANSERMANUEVO - VALLE DEL CAUCA", "ARGELIA - VALLE DEL CAUCA", "BOLIVAR - VALLE DEL CAUCA", "BUENAVENTURA - VALLE DEL CAUCA", "GUADALAJARA DE BUGA - VALLE DEL CAUCA", "BUGALAGRANDE - VALLE DEL CAUCA", "CAICEDONIA - VALLE DEL CAUCA", "CALIMA - VALLE DEL CAUCA", "CANDELARIA - VALLE DEL CAUCA", "CARTAGO - VALLE DEL CAUCA", "DAGUA - VALLE DEL CAUCA", "EL AGUILA - VALLE DEL CAUCA", "EL CAIRO - VALLE DEL CAUCA", "EL CERRITO - VALLE DEL CAUCA", "EL DOVIO - VALLE DEL CAUCA", "FLORIDA - VALLE DEL CAUCA", "GINEBRA - VALLE DEL CAUCA", "GUACARI - VALLE DEL CAUCA", "JAMUNDI - VALLE DEL CAUCA", "LA CUMBRE - VALLE DEL CAUCA", "LA UNION - VALLE DEL CAUCA", "LA VICTORIA - VALLE DEL CAUCA", "OBANDO - VALLE DEL CAUCA", "PALMIRA - VALLE DEL CAUCA", "PRADERA - VALLE DEL CAUCA", "RESTREPO - VALLE DEL CAUCA", "RIOFRIO - VALLE DEL CAUCA", "ROLDANILLO - VALLE DEL CAUCA", "SAN PEDRO - VALLE DEL CAUCA", "SEVILLA - VALLE DEL CAUCA", "TORO - VALLE DEL CAUCA", "TRUJILLO - VALLE DEL CAUCA", "TULUA - VALLE DEL CAUCA", "ULLOA - VALLE DEL CAUCA", "VERSALLES - VALLE DEL CAUCA", "VIJES - VALLE DEL CAUCA", "YOTOCO - VALLE DEL CAUCA", "YUMBO - VALLE DEL CAUCA", "ZARZAL - VALLE DEL CAUCA", "ARAUCA - ARAUCA", "ARAUQUITA - ARAUCA", "CRAVO NORTE - ARAUCA", "FORTUL - ARAUCA", "PUERTO RONDON - ARAUCA", "SARAVENA - ARAUCA", "TAME - ARAUCA", "YOPAL - CASANARE", "AGUAZUL - CASANARE", "CHAMEZA - CASANARE", "HATO COROZAL - CASANARE", "LA SALINA - CASANARE", "MANI - CASANARE", "MONTERREY - CASANARE", "NUNCHIA - CASANARE", "OROCUE - CASANARE", "PAZ DE ARIPORO - CASANARE", "PORE - CASANARE", "RECETOR - CASANARE", "SABANALARGA - CASANARE", "SACAMA - CASANARE", "SAN LUIS DE PALENQUE - CASANARE", "TAMARA - CASANARE", "TAURAMENA - CASANARE", "TRINIDAD - CASANARE", "VILLANUEVA - CASANARE", "MOCOA - PUTUMAYO", "COLON - PUTUMAYO", "ORITO - PUTUMAYO", "PUERTO ASIS - PUTUMAYO", "PUERTO CAICEDO - PUTUMAYO", "PUERTO GUZMAN - PUTUMAYO", "LEGUIZAMO - PUTUMAYO", "SIBUNDOY - PUTUMAYO", "SAN FRANCISCO - PUTUMAYO", "SAN MIGUEL - PUTUMAYO", "SANTIAGO - PUTUMAYO", "VALLE DEL GUAMUEZ - PUTUMAYO", "VILLAGARZON - PUTUMAYO", "SAN ANDRES - SAN ANDRES", "PROVIDENCIA - SAN ANDRES", "LETICIA - AMAZONAS", "EL ENCANTO - AMAZONAS", "LA CHORRERA - AMAZONAS", "LA PEDRERA - AMAZONAS", "LA VICTORIA - AMAZONAS", "MIRITI - PARANA - AMAZONAS", "PUERTO ALEGRIA - AMAZONAS", "PUERTO ARICA - AMAZONAS", "PUERTO NARIÑO - AMAZONAS", "PUERTO SANTANDER - AMAZONAS", "TARAPACA - AMAZONAS", "INIRIDA - GUAINIA", "BARRANCO MINAS - GUAINIA", "MAPIRIPANA - GUAINIA", "SAN FELIPE - GUAINIA", "PUERTO COLOMBIA - GUAINIA", "LA GUADALUPE - GUAINIA", "CACAHUAL - GUAINIA", "PANA PANA - GUAINIA", "MORICHAL - GUAINIA", "SAN JOSE DEL GUAVIARE - GUAVIARE", "CALAMAR - GUAVIARE", "EL RETORNO - GUAVIARE", "MIRAFLORES - GUAVIARE", "MITU - VAUPES", "CARURU - VAUPES", "PACOA - VAUPES", "TARAIRA - VAUPES", "PAPUNAUA - VAUPES", "YAVARATE - VAUPES", "PUERTO CARREÑO - VICHADA", "LA PRIMAVERA - VICHADA", "SANTA ROSALIA - VICHADA", "CUMARIBO - VICHADA"})
        Me.ComboBox_tablas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_tablas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_tablas.BackColor = System.Drawing.Color.White
        Me.ComboBox_tablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_tablas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_tablas.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ComboBox_tablas.FormattingEnabled = True
        Me.ComboBox_tablas.Location = New System.Drawing.Point(20, 45)
        Me.ComboBox_tablas.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.ComboBox_tablas.Name = "ComboBox_tablas"
        Me.ComboBox_tablas.Size = New System.Drawing.Size(394, 32)
        Me.ComboBox_tablas.TabIndex = 496
        '
        'BTN_elim_tabla
        '
        Me.BTN_elim_tabla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_elim_tabla.BackColor = System.Drawing.Color.Transparent
        Me.BTN_elim_tabla.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.BUTTTON1
        Me.BTN_elim_tabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_elim_tabla.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTN_elim_tabla.FlatAppearance.BorderSize = 0
        Me.BTN_elim_tabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_elim_tabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_elim_tabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_elim_tabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_elim_tabla.ForeColor = System.Drawing.Color.White
        Me.BTN_elim_tabla.Location = New System.Drawing.Point(781, 376)
        Me.BTN_elim_tabla.Name = "BTN_elim_tabla"
        Me.BTN_elim_tabla.Size = New System.Drawing.Size(110, 29)
        Me.BTN_elim_tabla.TabIndex = 478
        Me.BTN_elim_tabla.Text = "Borrar Datos"
        Me.BTN_elim_tabla.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label13.Location = New System.Drawing.Point(20, 18)
        Me.Label13.Margin = New System.Windows.Forms.Padding(20, 5, 3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(192, 24)
        Me.Label13.TabIndex = 495
        Me.Label13.Text = "Conjuntos de Datos"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(17, 80)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(874, 290)
        Me.DataGridView2.TabIndex = 641
        '
        'Button14
        '
        Me.Button14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button14.BackColor = System.Drawing.Color.Transparent
        Me.Button14.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.BUTTTON1
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.White
        Me.Button14.Location = New System.Drawing.Point(538, 45)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(110, 29)
        Me.Button14.TabIndex = 523
        Me.Button14.Text = "Revisar Estruc"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.Button2)
        Me.MetroTabPage3.Controls.Add(Me.Button13)
        Me.MetroTabPage3.Controls.Add(Me.Button12)
        Me.MetroTabPage3.Controls.Add(Me.Button10)
        Me.MetroTabPage3.Controls.Add(Me.Button_procesar)
        Me.MetroTabPage3.Controls.Add(Me.Button5)
        Me.MetroTabPage3.Controls.Add(Me.Button17)
        Me.MetroTabPage3.Controls.Add(Me.TextBox1)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(914, 418)
        Me.MetroTabPage3.TabIndex = 3
        Me.MetroTabPage3.Text = "      Parches     "
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(786, 275)
        Me.Button2.Margin = New System.Windows.Forms.Padding(10, 30, 3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 31)
        Me.Button2.TabIndex = 654
        Me.Button2.Text = "DATA 5"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.BackgroundImage = CType(resources.GetObject("Button13.BackgroundImage"), System.Drawing.Image)
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Location = New System.Drawing.Point(786, 236)
        Me.Button13.Margin = New System.Windows.Forms.Padding(10, 30, 3, 3)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(116, 31)
        Me.Button13.TabIndex = 653
        Me.Button13.Text = "DATA 4"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(786, 189)
        Me.Button12.Margin = New System.Windows.Forms.Padding(10, 30, 3, 3)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(116, 31)
        Me.Button12.TabIndex = 651
        Me.Button12.Text = "Actualiza DATA3"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(786, 145)
        Me.Button10.Margin = New System.Windows.Forms.Padding(10, 30, 3, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(116, 31)
        Me.Button10.TabIndex = 650
        Me.Button10.Text = "Actualiza DATA2"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button_procesar
        '
        Me.Button_procesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_procesar.BackColor = System.Drawing.Color.Transparent
        Me.Button_procesar.BackgroundImage = CType(resources.GetObject("Button_procesar.BackgroundImage"), System.Drawing.Image)
        Me.Button_procesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_procesar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_procesar.FlatAppearance.BorderSize = 0
        Me.Button_procesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_procesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_procesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_procesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_procesar.ForeColor = System.Drawing.Color.White
        Me.Button_procesar.Location = New System.Drawing.Point(786, 16)
        Me.Button_procesar.Margin = New System.Windows.Forms.Padding(10, 30, 3, 3)
        Me.Button_procesar.Name = "Button_procesar"
        Me.Button_procesar.Size = New System.Drawing.Size(116, 43)
        Me.Button_procesar.TabIndex = 649
        Me.Button_procesar.Text = "Procesar Manualmente"
        Me.Button_procesar.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.FondoBotonRojo
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(786, 381)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 34)
        Me.Button5.TabIndex = 504
        Me.Button5.Text = "Borrar Todos los datos"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button17.BackColor = System.Drawing.Color.Transparent
        Me.Button17.BackgroundImage = CType(resources.GetObject("Button17.BackgroundImage"), System.Drawing.Image)
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button17.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.White
        Me.Button17.Location = New System.Drawing.Point(786, 99)
        Me.Button17.Margin = New System.Windows.Forms.Padding(10, 30, 3, 3)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(116, 31)
        Me.Button17.TabIndex = 647
        Me.Button17.Text = "Actualizar DATA1"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.LightBlue
        Me.TextBox1.Location = New System.Drawing.Point(11, 5)
        Me.TextBox1.MaxLength = 1000000
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(762, 410)
        Me.TextBox1.TabIndex = 644
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.Controls.Add(Me.DataGridView)
        Me.MetroTabPage4.Controls.Add(Me.Button15)
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.HorizontalScrollbarSize = 10
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(914, 418)
        Me.MetroTabPage4.TabIndex = 4
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.VerticalScrollbarSize = 10
        '
        'DataGridView
        '
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(11, 68)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(888, 335)
        Me.DataGridView.TabIndex = 651
        '
        'Button15
        '
        Me.Button15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button15.BackColor = System.Drawing.Color.Transparent
        Me.Button15.BackgroundImage = CType(resources.GetObject("Button15.BackgroundImage"), System.Drawing.Image)
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.White
        Me.Button15.Location = New System.Drawing.Point(745, 19)
        Me.Button15.Margin = New System.Windows.Forms.Padding(10, 30, 3, 3)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(154, 43)
        Me.Button15.TabIndex = 650
        Me.Button15.Text = "Importar"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'OpenFileDialog_mail
        '
        Me.OpenFileDialog_mail.Filter = "JPG,*.jpg|"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label_info
        '
        Me.Label_info.AutoSize = True
        Me.Label_info.BackColor = System.Drawing.Color.Transparent
        Me.Label_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info.ForeColor = System.Drawing.Color.Red
        Me.Label_info.Location = New System.Drawing.Point(25, 508)
        Me.Label_info.Name = "Label_info"
        Me.Label_info.Size = New System.Drawing.Size(14, 18)
        Me.Label_info.TabIndex = 503
        Me.Label_info.Text = "-"
        Me.Label_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_info.Visible = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BackgroundWorker_up_do
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.banner9
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button_cerrar)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(952, 32)
        Me.Panel1.TabIndex = 445
        '
        'Button_cerrar
        '
        Me.Button_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Button_cerrar.BackgroundImage = Global.MiClickDerecho.My.Resources.Resources.CANCEL
        Me.Button_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_cerrar.FlatAppearance.BorderSize = 0
        Me.Button_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_cerrar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cerrar.ForeColor = System.Drawing.Color.White
        Me.Button_cerrar.Location = New System.Drawing.Point(917, 4)
        Me.Button_cerrar.Name = "Button_cerrar"
        Me.Button_cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Button_cerrar.TabIndex = 504
        Me.Button_cerrar.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(43, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(193, 18)
        Me.Label20.TabIndex = 438
        Me.Label20.Text = "Configuración Avanzada"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.MiClickDerecho.My.Resources.Resources.configur
        Me.PictureBox4.Location = New System.Drawing.Point(7, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 28)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 503
        Me.PictureBox4.TabStop = False
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.MetroTabControl1
        '
        'Form_avanzado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 531)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Label_info)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_avanzado"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        Me.MetroTabPage4.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents BTN_elim_tabla As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox_tablas As ComboBox
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents Button_restore As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents OpenFileDialog_mail As OpenFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Label_info As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Button6 As Button
    Friend WithEvents Button_cerrar As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents BackgroundWorker_up_do As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button14 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button17 As Button
    Friend WithEvents Button_procesar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Button15 As Button
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Button2 As Button
End Class
