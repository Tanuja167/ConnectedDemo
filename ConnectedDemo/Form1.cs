using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Xml.Linq;
using System.Data;

namespace ConnectedDemo
{
    public partial class Form1 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Dep11> list = new List<Dep11>();
                string qry = "select * from Dep11";
                cmd = new SqlCommand(qry, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)

                {
                    while (reader.Read())
                    {
                        Dep11 dept = new Dep11();
                        dept.Did = Convert.ToInt32(reader["did"]);
                        dept.Name = reader["dname"].ToString();
                        list.Add(dept);
                    }
                }
                cmbdep.DataSource = list;
                cmbdep.DisplayMember = "Name";
                cmbdep.ValueMember = "Did";
            }
           

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            GetAllEmps();


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into EMP01 values(@Name,@Age,@Email,@Salary,@Did)";
                cmd = new SqlCommand(qry, con);
                // assign value to each parameter
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtage.Text));
                cmd.Parameters.AddWithValue("@Salary", Convert.ToInt32(txtsal.Text));
                cmd.Parameters.AddWithValue("@Did", Convert.ToInt32(cmbdep.SelectedValue));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
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
            GetAllEmps();
            Clear();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            try
            {
                string qry = "select e.*, d.dname from EMP01 e inner join Dep11 d on d.did = e.did where e.id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        txtname.Text = reader["ename"].ToString();
                        txtemail.Text = reader["email"].ToString();
                        txtage.Text = reader["age"].ToString();
                        txtsal.Text = reader["sal"].ToString();
                        cmbdep.Text = reader["dname"].ToString();
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
            GetAllEmps();


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update EMP01 set ename=@Name,email=@email,age=@age,sal=@salary,did=@did where id=@id";
                cmd = new SqlCommand(qry, con);
                // assign value to each parameter
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtage.Text));
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(txtsal.Text));
                cmd.Parameters.AddWithValue("@did", Convert.ToInt32(cmbdep.SelectedValue));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record updated");
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
            GetAllEmps();
            Clear();


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from EMP01 where id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record deleted");
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
            GetAllEmps();
            Clear();
        }


        private void GetAllEmps()
        {
            string qry = "select e.*, d.dname from EMP01 e inner join Dep11 d on d.did = e.did";
            cmd = new SqlCommand(qry, con);
            con.Open();
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void Clear()
        {
            txtid.Clear();
            txtname.Clear();
            txtemail.Clear();
            txtage.Clear();
            txtsal.Clear();
            cmbdep.ResetText();
          
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {

        }
    }
}

