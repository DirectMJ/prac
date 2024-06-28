using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracLang
{
    public partial class Form2 : Form
    {
        
        double total, payment, change;
        DataTable dt = new DataTable();
        public Form2(int _total, DataTable _dt)
        {
            InitializeComponent();
            total = _total;
            dt = _dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTotal.Text = total.ToString();
            dtGrid.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            payment = int.Parse(txtAmount.Text);

            if (payment < total)
            {
                MessageBox.Show("Insufficient amount enetered.");
            } else
            {
                change = payment - total;
                MessageBox.Show("Item/s purchased successfully." + 
                    "\nTotal Amount: " + total + "\n Payment Amount: " + payment + "\n Change: " + change);
            }
        }
    }
}
