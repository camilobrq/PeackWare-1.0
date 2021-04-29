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
namespace Presentacion
{
    public partial class FrmRegistroCliente : Form
    {
        public FrmRegistroCliente()
        {
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
            BorrarMenajes();
            if (ValidarCampos())
            {
                MessageBox.Show("Cliente Registrado Satisfactoriamente");
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
            ComboSexo.Items.Insert(0,"SELECCIONE");
            ComboSexo.Items.Insert(1, "MASCULINO");
            ComboSexo.Items.Insert(2, "FEMENINO");
            ComboSexo.Items.Insert(3, "OTRO");
        }

        private void FrmRegistroCliente_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void ComboSexo_Validating(object sender, CancelEventArgs e)
        {
            if (ComboSexo.SelectedItem == "SELECCIONE")
            {
                errorProvider1.SetError(ComboSexo, "Debe seleccionar una opcion");
            }
            else
            {
                errorProvider1.SetError(ComboSexo, "");
            }
        }
    }
}
