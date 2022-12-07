using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text="Banana";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text="Morango";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
