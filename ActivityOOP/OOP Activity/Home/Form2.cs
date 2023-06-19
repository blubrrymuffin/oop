using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Activity
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnproductlist_Click(object sender, EventArgs e)
        {
            Form1 product = new Form1();
            product.ShowDialog();

        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.ShowDialog();
        }
    }
}
