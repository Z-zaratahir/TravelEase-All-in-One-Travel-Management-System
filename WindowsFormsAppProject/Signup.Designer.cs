namespace WindowsFormsAppProject
{
    partial class Signup
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
            this.label4 = new System.Windows.Forms.Label();
            this.loginb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.passwordtextb = new System.Windows.Forms.TextBox();
            this.usernametextb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastnametb = new System.Windows.Forms.TextBox();
            this.fnametb = new System.Windows.Forms.TextBox();
            this.lnametb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statetb = new System.Windows.Forms.TextBox();
            this.citytb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rolecombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dobtextb = new System.Windows.Forms.MaskedTextBox();
            this.zipcodetb = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(264, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Create Your TravelEase Account!";
            // 
            // loginb
            // 
            this.loginb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.loginb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.loginb.Location = new System.Drawing.Point(549, 317);
            this.loginb.Name = "loginb";
            this.loginb.Size = new System.Drawing.Size(122, 37);
            this.loginb.TabIndex = 28;
            this.loginb.Text = "Sign up!";
            this.loginb.UseVisualStyleBackColor = false;
            this.loginb.Click += new System.EventHandler(this.loginb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Already have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(651, 275);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign in!";
            // 
            // passwordtextb
            // 
            this.passwordtextb.Location = new System.Drawing.Point(605, 186);
            this.passwordtextb.Name = "passwordtextb";
            this.passwordtextb.Size = new System.Drawing.Size(100, 20);
            this.passwordtextb.TabIndex = 25;
            this.passwordtextb.TextChanged += new System.EventHandler(this.passwordtextb_TextChanged);
            // 
            // usernametextb
            // 
            this.usernametextb.Location = new System.Drawing.Point(605, 150);
            this.usernametextb.Name = "usernametextb";
            this.usernametextb.Size = new System.Drawing.Size(100, 20);
            this.usernametextb.TabIndex = 24;
            this.usernametextb.TextChanged += new System.EventHandler(this.usernametextb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(499, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(496, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Username:";
            // 
            // lastnametb
            // 
            this.lastnametb.Location = new System.Drawing.Point(318, 189);
            this.lastnametb.Name = "lastnametb";
            this.lastnametb.Size = new System.Drawing.Size(100, 20);
            this.lastnametb.TabIndex = 33;
            this.lastnametb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fnametb
            // 
            this.fnametb.Location = new System.Drawing.Point(318, 153);
            this.fnametb.Name = "fnametb";
            this.fnametb.Size = new System.Drawing.Size(100, 20);
            this.fnametb.TabIndex = 32;
            this.fnametb.TextChanged += new System.EventHandler(this.fnametb_TextChanged);
            // 
            // lnametb
            // 
            this.lnametb.AutoSize = true;
            this.lnametb.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.lnametb.Location = new System.Drawing.Point(174, 190);
            this.lnametb.Name = "lnametb";
            this.lnametb.Size = new System.Drawing.Size(87, 19);
            this.lnametb.TabIndex = 31;
            this.lnametb.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(172, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "First Name:";
            // 
            // statetb
            // 
            this.statetb.Location = new System.Drawing.Point(318, 269);
            this.statetb.Name = "statetb";
            this.statetb.Size = new System.Drawing.Size(100, 20);
            this.statetb.TabIndex = 37;
            this.statetb.TextChanged += new System.EventHandler(this.statetb_TextChanged);
            // 
            // citytb
            // 
            this.citytb.Location = new System.Drawing.Point(318, 233);
            this.citytb.Name = "citytb";
            this.citytb.Size = new System.Drawing.Size(100, 20);
            this.citytb.TabIndex = 36;
            this.citytb.TextChanged += new System.EventHandler(this.citytb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(212, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "State:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(220, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(216, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "CNIC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(185, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Zip Code:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(220, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 19);
            this.label10.TabIndex = 42;
            this.label10.Text = "DOB";
            // 
            // rolecombo
            // 
            this.rolecombo.FormattingEnabled = true;
            this.rolecombo.Location = new System.Drawing.Point(318, 446);
            this.rolecombo.Name = "rolecombo";
            this.rolecombo.Size = new System.Drawing.Size(121, 21);
            this.rolecombo.TabIndex = 44;
            this.rolecombo.SelectedIndexChanged += new System.EventHandler(this.rolecombo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(173, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 19);
            this.label11.TabIndex = 45;
            this.label11.Text = "Sign Up as:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 402);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dobtextb
            // 
            this.dobtextb.Location = new System.Drawing.Point(318, 354);
            this.dobtextb.Mask = "00000-0000000-0";
            this.dobtextb.Name = "dobtextb";
            this.dobtextb.Size = new System.Drawing.Size(100, 20);
            this.dobtextb.TabIndex = 43;
            this.dobtextb.ValidatingType = typeof(System.DateTime);
            this.dobtextb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dobtextb_MaskInputRejected);
            // 
            // zipcodetb
            // 
            this.zipcodetb.Location = new System.Drawing.Point(318, 317);
            this.zipcodetb.Mask = "00000";
            this.zipcodetb.Name = "zipcodetb";
            this.zipcodetb.Size = new System.Drawing.Size(100, 20);
            this.zipcodetb.TabIndex = 47;
            this.zipcodetb.ValidatingType = typeof(System.DateTime);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.back3;
            this.Controls.Add(this.zipcodetb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rolecombo);
            this.Controls.Add(this.dobtextb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.statetb);
            this.Controls.Add(this.citytb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lastnametb);
            this.Controls.Add(this.fnametb);
            this.Controls.Add(this.lnametb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.passwordtextb);
            this.Controls.Add(this.usernametextb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Size = new System.Drawing.Size(959, 565);
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox passwordtextb;
        private System.Windows.Forms.TextBox usernametextb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastnametb;
        private System.Windows.Forms.TextBox fnametb;
        private System.Windows.Forms.Label lnametb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox statetb;
        private System.Windows.Forms.TextBox citytb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox rolecombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox dobtextb;
        private System.Windows.Forms.MaskedTextBox zipcodetb;
    }
}
