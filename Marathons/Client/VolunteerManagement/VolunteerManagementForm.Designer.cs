namespace Client.VolunteerManagement
{
    partial class VolunteerManagementForm:BaseForm.BaseForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sortByСomboBox = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.importVolunteersButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totalVolunteersLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(700, 65);
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
            this.footerPanel.Size = new System.Drawing.Size(700, 36);
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
            this.label1.Location = new System.Drawing.Point(220, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Volunteer management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(69, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sort and filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(493, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Import";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sort by:";
            // 
            // sortByСomboBox
            // 
            this.sortByСomboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByСomboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.sortByСomboBox.FormattingEnabled = true;
            this.sortByСomboBox.Location = new System.Drawing.Point(118, 162);
            this.sortByСomboBox.Name = "sortByСomboBox";
            this.sortByСomboBox.Size = new System.Drawing.Size(122, 35);
            this.sortByСomboBox.TabIndex = 24;
            this.sortByСomboBox.Text = "Last Name";
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.Location = new System.Drawing.Point(141, 203);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(98, 35);
            this.refreshButton.TabIndex = 25;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // importVolunteersButton
            // 
            this.importVolunteersButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importVolunteersButton.Location = new System.Drawing.Point(433, 157);
            this.importVolunteersButton.Name = "importVolunteersButton";
            this.importVolunteersButton.Size = new System.Drawing.Size(180, 35);
            this.importVolunteersButton.TabIndex = 26;
            this.importVolunteersButton.Text = "Import volunteers";
            this.importVolunteersButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(259, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Total volunteers:";
            // 
            // totalVolunteersLabel
            // 
            this.totalVolunteersLabel.AutoSize = true;
            this.totalVolunteersLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalVolunteersLabel.Location = new System.Drawing.Point(393, 247);
            this.totalVolunteersLabel.Name = "totalVolunteersLabel";
            this.totalVolunteersLabel.Size = new System.Drawing.Size(22, 24);
            this.totalVolunteersLabel.TabIndex = 28;
            this.totalVolunteersLabel.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(580, 139);
            this.dataGridView1.TabIndex = 29;
            // 
            // VolunteerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalVolunteersLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.importVolunteersButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.sortByСomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "VolunteerManagementForm";
            this.Text = "Marathon Skills 2015 - Volunteer Management";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.footerPanel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.sortByСomboBox, 0);
            this.Controls.SetChildIndex(this.refreshButton, 0);
            this.Controls.SetChildIndex(this.importVolunteersButton, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.totalVolunteersLabel, 0);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sortByСomboBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button importVolunteersButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalVolunteersLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}