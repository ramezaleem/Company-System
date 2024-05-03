using Company.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.Repositories
{
   public class AdminRepo
   {
      List<Admin> admins = new List<Admin>();
      public void createAdmin ()
      {
         Admin a1 = new Admin();
         Console.WriteLine("Enter Email : ");
         a1.Email = Console.ReadLine();
         Console.WriteLine("Enter Name :");
         a1.Name = Console.ReadLine();
         Console.WriteLine("Enter ID : ");
         a1.ID = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter Age : ");
         a1.Age = int.Parse(Console.ReadLine());
         admins.Add(a1);
         Console.WriteLine("Employee Created :)");
      }
      public void getAdmin ()
      {
         foreach ( var item in admins )
         {
            Console.WriteLine($"Name : {item.Name}, Email : {item.Email}, ID : {item.ID}, Age: {item.Age}");
         }
      }
   }
}
