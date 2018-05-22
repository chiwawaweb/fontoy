﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FontoyXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MeteoPage : ContentPage
	{
		public MeteoPage ()
		{
			InitializeComponent ();

            ViewMeteo();
        }

        private async void ViewMeteo()
        {
            Weather weather = await Core.GetWeather();
            
            /* Affiche la température */
            Temp.Text = weather.Temperature;
            
        }
	}
}