namespace CRUD
{
    partial class VisualizarNotas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Voltar_Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(507, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Voltar_Home
            // 
            this.btn_Voltar_Home.Location = new System.Drawing.Point(497, 379);
            this.btn_Voltar_Home.Name = "btn_Voltar_Home";
            this.btn_Voltar_Home.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar_Home.TabIndex = 1;
            this.btn_Voltar_Home.Text = "Voltar";
            this.btn_Voltar_Home.UseVisualStyleBackColor = true;
            this.btn_Voltar_Home.Click += new System.EventHandler(this.btn_Voltar_Home_Click);
            // 
            // VisualizarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1066, 552);
            this.Controls.Add(this.btn_Voltar_Home);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VisualizarNotas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VisualizarNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Voltar_Home;
    }
}