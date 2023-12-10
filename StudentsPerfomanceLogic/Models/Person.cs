using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerformanceLogic.Models
{
    public abstract class Person
    {
        [DisplayName("Номер")]
        public int Id { get; }
        [DisplayName("Фамилия")]
        public string LastName { get; }
        [DisplayName("Имя")]
        public string FirstName { get; }
        [DisplayName("Отчество")]
        public string MiddleName { get; } 
        [DisplayName("Адрес проживания")]
        public string Address { get; }
        [DisplayName("Дата рождения")]
        public DateTime BirthDate { get; }
        [DisplayName("Телефон")]
        public string CellPhone { get; }
        public string FullName
        { 
            get
            {
                return $"{LastName} {FirstName} {MiddleName}";
            }
        }

        protected Person(int id, string lastName, string firstName, string middleName,  string address, DateTime birthDate, string cellPhone)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Address = address;
            BirthDate = birthDate;
            CellPhone = cellPhone;
        }
    }
}
