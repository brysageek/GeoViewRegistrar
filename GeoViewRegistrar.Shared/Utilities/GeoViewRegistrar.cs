using System;
using Esri.ArcGISRuntime.UI.Controls;
using GalaSoft.MvvmLight.Messaging;

namespace GeoViewRegistrar.Shared.Utilities
{
    class GeoViewRegistrar
    {
        private static readonly Lazy<GeoViewRegistrar> _singleton = new Lazy<GeoViewRegistrar>(() => new GeoViewRegistrar());
        public static GeoViewRegistrar Default => _singleton.Value;

        public GeoViewRegistrar()
        {
            
        }

        public void Register(GeoView geoView)
        {
            geoView.GeoViewDoubleTapped += (o, e) =>
            {
                Messenger.Default.Send<GeoViewInputEventArgs>(e);
            };
        }
    }
}
