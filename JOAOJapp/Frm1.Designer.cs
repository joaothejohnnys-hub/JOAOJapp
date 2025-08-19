namespace JOAOJapp
{
    partial class Frm1
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
            this.Btnentrar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.TXTSENHA = new System.Windows.Forms.TextBox();
            this.Lblsenha = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnentrar
            // 
            this.Btnentrar.BackColor = System.Drawing.Color.MintCream;
            this.Btnentrar.Font = new System.Drawing.Font("BankGothic Lt BT", 16.25F, System.Drawing.FontStyle.Italic);
            this.Btnentrar.Location = new System.Drawing.Point(435, 374);
            this.Btnentrar.Name = "Btnentrar";
            this.Btnentrar.Size = new System.Drawing.Size(98, 34);
            this.Btnentrar.TabIndex = 0;
            this.Btnentrar.Text = "entrar";
            this.Btnentrar.UseVisualStyleBackColor = false;
            this.Btnentrar.Click += new System.EventHandler(this.BtnJOGAR_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(878, 518);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXTSENHA
            // 
            this.TXTSENHA.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TXTSENHA.ForeColor = System.Drawing.SystemColors.Window;
            this.TXTSENHA.Location = new System.Drawing.Point(448, 348);
            this.TXTSENHA.Name = "TXTSENHA";
            this.TXTSENHA.PasswordChar = '*';
            this.TXTSENHA.Size = new System.Drawing.Size(201, 20);
            this.TXTSENHA.TabIndex = 4;
            this.TXTSENHA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lblsenha
            // 
            this.Lblsenha.AutoSize = true;
            this.Lblsenha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lblsenha.Font = new System.Drawing.Font("Swis721 Ex BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsenha.Location = new System.Drawing.Point(302, 350);
            this.Lblsenha.Name = "Lblsenha";
            this.Lblsenha.Size = new System.Drawing.Size(140, 15);
            this.Lblsenha.TabIndex = 5;
            this.Lblsenha.Text = "entre com a senha";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JOAOJapp.Properties.Resources.pngegg;
            this.pictureBox2.Location = new System.Drawing.Point(426, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JOAOJapp.Properties.Resources.pngegg__1_;
            this.pictureBox1.Location = new System.Drawing.Point(386, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(965, 553);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lblsenha);
            this.Controls.Add(this.TXTSENHA);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.Btnentrar);
            this.Name = "Frm1";
            this.Text = "frm1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnentrar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.TextBox TXTSENHA;
        private System.Windows.Forms.Label Lblsenha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

