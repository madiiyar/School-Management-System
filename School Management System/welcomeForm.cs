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
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 18;
            if (panel2.Width >= 635)
            {
                timer1.Stop();

                loginForm loginForm = new loginForm();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
