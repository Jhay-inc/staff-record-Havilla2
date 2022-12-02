using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;

namespace StaffRecords
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome To Havilla Secondary School");
            int choice = 1;
            int choice2 = 2;

            Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
            Console.WriteLine("Welcome To Main Menu, Please Enter Your Choice\n Press 1 for Non-Academic Staff or Press 2 for Academic Staff" );
            Console.WriteLine("Press 2 to exit Program");
            Console.WriteLine();
            string principalRole = "Pricipal Role";
            string role = principalRole;

            

            Console.Write("\nEnter Your Choice : ");
            string input = Console.ReadLine();


            while (true)
            {
                if (int.TryParse(input, out choice))
                {

                    if (choice.Equals(1))
                    {
                        Console.WriteLine("1 Press");
                        Console.Clear();
                        Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
                        Console.WriteLine("Welcome To Empolyee, Please Enter Your Choice\n");
                        Console.WriteLine("Press 1 to list all employees");
                        Console.WriteLine("Press 2 to add a new employee");
                        Console.WriteLine("Press 3 to Update employee");
                        Console.WriteLine("Press 4 to Delete employee");
                        Console.WriteLine("Press 5 to return to main menu");

                        Console.Write("\nEnter Your Choice : ");
                        string input2 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input2, out choice2))
                            {
                                if (choice2.Equals(1))
                                {
                                    Console.WriteLine("\t\t\t-------Empolyee Details-------");
                                    Console.WriteLine("\n\tID \t Name \t\t Email \t\tPassword \t Department \t Role \t DateCreated");

                                    //employee.ForEach(p => p.ListAllEmpolyee());

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(2))
                                {
                                    Console.WriteLine("\n\t\t\t------- Add Empolyee -------");

                                    Console.Write("Enter Empolyee ID : ");
                                    int Employee_Id = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter firstName : ");
                                    string firstName = Console.ReadLine();
                                    Console.Write("Enter secondName : ");
                                    string secondName = Console.ReadLine();
                                    Console.Write("Enter Email : ");
                                    string Email = Console.ReadLine();
                                    Console.Write("Enter Password : ");
                                    string Password = Console.ReadLine();
                                    Console.Write("Enter Department : ");
                                    string Department = (Console.ReadLine());
                                    Console.Write("Enter Role : ");
                                    string Role = Console.ReadLine();
                                    Console.Write("Enter DateCreated : ");
                                    string DateCreated = Console.ReadLine();

                                    Employees emps = new Employees(Employee_Id, firstName, secondName, Email, Password, Department, Role, DateCreated);

                                    //Employees.Add_Employee(employee);


                                    //Employees employees = new Employees();
                                    //Console.Write("Enter Empolyee ID : ");
                                    //int Employee_id = Convert.ToInt32(Console.ReadLine());
                                    //var empinfo = employee.Where(e => e.Empolyee_ID == Employee_id).FirstOrDefault();

                                    //if (empinfo == null)
                                    //{
                                    //    empinfo = emp;
                                    //    empinfo.Empolyee_ID = 0;
                                    //}



                                }
                            }
                        }
                    }
                }
            }
        }
    }
}




