using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFitness
{
    
    public partial class Receipt : Form
    {
        public string ItemPurchased ;
        public string Cost ;
        public Receipt()
        {
            InitializeComponent();
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }

        private void printReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            e.Graphics.DrawString("GoFitness", richTextReceipt.Font, Brushes.Black, 10, 10);
            
            e.Graphics.DrawString(richTextReceipt.Text, richTextReceipt.Font, Brushes.Black, 100, 100);
        }

        private void richTextReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

            richTextReceipt.AppendText(Environment.NewLine + DateTime.Now.ToShortTimeString()+" "+ DateTime.Now.ToShortDateString());
            richTextReceipt.AppendText(Environment.NewLine + "Receipt");
            richTextReceipt.AppendText(Environment.NewLine + "Paid fot the products: "+ItemPurchased);
            richTextReceipt.AppendText(Environment.NewLine + "Total cost:  "+Cost);
            richTextReceipt.AppendText(Environment.NewLine + "========================== ");
            richTextReceipt.AppendText(Environment.NewLine + "Hope to deal with you again  ");
            richTextReceipt.AppendText(Environment.NewLine + "Thank you  ");
        }
    }
}
