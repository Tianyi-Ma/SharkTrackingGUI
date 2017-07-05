using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SharkTrackingGUI
{
    /// <summary>
    /// This class extracts data from AUV and creates a model for the GUI
    /// </summary>
    public class FormModel
    {
        private Queue<XY> _AUVXY = new Queue<XY>();
        private Queue<XY> _sharkXY = new Queue<XY>();
        private List<string> _frontBoardReading = new List<string>();
        private List<string> _backBoardReading = new List<string>();
        private StreamReader _sr = new StreamReader("Vemco_1.txt");
        private Queue<string> _reading = new Queue<string>();
        Random rnd = new Random();
        Random rnd2 = new Random();

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
            UpdateSharkXY();
            UpdateAUVXY();
            UpdateFrontReading();
        }



        public void AddRndAUVXY()
        {
            int x = rnd.Next(0, 10);
            int y = rnd.Next(0, 10);
            
            _AUVXY.Enqueue(new XY(x, y));
        }

        public void AddRndSharkXY()
        {
            int x = rnd.Next(0, 10);
            int y = rnd.Next(0, 10);

            _sharkXY.Enqueue(new XY(x, y));
        }

        //EventHandler Version
        public void UpdateAUVXY(object sender, EventArgs e)
        {
            AddRndAUVXY();
        }
        public void UpdateAUVXY()
        {
            AddRndAUVXY();
        }
        public XY DequeueAUVXY() { return _AUVXY.Dequeue(); }
        public bool IsEmptyAUVXY() { return (_AUVXY.Count == 0); }

        public void UpdateSharkXY(object sender, EventArgs e)
        {
            AddRndSharkXY();
        }
        public void UpdateSharkXY()
        {
            AddRndSharkXY();
        }
        public XY DequeueSharkXY() { return _sharkXY.Dequeue(); }
        public bool IsEmptySharkXY() { return (_sharkXY.Count == 0); }

        public void UpdateFrontReading()
        {
            if (_reading.Count!=0)
            {
                _frontBoardReading.Add(_reading.Dequeue());
            }
            if (_frontBoardReading.Count > 10)
            {
                _frontBoardReading.RemoveAt(0);
            }
        }
        public void UpdateBackReading()
        {
            if (_reading.Count != 0)
            {
                _backBoardReading.Add(_reading.Dequeue());
            }
            if (_backBoardReading.Count > 10)
            {
                _backBoardReading.RemoveAt(0);
            }
        }
        public List<string> GetFrontReading() { return _frontBoardReading; }
        public List<string> GetBackReading() { return _backBoardReading; }
        
        public void Calibrate() { }

        public struct XY
        {
            public double X { get; set; }
            public double Y { get; set; }
            public XY(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

    }


}
