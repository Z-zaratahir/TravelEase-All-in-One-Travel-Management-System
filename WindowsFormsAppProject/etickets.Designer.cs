namespace WindowsFormsAppProject
{
    partial class etickets
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tripIDcbox = new System.Windows.Forms.ComboBox();
            this.destination = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.departuredate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.returndate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalpeople = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.paymentstatus = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.hotelname = new System.Windows.Forms.Label();
            this.dwvoucherb = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.activity = new System.Windows.Forms.DataGridView();
            this.ActivityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dwpassb = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.transportprovider = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activity)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Digital Travel Pass!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trip Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Destination:";
            // 
            // tripIDcbox
            // 
            this.tripIDcbox.FormattingEnabled = true;
            this.tripIDcbox.Location = new System.Drawing.Point(331, 104);
            this.tripIDcbox.Name = "tripIDcbox";
            this.tripIDcbox.Size = new System.Drawing.Size(121, 21);
            this.tripIDcbox.TabIndex = 4;
            this.tripIDcbox.SelectedIndexChanged += new System.EventHandler(this.tripIDcbox_SelectedIndexChanged);
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Location = new System.Drawing.Point(328, 137);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(60, 13);
            this.destination.TabIndex = 5;
            this.destination.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Departure Date:";
            // 
            // departuredate
            // 
            this.departuredate.AutoSize = true;
            this.departuredate.Location = new System.Drawing.Point(328, 165);
            this.departuredate.Name = "departuredate";
            this.departuredate.Size = new System.Drawing.Size(83, 13);
            this.departuredate.TabIndex = 7;
            this.departuredate.Text = "Departure Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Return Date:";
            // 
            // returndate
            // 
            this.returndate.AutoSize = true;
            this.returndate.Location = new System.Drawing.Point(328, 194);
            this.returndate.Name = "returndate";
            this.returndate.Size = new System.Drawing.Size(68, 13);
            this.returndate.TabIndex = 9;
            this.returndate.Text = "Return Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Group Size:";
            // 
            // totalpeople
            // 
            this.totalpeople.AutoSize = true;
            this.totalpeople.Location = new System.Drawing.Point(328, 222);
            this.totalpeople.Name = "totalpeople";
            this.totalpeople.Size = new System.Drawing.Size(62, 13);
            this.totalpeople.TabIndex = 11;
            this.totalpeople.Text = "Group Size:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Price:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(328, 253);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(34, 13);
            this.price.TabIndex = 13;
            this.price.Text = "Price:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "E-Ticket:";
            // 
            // paymentstatus
            // 
            this.paymentstatus.AutoSize = true;
            this.paymentstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.paymentstatus.Location = new System.Drawing.Point(328, 320);
            this.paymentstatus.Name = "paymentstatus";
            this.paymentstatus.Size = new System.Drawing.Size(75, 13);
            this.paymentstatus.TabIndex = 15;
            this.paymentstatus.Text = "paymentstatus";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(233, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Hotel Voucher:";
            // 
            // hotelname
            // 
            this.hotelname.AutoSize = true;
            this.hotelname.Location = new System.Drawing.Point(328, 351);
            this.hotelname.Name = "hotelname";
            this.hotelname.Size = new System.Drawing.Size(56, 13);
            this.hotelname.TabIndex = 17;
            this.hotelname.Text = "hotelname";
            // 
            // dwvoucherb
            // 
            this.dwvoucherb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.dwvoucherb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.dwvoucherb.Location = new System.Drawing.Point(615, 342);
            this.dwvoucherb.Name = "dwvoucherb";
            this.dwvoucherb.Size = new System.Drawing.Size(169, 28);
            this.dwvoucherb.TabIndex = 18;
            this.dwvoucherb.Text = "Download Voucher!";
            this.dwvoucherb.UseVisualStyleBackColor = false;
            this.dwvoucherb.Click += new System.EventHandler(this.dwvoucherb_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(241, 379);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Activity Pass:";
            // 
            // activity
            // 
            this.activity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivityID,
            this.ActivityName});
            this.activity.Location = new System.Drawing.Point(334, 379);
            this.activity.Name = "activity";
            this.activity.Size = new System.Drawing.Size(240, 70);
            this.activity.TabIndex = 20;
            this.activity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activity_CellContentClick);
            // 
            // ActivityID
            // 
            this.ActivityID.HeaderText = "ActivityID";
            this.ActivityID.Name = "ActivityID";
            // 
            // ActivityName
            // 
            this.ActivityName.HeaderText = "ActivityName";
            this.ActivityName.Name = "ActivityName";
            // 
            // dwpassb
            // 
            this.dwpassb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.dwpassb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.dwpassb.Location = new System.Drawing.Point(615, 379);
            this.dwpassb.Name = "dwpassb";
            this.dwpassb.Size = new System.Drawing.Size(169, 28);
            this.dwpassb.TabIndex = 21;
            this.dwpassb.Text = "Download Pass!";
            this.dwpassb.UseVisualStyleBackColor = false;
            this.dwpassb.Click += new System.EventHandler(this.dwpassb_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(223, 476);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Transport Ticket:";
            // 
            // transportprovider
            // 
            this.transportprovider.AutoSize = true;
            this.transportprovider.Location = new System.Drawing.Point(331, 476);
            this.transportprovider.Name = "transportprovider";
            this.transportprovider.Size = new System.Drawing.Size(86, 13);
            this.transportprovider.TabIndex = 23;
            this.transportprovider.Text = "transportprovider";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(615, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 46);
            this.button1.TabIndex = 24;
            this.button1.Text = "Download Transport Ticket!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // etickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.back3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transportprovider);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dwpassb);
            this.Controls.Add(this.activity);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dwvoucherb);
            this.Controls.Add(this.hotelname);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.paymentstatus);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalpeople);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.returndate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.departuredate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.tripIDcbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "etickets";
            this.Size = new System.Drawing.Size(959, 565);
            this.Load += new System.EventHandler(this.mybookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tripIDcbox;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label departuredate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label returndate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalpeople;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label paymentstatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label hotelname;
        private System.Windows.Forms.Button dwvoucherb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView activity;

        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityName;
        private System.Windows.Forms.Button dwpassb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label transportprovider;
        private System.Windows.Forms.Button button1;
    }
}
