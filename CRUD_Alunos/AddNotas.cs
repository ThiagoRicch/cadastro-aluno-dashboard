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
    public partial class AddNotas : Form
    {

        string conexao_db = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DADOS_ALUNOS;Integrated Security=True;";
        public AddNotas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota1_Disciplina1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota2_Disciplina1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Dados_Click(object sender, EventArgs e)
        {
            string disciplina = txtDisciplina.Text;
            string nota1 = txtNota1_Disciplina1.Text;
            string nota2 = txtNota2_Disciplina1.Text;
            string matricula = txtMatricula.Text;
            double media_disciplina;

            try
            {

                if (string.IsNullOrWhiteSpace(disciplina))
                {
                    MessageBox.Show("Por favor Preencha os Campos");
                    return;
                }
                if (string.IsNullOrWhiteSpace(matricula))
                {
                    MessageBox.Show("Por favor Preencha os Campos");
                    return;
                }

                if (string.IsNullOrWhiteSpace(nota1) || string.IsNullOrWhiteSpace(nota2))
                {
                    MessageBox.Show("Preencha os Campos!");
                    return;
                }
                if (!double.TryParse(nota1, out double n1_d1) || !double.TryParse(nota2, out double n2_d1))
                {
                    MessageBox.Show("Campo Invalído para Notas (Tente usar vírgula)");
                    return;

                }

                string status_d1;

                media_disciplina = (n1_d1 + n2_d1) / 2;
                if (media_disciplina > 7)

                {
                    status_d1 = "APROVADO";
                }
                else if (media_disciplina >= 5 && media_disciplina < 7)
                {
                    status_d1 = "RECUPERAÇÃO";
                }
                else
                {
                    status_d1 = "REPROVADO";
                }

                MessageBox.Show($"Matrícula: {matricula} <<>> Média de {disciplina} = {media_disciplina:F2} -> Status: {status_d1}");


                using (SqlConnection conn = new SqlConnection(conexao_db))
                {


                    conn.Open();

                    string query = "INSERT INTO NOTAS (Matrícula, Disciplina, Nota1, Nota2, Media, Status_Aluno) VALUES (@matrícula, @disciplina, @nota1, @nota2, @media, @status_aluno)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    
                    cmd.Parameters.AddWithValue("@matrícula", matricula);
                    cmd.Parameters.AddWithValue("@disciplina", disciplina);
                    cmd.Parameters.AddWithValue("@nota1", n1_d1);
                    cmd.Parameters.AddWithValue("@nota2", n2_d1);
                    cmd.Parameters.AddWithValue("@media", media_disciplina);
                    cmd.Parameters.AddWithValue("@status_aluno", status_d1);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado");


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro! (TENTE COLOCAR UMA MATRÍCULA JÁ EXISTENTE) "  + ex);
            }

            Home f3 = new Home();
            f3.Show();
            this.Hide();

        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
