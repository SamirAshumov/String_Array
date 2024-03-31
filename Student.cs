using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Array
{
    internal class Student : Group
    {
        public string Fullname;
        public string GroupNo;
        public double AvgPoint;


        public Student()
        {
            
        }

        public Student(string fullname, string no, double avgPoint, int limit) : base(limit)
        {
            Fullname = fullname;
            GroupNo = no;
            AvgPoint = avgPoint;            
        }


    }
}
