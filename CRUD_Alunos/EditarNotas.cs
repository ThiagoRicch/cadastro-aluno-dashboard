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
    public partial class EditarNotas : Form
    {
        string conexion_db = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DADOS_ALUNOS;Integrated Security=True;";
        public EditarNotas()
        {
            InitializeComponent();
        }
       
       
        private void EditarNotas_Load(object sender, EventArgs e)
        {
            CarregarNotas();
        }


        private void CarregarNotas()
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
                    MessageBox.Show($"Erro! ao carregar Dados {ex}");
                }
            }
        }

       

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Dados Alterados Com Sucesso!");

            Home tela = new Home();
            tela.Show();
            this.Hide();

           
        }

        private void dataGridView1_RowValidated_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem != null)
            {
                DataRowView drv = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                DataRow row = drv.Row;

                string conexion_db = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DADOS_ALUNOS;Integrated Security=True;";
                string query = "UPDATE NOTAS SET Matrícula=@matrícula, Disciplina=@disciplina, Nota1=@nota1, Nota2=@nota2, Media=@media, Status_Aluno=@status_aluno WHERE Id = @id";

                using (SqlConnection conn = new SqlConnection(conexion_db))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", row["Id"]);
                    cmd.Parameters.AddWithValue("@matrícula", row["Matrícula"]);
                    cmd.Parameters.AddWithValue("@disciplina", row["Disciplina"]);
                    cmd.Parameters.AddWithValue("@nota1", row["Nota1"]);
                    cmd.Parameters.AddWithValue("@nota2", row["Nota2"]);
                    cmd.Parameters.AddWithValue("@media", row["Media"]);
                    cmd.Parameters.AddWithValue("@status_aluno", row["Status_Aluno"]);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btn_Voltar_Home_Click(object sender, EventArgs e)
        {
            Home f3 = new Home();
            f3.Show();
            this.Hide();
        }
    }
}
