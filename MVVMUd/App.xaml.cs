using MVVMUd.Fody;
using MVVMUd.Models;
using MVVMUd.ViewModels;
using MVVMUd.Views;

namespace MVVMUd
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Person2Page());
        }
    }
}