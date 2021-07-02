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
using Entidad;
namespace Presentacion
{
    public partial class FrmRegistroProducto : Form
    {
        ProductoService productoService;
        public FrmRegistroProducto()
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

        private void Registrar_Click(object sender, EventArgs e)
        {
            Producto     producto = new Producto
            {
                CodigoProducto=TxtIdentificacion.Text,
                NombreProducto=TxtNombre.Text,
                PrecioUnidad=Convert.ToInt32( txtPrecioUnidad.Text),           
                Descuento=Convert.ToInt32( txtDescuento.Text),
                Descripcion=txtdiscrepcion.Text
            };
            MessageBox.Show(productoService.Guardar(producto));
        }
    }
}
