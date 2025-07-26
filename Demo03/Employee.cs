using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    internal class Employee : ICloneable, IComparable
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        public double Salary { set; get; }

        public object Clone()
        {
            return new Employee() { Id = this.Id, Name = this.Name, Age = this.Age, Salary = this.Salary };
        }

        public int CompareTo(object? obj)
        {
            Employee emp = obj as Employee;

            if (this.Age > emp.Age)
            {
                return 1;
            }

            else if (this.Age < emp.Age)
            {
                return -1;
            }

            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Age = {Age}, Salary = {Salary}";
        }
    }
}
