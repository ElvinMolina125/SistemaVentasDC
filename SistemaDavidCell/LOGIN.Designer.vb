<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.Chk_Mostrar = New System.Windows.Forms.CheckBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BackColor = System.Drawing.SystemColors.Menu
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsuario.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtUsuario.Location = New System.Drawing.Point(886, 425)
        Me.TxtUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(387, 33)
        Me.TxtUsuario.TabIndex = 0
        '
        'TxtContraseña
        '
        Me.TxtContraseña.BackColor = System.Drawing.SystemColors.Menu
        Me.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtContraseña.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.Location = New System.Drawing.Point(890, 512)
        Me.TxtContraseña.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña.Size = New System.Drawing.Size(387, 33)
        Me.TxtContraseña.TabIndex = 1
        '
        'Chk_Mostrar
        '
        Me.Chk_Mostrar.AutoSize = True
        Me.Chk_Mostrar.Location = New System.Drawing.Point(880, 606)
        Me.Chk_Mostrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chk_Mostrar.Name = "Chk_Mostrar"
        Me.Chk_Mostrar.Size = New System.Drawing.Size(22, 21)
        Me.Chk_Mostrar.TabIndex = 2
        Me.Chk_Mostrar.UseVisualStyleBackColor = True
        '
        'BtnEntrar
        '
        Me.BtnEntrar.BackgroundImage = Global.SistemaDavidCell.My.Resources.Resources.Btn_Mesa_de_trabajo_1
        Me.BtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEntrar.FlatAppearance.BorderSize = 0
        Me.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrar.Location = New System.Drawing.Point(856, 670)
        Me.BtnEntrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(452, 82)
        Me.BtnEntrar.TabIndex = 3
        Me.BtnEntrar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaDavidCell.My.Resources.Resources._1_LOGIN_01_01
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1434, 977)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.Chk_Mostrar)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtUsuario)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1456, 1033)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1456, 1018)
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents Chk_Mostrar As CheckBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
