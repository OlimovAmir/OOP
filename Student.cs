using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    public enum Group
    {
        fizik,
        Matematic,
        Himik,
        IT
    }
    public class Student
    {
        public Guid Id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public Group group;

    }
}
