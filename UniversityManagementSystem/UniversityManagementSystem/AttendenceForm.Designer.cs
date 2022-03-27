namespace UniversityManagementSystem
{
    partial class AttendenceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendenceForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMarkAbsent = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CID_ComboBox2 = new System.Windows.Forms.ComboBox();
            this.Status_ComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.SID_TextBox = new System.Windows.Forms.TextBox();
            this.dtpCampusTime = new System.Windows.Forms.DateTimePicker();
            this.dgvAttendenceTaken = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBacktoMenu = new System.Windows.Forms.Button();
            this.CID_ComboBox = new System.Windows.Forms.ComboBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendenceTaken)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMarkAbsent);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.CID_ComboBox2);
            this.groupBox1.Controls.Add(this.Status_ComboBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Name_TextBox);
            this.groupBox1.Controls.Add(this.SID_TextBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(939, 227);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(381, 390);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mark Present/ Absent";
            // 
            // btnMarkAbsent
            // 
            this.btnMarkAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAbsent.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnMarkAbsent.ForeColor = System.Drawing.Color.White;
            this.btnMarkAbsent.Location = new System.Drawing.Point(46, 298);
            this.btnMarkAbsent.Name = "btnMarkAbsent";
            this.btnMarkAbsent.Size = new System.Drawing.Size(297, 67);
            this.btnMarkAbsent.TabIndex = 5;
            this.btnMarkAbsent.Text = "Mark Attendance";
            this.btnMarkAbsent.UseVisualStyleBackColor = true;
            this.btnMarkAbsent.Click += new System.EventHandler(this.btnMarkAbsent_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(349, 59);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(74, 235);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "Status:";
            // 
            // CID_ComboBox2
            // 
            this.CID_ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CID_ComboBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID_ComboBox2.FormattingEnabled = true;
            this.CID_ComboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CID_ComboBox2.Location = new System.Drawing.Point(150, 171);
            this.CID_ComboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.CID_ComboBox2.Name = "CID_ComboBox2";
            this.CID_ComboBox2.Size = new System.Drawing.Size(199, 28);
            this.CID_ComboBox2.TabIndex = 3;
            // 
            // Status_ComboBox
            // 
            this.Status_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_ComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_ComboBox.FormattingEnabled = true;
            this.Status_ComboBox.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "On Leave"});
            this.Status_ComboBox.Location = new System.Drawing.Point(153, 231);
            this.Status_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Status_ComboBox.Name = "Status_ComboBox";
            this.Status_ComboBox.Size = new System.Drawing.Size(196, 28);
            this.Status_ComboBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 176);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Class ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Student ID:";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_TextBox.Location = new System.Drawing.Point(153, 113);
            this.Name_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(196, 26);
            this.Name_TextBox.TabIndex = 2;
            // 
            // SID_TextBox
            // 
            this.SID_TextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SID_TextBox.Location = new System.Drawing.Point(153, 55);
            this.SID_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SID_TextBox.Name = "SID_TextBox";
            this.SID_TextBox.Size = new System.Drawing.Size(196, 26);
            this.SID_TextBox.TabIndex = 1;
            // 
            // dtpCampusTime
            // 
            this.dtpCampusTime.Enabled = false;
            this.dtpCampusTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCampusTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCampusTime.Location = new System.Drawing.Point(407, 275);
            this.dtpCampusTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCampusTime.Name = "dtpCampusTime";
            this.dtpCampusTime.ShowUpDown = true;
            this.dtpCampusTime.Size = new System.Drawing.Size(207, 30);
            this.dtpCampusTime.TabIndex = 44;
            this.dtpCampusTime.Value = new System.DateTime(2020, 1, 1, 8, 0, 0, 0);
            // 
            // dgvAttendenceTaken
            // 
            this.dgvAttendenceTaken.AllowUserToAddRows = false;
            this.dgvAttendenceTaken.AllowUserToDeleteRows = false;
            this.dgvAttendenceTaken.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendenceTaken.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAttendenceTaken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendenceTaken.Location = new System.Drawing.Point(75, 340);
            this.dgvAttendenceTaken.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAttendenceTaken.Name = "dgvAttendenceTaken";
            this.dgvAttendenceTaken.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendenceTaken.Size = new System.Drawing.Size(833, 364);
            this.dgvAttendenceTaken.TabIndex = 56;
            this.dgvAttendenceTaken.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAttendenceTaken_RowHeaderMouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(209, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 28);
            this.label8.TabIndex = 52;
            this.label8.Text = "Campus Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(282, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 46;
            this.label3.Text = "Class ID:";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(995, 635);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 49);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBacktoMenu
            // 
            this.btnBacktoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBacktoMenu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoMenu.ForeColor = System.Drawing.Color.White;
            this.btnBacktoMenu.Location = new System.Drawing.Point(1139, 635);
            this.btnBacktoMenu.Name = "btnBacktoMenu";
            this.btnBacktoMenu.Size = new System.Drawing.Size(128, 49);
            this.btnBacktoMenu.TabIndex = 10;
            this.btnBacktoMenu.Text = "Back";
            this.btnBacktoMenu.UseVisualStyleBackColor = true;
            this.btnBacktoMenu.Click += new System.EventHandler(this.btnBacktoMenu_Click);
            // 
            // CID_ComboBox
            // 
            this.CID_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CID_ComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID_ComboBox.FormattingEnabled = true;
            this.CID_ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CID_ComboBox.Location = new System.Drawing.Point(407, 228);
            this.CID_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CID_ComboBox.Name = "CID_ComboBox";
            this.CID_ComboBox.Size = new System.Drawing.Size(207, 28);
            this.CID_ComboBox.TabIndex = 8;
            // 
            // Search_Button
            // 
            this.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.ForeColor = System.Drawing.Color.White;
            this.Search_Button.Location = new System.Drawing.Point(656, 240);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(208, 66);
            this.Search_Button.TabIndex = 9;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::UniversityManagementSystem.Properties.Resources.logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(387, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 191);
            this.panel2.TabIndex = 254;
            // 
            // AttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1377, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.CID_ComboBox);
            this.Controls.Add(this.btnBacktoMenu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpCampusTime);
            this.Controls.Add(this.dgvAttendenceTaken);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttendenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denko | University Management System |  Attendence Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendenceTaken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Status_ComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox SID_TextBox;
        private System.Windows.Forms.ComboBox CID_ComboBox2;
        private System.Windows.Forms.DateTimePicker dtpCampusTime;
        private System.Windows.Forms.DataGridView dgvAttendenceTaken;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBacktoMenu;
        private System.Windows.Forms.Button btnMarkAbsent;
        private System.Windows.Forms.ComboBox CID_ComboBox;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Panel panel2;
    }
}