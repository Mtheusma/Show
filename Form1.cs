using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DasafioPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int idade = 0;
            string resultado;
            string nome;
            string sobrenome;
            int data;
            int anoatual = int.Parse(DateTime.Now.ToString("yyyy"));
            if (txtVerificarnome.Text != "" && txtSobrenome.Text != "")
            {
                 nome = txtVerificarnome.Text;
                 sobrenome = txtSobrenome.Text;
                 data = int.Parse(txtData.Text);
                 idade = anoatual - data;
                pibPizza.Image = Properties.Resources.Pensado3;

                if (idade >= 18)
                {
                    lblResultado.Text = nome + " " + sobrenome + " " + idade + " anos";
                    // lblSobrenome.ForeColor = Color.Green;
                    // Mudar a img para um recurso do projeto:
                    pibPizza.Image = Properties.Resources.Feliz1;

                }
                else
                {
                    lblResultadodetudo.Text = "MORRA!!!";
                    lblResultadodetudo.ForeColor = Color.Red  ;
                    // Mudar a img para um recurso do projeto:
                    pibPizza.Image = Properties.Resources.Triste2;
                }
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVerificarnome.Clear();
            txtSobrenome.Clear();
            lblResultado.Text = "";
            pibPizza.Image = Properties.Resources.Pensado3;
            txtData.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
