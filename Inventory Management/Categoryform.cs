﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class Categoryform : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Eric Jiejorm Akpalu\OneDrive - University of Ghana\Documents\dbMS.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Categoryform()
        {
            InitializeComponent();
            LoadCategory();

        }

        public void LoadCategory()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCategory", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }
        

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {

            }
        }
    }
}