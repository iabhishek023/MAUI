using BindingMaui.Models;
using Microsoft.Maui.Controls;

namespace Binding
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var person = new Person
            {
                Name = "Abhishek",
                Phone = "56789",
                Address = "bewhb dhbch"

            };

            Binding personBinding = new Binding();

            personBinding.Source = Person;
        }
    }

}
