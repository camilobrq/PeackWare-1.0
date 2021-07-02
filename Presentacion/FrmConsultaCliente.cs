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
    public partial class FrmConsultaCliente : Form
    {
        ClienteService clienteService;
        public FrmConsultaCliente()
        {
            InitializeComponent();
            clienteService = new ClienteService(ConfigConnection.connectionString);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿esta seguro de cerrar esta pestaña?", "¡alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿esta seguro de querer eliminar este cliente?", "¡alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
            }
        }

        private void BtnConsultarTodos_Click(object sender, EventArgs e)
        {
            var respuesta = clienteService.Consultar();

            dataGridView1.DataSource = respuesta.clientes;

            int total =Convert.ToInt32( clienteService.ContarTodos());

            LbT.Text =Convert.ToString(total);
            LbM.Text = Convert.ToString( clienteService.ContarMasculinos());
            LbF.Text = Convert.ToString(clienteService.ContarFemeninos());
        }
    }
}
