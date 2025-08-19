namespace JOAOJapp
{
    partial class FrmCadastro
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
            this.lblnovocadastro = new System.Windows.Forms.Label();
            this.txtNovoUsuario = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblnovasenha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnovocadastro
            // 
            this.lblnovocadastro.AutoSize = true;
            this.lblnovocadastro.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblnovocadastro.Font = new System.Drawing.Font("Swis721 BT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnovocadastro.Location = new System.Drawing.Point(82, 67);
            this.lblnovocadastro.Name = "lblnovocadastro";
            this.lblnovocadastro.Size = new System.Drawing.Size(188, 35);
            this.lblnovocadastro.TabIndex = 0;
            this.lblnovocadastro.Text = "Novo Usuário";
            // 
            // txtNovoUsuario
            // 
            this.txtNovoUsuario.Location = new System.Drawing.Point(87, 106);
            this.txtNovoUsuario.Name = "txtNovoUsuario";
            this.txtNovoUsuario.Size = new System.Drawing.Size(114, 20);
            this.txtNovoUsuario.TabIndex = 2;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(87, 238);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(100, 20);
            this.txtNovaSenha.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Swis721 BT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(299, 351);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(203, 55);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "CADASTRAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblnovasenha
            // 
            this.lblnovasenha.AutoSize = true;
            this.lblnovasenha.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblnovasenha.Font = new System.Drawing.Font("Swis721 BT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnovasenha.Location = new System.Drawing.Point(81, 200);
            this.lblnovasenha.Name = "lblnovasenha";
            this.lblnovasenha.Size = new System.Drawing.Size(168, 35);
            this.lblnovasenha.TabIndex = 5;
            this.lblnovasenha.Text = "Nova Senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JOAOJapp.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(688, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblnovasenha);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.txtNovoUsuario);
            this.Controls.Add(this.lblnovocadastro);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnovocadastro;
        private System.Windows.Forms.TextBox txtNovoUsuario;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblnovasenha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}