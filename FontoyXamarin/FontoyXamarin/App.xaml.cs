using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace FontoyXamarin
{
	public partial class App : Application
	{
		public App ()
		{
            Resources = new ResourceDictionary();
            Resources.Add("primaryBlue", Color.FromHex("3769BA"));
            Resources.Add("primaryDarkGreen", Color.FromHex("6FA22E"));

            var nav = new NavigationPage(new MainPage());
            nav.BarBackgroundColor = (Color)App.Current.Resources["primaryBlue"];
            nav.BarTextColor = Color.White;

            MainPage = nav;

            //InitializeComponent();

			//MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
