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
    public partial class VentanaEmpleado : Form
    {
        public VentanaEmpleado()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            LoginEmpleado loginEmpleado = new LoginEmpleado();
            loginEmpleado.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            VGInventario vGInventario = new VGInventario();
            vGInventario.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            VGVentas vGVentas = new VGVentas();
            vGVentas.Show();
            this.Hide();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            VGClientes vG = new VGClientes();
            vG.Show();
            this.Hide();

        }
    }
}
