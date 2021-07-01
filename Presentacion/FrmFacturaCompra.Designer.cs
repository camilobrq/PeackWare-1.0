
namespace Presentacion
{
    partial class FrmFacturaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturaCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.Lbimporte = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LbSubtotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LbTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdFactura = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.Lbimporte);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.LbSubtotal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.LbTotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.BtnFacturar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TxtDescripcion);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TxtDescuento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtIdProveedor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtCodigoProducto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtCantidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtPrecioUnitario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtIdFactura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 476);
            this.panel1.TabIndex = 0;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(-109, -183);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(28, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 53;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Lbimporte
            // 
            this.Lbimporte.AutoSize = true;
            this.Lbimporte.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbimporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbimporte.Location = new System.Drawing.Point(782, 380);
            this.Lbimporte.Name = "Lbimporte";
            this.Lbimporte.Size = new System.Drawing.Size(17, 19);
            this.Lbimporte.TabIndex = 52;
            this.Lbimporte.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(707, 380);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 19);
            this.label14.TabIndex = 51;
            this.label14.Text = "Impote:";
            // 
            // LbSubtotal
            // 
            this.LbSubtotal.AutoSize = true;
            this.LbSubtotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSubtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbSubtotal.Location = new System.Drawing.Point(782, 411);
            this.LbSubtotal.Name = "LbSubtotal";
            this.LbSubtotal.Size = new System.Drawing.Size(17, 19);
            this.LbSubtotal.TabIndex = 50;
            this.LbSubtotal.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(707, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 49;
            this.label11.Text = "SubTotal:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(351, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Factura Compra";
            // 
            // LbTotal
            // 
            this.LbTotal.AutoSize = true;
            this.LbTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbTotal.Location = new System.Drawing.Point(782, 434);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(17, 19);
            this.LbTotal.TabIndex = 22;
            this.LbTotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(707, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total:";
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Location = new System.Drawing.Point(478, 417);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(135, 39);
            this.BtnFacturar.TabIndex = 20;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.UseVisualStyleBackColor = true;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(359, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Descripcion:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(478, 198);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(129, 20);
            this.TxtDescripcion.TabIndex = 18;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(192, 417);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(135, 39);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(58, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Descuento:";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Location = new System.Drawing.Point(192, 198);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(129, 20);
            this.TxtDescuento.TabIndex = 14;
            this.TxtDescuento.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDescuento_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(58, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID Factura:";
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.Location = new System.Drawing.Point(478, 45);
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.Size = new System.Drawing.Size(129, 20);
            this.TxtIdProveedor.TabIndex = 12;
            this.TxtIdProveedor.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIdProveedor_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(613, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(58, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Codigo Producto:";
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.Location = new System.Drawing.Point(192, 126);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(129, 20);
            this.TxtCodigoProducto.TabIndex = 8;
            this.TxtCodigoProducto.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigoProducto_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(358, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad:";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(478, 165);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(129, 20);
            this.TxtCantidad.TabIndex = 6;
            this.TxtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCantidad_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(359, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio Unitario:";
            // 
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(478, 125);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(129, 20);
            this.TxtPrecioUnitario.TabIndex = 4;
            this.TxtPrecioUnitario.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPrecioUnitario_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(58, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(192, 162);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(129, 20);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(358, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Proveedor:";
            // 
            // TxtIdFactura
            // 
            this.TxtIdFactura.Location = new System.Drawing.Point(192, 39);
            this.TxtIdFactura.Name = "TxtIdFactura";
            this.TxtIdFactura.Size = new System.Drawing.Size(129, 20);
            this.TxtIdFactura.TabIndex = 0;
            this.TxtIdFactura.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIdFactura_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(37, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 43);
            this.panel2.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(209, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(274, 20);
            this.label15.TabIndex = 55;
            this.label15.Text = "Agregre El Producto A la Compra";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 150);
            this.dataGridView1.TabIndex = 55;
            // 
            // FrmFacturaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 476);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturaCompra";
            this.Text = "FrmFacturaCompra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrecioUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Lbimporte;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LbSubtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.TextBox TxtIdProveedor;
        private System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.TextBox TxtIdFactura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
    }
}