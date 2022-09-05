using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //to show subform form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            
        }


        

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LoginForm ls = new LoginForm();
            ls.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Categoryform cf = new Categoryform();
            cf.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Salesform sf = new Salesform();
            sf.Show();
            this.Hide();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
