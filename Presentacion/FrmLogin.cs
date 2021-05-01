using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            TxtClave.UseSystemPasswordChar = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            ValidarCampos();
            if (txtUsuario.Text.ToUpper().Equals("ADMIN")&& TxtClave.Text.ToUpper().Equals("ADMIN"))
            {
                FrmMenu frmMenu = new FrmMenu();
                this.Hide();
                frmMenu.ShowDialog();
                this.Close();
               
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿esta seguro de querer cerrar la aplicacion?", "¡alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUsuario, "Debe llenar el campo");
            }
            if (TxtClave.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtClave, "Debe llenar el campo");
            }
            return ok;
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtUsuario,"");
            errorProvider1.SetError(txtUsuario, "");
        }
    }
}
