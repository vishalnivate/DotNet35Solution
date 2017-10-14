using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace LinqToSqlOrcConApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            NorthDataContext context = new NorthDataContext();
            context.Log = Console.Out;

            #region Get All Customer from London
            //var result = (from c in context.Customers
            //              where c.City == "London"
            //              select new { c.CustomerID, c.ContactName, c.CompanyName, c.City, c.Country }).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Insert Record in Table
            //Customer cusRec = new Customer
            //{

            //    CustomerID = "10092",
            //    CompanyName = "HDFC",
            //    ContactName = "Jignesh",
            //    City = "Mumbai",
            //    Country = "India"
            //};

            //context.Customers.InsertOnSubmit(cusRec);
            //try
            //{
            //    context.SubmitChanges();
            //    Console.WriteLine("Inserted....");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message.ToString());
            //}
            #endregion

            #region Update
            //var cust = context.Customers.FirstOrDefault(c => c.CustomerID == "10092");
            //Console.WriteLine($"CustId:{ cust.CustomerID},CmpName:{cust.CompanyName},City:{cust.City}");
            //cust.City = "Thane";
            //Console.ReadKey(true);
            //try
            //{
            //    context.SubmitChanges();
            //    //context.Transaction.Commit();
            //    Console.WriteLine("Updated....");
            //}
            //catch (ChangeConflictException ex)
            //{
            //    Console.WriteLine(ex.Message.ToString());
            //    context.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);
            //    context.SubmitChanges();
            //    Console.WriteLine("Updated After Concurruncy....");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message.ToString());
            //}
            #endregion

            #region Delete 
            //var cust = context.Customers.FirstOrDefault(c => c.CustomerID == "10092");
            //Console.WriteLine($"CustId:{ cust.CustomerID},CmpName:{cust.CompanyName},City:{cust.City}");
            //context.Customers.DeleteOnSubmit(cust);
            //try
            //{
            //    context.SubmitChanges();
            //    Console.WriteLine("Deleted....");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message.ToString());
            //}
            #endregion

            #region Store Procedure
            var result = context.CustOrderHist("ALFKI");
            foreach (var item in result)
            {
                Console.WriteLine($"\nProduct:{item.ProductName},\t Total:-{item.Total}");
            }
            #endregion
        }
    }
}
