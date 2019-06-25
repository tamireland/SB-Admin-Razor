using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SB_Admin_Razor.Models
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly DatabaseContext _dbContext;
        public EmployeeRepository(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }

        public Employee GetEmployeeByID(int id)
        {
            return _dbContext.Employees.FirstOrDefault(x => x.EmployeeId == id);

        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _dbContext.Employees;
        }

    }
}
