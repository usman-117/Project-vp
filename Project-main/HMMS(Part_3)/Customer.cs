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
    public partial class Customer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HotelMagnment;Integrated Security=True");
        public Customer()
        {
            InitializeComponent();
            DisplayRec();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Customer_id.Text) || string.IsNullOrWhiteSpace(Customer_Name.Text) || string.IsNullOrWhiteSpace(Customer_Email.Text) || string.IsNullOrWhiteSpace(Customer_Password.Text) || string.IsNullOrWhiteSpace(Customer_Contact.Text))
            {
                MessageBox.Show("Missing Information......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Insert into  custo (Customer_id, Customer_Name, Customer_Email, Customer_Password, Customer_Contact) Values (@Customer_id, @Customer_Name, @Customer_Email, @Customer_Password, @Customer_Contact)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Customer_id", Customer_id.Text);
                    cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name.Text);
                    cmd.Parameters.AddWithValue("@Customer_Email", Customer_Email.Text);
                    cmd.Parameters.AddWithValue("@Customer_Password", Customer_Password.Text);
                    cmd.Parameters.AddWithValue("@Customer_Contact", Customer_Contact.Text);
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
            Booking booking = new Booking();
            booking.Show();
            this.Hide();
        }
        private void DisplayRec()
        {
            con.Open();
            string query = "Select * from custo";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer_id.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            Customer_Name.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            Customer_Email.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            Customer_Password.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            Customer_Contact.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
