namespace FastEvents
{
    partial class Signup
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
            label11 = new Label();
            roleBtn = new ComboBox();
            linkLabel2 = new LinkLabel();
            label10 = new Label();
            linkLabel1 = new LinkLabel();
            label9 = new Label();
            pass2 = new TextBox();
            label1 = new Label();
            number = new TextBox();
            label8 = new Label();
            Lname = new TextBox();
            label5 = new Label();
            Fname = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            pass = new TextBox();
            user = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(239, 234, 216);
            label11.Location = new Point(720, 192);
            label11.Name = "label11";
            label11.Size = new Size(0, 23);
            label11.TabIndex = 54;
            // 
            // roleBtn
            // 
            roleBtn.BackColor = Color.FromArgb(208, 201, 192);
            roleBtn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roleBtn.ForeColor = SystemColors.WindowFrame;
            roleBtn.FormattingEnabled = true;
            roleBtn.Items.AddRange(new object[] { "Participant", "Admin", "Managing Team" });
            roleBtn.Location = new Point(479, 143);
            roleBtn.Margin = new Padding(3, 4, 3, 4);
            roleBtn.Name = "roleBtn";
            roleBtn.Size = new Size(170, 25);
            roleBtn.TabIndex = 53;
            roleBtn.Text = "Sign up as";
            roleBtn.SelectedIndexChanged += roleBtn_SelectedIndexChanged;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(543, 575);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(60, 22);
            linkLabel2.TabIndex = 52;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Log In";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(239, 234, 216);
            label10.Location = new Point(327, 575);
            label10.Name = "label10";
            label10.Size = new Size(224, 22);
            label10.TabIndex = 51;
            label10.Text = "Already have an account? ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(527, 759);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 22);
            linkLabel1.TabIndex = 50;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log in";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(239, 234, 216);
            label9.Location = new Point(284, 759);
            label9.Name = "label9";
            label9.Size = new Size(224, 22);
            label9.TabIndex = 49;
            label9.Text = "Already have an account? ";
            // 
            // pass2
            // 
            pass2.BackColor = Color.FromArgb(208, 201, 192);
            pass2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pass2.ForeColor = SystemColors.WindowFrame;
            pass2.Location = new Point(447, 411);
            pass2.Margin = new Padding(3, 4, 3, 4);
            pass2.Name = "pass2";
            pass2.Size = new Size(202, 25);
            pass2.TabIndex = 48;
            pass2.Text = "Confirm Password ";
            pass2.TextAlign = HorizontalAlignment.Center;
            pass2.MouseClick += password2;
            pass2.TextChanged += pass2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(239, 234, 216);
            label1.Location = new Point(234, 414);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 47;
            label1.Text = "Confirm Password";
            // 
            // number
            // 
            number.BackColor = Color.FromArgb(208, 201, 192);
            number.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            number.ForeColor = SystemColors.WindowFrame;
            number.Location = new Point(447, 463);
            number.Margin = new Padding(3, 4, 3, 4);
            number.Name = "number";
            number.Size = new Size(202, 25);
            number.TabIndex = 46;
            number.Text = "Enter Phone Number";
            number.TextAlign = HorizontalAlignment.Center;
            number.MouseClick += phone;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(239, 234, 216);
            label8.Location = new Point(234, 466);
            label8.Name = "label8";
            label8.Size = new Size(134, 23);
            label8.TabIndex = 45;
            label8.Text = "Phone Number";
            // 
            // Lname
            // 
            Lname.BackColor = Color.FromArgb(208, 201, 192);
            Lname.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Lname.ForeColor = SystemColors.WindowFrame;
            Lname.Location = new Point(447, 247);
            Lname.Margin = new Padding(3, 4, 3, 4);
            Lname.Name = "Lname";
            Lname.Size = new Size(202, 25);
            Lname.TabIndex = 44;
            Lname.Text = "Enter Last Name";
            Lname.TextAlign = HorizontalAlignment.Center;
            Lname.MouseClick += lname;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(239, 234, 216);
            label5.Location = new Point(234, 250);
            label5.Name = "label5";
            label5.Size = new Size(102, 23);
            label5.TabIndex = 43;
            label5.Text = "Last Name";
            // 
            // Fname
            // 
            Fname.BackColor = Color.FromArgb(208, 201, 192);
            Fname.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Fname.ForeColor = SystemColors.WindowFrame;
            Fname.Location = new Point(447, 194);
            Fname.Margin = new Padding(3, 4, 3, 4);
            Fname.Name = "Fname";
            Fname.Size = new Size(202, 25);
            Fname.TabIndex = 42;
            Fname.Text = "Enter First Name";
            Fname.TextAlign = HorizontalAlignment.Center;
            Fname.MouseClick += fname_click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(239, 234, 216);
            label6.Location = new Point(390, 37);
            label6.Name = "label6";
            label6.Size = new Size(129, 37);
            label6.TabIndex = 1;
            label6.Text = "Sign Up";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(239, 234, 216);
            label7.Location = new Point(234, 195);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 41;
            label7.Text = "First Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(95, 113, 97);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 116);
            panel1.TabIndex = 40;
            // 
            // pass
            // 
            pass.BackColor = Color.FromArgb(208, 201, 192);
            pass.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pass.ForeColor = SystemColors.WindowFrame;
            pass.Location = new Point(447, 357);
            pass.Margin = new Padding(3, 4, 3, 4);
            pass.Name = "pass";
            pass.Size = new Size(202, 25);
            pass.TabIndex = 39;
            pass.Text = "Enter Password";
            pass.TextAlign = HorizontalAlignment.Center;
            pass.MouseClick += password1;
            // 
            // user
            // 
            user.BackColor = Color.FromArgb(208, 201, 192);
            user.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            user.ForeColor = SystemColors.WindowFrame;
            user.Location = new Point(447, 303);
            user.Margin = new Padding(3, 4, 3, 4);
            user.Name = "user";
            user.Size = new Size(202, 25);
            user.TabIndex = 38;
            user.Text = "Enter Username";
            user.TextAlign = HorizontalAlignment.Center;
            user.MouseClick += username;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(239, 234, 216);
            label4.Location = new Point(234, 359);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 37;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(239, 234, 216);
            label3.Location = new Point(234, 306);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 36;
            label3.Text = "Username";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(208, 201, 192);
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowFrame;
            button1.Location = new Point(489, 515);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 29);
            button1.TabIndex = 35;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(239, 234, 216);
            label2.Location = new Point(234, 143);
            label2.Name = "label2";
            label2.Size = new Size(238, 25);
            label2.TabIndex = 34;
            label2.Text = "Create a new account ";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(109, 139, 116);
            ClientSize = new Size(914, 628);
            Controls.Add(label11);
            Controls.Add(roleBtn);
            Controls.Add(linkLabel2);
            Controls.Add(label10);
            Controls.Add(linkLabel1);
            Controls.Add(label9);
            Controls.Add(pass2);
            Controls.Add(label1);
            Controls.Add(number);
            Controls.Add(label8);
            Controls.Add(Lname);
            Controls.Add(label5);
            Controls.Add(Fname);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(pass);
            Controls.Add(user);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "Signup";
            Text = "Signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private ComboBox roleBtn;
        private LinkLabel linkLabel2;
        private Label label10;
        private LinkLabel linkLabel1;
        private Label label9;
        private TextBox pass2;
        private Label label1;
        private TextBox number;
        private Label label8;
        private TextBox Lname;
        private Label label5;
        private TextBox Fname;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private TextBox pass;
        private TextBox user;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label2;
    }
}