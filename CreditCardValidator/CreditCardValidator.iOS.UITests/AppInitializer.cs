using System;
using Xamarin.UITest;

namespace CreditCardValidator.UITests
{
	public static class AppInitializer
	{

		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)

				return ConfigureApp.Android.InstalledApp("com.xamarin.example.creditcardvalidator").StartApp();
			

		   if (platform == Platform.iOS)

				return ConfigureApp.iOS.InstalledApp("com.xamarin.example.creditcardvalidator").StartApp();
			

			throw new Exception("AppInitializer: Unsupported platform " + platform);
		}
	}
}
