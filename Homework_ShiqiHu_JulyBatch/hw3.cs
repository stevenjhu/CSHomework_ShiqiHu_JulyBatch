using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_ShiqiHu_JulyBatch
{
    public class hw3
    {
        //1. What are the six combinations of access modifier keywords and what do they do?
            /*
             * public: accessible from everywhere in a project
             * private: accessible only inside the same class or structure
             * protected: accessible inside the class and in all inherited classes
             * internal: accessible inside current project assembly
             * protected internal: accesible inside the assembly in which it's declared, or from within a derived class in another assembly.
             * private protected: accessible inside all inherited class and in current assembly
             */
        //2. What is the difference between the static, const, and readonly keywords when applied to a type member?
            /*
             * static: value change will be apply to every reference of this type; it belongs to the type, not its instances
             * const: the value is set once in the program and cannot be changed later on
             * readonly: the value can only be change via constructor
             */
        //3. What does a constructor do?
            /* 
             * Initialization of instances, including functions like set default values and limit instantiation
             */
        //4. Why is the partial keyword useful?
            /*
             * 1. Allows multiple people to work on the same project simultaneously
             * 2. Automatically generated source file does not need to be recreated for code to be added to the class
             * 3. Allows the usage of source generator
             */
        //5. What is a tuple?
            /*
             * A lightweight data structure that group multiple data elements together
             */
        //6. What does the C# record keyword do?
            /*
             * defines a init-only reference type that provides built-in functionalities such as equality
             */
        //7. What does overloading and overriding mean?
            /*
             * Overloading means redefine function of the same name in more than one form (different combination/type of parameters)
             * Overriding means in a derived class, creating a method of the same name and parameter from the base class.
             */
        //8. What is the difference between a field and a property?
            /*
             * field stores data, should be kept private or protected
             * properties gives access to the field safely and flexibly
             */
        //9. How do you make a method parameter optional?
            /*
             * by assigning default value to the parameter during method declaration
             */
        //10. What is an interface and how is it different from abstract class?
            /*
             * Interface supports multiple inheritance, but abstract class supports only one
             * Interface cannot have constructor, but abstract class can
             * Interface have members that are, by default, public and abstract, but abstract class can have both abstract and defined members
             * Interface cannot have fields, but abstract classes can
             */
        //11. What accessibility level are members of an interface?
            /*
             * The default member accessibility for interface is public. 
             */
        //12. True/False. T
        //Polymorphism allows derived classes to provide different implementations of the same method.
        //13. True/False. T
        //The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
        //14. True/False. F. Creating a new instance of the class
        //The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
        //15. True/False. F
        //Abstract methods can be used in a normal(non-abstract) class. 
        //16.True/False. T
        //Normal(non-abstract) methods can be used in an abstract class. 
        //17. True/False. T
        //Derived classes can override methods that were virtual in the base class. 
        //18. True/False. T. abstract are by default virtual
        //Derived classes can override methods that were abstract in the base class. 
        //19. True/False. F
        //In a derived class, you can override a method that was neither virtual non abstract in the base class.
        //20. True/False. F
        //A class that implements an interface does not have to provide an implementation for all of the members of the interface.
        //21. True/False. T
        //A class that implements an interface is allowed to have other members that aren’t defined in the interface.
        //22. True/False. F
        //A class can have more than one base class.
        //23. True/False. T
        //A class can implement more than one interface.

        //Work with methods
        //1
        /* input: array
         * function: reverse content
         * 3 separate methods
         * - create array
         * - reverse array
         * - print array
         */
        public static int[] GenerateNumbers(int len)
        {
            Random random = new Random();
            int[] arr = new int[len];

            for (int i = 0; i < len; i++)
            {
                arr[i] = random.Next();
            }
            return arr;
        }
        public static void Reverse(int[] numbers)
        {
            Array.Reverse(numbers);
        }
        public static void PrintNumbers(int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();    
        }
        
        //2
        public static int Fibonacci(int loc)
        {
            if (loc == 1)
            {
                return 1;
            }
            else if (loc == 2)
            {
                return 1;
            }

            int x = 1, y = 1;
            List<int> sequence = new List<int>(new int[] { 1,1});
            
            //create a fibonacci sequence of length loc
            for (int i = 0; i < loc-2; i++)
            {
                int sum = x + y;
                sequence.Add(sum);
                x = y;
                y = sum;
            }

            //output
            
            return sequence[sequence.Count - 1];
        }

        //Designing and Building Classes using object-oriented principles
        //Answer at the bottom of this file

              

        public static void Main(string[] args)
        {
            //Work with methods
            //1
            //int[] numbers = GenerateNumbers(5);
            //Reverse(numbers);
            //PrintNumbers(numbers);

            //2
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.Write("{0} ",Fibonacci(i));                
            //}

            //Designing and Building Classes using object-oriented principles
            //7
            //Create a few balls
            Ball b1 = new Ball(1,new Color(1,4,2,1));
            Ball b2 = new Ball(2, new Color(123, 23, 12, 141));
            Ball b3 = new Ball(3, new Color(12, 4, 52, 61));
            //Throw them around
            Random random = new Random();
            int repeat = random.Next(10);
            for(int i = 0; i < repeat; i++)
            {
                int choose = random.Next(3);
                switch (choose)
                {
                    case 0:
                        b1.Throw();
                        break;
                    case 1:
                        b2.Throw();
                        break;
                    case 2:
                        b3.Throw();
                        break;
                }
            }
            //Print number of throws
            Console.WriteLine("Ball 1 has been thrown {0} times.", b1.GetNumOfThrows());
            Console.WriteLine("Ball 2 has been thrown {0} times.", b2.GetNumOfThrows());
            Console.WriteLine("Ball 3 has been thrown {0} times.", b3.GetNumOfThrows());
            //Pop a few
            b2.Pop(2);
            //Throw them again
            for (int i = 0; i < repeat; i++)
            {
                int choose = random.Next(3);
                switch (choose)
                {
                    case 0:
                        b1.Throw();
                        break;
                    case 1:
                        b2.Throw();
                        break;
                    case 2:
                        b3.Throw();
                        break;
                }
            }
            //Print number of throws
            Console.WriteLine("Ball 1 has been thrown {0} times.", b1.GetNumOfThrows());
            Console.WriteLine("Ball 2 has been thrown {0} times.", b2.GetNumOfThrows());
            Console.WriteLine("Ball 3 has been thrown {0} times.", b3.GetNumOfThrows());
        }
    }

    //------------------------------------------------------


    public class Person : IPersonService
    {
        protected int id;
        protected string firstName;
        protected string lastName;
        protected string role;
        protected decimal salary;
        protected byte age;
        protected List<string> address;

        public Person()
        {
            role = "person";
            address = new List<string>();
        }

        public virtual void SetSalary(decimal salary)
        {
            if (salary >= 0)
            {
                this.salary = salary;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        List<string> IPersonService.GetAddress()
        {
            return address;
        }

        byte IPersonService.GetAge()
        {
            return age;
        }

        int IPersonService.GetID()
        {
            return id;
        }

        (string,string) IPersonService.GetName()
        {
            return (firstName,lastName);
        }

        decimal IPersonService.GetSalary()
        {
            return salary;
        }

        void IPersonService.SetAddress(string address, bool op)
        {
            if (op)
            {
                this.address.Add(address);
            }
            else
            {
                this.address.Remove(address);
            }
        }

        void IPersonService.SetID(int id)
        {
            this.id = id;
        }

        void IPersonService.SetName(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
    public class Student : Person, IStudentService
    {
        private Dictionary<int,Course> classEnrolled; //class, grade
        private float gpa;
        public Student(int id, string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.role = "student";
            classEnrolled = new Dictionary<int, Course>();
            gpa = 0f;
        }

        public Dictionary<int, Course> GetCourses()
        {
            return classEnrolled;
        }

        public float GetGpa()
        {
            return gpa;
        }

        public void SetCourse(int id, Course course, bool op)
        {
            if (op)
            {
                this.classEnrolled.Add(id, course);
            }
            else
            {
                this.classEnrolled.Remove(id);
            }
        }

        public void SetGpa(float gpa)
        {
            if(gpa <=4.0f && gpa >= 0)
            {
                this.gpa = gpa;
            }
            else
            {
                throw new ArgumentOutOfRangeException();    
            }
        }
    }
    public class Instructor : Person, IInstructorService
    {
        private Department department;
        private bool isHeadOfDepartment;
        private DateTime joinDate;
        private Dictionary<int, Course> classTeached;
        private static decimal bonus = 1000m; //same bonus for everyone
        public Instructor(int id, string firstName, string lastName, Department department)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.role = "instructor";
            this.department = department;
            this.isHeadOfDepartment = false; //by default, new faculty is not head of department
            this.joinDate = DateTime.Now;
            this.classTeached = new Dictionary<int, Course>();
        }
        public override void SetSalary(decimal salary)
        {
            if (salary < 0)
            {
                throw new ArgumentOutOfRangeException();
            }else
            {
                this.salary = salary + ((DateTime.Now - joinDate).Days / 365.24m) * bonus;
            }
        }

        Department IInstructorService.GetDepartment()
        {
            return department;
        }

        void IInstructorService.SetDepartment(Department department)
        {
            this.department = department;
        }

        DateTime IInstructorService.GetJoinDate()
        {
            return joinDate;
        }

        Dictionary<int,Course> IInstructorService.GetClassTeached()
        {
            return classTeached;
        }

        void IInstructorService.SetClassTeached(int id, Course course, bool op)
        {
            if (op)
            {
                this.classTeached.Add(id, course);
            }
            else
            {
                this.classTeached.Remove(id);
            }
        }

    }
    public class Course : ICourseService
    {
        private int id;
        private string name;
        private Dictionary<int,Student> enrolledStudents;
        
        public Course(int id, string name)
        {
            this.id = id;
            this.name = name;
            enrolledStudents = new Dictionary<int, Student>();
        }

        public Dictionary<int, Student> GetEnrolledStudents()
        {
            return enrolledStudents;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public void SetEnrolledStudents(int id, Student student, bool op)
        {
            if (op)
            {
                enrolledStudents.Add(id,student);
            }
            else
            {
                enrolledStudents.Remove(id);
            }
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetName(string name)
        {
            if (name == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.name = name;
            }
        }
    }
    public class Department : IDepartmentService
    {
        private string name;
        private Instructor headOfDepartment;
        private decimal budget;
        private Dictionary<int,Course> courses;
        public Department(string name, Instructor headOfDepartment, decimal budget)
        {
            this.name = name;
            this.headOfDepartment = headOfDepartment;
            this.budget = budget;
            this.courses = new Dictionary<int, Course>();
        }

        public decimal GetBudget()
        {
            return budget;
        }

        public Dictionary<int, Course> GetCourses()
        {
            return courses;
        }

        public Instructor GetHeadOfDepartment()
        {
            return headOfDepartment;
        }

        public string GetName()
        {
            return name;
        }

        public void SetBudget(decimal budget)
        {
            if(budget < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.budget = budget;
            }
        }

        public void SetCourses(int id, Course course, bool op)
        {
            if(op)
            {
                this.courses.Add(id,course);
            }
            else
            {
                this.courses.Remove(id);
            }
        }

        public void SetHeadOfDepartment(Instructor headOfDepartment)
        {
            this.headOfDepartment = headOfDepartment;
        }

        public void SetName(string name)
        {
            if(name == null)
            {
                throw new ArgumentOutOfRangeException();
            }else
            {
                this.name = name;
            }
        }
    }
    
    //interfaces
    public interface ICourseService
    {
        //private int id;
        //private string name;
        //private Dictionary<int, Student> enrolledStudents;

        int GetId();
        void SetId(int id);
        string GetName();
        void SetName(string name);
        Dictionary<int,Student> GetEnrolledStudents();
        void SetEnrolledStudents(int id, Student student, bool op); //true for add, false for delete
    }
    public interface IStudentService : IPersonService
    {
        //private Dictionary<int, Course> classEnrolled; //class, grade
        //private float gpa;

        Dictionary<int, Course> GetCourses();
        void SetCourse(int id, Course course, bool op); //true for add, false for delete
        float GetGpa();
        void SetGpa(float gpa);
    }
    public interface IInstructorService : IPersonService
    {
        //private Department department;
        //private bool isHeadOfDepartment;
        //private DateTime joinDate;
        //private List<int> classTeached = new List<int>();
        //private static decimal bonus = 1000m;
        Department GetDepartment();
        void SetDepartment(Department department);
        DateTime GetJoinDate();
        Dictionary<int, Course> GetClassTeached();
        void SetClassTeached(int id, Course course, bool op); //true for add, false for delete
        void SetSalary(decimal salary); //no negative

    }
    public interface IDepartmentService
    {
        //private string name;
        //private string headOfDepartment;
        //private decimal budget;
        //private Dictionary<int, Course> courses;

        string GetName();
        void SetName(string name);
        Instructor GetHeadOfDepartment();
        void SetHeadOfDepartment(Instructor headOfDepartment);
        decimal GetBudget();
        void SetBudget(decimal budget);
        Dictionary<int,Course> GetCourses();
        void SetCourses(int id, Course course, bool op); //true for add, false for delete
    }
    public interface IPersonService
    {
        //protected int id;
        //protected string firstName;
        //protected string lastName;
        //protected string role = "person";
        //protected decimal salary;
        //protected byte age;
        byte GetAge();
        decimal GetSalary();
        void SetSalary(decimal salary); //no negative
        List<string> GetAddress();
        void SetAddress(string address, bool op); //true for add, false for delete 
        int GetID();
        void SetID(int id);
        (string,string) GetName();
        void SetName(string firstName, string lastName);
    }

    //7
    public class Color
    {
        private byte red, green, blue, alpha;

        public Color(byte red, byte green, byte blue, byte alpha=255)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public void SetRed(byte red)
        {
            this.red = red;
        }
        public void SetGreen(byte green)
        {
            this.green = green;
        }
        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }
        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }
        public byte GetRed()
        {
            return red;
        }
        public byte GetGreen()
        {
            return green;
        }
        public byte GetBlue()
        {
            return blue;
        }
        public byte GetAlpha()
        {
            return alpha;
        }
        public double grayscale()
        {
            double r = (red + green + blue) / 3;
            return r;
        }
    }
    public class Ball
    {
        private int size;
        private Color color;
        private int numOfThrows;

        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
            numOfThrows = 0;
        }

        public void Pop(int id)
        {
            this.size = 0;
            Console.WriteLine("Ball {0} popped.",id);
        }
        public void Throw()
        {
            if(size != 0)
            {
                numOfThrows++;
            }
        }

        //getters and setters 
        public int GetSize() {return size;}
        public Color GetColor() {return color;}
        public int GetNumOfThrows() {return numOfThrows;}
        public void SetNumOfThrows(int numOfThrows) 
        {
            if (numOfThrows < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.numOfThrows = numOfThrows;
            }
        }
        public void SetColor(Color color) { this.color = color; }
        public void SetSize(int size) 
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.size = size;
            }
        } 
    }

}
