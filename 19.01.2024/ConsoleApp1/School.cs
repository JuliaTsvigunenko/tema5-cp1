using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class School
    {
        /// <summary>
        /// поля ФИО
        /// </summary>
        private string name;

        private string surname;

        private string patronymic;

        /// <summary>
        /// поле пола
        /// </summary>
        private string gender;

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Patronymic { get { return patronymic; } set { patronymic = value; } }

        public string Gender { get { return gender; } set { gender = value; } }

        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        public School(string name, string surname, string patronymic, string gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Gender = gender;
        }

        








    }
}
