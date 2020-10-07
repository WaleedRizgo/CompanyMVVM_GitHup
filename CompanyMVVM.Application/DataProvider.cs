using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMVVM.DTO;

namespace CompanyMVVM.Application
{
  public  class DataProvider
    {
        private CompanyEntities _companyEntities = new CompanyEntities();


        public IList<Employee> GetEmployees()
        {
            return _companyEntities.Employees.ToList();
        }

        public Employee GetEmployee(int empID)
        {
            return _companyEntities.Employees.FirstOrDefault(c => c.EmpID == empID);
        }
    }
}
