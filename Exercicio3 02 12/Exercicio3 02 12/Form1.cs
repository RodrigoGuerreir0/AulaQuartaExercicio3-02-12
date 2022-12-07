using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3_02_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible= false;
            label2.Visible= false;
            label3.Visible= false;
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            label1.Visible= true;
            label1.Text = "Dog";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            label2.Visible= true;
            label2.Text =  "Wood";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            label3.Visible= true;
            label3.Text = "Water";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
