using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Old Obj Initilization
            //Employee emp = new Employee();
            //emp.EmpName = "Vishal Nivate";
            //emp.EmpNo = 10092;
            //emp.Salary = 10000;
            //emp.Age = 26;
            //Console.WriteLine(emp); 
            #endregion

            #region New Obj Initlization
            //Employee emp = new Employee
            //{
            //    EmpName = "Vishal Nivate",
            //    EmpNo = 10092,
            //    Salary = 10000,
            //    Age = 26
            //};
            //Console.WriteLine(emp); 
            #endregion

            #region Collection Initilaztion
            List<Employee> empList = new List<Employee>
            {
               new Employee {EmpNo = 10092,EmpName = "Vishal",Salary = 15000,Age = 21},
               new Employee {EmpNo = 10093,EmpName = "Tushar",Salary = 14000,Age = 24},
               new Employee {EmpNo = 10094,EmpName = "Ani",Salary = 18000,Age = 25},
               new Employee {EmpNo = 15,EmpName = "Manasi",Salary = 28000,Age = 26},
               new Employee {EmpNo = 1005,EmpName = "Jignesh",Salary = 10000,Age = 27 },
               new Employee {EmpNo = 1542,EmpName = "Rahul",Salary = 29000,Age = 28 },
               new Employee {EmpNo = 1564,EmpName = "Rupesh Patil",Salary = 32000,Age = 30},
               new Employee {EmpNo = 10054,EmpName = "Rupesh Khedekar",Salary = 11000,Age = 31},
               new Employee {EmpNo = 0709,EmpName = "Vivek",Salary = 16000,Age = 25},
               new Employee {EmpNo = 1456,EmpName = "Vrushal",Salary = 16000,Age = 26},
               new Employee {EmpNo = 2559,EmpName = "Paresh",Salary = 10000,Age = 27},
               new Employee {EmpNo = 564,EmpName = "Hemant",Salary = 16000,Age = 26},
               new Employee {EmpNo = 1589,EmpName = "Rakesh",Salary = 35000,Age = 33},
               new Employee {EmpNo = 15474,EmpName = "Ramesh",Salary = 35000,Age = 35},
               new Employee {EmpNo = 2598,EmpName = "Danial",Salary = 35000,Age = 36},
               new Employee {EmpNo = 5554,EmpName = "Daina",Salary = 35000,Age = 38 },
               new Employee {EmpNo = 6665,EmpName = "Sheron",Salary = 45000,Age = 45},
               new Employee {EmpNo = 447,EmpName = "Maria",Salary = 45000,Age = 55},
               new Employee {EmpNo = 420,EmpName = "Farman",Salary = 40000,Age = 50 },
               new Employee {EmpNo = 840,EmpName = "Somnath",Salary = 36000,Age = 40 },
               new Employee {EmpNo = 123,EmpName = "Nutan",Salary = 35000,Age = 41 },
               new Employee {EmpNo = 478,EmpName = "Nitin",Salary = 30000,Age = 39},
               new Employee {EmpNo = 695,EmpName = "Swati",Salary = 14000,Age = 29},
               new Employee {EmpNo = 9854,EmpName = "Deepali",Salary = 25000,Age = 25},
               new Employee {EmpNo = 985,EmpName = "Mehul",Salary = 10000,Age = 22 },

            };
            //int cnt = 1;
            //for (int i = 0; i < empList.Count; i++)
            //{
            //    Console.WriteLine($"{cnt++} ->{empList[i]}");
            //}
            #endregion

            #region Extension Method
            //string name = "Vishal";
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(name.Vishal()); 
            #endregion


            #region Get All Emp with Age >26 using Delegate
            //int ctr = 1;
            //foreach (Employee item in empList.Filter(GetByAge))
            //{
            //    Console.WriteLine($"{ctr++} ->{item}");
            //} 
            #endregion

            #region Anonymous Function
            //int ctr = 1;
            //foreach (Employee item in empList.Filter(delegate (Employee e) { return e.Salary > 10000}))
            //{
            //    Console.WriteLine($"{ctr++} ->{item}");
            //}
            #endregion

            //int ctr = 1;
            //foreach (Employee item in empList.Filter(c => c.Salary > 15000))
            //{
            //    Console.WriteLine($"{ctr++} ->{item}");
            //}

            #region Using Lambada Expression Lambada is '=>'replace the word delegate
            //int ctr = 1;
            //foreach (Employee item in empList.Filter((Employee e) => { return e.Salary > 10000; }))
            //{
            //    Console.WriteLine($"{ctr++} ->{item}");
            //}
            #endregion

            #region LINQ to Object
            //List<Employee> emp = empList.Where(e => e.Age > 20).ToList();
            //var result = empList.Where(e => e.Age > 29).ToList();
            var result = empList.Where(e => e.EmpName.StartsWith("Vi")).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion


        }

        public static bool GetByAge(Employee emp)
        {
            if (emp.Age > 26) return true;
            return false;
        }
    }
}
