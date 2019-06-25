using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SB_Admin_Razor.Models
{
    interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployeeByID(int id);
    }
}
