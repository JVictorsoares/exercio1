using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btsoma_Click(object sender, EventArgs e)
        {
            int  v1, v2, btsoma;
            v1 = int.Parse(valor1.Text);
            v2 = int.Parse(valor2.Text);
            btsoma = valor1 + valor2;
            resultado.Text = btsoma.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
