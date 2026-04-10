using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class StudentManager
    {
        StudentStorage studentStorage = new StudentStorage();
        private List<Student>? students = new List<Student>();

        public void Run()
        {
            students = studentStorage.Load();

            //AddStudents();
            //ClearStudents();
            ShowStudents();
        }
        private void AddStudents()
        {
            Console.Write("Введіть кількість студентів: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                Console.Write("\nІм'я: ");
                string name = Console.ReadLine();
                Console.Write("Вік: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Середній бал: ");
                double avg = Convert.ToDouble(Console.ReadLine());

                Student student = new Student();
                student.Name = name;
                student.Age = age;
                student.AverageScore = avg;
                students.Add(student);
            }
            studentStorage.Save(students);
        }
        private void ShowStudents()
        {
            Console.WriteLine("Усі студенти:\n");
            foreach(var student in students)
            {
                if(students.Count == 0) Console.WriteLine("Студенти відсутні");
                else Console.WriteLine($"Ім'я: {student.Name}\nВік: {student.Age}\nСередній бал: {student.AverageScore}\n");
            }
            Console.WriteLine($"Кількість студентів: {students.Count}");
        }
        private void ClearStudents()
        {
            students.RemoveAt(0);
            studentStorage.Save(students);
        }
    }
}
