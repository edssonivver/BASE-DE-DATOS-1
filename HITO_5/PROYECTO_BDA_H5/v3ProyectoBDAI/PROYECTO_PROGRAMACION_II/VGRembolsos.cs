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
    public partial class VGRembolsos : Form
    {
        RembolsoDB remb = new RembolsoDB();

        public VGRembolsos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void VGRembolsos_Load(object sender, EventArgs e)
        {
            gbxRembolsos.Visible = true;

            DataTable dt2; int nr2 = 0;
            remb.listarRembolsos(out dt2, out nr2);
            dvgRembolsos.DataSource = dt2;
            if (nr2 > 0)
                dvgRembolsos.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt2; int nr2 = 0;

            remb.adicionarRembolso(Convert.ToString(txtId_Rembolsos.Text),

                Convert.ToString(txtId_Cliente.Text),

                Convert.ToString(txtId_Productos_Rembolsados.Text),

                Convert.ToDecimal(txtMonto_Rembolsado.Text),

                Convert.ToString(txtTipo_Moenda.Text),

                Convert.ToString(txtStock.Text));


            remb.listarRembolsos(out dt2, out nr2);
            dvgRembolsos.DataSource = dt2;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            remb.eliminarRembolso(Convert.ToString(txtId_Rembolsos.Text));
            dvgRembolsos.Rows.RemoveAt(dvgRembolsos.CurrentRow.Index);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt2; int nr2 = 0;

            remb.modificarRembolso(Convert.ToString(txtId_Rembolsos.Text),

                Convert.ToString(txtId_Cliente.Text),

                Convert.ToString(txtId_Productos_Rembolsados.Text),

                Convert.ToDecimal(txtMonto_Rembolsado.Text),

                Convert.ToString(txtTipo_Moenda.Text),

                Convert.ToString(txtStock.Text),

                Convert.ToString(txtNId_Rembolsos.Text));


            remb.listarRembolsos(out dt2, out nr2);
            dvgRembolsos.DataSource = dt2;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void dvgRembolsos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dvgRembolsos.Rows[e.RowIndex].IsNewRow)
            {
                dvgRembolsos.Rows.RemoveAt(e.RowIndex);
            }
        }


        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            gbxRembolsos.Visible = true;

            DataTable dt2; int nr2 = 0;
            remb.listarRembolsos(out dt2, out nr2);
            dvgRembolsos.DataSource = dt2;
            if (nr2 > 0)
                dvgRembolsos.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            //VentanaGerente VGPersonal = new VentanaGerente();
            //VGPersonal.Show();
            //this.Close();
        }





        class RembolsoDB
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt2;

            public RembolsoDB()
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

            public void listarRembolsos(out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarRembolsos", conexion); // Modificar el PA  
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

            public void eliminarRembolso(string id) // CAMBIAR EL INT Y VARIABLE Si Fuera NECESARIO
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Pa_EliminarRembolso"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Rembolsos", SqlDbType.Int).Value = id;  // MODIFICAR EL @id y VARIABLE 

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


            public void adicionarRembolso(string id, string client, string prod, decimal marc, string montRem, string mot) // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarRembolso"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Rembolsos", SqlDbType.VarChar).Value = "Remb-" + id;
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = client;
                cmd.Parameters.Add("@Id_Productos_Rembolsados", SqlDbType.VarChar).Value = prod;
                cmd.Parameters.Add("@Monto_Rembolsado", SqlDbType.Float).Value = marc;
                cmd.Parameters.Add("@Tipo_Moneda", SqlDbType.VarChar).Value = montRem;
                cmd.Parameters.Add("@Motivo", SqlDbType.VarChar).Value = mot;


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

            public void modificarRembolso(string id, string client, string prod, decimal marc, string montRem, string mot, string idN) // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarRembolso"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Rembolsos", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = client;
                cmd.Parameters.Add("@Id_Productos_Rembolsados", SqlDbType.VarChar).Value = prod;
                cmd.Parameters.Add("@Monto_Rembolsado", SqlDbType.Float).Value = marc;
                cmd.Parameters.Add("@Tipo_Moneda", SqlDbType.VarChar).Value = montRem;
                cmd.Parameters.Add("@Motivo", SqlDbType.VarChar).Value = mot;
                cmd.Parameters.Add("@Id_RembolsosNew", SqlDbType.VarChar).Value = idN;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
