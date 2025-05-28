namespace Project
{
    partial class ServiceProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceProvider));
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPerformance = new System.Windows.Forms.Button();
            this.buttonBookingManagement = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonRegiteration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(1, -1);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(87, 79);
            this.pictureLogo.TabIndex = 2;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelLogo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonPerformance);
            this.panel1.Controls.Add(this.buttonBookingManagement);
            this.panel1.Controls.Add(this.buttonCategories);
            this.panel1.Controls.Add(this.buttonRegiteration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 79);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.labelLogo.Location = new System.Drawing.Point(62, 27);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(188, 45);
            this.labelLogo.TabIndex = 2;
            this.labelLogo.Text = "TravelEase";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 79);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPerformance
            // 
            this.buttonPerformance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPerformance.Location = new System.Drawing.Point(836, 21);
            this.buttonPerformance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPerformance.Name = "buttonPerformance";
            this.buttonPerformance.Size = new System.Drawing.Size(164, 45);
            this.buttonPerformance.TabIndex = 6;
            this.buttonPerformance.Text = "Performance";
            this.buttonPerformance.UseVisualStyleBackColor = false;
            this.buttonPerformance.Click += new System.EventHandler(this.buttonPerformance_Click);
            // 
            // buttonBookingManagement
            // 
            this.buttonBookingManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonBookingManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookingManagement.Location = new System.Drawing.Point(664, 21);
            this.buttonBookingManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBookingManagement.Name = "buttonBookingManagement";
            this.buttonBookingManagement.Size = new System.Drawing.Size(164, 45);
            this.buttonBookingManagement.TabIndex = 5;
            this.buttonBookingManagement.Text = "Booking Management";
            this.buttonBookingManagement.UseVisualStyleBackColor = false;
            this.buttonBookingManagement.Click += new System.EventHandler(this.buttonBookingManagement_Click);
            // 
            // buttonCategories
            // 
            this.buttonCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategories.Location = new System.Drawing.Point(492, 21);
            this.buttonCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(164, 45);
            this.buttonCategories.TabIndex = 4;
            this.buttonCategories.Text = "Listing";
            this.buttonCategories.UseVisualStyleBackColor = false;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // buttonRegiteration
            // 
            this.buttonRegiteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonRegiteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRegiteration.Location = new System.Drawing.Point(310, 21);
            this.buttonRegiteration.Name = "buttonRegiteration";
            this.buttonRegiteration.Size = new System.Drawing.Size(175, 45);
            this.buttonRegiteration.TabIndex = 0;
            this.buttonRegiteration.Text = "Integration";
            this.buttonRegiteration.UseVisualStyleBackColor = false;
            this.buttonRegiteration.Click += new System.EventHandler(this.buttonRegiteration_Click);
            // 
            // ServiceProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureLogo);
            this.Name = "ServiceProvider";
            this.Text = "ServiceProvider";
            this.Load += new System.EventHandler(this.ServiceProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPerformance;
        private System.Windows.Forms.Button buttonBookingManagement;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Button buttonRegiteration;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}