using Xamarin.Forms;

namespace CustomIosFrameShadowsWithXF45
{
    public partial class App : Application
    {
        // NOTE: Just for demo project obviously ...
        public enum FrameShadowType
        {
            Default = 0,
            Custom = 1,
            NoShadow = 2,
        }


        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
