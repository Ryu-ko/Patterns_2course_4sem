using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University("Сеня", "Какой-то адресс", typeof(string));
            Faculty faculty = new Faculty("Сеня", "Какой-то адресс", typeof(string));

            JobTitle jobTitle = new JobTitle();
            Department department = new Department();

            university.PrintInfo();

            university.AddFaculty(faculty);
            university.AddJobTitle(jobTitle);

            faculty.AddDepartment(department);
            faculty.AddJobTitle(jobTitle);
        }
    }
}
