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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        int lx, ly;
        int sb, sa;
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (PnOpciones.Width==50)
            {
                PnOpciones.Visible = false;
                PnOpciones.Width = 215;
                PanelTransition.ShowSync(PnOpciones);
                LogoTransition.ShowSync(Magneto);
            }
            else
            {
                LogoTransition.Hide(Magneto);
                PnOpciones.Visible = false;
                PnOpciones.Width = 50;
                PanelTransition.ShowSync(PnOpciones);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿esta seguro de querer cerrar la aplicacion?", "¡alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnRestablecer_Click(object sender, EventArgs e)
        {
            Size = new Size(sb, sa);
            Location = new Point(lx, ly);

            BtnRestablecer.Visible = false;
            Btnmaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btnmaximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sb = Size.Width;
            sa = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            BtnRestablecer.Visible = true;
            Btnmaximizar.Visible = false;
        }
    }
}
