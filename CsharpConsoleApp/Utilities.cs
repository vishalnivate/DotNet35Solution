using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsoleApp
{
    public delegate bool DelFilter<S>(S value);
    public static class Utilities
    {
        //public static List<Employee> Filter(this List<Employee> empList, decimal salary)
        //{
        //    List<Employee> lstList = new List<Employee>();
        //    lstList = empList.Where(c => c.Salary > salary).ToList();
        //    return lstList;
        //}

        public static List<T> Filter<T>(this List<T> sourceList, DelFilter<T> del)
        {
            List<T> lstList = new List<T>();
            foreach (T item in sourceList)
            {
                if (del(item))
                {
                    lstList.Add(item);
                }
            }
            return lstList;
        }

    }
}
