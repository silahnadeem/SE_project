namespace FastEvents
{
    partial class PurchaseTickets
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
            signup_button = new Button();
            button8 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            label11 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // signup_button
            // 
            signup_button.BackColor = Color.FromArgb(208, 201, 192);
            signup_button.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            signup_button.Location = new Point(104, 343);
            signup_button.Margin = new Padding(3, 4, 3, 4);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(202, 57);
            signup_button.TabIndex = 155;
            signup_button.Text = "Purchase Ticket";
            signup_button.UseVisualStyleBackColor = false;
            signup_button.Click += signup_button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(208, 201, 192);
            button8.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(118, 465);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(168, 37);
            button8.TabIndex = 150;
            button8.Text = "Back to Menu";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(208, 201, 192);
            textBox4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.WindowFrame;
            textBox4.Location = new Point(104, 246);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(202, 36);
            textBox4.TabIndex = 149;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(239, 234, 216);
            label4.Location = new Point(104, 207);
            label4.Name = "label4";
            label4.Size = new Size(203, 35);
            label4.TabIndex = 148;
            label4.Text = "Enter Ticket id";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(239, 234, 216);
            label11.Location = new Point(463, 151);
            label11.Name = "label11";
            label11.Size = new Size(0, 23);
            label11.TabIndex = 147;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(208, 201, 192);
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(446, 45);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(168, 35);
            button2.TabIndex = 146;
            button2.Text = "View Events";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(95, 113, 97);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(446, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(778, 561);
            dataGridView1.TabIndex = 145;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.DataPropertyName = "ticketid";
            Column1.HeaderText = "TicketId";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.DataPropertyName = "title";
            Column2.HeaderText = "Titile";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 71;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.DataPropertyName = "description";
            Column3.HeaderText = "Description";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 114;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.DataPropertyName = "date";
            Column4.HeaderText = "Date";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 70;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.DataPropertyName = "time";
            Column5.HeaderText = "Time";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 71;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.DataPropertyName = "location";
            Column6.HeaderText = "Location";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 95;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.DataPropertyName = "categoryid";
            Column7.HeaderText = "CategoryId";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 111;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.DataPropertyName = "categoryname";
            Column8.HeaderText = "CategoryName";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 138;
            // 
            // PurchaseTickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(109, 139, 116);
            ClientSize = new Size(1305, 692);
            Controls.Add(signup_button);
            Controls.Add(button8);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Name = "PurchaseTickets";
            Text = "PurchaseTickets";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signup_button;
        private Button button8;
        private TextBox textBox4;
        private Label label4;
        private Label label11;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}