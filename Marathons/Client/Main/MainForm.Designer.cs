namespace Client.MainForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.wantRunnerButton = new System.Windows.Forms.Button();
            this.wantSponsorButton = new System.Windows.Forms.Button();
            this.wantFindMoreButton = new System.Windows.Forms.Button();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.headerPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.headerPanel.Controls.Add(this.dateLabel);
            this.headerPanel.Controls.Add(this.locationLabel);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(832, 137);
            this.headerPanel.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dateLabel.Location = new System.Drawing.Point(269, 97);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(280, 25);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Saturday September 5 2015";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.locationLabel.Location = new System.Drawing.Point(315, 69);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(177, 25);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Sao Paulo, Brazil";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(213, 19);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(426, 38);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "MARATHON SKILLS 2015";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(725, 373);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(95, 33);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // wantRunnerButton
            // 
            this.wantRunnerButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wantRunnerButton.Location = new System.Drawing.Point(289, 176);
            this.wantRunnerButton.Name = "wantRunnerButton";
            this.wantRunnerButton.Size = new System.Drawing.Size(256, 49);
            this.wantRunnerButton.TabIndex = 2;
            this.wantRunnerButton.Text = "I want to be a runner";
            this.wantRunnerButton.UseVisualStyleBackColor = true;
            this.wantRunnerButton.Click += new System.EventHandler(this.wantRunnerButton_Click);
            // 
            // wantSponsorButton
            // 
            this.wantSponsorButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wantSponsorButton.Location = new System.Drawing.Point(289, 245);
            this.wantSponsorButton.Name = "wantSponsorButton";
            this.wantSponsorButton.Size = new System.Drawing.Size(256, 49);
            this.wantSponsorButton.TabIndex = 3;
            this.wantSponsorButton.Text = "I want to sponsor a runner";
            this.wantSponsorButton.UseVisualStyleBackColor = true;
            this.wantSponsorButton.Click += new System.EventHandler(this.wantSponsorButton_Click);
            // 
            // wantFindMoreButton
            // 
            this.wantFindMoreButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wantFindMoreButton.Location = new System.Drawing.Point(289, 313);
            this.wantFindMoreButton.Name = "wantFindMoreButton";
            this.wantFindMoreButton.Size = new System.Drawing.Size(256, 49);
            this.wantFindMoreButton.TabIndex = 4;
            this.wantFindMoreButton.Text = "I want to find out more";
            this.wantFindMoreButton.UseVisualStyleBackColor = true;
            this.wantFindMoreButton.Click += new System.EventHandler(this.wantFindMoreButton_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.footerPanel.Controls.Add(this.timerLabel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 423);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(832, 29);
            this.footerPanel.TabIndex = 5;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(252, 7);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(40, 16);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "Timer";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 452);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.wantFindMoreButton);
            this.Controls.Add(this.wantSponsorButton);
            this.Controls.Add(this.wantRunnerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.headerPanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2015";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button wantRunnerButton;
        private System.Windows.Forms.Button wantSponsorButton;
        private System.Windows.Forms.Button wantFindMoreButton;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
    }
}