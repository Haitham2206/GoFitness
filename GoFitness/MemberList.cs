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
    public partial class MemberList : Form
    {
        int position = 0 ;

        DataSet ds = new DataSet();
        public MemberList()
        {
            InitializeComponent();
            ds.ReadXml("CustomerTable.xml");
            dataGridMemberList.DataSource = ds.Tables[0];
            ds.Tables[0].TableName = "Customers";

            MoveData();
        }

        void MoveData() 
        {
            if(position>ds.Tables["Customers"].Rows.Count -1 || position < 0)
            {
                position = 0;
                return;
            }
            txtFirstName.Text = ds.Tables["Customers"].Rows[position]["First_Name"].ToString();
            txtLastName.Text = ds.Tables["Customers"].Rows[position]["Last_Name"].ToString();
            txtId.Text = ds.Tables["Customers"].Rows[position]["ID"].ToString();
            txtAge.Text = ds.Tables["Customers"].Rows[position]["Age"].ToString();
            txtPhoneNumber.Text = ds.Tables["Customers"].Rows[position]["Phone_Number"].ToString();
            txtEmail.Text = ds.Tables["Customers"].Rows[position]["Email"].ToString();
            txtWeight.Text = ds.Tables["Customers"].Rows[position]["Weight"].ToString();
            txtUserName.Text = ds.Tables["Customers"].Rows[position]["User_Name"].ToString();
            txtPassword.Text = ds.Tables["Customers"].Rows[position]["Password"].ToString();
            txtCourse1.Text = ds.Tables["Customers"].Rows[position]["Course1"].ToString();
            txtCourse2.Text = ds.Tables["Customers"].Rows[position]["Course2"].ToString();
            txtCourse3.Text = ds.Tables["Customers"].Rows[position]["Course3"].ToString();
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
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int i = 0;
            int j = 0;
            int initial_x = 50;
            int position_y = 100;
            int position_x = 100;
            
            Pen p = new Pen(Brushes.Black, 1.5f);

            e.Graphics.DrawString(DateTime.Now.ToLongDateString(), dataGridMemberList.Font, Brushes.Black, 600, 10);
            e.Graphics.DrawString("GoFitness", dataGridMemberList.Font, Brushes.Black, 10, 10);
            e.Graphics.DrawString("Members list", dataGridMemberList.Font, Brushes.Black, 50, 50);

            for (i = 0; i < dataGridMemberList.ColumnCount ; i++)
            {
               
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(position_x, position_y, dataGridMemberList.Columns[0].Width , dataGridMemberList.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(position_x, 100, dataGridMemberList.Columns[i].Width, dataGridMemberList.Rows[0].Height));
                e.Graphics.DrawString(dataGridMemberList.Columns[i].HeaderText.ToString(), new Font("Comic Sans MS", 6), Brushes.Black, position_x, 100);
                if (i == 6 || i == 7) { continue; }
                position_x += initial_x;
            }

            

            while( j < dataGridMemberList.Rows.Count-1)
            {
                
                if(position_y > e.MarginBounds.Height)
                {
                    position_y = 100;
                    e.HasMorePages = true;
                    return;
                }
                    position_y += dataGridMemberList.Rows[0].Height;

                    e.Graphics.DrawRectangle(p, new Rectangle(100, position_y, dataGridMemberList.Columns[0].Width/2, dataGridMemberList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridMemberList.Rows[j].Cells[0].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100, position_y, dataGridMemberList.Columns[0].Width/2, dataGridMemberList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + dataGridMemberList.Columns[0].Width / 2, position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridMemberList.Rows[j].Cells[1].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100 + dataGridMemberList.Columns[0].Width / 2, position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + 2*(dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridMemberList.Rows[j].Cells[2].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100 + 2 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + 3 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridMemberList.Rows[j].Cells[3].FormattedValue.ToString(), new Font("Comic Sans MS", 5), Brushes.Black,
                                          new Rectangle(100 + 3 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + 4 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridMemberList.Rows[j].Cells[4].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100 + 4 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + 5 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridMemberList.Rows[j].Cells[5].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100 + 5 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + 6 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridMemberList.Rows[j].Cells[8].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100 + 6 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + 7 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridMemberList.Rows[j].Cells[9].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100 + 7 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + 8 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridMemberList.Rows[j].Cells[10].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100 + 8 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width / 2, dataGridMemberList.Rows[0].Height));

                    e.Graphics.DrawRectangle(p, new Rectangle(100 + 9 * (dataGridMemberList.Columns[0].Width)/2 , position_y, dataGridMemberList.Columns[0].Width , dataGridMemberList.Rows[0].Height));
                    e.Graphics.DrawString(dataGridMemberList.Rows[j].Cells[11].FormattedValue.ToString(), new Font("Comic Sans MS", 6), Brushes.Black,
                                          new Rectangle(100 + 9 * (dataGridMemberList.Columns[0].Width / 2), position_y, dataGridMemberList.Columns[0].Width , dataGridMemberList.Rows[0].Height));
                
                j++;
                    
                
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
           // printDocument1.Print();
        }

        private void dataGridMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridMemberList.Rows[e.RowIndex];

                txtFirstName.Text = row.Cells["First_Name"].Value.ToString();
                txtLastName.Text = row.Cells["Last_Name"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["Phone_Number"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtId.Text = row.Cells["ID"].Value.ToString();
                txtWeight.Text = row.Cells["Weight"].Value.ToString();
                txtUserName.Text = row.Cells["User_Name"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtCourse1.Text = row.Cells["Course1"].Value.ToString();
                txtCourse2.Text = row.Cells["Course2"].Value.ToString();
                txtCourse3.Text = row.Cells["Course3"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FilesService file = new FilesService();
            Customer customer=new Customer(txtFirstName.Text,txtLastName.Text,txtId.Text,Convert.ToInt32(txtAge.Text),txtPhoneNumber.
                                       Text, txtEmail.Text, txtUserName.Text, txtPassword.Text, Convert.ToDouble(txtWeight.Text),
                                       txtCourse1.Text, txtCourse2.Text, txtCourse3.Text);
            file.RemoveCustomer(customer);
            MessageBox.Show("ok");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            FilesService file = new FilesService();

            Customer customer = new Customer(txtFirstName.Text, txtLastName.Text, txtId.Text, Convert.ToInt32(txtAge.Text),
                                    txtPhoneNumber.Text, txtEmail.Text, txtUserName.Text, txtPassword.Text, 
                                    Convert.ToDouble(txtWeight.Text),txtCourse1.Text, txtCourse2.Text, txtCourse3.Text);
            
            file.UpdateCustomer(customer);
            MessageBox.Show("Updated successfuly!","Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            position -= 1;
            MoveData();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            position += 1;
            MoveData();
        }

        private void MemberList_Load(object sender, EventArgs e)
        {

        }

       

        
    }
}
