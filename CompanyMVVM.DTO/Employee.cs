//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyMVVM.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Projects = new HashSet<Project>();
        }
    
        public int EmpID { get; set; }
        public string EmpFName { get; set; }
        public string EmpLName { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<Project> Projects { get; set; }
    }
}
