using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassManagmentProject.Models.Entities
{
    public class Student
    {

        private string _lastName;
        private string _firstName;
        private DateTime _birthDate;
        private bool _gender;
        private string _email;
        private string _phone;

        public Student()
        {
            _lastName = string.Empty;
            _firstName = string.Empty;
            _birthDate = DateTime.MinValue;
            _gender = false;
            _email = string.Empty;
            _phone = string.Empty;
        }

        public Student(string lastName, string firstName, DateTime birthDate, bool gender, string email, string phone)
        {
            _lastName = lastName;
            _firstName = firstName;
            _birthDate = birthDate;
            _gender = gender;
            _email = email;
            _phone = phone;
        }

        public Student(string lastName, string firstName, DateTime birthDate, bool gender, string phone)
        {
            _lastName = lastName;
            _firstName = firstName;
            _birthDate = birthDate;
            _gender = gender;
            _email = string.Empty;
            _phone = phone;
        }

        public string Email { get => _email = Email;
            set
            {
                if(value == _email)
                    Console.WriteLine("");
                    //throw new Exception
                else
                    _email = value;
            } 
        }
        public string Phone { get => _phone = Phone; set => _phone = value; }

        public string FirstName =>_firstName = FirstName;
        public string LastName => _lastName = LastName;


        public void ChangeFirstName(string newFirstName)
        {
            _firstName = newFirstName;
        }

        public void ChangeLastName(string newLastName)
        {
            _firstName = newLastName;
        }

        public void ChangeBirthDate(DateTime newBirthDate)
        {
            _birthDate = newBirthDate;
        }

        public void ChangeGender(bool newGender)
        {
            _gender = newGender;
        }

        public string EnglishName()
        {
            return $"{_firstName} {_lastName}"; 
        }

        public string HungarianName()
        {
            return $"{_lastName} {_firstName}";
        }

        public int StudentAge()
        {
            int age = 0;

            age = DateTime.Now.Year - _birthDate.Year;
            if((DateTime.Now.Month <=_birthDate.Month) && (DateTime.Now.Day <= _birthDate.Day))
                age++;

            return age; 
        }

        public bool HasEmail()
        {
            if(_email == string.Empty)
                return false;
            else
                return true;
        }

        


        //2 konstruktor
        //email nelkul is letrehozni
        //angol és magyar teljes nev
        //konnyu email e telszam valtoztatas, tobbit csak nehezen (konnyu = set, masik = metodus)
        //uj email =/= regi
        // lekerdezheto h van-e email cim
        //meg lehessen tudni az eletkort



        //kivetel kezelesek
        // - nevben cska betu, kotojel es szokoz
        // - emailben nincs kukac
    }
}
