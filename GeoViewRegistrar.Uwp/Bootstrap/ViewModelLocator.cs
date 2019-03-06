using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GeoViewRegistrar.Shared.ViewModels;

namespace GeoViewRegistrar.Uwp.Bootstrap
{
    public class ViewModelLocator : ViewModelBase
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
