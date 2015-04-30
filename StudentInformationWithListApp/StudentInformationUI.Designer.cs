namespace StudentInformationWithListApp
{
    partial class StudentInformationUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.clearStudentInformationButton = new System.Windows.Forms.Button();
            this.showStudentInformationButton = new System.Windows.Forms.Button();
            this.saveStudentInformationButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(this.regNoTextBox);
            this.groupBox1.Controls.Add(this.clearStudentInformationButton);
            this.groupBox1.Controls.Add(this.showStudentInformationButton);
            this.groupBox1.Controls.Add(this.saveStudentInformationButton);
            this.groupBox1.Location = new System.Drawing.Point(36, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student  Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reg No";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(148, 149);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(337, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(148, 89);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(337, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(148, 39);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(337, 20);
            this.regNoTextBox.TabIndex = 3;
            // 
            // clearStudentInformationButton
            // 
            this.clearStudentInformationButton.Location = new System.Drawing.Point(390, 216);
            this.clearStudentInformationButton.Name = "clearStudentInformationButton";
            this.clearStudentInformationButton.Size = new System.Drawing.Size(75, 23);
            this.clearStudentInformationButton.TabIndex = 2;
            this.clearStudentInformationButton.Text = "Clear All";
            this.clearStudentInformationButton.UseVisualStyleBackColor = true;
            this.clearStudentInformationButton.Click += new System.EventHandler(this.clearStudentInformationButton_Click);
            // 
            // showStudentInformationButton
            // 
            this.showStudentInformationButton.Location = new System.Drawing.Point(252, 216);
            this.showStudentInformationButton.Name = "showStudentInformationButton";
            this.showStudentInformationButton.Size = new System.Drawing.Size(75, 23);
            this.showStudentInformationButton.TabIndex = 1;
            this.showStudentInformationButton.Text = "Show All";
            this.showStudentInformationButton.UseVisualStyleBackColor = true;
            this.showStudentInformationButton.Click += new System.EventHandler(this.showStudentInformationButton_Click);
            // 
            // saveStudentInformationButton
            // 
            this.saveStudentInformationButton.Location = new System.Drawing.Point(131, 216);
            this.saveStudentInformationButton.Name = "saveStudentInformationButton";
            this.saveStudentInformationButton.Size = new System.Drawing.Size(75, 23);
            this.saveStudentInformationButton.TabIndex = 0;
            this.saveStudentInformationButton.Text = "Save";
            this.saveStudentInformationButton.UseVisualStyleBackColor = true;
            this.saveStudentInformationButton.Click += new System.EventHandler(this.saveStudentInformationButton_Click);
            // 
            // StudentInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 325);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentInformationUI";
            this.Text = "Student Information UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.Button clearStudentInformationButton;
        private System.Windows.Forms.Button showStudentInformationButton;
        private System.Windows.Forms.Button saveStudentInformationButton;
    }
}

