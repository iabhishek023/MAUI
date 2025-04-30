using MVVMUd.Models;

namespace MVVMUd.ViewModels;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		
		BindingContext = new PersonViewModel();
	}
}