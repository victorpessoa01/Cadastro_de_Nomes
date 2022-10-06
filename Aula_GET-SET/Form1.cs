using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Aula_GET_SET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variaveis_GET_SET VarOb = new Variaveis_GET_SET();

            VarOb.Name1 = textBoxNome1.Text;
            VarOb.Name2 = textBoxNome2.Text;
            VarOb.Name3 = textBoxNome3.Text;
            VarOb.Name4 = textBoxNome4.Text;
            VarOb.Name5 = textBoxNome5.Text;

            listBox1.Items.Add(VarOb.Name2);
            listBox1.Items.Add(VarOb.Name5);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
