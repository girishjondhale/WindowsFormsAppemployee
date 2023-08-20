using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsAppemployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           List <string> list = new List<string>() { "hr","admin","development","testing","sales","marketing"};
            combodept.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salary=Convert.ToDouble(txtsalary.Text);
            double hra = salary * 0.40;
            double ta = salary * 0.20;
            double da = salary * 0.10;
            double pf = salary * 0.12;

            double Gross = (salary + hra + ta + da) - pf;

            txthra.Text = hra.ToString();
            txtta.Text = ta.ToString();
            txtda.Text = da.ToString();
            txtpf.Text = pf.ToString();
            txtgs.Text = da.ToString();

        }

        private void txtdisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Id={txtid.Text}\nName={txtname.Text}\nDepartment Name={combodept.Text}\nBasic Salary={txtsalary.Text}\nGross Salary={txtgs.Text}");
        }
    }
}
