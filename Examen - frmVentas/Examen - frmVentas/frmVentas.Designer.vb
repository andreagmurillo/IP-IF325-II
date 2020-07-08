<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtidProducto = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtidCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidVenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.panelLateral = New System.Windows.Forms.Panel()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Tienda = New Examen___frmVentas.Tienda()
        Me.TiendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtgVentas = New System.Windows.Forms.DataGridView()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtFechaVenta = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.panelLateral.SuspendLayout()
        CType(Me.Tienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFechaVenta)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.txtidProducto)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.txtidCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidVenta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btn)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(262, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ventas"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(243, 162)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(243, 125)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtidProducto
        '
        Me.txtidProducto.Location = New System.Drawing.Point(113, 165)
        Me.txtidProducto.Name = "txtidProducto"
        Me.txtidProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtidProducto.TabIndex = 11
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(243, 92)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'txtidCliente
        '
        Me.txtidCliente.Location = New System.Drawing.Point(113, 25)
        Me.txtidCliente.Name = "txtidCliente"
        Me.txtidCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtidCliente.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Venta"
        '
        'txtidVenta
        '
        Me.txtidVenta.Location = New System.Drawing.Point(113, 139)
        Me.txtidVenta.Name = "txtidVenta"
        Me.txtidVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtidVenta.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ID Cliente"
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(243, 55)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 25)
        Me.btn.TabIndex = 3
        Me.btn.Text = "Buscar"
        Me.btn.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(113, 113)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 9
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(243, 19)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(113, 84)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ID Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha de la Venta"
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.AntiqueWhite
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(760, 20)
        Me.panelSuperior.TabIndex = 2
        '
        'panelLateral
        '
        Me.panelLateral.BackColor = System.Drawing.Color.NavajoWhite
        Me.panelLateral.Controls.Add(Me.btnClientes)
        Me.panelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLateral.Location = New System.Drawing.Point(0, 20)
        Me.panelLateral.Name = "panelLateral"
        Me.panelLateral.Size = New System.Drawing.Size(148, 396)
        Me.panelLateral.TabIndex = 3
        '
        'btnClientes
        '
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Image = Global.Examen___frmVentas.My.Resources.Resources.customer
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(12, 113)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(133, 39)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(646, 120)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Tienda
        '
        Me.Tienda.DataSetName = "Tienda"
        Me.Tienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TiendaBindingSource
        '
        Me.TiendaBindingSource.DataSource = Me.Tienda
        Me.TiendaBindingSource.Position = 0
        '
        'dtgVentas
        '
        Me.dtgVentas.AutoGenerateColumns = False
        Me.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgVentas.DataSource = Me.TiendaBindingSource
        Me.dtgVentas.Location = New System.Drawing.Point(154, 241)
        Me.dtgVentas.Name = "dtgVentas"
        Me.dtgVentas.Size = New System.Drawing.Size(594, 141)
        Me.dtgVentas.TabIndex = 1
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'txtFechaVenta
        '
        Me.txtFechaVenta.Location = New System.Drawing.Point(113, 56)
        Me.txtFechaVenta.Mask = "00/00/0000"
        Me.txtFechaVenta.Name = "txtFechaVenta"
        Me.txtFechaVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaVenta.TabIndex = 5
        Me.txtFechaVenta.ValidatingType = GetType(Date)
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(760, 416)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.panelLateral)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.dtgVentas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmVentas"
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelLateral.ResumeLayout(False)
        CType(Me.Tienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtidVenta As TextBox
    Friend WithEvents txtidProducto As TextBox
    Friend WithEvents txtidCliente As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btn As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents Ventas As Tienda
    Friend WithEvents btnEliminar As Button
    Friend WithEvents panelSuperior As Panel
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents TiendaBindingSource As BindingSource
    Friend WithEvents Tienda As Tienda
    Friend WithEvents dtgVentas As DataGridView
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents txtFechaVenta As MaskedTextBox
End Class
