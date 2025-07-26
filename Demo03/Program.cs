using Demo03.Interface01;
using Demo03.Interface02;
using Demo03.Interface03;
using System.Text;

namespace Demo03
{


    internal class Program
    {
        static void PrintTenNumbers(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"series.Current: {series.Current}");
                series.Next();
            }

            series.Reset();
        }

        static void Main(string[] args)
        {
            #region Interface
            //// Interface: Reference Type
            //MyType myType = new MyType();
            //myType.Salary = 12000;
            //myType.MyFun();

            #endregion

            #region Interface Ex01
            //IMyType imyType; //IRef --> can refer to object from any class which implemented the interface 'IMyType'

            //imyType = new MyType();

            //imyType.Salary = 10000;
            //Console.WriteLine(imyType.Salary); //10000

            //imyType.MyFun();
            //imyType.Print();

            #endregion

            #region Interface Ex02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //PrintTenNumbers(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //PrintTenNumbers(seriesByThree);
            #endregion

            #region Interface Ex03
            //Car car = new Car();
            //Airplane airplane = new Airplane();

            //IMovable movable = car;
            //movable.Forward();

            //movable = airplane;
            //movable.Forward();

            //IFlyable flyable = airplane;
            //flyable.Forward();
            #endregion

            #region Shallow Copy vs Deep Copy (Array Of Value Type)
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //int[] Arr03 = { 7, 8 };

            //Arr02 = Arr01;  //Shallow Copy
            //Arr03 = (int[])Arr01.Clone();  //Deep Copy [copy the object state of the caller]


            //Console.WriteLine($"Arr01 Hashcode = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 Hashcode = {Arr02.GetHashCode()}");
            //Console.WriteLine($"Arr03 Hashcode = {Arr03.GetHashCode()}");
            #endregion

            #region Shallow Copy vs Deep Copy (Array Of String Type [Immutable Reference])
            //string[] Arr01 = { "Hussein", "Mahmoud", "Fouad" };
            //string[] Arr02 = { "Hisham", "Mohamed", "Essam" };
            //string[] Arr03 = { "Mariam", "Salah" };

            //Arr02 = Arr01;  //Shallow Copy
            //Arr03 = (string[])Arr01.Clone();  //Deep Copy [copy the object state of the caller]

            //Arr03[0] = "Esraa";

            //Console.WriteLine($"Arr01 Hashcode = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 Hashcode = {Arr02.GetHashCode()}");
            //Console.WriteLine($"Arr03 Hashcode = {Arr03.GetHashCode()}");


            //for (int i = 0; i < Arr01.Length; i++)
            //{
            //    Console.WriteLine($"Arr01[{i}] = {Arr01[i]}");
            //}

            //for (int i = 0; i < Arr01.Length; i++)
            //{
            //    Console.WriteLine($"Arr02[{i}] = {Arr02[i]}");
            //}

            //for (int i = 0; i < Arr03.Length; i++)
            //{
            //    Console.WriteLine($"Arr03[{i}] = {Arr03[i]}");
            //}
            #endregion

            #region Shallow Copy vs Deep Copy (Array Of StringBuilder Type [Mutable Reference])
            //StringBuilder[] Arr01 = new StringBuilder[]
            //{ new StringBuilder("Hussein"), new StringBuilder("Mahmoud"), new StringBuilder("Fouad")};

            //StringBuilder[] Arr02 = new StringBuilder[]
            //{ new StringBuilder("Hisham"), new StringBuilder("Mohamed"), new StringBuilder("Essam")};

            //StringBuilder[] Arr03 = new StringBuilder[] { new StringBuilder("Mariam"), new StringBuilder("Salah") };

            //Arr02 = Arr01;  //Shallow Copy
            //Arr03 = (StringBuilder[])Arr01.Clone();  //Deep Copy [copy the object state of the caller]

            //Arr03[0].Append(" Said");

            //Console.WriteLine($"Arr01 Hashcode = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 Hashcode = {Arr02.GetHashCode()}");
            //Console.WriteLine($"Arr03 Hashcode = {Arr03.GetHashCode()}");


            //for (int i = 0; i < Arr01.Length; i++)
            //{
            //    Console.WriteLine($"Arr01[{i}] = {Arr01[i]}");
            //}

            //for (int i = 0; i < Arr01.Length; i++)
            //{
            //    Console.WriteLine($"Arr02[{i}] = {Arr02[i]}");
            //}

            //for (int i = 0; i < Arr03.Length; i++)
            //{
            //    Console.WriteLine($"Arr03[{i}] = {Arr03[i]}");
            //}
            #endregion

            #region Built-in Interface01 [ICloneable]
            //Employee E01 = new Employee() { Id = 1, Name = "Hussein", Age = 25, Salary = 25000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Mahmoud", Age = 30, Salary = 40000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Fouad", Age = 50, Salary = 60000 };


            //E02 = E01; //Sallow Copy
            //E03 = (Employee)E01.Clone(); //Deep Copy

            //E02.Name = "Hisham"; //E01 will be changed
            //E03.Name = "Hosam"; //E01 won't be changed

            //Console.WriteLine($"E01 hashcode = {E01.GetHashCode()}");
            //Console.WriteLine($"E02 hashcode = {E02.GetHashCode()}");
            //Console.WriteLine($"E03 hashcode = {E03.GetHashCode()}");
            //Console.WriteLine();

            //Console.WriteLine(E01);
            //Console.WriteLine(E02);
            //Console.WriteLine(E03);
            #endregion

            #region Built-in Interface02 [IComparable]
            Employee[] employees = new Employee[2]
            {
                new Employee() {Id = 1, Name = "Hussein", Age = 25, Salary = 25000 },
                new Employee() { Id = 2, Name = "Mahmoud", Age = 40, Salary = 40000 }
            };


            Array.Sort(employees);  //Note: Array.Sort call the CompareTo the sorting will be base on age as implemented

            int isBigger = employees[0].CompareTo(employees[1]);
            //1 Caller > Parameter
            //-1 Caller < Parameter
            // 0  Caller = Parameter

            Console.WriteLine(isBigger);
            #endregion

            #region Built-in Interface03 [IComparer]
            //Employee[] employees = new Employee[2]
            //{
            //    new Employee() {Id = 1, Name = "Hussein", Age = 25, Salary = 60000 },
            //    new Employee() { Id = 2, Name = "Mahmoud", Age = 40, Salary = 40000 }
            //};


            //Array.Sort(employees, new EmployeeComparerSalary());


            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            #endregion
        }
    }
}
