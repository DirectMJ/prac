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
    public partial class Form1 : Form
    {
        int Item1 = 3500;
        int Item2 = 4200;
        int Item3 = 7800;
        int Item4 = 6000;
        int Item5 = 5400;
        int Item6 = 3800;

        int totalAmount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Item");
            dt.Columns.Add("Price");

            if (cb1.Checked)
            {
                totalAmount += Item1;
                dt.Rows.Add("Balmain", 3500);
            }
            if (cb2.Checked)
            {
                totalAmount += Item2;
                dt.Rows.Add("Aj1 Low", 4200);
            }
            if (cb3.Checked)
            {
                totalAmount += Item3;
                dt.Rows.Add("Airmag", 7800);
            }
            if (cb4.Checked)
            {
                totalAmount += Item4;
                dt.Rows.Add("Court Vision", 6000);
            }
            if (cb5.Checked)
            {
                totalAmount += Item5;
                dt.Rows.Add("Elevate 3", 5400);
            }
            if (cb6.Checked)
            {
                totalAmount += Item6;
                dt.Rows.Add("Air Max", 3800);
            }


            Form2 frm2 = new Form2 (totalAmount, dt);
            frm2.ShowDialog();
        }
    }
}
