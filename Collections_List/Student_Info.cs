using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo_Project1.Collections_List
{
    public class Student_Info
    {

        static void Mains(string[] args)
        {
            var students = new List<Student>() {
                                                    new Student(){ Id = 1, Name="Bill"},
                                                    new Student(){ Id = 2, Name="Steve"},
                                                    new Student(){ Id = 3, Name="Ram"},
                                                    new Student(){ Id = 4, Name="Abdul"}
                                                };
            //get all students whose name is Bill
            var result = from s in students
                         where s.Name == "Ram"
                         select s;

            foreach  (var student in result)
            {
                Console.WriteLine(student.Id + ", " + student.Name);

            }

        }
    }
}
