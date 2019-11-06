using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credi_Pisto
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
           

        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
         
            toolStripMenuItem1.Text = (Form1.obtenerUsuario());


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //toolStripMenuItem1.Text = ("   | Inició sesión como" + " | ");
        }
    }
}
