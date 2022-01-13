// 1)Create Student class (id, name, dateofbirth)
  // - Create constructors, getters and setters
// Create array of Student class and store few objects in it
    // - Demonstrate how to iterate over the array and call the display method for each student
 
// Take Student data as input from the user, store it in Student object
    // - Repeat the above process using loops
    // - Use Arrays to store the Student objects as covered in scenario2
    // - Finally iterate over the array to display all the collected data(Use a indexer to expose the student array)
 
// Do the CRUD operations for student

// **************************************************************************************************************



using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Student {
        int studentid;
        string name;
        string  dateofbirth;

        public Student(int studentid, string name, string dateofbirth)
        {
            this.studentid = studentid;
            this.name = name;
            this.dateofbirth = dateofbirth;
        }
        public Student() { }

        public int Id { get { return studentid; } set { studentid = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string DateofBirth { get { return dateofbirth; } set { dateofbirth = value; } }
        public override string ToString()
        {
            return "Student details: "+Id+" " + Name + " " + DateofBirth+" ";
        }
    }
    class AraryofStudent
    {
        public Student addStudent(int studentid, string name, string dateofbirth)
        {
            Student student;
            student = new Student(studentid, name, dateofbirth);
            return student;
        }
        public void RemoveStudent(Student[] stud,int studentid)
        {
            int length = stud.Length;
            for(int i=0;i<stud.Length;i++)
            {
                if (stud[i].Id == studentid)
                {
                    for(int j=i;j< stud.Length-1;j++)
                    {
                        stud[j] = stud[j + 1];
                    }
                    length--;
                    break;
                }
            }
            Console.WriteLine("After deleting");
            for(int i=0;i<length;i++)
            {
                Console.WriteLine(stud[i]);

            }

        }

        public void UpdateStudent(Student[] s,int studentid)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Id == studentid)
                {
                    Console.WriteLine("Enter name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter dob:");
                    string dob = Console.ReadLine();
                    s[i]= new Student(studentid, name, dob); 
                }
            }
        }
    }
    
        public class Inheritance1
         {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter how many students data you have to entered");
            int count = Int32.Parse(Console.ReadLine());
            Student[] s;
            s = new Student[count];
            AraryofStudent araryofstudent = new AraryofStudent();
            for (int i=0;i<count;i++)
            {
                Console.WriteLine("Enter Data:\n"+
                    "ID "+" Name "+" dateofbirth(dd-mm-yyyy)"
                    );
                int id = Int32.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                string dateofbirth = Console.ReadLine();
                s[i] = araryofstudent.addStudent(id, name, dateofbirth);
            }
            //helper1(s);
            while (true)
            {
                Console.WriteLine("Enter the choice: 1:Display 2:Delete 3:Update 4:Exit");
                int choice = Int32.Parse(Console.ReadLine());
                if(choice==1)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        Console.WriteLine(s[i]);

                    }
                }
                else if(choice ==2)
                {
                    Console.WriteLine("Enter id to delete");
                    int deid = Int32.Parse(Console.ReadLine());
                    araryofstudent.RemoveStudent(s, deid);
                }
                else if(choice == 3)
                {
                    Console.WriteLine("Enter id to update");
                    int deid = Int32.Parse(Console.ReadLine());
                    araryofstudent.UpdateStudent(s, deid);
                }
                else if(choice == 4)
                {
                    Console.WriteLine("Thank you");
                    break;
                }
                else
                {

                    Console.WriteLine("Enter correct input");
                }
            }
         
        }
        
    }
}

