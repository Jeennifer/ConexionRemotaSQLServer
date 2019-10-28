<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPresentacion))
        Me.barraInicio = New System.Windows.Forms.ProgressBar()
        Me.contadorInicio = New System.Windows.Forms.Timer(Me.components)
        Me.lblContadorInicio = New System.Windows.Forms.Label()
        Me.lblPrueba = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'barraInicio
        '
        Me.barraInicio.BackColor = System.Drawing.Color.Teal
        Me.barraInicio.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.barraInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.barraInicio.Location = New System.Drawing.Point(10, 421)
        Me.barraInicio.Margin = New System.Windows.Forms.Padding(1)
        Me.barraInicio.Name = "barraInicio"
        Me.barraInicio.Size = New System.Drawing.Size(640, 23)
        Me.barraInicio.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.barraInicio.TabIndex = 0
        '
        'contadorInicio
        '
        Me.contadorInicio.Interval = 60
        '
        'lblContadorInicio
        '
        Me.lblContadorInicio.AutoSize = True
        Me.lblContadorInicio.BackColor = System.Drawing.Color.Transparent
        Me.lblContadorInicio.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContadorInicio.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.lblContadorInicio.Location = New System.Drawing.Point(19, 401)
        Me.lblContadorInicio.Name = "lblContadorInicio"
        Me.lblContadorInicio.Size = New System.Drawing.Size(0, 19)
        Me.lblContadorInicio.TabIndex = 1
        '
        'lblPrueba
        '
        Me.lblPrueba.AutoSize = True
        Me.lblPrueba.Location = New System.Drawing.Point(13, 398)
        Me.lblPrueba.Name = "lblPrueba"
        Me.lblPrueba.Size = New System.Drawing.Size(0, 13)
        Me.lblPrueba.TabIndex = 2
        '
        'frmPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GUI_JM_SQLServer.My.Resources.Resources.Captura
        Me.ClientSize = New System.Drawing.Size(660, 450)
        Me.Controls.Add(Me.lblContadorInicio)
        Me.Controls.Add(Me.lblPrueba)
        Me.Controls.Add(Me.barraInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUI-SQLServer-JM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barraInicio As ProgressBar
    Friend WithEvents contadorInicio As Timer
    Friend WithEvents lblContadorInicio As Label
    Friend WithEvents lblPrueba As Label
End Class
