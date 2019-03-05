using System;
using Esri.ArcGISRuntime.Mapping;
using GalaSoft.MvvmLight.Ioc;
using GeoViewRegistrar.Shared.ViewModels;

namespace GeoRegistrarExample.Bootstrap
{
    public class ViewModelLocator
    {
        public MapViewModel MapVm => SimpleIoc.Default.GetInstance<MapViewModel>();
        public SceneViewModel SceneVm => SimpleIoc.Default.GetInstance<SceneViewModel>();
        public LocationViewModel LocationVm => SimpleIoc.Default.GetInstance<LocationViewModel>();

        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MapViewModel>();
            SimpleIoc.Default.Register<SceneViewModel>();
            SimpleIoc.Default.Register<LocationViewModel>();
        }
    }
}
