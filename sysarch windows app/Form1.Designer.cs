namespace sysarch_windows_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridViewDepartments = new DataGridView();
            label1 = new Label();
            Add = new Button();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            Restore = new Button();
            Update = new Button();
            Delete = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            Refresh = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            checkBox2 = new CheckBox();
            button1 = new Button();
            comboBoxCollege = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDepartments
            // 
            dataGridViewDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDepartments.Location = new Point(50, 194);
            dataGridViewDepartments.Name = "dataGridViewDepartments";
            dataGridViewDepartments.Size = new Size(800, 257);
            dataGridViewDepartments.TabIndex = 0;
            dataGridViewDepartments.CellContentClick += dataGridViewDepartments_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(385, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 1;
            label1.Text = "Department";
            // 
            // Add
            // 
            Add.Location = new Point(149, 121);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 2;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(376, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(851, 54);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(42, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "No";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Restore
            // 
            Restore.Location = new Point(577, 120);
            Restore.Name = "Restore";
            Restore.Size = new Size(75, 23);
            Restore.TabIndex = 6;
            Restore.Text = "restore";
            Restore.UseVisualStyleBackColor = true;
            Restore.Click += Edit_Click;
            // 
            // Update
            // 
            Update.Location = new Point(257, 121);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 7;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(365, 121);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 8;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(231, 50);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 9;
            label2.Text = "Department name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(508, 52);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 10;
            label3.Text = "Department code:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(647, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(779, 52);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 12;
            label4.Text = "IsActive:";
            // 
            // Refresh
            // 
            Refresh.Location = new Point(468, 120);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(75, 23);
            Refresh.TabIndex = 13;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 50);
            label5.Name = "label5";
            label5.Size = new Size(115, 21);
            label5.TabIndex = 15;
            label5.Text = "Department ID:";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(50, 169);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(70, 19);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "Show all";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(379, 457);
            button1.Name = "button1";
            button1.Size = new Size(118, 34);
            button1.TabIndex = 17;
            button1.Text = "to college form";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxCollege
            // 
            comboBoxCollege.FormattingEnabled = true;
            comboBoxCollege.Location = new Point(724, 122);
            comboBoxCollege.Name = "comboBoxCollege";
            comboBoxCollege.Size = new Size(121, 23);
            comboBoxCollege.TabIndex = 18;
            comboBoxCollege.SelectedIndexChanged += comboBoxCollege_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(917, 518);
            Controls.Add(comboBoxCollege);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(Refresh);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Restore);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(Add);
            Controls.Add(label1);
            Controls.Add(dataGridViewDepartments);
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDepartments;
        private Label label1;
        private Button Add;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Button Restore;
        private Button Update;
        private Button Delete;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Button Refresh;
        private TextBox textBox3;
        private Label label5;
        private CheckBox checkBox2;
        private Button button1;
        private ComboBox comboBoxCollege;
    }
}
