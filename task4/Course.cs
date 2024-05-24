using System;
using task4;
namespace task4
{
    public class Course
    {
        List<Student> students { get; set; }
        public int count = 0;
        public Course()
        {
            students = new List<Student>();

        }
        public void AddStudent(Student newstudent)
        {
            foreach (var student in students)
            {
                if (newstudent.Pin == student.Pin)
                {
                    Console.WriteLine("PIN isn't true");
                    return;
                }
            }
            students.Add(newstudent);
            count++;

        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
            count--;
        }

        public void DisplayStudents()
        {
            foreach (var item in students)
            {
                item.GetDetails();
            }
        }

        public void Search(string searchingName)
        {
            bool found = false;
            foreach (var student in students)
            {
                if (searchingName == student.Name)
                {
                    student.GetDetails();
                    found = true;

                }

                if (!found)
                {
                    Console.WriteLine("This student doesn't include to the course");
                }

            }

        }

        public void Count()
        {
            Console.WriteLine(count);
        }

        public void Exit()
        {
            Console.WriteLine("Operation stopped");
        }
    }
}