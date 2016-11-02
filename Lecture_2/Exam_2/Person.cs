﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    class Person
    {
        public string name;

        public int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
            
        }

        public Person(string name)
            : this ()
        {
            this.name = name;
        }

        public Person(string name, int age)
            : this(name)
        {
            this.age = age;
        }
        public override string ToString()
        {
            return $"{name} {age}";
        }
    }
}
