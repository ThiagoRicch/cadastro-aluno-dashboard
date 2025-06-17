namespace CRUD
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVisualizarDados = new System.Windows.Forms.Button();
            this.btnEditar_Dados = new System.Windows.Forms.Button();
            this.btnEditar_Notas = new System.Windows.Forms.Button();
            this.Btn_Sair_Tela = new System.Windows.Forms.Button();
            this.btn_Visualizar_Notas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("MS UI Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(414, 122);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(201, 64);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "HOME";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(425, 213);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(178, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar/Aluno Novo";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVisualizarDados
            // 
            this.btnVisualizarDados.Location = new System.Drawing.Point(425, 253);
            this.btnVisualizarDados.Name = "btnVisualizarDados";
            this.btnVisualizarDados.Size = new System.Drawing.Size(178, 23);
            this.btnVisualizarDados.TabIndex = 2;
            this.btnVisualizarDados.Text = "Visualizar Dados Alunos";
            this.btnVisualizarDados.UseVisualStyleBackColor = true;
            this.btnVisualizarDados.Click += new System.EventHandler(this.btnVisualizarDados_Click);
            // 
            // btnEditar_Dados
            // 
            this.btnEditar_Dados.Location = new System.Drawing.Point(425, 336);
            this.btnEditar_Dados.Name = "btnEditar_Dados";
            this.btnEditar_Dados.Size = new System.Drawing.Size(178, 23);
            this.btnEditar_Dados.TabIndex = 3;
            this.btnEditar_Dados.Text = "Editar Dados Alunos";
            this.btnEditar_Dados.UseVisualStyleBackColor = true;
            this.btnEditar_Dados.Click += new System.EventHandler(this.btnEditar_Dados_Click_1);
            // 
            // btnEditar_Notas
            // 
            this.btnEditar_Notas.Location = new System.Drawing.Point(425, 377);
            this.btnEditar_Notas.Name = "btnEditar_Notas";
            this.btnEditar_Notas.Size = new System.Drawing.Size(178, 23);
            this.btnEditar_Notas.TabIndex = 4;
            this.btnEditar_Notas.Text = "Editar Dados Notas";
            this.btnEditar_Notas.UseVisualStyleBackColor = true;
            this.btnEditar_Notas.Click += new System.EventHandler(this.btnExcluir_Dados_Click);
            // 
            // Btn_Sair_Tela
            // 
            this.Btn_Sair_Tela.Location = new System.Drawing.Point(982, 12);
            this.Btn_Sair_Tela.Name = "Btn_Sair_Tela";
            this.Btn_Sair_Tela.Size = new System.Drawing.Size(75, 33);
            this.Btn_Sair_Tela.TabIndex = 5;
            this.Btn_Sair_Tela.Text = "Sair";
            this.Btn_Sair_Tela.UseVisualStyleBackColor = true;
            this.Btn_Sair_Tela.Click += new System.EventHandler(this.Btn_Sair_Tela_Click);
            // 
            // btn_Visualizar_Notas
            // 
            this.btn_Visualizar_Notas.Location = new System.Drawing.Point(425, 295);
            this.btn_Visualizar_Notas.Name = "btn_Visualizar_Notas";
            this.btn_Visualizar_Notas.Size = new System.Drawing.Size(178, 23);
            this.btn_Visualizar_Notas.TabIndex = 6;
            this.btn_Visualizar_Notas.Text = "Visualizar Notas Alunos";
            this.btn_Visualizar_Notas.UseVisualStyleBackColor = true;
            this.btn_Visualizar_Notas.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1069, 518);
            this.Controls.Add(this.btn_Visualizar_Notas);
            this.Controls.Add(this.Btn_Sair_Tela);
            this.Controls.Add(this.btnEditar_Notas);
            this.Controls.Add(this.btnEditar_Dados);
            this.Controls.Add(this.btnVisualizarDados);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblHome);
            this.Name = "Home";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVisualizarDados;
        private System.Windows.Forms.Button btnEditar_Dados;
        private System.Windows.Forms.Button btnEditar_Notas;
        private System.Windows.Forms.Button Btn_Sair_Tela;
        private System.Windows.Forms.Button btn_Visualizar_Notas;
    }
}