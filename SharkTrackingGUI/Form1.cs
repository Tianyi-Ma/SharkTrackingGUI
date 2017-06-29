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

namespace SharkTrackingGUI
{
    public partial class Form1 : Form
    {
        public FormModel Model = new FormModel();
        public Form1()
        {
            InitializeComponent();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            TrackPlot.Series.Add("Shark").YValueMembers = "Shark";
            TrackPlot.Series["Shark"].ChartType = SeriesChartType.FastPoint;
            TrackPlot.Series["Shark"].XValueType = ChartValueType.Double;
            TrackPlot.Series["Shark"].YValueType = ChartValueType.Double;

            foreach (var element in Model.SharkXY)
            {
                TrackPlot.Series["Shark"].Points.AddXY(element.X, element.Y);
            }

            TrackPlot.Series.Add("AUV").YValueMembers = "AUV";
            TrackPlot.Series["AUV"].ChartType = SeriesChartType.FastPoint;
            TrackPlot.Series["AUV"].XValueType = ChartValueType.Double;
            TrackPlot.Series["AUV"].YValueType = ChartValueType.Double;
            TrackPlot.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "#.##";

            foreach (var element in Model.AUVXY)
            {
                TrackPlot.Series["AUV"].Points.AddXY(element.X, element.Y);
            }
            //            TrackPlot.Series["Shark"].Points.DataBind(SharkModel.SharkXY);

        }

        private void TrackPlot_Click(object sender, EventArgs e)
        {

        }
    }
}
