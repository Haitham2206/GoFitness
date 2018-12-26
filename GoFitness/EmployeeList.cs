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
    public partial class EmployeeList : Form
    {
        DataSet ds = new DataSet();

        public EmployeeList()
        {
            InitializeComponent();
            ds.ReadXml("EmployeeTable.xml");
            dataGridEmployeeList.DataSource = ds.Tables[0];
            ds.Tables[0].TableName = "Employees";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //printEmployeeList.Print();
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i = 0;
            int j = 0;
            
            int initial_x = 50;
            int position_y = 100;
            int position_x = 100;
            int position2_x = 100;

            Pen p = new Pen(Brushes.Black, 1.5f);

            e.Graphics.DrawString(DateTime.Now.ToLongDateString(), dataGridEmployeeList.Font, Brushes.Black, 630, 10);
            e.Graphics.DrawString("GoFitness", dataGridEmployeeList.Font, Brushes.Black, 10, 10);
            e.Graphics.DrawString("Employee list", dataGridEmployeeList.Font, Brushes.Black, 50, 50);

            for (i = 0; i < dataGridEmployeeList.ColumnCount-2; i++)
            {

                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(position_x, position_y, dataGridEmployeeList.Columns[0].Width, dataGridEmployeeList.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(position_x, 100, dataGridEmployeeList.Columns[i].Width, dataGridEmployeeList.Rows[0].Height));
                e.Graphics.DrawString(dataGridEmployeeList.Columns[i].HeaderText.ToString(), new Font("Comic Sans MS", 6), Brushes.Black, position_x, 100);
               
                position_x += initial_x;
            }



            while (j < dataGridEmployeeList.Rows.Count - 1)
            {

                if (position_y > e.MarginBounds.Height)
                {
                    position_y = 100;
                    e.HasMorePages = true;
                    return;
                }
                
                position_y += dataGridEmployeeList.Rows[0].Height;
                

              
                    e.Graphics.DrawRectangle(p, new Rectangle(position2_x , position_y, dataGridEmployeeList.Columns[0].Width , dataGridEmployeeList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridEmployeeList.Rows[j].Cells[0].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100, position_y, dataGridEmployeeList.Columns[0].Width , dataGridEmployeeList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + dataGridEmployeeList.Columns[0].Width / 2, position_y, dataGridEmployeeList.Columns[0].Width / 2, dataGridEmployeeList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridEmployeeList.Rows[j].Cells[1].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100 + dataGridEmployeeList.Columns[0].Width / 2, position_y, dataGridEmployeeList.Columns[0].Width / 2, dataGridEmployeeList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + 2 * (dataGridEmployeeList.Columns[0].Width / 2), position_y, dataGridEmployeeList.Columns[0].Width / 2, dataGridEmployeeList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridEmployeeList.Rows[j].Cells[2].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100 + 2 * (dataGridEmployeeList.Columns[0].Width / 2), position_y, dataGridEmployeeList.Columns[0].Width / 2, dataGridEmployeeList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + 3 * (dataGridEmployeeList.Columns[0].Width / 2), position_y, dataGridEmployeeList.Columns[0].Width / 2, dataGridEmployeeList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridEmployeeList.Rows[j].Cells[3].FormattedValue.ToString(), new Font("Comic Sans MS", 5), Brushes.Black,
                                          new Rectangle(100 + 3 * (dataGridEmployeeList.Columns[0].Width / 2), position_y, dataGridEmployeeList.Columns[0].Width / 2, dataGridEmployeeList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + 4 * (dataGridEmployeeList.Columns[0].Width / 2), position_y, dataGridEmployeeList.Columns[0].Width / 2, dataGridEmployeeList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridEmployeeList.Rows[j].Cells[4].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100 + 4 * (dataGridEmployeeList.Columns[0].Width / 2), position_y, dataGridEmployeeList.Columns[0].Width / 2, dataGridEmployeeList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + 5 * (dataGridEmployeeList.Columns[0].Width / 2), position_y, dataGridEmployeeList.Columns[0].Width, dataGridEmployeeList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridEmployeeList.Rows[j].Cells[5].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100 + 5 * (dataGridEmployeeList.Columns[0].Width / 2), position_y, dataGridEmployeeList.Columns[0].Width, dataGridEmployeeList.Rows[0].Height));

               
                j++;


            }
        }

        private void dataGridEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFireEmployee_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
