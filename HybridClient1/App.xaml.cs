using Wisej.Hybrid.Native.Controls;

namespace HybridClient1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HybridShell();
        }
    }
}