using SomarOO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomarOO
{
    public partial class Somar : Form
    {
        public Somar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txtNum1.Text, txtNum2.Text, txtResultado.Text);
            controle.Executar();

            if(controle.mensagem == "")
            {
                txtResultado.Text = controle.resposta;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
