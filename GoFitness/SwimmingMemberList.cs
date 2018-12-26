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
    public partial class SwimmingMemberList : Form
    {
        DataSet ds = new DataSet();
        public SwimmingMemberList()
        {
            InitializeComponent();
            ds.ReadXml("SwimmingCustomerTable.xml");
            dataGridSwimmingMemberList.DataSource = ds.Tables[0];
            ds.Tables[0].TableName = "SwimmingCustomerTable";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MainPage.userRole == "Admin")
            {
                Admin admin = new Admin();
                admin.Show();
                Hide();
            }
            else
            {
                Employee employee = new Employee();
                employee.Show();
                Hide();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }
    }
}
