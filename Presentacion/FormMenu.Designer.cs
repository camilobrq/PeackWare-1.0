
namespace Presentacion
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.PnBarraArriba = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnRestablecer = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelSubmenu3 = new System.Windows.Forms.Panel();
            this.BtnConsultaFactura = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.BtnConsultaProveedores = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.BtnConsultaCliente = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PanelSubmenu2 = new System.Windows.Forms.Panel();
            this.BtnFacturaVenta = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.BtnFacturaCompra = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.BtnFactura = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelSubmenu = new System.Windows.Forms.Panel();
            this.BtnRegistroProveedores = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BtnRegistroClientes = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Panel();
            this.DeslizarRegistro = new System.Windows.Forms.Timer(this.components);
            this.DeslizarFactura = new System.Windows.Forms.Timer(this.components);
            this.DeslizarConsulta = new System.Windows.Forms.Timer(this.components);
            this.Minregistro = new System.Windows.Forms.Timer(this.components);
            this.MinFactura = new System.Windows.Forms.Timer(this.components);
            this.MinConsulta = new System.Windows.Forms.Timer(this.components);
            this.BtnRegistro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnBarraArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestablecer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelSubmenu3.SuspendLayout();
            this.PanelSubmenu2.SuspendLayout();
            this.PanelSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.btnCerrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnBarraArriba
            // 
            this.PnBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.PnBarraArriba.Controls.Add(this.pictureBox2);
            this.PnBarraArriba.Controls.Add(this.BtnMinimizar);
            this.PnBarraArriba.Controls.Add(this.BtnRestablecer);
            this.PnBarraArriba.Controls.Add(this.BtnMaximizar);
            this.PnBarraArriba.Controls.Add(this.pictureBox1);
            this.PnBarraArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnBarraArriba.Location = new System.Drawing.Point(0, 0);
            this.PnBarraArriba.Name = "PnBarraArriba";
            this.PnBarraArriba.Size = new System.Drawing.Size(1051, 45);
            this.PnBarraArriba.TabIndex = 0;
            this.PnBarraArriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnBarraArriba_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(951, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnRestablecer
            // 
            this.BtnRestablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestablecer.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestablecer.Image")));
            this.BtnRestablecer.Location = new System.Drawing.Point(982, 3);
            this.BtnRestablecer.Name = "BtnRestablecer";
            this.BtnRestablecer.Size = new System.Drawing.Size(25, 25);
            this.BtnRestablecer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestablecer.TabIndex = 2;
            this.BtnRestablecer.TabStop = false;
            this.BtnRestablecer.Visible = false;
            this.BtnRestablecer.Click += new System.EventHandler(this.BtnRestablecer_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(982, 3);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximizar.TabIndex = 1;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1013, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.PanelSubmenu3);
            this.panel1.Controls.Add(this.PanelSubmenu2);
            this.panel1.Controls.Add(this.PanelSubmenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 699);
            this.panel1.TabIndex = 1;
            // 
            // PanelSubmenu3
            // 
            this.PanelSubmenu3.Controls.Add(this.BtnConsultaFactura);
            this.PanelSubmenu3.Controls.Add(this.panel15);
            this.PanelSubmenu3.Controls.Add(this.BtnConsultaProveedores);
            this.PanelSubmenu3.Controls.Add(this.panel13);
            this.PanelSubmenu3.Controls.Add(this.BtnConsultaCliente);
            this.PanelSubmenu3.Controls.Add(this.panel14);
            this.PanelSubmenu3.Controls.Add(this.BtnConsulta);
            this.PanelSubmenu3.Controls.Add(this.panel5);
            this.PanelSubmenu3.Location = new System.Drawing.Point(3, 235);
            this.PanelSubmenu3.Name = "PanelSubmenu3";
            this.PanelSubmenu3.Size = new System.Drawing.Size(200, 51);
            this.PanelSubmenu3.TabIndex = 10;
            // 
            // BtnConsultaFactura
            // 
            this.BtnConsultaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnConsultaFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultaFactura.FlatAppearance.BorderSize = 0;
            this.BtnConsultaFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnConsultaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaFactura.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultaFactura.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultaFactura.Image")));
            this.BtnConsultaFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaFactura.Location = new System.Drawing.Point(31, 136);
            this.BtnConsultaFactura.Name = "BtnConsultaFactura";
            this.BtnConsultaFactura.Size = new System.Drawing.Size(169, 35);
            this.BtnConsultaFactura.TabIndex = 16;
            this.BtnConsultaFactura.Text = "C. Factura";
            this.BtnConsultaFactura.UseVisualStyleBackColor = false;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel15.Location = new System.Drawing.Point(22, 136);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(10, 35);
            this.panel15.TabIndex = 17;
            // 
            // BtnConsultaProveedores
            // 
            this.BtnConsultaProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnConsultaProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultaProveedores.FlatAppearance.BorderSize = 0;
            this.BtnConsultaProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnConsultaProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaProveedores.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaProveedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultaProveedores.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultaProveedores.Image")));
            this.BtnConsultaProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaProveedores.Location = new System.Drawing.Point(34, 95);
            this.BtnConsultaProveedores.Name = "BtnConsultaProveedores";
            this.BtnConsultaProveedores.Size = new System.Drawing.Size(169, 35);
            this.BtnConsultaProveedores.TabIndex = 16;
            this.BtnConsultaProveedores.Text = "        C. Proveedores";
            this.BtnConsultaProveedores.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel13.Location = new System.Drawing.Point(22, 95);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 35);
            this.panel13.TabIndex = 15;
            // 
            // BtnConsultaCliente
            // 
            this.BtnConsultaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnConsultaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultaCliente.FlatAppearance.BorderSize = 0;
            this.BtnConsultaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnConsultaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultaCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultaCliente.Image")));
            this.BtnConsultaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaCliente.Location = new System.Drawing.Point(31, 54);
            this.BtnConsultaCliente.Name = "BtnConsultaCliente";
            this.BtnConsultaCliente.Size = new System.Drawing.Size(169, 35);
            this.BtnConsultaCliente.TabIndex = 16;
            this.BtnConsultaCliente.Text = "C. Clientes";
            this.BtnConsultaCliente.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel14.Location = new System.Drawing.Point(22, 54);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 35);
            this.panel14.TabIndex = 13;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsulta.FlatAppearance.BorderSize = 0;
            this.BtnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsulta.Image")));
            this.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsulta.Location = new System.Drawing.Point(9, 3);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(168, 45);
            this.BtnConsulta.TabIndex = 4;
            this.BtnConsulta.Text = "     Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = false;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 45);
            this.panel5.TabIndex = 7;
            // 
            // PanelSubmenu2
            // 
            this.PanelSubmenu2.Controls.Add(this.BtnFacturaVenta);
            this.PanelSubmenu2.Controls.Add(this.panel11);
            this.PanelSubmenu2.Controls.Add(this.BtnFacturaCompra);
            this.PanelSubmenu2.Controls.Add(this.panel10);
            this.PanelSubmenu2.Controls.Add(this.BtnFactura);
            this.PanelSubmenu2.Controls.Add(this.panel4);
            this.PanelSubmenu2.Location = new System.Drawing.Point(3, 175);
            this.PanelSubmenu2.Name = "PanelSubmenu2";
            this.PanelSubmenu2.Size = new System.Drawing.Size(205, 54);
            this.PanelSubmenu2.TabIndex = 9;
            // 
            // BtnFacturaVenta
            // 
            this.BtnFacturaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnFacturaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturaVenta.FlatAppearance.BorderSize = 0;
            this.BtnFacturaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnFacturaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturaVenta.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturaVenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFacturaVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacturaVenta.Image")));
            this.BtnFacturaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturaVenta.Location = new System.Drawing.Point(34, 104);
            this.BtnFacturaVenta.Name = "BtnFacturaVenta";
            this.BtnFacturaVenta.Size = new System.Drawing.Size(171, 35);
            this.BtnFacturaVenta.TabIndex = 10;
            this.BtnFacturaVenta.Text = "Venta";
            this.BtnFacturaVenta.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel11.Location = new System.Drawing.Point(22, 104);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 35);
            this.panel11.TabIndex = 11;
            // 
            // BtnFacturaCompra
            // 
            this.BtnFacturaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnFacturaCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturaCompra.FlatAppearance.BorderSize = 0;
            this.BtnFacturaCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnFacturaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturaCompra.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturaCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFacturaCompra.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacturaCompra.Image")));
            this.BtnFacturaCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturaCompra.Location = new System.Drawing.Point(31, 54);
            this.BtnFacturaCompra.Name = "BtnFacturaCompra";
            this.BtnFacturaCompra.Size = new System.Drawing.Size(171, 35);
            this.BtnFacturaCompra.TabIndex = 8;
            this.BtnFacturaCompra.Text = "Compra";
            this.BtnFacturaCompra.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel10.Location = new System.Drawing.Point(22, 54);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 35);
            this.panel10.TabIndex = 9;
            // 
            // BtnFactura
            // 
            this.BtnFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFactura.FlatAppearance.BorderSize = 0;
            this.BtnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFactura.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFactura.Image = ((System.Drawing.Image)(resources.GetObject("BtnFactura.Image")));
            this.BtnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFactura.Location = new System.Drawing.Point(12, 3);
            this.BtnFactura.Name = "BtnFactura";
            this.BtnFactura.Size = new System.Drawing.Size(168, 45);
            this.BtnFactura.TabIndex = 3;
            this.BtnFactura.Text = "      Facturar";
            this.BtnFactura.UseVisualStyleBackColor = false;
            this.BtnFactura.Click += new System.EventHandler(this.BtnFactura_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 45);
            this.panel4.TabIndex = 6;
            // 
            // PanelSubmenu
            // 
            this.PanelSubmenu.Controls.Add(this.BtnRegistro);
            this.PanelSubmenu.Controls.Add(this.BtnRegistroProveedores);
            this.PanelSubmenu.Controls.Add(this.panel8);
            this.PanelSubmenu.Controls.Add(this.BtnRegistroClientes);
            this.PanelSubmenu.Controls.Add(this.panel7);
            this.PanelSubmenu.Location = new System.Drawing.Point(0, 115);
            this.PanelSubmenu.Name = "PanelSubmenu";
            this.PanelSubmenu.Size = new System.Drawing.Size(205, 54);
            this.PanelSubmenu.TabIndex = 8;
            // 
            // BtnRegistroProveedores
            // 
            this.BtnRegistroProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnRegistroProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistroProveedores.FlatAppearance.BorderSize = 0;
            this.BtnRegistroProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnRegistroProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroProveedores.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroProveedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistroProveedores.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroProveedores.Image")));
            this.BtnRegistroProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistroProveedores.Location = new System.Drawing.Point(31, 104);
            this.BtnRegistroProveedores.Name = "BtnRegistroProveedores";
            this.BtnRegistroProveedores.Size = new System.Drawing.Size(171, 35);
            this.BtnRegistroProveedores.TabIndex = 8;
            this.BtnRegistroProveedores.Text = "             Proveedores";
            this.BtnRegistroProveedores.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel8.Location = new System.Drawing.Point(22, 104);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 35);
            this.panel8.TabIndex = 9;
            // 
            // BtnRegistroClientes
            // 
            this.BtnRegistroClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnRegistroClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistroClientes.FlatAppearance.BorderSize = 0;
            this.BtnRegistroClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnRegistroClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistroClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroClientes.Image")));
            this.BtnRegistroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistroClientes.Location = new System.Drawing.Point(31, 54);
            this.BtnRegistroClientes.Name = "BtnRegistroClientes";
            this.BtnRegistroClientes.Size = new System.Drawing.Size(171, 35);
            this.BtnRegistroClientes.TabIndex = 6;
            this.BtnRegistroClientes.Text = "     Clientes";
            this.BtnRegistroClientes.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel7.Location = new System.Drawing.Point(22, 54);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 35);
            this.panel7.TabIndex = 7;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrar.Image")));
            this.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.Location = new System.Drawing.Point(104, 79);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(168, 45);
            this.BtnRegistrar.TabIndex = 0;
            this.BtnRegistrar.Text = "     Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel3.Location = new System.Drawing.Point(88, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 45);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel2.Location = new System.Drawing.Point(6, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 3);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCerrar.Controls.Add(this.BtnRegistrar);
            this.btnCerrar.Controls.Add(this.panel3);
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrar.Location = new System.Drawing.Point(205, 45);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(846, 699);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCerrar_Paint);
            // 
            // DeslizarRegistro
            // 
            this.DeslizarRegistro.Interval = 2;
            this.DeslizarRegistro.Tick += new System.EventHandler(this.DeslizarRegistro_Tick);
            // 
            // DeslizarFactura
            // 
            this.DeslizarFactura.Interval = 2;
            this.DeslizarFactura.Tick += new System.EventHandler(this.DeslizarFactura_Tick);
            // 
            // DeslizarConsulta
            // 
            this.DeslizarConsulta.Interval = 2;
            this.DeslizarConsulta.Tick += new System.EventHandler(this.DeslizarConsulta_Tick);
            // 
            // Minregistro
            // 
            this.Minregistro.Interval = 2;
            this.Minregistro.Tick += new System.EventHandler(this.Minregistro_Tick);
            // 
            // MinFactura
            // 
            this.MinFactura.Interval = 2;
            this.MinFactura.Tick += new System.EventHandler(this.MinFactura_Tick);
            // 
            // MinConsulta
            // 
            this.MinConsulta.Interval = 2;
            this.MinConsulta.Tick += new System.EventHandler(this.MinConsulta_Tick);
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnRegistro.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistro.BorderRadius = 0;
            this.BtnRegistro.ButtonText = "Registrar";
            this.BtnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistro.DisabledColor = System.Drawing.Color.Gray;
            this.BtnRegistro.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRegistro.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnRegistro.Iconimage")));
            this.BtnRegistro.Iconimage_right = null;
            this.BtnRegistro.Iconimage_right_Selected = null;
            this.BtnRegistro.Iconimage_Selected = null;
            this.BtnRegistro.IconMarginLeft = 0;
            this.BtnRegistro.IconMarginRight = 0;
            this.BtnRegistro.IconRightVisible = true;
            this.BtnRegistro.IconRightZoom = 0D;
            this.BtnRegistro.IconVisible = true;
            this.BtnRegistro.IconZoom = 90D;
            this.BtnRegistro.IsTab = false;
            this.BtnRegistro.Location = new System.Drawing.Point(9, 0);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnRegistro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnRegistro.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.BtnRegistro.selected = false;
            this.BtnRegistro.Size = new System.Drawing.Size(190, 48);
            this.BtnRegistro.TabIndex = 10;
            this.BtnRegistro.Text = "Registrar";
            this.BtnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistro.Textcolor = System.Drawing.Color.White;
            this.BtnRegistro.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 744);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnBarraArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.PnBarraArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestablecer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PanelSubmenu3.ResumeLayout(false);
            this.PanelSubmenu2.ResumeLayout(false);
            this.PanelSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.btnCerrar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnBarraArriba;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnRestablecer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnFactura;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelSubmenu2;
        private System.Windows.Forms.Button BtnFacturaVenta;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button BtnFacturaCompra;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel PanelSubmenu;
        private System.Windows.Forms.Button BtnRegistroProveedores;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BtnRegistroClientes;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel PanelSubmenu3;
        private System.Windows.Forms.Button BtnConsultaFactura;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button BtnConsultaProveedores;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button BtnConsultaCliente;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Timer DeslizarRegistro;
        private System.Windows.Forms.Timer DeslizarFactura;
        private System.Windows.Forms.Timer DeslizarConsulta;
        private System.Windows.Forms.Timer Minregistro;
        private System.Windows.Forms.Timer MinFactura;
        private System.Windows.Forms.Timer MinConsulta;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRegistro;
    }
}