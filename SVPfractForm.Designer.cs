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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.ReChartLabel = new System.Windows.Forms.LinkLabel();
            this.minLagTextBox = new System.Windows.Forms.TextBox();
            this.nightCoefTextBox = new System.Windows.Forms.TextBox();
            this.maxLagTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.latTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.graphMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SVPPage.SuspendLayout();
            this.TemprPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
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
            this.MetFileNameLabel.Location = new System.Drawing.Point(39, 92);
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
            this.CalcLinkLabel.Location = new System.Drawing.Point(26, 56);
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
            this.spvFractLabel.Location = new System.Drawing.Point(192, 56);
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
            this.chart.Location = new System.Drawing.Point(302, 22);
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
            this.chart.Size = new System.Drawing.Size(630, 613);
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
            this.label3.Location = new System.Drawing.Point(416, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "From Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "To Month";
            // 
            // fromMonth
            // 
            this.fromMonth.FormattingEnabled = true;
            this.fromMonth.Location = new System.Drawing.Point(527, 62);
            this.fromMonth.Name = "fromMonth";
            this.fromMonth.Size = new System.Drawing.Size(121, 24);
            this.fromMonth.TabIndex = 10;
            this.fromMonth.SelectedIndexChanged += new System.EventHandler(this.IncludedMonth_SelectedIndexChanged);
            // 
            // toMonth
            // 
            this.toMonth.FormattingEnabled = true;
            this.toMonth.Location = new System.Drawing.Point(527, 89);
            this.toMonth.Name = "toMonth";
            this.toMonth.Size = new System.Drawing.Size(121, 24);
            this.toMonth.TabIndex = 11;
            this.toMonth.SelectedIndexChanged += new System.EventHandler(this.IncludedMonth_SelectedIndexChanged);
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
            this.panel1.Controls.Add(this.fromMonth);
            this.panel1.Controls.Add(this.toMonth);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 125);
            this.panel1.TabIndex = 12;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.SVPPage);
            this.tabControl.Controls.Add(this.TemprPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 125);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1326, 664);
            this.tabControl.TabIndex = 13;
            // 
            // SVPPage
            // 
            this.SVPPage.Controls.Add(this.label2);
            this.SVPPage.Controls.Add(this.CalcLinkLabel);
            this.SVPPage.Controls.Add(this.minRadnTextBox);
            this.SVPPage.Controls.Add(this.chart);
            this.SVPPage.Controls.Add(this.spvFractLabel);
            this.SVPPage.Location = new System.Drawing.Point(4, 25);
            this.SVPPage.Name = "SVPPage";
            this.SVPPage.Padding = new System.Windows.Forms.Padding(3);
            this.SVPPage.Size = new System.Drawing.Size(1318, 635);
            this.SVPPage.TabIndex = 0;
            this.SVPPage.Text = "SVP Fract";
            this.SVPPage.UseVisualStyleBackColor = true;
            // 
            // TemprPage
            // 
            this.TemprPage.Controls.Add(this.temperatureChart);
            this.TemprPage.Controls.Add(this.ReChartLabel);
            this.TemprPage.Controls.Add(this.minLagTextBox);
            this.TemprPage.Controls.Add(this.nightCoefTextBox);
            this.TemprPage.Controls.Add(this.maxLagTextBox);
            this.TemprPage.Controls.Add(this.textBox3);
            this.TemprPage.Controls.Add(this.textBox2);
            this.TemprPage.Controls.Add(this.textBox1);
            this.TemprPage.Controls.Add(this.latTextBox);
            this.TemprPage.Controls.Add(this.label6);
            this.TemprPage.Location = new System.Drawing.Point(4, 25);
            this.TemprPage.Name = "TemprPage";
            this.TemprPage.Padding = new System.Windows.Forms.Padding(3);
            this.TemprPage.Size = new System.Drawing.Size(1318, 635);
            this.TemprPage.TabIndex = 1;
            this.TemprPage.Text = "Diurnal Temperature";
            this.TemprPage.UseVisualStyleBackColor = true;
            // 
            // ReChartLabel
            // 
            this.ReChartLabel.AutoSize = true;
            this.ReChartLabel.Location = new System.Drawing.Point(21, 129);
            this.ReChartLabel.Name = "ReChartLabel";
            this.ReChartLabel.Size = new System.Drawing.Size(51, 16);
            this.ReChartLabel.TabIndex = 38;
            this.ReChartLabel.TabStop = true;
            this.ReChartLabel.Text = "Redraw";
            this.ReChartLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReChartLabel_LinkClicked);
            // 
            // minLagTextBox
            // 
            this.minLagTextBox.Location = new System.Drawing.Point(177, 389);
            this.minLagTextBox.Name = "minLagTextBox";
            this.minLagTextBox.Size = new System.Drawing.Size(62, 22);
            this.minLagTextBox.TabIndex = 34;
            this.minLagTextBox.Text = "1.0";
            // 
            // nightCoefTextBox
            // 
            this.nightCoefTextBox.Location = new System.Drawing.Point(177, 339);
            this.nightCoefTextBox.Name = "nightCoefTextBox";
            this.nightCoefTextBox.Size = new System.Drawing.Size(62, 22);
            this.nightCoefTextBox.TabIndex = 33;
            this.nightCoefTextBox.Text = "4.0";
            // 
            // maxLagTextBox
            // 
            this.maxLagTextBox.Location = new System.Drawing.Point(178, 293);
            this.maxLagTextBox.Name = "maxLagTextBox";
            this.maxLagTextBox.Size = new System.Drawing.Size(62, 22);
            this.maxLagTextBox.TabIndex = 32;
            this.maxLagTextBox.Text = "1.5";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 369);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(148, 42);
            this.textBox3.TabIndex = 31;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Min temperature after sunrise lag (hr)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 321);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(148, 40);
            this.textBox2.TabIndex = 30;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Coef for night time temperature decrease";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 276);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 39);
            this.textBox1.TabIndex = 29;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Max temperature after noon lag (hr)";
            // 
            // latTextBox
            // 
            this.latTextBox.Location = new System.Drawing.Point(163, 34);
            this.latTextBox.Name = "latTextBox";
            this.latTextBox.Size = new System.Drawing.Size(76, 22);
            this.latTextBox.TabIndex = 24;
            this.latTextBox.Text = "38.6785";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Latitude (°)";
            // 
            // temperatureChart
            // 
            chartArea2.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.temperatureChart.Legends.Add(legend2);
            this.temperatureChart.Location = new System.Drawing.Point(320, 3);
            this.temperatureChart.Name = "temperatureChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Wheat;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.temperatureChart.Series.Add(series4);
            this.temperatureChart.Size = new System.Drawing.Size(995, 629);
            this.temperatureChart.TabIndex = 39;
            this.temperatureChart.Text = "chart1";
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
            this.TemprPage.ResumeLayout(false);
            this.TemprPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
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
        private System.Windows.Forms.TextBox minLagTextBox;
        private System.Windows.Forms.TextBox nightCoefTextBox;
        private System.Windows.Forms.TextBox maxLagTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox latTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel ReChartLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
    }
}

