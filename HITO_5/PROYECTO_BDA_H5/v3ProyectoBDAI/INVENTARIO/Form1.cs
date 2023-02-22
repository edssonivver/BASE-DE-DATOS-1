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

namespace INVENTARIO
{
    public partial class Form1 : Form
    {
        InventarioBD inv = new InventarioBD();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            inv.listarInventario(out dt, out nr);
            dgvInventario.DataSource = dt;
            if (nr > 0)
                dgvInventario.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;
            switch (cmbBuscar.SelectedIndex)
            {
                case 0:
                    inv.buscarIdInventario(txtBuscar.Text, out dt, out nr);
                    dgvInventario.DataSource = dt;
                    break;
                case 1:
                    inv.buscarIdProducto(txtBuscar.Text, out dt, out nr);
                    dgvInventario.DataSource = dt;
                    break;
                case 2:
                    inv.buscarProducto(txtBuscar.Text, out dt, out nr);
                    dgvInventario.DataSource = dt;
                    break;
                case 3:
                    inv.buscarMarcas(Convert.ToInt32(txtBuscar.Text), out dt, out nr);
                    dgvInventario.DataSource = dt;
                    break;
            }
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            inv.listarInventario(out dt, out nr);
            dgvInventario.DataSource = dt;
            if (nr > 0)
                dgvInventario.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }



        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            inv.eliminarInvetario(Convert.ToInt32(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[0].Value));
            dgvInventario.Rows.RemoveAt(dgvInventario.CurrentRow.Index);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            inv.adicionarInventaio(Convert.ToInt32(dgvInventario.Rows[dgvInventario.CurrentRow.Index - 1].Cells[0].Value),

                Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[3].Value));

            inv.listarInventario(out dt, out nr);
            dgvInventario.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            inv.modificarInventario(Convert.ToInt32(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[0].Value),

                Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[3].Value));

            inv.listarInventario(out dt, out nr);
            dgvInventario.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        class InventarioBD
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt;

            public InventarioBD()
            {
                try
                {
                    conexion = new SqlConnection("server=localhost;Database=DB_SistemaDeVentas;integrated security=true");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

            public void listarInventario(out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarInventario", conexion);
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

            public void eliminarInvetario(int id)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_EliminarInventario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Inventario", SqlDbType.Int).Value = id;

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

            public void adicionarInventaio(int id, string idprod, string Pro, string mar)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarInventario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Inventario", SqlDbType.Int).Value = id + 1;
                cmd.Parameters.Add("@Id_Producto", SqlDbType.VarChar).Value = idprod;
                cmd.Parameters.Add("@Producto", SqlDbType.VarChar).Value = Pro;
                cmd.Parameters.Add("@Marcas", SqlDbType.VarChar).Value = mar;

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

            public void modificarInventario(int id, string idprod, string Pro, string mar)   // cambiar por string el id
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarInventario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Inventario", SqlDbType.Int).Value = id;  // Int y modificar bda sino quitar el +1 y ver que pasa
                cmd.Parameters.Add("@Id_Producto", SqlDbType.VarChar).Value = idprod;
                cmd.Parameters.Add("@Producto", SqlDbType.VarChar).Value = Pro;
                cmd.Parameters.Add("@Marcas", SqlDbType.VarChar).Value = mar;


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

            public void buscarIdInventario(string nom, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarIdInventario";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Inventario", SqlDbType.VarChar).Value = nom;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }



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
                conexion.Close();
            }

            public void buscarIdProducto(string apPaterno, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarIdProducto";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Producto", SqlDbType.VarChar).Value = apPaterno;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

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
                conexion.Close();
            }

            public void buscarProducto(string apMaterno, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarProducto";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Producto", SqlDbType.VarChar).Value = apMaterno;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

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
                conexion.Close();
            }

            public void buscarMarcas(int ed, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarMarcas";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Marcas", SqlDbType.Int).Value = ed;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

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
                conexion.Close();
            }
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvInventario.Rows[e.RowIndex].IsNewRow)
            {
                dgvInventario.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
