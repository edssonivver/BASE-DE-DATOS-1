using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PROGRAMACION_II
{
    public partial class VentanaGerente : Form
    {
        public VentanaGerente()
        {
            InitializeComponent();
        }


        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            VGInventario INVENTARIO = new VGInventario();
            INVENTARIO.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VGPersonal verTipoPersonal = new VGPersonal();
            verTipoPersonal.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            VGVentas VENTAS = new VGVentas();
            VENTAS.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            VGClientes CLIENTES = new VGClientes();
            CLIENTES.Show();
        }

        private void btnRembolsos_Click(object sender, EventArgs e)
        {
            this.Hide();
            VGRembolsos REMBOLSOS = new VGRembolsos();
            REMBOLSOS.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            LoginGerente loginGerente = new LoginGerente();
            loginGerente.Show();
            this.Hide();
        }

    }
}
