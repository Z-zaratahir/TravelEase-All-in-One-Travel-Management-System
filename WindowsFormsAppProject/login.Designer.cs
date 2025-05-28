namespace WindowsFormsAppProject
{
    partial class login
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
            this.usernametextb = new System.Windows.Forms.TextBox();
            this.passwordtextb = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.loginb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(348, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(351, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernametextb
            // 
            this.usernametextb.Location = new System.Drawing.Point(457, 211);
            this.usernametextb.Name = "usernametextb";
            this.usernametextb.Size = new System.Drawing.Size(100, 20);
            this.usernametextb.TabIndex = 2;
            this.usernametextb.TextChanged += new System.EventHandler(this.usernametextb_TextChanged);
            // 
            // passwordtextb
            // 
            this.passwordtextb.Location = new System.Drawing.Point(457, 247);
            this.passwordtextb.Name = "passwordtextb";
            this.passwordtextb.Size = new System.Drawing.Size(100, 20);
            this.passwordtextb.TabIndex = 3;
            this.passwordtextb.TextChanged += new System.EventHandler(this.passwordtextb_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(498, 336);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do not have an account?";
            // 
            // loginb
            // 
            this.loginb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.loginb.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.loginb.Location = new System.Drawing.Point(401, 378);
            this.loginb.Name = "loginb";
            this.loginb.Size = new System.Drawing.Size(122, 37);
            this.loginb.TabIndex = 20;
            this.loginb.Text = "Log In!";
            this.loginb.UseVisualStyleBackColor = false;
            this.loginb.Click += new System.EventHandler(this.loginb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(276, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(393, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "Log In to Your TravelEase Account!";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.back3;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.passwordtextb);
            this.Controls.Add(this.usernametextb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Size = new System.Drawing.Size(959, 565);
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametextb;
        private System.Windows.Forms.TextBox passwordtextb;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginb;
        private System.Windows.Forms.Label label4;
    }
}
