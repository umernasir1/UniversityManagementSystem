namespace UniversityManagementSystem
{
    partial class Teacher_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Form));
            this.Teacher_Info_DataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Display_Button = new System.Windows.Forms.Button();
            this.Delete_Teacher_Button = new System.Windows.Forms.Button();
            this.Update_Teacher_Button = new System.Windows.Forms.Button();
            this.Add_Teacher_Button = new System.Windows.Forms.Button();
            this.Gender_ComboBox = new System.Windows.Forms.ComboBox();
            this.Course_Teacher_ComboBox = new System.Windows.Forms.ComboBox();
            this.Age_TextBox = new System.Windows.Forms.TextBox();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Gender_Label = new System.Windows.Forms.Label();
            this.TID_TextBox = new System.Windows.Forms.TextBox();
            this.TID_Label = new System.Windows.Forms.Label();
            this.TName_TextBox = new System.Windows.Forms.TextBox();
            this.S_Name_Label = new System.Windows.Forms.Label();
            this.Course_Label = new System.Windows.Forms.Label();
            this.Salary_TextBox = new System.Windows.Forms.TextBox();
            this.Salary_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Info_DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Teacher_Info_DataGridView
            // 
            this.Teacher_Info_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Teacher_Info_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Teacher_Info_DataGridView.Location = new System.Drawing.Point(640, 209);
            this.Teacher_Info_DataGridView.Name = "Teacher_Info_DataGridView";
            this.Teacher_Info_DataGridView.RowTemplate.Height = 24;
            this.Teacher_Info_DataGridView.Size = new System.Drawing.Size(631, 500);
            this.Teacher_Info_DataGridView.TabIndex = 261;
            this.Teacher_Info_DataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Teacher_Info_DataGridView_RowHeaderMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Display_Button);
            this.groupBox1.Controls.Add(this.Delete_Teacher_Button);
            this.groupBox1.Controls.Add(this.Update_Teacher_Button);
            this.groupBox1.Controls.Add(this.Add_Teacher_Button);
            this.groupBox1.Controls.Add(this.Gender_ComboBox);
            this.groupBox1.Controls.Add(this.Course_Teacher_ComboBox);
            this.groupBox1.Controls.Add(this.Age_TextBox);
            this.groupBox1.Controls.Add(this.Age_Label);
            this.groupBox1.Controls.Add(this.Gender_Label);
            this.groupBox1.Controls.Add(this.TID_TextBox);
            this.groupBox1.Controls.Add(this.TID_Label);
            this.groupBox1.Controls.Add(this.TName_TextBox);
            this.groupBox1.Controls.Add(this.S_Name_Label);
            this.groupBox1.Controls.Add(this.Course_Label);
            this.groupBox1.Controls.Add(this.Salary_TextBox);
            this.groupBox1.Controls.Add(this.Salary_Label);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 532);
            this.groupBox1.TabIndex = 262;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teacher | Add | Update | Delete";
            // 
            // Display_Button
            // 
            this.Display_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Display_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Display_Button.ForeColor = System.Drawing.Color.White;
            this.Display_Button.Location = new System.Drawing.Point(107, 444);
            this.Display_Button.Name = "Display_Button";
            this.Display_Button.Size = new System.Drawing.Size(186, 66);
            this.Display_Button.TabIndex = 312;
            this.Display_Button.Text = "Display";
            this.Display_Button.UseVisualStyleBackColor = true;
            this.Display_Button.Click += new System.EventHandler(this.Display_Button_Click);
            // 
            // Delete_Teacher_Button
            // 
            this.Delete_Teacher_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Teacher_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Delete_Teacher_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Teacher_Button.Location = new System.Drawing.Point(303, 444);
            this.Delete_Teacher_Button.Name = "Delete_Teacher_Button";
            this.Delete_Teacher_Button.Size = new System.Drawing.Size(186, 66);
            this.Delete_Teacher_Button.TabIndex = 313;
            this.Delete_Teacher_Button.Text = "Delete";
            this.Delete_Teacher_Button.UseVisualStyleBackColor = true;
            this.Delete_Teacher_Button.Click += new System.EventHandler(this.Delete_Teacher_Button_Click);
            // 
            // Update_Teacher_Button
            // 
            this.Update_Teacher_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Teacher_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Update_Teacher_Button.ForeColor = System.Drawing.Color.White;
            this.Update_Teacher_Button.Location = new System.Drawing.Point(304, 372);
            this.Update_Teacher_Button.Name = "Update_Teacher_Button";
            this.Update_Teacher_Button.Size = new System.Drawing.Size(186, 66);
            this.Update_Teacher_Button.TabIndex = 11;
            this.Update_Teacher_Button.Text = "Update Info";
            this.Update_Teacher_Button.UseVisualStyleBackColor = true;
            this.Update_Teacher_Button.Click += new System.EventHandler(this.Update_Teacher_Button_Click);
            // 
            // Add_Teacher_Button
            // 
            this.Add_Teacher_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Teacher_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Add_Teacher_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Teacher_Button.Location = new System.Drawing.Point(107, 372);
            this.Add_Teacher_Button.Name = "Add_Teacher_Button";
            this.Add_Teacher_Button.Size = new System.Drawing.Size(186, 66);
            this.Add_Teacher_Button.TabIndex = 10;
            this.Add_Teacher_Button.Text = "Add Teacher";
            this.Add_Teacher_Button.UseVisualStyleBackColor = true;
            this.Add_Teacher_Button.Click += new System.EventHandler(this.Add_Teacher_Button_Click);
            // 
            // Gender_ComboBox
            // 
            this.Gender_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_ComboBox.FormattingEnabled = true;
            this.Gender_ComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_ComboBox.Location = new System.Drawing.Point(218, 205);
            this.Gender_ComboBox.Name = "Gender_ComboBox";
            this.Gender_ComboBox.Size = new System.Drawing.Size(350, 35);
            this.Gender_ComboBox.TabIndex = 4;
            // 
            // Course_Teacher_ComboBox
            // 
            this.Course_Teacher_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Course_Teacher_ComboBox.FormattingEnabled = true;
            this.Course_Teacher_ComboBox.Items.AddRange(new object[] {
            "Avionics",
            "COCIS",
            "Mechatronics",
            "ERP"});
            this.Course_Teacher_ComboBox.Location = new System.Drawing.Point(218, 258);
            this.Course_Teacher_ComboBox.Name = "Course_Teacher_ComboBox";
            this.Course_Teacher_ComboBox.Size = new System.Drawing.Size(350, 35);
            this.Course_Teacher_ComboBox.TabIndex = 5;
            // 
            // Age_TextBox
            // 
            this.Age_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_TextBox.Location = new System.Drawing.Point(218, 155);
            this.Age_TextBox.Name = "Age_TextBox";
            this.Age_TextBox.Size = new System.Drawing.Size(350, 32);
            this.Age_TextBox.TabIndex = 3;
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Age_Label.ForeColor = System.Drawing.Color.White;
            this.Age_Label.Location = new System.Drawing.Point(141, 162);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(57, 23);
            this.Age_Label.TabIndex = 306;
            this.Age_Label.Text = "Age:";
            // 
            // Gender_Label
            // 
            this.Gender_Label.AutoSize = true;
            this.Gender_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Gender_Label.ForeColor = System.Drawing.Color.White;
            this.Gender_Label.Location = new System.Drawing.Point(108, 213);
            this.Gender_Label.Name = "Gender_Label";
            this.Gender_Label.Size = new System.Drawing.Size(90, 23);
            this.Gender_Label.TabIndex = 304;
            this.Gender_Label.Text = "Gender:";
            // 
            // TID_TextBox
            // 
            this.TID_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID_TextBox.Location = new System.Drawing.Point(218, 55);
            this.TID_TextBox.Name = "TID_TextBox";
            this.TID_TextBox.Size = new System.Drawing.Size(350, 32);
            this.TID_TextBox.TabIndex = 1;
            // 
            // TID_Label
            // 
            this.TID_Label.AutoSize = true;
            this.TID_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.TID_Label.ForeColor = System.Drawing.Color.White;
            this.TID_Label.Location = new System.Drawing.Point(78, 60);
            this.TID_Label.Name = "TID_Label";
            this.TID_Label.Size = new System.Drawing.Size(120, 23);
            this.TID_Label.TabIndex = 303;
            this.TID_Label.Text = "Teacher ID:";
            // 
            // TName_TextBox
            // 
            this.TName_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TName_TextBox.Location = new System.Drawing.Point(218, 105);
            this.TName_TextBox.Name = "TName_TextBox";
            this.TName_TextBox.Size = new System.Drawing.Size(350, 32);
            this.TName_TextBox.TabIndex = 2;
            // 
            // S_Name_Label
            // 
            this.S_Name_Label.AutoSize = true;
            this.S_Name_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.S_Name_Label.ForeColor = System.Drawing.Color.White;
            this.S_Name_Label.Location = new System.Drawing.Point(38, 111);
            this.S_Name_Label.Name = "S_Name_Label";
            this.S_Name_Label.Size = new System.Drawing.Size(160, 23);
            this.S_Name_Label.TabIndex = 301;
            this.S_Name_Label.Text = "Teacher Name:";
            // 
            // Course_Label
            // 
            this.Course_Label.AutoSize = true;
            this.Course_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Course_Label.ForeColor = System.Drawing.Color.White;
            this.Course_Label.Location = new System.Drawing.Point(29, 264);
            this.Course_Label.Name = "Course_Label";
            this.Course_Label.Size = new System.Drawing.Size(169, 23);
            this.Course_Label.TabIndex = 299;
            this.Course_Label.Text = "Course Teacher:";
            // 
            // Salary_TextBox
            // 
            this.Salary_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_TextBox.Location = new System.Drawing.Point(218, 311);
            this.Salary_TextBox.Name = "Salary_TextBox";
            this.Salary_TextBox.Size = new System.Drawing.Size(350, 32);
            this.Salary_TextBox.TabIndex = 7;
            // 
            // Salary_Label
            // 
            this.Salary_Label.AutoSize = true;
            this.Salary_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Salary_Label.ForeColor = System.Drawing.Color.White;
            this.Salary_Label.Location = new System.Drawing.Point(129, 315);
            this.Salary_Label.Name = "Salary_Label";
            this.Salary_Label.Size = new System.Drawing.Size(69, 23);
            this.Salary_Label.TabIndex = 298;
            this.Salary_Label.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(246, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 96);
            this.label6.TabIndex = 341;
            this.label6.Text = "{";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(135, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 340;
            this.label5.Text = "CLASS ID\'s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(320, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 338;
            this.label3.Text = "4 - ERP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(320, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 23);
            this.label4.TabIndex = 339;
            this.label4.Text = "3 - Mechatronics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 337;
            this.label1.Text = "1 - Avionics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(320, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 336;
            this.label2.Text = "2 - COCIS";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::UniversityManagementSystem.Properties.Resources.logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(640, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 168);
            this.panel2.TabIndex = 342;
            // 
            // Teacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1294, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Teacher_Info_DataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Teacher_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denko | University Management System |  Teacher | Create, Read, Update & Delete";
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Info_DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Teacher_Info_DataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Gender_ComboBox;
        private System.Windows.Forms.ComboBox Course_Teacher_ComboBox;
        private System.Windows.Forms.TextBox Age_TextBox;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.Label Gender_Label;
        private System.Windows.Forms.TextBox TID_TextBox;
        private System.Windows.Forms.Label TID_Label;
        private System.Windows.Forms.TextBox TName_TextBox;
        private System.Windows.Forms.Label S_Name_Label;
        private System.Windows.Forms.Label Course_Label;
        private System.Windows.Forms.TextBox Salary_TextBox;
        private System.Windows.Forms.Label Salary_Label;
        private System.Windows.Forms.Button Delete_Teacher_Button;
        private System.Windows.Forms.Button Update_Teacher_Button;
        private System.Windows.Forms.Button Add_Teacher_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Display_Button;
    }
}