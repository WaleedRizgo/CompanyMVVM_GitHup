using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMVVM.Application;
using CompanyMVVM.DTO;

namespace CompanyMVVM.ViewModel
{
   public class MainViewModel
    {
        //connection line between ViewModel and the Application during Dataprovider and then Data Entity
        private IDataProvider _dataprovider; // to Access to Employees 
        private IList<Employee> _employees;
        

        public IList<Employee> Employees
        {
            get { return _employees ?? (_employees = _dataprovider.GetEmployees()); } // اذا مو صفر يرجع واذا لا يروح لجانب الأيمن
        }
        public MainViewModel(IDataProvider dataProvider)
        {
            _dataprovider = dataProvider;
        }

        public MainViewModel(DataProvider dataProvider)
        {
       
        }
    }

}
