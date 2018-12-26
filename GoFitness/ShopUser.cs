using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GoFitness
{
    public partial class ShopUser : Form
    {
        DataSet ds = new DataSet();
        string productPrice = "";
        string productName = "";
        int quantity = 0;
        public ShopUser()
        {
            InitializeComponent();
            ds.ReadXml("ShopTable.xml");
            dataGridProductList.DataSource = ds.Tables[0];
            ds.Tables[0].TableName = "Shop";
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables["Shop"].Rows.Count - 1; i++)
            {
                if (productPrice == ds.Tables["Shop"].Rows[i]["Product_Price"].ToString())
                {
                    DataRow row = ds.Tables["Shop"].Rows[i];
                    row["Quantity"] = Convert.ToString(quantity - 1);
                    ds.WriteXml("ShopTable.xml");
                }
            }
            Receipt receipt = new Receipt();
            receipt.ItemPurchased = productName;
            receipt.Cost = productPrice;
            receipt.Show();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            Hide();
        }

        private void dataGridProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.dataGridProductList.Rows[e.RowIndex];

                productPrice = row.Cells["Product_Price"].Value.ToString();
                productName = row.Cells["Product_Name"].Value.ToString();
                quantity = Convert.ToInt32( row.Cells["Quantity"].Value.ToString());
            }
        }
    }
}
