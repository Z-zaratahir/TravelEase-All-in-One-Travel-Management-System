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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TripName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableSlots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewconfirmb = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Trips";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TripName,
            this.Destination,
            this.Category,
            this.DepartureTime,
            this.ReturnDate,
            this.AvailableSlots,
            this.Payment});
            this.dataGridView1.Location = new System.Drawing.Point(147, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 112);
            this.dataGridView1.TabIndex = 8;
            // 
            // TripName
            // 
            this.TripName.Frozen = true;
            this.TripName.HeaderText = "TripName";
            this.TripName.Name = "TripName";
            // 
            // Destination
            // 
            this.Destination.Frozen = true;
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            // 
            // Category
            // 
            this.Category.Frozen = true;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // DepartureTime
            // 
            this.DepartureTime.Frozen = true;
            this.DepartureTime.HeaderText = "DepartureTime";
            this.DepartureTime.Name = "DepartureTime";
            // 
            // ReturnDate
            // 
            this.ReturnDate.Frozen = true;
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            // 
            // AvailableSlots
            // 
            this.AvailableSlots.Frozen = true;
            this.AvailableSlots.HeaderText = "AvailableSlots";
            this.AvailableSlots.Name = "AvailableSlots";
            // 
            // Payment
            // 
            this.Payment.Frozen = true;
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 349);
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
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.Button Cancelb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewconfirmb;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}
