using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    public class EmployeesForEachCompany
    {
        //CountOfEmployeesForEachCompany(new List<Employee>()
        //    {
        //        new Employee()
        //        {
        //            Company = "idscan",
        //            Age = 20
        //        },
        //        new Employee()
        //        {
        //            Company = "idscan",
        //            Age = 10
        //        },
        //        new Employee()
        //        {
        //            Company = "old",
        //            Age = 50
        //        },
        //    });
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> res = new Dictionary<string, int>();
            var xx = employees.GroupBy(x => x.Company)
               .Select(g => new
               {
                   Average = g.Average(p => p.Age),
                   Company = g.Key
               });
            return xx.OrderBy(x => x.Company).ToDictionary(x => x.Company, x => Convert.ToInt32(x.Average));
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            var xx = employees.GroupBy(x => x.Company)
               .Select(g => new
               {
                   Count = g.Count(),
                   Company = g.Key
               });
            return xx.OrderBy(x => x.Company).ToDictionary(x => x.Company, x => x.Count);
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            var xx = employees.GroupBy(x => x.Company)
               .Select(g => new
               {
                   oldestEmp = g.OrderByDescending(e => e.Age).First(),
                   Company = g.Key
               });
            return xx.OrderBy(x => x.Company).ToDictionary(x => x.Company, x => x.oldestEmp);
        }

        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Company { get; set; }
        }
    }
}
