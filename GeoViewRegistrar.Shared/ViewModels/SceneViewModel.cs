using System;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.UI.Controls;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace GeoViewRegistrar.Shared.ViewModels
{
    public class SceneViewModel : ViewModelBase
    {
        private Scene _mainScene;

        public Scene MainScene
        {
            get => _mainScene;
            set
            {
                _mainScene = value; 
                RaisePropertyChanged(()=>MainScene);
            }
        }

        [PreferredConstructor]
        public SceneViewModel()
        {
            MainScene = new Scene(Basemap.CreateOpenStreetMap());
            MessengerInstance.Register<GeoViewInputEventArgs>(this, e =>
            {
                Console.WriteLine("SceneViewModel Heard it");
            });
        }

        public SceneViewModel(Scene scene)
        {
            MainScene = scene;
          
        }
    }
}
