using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace String_Array
{
    internal class Group
    {

        public Group()
        {
            
        }
        public Group(int limit)
        {
            StudentLimit = limit;
        }





        public string No;
        public int StudentLimit;

        Student[] students = new Student[0];


        public void AddStudent(Student student)
        {
            if (students.Length < StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            } 
            
            else
            {
                Console.WriteLine("\nGrupdaki telebe limit dolmusdur");
            }
        }

        public void ShowAllStudents()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i].Fullname}      Grup : {students[i].GroupNo}    Ortalama bal : {students[i].AvgPoint}");
            }

        }

        public void SearchStudent(string fullname)
        {
            bool check = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Fullname == fullname)
                {
                    check = true;
                    Console.WriteLine($"{students[i].Fullname}      Grup : {students[i].GroupNo}    Ortalama bal : {students[i].AvgPoint}");
                }                
            }

            if (check == false)
            {
                Console.WriteLine("Bu ad ve soyada uygun telebe movcud deyil");
            }

        }

    }
}
