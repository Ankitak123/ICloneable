using System;
using System.Collections;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Runtime.Serialization;

using System.Text;

using System.Xml.Serialization;

using System.Globalization;

 

namespace ICloneableDemo

{

    public class Person :ICloneable

    {

        public string name { get; set; }

        public string surname { get; set; }

 

        public Person(){}

        public Person(Person p)

        {

            this.name = p.name;

            this.surname = p.surname;

        }

 

        public object Clone()

        {

            return new Person(this);

        }

    }

   class Program

    {

        static void Main(string[] args)

        {

            Person p1 = new Person { name = "Ankita", surname = "Kharche" };

            Console.Write("Name in p1:- " + p1.name + "\n");

            Person p2 =(Person) p1.Clone();

            Console.Write("Name in p2:- " + p2.name);

            Console.ReadLine();

        }

    }
}
   
