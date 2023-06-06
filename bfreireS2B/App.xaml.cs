using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bfreireS2B
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Ejecicio();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
