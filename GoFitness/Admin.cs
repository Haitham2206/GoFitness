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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnGymMemberList_Click(object sender, EventArgs e)
        {
            GymMemberList gym = new GymMemberList();
            gym.Show();
            Hide();
        }

        private void btnDancingMemberList_Click(object sender, EventArgs e)
        {
            DancingMemberList dance = new DancingMemberList();
            dance.Show();
            Hide();
        }

        private void btnSwimmingMemberList_Click(object sender, EventArgs e)
        {
            SwimmingMemberList swim = new SwimmingMemberList();
            swim.Show();
            Hide();
        }

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            MemberList member = new MemberList();
            member.Show();
            Hide();

        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CoursesAdmin course = new CoursesAdmin();
            course.Show();
            Hide();

        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            ShopAdmin shop = new ShopAdmin();
            shop.Show();
            Hide();
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            EmployeeList employee = new EmployeeList();
            employee.Show();
            Hide();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("BankTable.xml");
            
            XmlElement root = doc.DocumentElement;
            XmlElement bank = (XmlElement)root.ChildNodes[0].ChildNodes[0];
            string balance = bank.ChildNodes[0].InnerText;

            MessageBox.Show("The Updated Balance is:  " +balance+"$" , "Hello Boss :) ", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}
