using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMUd.Models;

namespace MVVMUd.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }

        public PersonViewModel()
        {
            Person = new Person
            {
                Name = "Abhishek",
                Age = 20,
                Married=false,
                BirthDate=new DateTime(2002,12,23),
                Weight=64,
                Lunchtime=new TimeSpan(10,0,0)
            };
        }
    }
}
