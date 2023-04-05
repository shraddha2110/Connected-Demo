
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CoonectedDemo
{
    public partial class ProductD : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;


        public ProductD()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }
        private DataSet GetAllProducts()
        {
            da = new SqlDataAdapter("select * from Product", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "product");
            return ds;

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = GetAllProducts();
                DataRow row = ds.Tables["product"].NewRow();
                row["name"] = txtName.Text;
                row["comp"] = txtCompany.Text;
                row["price"] = txtPrice.Text;
                // add new row in the dataset table
                ds.Tables["product"].Rows.Add(row);
                int res = da.Update(ds.Tables["product"]);
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
                DataRow row = ds.Tables["product"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    txtName.Text = row["name"].ToString();
                    txtCompany.Text = row["comp"].ToString();
                    txtPrice.Text = row["price"].ToString();
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
                DataRow row = ds.Tables["product"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row["name"] = txtName.Text;
                    row["comp"] = txtCompany.Text;
                    row["price"] = txtPrice.Text;
                    int res = da.Update(ds.Tables["product"]);
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
                DataRow row = ds.Tables["product"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row.Delete();
                    int res = da.Update(ds.Tables["product"]);
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
                dataGridView1.DataSource = ds.Tables["product"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
