using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;



namespace SharkTrackingGUI
{
    public partial class GUIFormView : System.Windows.Forms.Form, IFormView
    {
        public FormModel Model = new FormModel();
        FormController _controller;

        public void SetController(FormController controller)
        {
            _controller = controller;
        }

        public GUIFormView()
        {
            InitializeComponent();
        }

        public void LoadView(object sender, EventArgs e)
        {
            InitializeChart();
        }

        private XY _AUVXY;
        public XY AUVXY
        {
            set
            {
                _AUVXY = value;
                var point = _AUVXY;
                TrackPlot.Series["AUV"].Points.AddXY(point.X, point.Y);
                TrackPlot.Series["AUVRecent"].Points.Clear();
                TrackPlot.Series["AUVRecent"].Points.AddXY(point.X, point.Y);
                // Update Labels
                lblAUVX.Text = Convert.ToString(point.X);
                lblAUVY.Text = Convert.ToString(point.Y);
            }
        }

        private XY _SharkXY;
        public XY SharkXY
        {
            set
            {
                _SharkXY = value;
                var point = _SharkXY;
                TrackPlot.Series["Shark"].Points.AddXY(point.X, point.Y);
                TrackPlot.Series["SharkRecent"].Points.Clear();
                TrackPlot.Series["SharkRecent"].Points.AddXY(point.X, point.Y);
                // Update Labels
                lblSharkX.Text = Convert.ToString(point.X);
                lblSharkY.Text = Convert.ToString(point.Y);
            }
        }

        private double _AUVTemperature;
        public double AUVTemperature
        {
            set
            {
                _AUVTemperature = value;
                lblAUVTemperature.Text = Convert.ToString(_AUVTemperature);
            }
        }

        private double _AUVLatitude;
        public double AUVLatitude
        {
            set
            {
                _AUVLatitude = value;
                lblAUVLatitude.Text = Convert.ToString(_AUVLatitude);
            }
        }

        private double _AUVLongitude;
        public double AUVLongitude
        {
            set
            {
                _AUVLongitude = value;
                lblAUVLongitude.Text = Convert.ToString(_AUVLongitude); // Refresh lon
            }
        }

        private double _SharkDistance;
        public double SharkDistance
        {
            set
            {
                _SharkDistance = value;
                lblSharkDistance.Text = Convert.ToString(_SharkDistance);
            }
        }

        private double _SharkBearing;
        public double SharkBearing
        {
            set
            {
                _SharkBearing = value;
                lblSharkBearing.Text = Convert.ToString(_SharkBearing);
            }
        }

        //public void UpdateAUVPlot(object sender, EventArgs e)
        //{
        //    // Update Chart
        //    while (!Model.IsEmptyAUVXY())
        //    {
        //        var point = Model.DequeueAUVXY();
        //        TrackPlot.Series["AUV"].Points.AddXY(point.X, point.Y);
        //        TrackPlot.Series["AUVRecent"].Points.Clear();
        //        TrackPlot.Series["AUVRecent"].Points.AddXY(point.X, point.Y);
        //    }
        //    // Update labels
        //    if (TrackPlot.Series["AUVRecent"].Points.Count != 0)
        //    {
        //        lblAUVX.Text = Convert.ToString(TrackPlot.Series["AUVRecent"].Points[0].XValue);
        //        lblAUVY.Text = Convert.ToString(TrackPlot.Series["AUVRecent"].Points[0].YValues[0]);
        //    }
        //}

        //public void UpdateSharkPlot(object sender, EventArgs e)
        //{
        //    while (!Model.IsEmptySharkXY())
        //    {
        //        var point = Model.DequeueSharkXY();
        //        TrackPlot.Series["Shark"].Points.AddXY(point.X, point.Y);
        //        TrackPlot.Series["SharkRecent"].Points.Clear();
        //        TrackPlot.Series["SharkRecent"].Points.AddXY(point.X, point.Y);
        //    }
        //    // Update labels
        //    if (TrackPlot.Series["SharkRecent"].Points.Count != 0)
        //    {
        //        lblSharkX.Text = Convert.ToString(TrackPlot.Series["SharkRecent"].Points[0].XValue);
        //        lblSharkY.Text = Convert.ToString(TrackPlot.Series["SharkRecent"].Points[0].YValues[0]);
        //    }
        //}

        public void UpdateFrontBoardInfo(object sender, EventArgs e)
        {
            lstFront.DataSource = null;
            lstFront.DataSource = Model.GetFrontReading();
            lstFront.TopIndex = lstFront.Items.Count - 1; //Auto Scroll
        }

        public void UpdateBackBoardInfo(object sender, EventArgs e)
        {
            lstBack.DataSource = null;
            lstBack.DataSource = Model.GetBackReading();
            lstBack.TopIndex = lstBack.Items.Count - 1; //Auto Scroll
        }

        private void calibrateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.Calibrate();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            _controller.StartTracking();
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            _controller.StopTracking();
        }
    }
}
