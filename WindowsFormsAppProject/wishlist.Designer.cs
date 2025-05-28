namespace WindowsFormsAppProject
{
    partial class wishlist
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeb = new System.Windows.Forms.Button();
            this.notifyb = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(354, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Your WishList Traveler!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.TripID,
            this.CategoryID,
            this.DepartureDate,
            this.Price,
            this.DateAdded});
            this.dataGridView1.Location = new System.Drawing.Point(176, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(637, 126);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // TripID
            // 
            this.TripID.HeaderText = "TripID";
            this.TripID.Name = "TripID";
            this.TripID.ReadOnly = true;
            // 
            // CategoryID
            // 
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            // 
            // DepartureDate
            // 
            this.DepartureDate.HeaderText = "DepartureDate";
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // DateAdded
            // 
            this.DateAdded.HeaderText = "DateAdded";
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.ReadOnly = true;
            // 
            // removeb
            // 
            this.removeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.removeb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.removeb.Location = new System.Drawing.Point(407, 299);
            this.removeb.Name = "removeb";
            this.removeb.Size = new System.Drawing.Size(174, 37);
            this.removeb.TabIndex = 29;
            this.removeb.Text = "Remove From Wishlist!";
            this.removeb.UseVisualStyleBackColor = false;
            this.removeb.Click += new System.EventHandler(this.removeb_Click);
            // 
            // notifyb
            // 
            this.notifyb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.notifyb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.notifyb.Location = new System.Drawing.Point(407, 358);
            this.notifyb.Name = "notifyb";
            this.notifyb.Size = new System.Drawing.Size(174, 37);
            this.notifyb.TabIndex = 30;
            this.notifyb.Text = "Get Notified!";
            this.notifyb.UseVisualStyleBackColor = false;
            this.notifyb.Click += new System.EventHandler(this.notifyb_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(607, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "placeholder";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // wishlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.back3;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.notifyb);
            this.Controls.Add(this.removeb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "wishlist";
            this.Size = new System.Drawing.Size(959, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdded;
        private System.Windows.Forms.Button removeb;
        private System.Windows.Forms.Button notifyb;
        private System.Windows.Forms.Label label7;
    }
}
