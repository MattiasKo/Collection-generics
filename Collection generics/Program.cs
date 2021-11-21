//Mattias Kokkonen Sut21
using System;
using System.Collections.Generic;
using System.Linq;


namespace Collection_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee()
            {
                _ID = 100,
                _Name = "Mattias",
                _Gender = "Male",
                _Salery = 10500
            };
            Employee E2 = new Employee()
            {
                _ID = 101,
                _Name = "Anas",
                _Gender = "Male",
                _Salery = 25000
            };
            Employee E3 = new Employee()
            {
                _ID = 102,
                _Name = "Lisa",
                _Gender = "Female",
                _Salery = 12500
            };
            Employee E4 = new Employee()
            {
                _ID = 103,
                _Name = "Olle",
                _Gender = "Male",
                _Salery = 500
            };
            Employee E5 = new Employee()
            {
                _ID = 104,
                _Name = "Erika",
                _Gender = "Female",
                _Salery = 105000
            };
            Stack<Employee> StackEmp = new Stack<Employee>();
            StackEmp.Push(E1);
            StackEmp.Push(E2);
            StackEmp.Push(E3);
            StackEmp.Push(E4);
            StackEmp.Push(E5);
            
            foreach (Employee emps in StackEmp)
            {
                Console.WriteLine(emps._ID + "-" + emps._Name + "-" + emps._Gender + "-" + emps._Salery);
                Console.WriteLine(StackEmp.Count+" = is left in the stack.");
            }

            Console.WriteLine("POP----------------------");
           
            Employee EmployPop1 = StackEmp.Pop();
            Console.WriteLine(StackEmp.Count+" = is left in the stack.");
            Console.WriteLine(EmployPop1._ID+"-"+ EmployPop1._Name+"-"+ EmployPop1._Gender+"-"+ EmployPop1._Salery);

            Employee EmployPop2 = StackEmp.Pop();
            Console.WriteLine(StackEmp.Count + " = is left in the stack.");
            Console.WriteLine(EmployPop2._ID + "-" + EmployPop2._Name + "-" + EmployPop2._Gender + "-" + EmployPop2._Salery);

            Employee EmployPop3 = StackEmp.Pop();
            Console.WriteLine(StackEmp.Count + " = is left in the stack.");
            Console.WriteLine(EmployPop3._ID + "-" + EmployPop3._Name + "-" + EmployPop3._Gender + "-" + EmployPop3._Salery);

            Employee EmployPop4 = StackEmp.Pop();
            Console.WriteLine(StackEmp.Count + " = is left in the stack.");
            Console.WriteLine(EmployPop4._ID + "-" + EmployPop4._Name + "-" + EmployPop4._Gender + "-" + EmployPop4._Salery);

            Employee EmployPop5 = StackEmp.Pop();
            Console.WriteLine(StackEmp.Count + " = is left in the stack.");
            Console.WriteLine(EmployPop5._ID + "-" + EmployPop5._Name + "-" + EmployPop5._Gender + "-" + EmployPop5._Salery);

            Console.WriteLine("Peek och Pop------------------");

            StackEmp.Push(E1);
            StackEmp.Push(E2);
            StackEmp.Push(E3);
            StackEmp.Push(E4);
            StackEmp.Push(E5);


 
                Employee PeekEmp = StackEmp.Peek();
            for (int i = 0; i < 5; i++)

            {

                StackEmp.Peek();
                Console.WriteLine(PeekEmp._ID + "-" + PeekEmp._Name + "-" + PeekEmp._Gender + "-" + PeekEmp._Salery);
                Console.WriteLine(StackEmp.Count + " = is left in the stack.");
                StackEmp.Pop(); 
                
            }
            if (StackEmp.Contains(E3))
            {
                Console.WriteLine("Is in stack.");
            }
            else
            {
                Console.WriteLine("Is not in stack.");
            }

            Console.WriteLine("------------Del 2-------------------");
            //Del 2
            List<Employee> listEmp = new List<Employee>();
            listEmp.Add(E1);
            listEmp.Add(E2);
            listEmp.Add(E3);
            listEmp.Add(E4);
            listEmp.Add(E5);
            if (listEmp.Contains(E2))
            {
                Console.WriteLine("List contains E2");
            }
            else
            {
                Console.WriteLine("List doesnt contain E2");
            }

            if(listEmp.Exists(s => s._Gender.Contains("Male")))
            {
                Console.WriteLine("Male does exist.");
            }
            else
            {
                Console.WriteLine("Male doesnt exist");
            }
            Employee FindMale = listEmp.Find(f => f._Gender == "Male");
            Console.WriteLine(FindMale._ID+"-"+FindMale._Name+"-"+FindMale._Gender+"-"+FindMale._Salery);

            List<Employee> employed = listEmp.FindAll(fa => fa._Gender == "Male");
            foreach (Employee Es in employed)
            {
                Console.WriteLine(Es._ID + "-" + Es._Name + "-" + Es._Gender + "-" + Es._Salery);
            }
            Console.ReadKey();
        }


    }
       
}
