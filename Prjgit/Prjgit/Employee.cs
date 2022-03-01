using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjgit
{
    
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; } 
        
        public void getemployee()
        {
            Console.WriteLine("Enter the id");
          id=Convert.ToInt32(Console.writeline());
            Console.Writeline("Enter Your name");
           name=Console.WriteLine();

        }
        public void displayemploye()
        {

        }
    }
}
