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
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnJOGAR_Click(object sender, EventArgs e)
        {
            if (TXTSENHA.Text == "ADM")
            {
                // Abre o Form2 e esconde o Form1
                this.Visible = false; // ou this.Close(); se quiser fechar
                Frm2 frm2 = new Frm2();
                frm2.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Acesso negado. Texto incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("obrigado por usar o sistema",
                "AVISO!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            Environment.Exit(0);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
    }
