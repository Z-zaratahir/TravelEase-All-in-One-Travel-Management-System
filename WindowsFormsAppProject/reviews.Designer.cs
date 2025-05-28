namespace WindowsFormsAppProject
{
    partial class reviews
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reviewb1 = new System.Windows.Forms.RadioButton();
            this.reviewb2 = new System.Windows.Forms.RadioButton();
            this.reviewb3 = new System.Windows.Forms.RadioButton();
            this.reviewb4 = new System.Windows.Forms.RadioButton();
            this.reviewb5 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReviewID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leave a Review!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select a Trip:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(334, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // reviewb1
            // 
            this.reviewb1.AutoSize = true;
            this.reviewb1.BackColor = System.Drawing.Color.White;
            this.reviewb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.reviewb1.Location = new System.Drawing.Point(336, 174);
            this.reviewb1.Name = "reviewb1";
            this.reviewb1.Size = new System.Drawing.Size(14, 13);
            this.reviewb1.TabIndex = 5;
            this.reviewb1.TabStop = true;
            this.reviewb1.UseVisualStyleBackColor = false;
            this.reviewb1.CheckedChanged += new System.EventHandler(this.reviewb1_CheckedChanged);
            // 
            // reviewb2
            // 
            this.reviewb2.AutoSize = true;
            this.reviewb2.BackColor = System.Drawing.Color.White;
            this.reviewb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.reviewb2.Location = new System.Drawing.Point(351, 174);
            this.reviewb2.Name = "reviewb2";
            this.reviewb2.Size = new System.Drawing.Size(14, 13);
            this.reviewb2.TabIndex = 6;
            this.reviewb2.TabStop = true;
            this.reviewb2.UseVisualStyleBackColor = false;
            this.reviewb2.CheckedChanged += new System.EventHandler(this.reviewb2_CheckedChanged);
            // 
            // reviewb3
            // 
            this.reviewb3.AutoSize = true;
            this.reviewb3.BackColor = System.Drawing.Color.White;
            this.reviewb3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.reviewb3.Location = new System.Drawing.Point(366, 174);
            this.reviewb3.Name = "reviewb3";
            this.reviewb3.Size = new System.Drawing.Size(14, 13);
            this.reviewb3.TabIndex = 7;
            this.reviewb3.TabStop = true;
            this.reviewb3.UseVisualStyleBackColor = false;
            this.reviewb3.CheckedChanged += new System.EventHandler(this.reviewb3_CheckedChanged);
            // 
            // reviewb4
            // 
            this.reviewb4.AutoSize = true;
            this.reviewb4.BackColor = System.Drawing.Color.White;
            this.reviewb4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.reviewb4.Location = new System.Drawing.Point(381, 174);
            this.reviewb4.Name = "reviewb4";
            this.reviewb4.Size = new System.Drawing.Size(14, 13);
            this.reviewb4.TabIndex = 8;
            this.reviewb4.TabStop = true;
            this.reviewb4.UseVisualStyleBackColor = false;
            this.reviewb4.CheckedChanged += new System.EventHandler(this.reviewb4_CheckedChanged);
            // 
            // reviewb5
            // 
            this.reviewb5.AutoSize = true;
            this.reviewb5.BackColor = System.Drawing.Color.White;
            this.reviewb5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.reviewb5.Location = new System.Drawing.Point(397, 174);
            this.reviewb5.Name = "reviewb5";
            this.reviewb5.Size = new System.Drawing.Size(14, 13);
            this.reviewb5.TabIndex = 9;
            this.reviewb5.TabStop = true;
            this.reviewb5.UseVisualStyleBackColor = false;
            this.reviewb5.CheckedChanged += new System.EventHandler(this.reviewb5_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ratings:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Write Reviews:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(334, 207);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(298, 69);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(551, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReviewID,
            this.Rating,
            this.ReviewDate,
            this.Comments});
            this.dataGridView1.Location = new System.Drawing.Point(209, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 85);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ReviewID
            // 
            this.ReviewID.HeaderText = "ReviewID";
            this.ReviewID.Name = "ReviewID";
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            // 
            // ReviewDate
            // 
            this.ReviewDate.HeaderText = "ReviewDate";
            this.ReviewDate.Name = "ReviewDate";
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Previous Reviews:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // reviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppProject.Properties.Resources.back3;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reviewb5);
            this.Controls.Add(this.reviewb4);
            this.Controls.Add(this.reviewb3);
            this.Controls.Add(this.reviewb2);
            this.Controls.Add(this.reviewb1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "reviews";
            this.Size = new System.Drawing.Size(959, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton reviewb1;
        private System.Windows.Forms.RadioButton reviewb2;
        private System.Windows.Forms.RadioButton reviewb3;
        private System.Windows.Forms.RadioButton reviewb4;
        private System.Windows.Forms.RadioButton reviewb5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.Label label5;
    }
}
