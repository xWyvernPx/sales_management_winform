using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
            //var productForm = new FrmProduct();
            //productForm.MdiParent = this;

            //productForm.Show();
           var context = new Assignment02Context();

            var products = context.Products;
            products.ToList().ForEach(ele =>
            {
                listView1.Items.Add(ele.ProductName);

            });
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
