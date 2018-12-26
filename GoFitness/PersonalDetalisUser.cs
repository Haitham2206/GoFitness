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
    public partial class PersonalDetalisUser : Form
    {
        
        public PersonalDetalisUser()
        {
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            Hide();
        }
    }
}
