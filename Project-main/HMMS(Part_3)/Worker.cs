using Guna.UI.WinForms;
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
    public partial class Worker : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HotelMMS;Integrated Security=True");
        public Worker()
        {
            InitializeComponent();
            DisplayRec();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Worker_id.Text) || string.IsNullOrWhiteSpace(Worker_Name.Text) || string.IsNullOrWhiteSpace(Worker_Email.Text) || string.IsNullOrWhiteSpace(Worker_Password.Text) || string.IsNullOrWhiteSpace(Worker_Contact.Text))
            {
                MessageBox.Show("Missing Information......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Insert into  Worker (Worker_id, Worker_Name, Worker_Email, Worker_Password, Worker_Contact) Values (@Worker_id, @Worker_Name, @Worker_Email, @Worker_Password, @Worker_Contact)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Worker_id", Worker_id.Text);
                    cmd.Parameters.AddWithValue("@Worker_Name", Worker_Name.Text);
                    cmd.Parameters.AddWithValue("@Worker_Email", Worker_Email.Text);
                    cmd.Parameters.AddWithValue("@Worker_Password", Worker_Password.Text);
                    cmd.Parameters.AddWithValue("@Worker_Contact", Worker_Contact.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information Add Sucessfully..........");
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DisplayRec()
        {
            con.Open();
            string query = "Select * from Worker";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Worker_id.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            Worker_Name.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            Worker_Email.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            Worker_Password.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            Worker_Contact.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Worker_id.Text) || string.IsNullOrWhiteSpace(Worker_Name.Text) || string.IsNullOrWhiteSpace(Worker_Email.Text) || string.IsNullOrWhiteSpace(Worker_Password.Text) || string.IsNullOrWhiteSpace(Worker_Contact.Text))
            {
                MessageBox.Show("Missing Information......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update Worker set Worker_Name=@Worker_Name, Worker_Email=@Worker_Email, Worker_Password=@Worker_Password, Worker_Contact=@Worker_Contact where Worker_id=@Worker_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Worker_Name", Worker_Name.Text);
                    cmd.Parameters.AddWithValue("@Worker_Email", Worker_Email.Text);
                    cmd.Parameters.AddWithValue("@Worker_Password", Worker_Password.Text);
                    cmd.Parameters.AddWithValue("@Worker_Contact", Worker_Contact.Text);
                    cmd.Parameters.AddWithValue("@Worker_id", Worker_id.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information Update Sucessfully..........");
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Worker_id.Text))
            {
                MessageBox.Show("Fill the Information........");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Worker WHERE Worker_id = @Worker_id"; // Corrected parameter name
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Worker_id", Worker_id.Text); // Use the correct parameter name here
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Worker Data....");
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }
    }
}
