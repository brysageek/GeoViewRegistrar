using System.Windows;
namespace GeoRegistrarExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GeoViewRegistrar.Shared.Utilities.GeoViewRegistrar.Default.Register(MainMapView);
            GeoViewRegistrar.Shared.Utilities.GeoViewRegistrar.Default.Register(MainSceneView);
        }
    }
}
