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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.charityComboBox = new System.Windows.Forms.ComboBox();
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
            // additionalInfoLabel
            // 
            this.additionalInfoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.additionalInfoLabel.Location = new System.Drawing.Point(71, 123);
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
            this.label2.Location = new System.Drawing.Point(287, 81);
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
            this.fullMarathon_checkBox.Location = new System.Drawing.Point(157, 221);
            this.fullMarathon_checkBox.Name = "fullMarathon_checkBox";
            this.fullMarathon_checkBox.Size = new System.Drawing.Size(151, 17);
            this.fullMarathon_checkBox.TabIndex = 23;
            this.fullMarathon_checkBox.Text = "42km Full marathon ($145)";
            this.fullMarathon_checkBox.UseVisualStyleBackColor = true;
            // 
            // halfMarathon_checkBox
            // 
            this.halfMarathon_checkBox.AutoSize = true;
            this.halfMarathon_checkBox.Location = new System.Drawing.Point(157, 246);
            this.halfMarathon_checkBox.Name = "halfMarathon_checkBox";
            this.halfMarathon_checkBox.Size = new System.Drawing.Size(148, 17);
            this.halfMarathon_checkBox.TabIndex = 24;
            this.halfMarathon_checkBox.Text = "21km Half marathon ($75)";
            this.halfMarathon_checkBox.UseVisualStyleBackColor = true;
            // 
            // funRun_checkBox
            // 
            this.funRun_checkBox.AutoSize = true;
            this.funRun_checkBox.Location = new System.Drawing.Point(157, 272);
            this.funRun_checkBox.Name = "funRun_checkBox";
            this.funRun_checkBox.Size = new System.Drawing.Size(112, 17);
            this.funRun_checkBox.TabIndex = 25;
            this.funRun_checkBox.Text = "5km Fun run ($20)";
            this.funRun_checkBox.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(498, 230);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(498, 253);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(498, 276);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // charityComboBox
            // 
            this.charityComboBox.FormattingEnabled = true;
            this.charityComboBox.Location = new System.Drawing.Point(157, 325);
            this.charityComboBox.Name = "charityComboBox";
            this.charityComboBox.Size = new System.Drawing.Size(121, 21);
            this.charityComboBox.TabIndex = 29;
            // 
            // RegisterForEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.charityComboBox);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.funRun_checkBox);
            this.Controls.Add(this.halfMarathon_checkBox);
            this.Controls.Add(this.fullMarathon_checkBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.additionalInfoLabel);
            this.Controls.Add(this.label2);
            this.Name = "RegisterForEvent";
            this.Text = "RegisterForEvent";
            this.Load += new System.EventHandler(this.RegisterForEvent_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.additionalInfoLabel, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.fullMarathon_checkBox, 0);
            this.Controls.SetChildIndex(this.halfMarathon_checkBox, 0);
            this.Controls.SetChildIndex(this.funRun_checkBox, 0);
            this.Controls.SetChildIndex(this.radioButton1, 0);
            this.Controls.SetChildIndex(this.radioButton2, 0);
            this.Controls.SetChildIndex(this.radioButton3, 0);
            this.Controls.SetChildIndex(this.charityComboBox, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.footerPanel, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox charityComboBox;
    }
}