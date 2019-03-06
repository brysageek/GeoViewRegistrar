using System;
using Esri.ArcGISRuntime.Mapping;
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
                RaisePropertyChanged(() => MainScene);
            }
        }

        [PreferredConstructor]
        public SceneViewModel()
        {
            MainScene = new Scene(Basemap.CreateOpenStreetMap());
        }

        public SceneViewModel(Scene scene)
        {
            MainScene = scene;
        }
    }
}