﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace School_Mangement
{
    public partial class Subject: Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AJ4R5V4;Initial Catalog=schooldb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select* from subtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AJ4R5V4;Initial Catalog=schooldb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into sutab values(@subjectid,@subjectname)", con);
            cnn.Parameters.AddWithValue("@SubjectId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@SubjectName", textBox2.Text);
            
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AJ4R5V4;Initial Catalog=schooldb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("update subtab set subjectname=@subjectname where subjectid=@subjectid)", con);
            cnn.Parameters.AddWithValue("@SubjectId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@SubjectName", textBox2.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AJ4R5V4;Initial Catalog=schooldb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete subtab where subjectid=@subjectid", con);
            cnn.Parameters.AddWithValue("@SubjectId", int.Parse(textBox1.Text));
            

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AJ4R5V4;Initial Catalog=schooldb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select* from subtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AJ4R5V4;Initial Catalog=schooldb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select* from subtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
