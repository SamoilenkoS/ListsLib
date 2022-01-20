using System;
using System.Collections.Generic;
using System.Text;

namespace ListsConsole
{
    public class Student
    {
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
        }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        private Student(string firstName)
        {
            _firstName = firstName;
        }

        public static Student Initialize(string firstName, string lastName, DateTime birthDate)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || birthDate > DateTime.Now)
            {
                throw new ArgumentException();
            }

            return new Student(firstName);
        }
    }
}
