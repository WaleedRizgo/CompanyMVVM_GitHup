using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMVVM.Application;

namespace CompanyMVVM.ViewModel
{
   public  class ModelViewLocator 
    {
        private static MainViewModel _mainViewModel;
        public static MainViewModel Main
        {
            get
            {
                return _mainViewModel ?? (_mainViewModel = new MainViewModel(new DataProvider()));
            }

        }
    }
}
