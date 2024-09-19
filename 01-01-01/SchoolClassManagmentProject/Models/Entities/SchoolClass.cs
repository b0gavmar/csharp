using SchoolClassManagmentProject.Models.AppException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassManagmentProject.Models.Entities
{
    public class SchoolClass
    {
        private byte _grade;
        private char _gradeLetter;
        private byte _lastGrade;

        //field: kicsi betuvel, es privateok
        //property:

        // grade > lastGrade akk már végzett

        public SchoolClass()
        {
            _grade = byte.MinValue;
            _gradeLetter = char.MinValue;
            _lastGrade = _grade;
        }

        public SchoolClass(byte grade, char gradeLetter, byte lastGrade)
        {
            _grade = grade;
            _gradeLetter = gradeLetter;
            _lastGrade = lastGrade;
        }

        //ezek a propertyk
        public byte Grade { get => _grade; set => _grade = value; }
        public char GradeLetter { get => _gradeLetter; set => _gradeLetter = value; }
        public byte LastGrade { get => _lastGrade; private set => _lastGrade = value; }


        //public string Name { get { return $"{grade}. {gradeLetter}"; } };
        //public string Name { get => $"{grade}. {gradeLetter}"; } ;
        public string Name => $"{_grade}. {_gradeLetter}";
        public bool HasGraduated => _grade > _lastGrade;
        public bool IsGraduate => _grade == _lastGrade;
        public bool IsActive => !HasGraduated;

        public void SetLastGrade(byte newGrade)
        {
            if (newGrade > _grade)
                LastGrade = newGrade;
            else
                throw new LastGradeModificationErrorException($"{nameof(SchoolClass)} osztályba, {nameof(SetLastGrade)} metódusban paraméter hiba történt",nameof(Grade),null);
        }

        public void AdvanceGrade()
        {
            if(IsActive)
                Grade = (byte)(Grade+1);

        }

        //destruktor, meghivja a garbagecollectort
        ~SchoolClass() 
        {
            Console.WriteLine($"{_grade}. {_gradeLetter} osztály megszűnt");
        }

    }
}
