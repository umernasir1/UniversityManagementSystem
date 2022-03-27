namespace UniversityManagementSystem
{
    partial class Course_Info_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course_Info_Form));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Course_Info_DataGridView = new System.Windows.Forms.DataGridView();
            this.Check_Button = new System.Windows.Forms.Button();
            this.Course_ComboBox = new System.Windows.Forms.ComboBox();
            this.Course_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Course_Info_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::UniversityManagementSystem.Properties.Resources.logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 188);
            this.panel2.TabIndex = 254;
            // 
            // Course_Info_DataGridView
            // 
            this.Course_Info_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Course_Info_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Course_Info_DataGridView.Location = new System.Drawing.Point(13, 275);
            this.Course_Info_DataGridView.Name = "Course_Info_DataGridView";
            this.Course_Info_DataGridView.RowTemplate.Height = 24;
            this.Course_Info_DataGridView.Size = new System.Drawing.Size(895, 431);
            this.Course_Info_DataGridView.TabIndex = 295;
            // 
            // Check_Button
            // 
            this.Check_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Check_Button.ForeColor = System.Drawing.Color.White;
            this.Check_Button.Location = new System.Drawing.Point(656, 215);
            this.Check_Button.Name = "Check_Button";
            this.Check_Button.Size = new System.Drawing.Size(156, 45);
            this.Check_Button.TabIndex = 2;
            this.Check_Button.Text = "Check";
            this.Check_Button.UseVisualStyleBackColor = true;
            this.Check_Button.Click += new System.EventHandler(this.Check_Button_Click);
            // 
            // Course_ComboBox
            // 
            this.Course_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Course_ComboBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Course_ComboBox.FormattingEnabled = true;
            this.Course_ComboBox.Items.AddRange(new object[] {
            "Avionics",
            "COCIS",
            "Mechatronics",
            "ERP"});
            this.Course_ComboBox.Location = new System.Drawing.Point(279, 220);
            this.Course_ComboBox.Name = "Course_ComboBox";
            this.Course_ComboBox.Size = new System.Drawing.Size(350, 35);
            this.Course_ComboBox.TabIndex = 1;
            // 
            // Course_Label
            // 
            this.Course_Label.AutoSize = true;
            this.Course_Label.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Course_Label.ForeColor = System.Drawing.Color.White;
            this.Course_Label.Location = new System.Drawing.Point(110, 223);
            this.Course_Label.Name = "Course_Label";
            this.Course_Label.Size = new System.Drawing.Size(151, 28);
            this.Course_Label.TabIndex = 297;
            this.Course_Label.Text = "Course Info:";
            // 
            // Course_Info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(920, 718);
            this.Controls.Add(this.Check_Button);
            this.Controls.Add(this.Course_ComboBox);
            this.Controls.Add(this.Course_Label);
            this.Controls.Add(this.Course_Info_DataGridView);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Course_Info_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denko | University Management System |  Course Info";
            ((System.ComponentModel.ISupportInitialize)(this.Course_Info_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Course_Info_DataGridView;
        private System.Windows.Forms.Button Check_Button;
        private System.Windows.Forms.ComboBox Course_ComboBox;
        private System.Windows.Forms.Label Course_Label;
    }
}