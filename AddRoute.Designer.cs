namespace BRS
{
    partial class AddRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoute));
            this.OriginTextBox = new System.Windows.Forms.TextBox();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label_un = new System.Windows.Forms.Label();
            this.cencel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OriginTextBox
            // 
            this.OriginTextBox.Location = new System.Drawing.Point(541, 220);
            this.OriginTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OriginTextBox.Name = "OriginTextBox";
            this.OriginTextBox.Size = new System.Drawing.Size(563, 22);
            this.OriginTextBox.TabIndex = 2;
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(541, 299);
            this.DestinationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(563, 22);
            this.DestinationTextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = global::BRS.Properties.Resources.add_button_png_md;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.Location = new System.Drawing.Point(232, 517);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(191, 65);
            this.AddButton.TabIndex = 5;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BRS.Properties.Resources._1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label_un);
            this.panel1.Controls.Add(this.cencel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.DestinationTextBox);
            this.panel1.Controls.Add(this.OriginTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(67, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 714);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(176, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "ARRIVAL";
            // 
            // label_un
            // 
            this.label_un.AutoSize = true;
            this.label_un.BackColor = System.Drawing.Color.Transparent;
            this.label_un.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_un.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_un.Location = new System.Drawing.Point(176, 215);
            this.label_un.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_un.Name = "label_un";
            this.label_un.Size = new System.Drawing.Size(169, 29);
            this.label_un.TabIndex = 25;
            this.label_un.Text = "DEPARTURE";
            // 
            // cencel
            // 
            this.cencel.BackColor = System.Drawing.Color.Transparent;
            this.cencel.BackgroundImage = global::BRS.Properties.Resources.cancel1;
            this.cencel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cencel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cencel.FlatAppearance.BorderSize = 0;
            this.cencel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cencel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cencel.Location = new System.Drawing.Point(789, 517);
            this.cencel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cencel.Name = "cencel";
            this.cencel.Size = new System.Drawing.Size(247, 65);
            this.cencel.TabIndex = 23;
            this.cencel.UseVisualStyleBackColor = false;
            this.cencel.Click += new System.EventHandler(this.cencel_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.back);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1218, 92);
            this.panel3.TabIndex = 24;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = global::BRS.Properties.Resources.back_arrow;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(4, 7);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(117, 85);
            this.back.TabIndex = 18;
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
            this.label3.Location = new System.Drawing.Point(611, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(481, 67);
            this.label3.TabIndex = 13;
            this.label3.Text = "ROUTE MAKER";
            // 
            // AddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BRS.Properties.Resources.iwp780281584_bus_wallpapers3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 838);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddRoute";
            this.Padding = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.Text = "AddRoute";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox OriginTextBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cencel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_un;
    }
}