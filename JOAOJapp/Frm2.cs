using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOAOJapp
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn2Entrar_Click(object sender, EventArgs e)
        {
            
            string conexao = @"Server=SQLEXPRESS;Database=APPJOAO;User ID=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Senha = @Senha";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Senha", txt1Senha.Text);

                int resultado = (int)cmd.ExecuteScalar();

                if (resultado > 0)
                {
                    Frm3 telaPrincipal = new Frm3();
                    this.Visible = false;
                    telaPrincipal.ShowDialog();
                    this.Visible = true;    

                   this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();  
            frmCadastro.ShowDialog();
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }
    }
}
