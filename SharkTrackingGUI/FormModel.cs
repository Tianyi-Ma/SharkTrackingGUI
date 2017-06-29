using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharkTrackingGUI
{
    /// <summary>
    /// This class extracts data from AUV and creates a model for the GUI
    /// </summary>
    public class FormModel
    {
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

        public List<XY> SharkXY = new List<XY>();
        public List<XY> AUVXY = new List<XY>();

        public FormModel()
        { 
            SharkXY.Add(new XY(1.0, 2.9));
            SharkXY.Add(new XY(2.0, 4.0));
            SharkXY.Add(new XY(2.5, 7.0));
            AUVXY.Add(new XY(5.2, 3.5));
            AUVXY.Add(new XY(5.6, 3.2));
            AUVXY.Add(new XY(2.3, 9.0));

        }

        //Setting the maximum number of points to be plot to be 100
        public void UpdateSharkXY()
        {

        }

        public void UpdateAUVXY()
        {

        }

        public void GetSharkXY()
        {

        }

        public void GetAUVXY()
        {

        }
        public class TupleList<T1, T2> : List<Tuple<T1, T2>>
        {
            public void Add(T1 item, T2 item2)
            {
                Add(new Tuple<T1, T2>(item, item2));
            }
        }

    }


}
