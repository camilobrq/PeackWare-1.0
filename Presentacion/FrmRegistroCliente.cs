using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Entidad;
using Logica;
namespace Presentacion
{
    public partial class FrmRegistroCliente : Form
    {
        ClienteService clienteService;
        public FrmRegistroCliente()
        {
            clienteService = new ClienteService(ConfigConnection.connectionString);
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿esta seguro de cerrar esta pestaña?", "¡alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (TxtIdentificacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtIdentificacion, "Debe digitar la identificacion");
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
                errorProvider1.SetError(TxtTelefono, "Debe digitar una direccion");
            }
            return ok;
        }
        private void BorrarMenajes()
        {
            errorProvider1.SetError(TxtIdentificacion, "");
            errorProvider1.SetError(TxtNombre, "");
            errorProvider1.SetError(TxtEdad, "");
            errorProvider1.SetError(TxtTelefono, "");
            errorProvider1.SetError(TxtDireccion, "");
        
        }
        private void TxtIdentifiacion_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(TxtIdentificacion.Text, out num))
            {
                errorProvider1.SetError(TxtIdentificacion, "Solo se permiten datos numericos");
            }
            else
            {
                errorProvider1.SetError(TxtIdentificacion, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            Cliente cliente = new Cliente
            {
                Identificacion = TxtIdentificacion.Text,
                Nombre = TxtNombre.Text,
                Sexo = ComboSexo.Text,
                Edad = TxtEdad.Text,
                Telefono = TxtTelefono.Text,
                Direccion = TxtDireccion.Text
            };
            MessageBox.Show(clienteService.Guardar(cliente));

        }
        private void AgregarCliente()
        {
            BorrarMenajes();
            if (ValidarCampos())
            {
                AgregarCliente();
                MessageBox.Show("Datos Correctos");
                TxtNombre.Text = "";
                TxtIdentificacion.Text = "";
                TxtEdad.Text = "";
                TxtTelefono.Text = "";
                TxtDireccion.Text = "";

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

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {
          
        }

        private void FrmRegistroCliente_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void ComboSexo_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
