namespace BRS
{
    partial class ShowRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowRecords));
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.titleLabelShowScreen = new System.Windows.Forms.Label();
            this.SHOW_RECORDS = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            this.SHOW_RECORDS.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AllowUserToAddRows = false;
            this.bookingDataGridView.AllowUserToDeleteRows = false;
            this.bookingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Location = new System.Drawing.Point(31, 112);
            this.bookingDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.ReadOnly = true;
            this.bookingDataGridView.Size = new System.Drawing.Size(1140, 566);
            this.bookingDataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 592);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(13, 12);
            this.button1.TabIndex = 1;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // titleLabelShowScreen
            // 
            this.titleLabelShowScreen.AutoSize = true;
            this.titleLabelShowScreen.Location = new System.Drawing.Point(535, 105);
            this.titleLabelShowScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabelShowScreen.Name = "titleLabelShowScreen";
            this.titleLabelShowScreen.Size = new System.Drawing.Size(0, 17);
            this.titleLabelShowScreen.TabIndex = 2;
            // 
            // SHOW_RECORDS
            // 
            this.SHOW_RECORDS.BackgroundImage = global::BRS.Properties.Resources._1;
            this.SHOW_RECORDS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SHOW_RECORDS.Controls.Add(this.panel3);
            this.SHOW_RECORDS.Controls.Add(this.bookingDataGridView);
            this.SHOW_RECORDS.Controls.Add(this.button1);
            this.SHOW_RECORDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SHOW_RECORDS.Location = new System.Drawing.Point(67, 62);
            this.SHOW_RECORDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SHOW_RECORDS.Name = "SHOW_RECORDS";
            this.SHOW_RECORDS.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.SHOW_RECORDS.Size = new System.Drawing.Size(1210, 714);
            this.SHOW_RECORDS.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.back);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1218, 92);
            this.panel3.TabIndex = 25;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = global::BRS.Properties.Resources.back_arrow1;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(120, 89);
            this.back.TabIndex = 19;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(556, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 67);
            this.label3.TabIndex = 13;
            this.label3.Text = " RECORDS";
            // 
            // ShowRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BRS.Properties.Resources.iwp780281584_bus_wallpapers1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 838);
            this.Controls.Add(this.SHOW_RECORDS);
            this.Controls.Add(this.titleLabelShowScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShowRecords";
            this.Padding = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHOW_BOOKING";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SHOW_BOOKING_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            this.SHOW_RECORDS.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titleLabelShowScreen;
        private System.Windows.Forms.Panel SHOW_RECORDS;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}