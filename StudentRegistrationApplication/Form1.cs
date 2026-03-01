using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int days= 1; days <=31; days++) {   
                Day.Items.Add(days);
        }
            for (int months = 1; months <=12; months++)
            {
                Month.Items.Add(months);
            }
            for (int year = 1900; year <= 2026; year++)
            {
                Yr.Items.Add(year);
            }
            }
        private void button1_Click(object sender, EventArgs e)
        {
            string Lastname = LName.Text;
            string Firstname = Fname.Text;
            string Middlename = Mname.Text;

            string Gen = "";
            if (M.Checked)
            {
                Gen = "Male";
            }
            else if (F.Checked)
            {
                Gen = "Female";
            }
            int day = Convert.ToInt32(Day.SelectedItem);
            int month = Convert.ToInt32(Month.SelectedItem);
            int year = Convert.ToInt32(Yr.SelectedItem);
            

          
            {
                MessageBox.Show("STudent registered");
                return;
               
            }
 

        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
