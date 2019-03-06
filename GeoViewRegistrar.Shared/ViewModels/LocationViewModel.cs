using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.UI.Controls;
using GalaSoft.MvvmLight;

namespace GeoViewRegistrar.Shared.ViewModels
{
    public class LocationViewModel : ViewModelBase
    {
        private MapPoint _mapPoint;

        public MapPoint MapPoint
        {
            get => _mapPoint;
            set
            {
                _mapPoint = value;
                RaisePropertyChanged(()=>MapPoint);
            }
        }

        public LocationViewModel()
        {
            MessengerInstance.Register<GeoViewInputEventArgs>(this, e =>
            {
                MapPoint = e.Location;
            });
        }
    }
}
