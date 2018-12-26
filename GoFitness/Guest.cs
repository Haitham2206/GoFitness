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
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            Hide();
        }

        private void richTextAbout_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
