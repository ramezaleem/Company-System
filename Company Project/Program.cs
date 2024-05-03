using Company.BLL.Repositories;
using Company.DAL.DomainModels;
using System;

namespace Company_Project
{
   class Program
   {
      static void Main ( string[] args )
      {

         EmployeeRepo e1 = new EmployeeRepo();
         ManagerRepo m1 = new ManagerRepo();
         AdminRepo a1 = new AdminRepo();
         Console.WriteLine("\t\t\t\t\tWelcome To The Simple Registration\n");
         for ( ; ; )
         {
            Console.WriteLine("Create :\n\n1- Employee\t2- Manager\t3- Admin\n\nGet:\n4- Employee\t5- Manager\t6- Admin\n7- Exit\n");
            Console.Write("Enter Choise : ");
            int choise = int.Parse(Console.ReadLine());
            switch ( choise )
            {
               case 1:
                  e1.createEmployee();
                  break;
               case 2:
                  m1.createManager();
                  break;
               case 3:
                  a1.createAdmin();
                  break;
               case 4:
                  e1.getEmployee();
                  break;
               case 5:
                  m1.getManager();
                  break;
               case 6:
                  a1.getAdmin();
                  break;
               case 7:
                  start:
                  Console.WriteLine("Thank you have a nice day :)");
                  break;
               default:
                  Console.WriteLine("Error In Your Number");
                  break;
               goto start;
            }
            if ( choise == 7 )
            {
               break;
            }

         }

      }
   }
}
