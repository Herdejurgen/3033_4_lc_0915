using _3033_4_lc_0915.mis3033_herdejurgen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3033_4_lc_0915
{
    namespace mis3033_herdejurgen
    {
        public class Person
        {
            public string name { get; set; }
            public int age { get; set; }

        }
    }


    public class Student : Person
    {
        public Student()
        {

        }
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
