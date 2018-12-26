using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFitness
{
    public partial class ShopAdmin : Form
    {
        DataSet ds = new DataSet();
        public ShopAdmin()
        {
            InitializeComponent();
            ds.ReadXml("ShopTable.xml");
            dataGridProductList.DataSource = ds.Tables[0];
            ds.Tables[0].TableName = "Shop";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Admin admin = new Admin();
            admin.Show();
            Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }

        private void printShopTable_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int i = 0;
            int j = 0;
            int initial_x = 50;
            int position_y = 100;
            int position_x = 100;

            Pen p = new Pen(Brushes.Black, 1.5f);

            e.Graphics.DrawString(DateTime.Now.ToLongDateString(), dataGridProductList.Font, Brushes.Black, 600, 10);
            e.Graphics.DrawString("GoFitness", dataGridProductList.Font, Brushes.Black, 10, 10);
            e.Graphics.DrawString("Products list", dataGridProductList.Font, Brushes.Black, 50, 50);

            for (i = 0; i < dataGridProductList.ColumnCount; i++)
            {

                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(position_x, position_y, dataGridProductList.Columns[0].Width, dataGridProductList.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(position_x, 100, dataGridProductList.Columns[i].Width, dataGridProductList.Rows[0].Height));
                e.Graphics.DrawString(dataGridProductList.Columns[i].HeaderText.ToString(), new Font("Comic Sans MS", 6), Brushes.Black, position_x, 100);
               
                position_x += initial_x;
            }



            while (j < dataGridProductList.Rows.Count - 1)
            {

                if (position_y > e.MarginBounds.Height)
                {
                    position_y = 100;
                    e.HasMorePages = true;
                    return;
                }
                position_y += dataGridProductList.Rows[0].Height;

                e.Graphics.DrawRectangle(p, new Rectangle(100, position_y, dataGridProductList.Columns[0].Width / 2, dataGridProductList.Rows[0].Height));
                e.Graphics.DrawString(dataGridProductList.Rows[j].Cells[0].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                      new Rectangle(100, position_y, dataGridProductList.Columns[0].Width / 2, dataGridProductList.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(100 + dataGridProductList.Columns[0].Width / 2, position_y, dataGridProductList.Columns[0].Width / 2, dataGridProductList.Rows[0].Height));
                e.Graphics.DrawString(dataGridProductList.Rows[j].Cells[1].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                      new Rectangle(100 + dataGridProductList.Columns[0].Width / 2, position_y, dataGridProductList.Columns[0].Width / 2, dataGridProductList.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(100 + 2 * (dataGridProductList.Columns[0].Width / 2), position_y, dataGridProductList.Columns[0].Width / 2, dataGridProductList.Rows[0].Height));
                e.Graphics.DrawString(dataGridProductList.Rows[j].Cells[2].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                      new Rectangle(100 + 2 * (dataGridProductList.Columns[0].Width / 2), position_y, dataGridProductList.Columns[0].Width / 2, dataGridProductList.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(100 + 3 * (dataGridProductList.Columns[0].Width / 2), position_y, dataGridProductList.Columns[0].Width / 2, dataGridProductList.Rows[0].Height));
                e.Graphics.DrawString(dataGridProductList.Rows[j].Cells[3].FormattedValue.ToString(), new Font("Comic Sans MS", 5), Brushes.Black,
                                      new Rectangle(100 + 3 * (dataGridProductList.Columns[0].Width / 2), position_y, dataGridProductList.Columns[0].Width / 2, dataGridProductList.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(100 + 4 * (dataGridProductList.Columns[0].Width / 2), position_y, dataGridProductList.Columns[0].Width , dataGridProductList.Rows[0].Height));
                e.Graphics.DrawString(dataGridProductList.Rows[j].Cells[4].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                      new Rectangle(100 + 4 * (dataGridProductList.Columns[0].Width / 2), position_y, dataGridProductList.Columns[0].Width / 2, dataGridProductList.Rows[0].Height));

                j++;
            }
        }
    }
}
