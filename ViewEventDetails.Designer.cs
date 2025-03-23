namespace FastEvents
{
    partial class ViewEventDetails
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            show_button = new Button();
            label2 = new Label();
            exit_button = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(95, 113, 97);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 108);
            panel1.TabIndex = 85;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(239, 234, 216);
            label6.Location = new Point(315, 36);
            label6.Name = "label6";
            label6.Size = new Size(205, 37);
            label6.TabIndex = 1;
            label6.Text = "Event Details";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(109, 139, 116);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(109, 139, 116);
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(208, 201, 192);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(239, 234, 216);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(208, 201, 192);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(109, 139, 116);
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(208, 201, 192);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(239, 234, 216);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(109, 139, 116);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView2.GridColor = Color.FromArgb(109, 139, 116);
            dataGridView2.Location = new Point(64, 179);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(109, 139, 116);
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(208, 201, 192);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(239, 234, 216);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(109, 139, 116);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(683, 172);
            dataGridView2.TabIndex = 88;
            // 
            // show_button
            // 
            show_button.BackColor = Color.FromArgb(208, 201, 192);
            show_button.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            show_button.ForeColor = SystemColors.WindowFrame;
            show_button.Location = new Point(346, 128);
            show_button.Name = "show_button";
            show_button.Size = new Size(140, 25);
            show_button.TabIndex = 87;
            show_button.Text = "Browse";
            show_button.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(239, 234, 216);
            label2.Location = new Point(64, 125);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 86;
            // 
            // exit_button
            // 
            exit_button.BackColor = Color.FromArgb(208, 201, 192);
            exit_button.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            exit_button.ForeColor = SystemColors.WindowFrame;
            exit_button.Location = new Point(315, 420);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(202, 41);
            exit_button.TabIndex = 89;
            exit_button.Text = "Proceed back";
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += exit_button_Click;
            // 
            // ViewEventDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(109, 139, 116);
            ClientSize = new Size(801, 524);
            Controls.Add(exit_button);
            Controls.Add(panel1);
            Controls.Add(dataGridView2);
            Controls.Add(show_button);
            Controls.Add(label2);
            Name = "ViewEventDetails";
            Text = "ViewEventDetails";
            Load += ViewEventDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private DataGridView dataGridView2;
        private Button show_button;
        private Label label2;
        private Button exit_button;
    }
}