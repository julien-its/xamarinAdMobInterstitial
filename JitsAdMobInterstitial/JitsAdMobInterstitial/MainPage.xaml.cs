using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JitsAdMobInterstitial
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            BtnOpen.Clicked += OpenAdInt;
        }

        void OpenAdInt(object sender, EventArgs args)
        {
            DependencyService.Get<Models.Dependency.I_InterstitialAd>().show();
        }
    }
}
