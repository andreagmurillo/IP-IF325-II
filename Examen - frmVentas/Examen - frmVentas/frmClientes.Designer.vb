<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Me.grbClientes = New System.Windows.Forms.GroupBox()
        Me.txtDireccion = New System.Windows.Forms.RichTextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIDCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.ErrorValidacion1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grbClientes.SuspendLayout()
        CType(Me.ErrorValidacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbClientes
        '
        Me.grbClientes.Controls.Add(Me.txtDireccion)
        Me.grbClientes.Controls.Add(Me.txtApellido)
        Me.grbClientes.Controls.Add(Me.txtNombre)
        Me.grbClientes.Controls.Add(Me.txtIDCliente)
        Me.grbClientes.Controls.Add(Me.Label4)
        Me.grbClientes.Controls.Add(Me.Label3)
        Me.grbClientes.Controls.Add(Me.Label2)
        Me.grbClientes.Controls.Add(Me.Label1)
        Me.grbClientes.Location = New System.Drawing.Point(12, 12)
        Me.grbClientes.Name = "grbClientes"
        Me.grbClientes.Size = New System.Drawing.Size(253, 222)
        Me.grbClientes.TabIndex = 0
        Me.grbClientes.TabStop = False
        Me.grbClientes.Text = "Clientes"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(82, 113)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 96)
        Me.txtDireccion.TabIndex = 8
        Me.txtDireccion.Text = ""
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(82, 79)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(82, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtIDCliente
        '
        Me.txtIDCliente.Location = New System.Drawing.Point(82, 19)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIDCliente.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Cliente"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(104, 240)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 1
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'ErrorValidacion1
        '
        Me.ErrorValidacion1.ContainerControl = Me
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(284, 300)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.grbClientes)
        Me.Name = "frmCliente"
        Me.Text = "Clientes"
        Me.grbClientes.ResumeLayout(False)
        Me.grbClientes.PerformLayout()
        CType(Me.ErrorValidacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbClientes As GroupBox
    Friend WithEvents txtDireccion As RichTextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIDCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents ErrorValidacion1 As ErrorProvider
End Class
