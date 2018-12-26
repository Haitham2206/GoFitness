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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Welcome To Our Club", "Go Fitness", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                MainPage page = new MainPage();
                page.Show();
                Hide();
            }
            else if(dr == DialogResult.Cancel)
            {
                return ;
                
            }

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
