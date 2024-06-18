using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            //33:01
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                loginForm loginForm = new loginForm();
                loginForm.Show();
                this.Hide();
            }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DashboardForm dForm = new DashboardForm();
            dForm.displayEnrolledStudentToday();
            dForm.displayTotalGS();
            dForm.displayTotalTT();
            dForm.displayTotalES();

            dashboardForm1.Visible = true;
            dashboardForm1.Update();
            addStudentsForm1.Visible = false;
            addTeachersForm1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addStudentsForm1.Visible = true;
            addStudentsForm1.Update();
            addTeachersForm1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addStudentsForm1.Visible = false;
            addTeachersForm1.Visible = true;
            addTeachersForm1.Update();
        }
    }
}
