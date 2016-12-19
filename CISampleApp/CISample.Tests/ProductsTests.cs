using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CISampleApp.ViewModels;

namespace CISample.Tests
{
    [TestClass]
    public class ProductsTests
    {

        [TestMethod]
        public void AddNewProductSuccessTest()
        {
            //Arrange
            MainViewModel mainViewModel = new MainViewModel();

            //Act:
            mainViewModel.ProductName = "New product";
            mainViewModel.AddNewProduct.Execute(null);

            //Assert
            Assert.AreEqual(mainViewModel.MyProducts.Count, 1);
            Assert.AreEqual("New product", mainViewModel.MyProducts[0].Name);
        }
    }
}
