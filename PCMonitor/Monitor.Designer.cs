namespace PCMonitor
{
    partial class Monitor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.lbl_cpu = new MetroFramework.Controls.MetroLabel();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_ram = new MetroFramework.Controls.MetroLabel();
            this.progressbar_cpu = new MetroFramework.Controls.MetroProgressBar();
            this.progressbar_ram = new MetroFramework.Controls.MetroProgressBar();
            this.lbl_percentualCPU = new MetroFramework.Controls.MetroLabel();
            this.lbl_percentualRAM = new MetroFramework.Controls.MetroLabel();
            this.lbl_chart = new MetroFramework.Controls.MetroLabel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Tab = new MetroFramework.Controls.MetroTabControl();
            this.Computer = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.AboutMe = new MetroFramework.Controls.MetroTabPage();
            this.lbl_copyright = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.Tab.SuspendLayout();
            this.Computer.SuspendLayout();
            this.AboutMe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cpu
            // 
            this.lbl_cpu.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_cpu.Location = new System.Drawing.Point(9, 15);
            this.lbl_cpu.Name = "lbl_cpu";
            this.lbl_cpu.Size = new System.Drawing.Size(100, 20);
            this.lbl_cpu.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lbl_cpu.TabIndex = 0;
            this.lbl_cpu.Text = "Processador";
            this.lbl_cpu.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_ram
            // 
            this.lbl_ram.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_ram.Location = new System.Drawing.Point(9, 54);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(100, 20);
            this.lbl_ram.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lbl_ram.TabIndex = 1;
            this.lbl_ram.Text = "Memória RAM";
            this.lbl_ram.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // progressbar_cpu
            // 
            this.progressbar_cpu.Location = new System.Drawing.Point(115, 21);
            this.progressbar_cpu.Name = "progressbar_cpu";
            this.progressbar_cpu.Size = new System.Drawing.Size(575, 10);
            this.progressbar_cpu.Style = MetroFramework.MetroColorStyle.Yellow;
            this.progressbar_cpu.TabIndex = 2;
            this.progressbar_cpu.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // progressbar_ram
            // 
            this.progressbar_ram.Location = new System.Drawing.Point(115, 59);
            this.progressbar_ram.Name = "progressbar_ram";
            this.progressbar_ram.Size = new System.Drawing.Size(575, 10);
            this.progressbar_ram.Style = MetroFramework.MetroColorStyle.Yellow;
            this.progressbar_ram.TabIndex = 3;
            this.progressbar_ram.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_percentualCPU
            // 
            this.lbl_percentualCPU.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_percentualCPU.Location = new System.Drawing.Point(693, 15);
            this.lbl_percentualCPU.Name = "lbl_percentualCPU";
            this.lbl_percentualCPU.Size = new System.Drawing.Size(75, 20);
            this.lbl_percentualCPU.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lbl_percentualCPU.TabIndex = 4;
            this.lbl_percentualCPU.Text = "0%";
            this.lbl_percentualCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_percentualCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_percentualRAM
            // 
            this.lbl_percentualRAM.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_percentualRAM.Location = new System.Drawing.Point(693, 54);
            this.lbl_percentualRAM.Name = "lbl_percentualRAM";
            this.lbl_percentualRAM.Size = new System.Drawing.Size(75, 20);
            this.lbl_percentualRAM.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lbl_percentualRAM.TabIndex = 5;
            this.lbl_percentualRAM.Text = "0%";
            this.lbl_percentualRAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_percentualRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_chart
            // 
            this.lbl_chart.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_chart.Location = new System.Drawing.Point(9, 107);
            this.lbl_chart.Name = "lbl_chart";
            this.lbl_chart.Size = new System.Drawing.Size(200, 25);
            this.lbl_chart.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lbl_chart.TabIndex = 6;
            this.lbl_chart.Text = "Gráfico de Desempenho";
            this.lbl_chart.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chart.BorderlineColor = System.Drawing.Color.DarkGray;
            this.chart.BorderSkin.BorderColor = System.Drawing.Color.DarkGray;
            this.chart.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            chartArea1.BorderColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(-34, 137);
            this.chart.Name = "chart";
            series1.BorderColor = System.Drawing.Color.DarkGray;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "CPU";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.DarkGray;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "RAM";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(830, 250);
            this.chart.TabIndex = 8;
            this.chart.Text = "chart1";
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Computer);
            this.Tab.Controls.Add(this.AboutMe);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(15, 60);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(770, 420);
            this.Tab.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Tab.TabIndex = 9;
            this.Tab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tab.UseSelectable = true;
            // 
            // Computer
            // 
            this.Computer.Controls.Add(this.metroLabel1);
            this.Computer.Controls.Add(this.metroLabel2);
            this.Computer.Controls.Add(this.lbl_chart);
            this.Computer.Controls.Add(this.progressbar_ram);
            this.Computer.Controls.Add(this.progressbar_cpu);
            this.Computer.Controls.Add(this.lbl_cpu);
            this.Computer.Controls.Add(this.lbl_percentualRAM);
            this.Computer.Controls.Add(this.lbl_ram);
            this.Computer.Controls.Add(this.lbl_percentualCPU);
            this.Computer.Controls.Add(this.chart);
            this.Computer.HorizontalScrollbarBarColor = true;
            this.Computer.HorizontalScrollbarHighlightOnWheel = false;
            this.Computer.HorizontalScrollbarSize = 6;
            this.Computer.Location = new System.Drawing.Point(4, 38);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(762, 378);
            this.Computer.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Computer.TabIndex = 0;
            this.Computer.Text = "Computer Info";
            this.Computer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Computer.VerticalScrollbarBarColor = true;
            this.Computer.VerticalScrollbarHighlightOnWheel = false;
            this.Computer.VerticalScrollbarSize = 8;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.metroLabel1.Location = new System.Drawing.Point(660, 126);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "CPU";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(715, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "RAM";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // AboutMe
            // 
            this.AboutMe.Controls.Add(this.lbl_copyright);
            this.AboutMe.HorizontalScrollbarBarColor = true;
            this.AboutMe.HorizontalScrollbarHighlightOnWheel = false;
            this.AboutMe.HorizontalScrollbarSize = 6;
            this.AboutMe.Location = new System.Drawing.Point(4, 38);
            this.AboutMe.Name = "AboutMe";
            this.AboutMe.Size = new System.Drawing.Size(762, 378);
            this.AboutMe.Style = MetroFramework.MetroColorStyle.Yellow;
            this.AboutMe.TabIndex = 1;
            this.AboutMe.Text = "About Me";
            this.AboutMe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AboutMe.VerticalScrollbarBarColor = true;
            this.AboutMe.VerticalScrollbarHighlightOnWheel = false;
            this.AboutMe.VerticalScrollbarSize = 8;
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_copyright.Location = new System.Drawing.Point(9, 20);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(739, 200);
            this.lbl_copyright.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lbl_copyright.TabIndex = 2;
            this.lbl_copyright.Text = resources.GetString("lbl_copyright.Text");
            this.lbl_copyright.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Tab);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Monitor";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 20);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "PC Monitor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.Tab.ResumeLayout(false);
            this.Computer.ResumeLayout(false);
            this.AboutMe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_cpu;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel lbl_ram;
        private MetroFramework.Controls.MetroProgressBar progressbar_cpu;
        private MetroFramework.Controls.MetroProgressBar progressbar_ram;
        private MetroFramework.Controls.MetroLabel lbl_percentualCPU;
        private MetroFramework.Controls.MetroLabel lbl_percentualRAM;
        private MetroFramework.Controls.MetroLabel lbl_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private MetroFramework.Controls.MetroTabControl Tab;
        private MetroFramework.Controls.MetroTabPage Computer;
        private MetroFramework.Controls.MetroTabPage AboutMe;
        private MetroFramework.Controls.MetroLabel lbl_copyright;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

