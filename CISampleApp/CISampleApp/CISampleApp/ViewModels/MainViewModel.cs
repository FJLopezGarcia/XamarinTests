using CISampleApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinUniversity.Infrastructure;
using XamarinUniversity.Interfaces;

namespace CISampleApp.ViewModels
{
    public class MainViewModel : SimpleViewModel
    {
        static int ProductId;
        IDependencyService _serviceLocator;
        public ICommand AddNewProduct { get; private set; }

        private string _productName;

        public string ProductName
        {
            get { return _productName; }
            set
            {
                _productName = value;
                RaisePropertyChanged();
            }
        }



        private ObservableCollection<Product> _myProducts;

        public ObservableCollection<Product> MyProducts
        {
            get
            {
                return _myProducts;
            }

            set
            {
                _myProducts = value;
                RaisePropertyChanged();
            }
        }


        public MainViewModel() : this(new XamarinUniversity.Services.DependencyServiceWrapper())
        {

        }

        public MainViewModel(IDependencyService serviceLocator)
        {
            _serviceLocator = serviceLocator;
            AddNewProduct = new Command(() => AddProduct());
            MyProducts = new ObservableCollection<Product>();
        }

        private void AddProduct()
        {
            var newProduct = new Product()
            {
                Id = ProductId,
                Name = ProductName,
            };

            MyProducts.Add(newProduct);
            ProductId++;
            ProductName = string.Empty;
        }
    }
}
