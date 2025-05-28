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
            this.nametextb = new System.Windows.Forms.TextBox();
            this.zipcodetextb = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PreferenceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BudgetRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.YourPreferenceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // nametextb
            // 
            this.nametextb.Location = new System.Drawing.Point(272, 129);
            this.nametextb.Name = "nametextb";
            this.nametextb.Size = new System.Drawing.Size(100, 20);
            this.nametextb.TabIndex = 5;
            this.nametextb.TextChanged += new System.EventHandler(this.nametextb_TextChanged);
            // 
            // zipcodetextb
            // 
            this.zipcodetextb.Location = new System.Drawing.Point(272, 155);
            this.zipcodetextb.Name = "zipcodetextb";
            this.zipcodetextb.Size = new System.Drawing.Size(100, 20);
            this.zipcodetextb.TabIndex = 6;
            this.zipcodetextb.TextChanged += new System.EventHandler(this.zipcodetextb_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(576, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password:";
            // 
            // updatechangesb
            // 
            this.updatechangesb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.updatechangesb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.updatechangesb.Location = new System.Drawing.Point(357, 181);
            this.updatechangesb.Name = "updatechangesb";
            this.updatechangesb.Size = new System.Drawing.Size(154, 32);
            this.updatechangesb.TabIndex = 21;
            this.updatechangesb.Text = "Update Changes!";
            this.updatechangesb.UseVisualStyleBackColor = false;
            this.updatechangesb.Click += new System.EventHandler(this.updatechangesb_Click);
            // 
            // dobtextb
            // 
            this.dobtextb.Location = new System.Drawing.Point(576, 129);
            this.dobtextb.Mask = "00/00/0000";
            this.dobtextb.Name = "dobtextb";
            this.dobtextb.Size = new System.Drawing.Size(100, 20);
            this.dobtextb.TabIndex = 23;
            this.dobtextb.ValidatingType = typeof(System.DateTime);
            this.dobtextb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dobtextb_MaskInputRejected);
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
            this.label7.Location = new System.Drawing.Point(409, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Past Trips";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TripID,
            this.TripName,
            this.DepartureDate,
            this.ReturnDate,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(175, 401);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 139);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TripID
            // 
            this.TripID.Frozen = true;
            this.TripID.HeaderText = "TripID";
            this.TripID.Name = "TripID";
            this.TripID.ReadOnly = true;
            // 
            // TripName
            // 
            this.TripName.Frozen = true;
            this.TripName.HeaderText = "BookingID";
            this.TripName.Name = "TripName";
            this.TripName.ReadOnly = true;
            // 
            // DepartureDate
            // 
            this.DepartureDate.Frozen = true;
            this.DepartureDate.HeaderText = "DepartureDate";
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Frozen = true;
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(362, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Select Preferences";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PreferenceID,
            this.BudgetRange});
            this.dataGridView2.Location = new System.Drawing.Point(93, 245);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 121);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // PreferenceID
            // 
            this.PreferenceID.HeaderText = "PreferenceID";
            this.PreferenceID.Name = "PreferenceID";
            // 
            // BudgetRange
            // 
            this.BudgetRange.HeaderText = "BudgetRange";
            this.BudgetRange.Name = "BudgetRange";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.YourPreferenceID,
            this.Budget});
            this.dataGridView3.Location = new System.Drawing.Point(529, 245);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 121);
            this.dataGridView3.TabIndex = 28;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // YourPreferenceID
            // 
            this.YourPreferenceID.HeaderText = "YourPreferenceID";
            this.YourPreferenceID.Name = "YourPreferenceID";
            // 
            // Budget
            // 
            this.Budget.HeaderText = "Budget";
            this.Budget.Name = "Budget";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(357, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 32);
            this.button1.TabIndex = 29;
            this.button1.Text = "Add Preference!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.back3;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dobtextb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.updatechangesb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.zipcodetextb);
            this.Controls.Add(this.nametextb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "myprofile";
            this.Size = new System.Drawing.Size(959, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametextb;
        private System.Windows.Forms.TextBox zipcodetextb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button updatechangesb;
        private System.Windows.Forms.MaskedTextBox dobtextb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreferenceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BudgetRange;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn YourPreferenceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Budget;
        private System.Windows.Forms.Button button1;
    }
}
