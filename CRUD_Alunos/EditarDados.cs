using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        string conexion_db = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DADOS_ALUNOS;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem != null)
            {
                DataRowView drv = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                DataRow row = drv.Row;

                string conexion_db = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DADOS_ALUNOS;Integrated Security=True;";
                string query = "UPDATE ALUNOS SET Matrícula=@matrícula, Nome=@nome, Sobrenome=@sobrenome, Curso=@curso WHERE Id = @id";

                using (SqlConnection conn = new SqlConnection(conexion_db))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", row["Id"]);
                    cmd.Parameters.AddWithValue("@matrícula", row["Matrícula"]);
                    cmd.Parameters.AddWithValue("@nome", row["Nome"]);
                    cmd.Parameters.AddWithValue("@sobrenome", row["Sobrenome"]);
                    cmd.Parameters.AddWithValue("@curso", row["Curso"]);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnVoltar_Home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados Alterados Com Sucesso!");

            Home tela = new Home();
            tela.Show();
            this.Hide();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void CarregarDados()
        {
            string conexao_db = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DADOS_ALUNOS;Integrated Security=True;";
            string query = "SELECT * FROM ALUNOS";

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

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            
        
            DialogResult resultado = MessageBox.Show(
                "Você tem certeza que deseja excluir este registro?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            int id = Convert.ToInt32(e.Row.Cells["Id"].Value);

            using (SqlConnection con = new SqlConnection(conexion_db))
            {
                con.Open();

                
                SqlCommand cmd1 = new SqlCommand("DELETE FROM Notas WHERE Id = @id", con);
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.ExecuteNonQuery();

                
                SqlCommand cmd2 = new SqlCommand("DELETE FROM Alunos WHERE Id = @id", con);
                cmd2.Parameters.AddWithValue("@Id", id);
                cmd2.ExecuteNonQuery();
            }

            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_Home_Click(object sender, EventArgs e)
        {
            Home f3 = new Home();
            f3.Show();
            this.Hide();
        }
    }
    
}
