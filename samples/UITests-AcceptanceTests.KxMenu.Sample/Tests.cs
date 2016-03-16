using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace UITestsAcceptanceTests.KxMenu.Sample
{
	[TestFixture]
	public class Tests
	{
		string[] apppath_parts = new string[]
		{
			"..",
			"..",
			"..",
			"Sample.KxMenu.Bindings",
			"bin",
			"iPhoneSimulator",
			"Debug",
			"SampleKxMenuBindings.app"
		};

		iOSApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			string path = Path.Combine(apppath_parts);

			// TODO: If the iOS app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.iOS
				.AppBundle(path)
			// TODO: Update this path to point to your iOS app and uncomment the
			// code if the app is not included in the solution.
			//.AppBundle ("../../../iOS/bin/iPhoneSimulator/Debug/UITests-AcceptanceTests.KxMenu.Sample.iOS.app")
				.StartApp();


			return;
		}

		[Test]
		public void AppLaunches ()
		{
			app.Screenshot ("First screen.");
			// app.Repl();


		}

		[Test]
		public void Interaction01 ()
		{
			app.Tap(c => c.Marked("Click me"));;
			app.Tap(c => c.Marked("home_icon"));;
			app.Tap(c => c.Marked("Click me"));;
			app.Tap(c => c.Marked("home_icon"));;
		}
	}
}

