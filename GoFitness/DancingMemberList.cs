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
using System.Xml.Linq;

namespace GoFitness
{
    public partial class DancingMemberList : Form
    {

        DataSet ds = new DataSet();
        
        public DancingMemberList()
        {
            InitializeComponent();
            ds.ReadXml("DancingCustomerTable.xml");
            dataGridDancingMemberList.DataSource = ds.Tables[0];
            ds.Tables[0].TableName = "DancingCustomerTable";
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

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void groupMember_Enter(object sender, EventArgs e)
        {

        }
    }
}
