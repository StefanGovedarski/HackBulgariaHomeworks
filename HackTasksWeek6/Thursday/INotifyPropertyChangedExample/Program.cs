using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace INotifyPropertyChangedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee(25, 1000, "gg", "slave");
            Employee emp2 = new Employee(25, 1000, "ge", "slave");
            Employee emp3 = new Employee(25, 1000, "go", "slave");
            Employee emp4 = new Employee(25, 1000, "ga", "slave");
            Employee emp5 = new Employee(25, 1000, "gi", "slave");
            employees.Add(emp1); employees.Add(emp2); employees.Add(emp3); employees.Add(emp4); employees.Add(emp5);
            emp1.PropertyChanged += Emp_PropertyChanged;
            emp2.PropertyChanged += Emp_PropertyChanged;
            emp3.PropertyChanged += Emp_PropertyChanged;
            emp4.PropertyChanged += Emp_PropertyChanged;
            emp5.PropertyChanged += Emp_PropertyChanged;
            emp1.Name = "gege";
            emp3.Position = "slavemaster";
        }

        private static void Emp_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("A property was changed");
            Console.WriteLine("The changed property is {0}",e.PropertyName);
            Console.WriteLine("The hash code is: {0}",sender);
        }
    }

    class Employee : INotifyPropertyChanged
    {
        private int age;
        private int salary;
        private string name;
        private string position;

        public Employee(int age,int salary,string name,string position)
        {
            this.Name = name;
            this.Salary = salary;
            this.Age = age;
            this.Position = position;
        }


        public int Age{get { return age; }set{age = value;if (PropertyChanged != null){PropertyChanged(Age.GetHashCode(), new PropertyChangedEventArgs("Age"));}}}
        public int Salary { get { return salary; } set {salary =value; if (PropertyChanged != null) { PropertyChanged(Salary.GetHashCode(),new PropertyChangedEventArgs("Salary")); } } }
        public string Name { get {return name; } set { name = value; if (PropertyChanged != null) { PropertyChanged(Name.GetHashCode(), new PropertyChangedEventArgs("Name")); } } }
        public string Position { get { return position; } set { position = value; if (PropertyChanged != null) { PropertyChanged(Position.GetHashCode(), new PropertyChangedEventArgs("Position")); } } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
