using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOAOJapp
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string conexao = @"Server=SQLEXPRESS;Database=APPJOAO;User ID=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                string query = "INSERT INTO Usuarios (Usuario, Senha) VALUES (@Usuario, @Senha);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", txtNovoUsuario.Text);
                cmd.Parameters.AddWithValue("@Senha", txtNovaSenha.Text);

                int resultado = (int)cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    Frm2 telaPrincipal = new Frm2();
                    telaPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
