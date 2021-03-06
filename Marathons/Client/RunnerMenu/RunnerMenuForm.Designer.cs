﻿namespace Client.RunnerMenu
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
            this.popupPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headLabel = new System.Windows.Forms.Label();
            this.closePopupButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.popupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1467, 98);
            // 
            // backButton
            // 
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(0, 777);
            this.footerPanel.Size = new System.Drawing.Size(1467, 54);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(312, 223);
            this.registerButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(370, 94);
            this.registerButton.TabIndex = 20;
            this.registerButton.Text = "Register for an event";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // raceResultsButton
            // 
            this.raceResultsButton.Location = new System.Drawing.Point(805, 223);
            this.raceResultsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.raceResultsButton.Name = "raceResultsButton";
            this.raceResultsButton.Size = new System.Drawing.Size(370, 94);
            this.raceResultsButton.TabIndex = 21;
            this.raceResultsButton.Text = "My race results";
            this.raceResultsButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(312, 373);
            this.editButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(370, 94);
            this.editButton.TabIndex = 22;
            this.editButton.Text = "Edit your profile";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // sponsorshipButton
            // 
            this.sponsorshipButton.Location = new System.Drawing.Point(805, 386);
            this.sponsorshipButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sponsorshipButton.Name = "sponsorshipButton";
            this.sponsorshipButton.Size = new System.Drawing.Size(370, 94);
            this.sponsorshipButton.TabIndex = 23;
            this.sponsorshipButton.Text = "My sponsorship";
            this.sponsorshipButton.UseVisualStyleBackColor = true;
            this.sponsorshipButton.Click += new System.EventHandler(this.sponsorshipButton_Click);
            // 
            // contactInfoButton
            // 
            this.contactInfoButton.Location = new System.Drawing.Point(312, 543);
            this.contactInfoButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.contactInfoButton.Name = "contactInfoButton";
            this.contactInfoButton.Size = new System.Drawing.Size(370, 94);
            this.contactInfoButton.TabIndex = 24;
            this.contactInfoButton.Text = "Contact information";
            this.contactInfoButton.UseVisualStyleBackColor = true;
            this.contactInfoButton.Click += new System.EventHandler(this.contactInfoButton_Click);
            // 
            // popupPanel
            // 
            this.popupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popupPanel.Controls.Add(this.label5);
            this.popupPanel.Controls.Add(this.label4);
            this.popupPanel.Controls.Add(this.label3);
            this.popupPanel.Controls.Add(this.label2);
            this.popupPanel.Controls.Add(this.label1);
            this.popupPanel.Controls.Add(this.headLabel);
            this.popupPanel.Controls.Add(this.closePopupButton);
            this.popupPanel.Location = new System.Drawing.Point(282, 175);
            this.popupPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.popupPanel.Name = "popupPanel";
            this.popupPanel.Size = new System.Drawing.Size(891, 480);
            this.popupPanel.TabIndex = 25;
            this.popupPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(94, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(81, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(227, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "coordinators@marathonskills.org\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(227, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "+55 11 9988 7766\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 116);
            this.label1.TabIndex = 5;
            this.label1.Text = "For more information about Marathon Skills, please contact the coordinators using" +
    " these contact details.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headLabel.ForeColor = System.Drawing.Color.Black;
            this.headLabel.Location = new System.Drawing.Point(270, 20);
            this.headLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(340, 42);
            this.headLabel.TabIndex = 4;
            this.headLabel.Text = "Contact information";
            // 
            // closePopupButton
            // 
            this.closePopupButton.BackColor = System.Drawing.Color.Transparent;
            this.closePopupButton.ForeColor = System.Drawing.Color.Red;
            this.closePopupButton.Location = new System.Drawing.Point(838, 6);
            this.closePopupButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.closePopupButton.Name = "closePopupButton";
            this.closePopupButton.Size = new System.Drawing.Size(46, 42);
            this.closePopupButton.TabIndex = 3;
            this.closePopupButton.Text = "x";
            this.closePopupButton.UseVisualStyleBackColor = false;
            this.closePopupButton.Click += new System.EventHandler(this.closePopupButton_Click);
            // 
            // RunnerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.popupPanel);
            this.Controls.Add(this.contactInfoButton);
            this.Controls.Add(this.sponsorshipButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.raceResultsButton);
            this.Controls.Add(this.registerButton);
            this.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.Name = "RunnerMenuForm";
            this.Text = "RunnerMenuForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.footerPanel, 0);
            this.Controls.SetChildIndex(this.registerButton, 0);
            this.Controls.SetChildIndex(this.raceResultsButton, 0);
            this.Controls.SetChildIndex(this.editButton, 0);
            this.Controls.SetChildIndex(this.sponsorshipButton, 0);
            this.Controls.SetChildIndex(this.contactInfoButton, 0);
            this.Controls.SetChildIndex(this.popupPanel, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.popupPanel.ResumeLayout(false);
            this.popupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button raceResultsButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button sponsorshipButton;
        private System.Windows.Forms.Button contactInfoButton;
        private System.Windows.Forms.Panel popupPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Button closePopupButton;
    }
}