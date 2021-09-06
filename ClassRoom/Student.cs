using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        private string _name;
        private int _birthMonth;
        private int _birthday;

        public string Name { get => _name; set => _name = value; }
        public int BirthMonth { get => _birthMonth; set => _birthMonth = value; }
        public int Birthday { get => _birthday; set => _birthday = value; }


        public Student(string name, int birthMonth, int birthday)
        {
            _name = name;
            _birthMonth = birthMonth;
            _birthday = birthday;
        }


        public string Season()
        {
            
            switch (BirthMonth)
            { 
                case 1:
                case 12:
                case 2:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Autumn";
                default:
                    throw new ArgumentException("Unexpected number of month");
            }
        }
    }
}
