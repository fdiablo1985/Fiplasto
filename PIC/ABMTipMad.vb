Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework.Controls
Imports MetroFramework

Public Class ABMTipMad
    Inherits MetroFramework.Forms.MetroForm

    Dim sql, sql1, sql2, sql3, sql4, sql5 As String
    Dim da, da1, da5 As New SqlDataAdapter
    Dim cmd, cmd2, cmd3, cmd4, cmd5 As SqlCommand
    Dim dt As DataTable = New DataTable
    Dim dt1 As DataTable = New DataTable
    Dim dt5 As DataTable = New DataTable
    Dim sen, campos, variables, idl, dias As String
    Dim line, ms As Integer
    Friend WithEvents dg As MetroGrid
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents btnSalir As MetroTile
    Friend WithEvents btnGuardar As MetroTile
    Friend WithEvents btnBorrar As MetroTile
    Friend WithEvents btnEditar As MetroTile
    Friend WithEvents BtnNuevo As MetroTile
    Friend WithEvents txtdesc As MetroTextBox
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents txtcod As MetroTextBox
    Friend WithEvents btncancel As MetroButton
    Friend WithEvents Label2 As MetroLabel

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMTipMad))
        Me.dg = New MetroFramework.Controls.MetroGrid()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnSalir = New MetroFramework.Controls.MetroTile()
        Me.btnGuardar = New MetroFramework.Controls.MetroTile()
        Me.btnBorrar = New MetroFramework.Controls.MetroTile()
        Me.btnEditar = New MetroFramework.Controls.MetroTile()
        Me.BtnNuevo = New MetroFramework.Controls.MetroTile()
        Me.txtdesc = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.txtcod = New MetroFramework.Controls.MetroTextBox()
        Me.btncancel = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeColumns = False
        Me.dg.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle3
        Me.dg.Dock = System.Windows.Forms.DockStyle.Right
        Me.dg.EnableHeadersVisualStyles = False
        Me.dg.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.Location = New System.Drawing.Point(204, 101)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(249, 216)
        Me.dg.Style = MetroFramework.MetroColorStyle.Silver
        Me.dg.TabIndex = 38
        Me.dg.UseCustomForeColor = True
        Me.dg.UseStyleColors = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanel1.Controls.Add(Me.btnSalir)
        Me.MetroPanel1.Controls.Add(Me.btnGuardar)
        Me.MetroPanel1.Controls.Add(Me.btnBorrar)
        Me.MetroPanel1.Controls.Add(Me.btnEditar)
        Me.MetroPanel1.Controls.Add(Me.BtnNuevo)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(5, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(448, 41)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroPanel1.TabIndex = 37
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btnSalir
        '
        Me.btnSalir.ActiveControl = Nothing
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Location = New System.Drawing.Point(356, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 41)
        Me.btnSalir.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.TileImage = CType(resources.GetObject("btnSalir.TileImage"), System.Drawing.Image)
        Me.btnSalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnSalir.UseSelectable = True
        Me.btnSalir.UseTileImage = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ActiveControl = Nothing
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardar.Location = New System.Drawing.Point(267, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 41)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.TileImage = CType(resources.GetObject("btnGuardar.TileImage"), System.Drawing.Image)
        Me.btnGuardar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseTileImage = True
        '
        'btnBorrar
        '
        Me.btnBorrar.ActiveControl = Nothing
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBorrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBorrar.Location = New System.Drawing.Point(178, 0)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(89, 41)
        Me.btnBorrar.TabIndex = 4
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrar.TileImage = CType(resources.GetObject("btnBorrar.TileImage"), System.Drawing.Image)
        Me.btnBorrar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnBorrar.UseSelectable = True
        Me.btnBorrar.UseTileImage = True
        '
        'btnEditar
        '
        Me.btnEditar.ActiveControl = Nothing
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEditar.Location = New System.Drawing.Point(89, 0)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(89, 41)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TileImage = CType(resources.GetObject("btnEditar.TileImage"), System.Drawing.Image)
        Me.btnEditar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnEditar.UseSelectable = True
        Me.btnEditar.UseTileImage = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.ActiveControl = Nothing
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(89, 41)
        Me.BtnNuevo.TabIndex = 2
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.TileImage = CType(resources.GetObject("BtnNuevo.TileImage"), System.Drawing.Image)
        Me.BtnNuevo.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.BtnNuevo.UseSelectable = True
        Me.BtnNuevo.UseTileImage = True
        '
        'txtdesc
        '
        '
        '
        '
        Me.txtdesc.CustomButton.Image = Nothing
        Me.txtdesc.CustomButton.Location = New System.Drawing.Point(96, 1)
        Me.txtdesc.CustomButton.Name = ""
        Me.txtdesc.CustomButton.Size = New System.Drawing.Size(63, 63)
        Me.txtdesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdesc.CustomButton.TabIndex = 1
        Me.txtdesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdesc.CustomButton.UseSelectable = True
        Me.txtdesc.CustomButton.Visible = False
        Me.txtdesc.Lines = New String(-1) {}
        Me.txtdesc.Location = New System.Drawing.Point(20, 172)
        Me.txtdesc.MaxLength = 32767
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdesc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdesc.SelectedText = ""
        Me.txtdesc.SelectionLength = 0
        Me.txtdesc.SelectionStart = 0
        Me.txtdesc.ShortcutsEnabled = True
        Me.txtdesc.Size = New System.Drawing.Size(160, 65)
        Me.txtdesc.TabIndex = 35
        Me.txtdesc.UseSelectable = True
        Me.txtdesc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdesc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(20, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 28)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Descripci�n"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod
        '
        '
        '
        '
        Me.txtcod.CustomButton.Image = Nothing
        Me.txtcod.CustomButton.Location = New System.Drawing.Point(63, 2)
        Me.txtcod.CustomButton.Name = ""
        Me.txtcod.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcod.CustomButton.TabIndex = 1
        Me.txtcod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcod.CustomButton.UseSelectable = True
        Me.txtcod.CustomButton.Visible = False
        Me.txtcod.Enabled = False
        Me.txtcod.Lines = New String(-1) {}
        Me.txtcod.Location = New System.Drawing.Point(20, 124)
        Me.txtcod.MaxLength = 32767
        Me.txtcod.Name = "txtcod"
        Me.txtcod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcod.SelectedText = ""
        Me.txtcod.SelectionLength = 0
        Me.txtcod.SelectionStart = 0
        Me.txtcod.ShortcutsEnabled = True
        Me.txtcod.Size = New System.Drawing.Size(81, 20)
        Me.txtcod.TabIndex = 32
        Me.txtcod.UseSelectable = True
        Me.txtcod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncancel.Location = New System.Drawing.Point(105, 242)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 24)
        Me.btncancel.TabIndex = 33
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseSelectable = True
        Me.btncancel.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(20, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "C�digo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ABMTipMad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(458, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMTipMad"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.StartPosition = FormStartPosition.Manual
        Me.Text = "Tipo de Madera"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub condp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bloquea()
        Call buscadatos()
        dg.DataSource = dt
        btnGuardar.Enabled = False
        If dt.Rows.Count <> 0 Then
            dg.Select()
        Else
            btnEditar.Enabled = False
            btnBorrar.Enabled = False
        End If
    End Sub

    Private Sub Opcion(sender As Object, e As EventArgs) Handles BtnNuevo.Click, btnSalir.Click, btnGuardar.Click, btnEditar.Click, btnBorrar.Click
        'Busco la opci�n por el nombre del bot�n
        Select Case sender.Name

            Case BtnNuevo.Name ' boton nuevo
                sen = "n"
                btncancel.Visible = True
                btnGuardar.Enabled = True
                btnEditar.Enabled = False
                btnBorrar.Enabled = False
                Call habilita()
                Call buscamax()
                If IsDBNull(dt1.Rows(0).Item("ULT")) Then
                    txtcod.Text = "1"
                Else
                    txtcod.Text = dt1.Rows(0).Item("ULT") + 1
                    txtcod.Focus()
                End If
            Case btnEditar.Name 'boton editar
                sen = "m"
                btncancel.Visible = True
                BtnNuevo.Enabled = False
                btnBorrar.Enabled = False
                btnGuardar.Enabled = True
                Call habilita()
                Call modifica()
            Case btnBorrar.Name ' boton borrar
                ms = MetroMessageBox.Show(Me, "�Desea eliminar " + dg.CurrentRow.Cells("Descripcion").Value + " ?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalinea()
                    btncancel.Visible = False
                End If

            Case btnGuardar.Name 'boton guardar

                Call guardanuevo()
                Call limpia()
                Call buscadatos()
                dg.DataSource = dt
                If BtnNuevo.Enabled = False Then BtnNuevo.Enabled = True
                If btnEditar.Enabled = False Then btnEditar.Enabled = True
                If btnBorrar.Enabled = False Then btnBorrar.Enabled = True
                btnGuardar.Enabled = False
                btncancel.Visible = False
                dg.Select()
            Case btnSalir.Name ' boton salir
                Me.Close()
        End Select
    End Sub

    Private Sub modifica()
        If dg.SelectedRows.Count = 1 Then
            txtcod.Text = dg.CurrentRow.Cells("ID").Value
            txtdesc.Text = dg.CurrentRow.Cells("Descripcion").Value
            txtdesc.Focus()
        End If
    End Sub

    Private Sub habilita()
        txtdesc.Enabled = True
    End Sub

    Private Sub buscamax()
        conex("tipmad")
        sql1 = "SELECT max(tipmad_id)as ult From tipmad"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
    End Sub

    Private Sub dg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.Click
        Call limpia()
        Call deshabilita()
        If dg.SelectedRows.Count = 1 Then
            line = dg.CurrentRow.Cells("id").Value
        End If
    End Sub

    Private Sub deshabilita()
        txtcod.Enabled = False
        txtdesc.Enabled = False
    End Sub

    Private Sub limpia()
        txtcod.Text = ""
        txtdesc.Text = ""
    End Sub

    Private Sub buscadatos()
        conex("tipmad")
        sql = "SELECT tipmad_id as ID,tipmad_desc as Descripcion From tipmad order by tipmad_id"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
    End Sub

    Private Sub bloquea()
        txtcod.Enabled = False
        txtdesc.Enabled = False
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Opcion(btnEditar, e)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Call limpia()
        BtnNuevo.Enabled = True
        btnEditar.Enabled = True
        btnBorrar.Enabled = True
        btnGuardar.Enabled = False
        Call deshabilita()
        btncancel.Visible = False
    End Sub

    Private Sub guardanuevo()
        btncancel.Visible = False
        conex("tipmad")
        sql5 = "SELECT * From tipmad where tipmad_id='" + txtcod.Text + "';"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        n = dt5.Rows.Count
        If n = 0 Or sen <> "n" Then
            If sen = "n" Then
                campos = "tipmad_id,tipmad_desc"
                variables = "'" + txtcod.Text + "','" + txtdesc.Text + "'"
                sql3 = "INSERT INTO tipmad (" + campos + ") VALUES (" + variables + ")"
                cmd3 = New SqlCommand(sql3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()
            Else
                sql2 = "update tipmad set tipmad_desc='" + txtdesc.Text + "' where tipmad_id='" + txtcod.Text + "' "
                cmd2 = New SqlCommand(sql2, cnn)
                cmd2.Connection.Open()
                cmd2.ExecuteNonQuery()
                cmd2.Connection.Close()
            End If
            Call bloquea()

        Else
            MetroMessageBox.Show(Me, "Ese c�digo ya existe", "Atenci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcod.Focus()
        End If
    End Sub

    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If e.KeyCode = Keys.Delete Then
            ms = MetroMessageBox.Show(Me, "�Desea eliminar " + dg.CurrentRow.Cells("Descripcion").Value + " ?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If ms = 1 Then
                Call eliminalinea()
            End If
        End If
    End Sub

    Private Sub eliminalinea()
        'elimina la fila de la grilla
        idl = Trim(dg.CurrentRow.Cells("ID").Value)
        If idl <> "" Then
            sql4 = "delete from tipmad where tipmad_id='" + idl + "' "
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()
            Call buscadatos()
            dg.DataSource = dt
            If dt.Rows.Count <> 0 Then
                dg.Select()
            Else
                btnEditar.Enabled = False
                btnBorrar.Enabled = False
            End If
        Else
        End If

    End Sub

End Class
