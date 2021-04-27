
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
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnBarraArriba = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Btnmaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnRestablecer = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.PnOpciones = new System.Windows.Forms.Panel();
            this.Magneto = new System.Windows.Forms.PictureBox();
            this.BtnConsulta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnFactura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BtnRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.PnPrincipal = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnBarraArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestablecer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.PnOpciones.SuspendLayout();
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
            this.pnBarraArriba.Controls.Add(this.BtnMinimizar);
            this.pnBarraArriba.Controls.Add(this.Btnmaximizar);
            this.pnBarraArriba.Controls.Add(this.BtnRestablecer);
            this.pnBarraArriba.Controls.Add(this.BtnCerrar);
            this.LogoTransition.SetDecoration(this.pnBarraArriba, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.pnBarraArriba, BunifuAnimatorNS.DecorationType.None);
            this.pnBarraArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarraArriba.Location = new System.Drawing.Point(0, 0);
            this.pnBarraArriba.Name = "pnBarraArriba";
            this.pnBarraArriba.Size = new System.Drawing.Size(800, 52);
            this.pnBarraArriba.TabIndex = 0;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.BtnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.BtnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.ImageActive = null;
            this.BtnMinimizar.Location = new System.Drawing.Point(691, 3);
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
            this.Btnmaximizar.Location = new System.Drawing.Point(725, 3);
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
            this.BtnRestablecer.Location = new System.Drawing.Point(725, 3);
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
            this.BtnCerrar.Location = new System.Drawing.Point(760, 3);
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
            this.PnOpciones.Controls.Add(this.Magneto);
            this.PnOpciones.Controls.Add(this.BtnConsulta);
            this.PnOpciones.Controls.Add(this.BtnFactura);
            this.PnOpciones.Controls.Add(this.bunifuSeparator1);
            this.PnOpciones.Controls.Add(this.BtnRegistrar);
            this.PnOpciones.Controls.Add(this.BtnMenu);
            this.LogoTransition.SetDecoration(this.PnOpciones, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.PnOpciones, BunifuAnimatorNS.DecorationType.None);
            this.PnOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnOpciones.Location = new System.Drawing.Point(0, 52);
            this.PnOpciones.Name = "PnOpciones";
            this.PnOpciones.Size = new System.Drawing.Size(194, 398);
            this.PnOpciones.TabIndex = 1;
            // 
            // Magneto
            // 
            this.PanelTransition.SetDecoration(this.Magneto, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Magneto, BunifuAnimatorNS.DecorationType.None);
            this.Magneto.Image = ((System.Drawing.Image)(resources.GetObject("Magneto.Image")));
            this.Magneto.Location = new System.Drawing.Point(6, 0);
            this.Magneto.Name = "Magneto";
            this.Magneto.Size = new System.Drawing.Size(68, 56);
            this.Magneto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Magneto.TabIndex = 9;
            this.Magneto.TabStop = false;
            this.Magneto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Activecolor = System.Drawing.Color.Transparent;
            this.BtnConsulta.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConsulta.BorderRadius = 0;
            this.BtnConsulta.ButtonText = "Consultar";
            this.BtnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnConsulta, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnConsulta, BunifuAnimatorNS.DecorationType.None);
            this.BtnConsulta.DisabledColor = System.Drawing.Color.Gray;
            this.BtnConsulta.ForeColor = System.Drawing.Color.Transparent;
            this.BtnConsulta.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnConsulta.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnConsulta.Iconimage")));
            this.BtnConsulta.Iconimage_right = null;
            this.BtnConsulta.Iconimage_right_Selected = null;
            this.BtnConsulta.Iconimage_Selected = null;
            this.BtnConsulta.IconMarginLeft = 0;
            this.BtnConsulta.IconMarginRight = 0;
            this.BtnConsulta.IconRightVisible = true;
            this.BtnConsulta.IconRightZoom = 0D;
            this.BtnConsulta.IconVisible = true;
            this.BtnConsulta.IconZoom = 90D;
            this.BtnConsulta.IsTab = false;
            this.BtnConsulta.Location = new System.Drawing.Point(0, 219);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnConsulta.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnConsulta.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnConsulta.selected = false;
            this.BtnConsulta.Size = new System.Drawing.Size(185, 52);
            this.BtnConsulta.TabIndex = 8;
            this.BtnConsulta.Text = "Consultar";
            this.BtnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsulta.Textcolor = System.Drawing.Color.White;
            this.BtnConsulta.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnFactura
            // 
            this.BtnFactura.Activecolor = System.Drawing.Color.Transparent;
            this.BtnFactura.BackColor = System.Drawing.Color.Transparent;
            this.BtnFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFactura.BorderRadius = 0;
            this.BtnFactura.ButtonText = "Facturar";
            this.BtnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnFactura, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnFactura, BunifuAnimatorNS.DecorationType.None);
            this.BtnFactura.DisabledColor = System.Drawing.Color.Gray;
            this.BtnFactura.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnFactura.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnFactura.Iconimage")));
            this.BtnFactura.Iconimage_right = null;
            this.BtnFactura.Iconimage_right_Selected = null;
            this.BtnFactura.Iconimage_Selected = null;
            this.BtnFactura.IconMarginLeft = 0;
            this.BtnFactura.IconMarginRight = 0;
            this.BtnFactura.IconRightVisible = true;
            this.BtnFactura.IconRightZoom = 0D;
            this.BtnFactura.IconVisible = true;
            this.BtnFactura.IconZoom = 90D;
            this.BtnFactura.IsTab = false;
            this.BtnFactura.Location = new System.Drawing.Point(0, 161);
            this.BtnFactura.Name = "BtnFactura";
            this.BtnFactura.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnFactura.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnFactura.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnFactura.selected = false;
            this.BtnFactura.Size = new System.Drawing.Size(185, 52);
            this.BtnFactura.TabIndex = 7;
            this.BtnFactura.Text = "Facturar";
            this.BtnFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFactura.Textcolor = System.Drawing.Color.White;
            this.BtnFactura.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(6, 62);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(185, 35);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Activecolor = System.Drawing.Color.Transparent;
            this.BtnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrar.BorderRadius = 0;
            this.BtnRegistrar.ButtonText = "Registrar";
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.BtnRegistrar, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnRegistrar, BunifuAnimatorNS.DecorationType.None);
            this.BtnRegistrar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnRegistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrar.Iconimage")));
            this.BtnRegistrar.Iconimage_right = null;
            this.BtnRegistrar.Iconimage_right_Selected = null;
            this.BtnRegistrar.Iconimage_Selected = null;
            this.BtnRegistrar.IconMarginLeft = 0;
            this.BtnRegistrar.IconMarginRight = 0;
            this.BtnRegistrar.IconRightVisible = true;
            this.BtnRegistrar.IconRightZoom = 0D;
            this.BtnRegistrar.IconVisible = true;
            this.BtnRegistrar.IconZoom = 90D;
            this.BtnRegistrar.IsTab = false;
            this.BtnRegistrar.Location = new System.Drawing.Point(0, 103);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrar.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnRegistrar.selected = false;
            this.BtnRegistrar.Size = new System.Drawing.Size(185, 52);
            this.BtnRegistrar.TabIndex = 5;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.Textcolor = System.Drawing.Color.White;
            this.BtnRegistrar.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnMenu
            // 
            this.BtnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageActive = null;
            this.BtnMenu.Location = new System.Drawing.Point(155, 6);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(36, 33);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenu.TabIndex = 4;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Zoom = 10;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // PnPrincipal
            // 
            this.PnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.LogoTransition.SetDecoration(this.PnPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.PnPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.PnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnPrincipal.Location = new System.Drawing.Point(194, 52);
            this.PnPrincipal.Name = "PnPrincipal";
            this.PnPrincipal.Size = new System.Drawing.Size(606, 398);
            this.PnPrincipal.TabIndex = 2;
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
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 1;
            animation12.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 2F;
            animation12.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation12;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoTransition.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(30);
            animation11.RotateCoeff = 0.5F;
            animation11.RotateLimit = 0.2F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation11;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnPrincipal);
            this.Controls.Add(this.PnOpciones);
            this.Controls.Add(this.pnBarraArriba);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnBarraArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestablecer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.PnOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Magneto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PnPrincipal;
        private System.Windows.Forms.Panel PnOpciones;
        private System.Windows.Forms.Panel pnBarraArriba;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox Magneto;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConsulta;
        private Bunifu.Framework.UI.BunifuFlatButton BtnFactura;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRegistrar;
        private Bunifu.Framework.UI.BunifuImageButton BtnMenu;
        private Bunifu.Framework.UI.BunifuImageButton BtnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton Btnmaximizar;
        private Bunifu.Framework.UI.BunifuImageButton BtnRestablecer;
        private Bunifu.Framework.UI.BunifuImageButton BtnCerrar;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
    }
}

