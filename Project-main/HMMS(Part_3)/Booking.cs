using Guna.UI.Animation;
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
    public partial class Booking : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HotelMMS;Integrated Security=True");
        public Booking()
        {
            InitializeComponent();
            pop();
            popBill();
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
            Bill_Date.Text = DateTime.Now.ToString() + "/" + DateTime.Today.Month.ToString();
            //Sellernamee.Text = Form1.Seller_Name;
        }
        int flag = 0;
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Room_Cost.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Room_Status.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            flag = 1;
        }
        private void pop()
        {
            try
            {
                con.Open();
                string query = "Select  Room_Cost, Room_Status from Rom";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                var ds = new DataSet();
                DataTable dataTable = new DataTable();
                sda.Fill(ds);
                gunaDataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int gradetotal;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Room_Type.Text == "" || Days.Text == "" || Room_Cost.Text == "" || Room_Status.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int price = Convert.ToInt32(Room_Cost.Text);
                int quantity = Convert.ToInt32(Days.Text);
                int totalPrice = price * quantity;
                Guna.UI.WinForms.GunaDataGridView data = OrderGDV;
                int rowIndex = data.Rows.Add(); // Adding a new row directly and getting its index
                DataGridViewRow row = data.Rows[rowIndex];

                row.Cells[0].Value = rowIndex + 1; // Sets the value in the first cell to the incremented index for display
                row.Cells[1].Value = Room_Type.Text; // Sets the value in the second cell to the text from Room_Type control
                row.Cells[2].Value = quantity.ToString(); // Sets the value in the third cell to the string representation of quantity (displaying price?)
                row.Cells[3].Value = price.ToString(); // Sets the value in the fourth cell to the string representation of price (displaying quantity? // Sets the value in the fifth cell to the text from Room_Status control
                row.Cells[4].Value = totalPrice;
               // row.Cells[5].Value = Room_Status.Text;// Sets the value in the sixth cell to totalPrice variable
                                                      // Assigning the calculated total for this product

                if (!OrderGDV.Rows.Contains(row))
                {
                    // Add the row to the DataGridView
                    OrderGDV.Rows.Add(row);
                }

                gradetotal = gradetotal + totalPrice; // Add the current product's total to the overall accumulated total
                Amount.Text = "Rs: " + gradetotal; // Update the label with the accumulated total  
            }
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            pop();
            fillcombo();
            popBill();
        }
        private void fillcombo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HotelMMS;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Room_Type FROM Rom", con);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    if (dt.Rows.Count > 0)
                    {
                        Cat_Cb.DisplayMember = "Room_Type"; // Set DisplayMember if needed
                        Cat_Cb.ValueMember = "Room_Type";
                        Cat_Cb.DataSource = dt;
                    }
                    else
                    {
                        // Handle case when there are no rooms
                        MessageBox.Show("No rooms found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                            string query = "SELECT Room_Type, Room_Status  FROM Rom WHERE Cat_Cb = @selectedValue";

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
        private void button4_Click(object sender, EventArgs e)
        {

            if (Bill_id.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Bil (Bill_id, Customer_Name, Room_Status, Amount, Bill_Date) VALUES (@Bill_id, @Customer_Name, @Room_Status, @Amount, @Bill_Date)";

                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@Bill_id", Bill_id.Text);
                    com.Parameters.AddWithValue("@Customer_Name", Sellernamee.Text);
                    com.Parameters.AddWithValue("@Room_Status", Room_Status.Text);
                    // Convert the text to an integer before assigning it to the parameter
                    int totalAmount = 0;
                    if (int.TryParse(Amount.Text.Replace("Rs: ", ""), out totalAmount))
                    {
                        com.Parameters.AddWithValue("@Amount", totalAmount);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Amount"); // Notify the user if conversion fails
                    }
                    com.Parameters.AddWithValue("@Bill_Date", Bill_Date.Text);
                    com.ExecuteNonQuery();
                    con.Close();
                    popBill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void popBill()
        {
            try
            {
                con.Open();
                string query = "Select * from Bil";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                var ds = new DataSet();
                DataTable dataTable = new DataTable();
                sda.Fill(ds);
                gunaDataGridView2.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pop();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FIVE STAR HOTEL SYSTEM", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.DarkRed, new Point(230));
            e.Graphics.DrawString("Bill_ID: " + gunaDataGridView2.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 70));
            e.Graphics.DrawString("Customer_Name: " + gunaDataGridView2.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 100));
            e.Graphics.DrawString("Room_Status: " + gunaDataGridView2.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 130));
            e.Graphics.DrawString("Amount: " + gunaDataGridView2.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 160));
            e.Graphics.DrawString("Bill_Date: " + gunaDataGridView2.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 190));
            e.Graphics.DrawString("Code Space", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.DarkRed, new Point(270, 230));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
