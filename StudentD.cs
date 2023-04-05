using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Xml.Linq;

namespace CoonectedDemo
{
    public partial class StudentD : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;
        public StudentD()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }
        private DataSet GetAllProducts()
        {
            da = new SqlDataAdapter("select * from Student", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Student");
            return ds;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = GetAllProducts();
                DataRow row = ds.Tables["Student"].NewRow();
                row["Student_Name"] = txtStudentName.Text;
                row["Student_Percentage"] = txtStudentPercentage.Text;
                // add new row in the dataset table
                ds.Tables["Student"].Rows.Add(row);
                int res = da.Update(ds.Tables["Student"]);
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
                DataRow row = ds.Tables["Student"].Rows.Find(txtStudentRollno.Text);
                if (row != null)
                {
                    txtStudentName.Text = row["Student_Name"].ToString();
                    txtStudentPercentage.Text = row["Student_Percentage"].ToString();
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
                DataRow row = ds.Tables["Student"].Rows.Find(txtStudentRollno.Text);
                if (row != null)
                {
                    row["Student_Name"] = txtStudentName.Text;
                    row["Student_Percentage"] = txtStudentPercentage.Text;
                    int res = da.Update(ds.Tables["Student"]);
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
                DataRow row = ds.Tables["Student"].Rows.Find(txtStudentRollno.Text);
                if (row != null)
                {
                    row.Delete();
                    int res = da.Update(ds.Tables["Student"]);
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
                dataGridView1.DataSource = ds.Tables["Student"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
