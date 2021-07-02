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
using Logica;
namespace Presentacion
{
    public partial class FrmRegistroProveedor : Form
    {
        ProveedorService proveedorService;
        public FrmRegistroProveedor()
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
        private bool ValidarCampos()
        {
            bool ok = true;
            if (TxtIdenficiacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtIdenficiacion, "Debe digitar la identificacion");
            }

            if (TxtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNombre, "Debe digitar el nombre del Cliente");
            }
            if (TxtEdad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtEdad, "Debe digitar la edad ");
            }
            if (TxtTelefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtTelefono, "Debe digitar un numero de telefono");
            }
            if (TxtDireccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtDireccion, "Debe digitar una direccion");
            }
            if (TxtPais.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtPais, "Debe digitar un pais");
            }
            if (TxtEmpresa.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtEmpresa, "Debe digitar el Nombre de la empresa");
            }
            return ok;
        }
        private void BorrarMenajes()
        {
            errorProvider1.SetError(TxtIdenficiacion, "");
            errorProvider1.SetError(TxtNombre, "");
            errorProvider1.SetError(TxtEdad, "");
            errorProvider1.SetError(TxtTelefono, "");
            errorProvider1.SetError(TxtDireccion, "");
            errorProvider1.SetError(TxtPais, "");
            errorProvider1.SetError(TxtEmpresa, "");

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            /* BorrarMenajes();
             if (ValidarCampos())
             {
                 AgregarProovedor();

                 TxtIdenficiacion.Text="";
                 TxtNombre.Text = "";
                 TxtEdad.Text = "";
                 TxtTelefono.Text = "";
                 TxtDireccion.Text = "";
                 TxtPais.Text = "";
                 TxtEmpresa.Text = "";

             }
             /*
               public string Identificacion { get; set; }
         public string Nombre { get; set; }
         public string Sexo { get; set; }
         public int Edad { get; set; }
         public string Telefono { get; set; }
         public string Direccion { get; set; }

              */
            Proveedor proveedor = new Proveedor()
            {

                Identificacion = TxtIdenficiacion.Text,
                Nombre = TxtNombre.Text,
                Sexo = ComboSexo.Text,
                Edad = TxtEdad.Text,
                Telefono = TxtTelefono.Text,
                Direccion = TxtDireccion.Text,
                Pais = TxtPais.Text,
                NombreEmpresa = TxtEmpresa.Text,
            };
            MessageBox.Show(proveedorService.Guardar(proveedor));
        
          
        }
        private void AgregarProovedor()
        {
           
        }


        private void TxtIdenficiacion_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(TxtIdenficiacion.Text, out num))
            {
                errorProvider1.SetError(TxtIdenficiacion, "Solo se permiten datos numericos");
            }
            else
            {
                errorProvider1.SetError(TxtIdenficiacion, "");
            }
        }

        private void TxtEdad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(TxtEdad.Text, out num))
            {
                errorProvider1.SetError(TxtEdad, "Solo se permiten datos numericos");
            }
            else
            {
                errorProvider1.SetError(TxtEdad, "");
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

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

        private void TxtTelefono_Validating(object sender, CancelEventArgs e)
        {
            long num;
            if (!long.TryParse(TxtTelefono.Text, out num))
            {
                errorProvider1.SetError(TxtTelefono, "Solo se permiten datos numericos");
            }
            else
            {
                errorProvider1.SetError(TxtTelefono, "");
            }
        }

        private void TxtPais_Validating(object sender, CancelEventArgs e)
        {
            bool resultado = Regex.IsMatch(TxtPais.Text, @"^[a-zA-Z]+$");
            if (!resultado)
            {
                errorProvider1.SetError(TxtPais, "Solo debe Contener letras");
            }
            else
            {
                errorProvider1.SetError(TxtPais, "");
            }
        }
    }
}
