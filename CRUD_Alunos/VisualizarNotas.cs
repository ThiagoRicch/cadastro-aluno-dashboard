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

namespace CRUD
{
    public partial class VisualizarNotas : Form
    {
        public VisualizarNotas()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Home_Click(object sender, EventArgs e)
        {
            Home f3 = new Home();
            f3.Show();
            this.Hide();
        }

        private void VisualizarNotas_Load(object sender, EventArgs e)
        {
            string conexao_db = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DADOS_ALUNOS;Integrated Security=True;";
            string query = "SELECT * FROM NOTAS";

            using (SqlConnection con = new SqlConnection(conexao_db))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt);
                    dataGridView1.DataSource = (dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro! ao carregar Dados {ex} ");
                }
            }

        }
    }
}
