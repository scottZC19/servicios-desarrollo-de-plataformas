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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnsuma = New System.Windows.Forms.Button()
        Me.btnresta = New System.Windows.Forms.Button()
        Me.btnmulti = New System.Windows.Forms.Button()
        Me.btntang = New System.Windows.Forms.Button()
        Me.btnpot = New System.Windows.Forms.Button()
        Me.btndiv = New System.Windows.Forms.Button()
        Me.btncos = New System.Windows.Forms.Button()
        Me.btnseno = New System.Windows.Forms.Button()
        Me.btnraiz = New System.Windows.Forms.Button()
        Me.btnfac = New System.Windows.Forms.Button()
        Me.txtnro1 = New System.Windows.Forms.TextBox()
        Me.txtnro2 = New System.Windows.Forms.TextBox()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsuma
        '
        Me.btnsuma.Image = CType(resources.GetObject("btnsuma.Image"), System.Drawing.Image)
        Me.btnsuma.Location = New System.Drawing.Point(25, 102)
        Me.btnsuma.Name = "btnsuma"
        Me.btnsuma.Size = New System.Drawing.Size(70, 70)
        Me.btnsuma.TabIndex = 0
        Me.btnsuma.Text = "Suma"
        Me.btnsuma.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsuma.UseVisualStyleBackColor = True
        '
        'btnresta
        '
        Me.btnresta.Image = CType(resources.GetObject("btnresta.Image"), System.Drawing.Image)
        Me.btnresta.Location = New System.Drawing.Point(111, 102)
        Me.btnresta.Name = "btnresta"
        Me.btnresta.Size = New System.Drawing.Size(70, 70)
        Me.btnresta.TabIndex = 1
        Me.btnresta.Text = "Resta"
        Me.btnresta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnresta.UseVisualStyleBackColor = True
        '
        'btnmulti
        '
        Me.btnmulti.Image = CType(resources.GetObject("btnmulti.Image"), System.Drawing.Image)
        Me.btnmulti.Location = New System.Drawing.Point(197, 102)
        Me.btnmulti.Name = "btnmulti"
        Me.btnmulti.Size = New System.Drawing.Size(70, 70)
        Me.btnmulti.TabIndex = 2
        Me.btnmulti.Text = "Multi"
        Me.btnmulti.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmulti.UseVisualStyleBackColor = True
        '
        'btntang
        '
        Me.btntang.Image = CType(resources.GetObject("btntang.Image"), System.Drawing.Image)
        Me.btntang.Location = New System.Drawing.Point(111, 370)
        Me.btntang.Name = "btntang"
        Me.btntang.Size = New System.Drawing.Size(70, 70)
        Me.btntang.TabIndex = 3
        Me.btntang.Text = "Tangente"
        Me.btntang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntang.UseVisualStyleBackColor = True
        '
        'btnpot
        '
        Me.btnpot.Image = CType(resources.GetObject("btnpot.Image"), System.Drawing.Image)
        Me.btnpot.Location = New System.Drawing.Point(197, 189)
        Me.btnpot.Name = "btnpot"
        Me.btnpot.Size = New System.Drawing.Size(70, 70)
        Me.btnpot.TabIndex = 4
        Me.btnpot.Text = "Potencia"
        Me.btnpot.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnpot.UseVisualStyleBackColor = True
        '
        'btndiv
        '
        Me.btndiv.Image = CType(resources.GetObject("btndiv.Image"), System.Drawing.Image)
        Me.btndiv.Location = New System.Drawing.Point(25, 189)
        Me.btndiv.Name = "btndiv"
        Me.btndiv.Size = New System.Drawing.Size(70, 70)
        Me.btndiv.TabIndex = 5
        Me.btndiv.Text = "Divicion"
        Me.btndiv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndiv.UseVisualStyleBackColor = True
        '
        'btncos
        '
        Me.btncos.Image = CType(resources.GetObject("btncos.Image"), System.Drawing.Image)
        Me.btncos.Location = New System.Drawing.Point(197, 279)
        Me.btncos.Name = "btncos"
        Me.btncos.Size = New System.Drawing.Size(70, 70)
        Me.btncos.TabIndex = 6
        Me.btncos.Text = "coseno"
        Me.btncos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncos.UseVisualStyleBackColor = True
        '
        'btnseno
        '
        Me.btnseno.Image = CType(resources.GetObject("btnseno.Image"), System.Drawing.Image)
        Me.btnseno.Location = New System.Drawing.Point(111, 279)
        Me.btnseno.Name = "btnseno"
        Me.btnseno.Size = New System.Drawing.Size(70, 70)
        Me.btnseno.TabIndex = 7
        Me.btnseno.Text = "Seno"
        Me.btnseno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnseno.UseVisualStyleBackColor = True
        '
        'btnraiz
        '
        Me.btnraiz.Image = CType(resources.GetObject("btnraiz.Image"), System.Drawing.Image)
        Me.btnraiz.Location = New System.Drawing.Point(25, 279)
        Me.btnraiz.Name = "btnraiz"
        Me.btnraiz.Size = New System.Drawing.Size(70, 70)
        Me.btnraiz.TabIndex = 8
        Me.btnraiz.Text = "Raiz"
        Me.btnraiz.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnraiz.UseVisualStyleBackColor = True
        '
        'btnfac
        '
        Me.btnfac.Image = CType(resources.GetObject("btnfac.Image"), System.Drawing.Image)
        Me.btnfac.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnfac.Location = New System.Drawing.Point(111, 189)
        Me.btnfac.Name = "btnfac"
        Me.btnfac.Size = New System.Drawing.Size(70, 70)
        Me.btnfac.TabIndex = 9
        Me.btnfac.Text = "Factorial"
        Me.btnfac.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnfac.UseVisualStyleBackColor = True
        '
        'txtnro1
        '
        Me.txtnro1.BackColor = System.Drawing.Color.White
        Me.txtnro1.Location = New System.Drawing.Point(25, 26)
        Me.txtnro1.Name = "txtnro1"
        Me.txtnro1.Size = New System.Drawing.Size(114, 20)
        Me.txtnro1.TabIndex = 10
        '
        'txtnro2
        '
        Me.txtnro2.Location = New System.Drawing.Point(155, 26)
        Me.txtnro2.Name = "txtnro2"
        Me.txtnro2.Size = New System.Drawing.Size(112, 20)
        Me.txtnro2.TabIndex = 11
        '
        'txtresultado
        '
        Me.txtresultado.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtresultado.Location = New System.Drawing.Point(155, 66)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(112, 20)
        Me.txtresultado.TabIndex = 12
        '
        'btnborrar
        '
        Me.btnborrar.Image = CType(resources.GetObject("btnborrar.Image"), System.Drawing.Image)
        Me.btnborrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnborrar.Location = New System.Drawing.Point(25, 60)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(114, 30)
        Me.btnborrar.TabIndex = 13
        Me.btnborrar.Text = "Borrar Campos"
        Me.btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Numero 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Numero 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(185, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(293, 453)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.txtresultado)
        Me.Controls.Add(Me.txtnro2)
        Me.Controls.Add(Me.txtnro1)
        Me.Controls.Add(Me.btnfac)
        Me.Controls.Add(Me.btnraiz)
        Me.Controls.Add(Me.btnseno)
        Me.Controls.Add(Me.btncos)
        Me.Controls.Add(Me.btndiv)
        Me.Controls.Add(Me.btnpot)
        Me.Controls.Add(Me.btntang)
        Me.Controls.Add(Me.btnmulti)
        Me.Controls.Add(Me.btnresta)
        Me.Controls.Add(Me.btnsuma)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsuma As Button
    Friend WithEvents btnresta As Button
    Friend WithEvents btnmulti As Button
    Friend WithEvents btntang As Button
    Friend WithEvents btnpot As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btncos As Button
    Friend WithEvents btnseno As Button
    Friend WithEvents btnraiz As Button
    Friend WithEvents btnfac As Button
    Friend WithEvents txtnro1 As TextBox
    Friend WithEvents txtnro2 As TextBox
    Friend WithEvents txtresultado As TextBox
    Friend WithEvents btnborrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
