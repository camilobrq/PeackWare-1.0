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
            DiseñoMenu();
        }
        int lx, ly;
        int sb, sa;
       
        private void DiseñoMenu()
        {
            panelRegistrar.Visible = false;
            panelFactura.Visible = false;
            panelConsultar.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if (panelRegistrar.Visible == true)
                panelRegistrar.Visible = false;
            if (panelFactura.Visible == true)
                panelFactura.Visible = false;
            if (panelConsultar.Visible == true)
                panelConsultar.Visible = false;
           
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
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

        private void pnBarraArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelFactura);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelRegistrar);

        }

        private void BtnRegistroClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistroCliente>();
            OcultarSubMenu();


        }

        private void BtnRegistroProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistroProveedor>();
            OcultarSubMenu();
        }

        private void BtnFacturaCompra_Click(object sender, EventArgs e)
        {
            
            OcultarSubMenu();
        }

        private void BtnFacturaVenta_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnConsultaCliente_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnConsultaProveedores_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnConsultaFactura_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelConsultar);
        }

        private void PnPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegistrar_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(panelRegistrar);
        }

        private void BtnFactura_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(panelFactura);
        }

        private void BtnConsulta_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(panelConsultar);
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

        private void AbrirFormulario<FormularioAbrir>() where FormularioAbrir : Form, new()
        {
            Form Formularios;
            Formularios = PanelContenedor.Controls.OfType<FormularioAbrir>().FirstOrDefault();

            if (Formularios == null)
            {
                Formularios = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                PanelContenedor.Controls.Add(Formularios);

                PanelContenedor.Tag = Formularios;
                Formularios.Show();
                Formularios.BringToFront();
            }
            else
            {
                Formularios.BringToFront();
            }
        }


    }
}
