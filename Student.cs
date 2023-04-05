using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoonectedDemo
{
    public partial class Student : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Student()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into Student values(@name,@percentage)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@percentage", Convert.ToInt32(txtStudentPercentage.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Student where Student_Rollno=@Student_Rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Student_Rollno", Convert.ToInt32(txtStudentRollno.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtStudentName.Text = dr["Student_Name"].ToString();
                        txtStudentPercentage.Text = dr["Student_Percentage"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update Student set Student_Name=@Student_Name,Student_Percentage=@Student_Percentage where Student_Rollno=@Student_Rollno";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Student_Name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@Student_Percentage", Convert.ToInt32(txtStudentPercentage.Text));
                cmd.Parameters.AddWithValue("@Student_Rollno", Convert.ToInt32(txtStudentRollno.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record updated..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete from Student where Student_Rollno=@Student_Rollno";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Student_Rollno", Convert.ToInt32(txtStudentRollno.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record deleted..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowAllProducts_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Student";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dr);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
