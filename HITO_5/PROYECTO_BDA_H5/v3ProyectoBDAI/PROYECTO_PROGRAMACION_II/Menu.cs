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
using EnvioCorreo;

namespace PROYECTO_PROGRAMACION_II
{
    public partial class fmMenus : Form
    {
        bool sidebarExpand;
        string nombre_usuario;
        public fmMenus(string user)
        {
            nombre_usuario = user;
            InitializeComponent();
        }
        //para controlar con el mouse donde queremos llevar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int iparam);
        //

        private void fmMenus_Load(object sender, EventArgs e)
        {
            panelproductos.Visible=false;
            AbrirFormPanel1(new InicioFm());

            if (nombre_usuario== "EMPLEADO")
            {
                btnRembolso.Enabled = false;
                btnPersonal.Enabled = false;
                Login.Enabled = false;
            }
            else if (nombre_usuario== "GERENTE")
            {
                btnRembolso.Enabled = true;
                btnPersonal.Enabled = true;
                Login.Enabled = true;
            }
        }

       
        //ANIMACION
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {

                sidebar.Width -= 10; 
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
            
        }

        //para abrir un form dentro del panel
        private void AbrirFormPanel1(object formhijo)
        {
            if (this.panelContenedor.Controls.Count >0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh= formhijo as Form;
            fh.TopLevel = false;
            fh.Dock=DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


     
 

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel15_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }



        //mover el form con el mouse

        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




        //AREA DE LOS BUTTONS

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Frm_INICIO2 inicio1 = new Frm_INICIO2();
            inicio1.ShowDialog();
        }

        private void btnInicio_Click_2(object sender, EventArgs e)
        {
            AbrirFormPanel1(new InicioFm());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            panelproductos.Visible = true;
            AbrirFormPanel1(new VGInventario());
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormPanel1(new VGVIProducto());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormPanel1(new VGVentas());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormPanel1(new VGClientes());
        }

        private void btnRembolso_Click(object sender, EventArgs e)
        {
            AbrirFormPanel1(new VGRembolsos());
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormPanel1(new VGPersonal());
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_x_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmCorreo correo = new FmCorreo();
            correo.ShowDialog();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            AbrirFormPanel1(new VGLoginPersonal());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
