using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MVVMUd.ViewModels
{
    public class Person2ViewModel : INotifyPropertyChanged
    {
        private string name;
        private string city;
        private int age;
        private string message;

        public string Name
        {
            get => name;
            set { name = value;
                OnPropertyChanged();
            }
        }

        public string City
        {
            get => city;
            set { city = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get => message;
            set
            {
                message = value;
                OnPropertyChanged();
            }
        }

        //Commands
        public ICommand ShowDetailsCommand { get;}
        public ICommand ClearCommand { get; }
        public ICommand GreetCommand { get; }

        public Person2ViewModel()
        {
            ShowDetailsCommand = new Command(OnShowDetails);
            ClearCommand = new Command(OnClear);
            GreetCommand = new Command(OnGreet);
        }

        private void OnShowDetails()
        {
            Message= $"Name: {Name}, Age: {Age}, City: {City}";
        }

        private void OnClear()
        {
            Name = string.Empty;
            Age = 0;
            City = string.Empty;
            Message = string.Empty;
        }

        private void OnGreet()
        {
            Message=string.IsNullOrWhiteSpace(Name)? "Please enter your name!" : $"Hello, {Name}!";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        
    }
}
