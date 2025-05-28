namespace WindowsFormsAppProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.homeb = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchtripb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eticketsb = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.reportb = new System.Windows.Forms.Button();
            this.myprofileb = new System.Windows.Forms.Button();
            this.reviewb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeb
            // 
            this.homeb.BackColor = System.Drawing.Color.White;
            this.homeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeb.Location = new System.Drawing.Point(163, 20);
            this.homeb.Name = "homeb";
            this.homeb.Size = new System.Drawing.Size(104, 35);
            this.homeb.TabIndex = 2;
            this.homeb.Text = "Dashboard";
            this.homeb.UseVisualStyleBackColor = false;
            this.homeb.Click += new System.EventHandler(this.homeb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // searchtripb
            // 
            this.searchtripb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtripb.Location = new System.Drawing.Point(273, 20);
            this.searchtripb.Name = "searchtripb";
            this.searchtripb.Size = new System.Drawing.Size(109, 35);
            this.searchtripb.TabIndex = 3;
            this.searchtripb.Text = "Search Trips";
            this.searchtripb.UseVisualStyleBackColor = true;
            this.searchtripb.Click += new System.EventHandler(this.searchtripb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "TravelEase";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eticketsb
            // 
            this.eticketsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eticketsb.Location = new System.Drawing.Point(388, 21);
            this.eticketsb.Name = "eticketsb";
            this.eticketsb.Size = new System.Drawing.Size(109, 35);
            this.eticketsb.TabIndex = 4;
            this.eticketsb.Text = "E-Tickets";
            this.eticketsb.UseVisualStyleBackColor = true;
            this.eticketsb.Click += new System.EventHandler(this.bookingb_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.reportb);
            this.panel1.Controls.Add(this.myprofileb);
            this.panel1.Controls.Add(this.reviewb);
            this.panel1.Controls.Add(this.eticketsb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchtripb);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.homeb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 63);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(872, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Wishlist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportb
            // 
            this.reportb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportb.Location = new System.Drawing.Point(618, 20);
            this.reportb.Name = "reportb";
            this.reportb.Size = new System.Drawing.Size(136, 35);
            this.reportb.TabIndex = 7;
            this.reportb.Text = "Travel Reports";
            this.reportb.UseVisualStyleBackColor = true;
            this.reportb.Click += new System.EventHandler(this.reportb_Click);
            // 
            // myprofileb
            // 
            this.myprofileb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myprofileb.Location = new System.Drawing.Point(760, 20);
            this.myprofileb.Name = "myprofileb";
            this.myprofileb.Size = new System.Drawing.Size(109, 35);
            this.myprofileb.TabIndex = 6;
            this.myprofileb.Text = "My Profile";
            this.myprofileb.UseVisualStyleBackColor = true;
            this.myprofileb.Click += new System.EventHandler(this.myprofileb_Click);
            // 
            // reviewb
            // 
            this.reviewb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewb.Location = new System.Drawing.Point(503, 20);
            this.reviewb.Name = "reviewb";
            this.reviewb.Size = new System.Drawing.Size(109, 35);
            this.reviewb.TabIndex = 5;
            this.reviewb.Text = "Reviews";
            this.reviewb.UseVisualStyleBackColor = true;
            this.reviewb.Click += new System.EventHandler(this.reviewb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.back3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(943, 526);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchtripb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eticketsb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reviewb;
        private System.Windows.Forms.Button myprofileb;
        private System.Windows.Forms.Button reportb;
        private System.Windows.Forms.Button button1;
    }
}

