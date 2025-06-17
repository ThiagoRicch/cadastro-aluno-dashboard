namespace CRUD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalvar_Home = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btn_Voltar_Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // btnSalvar_Home
            // 
            this.btnSalvar_Home.Location = new System.Drawing.Point(584, 420);
            this.btnSalvar_Home.Name = "btnSalvar_Home";
            this.btnSalvar_Home.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar_Home.TabIndex = 1;
            this.btnSalvar_Home.Text = "Salvar";
            this.btnSalvar_Home.UseVisualStyleBackColor = true;
            this.btnSalvar_Home.Click += new System.EventHandler(this.btnVoltar_Home_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(135, 323);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(744, 48);
            this.lblAviso.TabIndex = 2;
            this.lblAviso.Text = resources.GetString("lblAviso.Text");
            this.lblAviso.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Voltar_Home
            // 
            this.btn_Voltar_Home.Location = new System.Drawing.Point(339, 420);
            this.btn_Voltar_Home.Name = "btn_Voltar_Home";
            this.btn_Voltar_Home.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar_Home.TabIndex = 3;
            this.btn_Voltar_Home.Text = "Voltar";
            this.btn_Voltar_Home.UseVisualStyleBackColor = true;
            this.btn_Voltar_Home.Click += new System.EventHandler(this.btn_Voltar_Home_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1036, 497);
            this.Controls.Add(this.btn_Voltar_Home);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnSalvar_Home);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalvar_Home;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btn_Voltar_Home;
    }
}