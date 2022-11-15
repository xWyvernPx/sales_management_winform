
using BusinessObject;
using BusinessObject.Service;
using DataAccess.Entity;
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
        IProductService productService;
        IMemberService memberService;
        IOrderService orderService;
        public Management()
        {
            InitializeComponent();
        }
        private void LoadMember(string term = null)
        {
            memberService = new MemberService();
            if (term is not null)
            {
                var members = memberService.FindAll(term);
                dgvMember.DataSource = null;
                dgvMember.DataSource = members.ToList();
            }
            else
            {
                var members = memberService.FindAll(term);
                dgvMember.DataSource = null;
                dgvMember.DataSource = members.ToList();

            }
        }
        private void LoadProduct(string term = null)
        {
            productService = new ProductService();
            if (term is not null)
            {
                var products = productService.FindAll(term);
                dgvProduct.DataSource = null;
                dgvProduct.DataSource = products.ToList();
            }
            else
            {
                var products = productService.FindAll();
                dgvProduct.DataSource = null;
                dgvProduct.DataSource = products.ToList();

            }


        }
        private void Management_Load(object sender, EventArgs e)
        {

            //this.IsMdiContainer = true;
            //var productForm = new FrmProduct();
            //productForm.MdiParent = this;

            //productForm.Show();
            LoadProduct();
            LoadMember();
            LoadOrder();


        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmProduct product = new()
            {
                UpdateOrInsert = false,
            };

            if (product.ShowDialog() == DialogResult.OK)
            {
                product.Hide();
                product.Text = "";
                LoadProduct();
            }

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            LoadProduct(txtSearchProd.Text.Trim());
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            FrmProduct product = new()
            {
                UpdateOrInsert = true,
            };
            var index = dgvProduct.CurrentCell.RowIndex;
            var selected = dgvProduct.Rows[index].Cells[0].Value.ToString();
            product.Tag = (ProductObject)productService.GetById(int.Parse(selected));

            if (product.ShowDialog() == DialogResult.OK)
            {
                product.Hide();
                product.Text = "";
                LoadProduct();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("Are you sure to delete this product?", "Delete Warning", MessageBoxButtons.OKCancel);
            if (diaResult == DialogResult.OK)
            {
                var index = dgvProduct.CurrentCell.RowIndex;
                var selected = dgvProduct.Rows[index].Cells[0].Value.ToString();
                productService.Delete(int.Parse(selected));
                LoadProduct();
            }
          
        }

        private void tabMember_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("Are you sure to delete this member?", "Delete Warning", MessageBoxButtons.OKCancel);
            if (diaResult == DialogResult.OK)
            {
                var index = dgvMember.CurrentCell.RowIndex;
                var selected = dgvMember.Rows[index].Cells[0].Value.ToString();
                memberService.Delete(int.Parse(selected));
                LoadMember();
            }
            
        }


        private void txtMemUpdate_Click(object sender, EventArgs e)
        {
            FrmMember memberForm = new()
            {
                UpdateOrInsert = true,
            };
            var index = dgvMember.CurrentCell.RowIndex;
            var selected = dgvMember.Rows[index].Cells[0].Value.ToString();
            memberForm.Tag = memberService.GetById(int.Parse(selected));

            if (memberForm.ShowDialog() == DialogResult.OK)
            {
                memberForm.Hide();
                memberForm.Text = "";
                LoadMember();
            }
        }

        private void txtMemAdd_Click(object sender, EventArgs e)
        {
            FrmMember memberForm = new()
            {
                UpdateOrInsert = false,
            };

            if (memberForm.ShowDialog() == DialogResult.OK)
            {
                memberForm.Hide();
                memberForm.Text = "";
                LoadMember();
            }
        }

        private void LoadOrder()
        {
            orderService = new OrderService();

            var orders = orderService.FindAll();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = orders.ToList();
        }
        private void tabOrder_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DateTime from = dtFrom.Value;
            DateTime to = dtTo.Value;
            var orders =  orderService.FindAll().Where(order => order.OrderDate >= from && order.OrderDate <= to);
            // TODO populate Order Detail

        }
    }
}
