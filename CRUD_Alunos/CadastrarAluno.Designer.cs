namespace CRUD
{
    partial class CadastrarAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome_Aluno = new System.Windows.Forms.Label();
            this.txtNome_Aluno = new System.Windows.Forms.TextBox();
            this.lblSobrenome_Aluno = new System.Windows.Forms.Label();
            this.txtSobrenome_Aluno = new System.Windows.Forms.TextBox();
            this.txtNum_Matricula = new System.Windows.Forms.TextBox();
            this.lblNum_Matrícula = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnCadastrar_Aluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome_Aluno
            // 
            this.lblNome_Aluno.AutoSize = true;
            this.lblNome_Aluno.Location = new System.Drawing.Point(361, 248);
            this.lblNome_Aluno.Name = "lblNome_Aluno";
            this.lblNome_Aluno.Size = new System.Drawing.Size(38, 13);
            this.lblNome_Aluno.TabIndex = 0;
            this.lblNome_Aluno.Text = "Nome:";
            // 
            // txtNome_Aluno
            // 
            this.txtNome_Aluno.Location = new System.Drawing.Point(439, 245);
            this.txtNome_Aluno.Name = "txtNome_Aluno";
            this.txtNome_Aluno.Size = new System.Drawing.Size(184, 20);
            this.txtNome_Aluno.TabIndex = 1;
            this.txtNome_Aluno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSobrenome_Aluno
            // 
            this.lblSobrenome_Aluno.AutoSize = true;
            this.lblSobrenome_Aluno.Location = new System.Drawing.Point(361, 284);
            this.lblSobrenome_Aluno.Name = "lblSobrenome_Aluno";
            this.lblSobrenome_Aluno.Size = new System.Drawing.Size(64, 13);
            this.lblSobrenome_Aluno.TabIndex = 2;
            this.lblSobrenome_Aluno.Text = "Sobrenome:";
            this.lblSobrenome_Aluno.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSobrenome_Aluno
            // 
            this.txtSobrenome_Aluno.Location = new System.Drawing.Point(439, 281);
            this.txtSobrenome_Aluno.Name = "txtSobrenome_Aluno";
            this.txtSobrenome_Aluno.Size = new System.Drawing.Size(184, 20);
            this.txtSobrenome_Aluno.TabIndex = 2;
            // 
            // txtNum_Matricula
            // 
            this.txtNum_Matricula.Location = new System.Drawing.Point(439, 206);
            this.txtNum_Matricula.Name = "txtNum_Matricula";
            this.txtNum_Matricula.Size = new System.Drawing.Size(184, 20);
            this.txtNum_Matricula.TabIndex = 0;
            this.txtNum_Matricula.TextChanged += new System.EventHandler(this.txtNum_Matricula_TextChanged);
            // 
            // lblNum_Matrícula
            // 
            this.lblNum_Matrícula.AutoSize = true;
            this.lblNum_Matrícula.Location = new System.Drawing.Point(361, 209);
            this.lblNum_Matrícula.Name = "lblNum_Matrícula";
            this.lblNum_Matrícula.Size = new System.Drawing.Size(70, 13);
            this.lblNum_Matrícula.TabIndex = 5;
            this.lblNum_Matrícula.Text = "N° Matrícula:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(364, 320);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 6;
            this.lblCurso.Text = "Curso:";
            this.lblCurso.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(439, 317);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(184, 20);
            this.txtCurso.TabIndex = 3;
            // 
            // btnCadastrar_Aluno
            // 
            this.btnCadastrar_Aluno.Location = new System.Drawing.Point(586, 374);
            this.btnCadastrar_Aluno.Name = "btnCadastrar_Aluno";
            this.btnCadastrar_Aluno.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar_Aluno.TabIndex = 8;
            this.btnCadastrar_Aluno.Text = "Cadastrar";
            this.btnCadastrar_Aluno.UseVisualStyleBackColor = true;
            this.btnCadastrar_Aluno.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 64);
            this.label1.TabIndex = 9;
            this.label1.Text = "CADASTRO DE ALUNO";
            // 
            // CadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1060, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar_Aluno);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblNum_Matrícula);
            this.Controls.Add(this.txtNum_Matricula);
            this.Controls.Add(this.txtSobrenome_Aluno);
            this.Controls.Add(this.lblSobrenome_Aluno);
            this.Controls.Add(this.txtNome_Aluno);
            this.Controls.Add(this.lblNome_Aluno);
            this.Name = "CadastrarAluno";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CadastrarAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome_Aluno;
        private System.Windows.Forms.TextBox txtNome_Aluno;
        private System.Windows.Forms.Label lblSobrenome_Aluno;
        private System.Windows.Forms.TextBox txtSobrenome_Aluno;
        private System.Windows.Forms.TextBox txtNum_Matricula;
        private System.Windows.Forms.Label lblNum_Matrícula;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnCadastrar_Aluno;
        private System.Windows.Forms.Label label1;
    }
}

