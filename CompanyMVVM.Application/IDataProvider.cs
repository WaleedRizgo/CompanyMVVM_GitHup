using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMVVM.DTO;

namespace CompanyMVVM.Application
{
   public  interface IDataProvider
    {
        IList<Employee> GetEmployees();
        Employee GetEmployee(int empID);
    }
}
