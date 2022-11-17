using BusinessObject;
using BusinessObject.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class FrmReport : Form
    {
        IProductService productService = new ProductService();
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            var orders = (IEnumerable<OrderObject>)this.Tag;
            var fullOrders = orders.Select(order =>
            {
                double sales = 0;

                order.OrderDetails?.ToList().ForEach(detail =>
                    sales = sales + detail.UnitPrice * detail.Quantity * (1 - detail.Discount)
                ); ;

                return new
                {
                    OrderId = order.OrderId,
                    MemberId = order.MemberId,
                    OrderDate = order.OrderDate,
                    RequiredDate = order.RequiredDate,
                    ShippedDate = order.ShippedDate,
                    Freight = order.Freight,
                    Items = order.OrderDetails?.ToArray()?.Length ?? 0,
                    Sales = sales
                };
            }).OrderBy(order => order.Sales);
            var orderDetails = new List<OrderDetailObject>();
            orders.ToList().ForEach(order => orderDetails.AddRange(order.OrderDetails));

            double total = fullOrders.Sum(order => order.Sales);
            double avg = fullOrders.Average(order => order.Sales);
            int count = fullOrders.Count();
            lbAvgSale.Text = avg.ToString();
            lbNoOrder.Text = count.ToString();
            lbTotalSale.Text = total.ToString();
            lbBestProd.Text = FindBestSeller(orderDetails)?.ProductName;
            dgvOrder.DataSource = fullOrders.ToList();
        }
        private ProductObject FindBestSeller(IEnumerable<OrderDetailObject> details)
        {
            var detailsGroup = from detail in details
                               group detail by detail.ProductId into prodGroup
                               select prodGroup;
            int max = 0;
            int prodId = -1;
            detailsGroup.ToList().ForEach(group =>
            {
               int sum =  group.Sum(detail => detail.Quantity);
                if (sum > max)
                {
                    max = sum;
                    prodId = group.Key;
                }
            });
            return productService.FindAll().Where(prod => prod.ProductId == prodId).FirstOrDefault();
                              

        }
    }
}
