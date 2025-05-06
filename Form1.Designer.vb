<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtusuario = New TextBox()
        txtcontraseña = New TextBox()
        Accederbtn = New Button()
        Salirbtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(344, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 15)
        Label1.TabIndex = 0
        Label1.Text = "INICIAR SESIÓN"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(349, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 1
        Label2.Text = "USUARIO"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(351, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 15)
        Label3.TabIndex = 2
        Label3.Text = "CONTRASEÑA"' 
        ' txtusuario
        ' 
        txtusuario.Location = New Point(349, 168)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(218, 23)
        txtusuario.TabIndex = 3
        ' 
        ' txtcontraseña
        ' 
        txtcontraseña.Location = New Point(349, 252)
        txtcontraseña.Name = "txtcontraseña"
        txtcontraseña.Size = New Size(218, 23)
        txtcontraseña.TabIndex = 4
        ' 
        ' Accederbtn
        ' 
        Accederbtn.BackColor = Color.Transparent
        Accederbtn.Image = CType(resources.GetObject("Accederbtn.Image"), Image)
        Accederbtn.ImageAlign = ContentAlignment.MiddleLeft
        Accederbtn.Location = New Point(351, 300)
        Accederbtn.Name = "Accederbtn"
        Accederbtn.Size = New Size(97, 58)
        Accederbtn.TabIndex = 5
        Accederbtn.Text = "ACCEDER"
        Accederbtn.TextAlign = ContentAlignment.MiddleRight
        Accederbtn.UseVisualStyleBackColor = False
        ' 
        ' Salirbtn
        ' 
        Salirbtn.Image = My.Resources.Resources.salida
        Salirbtn.ImageAlign = ContentAlignment.MiddleLeft
        Salirbtn.Location = New Point(480, 300)
        Salirbtn.Name = "Salirbtn"
        Salirbtn.Size = New Size(87, 58)
        Salirbtn.TabIndex = 6
        Salirbtn.Text = "SALIR"
        Salirbtn.TextAlign = ContentAlignment.MiddleRight
        Salirbtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(621, 386)
        Controls.Add(Salirbtn)
        Controls.Add(Accederbtn)
        Controls.Add(txtcontraseña)
        Controls.Add(txtusuario)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "TURBO REPUESTOS"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents Accederbtn As Button
    Friend WithEvents Salirbtn As Button
End Class
