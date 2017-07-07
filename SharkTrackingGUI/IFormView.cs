using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace SharkTrackingGUI
{
    public interface IFormView
    {
        void SetController(FormController controller);
        void LoadView(object sender, EventArgs e);
        void UpdateFrontBoardInfo(object sender, EventArgs e);
        void UpdateBackBoardInfo(object sender, EventArgs e);
        
        double AUVTemperature {set; }
        double AUVLatitude {set; }
        double AUVLongitude { set; }
        double SharkDistance { set; }
        double SharkBearing { set; }
        XY AUVXY { set; }
        XY SharkXY { set; }
    }
}
