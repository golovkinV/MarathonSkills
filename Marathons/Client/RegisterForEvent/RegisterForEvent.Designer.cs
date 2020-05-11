namespace Client.RegisterForEvent
{
    partial class RegisterForEvent : BaseForm.BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForEvent));
            this.additionalInfoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fullMarathon_checkBox = new System.Windows.Forms.CheckBox();
            this.halfMarathon_checkBox = new System.Windows.Forms.CheckBox();
            this.funRun_checkBox = new System.Windows.Forms.CheckBox();
            this.optionA = new System.Windows.Forms.RadioButton();
            this.optionB = new System.Windows.Forms.RadioButton();
            this.optionC = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.charityComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showCharityInfoButton = new System.Windows.Forms.Button();
            this.popupPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.closePopupButton = new System.Windows.Forms.Button();
            this.charityLogo = new System.Windows.Forms.PictureBox();
            this.nameCharityLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.popupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charityLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(800, 53);
            // 
            // backButton
            // 
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(0, 466);
            this.footerPanel.Size = new System.Drawing.Size(800, 29);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(713, 17);
            this.logoutButton.Visible = false;
            // 
            // additionalInfoLabel
            // 
            this.additionalInfoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.additionalInfoLabel.Location = new System.Drawing.Point(71, 106);
            this.additionalInfoLabel.Name = "additionalInfoLabel";
            this.additionalInfoLabel.Size = new System.Drawing.Size(657, 54);
            this.additionalInfoLabel.TabIndex = 21;
            this.additionalInfoLabel.Text = resources.GetString("additionalInfoLabel.Text");
            this.additionalInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(287, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Register for an event";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fullMarathon_checkBox
            // 
            this.fullMarathon_checkBox.AutoSize = true;
            this.fullMarathon_checkBox.Checked = true;
            this.fullMarathon_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fullMarathon_checkBox.Location = new System.Drawing.Point(124, 221);
            this.fullMarathon_checkBox.Name = "fullMarathon_checkBox";
            this.fullMarathon_checkBox.Size = new System.Drawing.Size(151, 17);
            this.fullMarathon_checkBox.TabIndex = 23;
            this.fullMarathon_checkBox.Text = "42km Full marathon ($145)";
            this.fullMarathon_checkBox.UseVisualStyleBackColor = true;
            this.fullMarathon_checkBox.CheckedChanged += new System.EventHandler(this.raceOptions_Changed);
            // 
            // halfMarathon_checkBox
            // 
            this.halfMarathon_checkBox.AutoSize = true;
            this.halfMarathon_checkBox.Location = new System.Drawing.Point(124, 246);
            this.halfMarathon_checkBox.Name = "halfMarathon_checkBox";
            this.halfMarathon_checkBox.Size = new System.Drawing.Size(148, 17);
            this.halfMarathon_checkBox.TabIndex = 24;
            this.halfMarathon_checkBox.Text = "21km Half marathon ($75)";
            this.halfMarathon_checkBox.UseVisualStyleBackColor = true;
            this.halfMarathon_checkBox.CheckedChanged += new System.EventHandler(this.raceOptions_Changed);
            // 
            // funRun_checkBox
            // 
            this.funRun_checkBox.AutoSize = true;
            this.funRun_checkBox.Location = new System.Drawing.Point(124, 272);
            this.funRun_checkBox.Name = "funRun_checkBox";
            this.funRun_checkBox.Size = new System.Drawing.Size(112, 17);
            this.funRun_checkBox.TabIndex = 25;
            this.funRun_checkBox.Text = "5km Fun run ($20)";
            this.funRun_checkBox.UseVisualStyleBackColor = true;
            this.funRun_checkBox.CheckedChanged += new System.EventHandler(this.raceOptions_Changed);
            // 
            // optionA
            // 
            this.optionA.AutoSize = true;
            this.optionA.Checked = true;
            this.optionA.Location = new System.Drawing.Point(446, 220);
            this.optionA.Name = "optionA";
            this.optionA.Size = new System.Drawing.Size(233, 17);
            this.optionA.TabIndex = 26;
            this.optionA.TabStop = true;
            this.optionA.Text = "Option A ($0): Runner\'s bib + RFID bracelet.";
            this.optionA.UseVisualStyleBackColor = true;
            this.optionA.Click += new System.EventHandler(this.raceOptions_Changed);
            // 
            // optionB
            // 
            this.optionB.AutoSize = true;
            this.optionB.Location = new System.Drawing.Point(446, 243);
            this.optionB.Name = "optionB";
            this.optionB.Size = new System.Drawing.Size(240, 17);
            this.optionB.TabIndex = 27;
            this.optionB.Text = "Option B ($20): Option A + hat + water bottle. ";
            this.optionB.UseVisualStyleBackColor = true;
            this.optionB.Click += new System.EventHandler(this.raceOptions_Changed);
            // 
            // optionC
            // 
            this.optionC.AutoSize = true;
            this.optionC.Location = new System.Drawing.Point(446, 267);
            this.optionC.Name = "optionC";
            this.optionC.Size = new System.Drawing.Size(270, 17);
            this.optionC.TabIndex = 28;
            this.optionC.Text = "Option C ($45): Option B + t-shirt + souvenir booklet.";
            this.optionC.UseVisualStyleBackColor = true;
            this.optionC.Click += new System.EventHandler(this.raceOptions_Changed);
            // 
            // charityComboBox
            // 
            this.charityComboBox.FormattingEnabled = true;
            this.charityComboBox.Location = new System.Drawing.Point(171, 340);
            this.charityComboBox.Name = "charityComboBox";
            this.charityComboBox.Size = new System.Drawing.Size(160, 21);
            this.charityComboBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(104, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Competition events";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(470, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Race kit options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(104, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Sponsorship details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label5.Location = new System.Drawing.Point(497, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Registration cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Charity:";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(121, 422);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 35;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(217, 422);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 36;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Target to raise:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.costLabel.Location = new System.Drawing.Point(553, 388);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(154, 32);
            this.costLabel.TabIndex = 38;
            this.costLabel.Text = "<$_COST>";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 385);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = "$500";
            // 
            // showCharityInfoButton
            // 
            this.showCharityInfoButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.showCharityInfoButton.Location = new System.Drawing.Point(346, 338);
            this.showCharityInfoButton.Name = "showCharityInfoButton";
            this.showCharityInfoButton.Size = new System.Drawing.Size(23, 23);
            this.showCharityInfoButton.TabIndex = 41;
            this.showCharityInfoButton.Text = "i";
            this.showCharityInfoButton.UseVisualStyleBackColor = true;
            this.showCharityInfoButton.Click += new System.EventHandler(this.showCharityInfoButton_Click);
            // 
            // popupPanel
            // 
            this.popupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popupPanel.Controls.Add(this.descriptionLabel);
            this.popupPanel.Controls.Add(this.closePopupButton);
            this.popupPanel.Controls.Add(this.charityLogo);
            this.popupPanel.Controls.Add(this.nameCharityLabel);
            this.popupPanel.Location = new System.Drawing.Point(121, 91);
            this.popupPanel.Name = "popupPanel";
            this.popupPanel.Size = new System.Drawing.Size(571, 341);
            this.popupPanel.TabIndex = 42;
            this.popupPanel.Visible = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(26, 175);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(522, 138);
            this.descriptionLabel.TabIndex = 24;
            this.descriptionLabel.Text = "<Description>";
            // 
            // closePopupButton
            // 
            this.closePopupButton.BackColor = System.Drawing.Color.Transparent;
            this.closePopupButton.ForeColor = System.Drawing.Color.Red;
            this.closePopupButton.Location = new System.Drawing.Point(541, 3);
            this.closePopupButton.Name = "closePopupButton";
            this.closePopupButton.Size = new System.Drawing.Size(25, 23);
            this.closePopupButton.TabIndex = 23;
            this.closePopupButton.Text = "x";
            this.closePopupButton.UseVisualStyleBackColor = false;
            this.closePopupButton.Click += new System.EventHandler(this.closePopupButton_Click);
            // 
            // charityLogo
            // 
            this.charityLogo.Location = new System.Drawing.Point(191, 49);
            this.charityLogo.Name = "charityLogo";
            this.charityLogo.Size = new System.Drawing.Size(194, 97);
            this.charityLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.charityLogo.TabIndex = 22;
            this.charityLogo.TabStop = false;
            // 
            // nameCharityLabel
            // 
            this.nameCharityLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCharityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.nameCharityLabel.Location = new System.Drawing.Point(36, 14);
            this.nameCharityLabel.Name = "nameCharityLabel";
            this.nameCharityLabel.Size = new System.Drawing.Size(486, 24);
            this.nameCharityLabel.TabIndex = 21;
            this.nameCharityLabel.Text = "<Name of the Charity>";
            this.nameCharityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.popupPanel);
            this.Controls.Add(this.showCharityInfoButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charityComboBox);
            this.Controls.Add(this.optionC);
            this.Controls.Add(this.optionB);
            this.Controls.Add(this.optionA);
            this.Controls.Add(this.funRun_checkBox);
            this.Controls.Add(this.halfMarathon_checkBox);
            this.Controls.Add(this.fullMarathon_checkBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.additionalInfoLabel);
            this.Controls.Add(this.label2);
            this.Name = "RegisterForEvent";
            this.Text = "Marathon Skills 2015 - Register for an event";
            this.Load += new System.EventHandler(this.RegisterForEvent_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.additionalInfoLabel, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.fullMarathon_checkBox, 0);
            this.Controls.SetChildIndex(this.halfMarathon_checkBox, 0);
            this.Controls.SetChildIndex(this.funRun_checkBox, 0);
            this.Controls.SetChildIndex(this.optionA, 0);
            this.Controls.SetChildIndex(this.optionB, 0);
            this.Controls.SetChildIndex(this.optionC, 0);
            this.Controls.SetChildIndex(this.charityComboBox, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.footerPanel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.registerButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.costLabel, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.showCharityInfoButton, 0);
            this.Controls.SetChildIndex(this.popupPanel, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.popupPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charityLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label additionalInfoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox fullMarathon_checkBox;
        private System.Windows.Forms.CheckBox halfMarathon_checkBox;
        private System.Windows.Forms.CheckBox funRun_checkBox;
        private System.Windows.Forms.RadioButton optionA;
        private System.Windows.Forms.RadioButton optionB;
        private System.Windows.Forms.RadioButton optionC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox charityComboBox;
        private System.Windows.Forms.Button showCharityInfoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel popupPanel;
        private System.Windows.Forms.Label nameCharityLabel;
        private System.Windows.Forms.PictureBox charityLogo;
        private System.Windows.Forms.Button closePopupButton;
        private System.Windows.Forms.Label descriptionLabel;
    }
}