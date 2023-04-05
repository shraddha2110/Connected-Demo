using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CoonectedDemo
{
    public partial class Employee : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Employee()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into Employee values(@Employee_Name,@Employee_Salary)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Employee_Name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@Employee_Salary", Convert.ToInt32(txtEmployeeSalary.Text));
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
                string qry = "select * from Employee where Employee_Id=@Employee_Id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Employee_Id", Convert.ToInt32(txtEmployeeId.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtEmployeeName.Text = dr["Employee_Name"].ToString();
                        txtEmployeeSalary.Text = dr["Employee_Salary"].ToString();
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
                string query = "update Employee set Employee_Name=@Employee_Name,Employee_Salary=@Employee_Salary where Employee_Id=@Employee_Id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Employee_Name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@Employee_Salary", Convert.ToInt32(txtEmployeeSalary.Text));
                cmd.Parameters.AddWithValue("@Employee_Id", Convert.ToInt32(txtEmployeeId.Text));
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
                string query = "delete from Employee where Employee_Id=@Employee_Id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Employee_Id", Convert.ToInt32(txtEmployeeId.Text));
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
                string qry = "select * from Employee";
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
