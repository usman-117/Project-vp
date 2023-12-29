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
    public partial class Room : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HotelMMS;Integrated Security=True");
        public Room()
        {
            InitializeComponent();
            pop();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category worker = new Category();
            worker.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Room_id.Text) || string.IsNullOrWhiteSpace(Room_Type.Text) || string.IsNullOrWhiteSpace(Room_Status.Text) || string.IsNullOrWhiteSpace(Room_Cost.Text) || string.IsNullOrWhiteSpace(Cat_Cb.SelectedValue.ToString()))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "Insert into  Rom(Room_id, Room_Type ,Room_Status, Room_Cost, Cat_Cb) Values (@Room_id, @Room_Type ,@Room_Status, @Room_Cost, @Cat_Cb)";
                    SqlCommand com = new SqlCommand(query, conn);
                    com.Parameters.AddWithValue("@Room_id", Room_id.Text);
                    com.Parameters.AddWithValue("@Room_Type", Room_Type.Text);
                    com.Parameters.AddWithValue("@Room_Status", Room_Status.Text);
                    com.Parameters.AddWithValue("@Room_Cost", Room_Cost.Text);
                    com.Parameters.AddWithValue("@Cat_Cb", Cat_Cb.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Infromation Add Sucessfully......");
                    conn.Close();
                    pop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void pop()
        {
            try
            {
                conn.Open();
                string query = "Select * from Rom";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                var ds = new DataSet();
                DataTable dataTable = new DataTable();
                sda.Fill(ds);
                gunaDataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void fillcombo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HotelMMS;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Room_Name FROM Category", conn);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Room_Name", typeof(string));
                    dt.Load(rdr);

                    Cat_Cb.ValueMember = "Room_Name";
                    Cat_Cb.DisplayMember = "Room_Name"; // Set DisplayMember if needed
                    Cat_Cb.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (you can log it, display an error message, etc.)
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Room_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Room_id.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Room_Type.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Room_Status.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Room_Cost.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Cat_Cb.SelectedValue = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Room_id.Text) || string.IsNullOrWhiteSpace(Room_Type.Text) || string.IsNullOrWhiteSpace(Room_Status.Text) || string.IsNullOrWhiteSpace(Room_Cost.Text) || string.IsNullOrWhiteSpace(Cat_Cb.SelectedValue.ToString()))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "Update Rom set  Room_Type=@Room_Type,Room_Status=@Room_Status, Room_Cost=@Room_Cost, Cat_Cb=@Cat_Cb where  Room_id=@Room_id";
                    SqlCommand com = new SqlCommand(query, conn);
                    com.Parameters.AddWithValue("@Room_Type", Room_Type.Text);
                    com.Parameters.AddWithValue("@Room_Status", Room_Status.Text);
                    com.Parameters.AddWithValue("@Room_Cost", Room_Cost.Text);
                    com.Parameters.AddWithValue("@Cat_Cb", Cat_Cb.Text);
                    com.Parameters.AddWithValue("@Room_id", Room_id.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Infromation Update Sucessfully......");
                    conn.Close();
                    pop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Room_id.Text == "")
            {
                MessageBox.Show("Fill the Information........");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Rom WHERE Room_id = @Room_id"; // Corrected parameter name
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Room_id", Room_id); // Use the correct parameter name here
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Delete Room....");
                    pop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cat_Cb.SelectedItem != null)
            {
                if (Cat_Cb.SelectedValue != null)
                {
                    string selectedValue = Cat_Cb.SelectedValue.ToString();

                    if (!string.IsNullOrEmpty(selectedValue))
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=SMMSPro;Integrated Security=True"))
                        {
                            conn.Open();
                            string query = "SELECT * FROM Rom WHERE Cat_Cb = @selectedValue";

                            // Use SqlCommand and SqlParameter to create a parameterized query
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@selectedValue", selectedValue);

                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            var ds = new DataSet();
                            sda.Fill(ds);

                            gunaDataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                    else
                    {
                        // Handle the case where SelectedValue is empty or null
                    }
                }
                else
                {
                    // Handle the case where SelectedValue itself is null
                }
            }
            else
            {
                // Handle the case where SelectedItem is null
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }
    }
}
