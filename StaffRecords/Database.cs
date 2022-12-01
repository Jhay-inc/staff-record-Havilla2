using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecords
{
    public class Database : Employees
    {
        public int employee_ID;
        public string firstName;
        public string lastName;
        public string email;
        public string password;
        public string department;
        public string role;
        public string dateCreated;




        public Database()
        {
            List<Employees> employee = new List<Employees>();
            employee.Add(new Employees(employee_ID, firstName, lastName, email, password, department, role, DateTime.Now));
            employee.Add(new Employees(employee_ID, firstName, lastName, email, password, department, role, DateTime.Now));
            employee.Add(new Employees(employee_ID, firstName, lastName, email, password, department, role, DateTime.Now));
            employee.Add(new Employees(employee_ID, firstName, lastName, email, password, department, role, DateTime.Now));
            employee.Add(new Employees(employee_ID, firstName, lastName, email, password, department, role, DateTime.Now));
        }

        Database employees = new Database();


    }
}



