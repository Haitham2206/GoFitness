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
    public partial class CourseUser : Form
    {
        DataSet ds = new DataSet();

        public string CourseName = " ";
        public string CoursePrice = " ";
        public int QuantityOfMembers = 0;

        public CourseUser()
        {
            InitializeComponent();

            ds.ReadXml("CourseTable.xml");
            dataGridCourseList.DataSource = ds.Tables[0];
            ds.Tables[0].TableName = "Courses";
        }

        private void CourseUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSubscribeToCourse_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables["Courses"].Rows.Count - 1; i++)
            {
                if (CoursePrice == ds.Tables["Courses"].Rows[i]["Price"].ToString())
                {
                    DataRow row = ds.Tables["Courses"].Rows[i];
                    row["Quantity_Of_Members"] = Convert.ToString(QuantityOfMembers + 1);
                    ds.WriteXml("CourseTable.xml");
                }
            }
            Receipt receipt = new Receipt();
            receipt.ItemPurchased = CourseName + " course";
            receipt.Cost = CoursePrice;
            receipt.Show();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            Hide();
        }

        private void dataGridCourseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridCourseList.Rows[e.RowIndex];

                CourseName = row.Cells["Name_Of_Course"].Value.ToString();
                CoursePrice = row.Cells["Price"].Value.ToString();
                QuantityOfMembers = Convert.ToInt32(row.Cells["Quantity_Of_Members"].Value.ToString());
            }
        }
    }
}
