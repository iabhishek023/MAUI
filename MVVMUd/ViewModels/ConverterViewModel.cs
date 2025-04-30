using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMUd.Models;

namespace MVVMUd.ViewModels
{
    public class ConverterViewModel
    {
        public Data Data { get; set; }

        public ConverterViewModel()
        {
            Data = new Data
            {
                Married = "YES"
            };
        }
    }
}
