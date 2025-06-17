using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarAluno f1 = new CadastrarAluno();
            f1.Show();
            this.Hide();

        }

        private void btnVisualizarDados_Click(object sender, EventArgs e)
        {
            VisualizarDados tela = new VisualizarDados();
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisualizarNotas tela = new VisualizarNotas();
            tela.Show();
        }

        private void Btn_Sair_Tela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Dados_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Dados_Click_1(object sender, EventArgs e)
        {
            Form1 telaEditarDados = new Form1();
            telaEditarDados.Show();
            this.Hide();
        }

        private void btnExcluir_Dados_Click(object sender, EventArgs e)
        {
            EditarNotas tela = new EditarNotas();
            tela.Show();
            this.Hide();
        }
    }
}
