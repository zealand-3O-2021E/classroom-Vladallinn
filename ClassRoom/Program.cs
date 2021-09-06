using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom ClassRoom = new ClassRoom();
            ClassRoom.ClassName = "3Q";
            ClassRoom.SemesterStart = new DateTime(2021, 08, 28);
            Student student1 = new Student("Vladimir",3, 10);
            Student student2 = new Student("Raz", 1, 25);
            Student student3 = new Student("Arturs", 7, 4);
            Student student4 = new Student("Zdenek",4, 8);
            Student student5 = new Student("Natalie", 3, 21);

            Console.WriteLine(ClassRoom);
            Console.ReadLine();

        }

    }
}
