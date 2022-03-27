namespace UniversityManagementSystem
{
    partial class Student_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Picture_Label = new System.Windows.Forms.Label();
            this.Update_Student_Button = new System.Windows.Forms.Button();
            this.Display_Students_Button = new System.Windows.Forms.Button();
            this.Delete_Student_Button = new System.Windows.Forms.Button();
            this.Add_New_Student_Button = new System.Windows.Forms.Button();
            this.Gender_ComboBox = new System.Windows.Forms.ComboBox();
            this.Course_ComboBox = new System.Windows.Forms.ComboBox();
            this.Age_TextBox = new System.Windows.Forms.TextBox();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Gender_Label = new System.Windows.Forms.Label();
            this.SID_TextBox = new System.Windows.Forms.TextBox();
            this.SID_Label = new System.Windows.Forms.Label();
            this.SName_TextBox = new System.Windows.Forms.TextBox();
            this.S_Name_Label = new System.Windows.Forms.Label();
            this.Address_TextBox = new System.Windows.Forms.TextBox();
            this.Address_Label = new System.Windows.Forms.Label();
            this.Phone_TextBox = new System.Windows.Forms.TextBox();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.Course_Label = new System.Windows.Forms.Label();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.Email__Label = new System.Windows.Forms.Label();
            this.Student_Info_DataGridView = new System.Windows.Forms.DataGridView();
            this.Search_Students_TextBox = new System.Windows.Forms.TextBox();
            this.Search_Students_Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Info_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PictureBox);
            this.groupBox1.Controls.Add(this.Picture_Label);
            this.groupBox1.Controls.Add(this.Update_Student_Button);
            this.groupBox1.Controls.Add(this.Display_Students_Button);
            this.groupBox1.Controls.Add(this.Delete_Student_Button);
            this.groupBox1.Controls.Add(this.Add_New_Student_Button);
            this.groupBox1.Controls.Add(this.Gender_ComboBox);
            this.groupBox1.Controls.Add(this.Course_ComboBox);
            this.groupBox1.Controls.Add(this.Age_TextBox);
            this.groupBox1.Controls.Add(this.Age_Label);
            this.groupBox1.Controls.Add(this.Gender_Label);
            this.groupBox1.Controls.Add(this.SID_TextBox);
            this.groupBox1.Controls.Add(this.SID_Label);
            this.groupBox1.Controls.Add(this.SName_TextBox);
            this.groupBox1.Controls.Add(this.S_Name_Label);
            this.groupBox1.Controls.Add(this.Address_TextBox);
            this.groupBox1.Controls.Add(this.Address_Label);
            this.groupBox1.Controls.Add(this.Phone_TextBox);
            this.groupBox1.Controls.Add(this.Phone_Label);
            this.groupBox1.Controls.Add(this.Course_Label);
            this.groupBox1.Controls.Add(this.Email_TextBox);
            this.groupBox1.Controls.Add(this.Email__Label);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(712, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 727);
            this.groupBox1.TabIndex = 248;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox.Image = global::UniversityManagementSystem.Properties.Resources.No_Image_Available;
            this.PictureBox.Location = new System.Drawing.Point(196, 428);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(157, 148);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 297;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDoubleClick);
            // 
            // Picture_Label
            // 
            this.Picture_Label.AutoSize = true;
            this.Picture_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Picture_Label.ForeColor = System.Drawing.Color.White;
            this.Picture_Label.Location = new System.Drawing.Point(18, 435);
            this.Picture_Label.Name = "Picture_Label";
            this.Picture_Label.Size = new System.Drawing.Size(158, 23);
            this.Picture_Label.TabIndex = 296;
            this.Picture_Label.Text = "Upload Picture:";
            // 
            // Update_Student_Button
            // 
            this.Update_Student_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Student_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Update_Student_Button.ForeColor = System.Drawing.Color.White;
            this.Update_Student_Button.Location = new System.Drawing.Point(47, 655);
            this.Update_Student_Button.Name = "Update_Student_Button";
            this.Update_Student_Button.Size = new System.Drawing.Size(228, 54);
            this.Update_Student_Button.TabIndex = 12;
            this.Update_Student_Button.Text = "Update Student";
            this.Update_Student_Button.UseVisualStyleBackColor = true;
            this.Update_Student_Button.Click += new System.EventHandler(this.Update_Student_Button_Click_1);
            // 
            // Display_Students_Button
            // 
            this.Display_Students_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Display_Students_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Display_Students_Button.ForeColor = System.Drawing.Color.White;
            this.Display_Students_Button.Location = new System.Drawing.Point(286, 594);
            this.Display_Students_Button.Name = "Display_Students_Button";
            this.Display_Students_Button.Size = new System.Drawing.Size(228, 54);
            this.Display_Students_Button.TabIndex = 11;
            this.Display_Students_Button.Text = "Display Students";
            this.Display_Students_Button.UseVisualStyleBackColor = true;
            this.Display_Students_Button.Click += new System.EventHandler(this.Display_Students_Button_Click_1);
            // 
            // Delete_Student_Button
            // 
            this.Delete_Student_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Student_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Delete_Student_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Student_Button.Location = new System.Drawing.Point(286, 655);
            this.Delete_Student_Button.Name = "Delete_Student_Button";
            this.Delete_Student_Button.Size = new System.Drawing.Size(228, 54);
            this.Delete_Student_Button.TabIndex = 13;
            this.Delete_Student_Button.Text = "Delete Student";
            this.Delete_Student_Button.UseVisualStyleBackColor = true;
            this.Delete_Student_Button.Click += new System.EventHandler(this.Delete_Student_Button_Click_1);
            // 
            // Add_New_Student_Button
            // 
            this.Add_New_Student_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_New_Student_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Add_New_Student_Button.ForeColor = System.Drawing.Color.White;
            this.Add_New_Student_Button.Location = new System.Drawing.Point(47, 594);
            this.Add_New_Student_Button.Name = "Add_New_Student_Button";
            this.Add_New_Student_Button.Size = new System.Drawing.Size(228, 54);
            this.Add_New_Student_Button.TabIndex = 10;
            this.Add_New_Student_Button.Text = "Add New Student";
            this.Add_New_Student_Button.UseVisualStyleBackColor = true;
            this.Add_New_Student_Button.Click += new System.EventHandler(this.Add_New_Student_Button_Click_1);
            // 
            // Gender_ComboBox
            // 
            this.Gender_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_ComboBox.FormattingEnabled = true;
            this.Gender_ComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_ComboBox.Location = new System.Drawing.Point(196, 182);
            this.Gender_ComboBox.Name = "Gender_ComboBox";
            this.Gender_ComboBox.Size = new System.Drawing.Size(350, 35);
            this.Gender_ComboBox.TabIndex = 4;
            // 
            // Course_ComboBox
            // 
            this.Course_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Course_ComboBox.FormattingEnabled = true;
            this.Course_ComboBox.Items.AddRange(new object[] {
            "Avionics",
            "COCIS",
            "Mechatronics",
            "ERP"});
            this.Course_ComboBox.Location = new System.Drawing.Point(196, 233);
            this.Course_ComboBox.Name = "Course_ComboBox";
            this.Course_ComboBox.Size = new System.Drawing.Size(350, 35);
            this.Course_ComboBox.TabIndex = 5;
            // 
            // Age_TextBox
            // 
            this.Age_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_TextBox.Location = new System.Drawing.Point(196, 134);
            this.Age_TextBox.Name = "Age_TextBox";
            this.Age_TextBox.Size = new System.Drawing.Size(350, 32);
            this.Age_TextBox.TabIndex = 3;
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Age_Label.ForeColor = System.Drawing.Color.White;
            this.Age_Label.Location = new System.Drawing.Point(119, 141);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(57, 23);
            this.Age_Label.TabIndex = 289;
            this.Age_Label.Text = "Age:";
            // 
            // Gender_Label
            // 
            this.Gender_Label.AutoSize = true;
            this.Gender_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Gender_Label.ForeColor = System.Drawing.Color.White;
            this.Gender_Label.Location = new System.Drawing.Point(86, 190);
            this.Gender_Label.Name = "Gender_Label";
            this.Gender_Label.Size = new System.Drawing.Size(90, 23);
            this.Gender_Label.TabIndex = 287;
            this.Gender_Label.Text = "Gender:";
            // 
            // SID_TextBox
            // 
            this.SID_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SID_TextBox.Location = new System.Drawing.Point(196, 38);
            this.SID_TextBox.Name = "SID_TextBox";
            this.SID_TextBox.Size = new System.Drawing.Size(350, 32);
            this.SID_TextBox.TabIndex = 1;
            // 
            // SID_Label
            // 
            this.SID_Label.AutoSize = true;
            this.SID_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SID_Label.ForeColor = System.Drawing.Color.White;
            this.SID_Label.Location = new System.Drawing.Point(62, 43);
            this.SID_Label.Name = "SID_Label";
            this.SID_Label.Size = new System.Drawing.Size(114, 23);
            this.SID_Label.TabIndex = 285;
            this.SID_Label.Text = "Student ID:";
            // 
            // SName_TextBox
            // 
            this.SName_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SName_TextBox.Location = new System.Drawing.Point(196, 86);
            this.SName_TextBox.Name = "SName_TextBox";
            this.SName_TextBox.Size = new System.Drawing.Size(350, 32);
            this.SName_TextBox.TabIndex = 2;
            // 
            // S_Name_Label
            // 
            this.S_Name_Label.AutoSize = true;
            this.S_Name_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.S_Name_Label.ForeColor = System.Drawing.Color.White;
            this.S_Name_Label.Location = new System.Drawing.Point(22, 92);
            this.S_Name_Label.Name = "S_Name_Label";
            this.S_Name_Label.Size = new System.Drawing.Size(154, 23);
            this.S_Name_Label.TabIndex = 283;
            this.S_Name_Label.Text = "Student Name:";
            // 
            // Address_TextBox
            // 
            this.Address_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_TextBox.Location = new System.Drawing.Point(196, 332);
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.Size = new System.Drawing.Size(350, 32);
            this.Address_TextBox.TabIndex = 7;
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Address_Label.ForeColor = System.Drawing.Color.White;
            this.Address_Label.Location = new System.Drawing.Point(82, 337);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(94, 23);
            this.Address_Label.TabIndex = 281;
            this.Address_Label.Text = "Address:";
            // 
            // Phone_TextBox
            // 
            this.Phone_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_TextBox.Location = new System.Drawing.Point(196, 380);
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.Size = new System.Drawing.Size(350, 32);
            this.Phone_TextBox.TabIndex = 8;
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Phone_Label.ForeColor = System.Drawing.Color.White;
            this.Phone_Label.Location = new System.Drawing.Point(99, 386);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(77, 23);
            this.Phone_Label.TabIndex = 279;
            this.Phone_Label.Text = "Phone:";
            // 
            // Course_Label
            // 
            this.Course_Label.AutoSize = true;
            this.Course_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Course_Label.ForeColor = System.Drawing.Color.White;
            this.Course_Label.Location = new System.Drawing.Point(91, 239);
            this.Course_Label.Name = "Course_Label";
            this.Course_Label.Size = new System.Drawing.Size(85, 23);
            this.Course_Label.TabIndex = 277;
            this.Course_Label.Text = "Course:";
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_TextBox.Location = new System.Drawing.Point(196, 284);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(350, 32);
            this.Email_TextBox.TabIndex = 6;
            // 
            // Email__Label
            // 
            this.Email__Label.AutoSize = true;
            this.Email__Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Email__Label.ForeColor = System.Drawing.Color.White;
            this.Email__Label.Location = new System.Drawing.Point(108, 288);
            this.Email__Label.Name = "Email__Label";
            this.Email__Label.Size = new System.Drawing.Size(68, 23);
            this.Email__Label.TabIndex = 275;
            this.Email__Label.Text = "Email:";
            // 
            // Student_Info_DataGridView
            // 
            this.Student_Info_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Student_Info_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_Info_DataGridView.Location = new System.Drawing.Point(20, 294);
            this.Student_Info_DataGridView.Name = "Student_Info_DataGridView";
            this.Student_Info_DataGridView.RowTemplate.Height = 24;
            this.Student_Info_DataGridView.Size = new System.Drawing.Size(672, 456);
            this.Student_Info_DataGridView.TabIndex = 251;
            this.Student_Info_DataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Student_Info_DataGridView_RowHeaderMouseDoubleClick);
            // 
            // Search_Students_TextBox
            // 
            this.Search_Students_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Students_TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Search_Students_TextBox.Location = new System.Drawing.Point(364, 229);
            this.Search_Students_TextBox.Name = "Search_Students_TextBox";
            this.Search_Students_TextBox.Size = new System.Drawing.Size(263, 32);
            this.Search_Students_TextBox.TabIndex = 16;
            this.Search_Students_TextBox.TextChanged += new System.EventHandler(this.Search_Students_TextBox_TextChanged);
            // 
            // Search_Students_Label
            // 
            this.Search_Students_Label.AutoSize = true;
            this.Search_Students_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Search_Students_Label.ForeColor = System.Drawing.Color.White;
            this.Search_Students_Label.Location = new System.Drawing.Point(115, 234);
            this.Search_Students_Label.Name = "Search_Students_Label";
            this.Search_Students_Label.Size = new System.Drawing.Size(227, 23);
            this.Search_Students_Label.TabIndex = 250;
            this.Search_Students_Label.Text = "Search Student Name:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::UniversityManagementSystem.Properties.Resources.logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(20, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 167);
            this.panel2.TabIndex = 252;
            // 
            // Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1294, 781);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Student_Info_DataGridView);
            this.Controls.Add(this.Search_Students_TextBox);
            this.Controls.Add(this.Search_Students_Label);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denko | University Management System |  Students | Create, Read, Update & Delete";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Info_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Student_Info_DataGridView;
        private System.Windows.Forms.TextBox Search_Students_TextBox;
        private System.Windows.Forms.Label Search_Students_Label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Update_Student_Button;
        private System.Windows.Forms.Button Display_Students_Button;
        private System.Windows.Forms.Button Delete_Student_Button;
        private System.Windows.Forms.Button Add_New_Student_Button;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label Picture_Label;
        private System.Windows.Forms.ComboBox Gender_ComboBox;
        private System.Windows.Forms.ComboBox Course_ComboBox;
        private System.Windows.Forms.TextBox Age_TextBox;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.Label Gender_Label;
        private System.Windows.Forms.TextBox SID_TextBox;
        private System.Windows.Forms.Label SID_Label;
        private System.Windows.Forms.TextBox SName_TextBox;
        private System.Windows.Forms.Label S_Name_Label;
        private System.Windows.Forms.TextBox Address_TextBox;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.TextBox Phone_TextBox;
        private System.Windows.Forms.Label Phone_Label;
        private System.Windows.Forms.Label Course_Label;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Label Email__Label;
    }
}