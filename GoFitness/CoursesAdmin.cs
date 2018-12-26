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
    public partial class CoursesAdmin : Form
    {
        DataSet ds = new DataSet();

        public CoursesAdmin()
        {
            InitializeComponent();
            ds.ReadXml("CourseTable.xml");
            dataGridCourseList.DataSource = ds.Tables[0];
            ds.Tables[0].TableName = "Courses";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Admin admin = new Admin();
            admin.Show();
            Hide();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {

        }

        private void printCourseTable_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i = 0;
            int j = 0;
            int initial_x = 50;
            int position_y = 100;
            int position_x = 100;

            Pen p = new Pen(Brushes.Black, 1.5f);

            e.Graphics.DrawString(DateTime.Now.ToLongDateString(), dataGridCourseList.Font, Brushes.Black, 600, 10);
            e.Graphics.DrawString("GoFitness", dataGridCourseList.Font, Brushes.Black, 10, 10);
            e.Graphics.DrawString("Courses list", dataGridCourseList.Font, Brushes.Black, 50, 50);

            for (i = 0; i < dataGridCourseList.ColumnCount; i++)
            {

                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(position_x, position_y, dataGridCourseList.Columns[0].Width, dataGridCourseList.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(position_x, 100, dataGridCourseList.Columns[i].Width, dataGridCourseList.Rows[0].Height));
                e.Graphics.DrawString(dataGridCourseList.Columns[i].HeaderText.ToString(), new Font("Comic Sans MS", 6), Brushes.Black, position_x, 100);

                position_x += initial_x;
            }



            while (j < dataGridCourseList.Rows.Count - 1)
            {

                if (position_y > e.MarginBounds.Height)
                {
                    position_y = 100;
                    e.HasMorePages = true;
                    return;
                }
                position_y += dataGridCourseList.Rows[0].Height;

                e.Graphics.DrawRectangle(p, new Rectangle(100, position_y, dataGridCourseList.Columns[0].Width / 2, dataGridCourseList.Rows[0].Height));
                e.Graphics.DrawString(dataGridCourseList.Rows[j].Cells[0].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                      new Rectangle(100, position_y, dataGridCourseList.Columns[0].Width / 2, dataGridCourseList.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(100 + dataGridCourseList.Columns[0].Width / 2, position_y, dataGridCourseList.Columns[0].Width / 2, dataGridCourseList.Rows[0].Height));
                e.Graphics.DrawString(dataGridCourseList.Rows[j].Cells[1].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                      new Rectangle(100 + dataGridCourseList.Columns[0].Width / 2, position_y, dataGridCourseList.Columns[0].Width / 2, dataGridCourseList.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(100 + 2 * (dataGridCourseList.Columns[0].Width / 2), position_y, dataGridCourseList.Columns[0].Width / 2, dataGridCourseList.Rows[0].Height));
                e.Graphics.DrawString(dataGridCourseList.Rows[j].Cells[2].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                      new Rectangle(100 + 2 * (dataGridCourseList.Columns[0].Width / 2), position_y, dataGridCourseList.Columns[0].Width / 2, dataGridCourseList.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(100 + 3 * (dataGridCourseList.Columns[0].Width / 2), position_y, dataGridCourseList.Columns[0].Width / 2, dataGridCourseList.Rows[0].Height));
                e.Graphics.DrawString(dataGridCourseList.Rows[j].Cells[3].FormattedValue.ToString(), new Font("Comic Sans MS", 5), Brushes.Black,
                                      new Rectangle(100 + 3 * (dataGridCourseList.Columns[0].Width / 2), position_y, dataGridCourseList.Columns[0].Width / 2, dataGridCourseList.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(100 + 4 * (dataGridCourseList.Columns[0].Width / 2), position_y, dataGridCourseList.Columns[0].Width/2, dataGridCourseList.Rows[0].Height));
                e.Graphics.DrawString(dataGridCourseList.Rows[j].Cells[4].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                      new Rectangle(100 + 4 * (dataGridCourseList.Columns[0].Width / 2), position_y, dataGridCourseList.Columns[0].Width / 2, dataGridCourseList.Rows[0].Height));


                e.Graphics.DrawRectangle(p, new Rectangle(100 + 5 * (dataGridCourseList.Columns[0].Width / 2), position_y, dataGridCourseList.Columns[0].Width/2, dataGridCourseList.Rows[0].Height));
                e.Graphics.DrawString(dataGridCourseList.Rows[j].Cells[5].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                      new Rectangle(100 + 5 * (dataGridCourseList.Columns[0].Width / 2), position_y, dataGridCourseList.Columns[0].Width / 2, dataGridCourseList.Rows[0].Height));


                e.Graphics.DrawRectangle(p, new Rectangle(100 + 6 * (dataGridCourseList.Columns[0].Width / 2), position_y, dataGridCourseList.Columns[0].Width/2, dataGridCourseList.Rows[0].Height));
                e.Graphics.DrawString(dataGridCourseList.Rows[j].Cells[6].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                      new Rectangle(100 + 6 * (dataGridCourseList.Columns[0].Width / 2), position_y, dataGridCourseList.Columns[0].Width / 2, dataGridCourseList.Rows[0].Height));


                e.Graphics.DrawRectangle(p, new Rectangle(100 + 7 * (dataGridCourseList.Columns[0].Width / 2), position_y, dataGridCourseList.Columns[0].Width, dataGridCourseList.Rows[0].Height));
                e.Graphics.DrawString(dataGridCourseList.Rows[j].Cells[7].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                      new Rectangle(100 + 7 * (dataGridCourseList.Columns[0].Width / 2), position_y, dataGridCourseList.Columns[0].Width / 2, dataGridCourseList.Rows[0].Height));

                j++;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }
    }
}
