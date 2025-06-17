namespace CRUD
{
    partial class AddNotas
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
            this.lblDisciplina_1 = new System.Windows.Forms.Label();
            this.lblNota1_Disciplina1 = new System.Windows.Forms.Label();
            this.lblNota2_Disciplina1 = new System.Windows.Forms.Label();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.txtNota1_Disciplina1 = new System.Windows.Forms.TextBox();
            this.txtNota2_Disciplina1 = new System.Windows.Forms.TextBox();
            this.btnSalvar_Dados = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMatrícula_Aluno = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisciplina_1
            // 
            this.lblDisciplina_1.AutoSize = true;
            this.lblDisciplina_1.Location = new System.Drawing.Point(283, 274);
            this.lblDisciplina_1.Name = "lblDisciplina_1";
            this.lblDisciplina_1.Size = new System.Drawing.Size(55, 13);
            this.lblDisciplina_1.TabIndex = 0;
            this.lblDisciplina_1.Text = "Disciplina:";
            this.lblDisciplina_1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNota1_Disciplina1
            // 
            this.lblNota1_Disciplina1.AutoSize = true;
            this.lblNota1_Disciplina1.Location = new System.Drawing.Point(517, 274);
            this.lblNota1_Disciplina1.Name = "lblNota1_Disciplina1";
            this.lblNota1_Disciplina1.Size = new System.Drawing.Size(42, 13);
            this.lblNota1_Disciplina1.TabIndex = 3;
            this.lblNota1_Disciplina1.Text = "Nota 1:";
            // 
            // lblNota2_Disciplina1
            // 
            this.lblNota2_Disciplina1.AutoSize = true;
            this.lblNota2_Disciplina1.Location = new System.Drawing.Point(635, 274);
            this.lblNota2_Disciplina1.Name = "lblNota2_Disciplina1";
            this.lblNota2_Disciplina1.Size = new System.Drawing.Size(42, 13);
            this.lblNota2_Disciplina1.TabIndex = 6;
            this.lblNota2_Disciplina1.Text = "Nota 2:";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Location = new System.Drawing.Point(344, 271);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(167, 20);
            this.txtDisciplina.TabIndex = 1;
            // 
            // txtNota1_Disciplina1
            // 
            this.txtNota1_Disciplina1.Location = new System.Drawing.Point(565, 271);
            this.txtNota1_Disciplina1.Name = "txtNota1_Disciplina1";
            this.txtNota1_Disciplina1.Size = new System.Drawing.Size(41, 20);
            this.txtNota1_Disciplina1.TabIndex = 2;
            this.txtNota1_Disciplina1.TextChanged += new System.EventHandler(this.txtNota1_Disciplina1_TextChanged);
            // 
            // txtNota2_Disciplina1
            // 
            this.txtNota2_Disciplina1.Location = new System.Drawing.Point(683, 271);
            this.txtNota2_Disciplina1.Name = "txtNota2_Disciplina1";
            this.txtNota2_Disciplina1.Size = new System.Drawing.Size(42, 20);
            this.txtNota2_Disciplina1.TabIndex = 3;
            this.txtNota2_Disciplina1.TextChanged += new System.EventHandler(this.txtNota2_Disciplina1_TextChanged);
            // 
            // btnSalvar_Dados
            // 
            this.btnSalvar_Dados.Location = new System.Drawing.Point(485, 332);
            this.btnSalvar_Dados.Name = "btnSalvar_Dados";
            this.btnSalvar_Dados.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar_Dados.TabIndex = 4;
            this.btnSalvar_Dados.Text = "Salvar";
            this.btnSalvar_Dados.UseVisualStyleBackColor = true;
            this.btnSalvar_Dados.Click += new System.EventHandler(this.btnSalvar_Dados_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS UI Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(222, 101);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(591, 64);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "ADICIONAR NOTAS";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMatrícula_Aluno
            // 
            this.lblMatrícula_Aluno.AutoSize = true;
            this.lblMatrícula_Aluno.Location = new System.Drawing.Point(284, 204);
            this.lblMatrícula_Aluno.Name = "lblMatrícula_Aluno";
            this.lblMatrícula_Aluno.Size = new System.Drawing.Size(55, 13);
            this.lblMatrícula_Aluno.TabIndex = 26;
            this.lblMatrícula_Aluno.Text = "Matrícula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(345, 201);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(381, 20);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.Location = new System.Drawing.Point(341, 235);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(352, 13);
            this.msg.TabIndex = 27;
            this.msg.Text = " DIGITE A MESMA MATRÍCULA DA TELA DE ( CADASTRO )";
            // 
            // AddNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1077, 530);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatrícula_Aluno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalvar_Dados);
            this.Controls.Add(this.txtNota2_Disciplina1);
            this.Controls.Add(this.txtNota1_Disciplina1);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.lblNota2_Disciplina1);
            this.Controls.Add(this.lblNota1_Disciplina1);
            this.Controls.Add(this.lblDisciplina_1);
            this.Name = "AddNotas";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisciplina_1;
        private System.Windows.Forms.Label lblNota1_Disciplina1;
        private System.Windows.Forms.Label lblNota2_Disciplina1;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.TextBox txtNota1_Disciplina1;
        private System.Windows.Forms.TextBox txtNota2_Disciplina1;
        private System.Windows.Forms.Button btnSalvar_Dados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMatrícula_Aluno;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label msg;
    }
}