namespace WindowsFormsAppProject
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelEaseDataSet = new WindowsFormsAppProject.TravelEaseDataSet();
            this.Cancelb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewconfirmb = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tripTableAdapter = new WindowsFormsAppProject.TravelEaseDataSetTableAdapters.TripTableAdapter();
            this.bookingAttemptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingAttemptTableAdapter = new WindowsFormsAppProject.TravelEaseDataSetTableAdapters.BookingAttemptTableAdapter();
            this.TripID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSlots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableSlots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelEaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingAttemptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Trips";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TripID,
            this.TotalSlots,
            this.AvailableSlots,
            this.ReturnDate,
            this.Price,
            this.DepartureDate,
            this.CategoryID,
            this.isCompleted});
            this.dataGridView1.Location = new System.Drawing.Point(99, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 112);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tripBindingSource
            // 
            this.tripBindingSource.DataMember = "Trip";
            this.tripBindingSource.DataSource = this.travelEaseDataSet;
            // 
            // travelEaseDataSet
            // 
            this.travelEaseDataSet.DataSetName = "TravelEaseDataSet";
            this.travelEaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cancelb
            // 
            this.Cancelb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.Cancelb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cancelb.Location = new System.Drawing.Point(385, 259);
            this.Cancelb.Name = "Cancelb";
            this.Cancelb.Size = new System.Drawing.Size(75, 29);
            this.Cancelb.TabIndex = 9;
            this.Cancelb.Text = "Cancel Trip!";
            this.Cancelb.UseVisualStyleBackColor = false;
            this.Cancelb.Click += new System.EventHandler(this.Cancelb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cancellation Policies:";
            // 
            // viewconfirmb
            // 
            this.viewconfirmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.viewconfirmb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.viewconfirmb.Location = new System.Drawing.Point(480, 259);
            this.viewconfirmb.Name = "viewconfirmb";
            this.viewconfirmb.Size = new System.Drawing.Size(167, 29);
            this.viewconfirmb.TabIndex = 11;
            this.viewconfirmb.Text = "View Confirmation!";
            this.viewconfirmb.UseVisualStyleBackColor = false;
            this.viewconfirmb.Click += new System.EventHandler(this.viewconfirmb_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(238, 383);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(528, 125);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // tripTableAdapter
            // 
            this.tripTableAdapter.ClearBeforeFill = true;
            // 
            // bookingAttemptBindingSource
            // 
            this.bookingAttemptBindingSource.DataMember = "BookingAttempt";
            this.bookingAttemptBindingSource.DataSource = this.travelEaseDataSet;
            // 
            // bookingAttemptTableAdapter
            // 
            this.bookingAttemptTableAdapter.ClearBeforeFill = true;
            // 
            // TripID
            // 
            this.TripID.HeaderText = "TripID";
            this.TripID.Name = "TripID";
            // 
            // TotalSlots
            // 
            this.TotalSlots.HeaderText = "TotalSlots";
            this.TotalSlots.Name = "TotalSlots";
            // 
            // AvailableSlots
            // 
            this.AvailableSlots.HeaderText = "AvailableSlots";
            this.AvailableSlots.Name = "AvailableSlots";
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // DepartureDate
            // 
            this.DepartureDate.HeaderText = "DepartureDate";
            this.DepartureDate.Name = "DepartureDate";
            // 
            // CategoryID
            // 
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            // 
            // isCompleted
            // 
            this.isCompleted.HeaderText = "isCompleted";
            this.isCompleted.Name = "isCompleted";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.back3;
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.viewconfirmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(959, 565);
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelEaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingAttemptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Cancelb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewconfirmb;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.BindingSource tripBindingSource;
        private TravelEaseDataSet travelEaseDataSet;
        private TravelEaseDataSetTableAdapters.TripTableAdapter tripTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.BindingSource bookingAttemptBindingSource;
        private TravelEaseDataSetTableAdapters.BookingAttemptTableAdapter bookingAttemptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCompleted;
    }
}
