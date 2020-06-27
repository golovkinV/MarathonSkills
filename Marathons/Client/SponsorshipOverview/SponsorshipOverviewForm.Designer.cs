namespace Client.SponsorshipOverview
{
    partial class SponsorshipOverviewForm:BaseForm.BaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalAmountComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.charitiesLabel = new System.Windows.Forms.Label();
            this.totalSponsorshipLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(800, 65);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(18, 21);
            this.backButton.Size = new System.Drawing.Size(88, 28);
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Location = new System.Drawing.Point(120, 17);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(0, 414);
            this.footerPanel.Size = new System.Drawing.Size(800, 36);
            // 
            // timerLabel
            // 
            this.timerLabel.Location = new System.Drawing.Point(63, 9);
            this.timerLabel.Size = new System.Drawing.Size(661, 20);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(680, 21);
            this.logoutButton.Size = new System.Drawing.Size(88, 28);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(246, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sponsorship overview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sort by:";
            // 
            // totalAmountComboBox
            // 
            this.totalAmountComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.totalAmountComboBox.FormattingEnabled = true;
            this.totalAmountComboBox.Location = new System.Drawing.Point(275, 142);
            this.totalAmountComboBox.Name = "totalAmountComboBox";
            this.totalAmountComboBox.Size = new System.Drawing.Size(178, 29);
            this.totalAmountComboBox.TabIndex = 22;
            this.totalAmountComboBox.Text = "Total Amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(117, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Charities:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(351, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total Sponsorship:";
            // 
            // charitiesLabel
            // 
            this.charitiesLabel.AutoSize = true;
            this.charitiesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.charitiesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.charitiesLabel.Location = new System.Drawing.Point(216, 184);
            this.charitiesLabel.Name = "charitiesLabel";
            this.charitiesLabel.Size = new System.Drawing.Size(31, 32);
            this.charitiesLabel.TabIndex = 26;
            this.charitiesLabel.Text = "0";
            // 
            // totalSponsorshipLabel
            // 
            this.totalSponsorshipLabel.AutoSize = true;
            this.totalSponsorshipLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalSponsorshipLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.totalSponsorshipLabel.Location = new System.Drawing.Point(529, 184);
            this.totalSponsorshipLabel.Name = "totalSponsorshipLabel";
            this.totalSponsorshipLabel.Size = new System.Drawing.Size(47, 32);
            this.totalSponsorshipLabel.TabIndex = 27;
            this.totalSponsorshipLabel.Text = "$0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(660, 179);
            this.dataGridView1.TabIndex = 28;
            // 
            // SponsorshipOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalSponsorshipLabel);
            this.Controls.Add(this.charitiesLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalAmountComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SponsorshipOverviewForm";
            this.Text = "Marathon Skills 2015 - Sponsorship Overview";
            this.Load += new System.EventHandler(this.SponsorshipOverviewForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.footerPanel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.totalAmountComboBox, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.charitiesLabel, 0);
            this.Controls.SetChildIndex(this.totalSponsorshipLabel, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox totalAmountComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label charitiesLabel;
        private System.Windows.Forms.Label totalSponsorshipLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}