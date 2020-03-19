using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            

        }
            private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Hide();
                Form2 f2 = new Form2(textBox1.Text);
                f2.ShowDialog();
              
            }
            else
            {
                MessageBox.Show("Invalid Login..");
                textBox2.Text = "";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
