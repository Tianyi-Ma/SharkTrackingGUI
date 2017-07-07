namespace SharkTrackingGUI
{
    partial class GUIFormView
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

        private void InitializeChart()
        {
            // Set the chart area
            this.TrackPlot.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "#.##";
            this.TrackPlot.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            this.TrackPlot.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            // Add series
            this.TrackPlot.Series.Add("Shark").YValueMembers = "Shark";
            this.TrackPlot.Series["Shark"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            this.TrackPlot.Series["Shark"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.TrackPlot.Series["Shark"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            TrackPlot.Series["Shark"].MarkerColor = System.Drawing.Color.Blue;
            TrackPlot.Series["Shark"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;

            TrackPlot.Series.Add("SharkRecent").YValueMembers = "SharkRecent";
            TrackPlot.Series["SharkRecent"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            TrackPlot.Series["SharkRecent"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            TrackPlot.Series["SharkRecent"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            TrackPlot.Series["SharkRecent"].MarkerColor = System.Drawing.Color.Purple;
            TrackPlot.Series["SharkRecent"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            TrackPlot.Series["SharkRecent"].MarkerSize = 8;

            this.TrackPlot.Series.Add("AUV").YValueMembers = "AUV";
            this.TrackPlot.Series["AUV"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            this.TrackPlot.Series["AUV"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.TrackPlot.Series["AUV"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            TrackPlot.Series["AUV"].MarkerColor = System.Drawing.Color.Orange;
            TrackPlot.Series["AUV"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;

            TrackPlot.Series.Add("AUVRecent").YValueMembers = "AUVRecent";
            TrackPlot.Series["AUVRecent"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            TrackPlot.Series["AUVRecent"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            TrackPlot.Series["AUVRecent"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            TrackPlot.Series["AUVRecent"].MarkerColor = System.Drawing.Color.OrangeRed;
            TrackPlot.Series["AUVRecent"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            TrackPlot.Series["AUVRecent"].MarkerSize = 8;

            //cboMode.Text = System.Convert.ToString(cboMode.Items[0]);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSharkDistance = new System.Windows.Forms.Label();
            this.lblSharkBearing = new System.Windows.Forms.Label();
            this.lblSharkX = new System.Windows.Forms.Label();
            this.lblSharkY = new System.Windows.Forms.Label();
            this.lblAUVY = new System.Windows.Forms.Label();
            this.lblAUVX = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblAUVLongitude = new System.Windows.Forms.Label();
            this.lblAUVLatitude = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblAUVTemperature = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lstFront = new System.Windows.Forms.ListBox();
            this.lstBack = new System.Windows.Forms.ListBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.TrackPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadXMLFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TrackPlot)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMode
            // 
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Items.AddRange(new object[] {
            "Point",
            "Circle",
            "Oval"});
            this.cboMode.Location = new System.Drawing.Point(136, 240);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(121, 24);
            this.cboMode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Track Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "AUV Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shark Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bearing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "X";
            // 
            // lblSharkDistance
            // 
            this.lblSharkDistance.AutoSize = true;
            this.lblSharkDistance.Location = new System.Drawing.Point(524, 66);
            this.lblSharkDistance.Name = "lblSharkDistance";
            this.lblSharkDistance.Size = new System.Drawing.Size(16, 17);
            this.lblSharkDistance.TabIndex = 8;
            this.lblSharkDistance.Text = "0";
            // 
            // lblSharkBearing
            // 
            this.lblSharkBearing.AutoSize = true;
            this.lblSharkBearing.Location = new System.Drawing.Point(524, 93);
            this.lblSharkBearing.Name = "lblSharkBearing";
            this.lblSharkBearing.Size = new System.Drawing.Size(32, 17);
            this.lblSharkBearing.TabIndex = 9;
            this.lblSharkBearing.Text = "180";
            // 
            // lblSharkX
            // 
            this.lblSharkX.AutoSize = true;
            this.lblSharkX.Location = new System.Drawing.Point(524, 121);
            this.lblSharkX.Name = "lblSharkX";
            this.lblSharkX.Size = new System.Drawing.Size(16, 17);
            this.lblSharkX.TabIndex = 10;
            this.lblSharkX.Text = "0";
            // 
            // lblSharkY
            // 
            this.lblSharkY.AutoSize = true;
            this.lblSharkY.Location = new System.Drawing.Point(524, 148);
            this.lblSharkY.Name = "lblSharkY";
            this.lblSharkY.Size = new System.Drawing.Size(16, 17);
            this.lblSharkY.TabIndex = 11;
            this.lblSharkY.Text = "0";
            // 
            // lblAUVY
            // 
            this.lblAUVY.AutoSize = true;
            this.lblAUVY.Location = new System.Drawing.Point(165, 92);
            this.lblAUVY.Name = "lblAUVY";
            this.lblAUVY.Size = new System.Drawing.Size(16, 17);
            this.lblAUVY.TabIndex = 15;
            this.lblAUVY.Text = "0";
            // 
            // lblAUVX
            // 
            this.lblAUVX.AutoSize = true;
            this.lblAUVX.Location = new System.Drawing.Point(165, 65);
            this.lblAUVX.Name = "lblAUVX";
            this.lblAUVX.Size = new System.Drawing.Size(16, 17);
            this.lblAUVX.TabIndex = 14;
            this.lblAUVX.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "X";
            // 
            // lblAUVLongitude
            // 
            this.lblAUVLongitude.AutoSize = true;
            this.lblAUVLongitude.Location = new System.Drawing.Point(165, 143);
            this.lblAUVLongitude.Name = "lblAUVLongitude";
            this.lblAUVLongitude.Size = new System.Drawing.Size(16, 17);
            this.lblAUVLongitude.TabIndex = 19;
            this.lblAUVLongitude.Text = "0";
            // 
            // lblAUVLatitude
            // 
            this.lblAUVLatitude.AutoSize = true;
            this.lblAUVLatitude.Location = new System.Drawing.Point(165, 116);
            this.lblAUVLatitude.Name = "lblAUVLatitude";
            this.lblAUVLatitude.Size = new System.Drawing.Size(16, 17);
            this.lblAUVLatitude.TabIndex = 18;
            this.lblAUVLatitude.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(62, 143);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 17);
            this.label18.TabIndex = 17;
            this.label18.Text = "Longitude";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(62, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 17);
            this.label19.TabIndex = 16;
            this.label19.Text = "Latitude";
            // 
            // lblAUVTemperature
            // 
            this.lblAUVTemperature.AutoSize = true;
            this.lblAUVTemperature.Location = new System.Drawing.Point(329, 65);
            this.lblAUVTemperature.Name = "lblAUVTemperature";
            this.lblAUVTemperature.Size = new System.Drawing.Size(16, 17);
            this.lblAUVTemperature.TabIndex = 21;
            this.lblAUVTemperature.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(226, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 17);
            this.label21.TabIndex = 20;
            this.label21.Text = "Temperature";
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(365, 198);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(191, 53);
            this.butStart.TabIndex = 22;
            this.butStart.Text = "Start Tracking";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(365, 253);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(191, 53);
            this.butStop.TabIndex = 23;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(45, 288);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(127, 17);
            this.label22.TabIndex = 24;
            this.label22.Text = "Front Hydrophone:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(40, 451);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(125, 17);
            this.label23.TabIndex = 25;
            this.label23.Text = "Back Hydrophone:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstFront
            // 
            this.lstFront.FormattingEnabled = true;
            this.lstFront.ItemHeight = 16;
            this.lstFront.Location = new System.Drawing.Point(50, 316);
            this.lstFront.Name = "lstFront";
            this.lstFront.Size = new System.Drawing.Size(725, 116);
            this.lstFront.TabIndex = 30;
            // 
            // lstBack
            // 
            this.lstBack.FormattingEnabled = true;
            this.lstBack.ItemHeight = 16;
            this.lstBack.Location = new System.Drawing.Point(50, 481);
            this.lstBack.Name = "lstBack";
            this.lstBack.Size = new System.Drawing.Size(725, 116);
            this.lstBack.TabIndex = 31;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(174, 288);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(56, 17);
            this.label28.TabIndex = 32;
            this.label28.Text = "450207";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(174, 451);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 17);
            this.label29.TabIndex = 33;
            this.label29.Text = "450208";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TrackPlot
            // 
            chartArea1.Name = "ChartArea1";
            this.TrackPlot.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Legend1";
            this.TrackPlot.Legends.Add(legend1);
            this.TrackPlot.Location = new System.Drawing.Point(797, 32);
            this.TrackPlot.Name = "TrackPlot";
            this.TrackPlot.Size = new System.Drawing.Size(631, 565);
            this.TrackPlot.TabIndex = 34;
            this.TrackPlot.Text = "TrackPlot";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadXMLFileToolStripMenuItem,
            this.calibrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1428, 28);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadXMLFileToolStripMenuItem
            // 
            this.loadXMLFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadXMLFileToolStripMenuItem1});
            this.loadXMLFileToolStripMenuItem.Name = "loadXMLFileToolStripMenuItem";
            this.loadXMLFileToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.loadXMLFileToolStripMenuItem.Text = "Files";
            // 
            // loadXMLFileToolStripMenuItem1
            // 
            this.loadXMLFileToolStripMenuItem1.Name = "loadXMLFileToolStripMenuItem1";
            this.loadXMLFileToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.loadXMLFileToolStripMenuItem1.Text = "Load XML File";
            // 
            // calibrationToolStripMenuItem
            // 
            this.calibrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calibrateToolStripMenuItem});
            this.calibrationToolStripMenuItem.Name = "calibrationToolStripMenuItem";
            this.calibrationToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.calibrationToolStripMenuItem.Text = "Tools";
            // 
            // calibrateToolStripMenuItem
            // 
            this.calibrateToolStripMenuItem.Name = "calibrateToolStripMenuItem";
            this.calibrateToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.calibrateToolStripMenuItem.Text = "Calibrate";
            this.calibrateToolStripMenuItem.Click += new System.EventHandler(this.calibrateToolStripMenuItem_Click);
            // 
            // GUIFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 611);
            this.Controls.Add(this.TrackPlot);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.lstBack);
            this.Controls.Add(this.lstFront);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.lblAUVTemperature);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblAUVLongitude);
            this.Controls.Add(this.lblAUVLatitude);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblAUVY);
            this.Controls.Add(this.lblAUVX);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblSharkY);
            this.Controls.Add(this.lblSharkX);
            this.Controls.Add(this.lblSharkBearing);
            this.Controls.Add(this.lblSharkDistance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUIFormView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadView);
            ((System.ComponentModel.ISupportInitialize)(this.TrackPlot)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSharkDistance;
        private System.Windows.Forms.Label lblSharkBearing;
        private System.Windows.Forms.Label lblSharkX;
        private System.Windows.Forms.Label lblSharkY;
        private System.Windows.Forms.Label lblAUVY;
        private System.Windows.Forms.Label lblAUVX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblAUVLongitude;
        private System.Windows.Forms.Label lblAUVLatitude;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblAUVTemperature;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox lstFront;
        private System.Windows.Forms.ListBox lstBack;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataVisualization.Charting.Chart TrackPlot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadXMLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadXMLFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calibrateToolStripMenuItem;
    }
}

