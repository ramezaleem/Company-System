using Company.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.Repositories
{
   public class ManagerRepo
   {
      List<Manager> managers = new List<Manager>();
      public void createManager ()
      {
         Manager m1 = new Manager();
         Console.WriteLine("Enter Name :");
         m1.Name = Console.ReadLine();
         Console.WriteLine("Enter ID : ");
         m1.ID = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter Age : ");
         m1.Age = int.Parse(Console.ReadLine());
         managers.Add(m1);
         Console.WriteLine("Manager Created :)");
      }
      public void getManager ()
      {
         foreach ( var item in managers )
         {
            Console.WriteLine($"Name : {item.Name}, ID : {item.ID}, Age: {item.Age}");
         }
      }
   }
}
