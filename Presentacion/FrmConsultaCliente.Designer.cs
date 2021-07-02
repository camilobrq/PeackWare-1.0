
namespace Presentacion
{
    partial class FrmConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCliente));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnConsultarTodos = new System.Windows.Forms.Button();
            this.LbMasculinos = new System.Windows.Forms.Label();
            this.LbFemenino = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbM = new System.Windows.Forms.Label();
            this.LbF = new System.Windows.Forms.Label();
            this.LbT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(78, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(3, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(28, 24);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 27;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnConsultarTodos
            // 
            this.BtnConsultarTodos.Location = new System.Drawing.Point(82, 351);
            this.BtnConsultarTodos.Name = "BtnConsultarTodos";
            this.BtnConsultarTodos.Size = new System.Drawing.Size(147, 23);
            this.BtnConsultarTodos.TabIndex = 28;
            this.BtnConsultarTodos.Text = "Consultar Toda la Tabla";
            this.BtnConsultarTodos.UseVisualStyleBackColor = true;
            this.BtnConsultarTodos.Click += new System.EventHandler(this.BtnConsultarTodos_Click);
            // 
            // LbMasculinos
            // 
            this.LbMasculinos.AutoSize = true;
            this.LbMasculinos.Location = new System.Drawing.Point(530, 301);
            this.LbMasculinos.Name = "LbMasculinos";
            this.LbMasculinos.Size = new System.Drawing.Size(63, 13);
            this.LbMasculinos.TabIndex = 29;
            this.LbMasculinos.Text = "Masculinos:";
            // 
            // LbFemenino
            // 
            this.LbFemenino.AutoSize = true;
            this.LbFemenino.Location = new System.Drawing.Point(530, 333);
            this.LbFemenino.Name = "LbFemenino";
            this.LbFemenino.Size = new System.Drawing.Size(56, 13);
            this.LbFemenino.TabIndex = 30;
            this.LbFemenino.Text = "Femenino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Total";
            // 
            // LbM
            // 
            this.LbM.AutoSize = true;
            this.LbM.Location = new System.Drawing.Point(619, 301);
            this.LbM.Name = "LbM";
            this.LbM.Size = new System.Drawing.Size(13, 13);
            this.LbM.TabIndex = 32;
            this.LbM.Text = "0";
            // 
            // LbF
            // 
            this.LbF.AutoSize = true;
            this.LbF.Location = new System.Drawing.Point(619, 333);
            this.LbF.Name = "LbF";
            this.LbF.Size = new System.Drawing.Size(13, 13);
            this.LbF.TabIndex = 33;
            this.LbF.Text = "0";
            // 
            // LbT
            // 
            this.LbT.AutoSize = true;
            this.LbT.Location = new System.Drawing.Point(619, 361);
            this.LbT.Name = "LbT";
            this.LbT.Size = new System.Drawing.Size(13, 13);
            this.LbT.TabIndex = 34;
            this.LbT.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Conteo De Clientes";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 290);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 36;
            // 
            // FrmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(720, 409);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbT);
            this.Controls.Add(this.LbF);
            this.Controls.Add(this.LbM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbFemenino);
            this.Controls.Add(this.LbMasculinos);
            this.Controls.Add(this.BtnConsultarTodos);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaCliente";
            this.Text = "FrmConsultaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Button BtnConsultarTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbT;
        private System.Windows.Forms.Label LbF;
        private System.Windows.Forms.Label LbM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbFemenino;
        private System.Windows.Forms.Label LbMasculinos;
        private System.Windows.Forms.TextBox textBox2;
    }
}