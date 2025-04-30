using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewDemo.MVVM.Models;

namespace CollectionViewDemo.MVVM.ViewModels
{
    public class DataViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public DataViewModel()
        {
            Products = new ObservableCollection<Product> {
            new Product
            {
                Name = "Yogurt",
                Price = 60.0m,
                Image = "yogurt.png",
                HasOffer = false,
                Stock = 28
            },
            new Product
            {
                Name = "Watermelon",
                Price = 80.0m,
                Image = "watermelon.png",
                HasOffer = false,
                Stock = 90
            },
            new Product
            {
                Name = "Tomato",
                Price = 120.0m,
                Image = "tomato.png",
                HasOffer = true,
                OfferPrice=100.0m,
                Stock = 76
            },
            new Product
            {
                Name = "Banana",
                Price = 45.0m,
                Image = "banana.png",
                HasOffer = false,
                Stock = 79
            },
            new Product
            {
                Name = "Apple",
                Price = 45.0m,
                Image = "apple.png",
                HasOffer = false,
                Stock = 79
            }
           };
        }
    }


}
