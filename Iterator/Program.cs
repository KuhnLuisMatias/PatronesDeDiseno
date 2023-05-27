using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University();

            Faculty scienceFaculty = new Faculty() { Name = "Science" };
            scienceFaculty.Students.Add(new Student() { Name = "John", Age = 20 });
            scienceFaculty.Students.Add(new Student() { Name = "Emily", Age = 19 });
            scienceFaculty.Students.Add(new Student() { Name = "David", Age = 21 });

            Faculty artsFaculty = new Faculty() { Name = "Arts" };
            artsFaculty.Students.Add(new Student() { Name = "Sarah", Age = 22 });
            artsFaculty.Students.Add(new Student() { Name = "Ryan", Age = 18 });

            university.Faculties.Add(scienceFaculty);
            university.Faculties.Add(artsFaculty);

            // Iterar sobre todos los estudiantes en la universidad
            foreach (Student student in university)
            {
                Console.WriteLine("Student Name: {0}, Age: {1}", student.Name, student.Age);
            }

            Console.ReadLine();
        }
    }
}
