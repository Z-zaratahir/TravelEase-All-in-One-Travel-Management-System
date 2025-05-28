namespace WindowsFormsAppProject
{
    partial class Bookings
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.travelername = new System.Windows.Forms.Label();
            this.cnic = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tripcategory = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.departuredate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bstatus = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.makepayment = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.bookingid = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book A Trip!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // travelername
            // 
            this.travelername.AutoSize = true;
            this.travelername.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelername.Location = new System.Drawing.Point(298, 129);
            this.travelername.Name = "travelername";
            this.travelername.Size = new System.Drawing.Size(40, 17);
            this.travelername.TabIndex = 4;
            this.travelername.Text = "name";
            this.travelername.Click += new System.EventHandler(this.travelername_Click);
            // 
            // cnic
            // 
            this.cnic.AutoSize = true;
            this.cnic.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnic.Location = new System.Drawing.Point(298, 157);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(30, 17);
            this.cnic.TabIndex = 6;
            this.cnic.Text = "cnic";
            this.cnic.Click += new System.EventHandler(this.cnic_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "CNIC:";
            // 
            // tid
            // 
            this.tid.AutoSize = true;
            this.tid.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tid.Location = new System.Drawing.Point(299, 187);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(39, 17);
            this.tid.TabIndex = 8;
            this.tid.Text = "tripid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "TripID:";
            // 
            // tripcategory
            // 
            this.tripcategory.AutoSize = true;
            this.tripcategory.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripcategory.Location = new System.Drawing.Point(298, 223);
            this.tripcategory.Name = "tripcategory";
            this.tripcategory.Size = new System.Drawing.Size(39, 17);
            this.tripcategory.TabIndex = 10;
            this.tripcategory.Text = "tripid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trip Category:";
            // 
            // departuredate
            // 
            this.departuredate.AutoSize = true;
            this.departuredate.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departuredate.Location = new System.Drawing.Point(299, 258);
            this.departuredate.Name = "departuredate";
            this.departuredate.Size = new System.Drawing.Size(39, 17);
            this.departuredate.TabIndex = 12;
            this.departuredate.Text = "tripid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Departure Date:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(299, 291);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(39, 17);
            this.price.TabIndex = 14;
            this.price.Text = "tripid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(181, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Trip Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(599, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "tripid";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(482, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total Amount:";
            // 
            // bstatus
            // 
            this.bstatus.AutoSize = true;
            this.bstatus.Location = new System.Drawing.Point(378, 448);
            this.bstatus.Name = "bstatus";
            this.bstatus.Size = new System.Drawing.Size(118, 17);
            this.bstatus.TabIndex = 19;
            this.bstatus.Text = "Booking Confirmed!";
            this.bstatus.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(489, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Confirm Your Booking!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(461, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Payment Method:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(597, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // makepayment
            // 
            this.makepayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.makepayment.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makepayment.Location = new System.Drawing.Point(535, 293);
            this.makepayment.Name = "makepayment";
            this.makepayment.Size = new System.Drawing.Size(145, 32);
            this.makepayment.TabIndex = 23;
            this.makepayment.Text = "Make Payment!";
            this.makepayment.UseVisualStyleBackColor = false;
            this.makepayment.Click += new System.EventHandler(this.makepayment_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(367, 410);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 21);
            this.label13.TabIndex = 24;
            this.label13.Text = "Confirmation Panel";
            // 
            // bookingid
            // 
            this.bookingid.AutoSize = true;
            this.bookingid.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingid.Location = new System.Drawing.Point(302, 477);
            this.bookingid.Name = "bookingid";
            this.bookingid.Size = new System.Drawing.Size(326, 17);
            this.bookingid.TabIndex = 26;
            this.bookingid.Text = "You will view it once the admin confirms your booking!";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(215, 477);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Booking ID:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(183, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 32);
            this.button1.TabIndex = 27;
            this.button1.Text = "Book Now!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(601, 249);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 29;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Group Size:";
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.back3;
            this.ClientSize = new System.Drawing.Size(943, 526);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookingid);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.makepayment);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bstatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.departuredate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tripcategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.travelername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Bookings";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.Bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label travelername;
        private System.Windows.Forms.Label cnic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tripcategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label departuredate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox bstatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button makepayment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label bookingid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}