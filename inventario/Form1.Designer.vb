<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtservicetag = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSerieMonitor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLicenciaWindows = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtversionOffice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRam = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProcesador = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDiscoDuro = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.ttmensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtlicenciaOffice = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso de Equipo de Computo."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Service Tag /Serie:"
        '
        'txtservicetag
        '
        Me.txtservicetag.Location = New System.Drawing.Point(82, 128)
        Me.txtservicetag.Name = "txtservicetag"
        Me.txtservicetag.Size = New System.Drawing.Size(173, 20)
        Me.txtservicetag.TabIndex = 2
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(82, 206)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(173, 20)
        Me.txtmarca.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Marca:"
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(82, 277)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(173, 20)
        Me.txtmodelo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Modelo:"
        '
        'txtSerieMonitor
        '
        Me.txtSerieMonitor.Location = New System.Drawing.Point(82, 360)
        Me.txtSerieMonitor.Name = "txtSerieMonitor"
        Me.txtSerieMonitor.Size = New System.Drawing.Size(173, 20)
        Me.txtSerieMonitor.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Serie Moinitor:"
        '
        'txtSO
        '
        Me.txtSO.Location = New System.Drawing.Point(86, 429)
        Me.txtSO.Name = "txtSO"
        Me.txtSO.Size = New System.Drawing.Size(173, 20)
        Me.txtSO.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sistema Operativo:"
        '
        'txtLicenciaWindows
        '
        Me.txtLicenciaWindows.Location = New System.Drawing.Point(86, 500)
        Me.txtLicenciaWindows.Name = "txtLicenciaWindows"
        Me.txtLicenciaWindows.Size = New System.Drawing.Size(173, 20)
        Me.txtLicenciaWindows.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 468)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Licencia de Windows:"
        '
        'txtversionOffice
        '
        Me.txtversionOffice.Location = New System.Drawing.Point(353, 128)
        Me.txtversionOffice.Name = "txtversionOffice"
        Me.txtversionOffice.Size = New System.Drawing.Size(173, 20)
        Me.txtversionOffice.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(350, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Versión Office:"
        '
        'txtRam
        '
        Me.txtRam.Location = New System.Drawing.Point(353, 211)
        Me.txtRam.Name = "txtRam"
        Me.txtRam.Size = New System.Drawing.Size(173, 20)
        Me.txtRam.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(350, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Memoria Ram:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(350, 397)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Tipo:"
        '
        'txtProcesador
        '
        Me.txtProcesador.Location = New System.Drawing.Point(353, 358)
        Me.txtProcesador.Name = "txtProcesador"
        Me.txtProcesador.Size = New System.Drawing.Size(173, 20)
        Me.txtProcesador.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(350, 326)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Procesador:"
        '
        'txtDiscoDuro
        '
        Me.txtDiscoDuro.Location = New System.Drawing.Point(353, 280)
        Me.txtDiscoDuro.Name = "txtDiscoDuro"
        Me.txtDiscoDuro.Size = New System.Drawing.Size(173, 20)
        Me.txtDiscoDuro.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(350, 248)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Disco Duro:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(77, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 26)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Datos Equipo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(577, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 26)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Datos Usuarios."
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(582, 360)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(65, 20)
        Me.txtIp.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(579, 328)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Dirección IP:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(579, 245)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Departamento:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(582, 206)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(173, 20)
        Me.txtApellido.TabIndex = 31
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(579, 174)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Apellido:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(582, 128)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(173, 20)
        Me.txtNombre.TabIndex = 29
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(579, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Nombre:"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.GreenYellow
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.Location = New System.Drawing.Point(582, 593)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(65, 64)
        Me.btnguardar.TabIndex = 36
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.Lime
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.Location = New System.Drawing.Point(680, 593)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(62, 64)
        Me.btnnuevo.TabIndex = 37
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.Location = New System.Drawing.Point(789, 593)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 64)
        Me.btnsalir.TabIndex = 38
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'ttmensaje
        '
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'txtlicenciaOffice
        '
        Me.txtlicenciaOffice.Location = New System.Drawing.Point(353, 500)
        Me.txtlicenciaOffice.Name = "txtlicenciaOffice"
        Me.txtlicenciaOffice.Size = New System.Drawing.Size(173, 20)
        Me.txtlicenciaOffice.TabIndex = 41
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(350, 468)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 13)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Licencia de Office"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Items.AddRange(New Object() {"IT", "Contabilidad", "Recursos Humanos", "Empaque", "Servicio al cliente", "Empaque", "Serigrafia", "Sublimación", "Producción", "Ingenieria", "Calidad", "Generación", "Telas", "Materiales"})
        Me.cbDepartamento.Location = New System.Drawing.Point(582, 276)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(121, 21)
        Me.cbDepartamento.TabIndex = 42
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Desktop", "Laptop", "Servidor"})
        Me.cbTipo.Location = New System.Drawing.Point(353, 428)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cbTipo.TabIndex = 43
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(901, 684)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.txtlicenciaOffice)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtProcesador)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDiscoDuro)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtRam)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtversionOffice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtLicenciaWindows)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSerieMonitor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmodelo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmarca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtservicetag)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtservicetag As System.Windows.Forms.TextBox
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmodelo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSerieMonitor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSO As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLicenciaWindows As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtversionOffice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRam As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtProcesador As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDiscoDuro As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtIp As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents ttmensaje As System.Windows.Forms.ToolTip
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtlicenciaOffice As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox

End Class
