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
    public partial class MainPage : Form
    {
        public static string userRole ;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRegisterNewCustomer_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            Hide();
        }

        private void btnGuset_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();
            guest.Show();
            Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            
                XmlDocument memberDoc = new XmlDocument();
                memberDoc.Load("CustomerTable.xml");
                foreach (XmlNode node in memberDoc.SelectNodes("//Customer"))
                {
                    string userName = node.SelectSingleNode("User_Name").InnerText;
                    string password = node.SelectSingleNode("Password").InnerText;
                    string firstName = node.SelectSingleNode("First_Name").InnerText;

                    if (userName == txtUserName.Text && password == txtPassword.Text)
                    {
                        this.Hide();
                        User user = new User();
                        user.Show();
                        userRole = "Customer";
                        user.CreateGraphics().DrawString("Hello " + firstName + " :)", GroupLogIn.Font, Brushes.Black, 3, 3);
                        return;
                    }


                }

                XmlDocument employeeDoc = new XmlDocument();
                employeeDoc.Load("EmployeeTable.xml");
                foreach (XmlNode node in employeeDoc.SelectNodes("//Employee"))
                {
                    string userName = node.SelectSingleNode("User_Name").InnerText;
                    string password = node.SelectSingleNode("Password").InnerText;
                    string firstName = node.SelectSingleNode("First_Name").InnerText;

                    if (userName == txtUserName.Text && password == txtPassword.Text)
                    {
                        Employee employee = new Employee();
                        employee.Show();
                        Hide();
                        userRole = "Employee";
                        employee.CreateGraphics().DrawString("Hello " + firstName + " :)", GroupLogIn.Font, Brushes.Black, 3, 3);
                        return;
                    }


                }

                XmlDocument adminDoc = new XmlDocument();
                adminDoc.Load("ManagerDetailsTable.xml");
                foreach (XmlNode node in adminDoc.SelectNodes("//Manager"))
                {
                    string userName = node.SelectSingleNode("User_Name").InnerText;
                    string password = node.SelectSingleNode("Password").InnerText;
                    //string firstName = node.SelectSingleNode("First_Name").InnerText;

                    if (userName == txtUserName.Text && password == txtPassword.Text)
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        Hide();
                        userRole = "Admin";
                        admin.CreateGraphics().DrawString("Hello Boss :)" , GroupLogIn.Font, Brushes.Black, 3, 3);
                        return;
                    }
                    

                }
            
                if (txtUserName.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Insert your Username and password!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
        }
    }
}
