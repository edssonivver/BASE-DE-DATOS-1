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
    public partial class VGInventario : Form
    {
        InventarioBD inv = new InventarioBD();


        public VGInventario()
        {
            InitializeComponent();
        }


        private void VGInventario_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            inv.listarInventario(out dt, out nr);
            dgvInventario.DataSource = dt;
            if (nr > 0)
                dgvInventario.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inv.eliminarInvetario(Convert.ToString(txtId_Inventario.Text));
            dgvInventario.Rows.RemoveAt(dgvInventario.CurrentRow.Index);
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            inv.adicionarInventaio(Convert.ToString(txtId_Inventario.Text),

                Convert.ToString(txtId_Productos.Text),

                Convert.ToString(txtId_Gerente_Del_Inventario.Text),

                Convert.ToString(txtProductos.Text),

                Convert.ToString(txtMarcas.Text));

            inv.listarInventario(out dt, out nr);
            dgvInventario.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            inv.modificarInventario(Convert.ToString(txtId_Inventario.Text),

                Convert.ToString(txtId_Productos.Text),

                Convert.ToString(txtId_Gerente_Del_Inventario.Text),

                Convert.ToString(txtProductos.Text),

                Convert.ToString(txtMarcas.Text),

                Convert.ToString(txtNId_Inventario.Text));

            inv.listarInventario(out dt, out nr);
            dgvInventario.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            inv.listarInventario(out dt, out nr);
            dgvInventario.DataSource = dt;
            if (nr > 0)
                dgvInventario.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btn_volver_Click_1(object sender, EventArgs e)
        {
            //VentanaGerente VentanaGerente = new VentanaGerente();
            //VentanaGerente.Show();
            //this.Close();
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

            public void eliminarInvetario(string id)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_EliminarInventario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Inventario", SqlDbType.VarChar).Value = id;

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

            public void adicionarInventaio(string id, string idprod, string idinvg,string Pro, string mar)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarInventario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Inventario", SqlDbType.VarChar).Value = "Inv-" + id;
                cmd.Parameters.Add("@Id_Productos", SqlDbType.VarChar).Value = idprod;
                cmd.Parameters.Add("@Id_Gerente_Del_Inventario", SqlDbType.VarChar).Value = idinvg;
                cmd.Parameters.Add("@Productos", SqlDbType.VarChar).Value = Pro;
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

            public void modificarInventario(string id, string idprod, string idinvg,string Pro, string mar, string idN)   // cambiar por string el id
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarInventario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Inventario", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Id_Productos", SqlDbType.VarChar).Value = idprod;
                cmd.Parameters.Add("@Id_Gerente_Del_Inventario", SqlDbType.VarChar).Value = idinvg;
                cmd.Parameters.Add("@Productos", SqlDbType.VarChar).Value = Pro;
                cmd.Parameters.Add("@Marcas", SqlDbType.VarChar).Value = mar;
                cmd.Parameters.Add("@Id_InventarioNew", SqlDbType.VarChar).Value = idN;

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


        private void dgvInventario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvInventario.Rows[e.RowIndex].IsNewRow)
            {
                dgvInventario.Rows.RemoveAt(e.RowIndex);
            }
        }

    }
}
