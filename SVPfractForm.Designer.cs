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
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.domTextBox = new System.Windows.Forms.TextBox();
            this.DailyLabel = new System.Windows.Forms.LinkLabel();
            this.nightStdDevlabel = new System.Windows.Forms.Label();
            this.labelmaxStdDev = new System.Windows.Forms.Label();
            this.minStdDevlabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maxLaglabel = new System.Windows.Forms.Label();
            this.nightCoeflabel1 = new System.Windows.Forms.Label();
            this.minLaglabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OptimiseLabel = new System.Windows.Forms.LinkLabel();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.latTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.TemprPage.Controls.Add(this.DownButton);
            this.TemprPage.Controls.Add(this.UpButton);
            this.TemprPage.Controls.Add(this.label11);
            this.TemprPage.Controls.Add(this.domTextBox);
            this.TemprPage.Controls.Add(this.DailyLabel);
            this.TemprPage.Controls.Add(this.nightStdDevlabel);
            this.TemprPage.Controls.Add(this.labelmaxStdDev);
            this.TemprPage.Controls.Add(this.minStdDevlabel);
            this.TemprPage.Controls.Add(this.label10);
            this.TemprPage.Controls.Add(this.maxLaglabel);
            this.TemprPage.Controls.Add(this.nightCoeflabel1);
            this.TemprPage.Controls.Add(this.minLaglabel);
            this.TemprPage.Controls.Add(this.label9);
            this.TemprPage.Controls.Add(this.label8);
            this.TemprPage.Controls.Add(this.label7);
            this.TemprPage.Controls.Add(this.label5);
            this.TemprPage.Controls.Add(this.OptimiseLabel);
            this.TemprPage.Controls.Add(this.temperatureChart);
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
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(23, 374);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(51, 23);
            this.DownButton.TabIndex = 56;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(140, 374);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(51, 23);
            this.UpButton.TabIndex = 55;
            this.UpButton.Text = "UP";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Day of the Month";
            // 
            // domTextBox
            // 
            this.domTextBox.Location = new System.Drawing.Point(92, 375);
            this.domTextBox.Name = "domTextBox";
            this.domTextBox.Size = new System.Drawing.Size(30, 22);
            this.domTextBox.TabIndex = 53;
            this.domTextBox.Text = "1";
            this.domTextBox.TextChanged += new System.EventHandler(this.domTextBox_TextChanged);
            // 
            // DailyLabel
            // 
            this.DailyLabel.AutoSize = true;
            this.DailyLabel.Location = new System.Drawing.Point(20, 319);
            this.DailyLabel.Name = "DailyLabel";
            this.DailyLabel.Size = new System.Drawing.Size(69, 16);
            this.DailyLabel.TabIndex = 52;
            this.DailyLabel.TabStop = true;
            this.DailyLabel.Text = "View Daily";
            this.DailyLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DailyLabel_LinkClicked);
            // 
            // nightStdDevlabel
            // 
            this.nightStdDevlabel.AutoSize = true;
            this.nightStdDevlabel.Location = new System.Drawing.Point(333, 256);
            this.nightStdDevlabel.Name = "nightStdDevlabel";
            this.nightStdDevlabel.Size = new System.Drawing.Size(36, 16);
            this.nightStdDevlabel.TabIndex = 51;
            this.nightStdDevlabel.Text = "night";
            // 
            // labelmaxStdDev
            // 
            this.labelmaxStdDev.AutoSize = true;
            this.labelmaxStdDev.Location = new System.Drawing.Point(333, 229);
            this.labelmaxStdDev.Name = "labelmaxStdDev";
            this.labelmaxStdDev.Size = new System.Drawing.Size(33, 16);
            this.labelmaxStdDev.TabIndex = 50;
            this.labelmaxStdDev.Text = "max";
            // 
            // minStdDevlabel
            // 
            this.minStdDevlabel.AutoSize = true;
            this.minStdDevlabel.Location = new System.Drawing.Point(333, 201);
            this.minStdDevlabel.Name = "minStdDevlabel";
            this.minStdDevlabel.Size = new System.Drawing.Size(29, 16);
            this.minStdDevlabel.TabIndex = 49;
            this.minStdDevlabel.Text = "min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "StdDev";
            // 
            // maxLaglabel
            // 
            this.maxLaglabel.AutoSize = true;
            this.maxLaglabel.Location = new System.Drawing.Point(273, 229);
            this.maxLaglabel.Name = "maxLaglabel";
            this.maxLaglabel.Size = new System.Drawing.Size(33, 16);
            this.maxLaglabel.TabIndex = 47;
            this.maxLaglabel.Text = "max";
            // 
            // nightCoeflabel1
            // 
            this.nightCoeflabel1.AutoSize = true;
            this.nightCoeflabel1.Location = new System.Drawing.Point(273, 256);
            this.nightCoeflabel1.Name = "nightCoeflabel1";
            this.nightCoeflabel1.Size = new System.Drawing.Size(36, 16);
            this.nightCoeflabel1.TabIndex = 46;
            this.nightCoeflabel1.Text = "night";
            // 
            // minLaglabel
            // 
            this.minLaglabel.AutoSize = true;
            this.minLaglabel.Location = new System.Drawing.Point(273, 201);
            this.minLaglabel.Name = "minLaglabel";
            this.minLaglabel.Size = new System.Drawing.Size(29, 16);
            this.minLaglabel.TabIndex = 45;
            this.minLaglabel.Text = "min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Coef for night time temperature decrease:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Max temperature after noon lag (hr):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Min temperature after sunrise lag (hr):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Optimised Values";
            // 
            // OptimiseLabel
            // 
            this.OptimiseLabel.AutoSize = true;
            this.OptimiseLabel.Location = new System.Drawing.Point(20, 92);
            this.OptimiseLabel.Name = "OptimiseLabel";
            this.OptimiseLabel.Size = new System.Drawing.Size(133, 16);
            this.OptimiseLabel.TabIndex = 40;
            this.OptimiseLabel.TabStop = true;
            this.OptimiseLabel.Text = "Calculate Parameters";
            this.OptimiseLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OptimiseLabel_LinkClicked);
            // 
            // temperatureChart
            // 
            chartArea2.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea2.AxisX.Maximum = 25D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Hour of the Day";
            chartArea2.AxisY.Title = "Temperature (°C)";
            chartArea2.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea2);
            this.temperatureChart.ContextMenuStrip = this.graphMenu;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.temperatureChart.Legends.Add(legend2);
            this.temperatureChart.Location = new System.Drawing.Point(402, 3);
            this.temperatureChart.Name = "temperatureChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Wheat;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.temperatureChart.Series.Add(series4);
            this.temperatureChart.Size = new System.Drawing.Size(913, 629);
            this.temperatureChart.TabIndex = 39;
            this.temperatureChart.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Hourly Temperatures";
            title4.Name = "Title2";
            this.temperatureChart.Titles.Add(title3);
            this.temperatureChart.Titles.Add(title4);
            // 
            // latTextBox
            // 
            this.latTextBox.Location = new System.Drawing.Point(163, 34);
            this.latTextBox.Name = "latTextBox";
            this.latTextBox.Size = new System.Drawing.Size(76, 22);
            this.latTextBox.TabIndex = 24;
            this.latTextBox.Text = "-33.775";
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
        private System.Windows.Forms.TextBox latTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private System.Windows.Forms.LinkLabel OptimiseLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label maxLaglabel;
        private System.Windows.Forms.Label nightCoeflabel1;
        private System.Windows.Forms.Label minLaglabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nightStdDevlabel;
        private System.Windows.Forms.Label labelmaxStdDev;
        private System.Windows.Forms.Label minStdDevlabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel DailyLabel;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox domTextBox;
    }
}

