using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise7
{
    internal class Program
    {
        public class User
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Adress { get; set; }
            public int DOB { get; set; }
        }



        static void Main(string[] args)
        {
            List<User> listuser = new List<User>
             {
                new User {ID=1, Name="Jhon", Adress="London", DOB= 2001-04-01 },
                new User {ID=2, Name="Lenny", Adress="New York", DOB=1977-12-11 },
                new User {ID=3, Name="Andrew", Adress="Boston", DOB=1987-02-22 },
                new User {ID=4, Name="Peter", Adress="Prague", DOB=1936-03-24 },
                new User {ID=5, Name="Anna", Adress="Bratislava", DOB=1973-11-18 },
                new User {ID=6, Name="Albert", Adress="Bratislava", DOB= 1940-12-11 },
                new User {ID=7, Name="Adam", Adress="Trnava", DOB=1983-12-01 },
                new User {ID=8, Name="Robert", Adress="Bratislava", DOB= 1935-05-15 },
                new User {ID=9, Name="Robert", Adress="Prague", DOB= 1988-03-14 },
            };
            IEnumerable<User> result = (from A in listuser
                                        where A.Adress == "Bratislava"
                                        select A);

            result.ToList().ForEach(A => Console.WriteLine(A.Name));
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise7
{
    internal class Program
    {


        public class Cars
        {
            public string Name { get; set; }
            public int cost { get; set; }

        }


        static void Main(string[] args)
        {
            List<Cars> carlist = new List<Cars>
             {
                new Cars { Name="Audi", cost = 52642 },
                new Cars { Name="Mercedes", cost = 57127 },
                new Cars { Name="Skoda", cost = 9000 },
                new Cars { Name="Volvo", cost = 29000 },
                new Cars { Name="Bently", cost = 350000 },
                new Cars { Name="Citroen", cost = 21000 },
                new Cars { Name="Hummer", cost = 41400 },
                new Cars { Name="Volkswagen", cost = 21600 },
            };
            IEnumerable<Cars> result = (from A in carlist
                                        where A.cost > 30000 && A.cost < 100000
                                        select A);

            result.ToList().ForEach(A => Console.WriteLine(A.Name));
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Exercise7
{
    internal class Program
    {


        public class Employees
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public int Salary { get; set; }

        }


        static void Main(string[] args)
        {
            List<Employees> userlist = new List<Employees>
             {
                new Employees { FName="John", LName= "Doe", Salary = 1230 },
                new Employees { FName="Lucy", LName= "Novak", Salary = 670 },
                new Employees { FName="Ben", LName= "Walter", Salary = 2050 },
                new Employees { FName="Robin", LName= "Brown", Salary = 2300 },
                new Employees { FName="Amy", LName= "Doe", Salary = 1250 },
                new Employees { FName="John", LName= "Draker", Salary = 1190},
                new Employees { FName="Janet", LName= "Doe", Salary = 980 },
                new Employees { FName="Albert", LName= "Novak", Salary = 1930 },


            };
            IEnumerable<Employees> result = (from Employee in userlist
                                             orderby Employee.LName ascending, Employee.Salary ascending
                                             select Employee);


            result.ToList().ForEach(Employee => Console.WriteLine($"{Employee.LName}, {Employee.Salary}"));
            //Console.ReadKey();

            IEnumerable<Employees> result1 = (from Employee1 in userlist
                                              where Employee1.Salary > 1500
                                              select Employee1);


            result1.ToList().ForEach(Employee1 => Console.WriteLine($"Salary: {Employee1.Salary}"));
            Console.ReadKey();
        }
    }
}