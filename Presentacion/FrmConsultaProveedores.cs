using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;
namespace Presentacion
{
    public partial class FrmConsultaProveedores : Form
    {
        ProveedorService proveedorService;
        public FrmConsultaProveedores()
        {
            proveedorService = new ProveedorService(ConfigConnection.connectionString);
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿esta seguro de cerrar esta pestaña?", "¡alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var respuesta = proveedorService.Consultar();

            dataGridView1.DataSource = respuesta.proveedors;

            int total = Convert.ToInt32(proveedorService.ContarTodos());

            LbTo.Text = Convert.ToString(total);
            LbMas.Text = Convert.ToString(proveedorService.ContarMasculinos());
            LbFe.Text = Convert.ToString(proveedorService.ContarFemeninos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = proveedorService.ConsultarPorId(TxtId.Text);
        }
    }
}
