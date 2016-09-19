using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CreditCardValidator.UITests
{
	//Set this attribute to indicate which platforms you would like to test:
	[TestFixture(Platform.Android)]
	[TestFixture (Platform.iOS)]
	public class Tests
	{
		//Platform parameter - indicates on which platform Xamarin shoudl launch tests:
		Platform platform;
		//IApp interface is responsible for communication with the app (like clicking buttons or typing in text fields);
		IApp app;

		//This is constructor for the test with setting the platform:
		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		//This is setup before test is launched - below app object is initialized to enable tests:
		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		//In this method REPL console in invoked (with REPL we are able to test our app and see the result in console,
		// we can also test our app manually and all actions will be displayed on the console:
		[Test]
		public void AppLaunches()
		{
			app.Repl();
		}

		// Test for Android:
		//[Test]
		//public void CreditCardNumber_TooShort_DisplayErrorMessage()
		//{
		//	app.WaitForElement(c => c.Marked("action_bar_title").Text("Enter Credit Card Number"));
		//	app.EnterText(c => c.Marked("creditCardNumberText"), new string('9', 15));
		//	app.Tap(c => c.Marked("validateButton"));

		//	app.WaitForElement(c => c.Marked("errorMessagesText").Text("Credit card number is too short."));
		//}

		//Test for iOS:
		[Test]
		public void CreditCardNumber_TooShort_DisplayErrorMessage()
		{
			app.WaitForElement(c => c.Class("UINavigationBar").Marked("Simple Credit Card Validator"));
			app.EnterText(c => c.Class("UITextField"), new string('9', 15));
			app.Tap(c => c.Marked("Validate Credit Card").Class("UIButton"));

			app.WaitForElement(c => c.Marked("Credit card number is too short.").Class("UILabel"));
		}

	}
}


