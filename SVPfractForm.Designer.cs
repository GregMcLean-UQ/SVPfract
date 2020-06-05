namespace SVPfract
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 4D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPVfractForm));
            this.label1 = new System.Windows.Forms.Label();
            this.MetFileLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MetFileNameLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CalcLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.minRadnTextBox = new System.Windows.Forms.TextBox();
            this.spvFractLabel = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromMonth = new System.Windows.Forms.ComboBox();
            this.toMonth = new System.Windows.Forms.ComboBox();
            this.saveDataFile = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.SVPPage = new System.Windows.Forms.TabPage();
            this.TemprPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.graphMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SVPPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate SVPfract using hourly Temperature and Humidity";
            // 
            // MetFileLinkLabel
            // 
            this.MetFileLinkLabel.AutoSize = true;
            this.MetFileLinkLabel.Location = new System.Drawing.Point(39, 65);
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
            this.MetFileNameLabel.Location = new System.Drawing.Point(205, 65);
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
            this.label2.Location = new System.Drawing.Point(26, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minimum Radiation";
            // 
            // minRadnTextBox
            // 
            this.minRadnTextBox.Location = new System.Drawing.Point(195, 13);
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
            // chart
            // 
            textAnnotation1.AnchorDataPointName = "One2One\\r1";
            textAnnotation1.AnchorOffsetX = 50D;
            textAnnotation1.AnchorOffsetY = 60D;
            textAnnotation1.AnchorX = 0D;
            textAnnotation1.AnchorY = 0D;
            textAnnotation1.Name = "Regression";
            textAnnotation1.Text = ".";
            this.chart.Annotations.Add(textAnnotation1);
            chartArea1.AxisX.Maximum = 4D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Mean Daytime VPD (kPa)";
            chartArea1.AxisY.Maximum = 4D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Predicted VPD  (kPa)";
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.ContextMenuStrip = this.graphMenu;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(301, 90);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Data";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.Name = "Regression";
            series3.BorderColor = System.Drawing.Color.Black;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "One2One";
            series3.Points.Add(dataPoint1);
            series3.Points.Add(dataPoint2);
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(514, 532);
            this.chart.TabIndex = 7;
            this.chart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "VPD";
            title2.Name = "Title2";
            this.chart.Titles.Add(title1);
            this.chart.Titles.Add(title2);
            // 
            // graphMenu
            // 
            this.graphMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyItem,
            this.saveToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exportDataToolStripMenuItem1});
            this.graphMenu.Name = "graphMenu";
            this.graphMenu.Size = new System.Drawing.Size(172, 114);
            // 
            // copyItem
            // 
            this.copyItem.Name = "copyItem";
            this.copyItem.Size = new System.Drawing.Size(171, 22);
            this.copyItem.Text = "Copy to Clipboard";
            this.copyItem.Click += new System.EventHandler(this.copyItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exportDataToolStripMenuItem1
            // 
            this.exportDataToolStripMenuItem1.Name = "exportDataToolStripMenuItem1";
            this.exportDataToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.exportDataToolStripMenuItem1.Text = "Export Data";
            this.exportDataToolStripMenuItem1.Click += new System.EventHandler(this.exportDataToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "From Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "To Month";
            // 
            // fromMonth
            // 
            this.fromMonth.FormattingEnabled = true;
            this.fromMonth.Location = new System.Drawing.Point(137, 46);
            this.fromMonth.Name = "fromMonth";
            this.fromMonth.Size = new System.Drawing.Size(121, 24);
            this.fromMonth.TabIndex = 10;
            // 
            // toMonth
            // 
            this.toMonth.FormattingEnabled = true;
            this.toMonth.Location = new System.Drawing.Point(137, 73);
            this.toMonth.Name = "toMonth";
            this.toMonth.Size = new System.Drawing.Size(121, 24);
            this.toMonth.TabIndex = 11;
            // 
            // saveDataFile
            // 
            this.saveDataFile.DefaultExt = "csv";
            this.saveDataFile.Filter = "CSV File (*.csv)|*.csv";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MetFileLinkLabel);
            this.panel1.Controls.Add(this.MetFileNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 106);
            this.panel1.TabIndex = 12;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.SVPPage);
            this.tabControl.Controls.Add(this.TemprPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 106);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1326, 683);
            this.tabControl.TabIndex = 13;
            // 
            // SVPPage
            // 
            this.SVPPage.Controls.Add(this.label2);
            this.SVPPage.Controls.Add(this.CalcLinkLabel);
            this.SVPPage.Controls.Add(this.minRadnTextBox);
            this.SVPPage.Controls.Add(this.chart);
            this.SVPPage.Controls.Add(this.toMonth);
            this.SVPPage.Controls.Add(this.spvFractLabel);
            this.SVPPage.Controls.Add(this.fromMonth);
            this.SVPPage.Controls.Add(this.label3);
            this.SVPPage.Controls.Add(this.label4);
            this.SVPPage.Location = new System.Drawing.Point(4, 25);
            this.SVPPage.Name = "SVPPage";
            this.SVPPage.Padding = new System.Windows.Forms.Padding(3);
            this.SVPPage.Size = new System.Drawing.Size(1318, 654);
            this.SVPPage.TabIndex = 0;
            this.SVPPage.Text = "SVP Fract";
            this.SVPPage.UseVisualStyleBackColor = true;
            // 
            // TemprPage
            // 
            this.TemprPage.Location = new System.Drawing.Point(4, 25);
            this.TemprPage.Name = "TemprPage";
            this.TemprPage.Padding = new System.Windows.Forms.Padding(3);
            this.TemprPage.Size = new System.Drawing.Size(1318, 654);
            this.TemprPage.TabIndex = 1;
            this.TemprPage.Text = "Diurnal Temperature";
            this.TemprPage.UseVisualStyleBackColor = true;
            // 
            // SPVfractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 789);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SPVfractForm";
            this.Text = "SVPfract";
            this.Load += new System.EventHandler(this.SPVfractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.graphMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.SVPPage.ResumeLayout(false);
            this.SVPPage.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fromMonth;
        private System.Windows.Forms.ComboBox toMonth;
        private System.Windows.Forms.ContextMenuStrip graphMenu;
        private System.Windows.Forms.ToolStripMenuItem copyItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveDataFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage SVPPage;
        private System.Windows.Forms.TabPage TemprPage;
    }
}

