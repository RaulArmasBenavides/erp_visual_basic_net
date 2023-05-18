<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MnuAlmacen = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoríasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuIngresos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuAcceso = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuConsultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JustifyTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewMailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.S1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActiveDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LDAPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleAPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalendarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TsVentas = New System.Windows.Forms.ToolStripButton()
        Me.TsCompras = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.TsBarraInferior = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.AuthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JWTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerToServerOauthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuAlmacen, Me.MnuIngresos, Me.MnuVentas, Me.MnuAcceso, Me.MnuConsultas, Me.ViewMenu, Me.WindowsMenu, Me.Form1ToolStripMenuItem, Me.MailToolStripMenuItem, Me.ShellToolStripMenuItem, Me.ActiveDirectoryToolStripMenuItem, Me.APIToolStripMenuItem, Me.HelpMenu, Me.MnuSalir})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1676, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MnuAlmacen
        '
        Me.MnuAlmacen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoríasToolStripMenuItem, Me.ArtículosToolStripMenuItem})
        Me.MnuAlmacen.Name = "MnuAlmacen"
        Me.MnuAlmacen.Size = New System.Drawing.Size(66, 20)
        Me.MnuAlmacen.Text = "Almacén"
        '
        'CategoríasToolStripMenuItem
        '
        Me.CategoríasToolStripMenuItem.Name = "CategoríasToolStripMenuItem"
        Me.CategoríasToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CategoríasToolStripMenuItem.Text = "Cate&gorías"
        '
        'ArtículosToolStripMenuItem
        '
        Me.ArtículosToolStripMenuItem.Name = "ArtículosToolStripMenuItem"
        Me.ArtículosToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ArtículosToolStripMenuItem.Text = "&Artículos"
        '
        'MnuIngresos
        '
        Me.MnuIngresos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.MnuIngresos.Name = "MnuIngresos"
        Me.MnuIngresos.Size = New System.Drawing.Size(63, 20)
        Me.MnuIngresos.Text = "Ingresos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem.Text = "&Proveedores"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ComprasToolStripMenuItem.Text = "&Compras"
        '
        'MnuVentas
        '
        Me.MnuVentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.VentasToolStripMenuItem1})
        Me.MnuVentas.Name = "MnuVentas"
        Me.MnuVentas.Size = New System.Drawing.Size(53, 20)
        Me.MnuVentas.Text = "Ventas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ClientesToolStripMenuItem.Text = "Clien&tes"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.VentasToolStripMenuItem1.Text = "&Ventas"
        '
        'MnuAcceso
        '
        Me.MnuAcceso.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RolesToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.MnuAcceso.Name = "MnuAcceso"
        Me.MnuAcceso.Size = New System.Drawing.Size(57, 20)
        Me.MnuAcceso.Text = "Acceso"
        '
        'RolesToolStripMenuItem
        '
        Me.RolesToolStripMenuItem.Name = "RolesToolStripMenuItem"
        Me.RolesToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.RolesToolStripMenuItem.Text = "&Roles"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UsuariosToolStripMenuItem.Text = "&Usuarios"
        '
        'MnuConsultas
        '
        Me.MnuConsultas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaVentasToolStripMenuItem})
        Me.MnuConsultas.Name = "MnuConsultas"
        Me.MnuConsultas.Size = New System.Drawing.Size(71, 20)
        Me.MnuConsultas.Text = "Consultas"
        '
        'ConsultaVentasToolStripMenuItem
        '
        Me.ConsultaVentasToolStripMenuItem.Name = "ConsultaVentasToolStripMenuItem"
        Me.ConsultaVentasToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ConsultaVentasToolStripMenuItem.Text = "Consulta Ventas"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(44, 20)
        Me.ViewMenu.Text = "&View"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ToolBarToolStripMenuItem.Text = "&Toolbar"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NewWindowToolStripMenuItem.Text = "&New Window"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'Form1ToolStripMenuItem
        '
        Me.Form1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReadCSVToolStripMenuItem, Me.JustifyTextToolStripMenuItem})
        Me.Form1ToolStripMenuItem.Name = "Form1ToolStripMenuItem"
        Me.Form1ToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.Form1ToolStripMenuItem.Text = "Utils"
        '
        'ReadCSVToolStripMenuItem
        '
        Me.ReadCSVToolStripMenuItem.Name = "ReadCSVToolStripMenuItem"
        Me.ReadCSVToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReadCSVToolStripMenuItem.Text = "Read CSV"
        '
        'JustifyTextToolStripMenuItem
        '
        Me.JustifyTextToolStripMenuItem.Name = "JustifyTextToolStripMenuItem"
        Me.JustifyTextToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JustifyTextToolStripMenuItem.Text = "Justify Text"
        '
        'MailToolStripMenuItem
        '
        Me.MailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMailToolStripMenuItem})
        Me.MailToolStripMenuItem.Name = "MailToolStripMenuItem"
        Me.MailToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.MailToolStripMenuItem.Text = "Mail"
        '
        'NewMailToolStripMenuItem
        '
        Me.NewMailToolStripMenuItem.Name = "NewMailToolStripMenuItem"
        Me.NewMailToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewMailToolStripMenuItem.Text = "New Mail"
        '
        'ShellToolStripMenuItem
        '
        Me.ShellToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.S1ToolStripMenuItem})
        Me.ShellToolStripMenuItem.Name = "ShellToolStripMenuItem"
        Me.ShellToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ShellToolStripMenuItem.Text = "Shell"
        '
        'S1ToolStripMenuItem
        '
        Me.S1ToolStripMenuItem.Name = "S1ToolStripMenuItem"
        Me.S1ToolStripMenuItem.Size = New System.Drawing.Size(86, 22)
        Me.S1ToolStripMenuItem.Text = "S1"
        '
        'ActiveDirectoryToolStripMenuItem
        '
        Me.ActiveDirectoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LDAPToolStripMenuItem})
        Me.ActiveDirectoryToolStripMenuItem.Name = "ActiveDirectoryToolStripMenuItem"
        Me.ActiveDirectoryToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.ActiveDirectoryToolStripMenuItem.Text = "Active Directory"
        '
        'LDAPToolStripMenuItem
        '
        Me.LDAPToolStripMenuItem.Name = "LDAPToolStripMenuItem"
        Me.LDAPToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LDAPToolStripMenuItem.Text = "LDAP"
        '
        'APIToolStripMenuItem
        '
        Me.APIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.TeamsToolStripMenuItem, Me.GoogleAPIToolStripMenuItem})
        Me.APIToolStripMenuItem.Name = "APIToolStripMenuItem"
        Me.APIToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.APIToolStripMenuItem.Text = "API"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AuthToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem1.Text = "Zoom"
        '
        'TeamsToolStripMenuItem
        '
        Me.TeamsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccessToolStripMenuItem})
        Me.TeamsToolStripMenuItem.Name = "TeamsToolStripMenuItem"
        Me.TeamsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TeamsToolStripMenuItem.Text = "Teams"
        '
        'AccessToolStripMenuItem
        '
        Me.AccessToolStripMenuItem.Name = "AccessToolStripMenuItem"
        Me.AccessToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AccessToolStripMenuItem.Text = "Access"
        '
        'GoogleAPIToolStripMenuItem
        '
        Me.GoogleAPIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.CalendarsToolStripMenuItem})
        Me.GoogleAPIToolStripMenuItem.Name = "GoogleAPIToolStripMenuItem"
        Me.GoogleAPIToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GoogleAPIToolStripMenuItem.Text = "Google API"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(126, 22)
        '
        'CalendarsToolStripMenuItem
        '
        Me.CalendarsToolStripMenuItem.Name = "CalendarsToolStripMenuItem"
        Me.CalendarsToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CalendarsToolStripMenuItem.Text = "Calendars"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(181, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'MnuSalir
        '
        Me.MnuSalir.Name = "MnuSalir"
        Me.MnuSalir.Size = New System.Drawing.Size(41, 20)
        Me.MnuSalir.Text = "Salir"
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsVentas, Me.TsCompras})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1676, 27)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'TsVentas
        '
        Me.TsVentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsVentas.Image = Global.Sistema.Presentacion.My.Resources.Resources.ventas_m
        Me.TsVentas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsVentas.Name = "TsVentas"
        Me.TsVentas.Size = New System.Drawing.Size(24, 24)
        Me.TsVentas.Text = "ToolStripButton1"
        Me.TsVentas.ToolTipText = "Ventas"
        '
        'TsCompras
        '
        Me.TsCompras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsCompras.Image = Global.Sistema.Presentacion.My.Resources.Resources.compra_m
        Me.TsCompras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsCompras.Name = "TsCompras"
        Me.TsCompras.Size = New System.Drawing.Size(24, 24)
        Me.TsCompras.Text = "ToolStripButton1"
        Me.TsCompras.ToolTipText = "Compras"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsBarraInferior})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 772)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1676, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'TsBarraInferior
        '
        Me.TsBarraInferior.Name = "TsBarraInferior"
        Me.TsBarraInferior.Size = New System.Drawing.Size(262, 17)
        Me.TsBarraInferior.Text = "Desarrollado por Raúl Marcelo Armas Benavides "
        '
        'AuthToolStripMenuItem
        '
        Me.AuthToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JWTToolStripMenuItem1, Me.ServerToServerOauthToolStripMenuItem})
        Me.AuthToolStripMenuItem.Name = "AuthToolStripMenuItem"
        Me.AuthToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AuthToolStripMenuItem.Text = "Auth"
        '
        'JWTToolStripMenuItem1
        '
        Me.JWTToolStripMenuItem1.Name = "JWTToolStripMenuItem1"
        Me.JWTToolStripMenuItem1.Size = New System.Drawing.Size(199, 22)
        Me.JWTToolStripMenuItem1.Text = "JWT"
        '
        'ServerToServerOauthToolStripMenuItem
        '
        Me.ServerToServerOauthToolStripMenuItem.Name = "ServerToServerOauthToolStripMenuItem"
        Me.ServerToServerOauthToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ServerToServerOauthToolStripMenuItem.Text = "Server to Server (Oauth)"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1676, 794)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmPrincipal"
        Me.Text = ".:. Sistema Compras - Ventas .:."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents TsBarraInferior As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuAlmacen As ToolStripMenuItem
    Friend WithEvents CategoríasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtículosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuIngresos As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuVentas As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MnuAcceso As ToolStripMenuItem
    Friend WithEvents RolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuConsultas As ToolStripMenuItem
    Friend WithEvents ConsultaVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuSalir As ToolStripMenuItem
    Friend WithEvents TsVentas As ToolStripButton
    Friend WithEvents TsCompras As ToolStripButton
    Friend WithEvents Form1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReadCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewMailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JustifyTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents S1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActiveDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LDAPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents APIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TeamsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoogleAPIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CalendarsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JWTToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ServerToServerOauthToolStripMenuItem As ToolStripMenuItem
End Class
