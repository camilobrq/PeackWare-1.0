
namespace Presentacion
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnBarraArriba = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Btnmaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnRestablecer = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.PnOpciones = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConsultar = new System.Windows.Forms.Panel();
            this.BtnConsultaFactura = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.BtnConsultaCliente = new System.Windows.Forms.Button();
            this.BtnConsultaProveedores = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.panelFactura = new System.Windows.Forms.Panel();
            this.BtnFacturaVenta = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.BtnFacturaCompra = new System.Windows.Forms.Button();
            this.BtnFactura = new System.Windows.Forms.Button();
            this.panelRegistrar = new System.Windows.Forms.Panel();
            this.BtnRegistroProveedores = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnRegistroClientes = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Magneto = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BtnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnProdu = new System.Windows.Forms.Button();
            this.pnBarraArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestablecer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.PnOpciones.SuspendLayout();
            this.panelConsultar.SuspendLayout();
            this.panelFactura.SuspendLayout();
            this.panelRegistrar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Magneto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnBarraArriba
            // 
            this.pnBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.pnBarraArriba.Controls.Add(this.label8);
            this.pnBarraArriba.Controls.Add(this.BtnMinimizar);
            this.pnBarraArriba.Controls.Add(this.Btnmaximizar);
            this.pnBarraArriba.Controls.Add(this.BtnRestablecer);
            this.pnBarraArriba.Controls.Add(this.BtnCerrar);
            this.LogoTransition.SetDecoration(this.pnBarraArriba, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.pnBarraArriba, BunifuAnimatorNS.DecorationType.None);
            this.pnBarraArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarraArriba.Location = new System.Drawing.Point(0, 0);
            this.pnBarraArriba.Name = "pnBarraArriba";
            this.pnBarraArriba.Size = new System.Drawing.Size(931, 52);
            this.pnBarraArriba.TabIndex = 0;
            this.pnBarraArriba.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBarraArriba_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "PeackWare";
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.BtnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.BtnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.ImageActive = null;
            this.BtnMinimizar.Location = new System.Drawing.Point(822, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(28, 24);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Zoom = 10;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // Btnmaximizar
            // 
            this.Btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnmaximizar.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.Btnmaximizar, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Btnmaximizar, BunifuAnimatorNS.DecorationType.None);
            this.Btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("Btnmaximizar.Image")));
            this.Btnmaximizar.ImageActive = null;
            this.Btnmaximizar.Location = new System.Drawing.Point(856, 3);
            this.Btnmaximizar.Name = "Btnmaximizar";
            this.Btnmaximizar.Size = new System.Drawing.Size(28, 24);
            this.Btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btnmaximizar.TabIndex = 2;
            this.Btnmaximizar.TabStop = false;
            this.Btnmaximizar.Zoom = 10;
            this.Btnmaximizar.Click += new System.EventHandler(this.Btnmaximizar_Click);
            // 
            // BtnRestablecer
            // 
            this.BtnRestablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestablecer.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.BtnRestablecer, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.BtnRestablecer, BunifuAnimatorNS.DecorationType.None);
            this.BtnRestablecer.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestablecer.Image")));
            this.BtnRestablecer.ImageActive = null;
            this.BtnRestablecer.Location = new System.Drawing.Point(856, 3);
            this.BtnRestablecer.Name = "BtnRestablecer";
            this.BtnRestablecer.Size = new System.Drawing.Size(28, 24);
            this.BtnRestablecer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestablecer.TabIndex = 1;
            this.BtnRestablecer.TabStop = false;
            this.BtnRestablecer.Visible = false;
            this.BtnRestablecer.Zoom = 10;
            this.BtnRestablecer.Click += new System.EventHandler(this.BtnRestablecer_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.BtnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.BtnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.ImageActive = null;
            this.BtnCerrar.Location = new System.Drawing.Point(891, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(28, 24);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Zoom = 10;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PnOpciones
            // 
            this.PnOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.PnOpciones.Controls.Add(this.label1);
            this.PnOpciones.Controls.Add(this.panelConsultar);
            this.PnOpciones.Controls.Add(this.BtnConsulta);
            this.PnOpciones.Controls.Add(this.panelFactura);
            this.PnOpciones.Controls.Add(this.BtnFactura);
            this.PnOpciones.Controls.Add(this.panelRegistrar);
            this.PnOpciones.Controls.Add(this.BtnRegistrar);
            this.PnOpciones.Controls.Add(this.panel1);
            this.LogoTransition.SetDecoration(this.PnOpciones, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.PnOpciones, BunifuAnimatorNS.DecorationType.None);
            this.PnOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnOpciones.Location = new System.Drawing.Point(0, 52);
            this.PnOpciones.Name = "PnOpciones";
            this.PnOpciones.Size = new System.Drawing.Size(194, 736);
            this.PnOpciones.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 711);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "PeackWare";
            // 
            // panelConsultar
            // 
            this.panelConsultar.Controls.Add(this.panel3);
            this.panelConsultar.Controls.Add(this.BtnProdu);
            this.panelConsultar.Controls.Add(this.BtnConsultaFactura);
            this.panelConsultar.Controls.Add(this.panel14);
            this.panelConsultar.Controls.Add(this.panel15);
            this.panelConsultar.Controls.Add(this.BtnConsultaCliente);
            this.panelConsultar.Controls.Add(this.BtnConsultaProveedores);
            this.panelConsultar.Controls.Add(this.panel13);
            this.LogoTransition.SetDecoration(this.panelConsultar, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panelConsultar, BunifuAnimatorNS.DecorationType.None);
            this.panelConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConsultar.Location = new System.Drawing.Point(0, 487);
            this.panelConsultar.Name = "panelConsultar";
            this.panelConsultar.Size = new System.Drawing.Size(194, 168);
            this.panelConsultar.TabIndex = 15;
            this.panelConsultar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsultar_Paint);
            // 
            // BtnConsultaFactura
            // 
            this.BtnConsultaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnConsultaFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnConsultaFactura, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnConsultaFactura, BunifuAnimatorNS.DecorationType.None);
            this.BtnConsultaFactura.FlatAppearance.BorderSize = 0;
            this.BtnConsultaFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnConsultaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaFactura.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultaFactura.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultaFactura.Image")));
            this.BtnConsultaFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaFactura.Location = new System.Drawing.Point(35, 88);
            this.BtnConsultaFactura.Name = "BtnConsultaFactura";
            this.BtnConsultaFactura.Size = new System.Drawing.Size(162, 35);
            this.BtnConsultaFactura.TabIndex = 20;
            this.BtnConsultaFactura.Text = "C. Factura";
            this.BtnConsultaFactura.UseVisualStyleBackColor = false;
            this.BtnConsultaFactura.Click += new System.EventHandler(this.BtnConsultaFactura_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.LogoTransition.SetDecoration(this.panel14, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel14, BunifuAnimatorNS.DecorationType.None);
            this.panel14.Location = new System.Drawing.Point(26, 6);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 35);
            this.panel14.TabIndex = 18;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.LogoTransition.SetDecoration(this.panel15, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel15, BunifuAnimatorNS.DecorationType.None);
            this.panel15.Location = new System.Drawing.Point(26, 88);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(10, 35);
            this.panel15.TabIndex = 23;
            this.panel15.Paint += new System.Windows.Forms.PaintEventHandler(this.panel15_Paint);
            // 
            // BtnConsultaCliente
            // 
            this.BtnConsultaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnConsultaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnConsultaCliente, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnConsultaCliente, BunifuAnimatorNS.DecorationType.None);
            this.BtnConsultaCliente.FlatAppearance.BorderSize = 0;
            this.BtnConsultaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnConsultaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultaCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultaCliente.Image")));
            this.BtnConsultaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaCliente.Location = new System.Drawing.Point(35, 6);
            this.BtnConsultaCliente.Name = "BtnConsultaCliente";
            this.BtnConsultaCliente.Size = new System.Drawing.Size(162, 35);
            this.BtnConsultaCliente.TabIndex = 22;
            this.BtnConsultaCliente.Text = "C. Clientes";
            this.BtnConsultaCliente.UseVisualStyleBackColor = false;
            this.BtnConsultaCliente.Click += new System.EventHandler(this.BtnConsultaCliente_Click);
            // 
            // BtnConsultaProveedores
            // 
            this.BtnConsultaProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnConsultaProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnConsultaProveedores, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnConsultaProveedores, BunifuAnimatorNS.DecorationType.None);
            this.BtnConsultaProveedores.FlatAppearance.BorderSize = 0;
            this.BtnConsultaProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnConsultaProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaProveedores.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaProveedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultaProveedores.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultaProveedores.Image")));
            this.BtnConsultaProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaProveedores.Location = new System.Drawing.Point(38, 47);
            this.BtnConsultaProveedores.Name = "BtnConsultaProveedores";
            this.BtnConsultaProveedores.Size = new System.Drawing.Size(162, 35);
            this.BtnConsultaProveedores.TabIndex = 21;
            this.BtnConsultaProveedores.Text = "        C. Proveedores";
            this.BtnConsultaProveedores.UseVisualStyleBackColor = false;
            this.BtnConsultaProveedores.Click += new System.EventHandler(this.BtnConsultaProveedores_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.LogoTransition.SetDecoration(this.panel13, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel13, BunifuAnimatorNS.DecorationType.None);
            this.panel13.Location = new System.Drawing.Point(26, 47);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 35);
            this.panel13.TabIndex = 19;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnConsulta, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnConsulta, BunifuAnimatorNS.DecorationType.None);
            this.BtnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsulta.FlatAppearance.BorderSize = 0;
            this.BtnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsulta.Image")));
            this.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsulta.Location = new System.Drawing.Point(0, 442);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(194, 45);
            this.BtnConsulta.TabIndex = 14;
            this.BtnConsulta.Text = "     Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = false;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click_1);
            // 
            // panelFactura
            // 
            this.panelFactura.Controls.Add(this.BtnFacturaVenta);
            this.panelFactura.Controls.Add(this.panel10);
            this.panelFactura.Controls.Add(this.panel11);
            this.panelFactura.Controls.Add(this.BtnFacturaCompra);
            this.LogoTransition.SetDecoration(this.panelFactura, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panelFactura, BunifuAnimatorNS.DecorationType.None);
            this.panelFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFactura.Location = new System.Drawing.Point(0, 345);
            this.panelFactura.Name = "panelFactura";
            this.panelFactura.Size = new System.Drawing.Size(194, 97);
            this.panelFactura.TabIndex = 13;
            // 
            // BtnFacturaVenta
            // 
            this.BtnFacturaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnFacturaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnFacturaVenta, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnFacturaVenta, BunifuAnimatorNS.DecorationType.None);
            this.BtnFacturaVenta.FlatAppearance.BorderSize = 0;
            this.BtnFacturaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnFacturaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturaVenta.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturaVenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFacturaVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacturaVenta.Image")));
            this.BtnFacturaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturaVenta.Location = new System.Drawing.Point(38, 53);
            this.BtnFacturaVenta.Name = "BtnFacturaVenta";
            this.BtnFacturaVenta.Size = new System.Drawing.Size(150, 35);
            this.BtnFacturaVenta.TabIndex = 14;
            this.BtnFacturaVenta.Text = "Venta";
            this.BtnFacturaVenta.UseVisualStyleBackColor = false;
            this.BtnFacturaVenta.Click += new System.EventHandler(this.BtnFacturaVenta_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.LogoTransition.SetDecoration(this.panel10, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel10, BunifuAnimatorNS.DecorationType.None);
            this.panel10.Location = new System.Drawing.Point(26, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 35);
            this.panel10.TabIndex = 13;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.LogoTransition.SetDecoration(this.panel11, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel11, BunifuAnimatorNS.DecorationType.None);
            this.panel11.Location = new System.Drawing.Point(26, 53);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 35);
            this.panel11.TabIndex = 15;
            // 
            // BtnFacturaCompra
            // 
            this.BtnFacturaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnFacturaCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnFacturaCompra, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnFacturaCompra, BunifuAnimatorNS.DecorationType.None);
            this.BtnFacturaCompra.FlatAppearance.BorderSize = 0;
            this.BtnFacturaCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnFacturaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturaCompra.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturaCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFacturaCompra.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacturaCompra.Image")));
            this.BtnFacturaCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturaCompra.Location = new System.Drawing.Point(35, 3);
            this.BtnFacturaCompra.Name = "BtnFacturaCompra";
            this.BtnFacturaCompra.Size = new System.Drawing.Size(150, 35);
            this.BtnFacturaCompra.TabIndex = 12;
            this.BtnFacturaCompra.Text = "Compra";
            this.BtnFacturaCompra.UseVisualStyleBackColor = false;
            this.BtnFacturaCompra.Click += new System.EventHandler(this.BtnFacturaCompra_Click);
            // 
            // BtnFactura
            // 
            this.BtnFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnFactura, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnFactura, BunifuAnimatorNS.DecorationType.None);
            this.BtnFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFactura.FlatAppearance.BorderSize = 0;
            this.BtnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFactura.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFactura.Image = ((System.Drawing.Image)(resources.GetObject("BtnFactura.Image")));
            this.BtnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFactura.Location = new System.Drawing.Point(0, 300);
            this.BtnFactura.Name = "BtnFactura";
            this.BtnFactura.Size = new System.Drawing.Size(194, 45);
            this.BtnFactura.TabIndex = 12;
            this.BtnFactura.Text = "      Facturar";
            this.BtnFactura.UseVisualStyleBackColor = false;
            this.BtnFactura.Click += new System.EventHandler(this.BtnFactura_Click_1);
            // 
            // panelRegistrar
            // 
            this.panelRegistrar.Controls.Add(this.panel2);
            this.panelRegistrar.Controls.Add(this.BtnRegistroProveedores);
            this.panelRegistrar.Controls.Add(this.BtnProducto);
            this.panelRegistrar.Controls.Add(this.panel7);
            this.panelRegistrar.Controls.Add(this.BtnRegistroClientes);
            this.panelRegistrar.Controls.Add(this.panel8);
            this.LogoTransition.SetDecoration(this.panelRegistrar, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panelRegistrar, BunifuAnimatorNS.DecorationType.None);
            this.panelRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistrar.Location = new System.Drawing.Point(0, 154);
            this.panelRegistrar.Name = "panelRegistrar";
            this.panelRegistrar.Size = new System.Drawing.Size(194, 146);
            this.panelRegistrar.TabIndex = 11;
            // 
            // BtnRegistroProveedores
            // 
            this.BtnRegistroProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnRegistroProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnRegistroProveedores, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnRegistroProveedores, BunifuAnimatorNS.DecorationType.None);
            this.BtnRegistroProveedores.FlatAppearance.BorderSize = 0;
            this.BtnRegistroProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnRegistroProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroProveedores.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroProveedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistroProveedores.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroProveedores.Image")));
            this.BtnRegistroProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistroProveedores.Location = new System.Drawing.Point(35, 56);
            this.BtnRegistroProveedores.Name = "BtnRegistroProveedores";
            this.BtnRegistroProveedores.Size = new System.Drawing.Size(157, 35);
            this.BtnRegistroProveedores.TabIndex = 12;
            this.BtnRegistroProveedores.Text = "             Proveedores";
            this.BtnRegistroProveedores.UseVisualStyleBackColor = false;
            this.BtnRegistroProveedores.Click += new System.EventHandler(this.BtnRegistroProveedores_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.LogoTransition.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.panel7.Location = new System.Drawing.Point(26, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 35);
            this.panel7.TabIndex = 11;
            // 
            // BtnRegistroClientes
            // 
            this.BtnRegistroClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnRegistroClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnRegistroClientes, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnRegistroClientes, BunifuAnimatorNS.DecorationType.None);
            this.BtnRegistroClientes.FlatAppearance.BorderSize = 0;
            this.BtnRegistroClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnRegistroClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistroClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroClientes.Image")));
            this.BtnRegistroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistroClientes.Location = new System.Drawing.Point(35, 6);
            this.BtnRegistroClientes.Name = "BtnRegistroClientes";
            this.BtnRegistroClientes.Size = new System.Drawing.Size(157, 35);
            this.BtnRegistroClientes.TabIndex = 10;
            this.BtnRegistroClientes.Text = "     Clientes";
            this.BtnRegistroClientes.UseVisualStyleBackColor = false;
            this.BtnRegistroClientes.Click += new System.EventHandler(this.BtnRegistroClientes_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.LogoTransition.SetDecoration(this.panel8, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel8, BunifuAnimatorNS.DecorationType.None);
            this.panel8.Location = new System.Drawing.Point(26, 56);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(24, 35);
            this.panel8.TabIndex = 13;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnRegistrar, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnRegistrar, BunifuAnimatorNS.DecorationType.None);
            this.BtnRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrar.Image")));
            this.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.Location = new System.Drawing.Point(0, 109);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(194, 45);
            this.BtnRegistrar.TabIndex = 10;
            this.BtnRegistrar.Text = "     Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Magneto);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.BtnMenu);
            this.LogoTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 109);
            this.panel1.TabIndex = 10;
            // 
            // Magneto
            // 
            this.PanelTransition.SetDecoration(this.Magneto, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Magneto, BunifuAnimatorNS.DecorationType.None);
            this.Magneto.Image = ((System.Drawing.Image)(resources.GetObject("Magneto.Image")));
            this.Magneto.Location = new System.Drawing.Point(12, 6);
            this.Magneto.Name = "Magneto";
            this.Magneto.Size = new System.Drawing.Size(68, 56);
            this.Magneto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Magneto.TabIndex = 9;
            this.Magneto.TabStop = false;
            this.Magneto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(6, 68);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(185, 35);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageActive = null;
            this.BtnMenu.Location = new System.Drawing.Point(152, 6);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(36, 33);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenu.TabIndex = 4;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Zoom = 10;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.LogoTransition.SetDecoration(this.PanelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.PanelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(194, 52);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(737, 736);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PnPrincipal_Paint);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnBarraArriba;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation3;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoTransition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0.5F;
            animation4.RotateLimit = 0.2F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.LogoTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(26, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 35);
            this.panel2.TabIndex = 24;
            // 
            // BtnProducto
            // 
            this.BtnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnProducto, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnProducto, BunifuAnimatorNS.DecorationType.None);
            this.BtnProducto.FlatAppearance.BorderSize = 0;
            this.BtnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnProducto.Image")));
            this.BtnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducto.Location = new System.Drawing.Point(35, 97);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(157, 35);
            this.BtnProducto.TabIndex = 25;
            this.BtnProducto.Text = "      Producto";
            this.BtnProducto.UseVisualStyleBackColor = false;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.LogoTransition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(26, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 35);
            this.panel3.TabIndex = 24;
            // 
            // BtnProdu
            // 
            this.BtnProdu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnProdu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnProdu, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnProdu, BunifuAnimatorNS.DecorationType.None);
            this.BtnProdu.FlatAppearance.BorderSize = 0;
            this.BtnProdu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnProdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdu.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnProdu.Image = ((System.Drawing.Image)(resources.GetObject("BtnProdu.Image")));
            this.BtnProdu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdu.Location = new System.Drawing.Point(35, 129);
            this.BtnProdu.Name = "BtnProdu";
            this.BtnProdu.Size = new System.Drawing.Size(162, 35);
            this.BtnProdu.TabIndex = 25;
            this.BtnProdu.Text = "    C. Productos";
            this.BtnProdu.UseVisualStyleBackColor = false;
            this.BtnProdu.Click += new System.EventHandler(this.BtnProdu_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 788);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PnOpciones);
            this.Controls.Add(this.pnBarraArriba);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnBarraArriba.ResumeLayout(false);
            this.pnBarraArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestablecer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.PnOpciones.ResumeLayout(false);
            this.PnOpciones.PerformLayout();
            this.panelConsultar.ResumeLayout(false);
            this.panelFactura.ResumeLayout(false);
            this.panelRegistrar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Magneto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel PnOpciones;
        private System.Windows.Forms.Panel pnBarraArriba;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox Magneto;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton BtnMenu;
        private Bunifu.Framework.UI.BunifuImageButton BtnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton Btnmaximizar;
        private Bunifu.Framework.UI.BunifuImageButton BtnRestablecer;
        private Bunifu.Framework.UI.BunifuImageButton BtnCerrar;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private System.Windows.Forms.Button BtnRegistroProveedores;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BtnRegistroClientes;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnFacturaVenta;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button BtnFacturaCompra;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button BtnConsultaFactura;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button BtnConsultaProveedores;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button BtnConsultaCliente;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRegistrar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Panel panelFactura;
        private System.Windows.Forms.Button BtnFactura;
        private System.Windows.Forms.Panel panelConsultar;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnProdu;
    }
}

