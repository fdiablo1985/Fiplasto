﻿Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IngCamionRep
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
        Me.dtdesde = New MetroFramework.Controls.MetroDateTime()
        Me.dthasta = New MetroFramework.Controls.MetroDateTime()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btngenerar = New MetroFramework.Controls.MetroButton()
        Me.rbtodos = New MetroFramework.Controls.MetroRadioButton()
        Me.rbnc = New MetroFramework.Controls.MetroRadioButton()
        Me.rbcontrol = New MetroFramework.Controls.MetroRadioButton()
        Me.rbrajadora = New MetroFramework.Controls.MetroRadioButton()
        Me.gbCamion = New MetroFramework.Controls.MetroPanel()
        Me.gbRajadora = New MetroFramework.Controls.MetroPanel()
        Me.gbCamion.SuspendLayout()
        Me.gbRajadora.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtdesde
        '
        Me.dtdesde.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdesde.Location = New System.Drawing.Point(234, 80)
        Me.dtdesde.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(89, 25)
        Me.dtdesde.TabIndex = 2
        '
        'dthasta
        '
        Me.dthasta.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(234, 106)
        Me.dthasta.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(89, 25)
        Me.dthasta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(175, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(175, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Desde:"
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(234, 142)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 4
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
        '
        'rbtodos
        '
        Me.rbtodos.AutoSize = True
        Me.rbtodos.Checked = True
        Me.rbtodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbtodos.Location = New System.Drawing.Point(6, 6)
        Me.rbtodos.Name = "rbtodos"
        Me.rbtodos.Size = New System.Drawing.Size(56, 15)
        Me.rbtodos.TabIndex = 0
        Me.rbtodos.TabStop = True
        Me.rbtodos.Text = "Todos"
        Me.rbtodos.UseSelectable = True
        '
        'rbnc
        '
        Me.rbnc.AutoSize = True
        Me.rbnc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbnc.Location = New System.Drawing.Point(6, 31)
        Me.rbnc.Name = "rbnc"
        Me.rbnc.Size = New System.Drawing.Size(71, 15)
        Me.rbnc.TabIndex = 1
        Me.rbnc.Text = "NC/Rech"
        Me.rbnc.UseSelectable = True
        '
        'rbcontrol
        '
        Me.rbcontrol.AutoSize = True
        Me.rbcontrol.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbcontrol.Location = New System.Drawing.Point(6, 56)
        Me.rbcontrol.Name = "rbcontrol"
        Me.rbcontrol.Size = New System.Drawing.Size(98, 15)
        Me.rbcontrol.TabIndex = 2
        Me.rbcontrol.Text = "Ctrl Camiones"
        Me.rbcontrol.UseSelectable = True
        '
        'rbrajadora
        '
        Me.rbrajadora.AutoSize = True
        Me.rbrajadora.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbrajadora.Location = New System.Drawing.Point(6, 19)
        Me.rbrajadora.Name = "rbrajadora"
        Me.rbrajadora.Size = New System.Drawing.Size(69, 15)
        Me.rbrajadora.TabIndex = 0
        Me.rbrajadora.Text = "Rajadora"
        Me.rbrajadora.UseSelectable = True
        '
        'gbCamion
        '
        Me.gbCamion.Controls.Add(Me.rbtodos)
        Me.gbCamion.Controls.Add(Me.rbnc)
        Me.gbCamion.Controls.Add(Me.rbcontrol)
        Me.gbCamion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCamion.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.gbCamion.HorizontalScrollbarBarColor = True
        Me.gbCamion.HorizontalScrollbarHighlightOnWheel = False
        Me.gbCamion.HorizontalScrollbarSize = 10
        Me.gbCamion.Location = New System.Drawing.Point(7, 57)
        Me.gbCamion.Name = "gbCamion"
        Me.gbCamion.Size = New System.Drawing.Size(128, 83)
        Me.gbCamion.TabIndex = 0
        Me.gbCamion.Text = "Camiones"
        Me.gbCamion.VerticalScrollbarBarColor = True
        Me.gbCamion.VerticalScrollbarHighlightOnWheel = False
        Me.gbCamion.VerticalScrollbarSize = 10
        '
        'gbRajadora
        '
        Me.gbRajadora.Controls.Add(Me.rbrajadora)
        Me.gbRajadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRajadora.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.gbRajadora.HorizontalScrollbarBarColor = True
        Me.gbRajadora.HorizontalScrollbarHighlightOnWheel = False
        Me.gbRajadora.HorizontalScrollbarSize = 10
        Me.gbRajadora.Location = New System.Drawing.Point(7, 146)
        Me.gbRajadora.Name = "gbRajadora"
        Me.gbRajadora.Size = New System.Drawing.Size(128, 46)
        Me.gbRajadora.TabIndex = 1
        Me.gbRajadora.Text = "Rajadora"
        Me.gbRajadora.VerticalScrollbarBarColor = True
        Me.gbRajadora.VerticalScrollbarHighlightOnWheel = False
        Me.gbRajadora.VerticalScrollbarSize = 10
        '
        'IngCamionRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 231)
        Me.Controls.Add(Me.gbRajadora)
        Me.Controls.Add(Me.gbCamion)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dthasta)
        Me.Controls.Add(Me.dtdesde)
        Me.Name = "IngCamionRep"
        Me.Resizable = False
        Me.Text = "Ingreso de Camiones / Rajadora"
        Me.gbCamion.ResumeLayout(False)
        Me.gbCamion.PerformLayout()
        Me.gbRajadora.ResumeLayout(False)
        Me.gbRajadora.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtdesde As MetroDateTime
    Friend WithEvents dthasta As MetroDateTime
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents btngenerar As MetroButton
    Friend WithEvents rbtodos As MetroRadioButton
    Friend WithEvents rbnc As MetroRadioButton
    Friend WithEvents rbcontrol As MetroRadioButton
    Friend WithEvents rbrajadora As MetroRadioButton
    Friend WithEvents gbCamion As MetroPanel
    Friend WithEvents gbRajadora As MetroPanel
End Class
