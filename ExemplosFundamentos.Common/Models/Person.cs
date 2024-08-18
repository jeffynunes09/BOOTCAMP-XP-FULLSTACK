using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Common.Models
{
    public class Person
    {
        public  string? Name { get; set; }
        public int Age { get; set; }

        public void IntroduseMyself()
        {

       Console.WriteLine($"Hello, my name is {Name}, I'm {Age} years old!");

        }
    }
}