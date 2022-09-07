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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            openChildForm(new LoginForm());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new Categoryform());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            openChildForm(new Salesform());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            openChildForm(new Productsforms());
        }
    }
}
