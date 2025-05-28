namespace WindowsFormsAppProject
{
    partial class myprofile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametextb = new System.Windows.Forms.TextBox();
            this.zipcodetextb = new System.Windows.Forms.TextBox();
            this.tidtextb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statuscombob = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.usernameb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.updatechangesb = new System.Windows.Forms.Button();
            this.dobtextb = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TripID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(184, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Your Profile Traveler!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zip Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Traveler ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status:";
            // 
            // nametextb
            // 
            this.nametextb.Location = new System.Drawing.Point(272, 129);
            this.nametextb.Name = "nametextb";
            this.nametextb.Size = new System.Drawing.Size(100, 20);
            this.nametextb.TabIndex = 5;
            // 
            // zipcodetextb
            // 
            this.zipcodetextb.Location = new System.Drawing.Point(272, 155);
            this.zipcodetextb.Name = "zipcodetextb";
            this.zipcodetextb.Size = new System.Drawing.Size(100, 20);
            this.zipcodetextb.TabIndex = 6;
            // 
            // tidtextb
            // 
            this.tidtextb.Location = new System.Drawing.Point(272, 185);
            this.tidtextb.Name = "tidtextb";
            this.tidtextb.Size = new System.Drawing.Size(100, 20);
            this.tidtextb.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Prefered Trip Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(576, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // statuscombob
            // 
            this.statuscombob.FormattingEnabled = true;
            this.statuscombob.Location = new System.Drawing.Point(272, 215);
            this.statuscombob.Name = "statuscombob";
            this.statuscombob.Size = new System.Drawing.Size(121, 21);
            this.statuscombob.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(576, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 20;
            // 
            // usernameb
            // 
            this.usernameb.Location = new System.Drawing.Point(576, 183);
            this.usernameb.Name = "usernameb";
            this.usernameb.Size = new System.Drawing.Size(100, 20);
            this.usernameb.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Username:";
            // 
            // updatechangesb
            // 
            this.updatechangesb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.updatechangesb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.updatechangesb.Location = new System.Drawing.Point(375, 262);
            this.updatechangesb.Name = "updatechangesb";
            this.updatechangesb.Size = new System.Drawing.Size(154, 32);
            this.updatechangesb.TabIndex = 21;
            this.updatechangesb.Text = "Update Changes!";
            this.updatechangesb.UseVisualStyleBackColor = false;
            // 
            // dobtextb
            // 
            this.dobtextb.Location = new System.Drawing.Point(576, 129);
            this.dobtextb.Mask = "00/00/0000";
            this.dobtextb.Name = "dobtextb";
            this.dobtextb.Size = new System.Drawing.Size(100, 20);
            this.dobtextb.TabIndex = 23;
            this.dobtextb.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "DOB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(185, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Past Trips";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TripID,
            this.TripName,
            this.DepartureDate,
            this.ReturnDate,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(213, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // TripID
            // 
            this.TripID.Frozen = true;
            this.TripID.HeaderText = "TripID";
            this.TripID.Name = "TripID";
            // 
            // TripName
            // 
            this.TripName.Frozen = true;
            this.TripName.HeaderText = "TripName";
            this.TripName.Name = "TripName";
            // 
            // DepartureDate
            // 
            this.DepartureDate.Frozen = true;
            this.DepartureDate.HeaderText = "DepartureDate";
            this.DepartureDate.Name = "DepartureDate";
            // 
            // ReturnDate
            // 
            this.ReturnDate.Frozen = true;
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // myprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.back3;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dobtextb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.updatechangesb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.usernameb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.statuscombob);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tidtextb);
            this.Controls.Add(this.zipcodetextb);
            this.Controls.Add(this.nametextb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "myprofile";
            this.Size = new System.Drawing.Size(959, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametextb;
        private System.Windows.Forms.TextBox zipcodetextb;
        private System.Windows.Forms.TextBox tidtextb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox statuscombob;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox usernameb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button updatechangesb;
        private System.Windows.Forms.MaskedTextBox dobtextb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
