namespace Client.RunnerMenu
{
    partial class RunnerMenuForm : BaseForm.BaseForm
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
            this.registerButton = new System.Windows.Forms.Button();
            this.raceResultsButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.sponsorshipButton = new System.Windows.Forms.Button();
            this.contactInfoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(800, 53);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(0, 421);
            this.footerPanel.Size = new System.Drawing.Size(800, 29);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(170, 121);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(202, 51);
            this.registerButton.TabIndex = 20;
            this.registerButton.Text = "Register for an event";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // raceResultsButton
            // 
            this.raceResultsButton.Location = new System.Drawing.Point(439, 121);
            this.raceResultsButton.Name = "raceResultsButton";
            this.raceResultsButton.Size = new System.Drawing.Size(202, 51);
            this.raceResultsButton.TabIndex = 21;
            this.raceResultsButton.Text = "My race results";
            this.raceResultsButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(170, 202);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(202, 51);
            this.editButton.TabIndex = 22;
            this.editButton.Text = "Edit your profile";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // sponsorshipButton
            // 
            this.sponsorshipButton.Location = new System.Drawing.Point(439, 209);
            this.sponsorshipButton.Name = "sponsorshipButton";
            this.sponsorshipButton.Size = new System.Drawing.Size(202, 51);
            this.sponsorshipButton.TabIndex = 23;
            this.sponsorshipButton.Text = "My sponsorship";
            this.sponsorshipButton.UseVisualStyleBackColor = true;
            // 
            // contactInfoButton
            // 
            this.contactInfoButton.Location = new System.Drawing.Point(170, 294);
            this.contactInfoButton.Name = "contactInfoButton";
            this.contactInfoButton.Size = new System.Drawing.Size(202, 51);
            this.contactInfoButton.TabIndex = 24;
            this.contactInfoButton.Text = "Contact information";
            this.contactInfoButton.UseVisualStyleBackColor = true;
            // 
            // RunnerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contactInfoButton);
            this.Controls.Add(this.sponsorshipButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.raceResultsButton);
            this.Controls.Add(this.registerButton);
            this.Name = "RunnerMenuForm";
            this.Text = "RunnerMenuForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.footerPanel, 0);
            this.Controls.SetChildIndex(this.registerButton, 0);
            this.Controls.SetChildIndex(this.raceResultsButton, 0);
            this.Controls.SetChildIndex(this.editButton, 0);
            this.Controls.SetChildIndex(this.sponsorshipButton, 0);
            this.Controls.SetChildIndex(this.contactInfoButton, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button raceResultsButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button sponsorshipButton;
        private System.Windows.Forms.Button contactInfoButton;
    }
}