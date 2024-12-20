namespace CRUD_WindowForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TextEmail = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(207, 34);
            button1.Name = "button1";
            button1.Size = new Size(169, 43);
            button1.TabIndex = 0;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(67, 34);
            button2.Name = "button2";
            button2.Size = new Size(110, 43);
            button2.TabIndex = 1;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(405, 34);
            button3.Name = "button3";
            button3.Size = new Size(130, 43);
            button3.TabIndex = 2;
            button3.Text = "Read";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI", 12F);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(710, 34);
            button4.Name = "button4";
            button4.Size = new Size(105, 43);
            button4.TabIndex = 3;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 0, 192);
            button5.Font = new Font("Segoe UI", 12F);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(560, 34);
            button5.Name = "button5";
            button5.Size = new Size(121, 43);
            button5.TabIndex = 4;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(124, 156);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 5;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(124, 210);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 6;
            label2.Text = "Nom";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(124, 265);
            label3.Name = "label3";
            label3.Size = new Size(97, 32);
            label3.TabIndex = 7;
            label3.Text = "Prenom";
            // 
            // TextEmail
            // 
            TextEmail.AutoSize = true;
            TextEmail.Font = new Font("Segoe UI", 12F);
            TextEmail.Location = new Point(124, 319);
            TextEmail.Name = "TextEmail";
            TextEmail.Size = new Size(71, 32);
            TextEmail.TabIndex = 8;
            TextEmail.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(124, 368);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 9;
            label5.Text = "Password";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F);
            numericUpDown1.Location = new Point(369, 150);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(258, 39);
            numericUpDown1.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(369, 204);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 39);
            txtName.TabIndex = 11;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(369, 313);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(258, 39);
            txtEmail.TabIndex = 12;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F);
            txtUser.Location = new Point(367, 259);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(260, 39);
            txtUser.TabIndex = 13;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12F);
            txtPass.Location = new Point(369, 365);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(258, 39);
            txtPass.TabIndex = 14;
            txtPass.UseSystemPasswordChar = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(167, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(622, 249);
            dataGridView1.TabIndex = 15;
            //dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 518);
            Controls.Add(dataGridView1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(TextEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label TextEmail;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtUser;
        private TextBox txtPass;
        private DataGridView dataGridView1;
    }
}
