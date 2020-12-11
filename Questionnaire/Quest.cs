using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    public class Quest
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Patronymic { get; set; }

        string Country { get; set; }
        string City { get; set; }
        string Phone { get; set; }

        string Date { get; set; }
        string Gender { get; set; }

        public void Start(string name, string surname, string patr, string country,
                            string city, string phone, string date, string gender)
        {
            Name = name;
            Surname = surname;
            Patronymic = patr;

            Country = country;
            City = city;
            Phone = phone;

            Date = date;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"{Name}\n{Surname}\n{Patronymic}\n\n{Country}\n{City}\n" +
                $"{Phone}\n\n{Date}\n{Gender}\n---------------------\n";      
        }
    }
}
