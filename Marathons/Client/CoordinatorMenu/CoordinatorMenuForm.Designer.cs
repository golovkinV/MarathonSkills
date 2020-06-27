namespace Client.CoordinatorMenu
{
    partial class CoordinatorMenuForm:BaseForm.BaseForm
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
            this.runnersButton = new System.Windows.Forms.Button();
            this.sponsorshipButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1100, 98);
            // 
            // backButton
            // 
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(0, 622);
            this.footerPanel.Size = new System.Drawing.Size(1100, 54);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // runnersButton
            // 
            this.runnersButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runnersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.runnersButton.Location = new System.Drawing.Point(205, 251);
            this.runnersButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.runnersButton.Name = "runnersButton";
            this.runnersButton.Size = new System.Drawing.Size(317, 126);
            this.runnersButton.TabIndex = 20;
            this.runnersButton.Text = "Runners";
            this.runnersButton.UseVisualStyleBackColor = true;
            // 
            // sponsorshipButton
            // 
            this.sponsorshipButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsorshipButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.sponsorshipButton.Location = new System.Drawing.Point(634, 251);
            this.sponsorshipButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sponsorshipButton.Name = "sponsorshipButton";
            this.sponsorshipButton.Size = new System.Drawing.Size(317, 126);
            this.sponsorshipButton.TabIndex = 21;
            this.sponsorshipButton.Text = "Sponsorship";
            this.sponsorshipButton.UseVisualStyleBackColor = true;
            this.sponsorshipButton.Click += new System.EventHandler(this.sponsorshipButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(403, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "Coordinator menu";
            // 
            // CoordinatorMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sponsorshipButton);
            this.Controls.Add(this.runnersButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CoordinatorMenuForm";
            this.Text = "Marathon Skills 2015 - Coordinator Menu";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.footerPanel, 0);
            this.Controls.SetChildIndex(this.runnersButton, 0);
            this.Controls.SetChildIndex(this.sponsorshipButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runnersButton;
        private System.Windows.Forms.Button sponsorshipButton;
        private System.Windows.Forms.Label label1;
    }
}