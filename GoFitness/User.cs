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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            ShopUser shop = new ShopUser();
            shop.Show();
            Hide();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CourseUser course = new CourseUser();
            course.Show();
            Hide();
        }

        private void btnPersonalDetails_Click(object sender, EventArgs e)
        {
            PersonalDetalisUser personaldetalis = new PersonalDetalisUser();
            personaldetalis.Show();
            Hide();
        }
    }
}
