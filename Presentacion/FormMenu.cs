using Presentacion.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Presentacion
{
    public partial class FormMenu : Form
    {
        private bool deslizarMenu1;
        private bool deslizarMenu2;
        private bool deslizarMenu3;
        public FormMenu()
        {
            InitializeComponent();
            DeslizarRegistro.Start();
            DeslizarFactura.Start();
            DeslizarConsulta.Start();

        }
        int lx, ly;
        int sb, sa;

        private void pictureBox1_Click(object sender, EventArgs e)
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
            BtnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PnBarraArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void DeslizarRegistro_Tick(object sender, EventArgs e)
        {
            if (deslizarMenu1)
            {
                BtnRegistro.Iconimage_right = Resources.menossRex_64;
                PanelSubmenu.Height += 10;
                
                if (PanelSubmenu.Size==PanelSubmenu.MaximumSize)
                {
                    DeslizarRegistro.Stop();
                    deslizarMenu1 = false;

                }
            }
            else
            {
                BtnRegistro.Iconimage_right = Resources.massRexx_64;
                PanelSubmenu.Height -= 5;

                if (PanelSubmenu.Size == PanelSubmenu.MaximumSize)
                {
                    DeslizarRegistro.Stop();
                    deslizarMenu1 = true;

                }
            }
        }

        private void DeslizarFactura_Tick(object sender, EventArgs e)
        {
            if (deslizarMenu2)
            {
                PanelSubmenu2.Height += 5;

                if (PanelSubmenu2.Size == PanelSubmenu2.MaximumSize)
                {
                    DeslizarFactura.Stop();
                    deslizarMenu2 = false;

                }
            }
            else
            {
                PanelSubmenu2.Height -= 5;

                if (PanelSubmenu2.Size == PanelSubmenu2.MaximumSize)
                {
                    DeslizarFactura.Stop();
                    deslizarMenu2 = true;

                }
            }
        }

        private void DeslizarConsulta_Tick(object sender, EventArgs e)
        {
            if (deslizarMenu3)
            {

                PanelSubmenu3.Height += 5;

                if (PanelSubmenu3.Size == PanelSubmenu3.MaximumSize)
                {
                    DeslizarConsulta.Stop();
                    deslizarMenu3 = false;

                }
            }
            else
            {
                PanelSubmenu3.Height -= 5;

                if (PanelSubmenu3.Size == PanelSubmenu3.MaximumSize)
                {
                    DeslizarConsulta.Stop();
                    deslizarMenu3 = true;

                }
            }
        }

        private void Minregistro_Tick(object sender, EventArgs e)
        {
            PanelSubmenu.Height -= 5;

            if (PanelSubmenu.Size == PanelSubmenu.MaximumSize)
            {
                Minregistro.Stop();
                deslizarMenu1 = true;

            }
        }

        private void MinFactura_Tick(object sender, EventArgs e)
        {
            PanelSubmenu2.Height -= 5;

            if (PanelSubmenu2.Size == PanelSubmenu2.MaximumSize)
            {
                MinFactura.Stop();
                deslizarMenu2 = true;

            }
        }

        private void MinConsulta_Tick(object sender, EventArgs e)
        {
            PanelSubmenu3.Height -= 5;

            if (PanelSubmenu3.Size == PanelSubmenu3.MaximumSize)
            {
                MinConsulta.Stop();
                deslizarMenu3 = true;

            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            DeslizarRegistro.Start();
            MinFactura.Start();
            MinConsulta.Start();

        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            DeslizarFactura.Start();
            Minregistro.Start();
            MinConsulta.Start();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            DeslizarConsulta.Start();
            Minregistro.Start();
            MinFactura.Start();
           
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            DeslizarRegistro.Start();
            MinFactura.Start();
            MinConsulta.Start();
        }

        private void btnCerrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sb = Size.Width;
            sa = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            BtnRestablecer.Visible = true;
            BtnMaximizar.Visible = false;
        }
    }
}
