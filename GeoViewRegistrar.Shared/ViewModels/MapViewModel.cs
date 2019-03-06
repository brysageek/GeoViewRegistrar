using System;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.UI.Controls;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace GeoViewRegistrar.Shared.ViewModels
{
    public class MapViewModel : ViewModelBase
    {
        private Map _mainMap;

        public Map MainMap
        {
            get => _mainMap;
            set
            {
                _mainMap = value;
                RaisePropertyChanged(() => MainMap);
            }
        }

        [PreferredConstructor]
        public MapViewModel()
        {
            MainMap = new Map(Basemap.CreateOpenStreetMap());
        }

        public MapViewModel(Map map)
        {
            MainMap = map;
        }
    }
}
