using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClientModel
{
  public class Employee
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string EmpAddress { get; set; }
    }

    public class EmployeeList
    {
        public List<Employee> empList { get; set; }
    }
}
