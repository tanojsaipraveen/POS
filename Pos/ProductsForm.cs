using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class ProductsForm : MetroFramework.Forms.MetroForm
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Database=dbpos;trusted_connection=true;");
            string query = "insert into Producttbl values ('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            string result = cmd.ExecuteNonQuery().ToString();
            if (result == "1")
            {
                MessageBox.Show("Data inserted");
                Form2 form2 = new Form2("sddd");
                form2.Hide();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data not inserted");
            }
            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
            con.Close();
        }
    }
}
