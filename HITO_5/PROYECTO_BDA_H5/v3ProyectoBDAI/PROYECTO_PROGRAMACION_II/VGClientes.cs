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
    public partial class VGClientes : Form
    {
        ClientesDB client = new ClientesDB();

        public VGClientes()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            gbxClientes.Visible = true;

            DataTable dt2; int nr2 = 0;
            client.listarClientes(out dt2, out nr2);
            dvgClientes.DataSource = dt2;
            if (nr2 > 0)
                dvgClientes.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt2; int nr2 = 0;

            client.adicionarCliente(Convert.ToString(txtId_Cliente.Text),

                Convert.ToString(txtId_Vendedor.Text),
                
                Convert.ToInt32(txtCI.Text),

                Convert.ToString(txtNombre_Clientes.Text),

                Convert.ToString(txtApellido_Clientes.Text));

            client.listarClientes(out dt2, out nr2);
            dvgClientes.DataSource = dt2;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt2; int nr2 = 0;

            client.modificarCliente(Convert.ToString(txtId_Cliente.Text),

                Convert.ToString(txtId_Vendedor.Text),

                 Convert.ToInt32(txtCI.Text),

                 Convert.ToString(txtNombre_Clientes.Text),

                 Convert.ToString(txtApellido_Clientes.Text),

                 Convert.ToString(txtNId_Cliente.Text));

            client.listarClientes(out dt2, out nr2);
            dvgClientes.DataSource = dt2;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            client.eliminarCliente(Convert.ToString(txtId_Cliente.Text));
            dvgClientes.Rows.RemoveAt(dvgClientes.CurrentRow.Index);
        }


        private void dvgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dvgClientes.Rows[e.RowIndex].IsNewRow)
            {
                dvgClientes.Rows.RemoveAt(e.RowIndex);
            }
        }


        private void btnDesplegarLista_Click(object sender, EventArgs e)
        {
            gbxClientes.Visible = true;

            DataTable dt2; int nr2 = 0;
            client.listarClientes(out dt2, out nr2);
            dvgClientes.DataSource = dt2;
            if (nr2 > 0)
                dvgClientes.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        class ClientesDB
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt2;

            public ClientesDB()
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

            public void listarClientes(out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarCliente", conexion); // Modificar el PA  
                    adaptador = new SqlDataAdapter(cmd);
                    dt2 = new DataTable();

                    adaptador.Fill(dt2);
                    dataTable = dt2;
                    numreg = dt2.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt2;
                    numreg = dt2.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
            }

            public void eliminarCliente(string id) // CAMBIAR EL INT Y VARIABLE Si Fuera NECESARIO
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Pa_EliminarCliente"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = id;  // MODIFICAR EL @id y VARIABLE 

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

            public void adicionarCliente(string id, string idv, int ci, string nom, string ap) // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarCliente"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = "C-" + id;
                cmd.Parameters.Add("@Id_Vendedor", SqlDbType.VarChar).Value = idv;
                cmd.Parameters.Add("@ci", SqlDbType.Int).Value = ci;
                cmd.Parameters.Add("@Nombre_Clientes", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@Apellido_Clientes", SqlDbType.VarChar).Value = ap;

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

            public void modificarCliente(string id, string idv, int ci, string nom, string ap, string idNew)    // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarCliente"; // MODIFICAR EL PA 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Id_Vendedor", SqlDbType.VarChar).Value = idv;
                cmd.Parameters.Add("@ci", SqlDbType.Int).Value = ci;
                cmd.Parameters.Add("@Nombre_Clientes", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@Apellido_Clientes", SqlDbType.VarChar).Value = ap;
                cmd.Parameters.Add("@Id_ClienteNew", SqlDbType.VarChar).Value = idNew;
                
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

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_INICIO2  VGPersonal = new Frm_INICIO2();
            VGPersonal.Show();
        }

    }
}
