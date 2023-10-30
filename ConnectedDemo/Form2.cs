using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;
using System.Xml.Linq;

namespace ConnectedDemo
{
    public partial class Form2 : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder builder;
        DataSet ds;

        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string qry = "select *from Dep11";
                da = new SqlDataAdapter(qry, con);
                ds = new DataSet();
                da.Fill(ds, "Dep11");
                cmbdep.DataSource = ds.Tables["Dep11"];
                cmbdep.DisplayMember = "dname";
                cmbdep.ValueMember = "did";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private DataSet GetEmployees()
        {
            string qry = "select * from EMP01";
            // assign the query
            da = new SqlDataAdapter(qry, con);
            // when app load the in DataSet, we need to manage the PK also
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // SCB will track the DataSet & update quries to the DataAdapter
            builder = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "EMP01");// this name given to the DataSet table
            return ds;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                // create new row to add recrod
                DataRow row = ds.Tables["EMP01"].NewRow();
                // assign value to the row
                row["ename"] = txtname.Text;
                row["email"] = txtemail.Text;
                row["age"] = txtage.Text;
                row["sal"] = txtsal.Text;
                row["did"] = cmbdep.SelectedValue;
                // attach this row in DataSet table
                ds.Tables["EMP01"].Rows.Add(row);
                // update the changes from DataSet to DB
                int result = da.Update(ds.Tables["EMP01"]);
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetEmployees();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                // find the row
                DataRow row = ds.Tables["EMP01"].Rows.Find(txtid.Text);
                if (row != null)
                {
                    row["ename"] = txtname.Text;
                    row["email"] = txtemail.Text;
                    row["age"] = txtage.Text;
                    row["sal"] = txtsal.Text;
                    row["did"] = cmbdep.SelectedValue;
                    // update the changes from DataSet to DB
                    int result = da.Update(ds.Tables["EMP01"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record updated");
                    }
                }
                else
                {
                    MessageBox.Show("Id not matched");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetEmployees();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                // find the row
                DataRow row = ds.Tables["EMP01"].Rows.Find(txtid.Text);
                if (row != null)
                {
                    // delete the current row from DataSet table
                    row.Delete();
                    // update the changes from DataSet to DB
                    int result = da.Update(ds.Tables["EMP01"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Id not matched");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                dataGridView1.DataSource = ds.Tables["EMP01"];

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            GetEmployees();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select e.*, d.dname from EMP01 e inner join Dep11 d on d.did = e.did";
                da = new SqlDataAdapter(qry, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
                da.Fill(ds, "emp");
                //find method can only seach the data if PK is applied in the DataSet table
                DataRow row = ds.Tables["emp"].Rows.Find(txtid.Text);
                if (row != null)
                {
                    txtname.Text = row["ename"].ToString();
                    txtemail.Text = row["email"].ToString();
                    txtage.Text = row["age"].ToString();
                    txtsal.Text = row["sal"].ToString();
                    cmbdep.Text = row["dname"].ToString();
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
            GetEmployees();

        }
    }
}
