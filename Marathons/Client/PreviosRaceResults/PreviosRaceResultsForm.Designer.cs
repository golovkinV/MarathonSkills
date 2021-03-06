﻿namespace Client.PreviosRaceResults
{
    partial class PreviosRaceResultsForm:BaseForm.BaseForm
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
            this.previosRaceResultsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.marathonComboBox = new System.Windows.Forms.ComboBox();
            this.raceEventComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ageCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totalRunnersLabel = new System.Windows.Forms.Label();
            this.totalRunnersFinishedLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.averageRaceTimeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.previosRaceResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previosRaceResultsDataGridView)).BeginInit();
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
            this.footerPanel.Location = new System.Drawing.Point(0, 621);
            this.footerPanel.Size = new System.Drawing.Size(1100, 54);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // previosRaceResultsLabel
            // 
            this.previosRaceResultsLabel.AutoSize = true;
            this.previosRaceResultsLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previosRaceResultsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.previosRaceResultsLabel.Location = new System.Drawing.Point(368, 130);
            this.previosRaceResultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.previosRaceResultsLabel.Name = "previosRaceResultsLabel";
            this.previosRaceResultsLabel.Size = new System.Drawing.Size(325, 38);
            this.previosRaceResultsLabel.TabIndex = 20;
            this.previosRaceResultsLabel.Text = "Previos Race Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(95, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Marathon:";
            // 
            // marathonComboBox
            // 
            this.marathonComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marathonComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.marathonComboBox.FormattingEnabled = true;
            this.marathonComboBox.Location = new System.Drawing.Point(216, 208);
            this.marathonComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.marathonComboBox.Name = "marathonComboBox";
            this.marathonComboBox.Size = new System.Drawing.Size(230, 35);
            this.marathonComboBox.TabIndex = 22;
            this.marathonComboBox.Text = "2014 - Japan";
            // 
            // raceEventComboBox
            // 
            this.raceEventComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.raceEventComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.raceEventComboBox.FormattingEnabled = true;
            this.raceEventComboBox.Location = new System.Drawing.Point(216, 274);
            this.raceEventComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.raceEventComboBox.Name = "raceEventComboBox";
            this.raceEventComboBox.Size = new System.Drawing.Size(230, 35);
            this.raceEventComboBox.TabIndex = 24;
            this.raceEventComboBox.Text = "42km Full Marathon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(77, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Race event:";
            // 
            // ageCategoryComboBox
            // 
            this.ageCategoryComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageCategoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.ageCategoryComboBox.FormattingEnabled = true;
            this.ageCategoryComboBox.Location = new System.Drawing.Point(645, 274);
            this.ageCategoryComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ageCategoryComboBox.Name = "ageCategoryComboBox";
            this.ageCategoryComboBox.Size = new System.Drawing.Size(230, 35);
            this.ageCategoryComboBox.TabIndex = 28;
            this.ageCategoryComboBox.Text = "18-29";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(483, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Age category:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(645, 208);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(230, 35);
            this.genderComboBox.TabIndex = 26;
            this.genderComboBox.Text = "Any";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(543, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Gender:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(920, 274);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(109, 42);
            this.searchButton.TabIndex = 29;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(103, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total runners:";
            // 
            // totalRunnersLabel
            // 
            this.totalRunnersLabel.AutoSize = true;
            this.totalRunnersLabel.Location = new System.Drawing.Point(264, 358);
            this.totalRunnersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalRunnersLabel.Name = "totalRunnersLabel";
            this.totalRunnersLabel.Size = new System.Drawing.Size(23, 25);
            this.totalRunnersLabel.TabIndex = 31;
            this.totalRunnersLabel.Text = "0";
            // 
            // totalRunnersFinishedLabel
            // 
            this.totalRunnersFinishedLabel.AutoSize = true;
            this.totalRunnersFinishedLabel.Location = new System.Drawing.Point(615, 358);
            this.totalRunnersFinishedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalRunnersFinishedLabel.Name = "totalRunnersFinishedLabel";
            this.totalRunnersFinishedLabel.Size = new System.Drawing.Size(23, 25);
            this.totalRunnersFinishedLabel.TabIndex = 33;
            this.totalRunnersFinishedLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(371, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Total runners finished:";
            // 
            // averageRaceTimeLabel
            // 
            this.averageRaceTimeLabel.AutoSize = true;
            this.averageRaceTimeLabel.Location = new System.Drawing.Point(902, 358);
            this.averageRaceTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageRaceTimeLabel.Name = "averageRaceTimeLabel";
            this.averageRaceTimeLabel.Size = new System.Drawing.Size(114, 25);
            this.averageRaceTimeLabel.TabIndex = 35;
            this.averageRaceTimeLabel.Text = "0h 00m 00s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(694, 358);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 24);
            this.label9.TabIndex = 34;
            this.label9.Text = "Average race time:";
            // 
            // previosRaceResultsDataGridView
            // 
            this.previosRaceResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previosRaceResultsDataGridView.Location = new System.Drawing.Point(91, 412);
            this.previosRaceResultsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.previosRaceResultsDataGridView.Name = "previosRaceResultsDataGridView";
            this.previosRaceResultsDataGridView.RowHeadersWidth = 51;
            this.previosRaceResultsDataGridView.RowTemplate.Height = 24;
            this.previosRaceResultsDataGridView.Size = new System.Drawing.Size(936, 182);
            this.previosRaceResultsDataGridView.TabIndex = 36;
            // 
            // PreviosRaceResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.previosRaceResultsDataGridView);
            this.Controls.Add(this.averageRaceTimeLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalRunnersFinishedLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalRunnersLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.ageCategoryComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.raceEventComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.marathonComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previosRaceResultsLabel);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "PreviosRaceResultsForm";
            this.Text = "Marathon Skills 2015 - Previos Race Results";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.footerPanel, 0);
            this.Controls.SetChildIndex(this.previosRaceResultsLabel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.marathonComboBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.raceEventComboBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.genderComboBox, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ageCategoryComboBox, 0);
            this.Controls.SetChildIndex(this.searchButton, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.totalRunnersLabel, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.totalRunnersFinishedLabel, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.averageRaceTimeLabel, 0);
            this.Controls.SetChildIndex(this.previosRaceResultsDataGridView, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previosRaceResultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label previosRaceResultsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox marathonComboBox;
        private System.Windows.Forms.ComboBox raceEventComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ageCategoryComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalRunnersLabel;
        private System.Windows.Forms.Label totalRunnersFinishedLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label averageRaceTimeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView previosRaceResultsDataGridView;
    }
}