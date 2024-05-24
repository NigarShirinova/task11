using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public static class Program
    {
        public static void Main()
        {
            Course PB401 = new();
            Student student1 = new Student("Nigar", "Shirinova", 19, "123456");
            Student student2 = new Student("Filankes", "Filankesov", 22, "1234567");
            PB401.AddStudent(student1);
            PB401.AddStudent(student2);
            
            PB401.RemoveStudent(student2);
            PB401.Search("Salam");
            PB401.Search("Nigar");
            PB401.Count();
            PB401.DisplayStudents();

            PB401.Exit();


        }



    }
}
