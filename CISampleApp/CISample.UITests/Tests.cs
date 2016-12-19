using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CISample.UITests
{
    [TestFixture(Platform.Android)]
    //Comment this on Windows:
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AddNewProductTest()
        {
            app.WaitForElement(c => c.Marked("ProductsListView"));
            app.EnterText("ProductNameEntry", "New product");
            app.Tap(b => b.Marked("AddProductButton"));
            app.EnterText("ProductNameEntry", "New product 2");
            app.Tap(b => b.Marked("AddProductButton"));
            var length = app.Query(q => q.Marked("ProductsListView").Child()).Length;
            Assert.AreEqual(2, length);
        }

    }
}

