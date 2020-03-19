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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2(string name)
        {
            InitializeComponent();
            label1.Text = "Welcome " + name;
          


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbposDataSet1.Producttbl' table. You can move, or remove it, as needed.

            this.producttblTableAdapter.Fill(this.dbposDataSet1.Producttbl);
            this.KeyPreview = true;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            CatagorieForm catagorieForm = new CatagorieForm();
            catagorieForm.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();
            
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                metroTile1.PerformClick();
            }
            else if(e.KeyCode == Keys.F2)
            {
                metroTile2.PerformClick();
            }
        }
    }
}
