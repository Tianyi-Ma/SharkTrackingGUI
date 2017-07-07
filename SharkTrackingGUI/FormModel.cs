using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace SharkTrackingGUI
{
    /// <summary>
    /// This class extracts data from AUV and creates a model for the GUI
    /// </summary>
    public class FormModel
    {
        private Queue<XY> AUVXYQueue = new Queue<XY>();
        private Queue<XY> SharkXYQueue = new Queue<XY>();
        private List<string> FrontBoardReading = new List<string>();
        private List<string> BackBoardReading = new List<string>();
        private StreamReader _sr = new StreamReader("Vemco_1.txt");
        private Queue<string> _reading = new Queue<string>();
        private Random rnd = new Random();

        public XY AUVXY { get; set; }
        public XY SharkXY { get; set; }
        public double AUVTemperature { get; set; }
        public double AUVLatitude { get; set; }
        public double AUVLongitude { get; set; }
        public double SharkDistance { get; set; }
        public double SharkBearing { get; set; }

        public FormModel()
        {
            string line;
            while ((line = _sr.ReadLine()) != null)
            {
                if (line != "")
                {
                    _reading.Enqueue(line);
                }
            }

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (1000); // 1 sec
            timer.Tick += new EventHandler(UpdateAll);
            timer.Start();
        }

        public void UpdateAll(object sender, EventArgs e)
        {
            UpdateAUVXY();
            UpdateSharkXY();
            UpdateFrontReading();
            UpdateAUVTemperature();
            UpdateAUVLatLon();
            UpdateSharkDistance();
            UpdateSharkBearing();
        }

        public void AddRndAUVXY()
        {
            int x = rnd.Next(0, 10);
            int y = rnd.Next(0, 10);
            
            AUVXYQueue.Enqueue(new XY(x, y));
        }
        public void AddRndSharkXY()
        {
            int x = rnd.Next(0, 10);
            int y = rnd.Next(0, 10);

            SharkXYQueue.Enqueue(new XY(x, y));
        }

        #region AUVXY
        public XY DequeueAUVXY() { return AUVXYQueue.Dequeue(); }
        public bool IsEmptyAUVXY() { return (AUVXYQueue.Count == 0); }

        /// <summary>
        /// Update the XY location of AUV and invoke the AUVXYChanged event.
        /// </summary>
        public void UpdateAUVXY()
        {
            AddRndAUVXY();
            if (AUVXYQueue.Count != 0)
            {
                AUVXY = AUVXYQueue.Dequeue();
                OnAUVXYChanged(EventArgs.Empty);
            }
        }
        public event EventHandler AUVXYChanged;
        protected virtual void OnAUVXYChanged(EventArgs e)
        {
            var handler = AUVXYChanged;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }
        }
        #endregion

        #region SharkXY
        public XY DequeueSharkXY() { return SharkXYQueue.Dequeue(); }
        public bool IsEmptySharkXY() { return (SharkXYQueue.Count == 0); }

        /// <summary>
        /// Update the XY location of the shark and invoke the SharkXYChanged event.
        /// </summary>
        public void UpdateSharkXY()
        {
            AddRndSharkXY();
            if (SharkXYQueue.Count != 0)
            {
                SharkXY = SharkXYQueue.Dequeue();
                OnSharkXYChanged(EventArgs.Empty);
            }
        }
        public event EventHandler SharkXYChanged;
        protected virtual void OnSharkXYChanged(EventArgs e)
        {
            var handler = SharkXYChanged;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }
        }
        #endregion

        #region SharkDistance
        /// <summary>
        /// Update the shark distance and invoke the SharkDistanceChanged event.
        /// </summary>
        public void UpdateSharkDistance()
        {
            SharkDistance = rnd.Next(0, 500);
            OnSharkDistanceChanged(EventArgs.Empty);
        }

        public event EventHandler SharkDistanceChanged;

        protected virtual void OnSharkDistanceChanged(EventArgs e)
        {
            var handler = SharkDistanceChanged;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }
        }
        #endregion

        #region SharkBearing
        // Update the shark bearing and invoke the SharkBearingChanged event.
        public void UpdateSharkBearing()
        {
            SharkBearing = rnd.Next(0, 360);
            OnSharkBearingChanged(EventArgs.Empty);
        }

        public event EventHandler SharkBearingChanged;

        protected virtual void OnSharkBearingChanged(EventArgs e)
        {
            var handler = SharkBearingChanged;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }
        }
        #endregion

        #region AUVTemperature
        // Update the Temperature of the AUV and invoke the AUVTemperatureChanged event.
        public void UpdateAUVTemperature()
        {
            AUVTemperature = rnd.Next(0, 40);
            OnAUVTemperatureChanged(EventArgs.Empty);
        }

        public event EventHandler AUVTemperatureChanged;

        protected virtual void OnAUVTemperatureChanged(EventArgs e)
        {
            var handler = AUVTemperatureChanged;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }
        }
        #endregion

        #region AUVLatLon
        /// <summary>
        /// Update the latitude and longitude of AUV and invoke the AUVLatLonChanged event.
        /// </summary>
        public void UpdateAUVLatLon()
        {
            AUVLatitude = rnd.Next(0, 100000);
            AUVLongitude = rnd.Next(0, 100000);
            OnAUVLatLonChanged(EventArgs.Empty);
        }

        public event EventHandler AUVLatLonChanged;

        protected virtual void OnAUVLatLonChanged(EventArgs e)
        {
            var handler = AUVLatLonChanged;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }
        }
        #endregion

        #region FrontReading
        public List<string> GetFrontReading() { return FrontBoardReading; }
        /// <summary>
        /// Update the Vemco reading from the front hydrophone and invoke the FrontReadingChanged event.
        /// </summary>
        public void UpdateFrontReading()
        {
            if (_reading.Count!=0)
            {
                FrontBoardReading.Add(_reading.Dequeue());
                OnFrontReadingChanged(EventArgs.Empty);
            }
            if (FrontBoardReading.Count > 10)
            {
                FrontBoardReading.RemoveAt(0);
            }
        }

        public event EventHandler FrontReadingChanged;

        protected virtual void OnFrontReadingChanged(EventArgs e)
        {
            var handler = FrontReadingChanged;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }
        }
        #endregion

        #region BackReading
        public List<string> GetBackReading() { return BackBoardReading; }
        /// <summary>
        /// Update the Vemco reading from the back hydrophone and invoke the BackReadingChanged event.
        /// </summary>
        public void UpdateBackReading()
        {
            if (_reading.Count != 0)
            {
                BackBoardReading.Add(_reading.Dequeue());
                OnBackReadingChanged(EventArgs.Empty);
            }
            if (BackBoardReading.Count > 10)
            {
                BackBoardReading.RemoveAt(0);
            }
        }

        public event EventHandler BackReadingChanged;

        protected virtual void OnBackReadingChanged(EventArgs e)
        {
            var handler = BackReadingChanged;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }
        }
        #endregion
    }


}
