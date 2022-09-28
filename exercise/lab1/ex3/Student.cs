using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{

    internal class Student
    {
        public string name;
        public DateTime birthDay;
        public string gender;
        public string bornIn;

        public Student()
        {
            this.name = "";
            this.birthDay = DateTime.Parse("1/1/2021");
            this.gender = "male";
            this.bornIn = "HCM";
        }

        public Student(string name, DateTime dateTime, string age, string bornIn)
        {
            this.name = name;
            this.birthDay = dateTime;
            this.gender = age;
            this.bornIn = bornIn;
        }

        public string getName()
        {
            return this.name;
        }

    }
}
