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
    public partial class Category : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HotelMMS;Integrated Security=True");
        public Category()
        {
            InitializeComponent();
            DisplayRec();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Room_id.Text) || string.IsNullOrWhiteSpace(Room_Name.Text) || string.IsNullOrWhiteSpace(Room_Discription.Text))
            {
                MessageBox.Show("Missing Information......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Insert into  Category (Room_id, Room_Name, Room_Discription) Values (@Room_id, @Room_Name, @Room_Discription)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Room_id", Room_id.Text);
                    cmd.Parameters.AddWithValue("@Room_Name", Room_Name.Text);
                    cmd.Parameters.AddWithValue("@Room_Discription", Room_Discription.Text);
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
            string query = "Select * from Category";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Room_id.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Room_Name.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Room_Discription.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Room_id.Text) || string.IsNullOrWhiteSpace(Room_Name.Text) || string.IsNullOrWhiteSpace(Room_Discription.Text))
            {
                MessageBox.Show("Missing Information......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update Category  set Room_Name=@Room_Name, Room_Discription=@Room_Discription where Room_id=@Room_id ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Room_Name", Room_Name.Text);
                    cmd.Parameters.AddWithValue("@Room_Discription", Room_Discription.Text);
                    cmd.Parameters.AddWithValue("@Room_id", Room_id.Text);
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
            if (string.IsNullOrWhiteSpace(Room_id.Text))
            {
                MessageBox.Show("Fill the Information........");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Category WHERE Room_id = @Room_id"; // Corrected parameter name
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Room_id", Room_id.Text); // Use the correct parameter name here
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Category Items....");
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 85, 100, 85);
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
