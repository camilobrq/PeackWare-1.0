using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Presentacion
{
    public partial class FrmFacturaVenta : Form
    {
        public FrmFacturaVenta()
        {
            InitializeComponent();
        }

        private void TxtIdFactura_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(TxtIdFactura.Text, out num))
            {
                errorProvider1.SetError(TxtIdFactura, "Solo se permiten datos numericos");
            }
            else
            {
                errorProvider1.SetError(TxtIdFactura, "");
            }
        }
            private bool ValidarCamposFactura()
            {
                bool ok = true;
                if (TxtIdFactura.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtIdFactura, "Debe digitar el codigo de la factura");
                }
                if (TxtIdCliente.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtIdCliente, "Debe digitar la identificacion del proveedor");
                }
                /*if (TxtFechaCompra.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtFechaCompra, "Debe digitar la fecha de la factura");
                }*/
                return ok;
            }
            private void BorrarMenajesFactura()
            {
                errorProvider1.SetError(TxtIdFactura, "");
               // errorProvider1.SetError(TxtFechaCompra, "");
                errorProvider1.SetError(TxtIdCliente, "");

            }
            private bool ValidarCampos()
            {
                bool ok = true;
                if (TxtCodigoProducto.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtCodigoProducto, "Debe digitar un codigo de Producto");
                }
               
                if (TxtNombre.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtNombre, "Debe digitar el nombre del Producto");
                }
                if (TxtCantidad.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtCantidad, "Debe digitar la cantidad del Producto");
                }
                if (TxtDescuento.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(TxtDescuento, "Debe digitar el descuento del Producto");
                }
               
                return ok;
            }
            private void BorrarMenajes()
            {
                errorProvider1.SetError(TxtCodigoProducto, "");
             
                errorProvider1.SetError(TxtNombre, "");
                errorProvider1.SetError(TxtCantidad, "");
                errorProvider1.SetError(TxtDescuento, "");
             
            }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            BorrarMenajes();
            if (ValidarCampos())

            {
                MessageBox.Show("Producto Agregado Correctamente");
                TxtCantidad.Text = "";
                TxtCodigoProducto.Text = "";
                TxtDescuento.Text = "";
                TxtNombre.Text="";
            }
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            BorrarMenajesFactura();
            if (ValidarCamposFactura()){
                MessageBox.Show("Facturado Correctamente");
                TxtIdFactura.Text = "";
                TxtIdCliente.Text = "";
             //   TxtFechaCompra.Text = "";
            }

        }

        private void TxtDescuento_Validating(object sender, CancelEventArgs e)
        {
            decimal num;
            if (!decimal.TryParse(TxtDescuento.Text, out num))
            {
                errorProvider1.SetError(TxtDescuento, "Solo se permiten datos numericos");
            }
            else
            {
                errorProvider1.SetError(TxtDescuento, "");
            }
        }

        private void TxtCantidad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(TxtCantidad.Text, out num))
            {
                errorProvider1.SetError(TxtCantidad, "Solo se permiten datos numericos");
            }
            else
            {
                errorProvider1.SetError(TxtCantidad, "");
            }
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            bool resultado = Regex.IsMatch(TxtNombre.Text, @"^[a-zA-Z]+$");
            if (!resultado)
            {
                errorProvider1.SetError(TxtNombre, "Solo debe Contener letras");
            }
            else
            {
                errorProvider1.SetError(TxtNombre, "");
            }
        }

        private void TxtCodigoProducto_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(TxtCodigoProducto.Text, out num))
            {
                errorProvider1.SetError(TxtCodigoProducto, "Solo se permiten datos numericos");
            }
            else
            {
                errorProvider1.SetError(TxtCodigoProducto, "");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿esta seguro de cerrar esta pestaña?", "¡alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TxtCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtIdFactura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
