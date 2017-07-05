using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;



namespace SharkTrackingGUI
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public FormModel Model = new FormModel();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeChart();

            System.Windows.Forms.Timer timerAUV = new System.Windows.Forms.Timer();
            timerAUV.Interval = (2000); // 2 secs
            timerAUV.Tick += new EventHandler(UpdateAUVInfo);
            timerAUV.Start();

            System.Windows.Forms.Timer timerShark = new System.Windows.Forms.Timer();
            timerShark.Interval = (2000); // 2 secs
            timerShark.Tick += new EventHandler(UpdateSharkInfo);
            timerShark.Start();

            System.Windows.Forms.Timer timerlst = new System.Windows.Forms.Timer();
            timerlst.Interval = (1000); // 2 secs
            timerlst.Tick += new EventHandler(UpdateFrontVemcoInfo);
            timerlst.Start();
        }

        private void UpdateAUVInfo(object sender, EventArgs e)
        {
            // Update Chart
            while (!Model.IsEmptyAUVXY())
            {
                var point = Model.DequeueAUVXY();
                TrackPlot.Series["AUV"].Points.AddXY(point.X, point.Y);
                TrackPlot.Series["AUVRecent"].Points.Clear();
                TrackPlot.Series["AUVRecent"].Points.AddXY(point.X, point.Y);
            }
            // Update labels
            if (TrackPlot.Series["AUVRecent"].Points.Count != 0)
            {
                lblAUVX.Text = Convert.ToString(TrackPlot.Series["AUVRecent"].Points[0].XValue);
                lblAUVY.Text = Convert.ToString(TrackPlot.Series["AUVRecent"].Points[0].YValues[0]);
            }
        }

        private void UpdateSharkInfo(object sender, EventArgs e)
        {
            while (!Model.IsEmptySharkXY())
            {
                var point = Model.DequeueSharkXY();
                TrackPlot.Series["Shark"].Points.AddXY(point.X, point.Y);
                TrackPlot.Series["SharkRecent"].Points.Clear();
                TrackPlot.Series["SharkRecent"].Points.AddXY(point.X, point.Y);
            }
            // Update labels
            if (TrackPlot.Series["AUVRecent"].Points.Count != 0)
            {
                lblSharkX.Text = Convert.ToString(TrackPlot.Series["SharkRecent"].Points[0].XValue);
                lblSharkY.Text = Convert.ToString(TrackPlot.Series["SharkRecent"].Points[0].YValues[0]);
            }
        }

        public void UpdateFrontVemcoInfo(object sender, EventArgs e)
        {
            lstFront.DataSource = null;
            lstFront.DataSource = Model.GetFrontReading();
            lstFront.TopIndex = lstFront.Items.Count - 1; //Auto Scroll
        }

        public void UpdateBackVemcoInfo(object sender, EventArgs e)
        {
            lstBack.DataSource = null;
            lstBack.DataSource = Model.GetBackReading();
            lstBack.TopIndex = lstBack.Items.Count - 1; //Auto Scroll
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateChart(object sender, EventArgs e)
        {
            // Should not be used because the model should generate this for us.
            while (!Model.IsEmptyAUVXY())
            {
                var point = Model.DequeueAUVXY();
                TrackPlot.Series["AUV"].Points.AddXY(point.X, point.Y);
                TrackPlot.Series["AUVRecent"].Points.Clear();
                TrackPlot.Series["AUVRecent"].Points.AddXY(point.X, point.Y);
            }

            while (!Model.IsEmptySharkXY())
            {
                var point = Model.DequeueSharkXY();
                TrackPlot.Series["Shark"].Points.AddXY(point.X, point.Y);
                TrackPlot.Series["SharkRecent"].Points.Clear();
                TrackPlot.Series["SharkRecent"].Points.AddXY(point.X, point.Y);
            }
        }

        private void UpdateLabels(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrackPlot.Series["AUV"].Points.AddXY(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            TrackPlot.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstFront.Items.Add(textBox3.Text);
        }

        private void calibrateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.Calibrate();
        }
    }
}
