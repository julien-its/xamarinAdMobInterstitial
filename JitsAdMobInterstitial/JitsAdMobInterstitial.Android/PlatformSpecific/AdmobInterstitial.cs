using Android.Gms.Ads;
using JitsAdMobInterstitial.Models.Dependency;
using JitsAdMobInterstitial.Droid.PlatformSpecific;
using Android.App;

[assembly: Xamarin.Forms.Dependency(typeof(AdmobInterstitial))]
namespace JitsAdMobInterstitial.Droid.PlatformSpecific
{
    public class AdmobInterstitial : I_InterstitialAd
    {
        Android.Gms.Ads.InterstitialAd _ad;

        public void show()
        {
            var context = Application.Context;

            _ad = new InterstitialAd(context);
            _ad.AdUnitId = "ca-app-pub-9122365822495930/4770566486"; // Bloc d'annonce INTERSTITIEL !

            var intlistener = new InterstitialAdListener(_ad);
            _ad.AdListener = intlistener;
            intlistener.OnAdLoaded();

            var requestbuilder = new AdRequest.Builder();
            _ad.LoadAd(requestbuilder.Build());
        }

    }
}