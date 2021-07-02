using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace Presentacion
{
    public partial class FrmConsultarProducto : Form
    {
        ProductoService productoService;
        public FrmConsultarProducto()
        {
            productoService = new ProductoService(ConfigConnection.connectionString);
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿esta seguro de cerrar esta pestaña?", "¡alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnConsultarTodos_Click(object sender, EventArgs e)
        {
            var respuesta = productoService.Consultar();

            dataGridView1.DataSource = respuesta.Productos;

            int total = Convert.ToInt32(productoService.ContarTodos());

            LbTotal.Text = Convert.ToString(total);
        }
    }
}
