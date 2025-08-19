namespace JOAOJapp
{
    partial class Frm2
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
            this.Lbltitulo = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txt1Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btn2Entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbltitulo
            // 
            this.Lbltitulo.AutoSize = true;
            this.Lbltitulo.Font = new System.Drawing.Font("BankGothic Lt BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitulo.Location = new System.Drawing.Point(157, 30);
            this.Lbltitulo.Name = "Lbltitulo";
            this.Lbltitulo.Size = new System.Drawing.Size(506, 67);
            this.Lbltitulo.TabIndex = 0;
            this.Lbltitulo.Text = "Identifique-se";
            this.Lbltitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblusuario.Font = new System.Drawing.Font("Swis721 Ex BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(291, 178);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(74, 19);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(371, 177);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsenha.Font = new System.Drawing.Font("Swis721 Ex BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(300, 221);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(65, 19);
            this.lblsenha.TabIndex = 3;
            this.lblsenha.Text = "Senha";
            // 
            // txt1Senha
            // 
            this.txt1Senha.Location = new System.Drawing.Point(371, 222);
            this.txt1Senha.Name = "txt1Senha";
            this.txt1Senha.Size = new System.Drawing.Size(100, 20);
            this.txt1Senha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Não tem login?";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Swis721 BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(393, 293);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(100, 27);
            this.btnCadastro.TabIndex = 6;
            this.btnCadastro.Text = "cadastre-se";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btn2Entrar
            // 
            this.btn2Entrar.Font = new System.Drawing.Font("Swis721 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Entrar.Location = new System.Drawing.Point(346, 248);
            this.btn2Entrar.Name = "btn2Entrar";
            this.btn2Entrar.Size = new System.Drawing.Size(75, 23);
            this.btn2Entrar.TabIndex = 7;
            this.btn2Entrar.Text = "Entrar";
            this.btn2Entrar.UseVisualStyleBackColor = true;
            this.btn2Entrar.Click += new System.EventHandler(this.btn2Entrar_Click);
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2Entrar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1Senha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.Lbltitulo);
            this.Name = "Frm2";
            this.Text = "Frm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbltitulo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txt1Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btn2Entrar;
    }
}