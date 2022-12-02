using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecords
{
    public class Employees
    {

        public int Empolyee_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
        public DateTime DateCreated { get; set; }
        public string SecondName { get; }
        public string DateCreated1 { get; }

        public Employees(int empolyee_ID, string firstName, string lastName, string email, string password, string department, string role, DateTime dateCreated)
        {
            Empolyee_ID = empolyee_ID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Department = department;
            Role = role;
            DateCreated = dateCreated;

            List<Employees> employee = new List<Employees>();
            employee.Add(new Employees(empolyee_ID, firstName, lastName, email, password, department, role, dateCreated));
            employee.Add(new Employees(empolyee_ID, firstName, lastName, email, password, department, role, dateCreated));
            employee.Add(new Employees(empolyee_ID, firstName, lastName, email, password, department, role, dateCreated));
            employee.Add(new Employees(empolyee_ID, firstName, lastName, email, password, department, role, dateCreated));
            employee.Add(new Employees(empolyee_ID, firstName, lastName, email, password, department, role, dateCreated));

        }

        public Employees(int employee_Id, string firstName)
        {
        }

        public Employees(int employee_Id, string firstName, string secondName, string email, string password, string department, string role, string dateCreated) : this(employee_Id, firstName)
        {
            SecondName = secondName;
            Email = email;
            Password = password;
            Department = department;
            Role = role;
            DateCreated1 = dateCreated;
        }



        //List all empolyee
        public void DisplayAllEmpolyee()
        {
            Console.WriteLine("\n\t" + Empolyee_ID + "\t" + FirstName + "\t" + LastName + "\t" + Email + "\t" + Password + "\t" + Department + "\t" + Role + "\t" +DateCreated);
        }

        //add new Empolyee
        public static List<Employees> Add_Employee(List<Employees> employee, Employees emp)
        {

            employee.Add(emp);
            return employee;

        }

        internal static void Add_Employee(object employee, Employees emp)
        {
            
        }

        //public void GenerateID()
        //{
        //    string day, month, year, ID;
        //    string hr, min, sec;
        //    day = DateTime.Now.Date.Day.ToString();
        //    month = DateTime.Now.Month.ToString();
        //    year = DateTime.Now.Year.ToString();

        //    hr = DateTime.Now.Hour.ToString();
        //    min = DateTime.Now.Minute.ToString();
        //    sec = DateTime.Now.Second.ToString();

        //    Employee_ID.Text = "E-" + day + month + year + hr + min + sec;
        //}

    }
}

