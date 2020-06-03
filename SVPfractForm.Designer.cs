﻿namespace SVPfract
{
    partial class SPVfractForm
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
            this.MetFileLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MetFileNameLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CalcLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.minRadnTextBox = new System.Windows.Forms.TextBox();
            this.spvFractLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate SVPfract using hourly Temperature and Humidity";
            // 
            // MetFileLinkLabel
            // 
            this.MetFileLinkLabel.AutoSize = true;
            this.MetFileLinkLabel.Location = new System.Drawing.Point(26, 55);
            this.MetFileLinkLabel.Name = "MetFileLinkLabel";
            this.MetFileLinkLabel.Size = new System.Drawing.Size(137, 16);
            this.MetFileLinkLabel.TabIndex = 1;
            this.MetFileLinkLabel.TabStop = true;
            this.MetFileLinkLabel.Text = "Select Hourly Met File";
            this.MetFileLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MetFileLinkLabel_LinkClicked);
            // 
            // MetFileNameLabel
            // 
            this.MetFileNameLabel.AutoSize = true;
            this.MetFileNameLabel.Location = new System.Drawing.Point(192, 55);
            this.MetFileNameLabel.Name = "MetFileNameLabel";
            this.MetFileNameLabel.Size = new System.Drawing.Size(61, 16);
            this.MetFileNameLabel.TabIndex = 2;
            this.MetFileNameLabel.Text = "Filename";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "\"C:\\Pioneer\\SPVfract\\WoodlandHourly2019.csv\"";
            this.openFileDialog.Filter = "Met File (*.csv)|*.csv";
            // 
            // CalcLinkLabel
            // 
            this.CalcLinkLabel.AutoSize = true;
            this.CalcLinkLabel.Location = new System.Drawing.Point(26, 121);
            this.CalcLinkLabel.Name = "CalcLinkLabel";
            this.CalcLinkLabel.Size = new System.Drawing.Size(118, 16);
            this.CalcLinkLabel.TabIndex = 3;
            this.CalcLinkLabel.TabStop = true;
            this.CalcLinkLabel.Text = "Calculate SVPfract";
            this.CalcLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CalcLinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minimum Radiation";
            // 
            // minRadnTextBox
            // 
            this.minRadnTextBox.Location = new System.Drawing.Point(195, 86);
            this.minRadnTextBox.Name = "minRadnTextBox";
            this.minRadnTextBox.Size = new System.Drawing.Size(63, 22);
            this.minRadnTextBox.TabIndex = 5;
            this.minRadnTextBox.Text = "300";
            // 
            // spvFractLabel
            // 
            this.spvFractLabel.AutoSize = true;
            this.spvFractLabel.Location = new System.Drawing.Point(192, 121);
            this.spvFractLabel.Name = "spvFractLabel";
            this.spvFractLabel.Size = new System.Drawing.Size(60, 16);
            this.spvFractLabel.TabIndex = 6;
            this.spvFractLabel.Text = "SPVfract";
            // 
            // SPVfractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 789);
            this.Controls.Add(this.spvFractLabel);
            this.Controls.Add(this.minRadnTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalcLinkLabel);
            this.Controls.Add(this.MetFileNameLabel);
            this.Controls.Add(this.MetFileLinkLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SPVfractForm";
            this.Text = "SVPfract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel MetFileLinkLabel;
        private System.Windows.Forms.Label MetFileNameLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.LinkLabel CalcLinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minRadnTextBox;
        private System.Windows.Forms.Label spvFractLabel;
    }
}

