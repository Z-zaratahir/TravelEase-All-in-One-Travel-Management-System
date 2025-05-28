namespace Project
{
    partial class ReviewModeration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewModeration));
            this.PlatformAnalytics = new System.Windows.Forms.Label();
            this.dataGridViewReviews = new System.Windows.Forms.DataGridView();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.buttonDeleteReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // PlatformAnalytics
            // 
            this.PlatformAnalytics.AutoSize = true;
            this.PlatformAnalytics.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlatformAnalytics.Font = new System.Drawing.Font("Segoe Print", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformAnalytics.Location = new System.Drawing.Point(429, 177);
            this.PlatformAnalytics.Name = "PlatformAnalytics";
            this.PlatformAnalytics.Size = new System.Drawing.Size(654, 91);
            this.PlatformAnalytics.TabIndex = 5;
            this.PlatformAnalytics.Text = "REVIEW MODERATION";
            // 
            // dataGridViewReviews
            // 
            this.dataGridViewReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviews.Location = new System.Drawing.Point(259, 465);
            this.dataGridViewReviews.Name = "dataGridViewReviews";
            this.dataGridViewReviews.RowHeadersWidth = 62;
            this.dataGridViewReviews.RowTemplate.Height = 28;
            this.dataGridViewReviews.Size = new System.Drawing.Size(1109, 159);
            this.dataGridViewReviews.TabIndex = 6;
            this.dataGridViewReviews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReviews_CellContentClick);
            // 
            // buttonApprove
            // 
            this.buttonApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonApprove.Location = new System.Drawing.Point(259, 409);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(177, 50);
            this.buttonApprove.TabIndex = 7;
            this.buttonApprove.Text = "Approve";
            this.buttonApprove.UseVisualStyleBackColor = false;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // buttonDeleteReview
            // 
            this.buttonDeleteReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.buttonDeleteReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDeleteReview.Location = new System.Drawing.Point(442, 409);
            this.buttonDeleteReview.Name = "buttonDeleteReview";
            this.buttonDeleteReview.Size = new System.Drawing.Size(177, 50);
            this.buttonDeleteReview.TabIndex = 8;
            this.buttonDeleteReview.Text = "Delete";
            this.buttonDeleteReview.UseVisualStyleBackColor = false;
            this.buttonDeleteReview.Click += new System.EventHandler(this.buttonDeleteReview_Click);
            // 
            // ReviewModeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.buttonDeleteReview);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.dataGridViewReviews);
            this.Controls.Add(this.PlatformAnalytics);
            this.Name = "ReviewModeration";
            this.Size = new System.Drawing.Size(1500, 800);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlatformAnalytics;
        private System.Windows.Forms.DataGridView dataGridViewReviews;
        private System.Windows.Forms.Button buttonApprove;
        private System.Windows.Forms.Button buttonDeleteReview;
    }
}
