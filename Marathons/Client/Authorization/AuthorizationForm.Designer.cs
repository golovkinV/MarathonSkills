namespace Client
{
    partial class AuthorizationForm : BaseForm.BaseForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.popupPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.headLabel = new System.Windows.Forms.Label();
            this.closePopupButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.logAsRunnerButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.popupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(668, 53);
            // 
            // backButton
            // 
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(0, 337);
            this.footerPanel.Size = new System.Drawing.Size(668, 29);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(231, 159);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(181, 20);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.Text = "evalyn.christian@hr.gov";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(231, 208);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(181, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "DqqSGUE2";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(231, 270);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(337, 270);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // popupPanel
            // 
            this.popupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popupPanel.Controls.Add(this.label1);
            this.popupPanel.Controls.Add(this.headLabel);
            this.popupPanel.Controls.Add(this.closePopupButton);
            this.popupPanel.Controls.Add(this.button3);
            this.popupPanel.Controls.Add(this.button2);
            this.popupPanel.Controls.Add(this.logAsRunnerButton);
            this.popupPanel.Location = new System.Drawing.Point(138, 79);
            this.popupPanel.Name = "popupPanel";
            this.popupPanel.Size = new System.Drawing.Size(400, 214);
            this.popupPanel.TabIndex = 20;
            this.popupPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Which type of user would you like to log in to the system as?\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.headLabel.Location = new System.Drawing.Point(87, 11);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(239, 25);
            this.headLabel.TabIndex = 4;
            this.headLabel.Text = "FOR TESTING ONLY!";
            // 
            // closePopupButton
            // 
            this.closePopupButton.BackColor = System.Drawing.Color.Transparent;
            this.closePopupButton.ForeColor = System.Drawing.Color.Red;
            this.closePopupButton.Location = new System.Drawing.Point(367, 3);
            this.closePopupButton.Name = "closePopupButton";
            this.closePopupButton.Size = new System.Drawing.Size(25, 23);
            this.closePopupButton.TabIndex = 3;
            this.closePopupButton.Text = "x";
            this.closePopupButton.UseVisualStyleBackColor = false;
            this.closePopupButton.Click += new System.EventHandler(this.closePopupButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Admin";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Coordinator";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // logAsRunnerButton
            // 
            this.logAsRunnerButton.Location = new System.Drawing.Point(158, 106);
            this.logAsRunnerButton.Name = "logAsRunnerButton";
            this.logAsRunnerButton.Size = new System.Drawing.Size(75, 23);
            this.logAsRunnerButton.TabIndex = 0;
            this.logAsRunnerButton.Text = "Runner";
            this.logAsRunnerButton.UseVisualStyleBackColor = true;
            this.logAsRunnerButton.Click += new System.EventHandler(this.logAsRunnerButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 366);
            this.Controls.Add(this.popupPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.Text = "Marathon Skills 2015 - Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthorizationForm_FormClosed);
            this.Controls.SetChildIndex(this.loginTextBox, 0);
            this.Controls.SetChildIndex(this.passwordTextBox, 0);
            this.Controls.SetChildIndex(this.loginButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.footerPanel, 0);
            this.Controls.SetChildIndex(this.popupPanel, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.popupPanel.ResumeLayout(false);
            this.popupPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel popupPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button logAsRunnerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Button closePopupButton;
    }
}

