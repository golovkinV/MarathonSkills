namespace Client.CheckRunnerCompeted
{
    partial class CheckRunnerCompetedForm : BaseForm.BaseForm
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
            this.competedButton = new System.Windows.Forms.Button();
            this.newCompetitorButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(758, 53);
            // 
            // backButton
            // 
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(0, 421);
            this.footerPanel.Size = new System.Drawing.Size(758, 29);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // competedButton
            // 
            this.competedButton.Location = new System.Drawing.Point(255, 146);
            this.competedButton.Name = "competedButton";
            this.competedButton.Size = new System.Drawing.Size(233, 54);
            this.competedButton.TabIndex = 20;
            this.competedButton.Text = "I have competed before";
            this.competedButton.UseVisualStyleBackColor = true;
            this.competedButton.Click += new System.EventHandler(this.competedButton_Click);
            // 
            // newCompetitorButton
            // 
            this.newCompetitorButton.Location = new System.Drawing.Point(255, 241);
            this.newCompetitorButton.Name = "newCompetitorButton";
            this.newCompetitorButton.Size = new System.Drawing.Size(233, 54);
            this.newCompetitorButton.TabIndex = 21;
            this.newCompetitorButton.Text = "I am a new competitor";
            this.newCompetitorButton.UseVisualStyleBackColor = true;
            this.newCompetitorButton.Click += new System.EventHandler(this.newCompetitorButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(627, 374);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(119, 32);
            this.LoginButton.TabIndex = 22;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // CheckRunnerCompetedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.newCompetitorButton);
            this.Controls.Add(this.competedButton);
            this.Name = "CheckRunnerCompetedForm";
            this.Text = "CheckRunnerCompetedForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.footerPanel, 0);
            this.Controls.SetChildIndex(this.competedButton, 0);
            this.Controls.SetChildIndex(this.newCompetitorButton, 0);
            this.Controls.SetChildIndex(this.LoginButton, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button competedButton;
        private System.Windows.Forms.Button newCompetitorButton;
        private System.Windows.Forms.Button LoginButton;
    }
}