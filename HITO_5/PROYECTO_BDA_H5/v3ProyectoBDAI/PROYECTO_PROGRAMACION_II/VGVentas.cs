using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PROGRAMACION_II
{
    public partial class VGVentas : Form
    {
        VentasDB ven = new VentasDB();

        public VGVentas()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            //VentanaGerente VGPersonal = new VentanaGerente();
            //VGPersonal.Show();
            //this.Close();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            ven.adicionarVenta(Convert.ToString(txtNId_Ventas.Text),

                Convert.ToString(txtI_Cliente.Text),

                Convert.ToString(txtId_Productos.Text),

                Convert.ToDecimal(txtCuenta_a_Pagar.Text),

                Convert.ToDecimal(txtCuenta_Pagada.Text),

                 Convert.ToDecimal(txtCuenta_Pagada.Text),

                Convert.ToString(txtCuenta_Pagada.Text));

            ven.listarVentas(out dt, out nr);
            dvgVentas.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            ven.modificarVenta(Convert.ToString(txtNId_Ventas.Text),

                Convert.ToString(txtI_Cliente.Text),

                Convert.ToString(txtId_Productos.Text),

                Convert.ToDecimal(txtCuenta_a_Pagar.Text),

                Convert.ToDecimal(txtCuenta_Pagada.Text),

                 Convert.ToDecimal(txtCuenta_Pagada.Text),

                Convert.ToString(txtCuenta_Pagada.Text),

                 Convert.ToString(txtId_Productos.Text));

            ven.listarVentas(out dt, out nr);
            dvgVentas.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void dvgVentas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (!dvgVentas.Rows[e.RowIndex].IsNewRow)
            {
                dvgVentas.Rows.RemoveAt(e.RowIndex);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ven.eliminarVenta(Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[0].Value));
            dvgVentas.Rows.RemoveAt(dvgVentas.CurrentRow.Index);
        }


        private void btnDesplegarLista_Click(object sender, EventArgs e)
        {
            gbxVentas.Visible = true;

            DataTable dt; int nr = 0;
            ven.listarVentas(out dt, out nr);
            dvgVentas.DataSource = dt;
            if (nr > 0)
                dvgVentas.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


 


        private void VGVentas_Load(object sender, EventArgs e)
        {
            gbxVentas.Visible = true;

            DataTable dt; int nr = 0;
            ven.listarVentas(out dt, out nr);
            dvgVentas.DataSource = dt;
            if (nr > 0)
                dvgVentas.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        class VentasDB
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt;

            public VentasDB()
            {
                try
                {
                    conexion = new SqlConnection("server=localhost;Database=DB_SistemaDeVentas;integrated security=true"); // PONER LA BASE DE DATOS AQUI este es un EJEMPLO
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

            public void listarVentas(out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarVenta", conexion); // Modificar el PA  
                    adaptador = new SqlDataAdapter(cmd);
                    dt = new DataTable();

                    adaptador.Fill(dt);
                    dataTable = dt;
                    numreg = dt.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt;
                    numreg = dt.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
            }

            public void eliminarVenta(string id) // CAMBIAR EL INT Y VARIABLE
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Pa_EliminarVenta"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Ventas", SqlDbType.VarChar).Value = id;  // MODIFICAR EL @id y VARIABLE 

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                conexion.Close();
            }

            public void adicionarVenta(string id, string a1, string a2, decimal a3, decimal a4, decimal a5, string a6) // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarVenta"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Ventas", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = a1;
                cmd.Parameters.Add("@Id_Productos", SqlDbType.VarChar).Value = a2;
                cmd.Parameters.Add("@Cuenta_a_Pagar", SqlDbType.Float).Value = a3;
                cmd.Parameters.Add("@Cuenta_Pagada", SqlDbType.Float).Value = a4;
                cmd.Parameters.Add("@Total_a_Pagar", SqlDbType.Float).Value = a5;
                cmd.Parameters.Add("@Tipo_Moneda_De_Pago", SqlDbType.VarChar).Value = a6;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                conexion.Close();
            }

            public void modificarVenta(string id, string a1, string a2, decimal a3, decimal a4, decimal a5, string a6, string a7)    // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarVenta"; // MODIFICAR EL PA 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Ventas", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = a1;
                cmd.Parameters.Add("@Id_Productos", SqlDbType.VarChar).Value = a2;
                cmd.Parameters.Add("@Cuenta_a_Pagar", SqlDbType.Float).Value = a3;
                cmd.Parameters.Add("@Cuenta_Pagada", SqlDbType.Float).Value = a4;
                cmd.Parameters.Add("@Total_a_Pagar", SqlDbType.Float).Value = a5;
                cmd.Parameters.Add("@Tipo_Moneda_De_Pago", SqlDbType.VarChar).Value = a6;
                cmd.Parameters.Add("@Id_VentasNew", SqlDbType.VarChar).Value = a7;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                conexion.Close();
            }

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
