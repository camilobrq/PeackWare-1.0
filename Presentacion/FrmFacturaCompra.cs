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
using Entidad;

namespace Presentacion
{
    public partial class FrmFacturaCompra : Form
    {
        DetalleFactura detalleFactura = new DetalleFactura();
        List<DetalleFactura> listaProductos = new List<DetalleFactura>();
        public FrmFacturaCompra()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            BorrarMenajes();
           if(ValidarCampos())
            {
               
                MessageBox.Show("Datos Ingresados Correctamente");
                //TablaProducto.DataSource = detalleFactura;
                TxtDescuento.Text = "";
                TxtCantidad.Text = "";
                TxtCodigoProducto.Text = "";
                TxtDescripcion.Text = "";
                TxtNombre.Text = "";
                TxtPrecioUnitario.Text = "";
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
            if (TxtIdProveedor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtIdProveedor, "Debe digitar la identificacion del proveedor");
            }
           /* if (TxtFecha.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtFecha, "Debe digitar la fecha de la factura");
            }*/
            return ok;
        }
        private void BorrarMenajesFactura()
        {
            errorProvider1.SetError(TxtIdFactura, "");
         //   errorProvider1.SetError(TxtFecha, "");
            errorProvider1.SetError(TxtIdProveedor, "");
            
        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (TxtCodigoProducto.Text=="")
            {
                ok = false;
                errorProvider1.SetError(TxtCodigoProducto,"Debe digitar un codigo de Producto");
            }
            if (TxtPrecioUnitario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtPrecioUnitario, "Debe digitar el precio del Producto");
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
            if (TxtDescripcion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtDescripcion, "Debe digitar la descripcion del Producto");
            }
            return ok;
        }
        private void BorrarMenajes()
        {
            errorProvider1.SetError(TxtCodigoProducto, "");
            errorProvider1.SetError(TxtPrecioUnitario, "");
            errorProvider1.SetError(TxtNombre, "");
            errorProvider1.SetError(TxtCantidad, "");
            errorProvider1.SetError(TxtDescuento, "");
            errorProvider1.SetError(TxtDescripcion, "");
        }

        private void TxtCantidad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if(!int.TryParse(TxtCantidad.Text, out num))
            {
                errorProvider1.SetError(TxtCantidad, "Solo se permiten datos numericos");
            }
            else
            {
                errorProvider1.SetError(TxtCantidad, "");
            }
        }

        private void TxtFecha_Validating(object sender, CancelEventArgs e)
        {
            DateTime Fecha;
          /*  if (!DateTime.TryParse(TxtFecha.Text, out Fecha))
            {
                errorProvider1.SetError(TxtFecha, "solo formato fechas eje: 29/04/2021");
            }
            else
            {
                errorProvider1.SetError(TxtFecha, "");
            }
          */
        }

        private void TxtPrecioUnitario_Validating(object sender, CancelEventArgs e)
        {
            decimal num;
            if (!decimal.TryParse(TxtPrecioUnitario.Text, out num))
            {
                errorProvider1.SetError(TxtPrecioUnitario, "Solo se permiten datos numericos");
            }
            else
            {
                errorProvider1.SetError(TxtPrecioUnitario, "");
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

        private void TxtIdProveedor_Validating(object sender, CancelEventArgs e)
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

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            BorrarMenajesFactura();
            if (ValidarCamposFactura())
            {
                MessageBox.Show("Facturado Correctamente");
                TxtIdProveedor.Text = "";
              //  TxtFecha.Text = "";
                TxtIdFactura.Text = "";

            }
        }

        private void Facturar()
        {

            Proveedor persona = new Proveedor();

            Factura facturaCompra = new FacturaCompra(persona)
            {
                IdFactura = TxtIdFactura.Text,
                IdPersona = TxtIdProveedor.Text,
            //    Fecha = Convert.ToDateTime(TxtFecha.Text),
                Total = Convert.ToDecimal(LbTotal.Text),
                Subtotal = Convert.ToDecimal(LbSubtotal.Text)
             


            };
            
           
        }
     
        public void AgregarProductos()
        {
            
           
            detalleFactura.producto.CodigoProducto = TxtCodigoProducto.Text;
            detalleFactura.producto.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            detalleFactura.producto.Descuento = Convert.ToDecimal(TxtDescuento.Text);
            detalleFactura.producto.NombreProducto = TxtNombre.Text;
            detalleFactura.producto.PrecioUnidad = Convert.ToDecimal(TxtPrecioUnitario.Text);
            detalleFactura.CalculaIva();
            detalleFactura.CalcularDescuento();
            detalleFactura.CalcularImporte();
            listaProductos.Add(detalleFactura);
                                             
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

        private void TablaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿esta seguro de cerrar esta pestaña?", "¡alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
