using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharkTrackingGUI
{
    public class FormController
    {
        IFormView _view;
        FormModel _model;

        public FormController(IFormView view, FormModel model)
        {
            _view = view;
            _model = model;
            _view.SetController(this);
            // Subscribing event handlers to events
            _model.AUVTemperatureChanged += BindAUVTemperature;
            _model.AUVLatLonChanged += BindAUVLatLon;
            _model.SharkDistanceChanged += BindSharkDistance;
            _model.SharkBearingChanged += BindSharkBearing;
            _model.AUVXYChanged += BindAUVXY;
            _model.SharkXYChanged += BindSharkXY;
            _model.FrontReadingChanged += _view.UpdateFrontBoardInfo;
            _model.BackReadingChanged += _view.UpdateBackBoardInfo;
        }
        #region DataBinding
        private void BindAUVXY(object sender, EventArgs e)
        {
            _view.AUVXY = _model.AUVXY;
        }

        private void BindSharkXY(object sender, EventArgs e)
        {
            _view.SharkXY = _model.SharkXY;
        }

        private void BindAUVTemperature(object sender, EventArgs e)
        {
            _view.AUVTemperature = _model.AUVTemperature;
        }

        private void BindAUVLatLon(object sender, EventArgs e)
        {
            _view.AUVLatitude = _model.AUVLatitude;
            _view.AUVLongitude = _model.AUVLongitude;
        }

        private void BindSharkDistance(object sender, EventArgs e)
        {
            _view.SharkDistance = _model.SharkDistance;
        }

        private void BindSharkBearing(object sender, EventArgs e)
        {
            _view.SharkBearing = _model.SharkBearing;
        }
        #endregion

        public void Calibrate()
        {
            throw new NotImplementedException();
        }

        public void StartTracking()
        {
            throw new NotImplementedException();
        }

        public void StopTracking()
        {
            throw new NotImplementedException();
        }

    }
}
