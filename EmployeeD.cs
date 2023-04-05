using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Xml.Linq;


namespace CoonectedDemo
{
    public partial class EmployeeD : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;
        public EmployeeD()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }
        private DataSet GetAllProducts()
        {
            da = new SqlDataAdapter("select * from Employee", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Employee");
            return ds;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = GetAllProducts();
                DataRow row = ds.Tables["Employee"].NewRow();
                row["Employee_Name"] = txtEmployeeName.Text;
                row["Employee_Salary"] = txtEmployeeSalary.Text;
                // add new row in the dataset table
                ds.Tables["Employee"].Rows.Add(row);
                int res = da.Update(ds.Tables["Employee"]);
                if (res >= 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = GetAllProducts();
                DataRow row = ds.Tables["Employee"].Rows.Find(txtEmployeeId.Text);
                if (row != null)
                {
                    txtEmployeeName.Text = row["Employee_Name"].ToString();
                    txtEmployeeSalary.Text = row["Employee_Salary"].ToString();
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = GetAllProducts();
                DataRow row = ds.Tables["Employee"].Rows.Find(txtEmployeeId.Text);
                if (row != null)
                {
                    row["Employee_Name"] = txtEmployeeName.Text;
                    row["Employee_Salary"] = txtEmployeeSalary.Text;
                    int res = da.Update(ds.Tables["Employee"]);
                    if (res >= 1)
                    {
                        MessageBox.Show("Record updated");
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = GetAllProducts();
                DataRow row = ds.Tables["Employee"].Rows.Find(txtEmployeeId.Text);
                if (row != null)
                {
                    row.Delete();
                    int res = da.Update(ds.Tables["Employee"]);
                    if (res >= 1)
                    {
                        MessageBox.Show("Record deleted");
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
        }

        private void btnShowAllProducts_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = GetAllProducts();
                dataGridView1.DataSource = ds.Tables["Employee"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
