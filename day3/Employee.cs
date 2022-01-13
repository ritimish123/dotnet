using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Employee
    {
        public string name { get; set; }
        public int empId { get; set; }
        public double salary { get; set; }
        public Employee(int empId =94 , String name = "Ritika", double salary = 28546.95)
        {
            this.empId = empId;
            this.name = name;
            this.salary = salary;
        }
        public void empDetails()
        {
            Console.WriteLine("Employee Id:{0},", empId);
            Console.WriteLine("Employee Name:{0},", name);
            Console.WriteLine("Employee Salary:{0},", salary);
            Console.ReadLine();
        }
    }
    class Manager : Employee 
    {
        public string type;
        public Manager (int empId,String name,double salary ,String type) : base(empId, name, salary)
        {

            this.type = type;
        }

        public void managerdetails()
        {
            Console.WriteLine("ManagerId:{0},", empId);
            Console.WriteLine("Managername:{0},", name);
            Console.WriteLine("Managersalary:{0},", salary);
            Console.WriteLine("Managertype:{0},", type);
        }
    }

    class Clerk : Employee
    {
        public int speed, accuracy;
        public Clerk(int empId, String name, double salary, int speed, int accuracy) : base(empId, name, salary) 
        {
            this.speed = speed;
            this.accuracy = accuracy;

        }

        public void clerkDetails()
        {
            Console.WriteLine("clerk Id:{0},", empId);
            Console.WriteLine("clerk Name:{0},", name);
            Console.WriteLine("clerk salary:{0},", salary);
            Console.WriteLine("clerk speed:{0},", speed);
            Console.WriteLine("clerk accuracy:{0},", accuracy);

        }
    }

    public class MyClass
    {
        public static void Main(String[] args)
        {
            Employee e = new Employee();
            Manager m = new Manager(12, "Kaushiki", 98463.0, "General Manager");
            Clerk c = new Clerk(1, "Abhika", 15687.82, 8, 3);
            e.empDetails();
            m.managerdetails();
            c.clerkDetails();
            Console.ReadLine();
        }
    

    }
    