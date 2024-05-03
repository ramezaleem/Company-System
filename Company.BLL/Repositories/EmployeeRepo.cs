using Company.BLL.Services;
using Company.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.Repositories
{
   public class EmployeeRepo
   {
      List<Employee> employees = new List<Employee>();
      public void createEmployee ()
      {
         Employee e1 = new Employee();
         Console.WriteLine("Enter Name :");
         e1.Name = Console.ReadLine();
         Console.WriteLine("Enter ID : ");
         e1.ID = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter Age : ");
         e1.Age = int.Parse(Console.ReadLine());
         employees.Add(e1);
         Console.WriteLine("Employee Created :)");
      }
      public void getEmployee ()
      {
         foreach ( var item in employees )
         {
            Console.WriteLine($"Name : {item.Name}, ID : {item.ID}, Age: {item.Age}");
         }
      }
   }
}
