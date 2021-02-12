using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1
{
    public class StudentRepository
    {
        public List<Department> GetDepartments()
        {
            StudentDBContext employeeDBContext = new StudentDBContext();
            return employeeDBContext.Departments.Include("Students").ToList();
        }
    }
}