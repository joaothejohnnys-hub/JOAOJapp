using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOAOJapp
{
    public partial class Frm3 : Form
    {
        public Frm3()
        {
            InitializeComponent();
        }

        private void BtnJordan_Click(object sender, EventArgs e)
        {




        }

        private void PicJordan_Click(object sender, EventArgs e)
        {
        
            // Criar instância do formulário que será aberto
            FrmJordan1 frmJordan = new FrmJordan1();

            // Mostrar o novo formulário
            frmJordan.Show();

            // Esconder o formulário atual
            this.Hide();
        }

    }
}

