using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMMS_Part_3_
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HotelMMS;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_show_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_show.Checked)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Select Role Enter Username And Password");
            }
            else
            {
                if (SelCb.SelectedItem.ToString() == "ADMIN")
                {

                    if (conn.State != ConnectionState.Open)
                    {

                        try
                        {
                            conn.Open();
                            string query = "Select * From Signup Where Username = @Username And Password = @Password";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Username", Username.Text);
                                cmd.Parameters.AddWithValue("@Password", Password.Text);
                                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                                DataTable ta = new DataTable();
                                sda.Fill(ta);
                                if (ta.Rows.Count >= 1)
                                {
                                    Homepage homepage = new Homepage();
                                    homepage.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Error /Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error to Connection Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                else if (SelCb.SelectedItem.ToString() == "CUSTOMER")
                {
                    if (conn.State != ConnectionState.Open)
                    {

                        try
                        {
                            conn.Open();
                            string query = "Select * From Signup Where Username = @Username And Password = @Password";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Username", Username.Text);
                                cmd.Parameters.AddWithValue("@Password", Password.Text);
                                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                                DataTable ta = new DataTable();
                                sda.Fill(ta);
                                if (ta.Rows.Count >= 1)
                                {
                                    Customer customer = new Customer();
                                    customer.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Error /Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error to Connection Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }

            }
        }

        private void Login_register_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
    }
}
