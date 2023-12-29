namespace HMMS_Part_3_
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SellerDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Customer_Password = new System.Windows.Forms.TextBox();
            this.Customer_Contact = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Customer_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Prod_Quant = new System.Windows.Forms.Label();
            this.Customer_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Customer_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 569);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumBlue;
            this.button6.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(18, 477);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 37);
            this.button6.TabIndex = 14;
            this.button6.Text = "Back to";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(35, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 100);
            this.panel4.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(462, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 69);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MediumBlue;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(985, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.SellerDGV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Customer_Password);
            this.panel1.Controls.Add(this.Customer_Contact);
            this.panel1.Controls.Add(this.Customer_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Prod_Quant);
            this.panel1.Controls.Add(this.Customer_Email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Customer_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(173, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 457);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SellerDGV
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.SellerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.SellerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellerDGV.BackgroundColor = System.Drawing.Color.White;
            this.SellerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.SellerDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellerDGV.DefaultCellStyle = dataGridViewCellStyle18;
            this.SellerDGV.EnableHeadersVisualStyles = false;
            this.SellerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.SellerDGV.Location = new System.Drawing.Point(16, 191);
            this.SellerDGV.Name = "SellerDGV";
            this.SellerDGV.RowHeadersVisible = false;
            this.SellerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellerDGV.Size = new System.Drawing.Size(802, 197);
            this.SellerDGV.TabIndex = 25;
            this.SellerDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.SellerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SellerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SellerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellerDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.SellerDGV.ThemeStyle.ReadOnly = false;
            this.SellerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.SellerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SellerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.SellerDGV.ThemeStyle.RowsStyle.Height = 22;
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Contact";
            // 
            // Customer_Password
            // 
            this.Customer_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Password.Location = new System.Drawing.Point(552, 78);
            this.Customer_Password.Multiline = true;
            this.Customer_Password.Name = "Customer_Password";
            this.Customer_Password.Size = new System.Drawing.Size(209, 31);
            this.Customer_Password.TabIndex = 23;
            // 
            // Customer_Contact
            // 
            this.Customer_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Contact.Location = new System.Drawing.Point(168, 125);
            this.Customer_Contact.Multiline = true;
            this.Customer_Contact.Name = "Customer_Contact";
            this.Customer_Contact.Size = new System.Drawing.Size(205, 32);
            this.Customer_Contact.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumBlue;
            this.button4.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(306, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 60);
            this.button4.TabIndex = 11;
            this.button4.Text = "Start Booking";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Customer_id
            // 
            this.Customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_id.Location = new System.Drawing.Point(168, 32);
            this.Customer_id.Multiline = true;
            this.Customer_id.Name = "Customer_id";
            this.Customer_id.Size = new System.Drawing.Size(205, 32);
            this.Customer_id.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(428, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // Prod_Quant
            // 
            this.Prod_Quant.AutoSize = true;
            this.Prod_Quant.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_Quant.ForeColor = System.Drawing.Color.White;
            this.Prod_Quant.Location = new System.Drawing.Point(32, 86);
            this.Prod_Quant.Name = "Prod_Quant";
            this.Prod_Quant.Size = new System.Drawing.Size(61, 23);
            this.Prod_Quant.TabIndex = 6;
            this.Prod_Quant.Text = "Email";
            // 
            // Customer_Email
            // 
            this.Customer_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Email.Location = new System.Drawing.Point(168, 78);
            this.Customer_Email.Multiline = true;
            this.Customer_Email.Name = "Customer_Email";
            this.Customer_Email.Size = new System.Drawing.Size(205, 32);
            this.Customer_Email.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(428, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // Customer_Name
            // 
            this.Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Name.Location = new System.Drawing.Point(552, 32);
            this.Customer_Name.Multiline = true;
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(209, 32);
            this.Customer_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Id";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView SellerDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Customer_Password;
        private System.Windows.Forms.TextBox Customer_Contact;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Customer_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Prod_Quant;
        private System.Windows.Forms.TextBox Customer_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Customer_Name;
        private System.Windows.Forms.Label label2;
    }
}