using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public void DisplayStudentInfo(string fname, string mname, string lname,string gender, 
           string dob, string program)
        {
            string message = $"Student name: {fname} {mname} {lname}\n" +
                             $"Gender: {gender}\n" +
                             $"Date of Birth: {dob}\n" +
                             $"Program: {program}";
            MessageBox.Show(message, "Student Info");
        }
        public void DisplayStudentInfo(string fname, string lname, string gender,
           string dob, string program)
        {
            string message = $"Student name: {fname} {lname}\n" +
                            $"Gender: {gender}\n" +
                            $"Date of Birth: {dob}\n" +
                            $"Program: {program}";
            MessageBox.Show(message, "Student Info");
        }
                 public void DisplayStudentInfo(string fname, string mname, string lname)
        {
            string message = $"Student name: {fname} {lname}";
            MessageBox.Show(message, "Student Info");
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
            string day = Day.SelectedItem?.ToString();
            string month = Month.SelectedItem?.ToString();  
            string year = Yr.SelectedItem?.ToString();
            string dob = $"{day}/{month}/{year}";

            string program = cmbProgram.SelectedItem?.ToString();
          
            {
                string message = $"Student name: {Firstname} {Middlename} {Lastname}\n" +
                $"Gender: {Gen}\n" +
                $"Date of Birth: {dob}\n" +
                $"Program: {program}";


                DisplayStudentInfo(Firstname,Middlename, Lastname,Gen, dob, program);
                DisplayStudentInfo(Firstname, Lastname, Gen, dob, program);
                DisplayStudentInfo(Firstname,Middlename, Lastname);
               
            }
 

        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
            for (int days = 1; days <= 31; days++)
            {
                Day.Items.Add(days);
            }
            string[] months = {"January","February","March","April","May","June","July","August","September",
                "October","November","December"};
           
            {
                Month.Items.AddRange(months);
            }
            for (int year = 1900; year <= 2026; year++)
            {
                Yr.Items.Add(year.ToString());
            }
            cmbProgram.Items.Add("Bachelor of Science in Computer Science");
            cmbProgram.Items.Add("Bachelor of Science in Information Technology");
            cmbProgram.Items.Add("Bachelor of Science in Information System");
            cmbProgram.Items.Add("Bachelor of Science in Computer Engineering");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
    }
    

