using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data;

namespace LinqToSqlConApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataContext contex = new DataContext(@"Server=M-30;Initial Catalog=Northwind;Integrated Security=true;");
            Table<Category> categoryTable = contex.GetTable<Category>();
            Table<Products> PrdTable = contex.GetTable<Products>();
            contex.Log = Console.Out;
            //Qurey Expression
            //var result = from c in categoryTable
            //             select c;

            //With Anonymous Table
            //var result = from c in categoryTable
            //             select new { catId = c.CategoryID, catName = c.CategoryName, Desc = c.Description };

            //With Lambda Expression
            //var result = from c in categoryTable.Select(c => new { CID = c.CategoryID, CName = c.CategoryName, Desc =        c.Description });

            // Product Table Get All Record From Product Where Category Id 2
            //With Anonymous Table
            //var result = from p in PrdTable
            //             select new { PId = p.ProductID, PName = p.ProductName, UnitPrice = p.UnitPrice, CatId = p.CategoryID };

            //Qurey Expression
            //var result = from c in categoryTable
            //             select c;

            //With Lambda Expression
            //var result = from c in PrdTable
            //             where c.CategoryID == 2
            //             select c;

            //var result = from p in PrdTable
            //             where p.CategoryID == 2
            //             select new { PId = p.ProductID, PName = p.ProductName, UnitPrice = p.UnitPrice, CatId = p.CategoryID };

            //var result = from p in PrdTable.Where(p=>p.CategoryID==2)
            //             .Select(p=> new { p.ProductID,  p.ProductName,  p.UnitPrice,p.CategoryID }).ToList();

            #region Get All Product With its CategoryName
            //var result = (from c in categoryTable
            //              join p in PrdTable
            //              on c.CategoryID equals p.CategoryID
            //              where p.UnitPrice > 30
            //              select new { p.ProductID, p.ProductName, c.CategoryID, c.CategoryName }).ToList();

            //var result = PrdTable.Join(categoryTable, p => p.CategoryID, c => c.CategoryID, (p, c) => new { p.ProductID, p.ProductName, c.CategoryID, c.CategoryName }).Where(c=>c.CategoryID==2).ToList();
            #endregion

            #region Get Each Category with the no Of Products it has
            //var result = (from p in PrdTable
            //              group p by p.CategoryID into grp
            //              select new { CatId = grp.Key, NoofPrd = grp.Count() }).ToList();

            //var result = PrdTable.GroupBy(p => p.CategoryID).Select(p => new { CatId = p.Key, NoofPrd = p.Count() }).ToList();

            //var result = (from c in categoryTable
            //              join p in PrdTable
            //              on c.CategoryID equals p.CategoryID
            //              group p by c.CategoryName into grp
            //              select new { CatId = grp.Key, NoofPrd = grp.Count() }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get All the CategoryName with the noof product and List Products
            //var result = (from c in categoryTable
            //              join p in PrdTable
            //              on c.CategoryID equals p.CategoryID
            //              group p by c.CategoryName).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}-----{item.Count()}");
            //    foreach (var grp in item)
            //    {
            //        Console.WriteLine($"\t\n{grp.ProductName}");
            //    }
            //}
            #endregion

            #region Get Data Using Assocition
            var result = (from p in PrdTable
                          select new { p.ProductName, p.Cat.CategoryName }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            } 
            #endregion
        }
    }
}
