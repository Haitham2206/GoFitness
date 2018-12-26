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
    public partial class Employee : Form
    {
        public Employee()
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

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            MemberList member = new MemberList();
            member.Show();
            Hide();

        }

        private void btnSwimmingMemberList_Click(object sender, EventArgs e)
        {
            SwimmingMemberList swim = new SwimmingMemberList();
            swim.Show();
            Hide();
        }
    }
}
