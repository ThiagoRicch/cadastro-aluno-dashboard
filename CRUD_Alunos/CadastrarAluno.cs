using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class CadastrarAluno : Form
    {
        string conexãoDB = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DADOS_ALUNOS;Integrated Security=True;";
        public CadastrarAluno()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matricula_aluno = txtNum_Matricula.Text.ToUpper(); 
            string nome_aluno = txtNome_Aluno.Text;
            string sobrenome_aluno = txtSobrenome_Aluno.Text;
            string curso = txtCurso.Text;

            if (matricula_aluno.Length < 7 || matricula_aluno.Length > 7)
            {
                MessageBox.Show("Matrícula deve ter 7 caracteres exatos!");
                return;
            }
            if (matricula_aluno == "" || nome_aluno == "" || sobrenome_aluno == "" || curso == "")
            {
                MessageBox.Show("Preencha Todos os Campos!");
                return;
            }

            using(SqlConnection conn = new SqlConnection(conexãoDB))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO ALUNOS (Matrícula, Nome, Sobrenome, Curso) VALUES (@matrícula ,@nome, @sobrenome, @curso)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@matrícula", matricula_aluno);
                    cmd.Parameters.AddWithValue("@nome",nome_aluno);
                    cmd.Parameters.AddWithValue("@sobrenome", sobrenome_aluno);
                    cmd.Parameters.AddWithValue("@curso", curso);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro! {ex}");
                }
            }

            
            txtNum_Matricula.Focus();
            txtNum_Matricula.Clear();
            txtNome_Aluno.Clear();
            txtSobrenome_Aluno.Clear();
            txtCurso.Clear();

            AddNotas f2 = new AddNotas();
            f2.Show();
            this.Hide();
        
            
           
            
        }

        private void txtNum_Matricula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CadastrarAluno_Load(object sender, EventArgs e)
        {

        }
    }
}
