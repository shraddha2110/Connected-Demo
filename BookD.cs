using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace CoonectedDemo
{
    public partial class BookD : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;
        public BookD()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }
        private DataSet GetAllProducts()
        {
            da = new SqlDataAdapter("select * from Book", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Book");
            return ds;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = GetAllProducts();
                DataRow row = ds.Tables["Book"].NewRow();
                row["name"] = txtName.Text;
                row["author"] = txtAuthor.Text;
                row["price"] = txtPrice.Text;
                // add new row in the dataset table
                ds.Tables["Book"].Rows.Add(row);
                int res = da.Update(ds.Tables["Book"]);
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
                DataRow row = ds.Tables["Book"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    txtName.Text = row["name"].ToString();
                    txtAuthor.Text = row["author"].ToString();
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
                DataRow row = ds.Tables["Book"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row["name"] = txtName.Text;
                    row["author"] = txtAuthor.Text;
                    row["price"] = txtPrice.Text;
                    int res = da.Update(ds.Tables["Book"]);
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
                DataRow row = ds.Tables["Book"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row.Delete();
                    int res = da.Update(ds.Tables["Book"]);
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
                dataGridView1.DataSource = ds.Tables["Book"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
