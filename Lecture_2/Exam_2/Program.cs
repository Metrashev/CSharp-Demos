using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    class Program 
    {
        static void Main(string[] args)
        {
            // #2
            Console.Write("Enter Name: ");
            var sName = Console.ReadLine();
            Console.Write("Enter Age: ");
            var sAge = int.Parse(Console.ReadLine());


            var person = new Person();
            var person1 = new Person(sName);
            var person2 = new Person(sName, sAge);
            Console.WriteLine(person);
            Console.WriteLine(person1);
            Console.WriteLine(person2);
			
			// #4
			
            List<Person> personList = new List<Person>();

            Console.WriteLine("Enter name: Georgi//20");
            while (true)
            {
                string consoleInput = Console.ReadLine();
                var parts = consoleInput.Split(new[] { "//" }, StringSplitOptions.None);
                if (consoleInput == "quit") break;
                var name = parts[0];
                var age = int.Parse(parts[1]);
                personList.Add(new Person(name, age));
            }

            var sortedList = personList.Where(x => x.age > 18).OrderBy(x => x.name.Length).ToList();
            foreach (var item in sortedList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
            
        }
    }
}
