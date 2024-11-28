using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExample
{
    internal class Student
    {
        string firstName = "";
        string lastName = "";
        int idNumber;

        /// <summary>
        /// Returns the first name.
        /// </summary>
        public string FirstName 
        { 
            get 
            {
                return firstName;
            }
            set 
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name cannot be null");
                }
                firstName =  value.Trim();
            }
        }
        /// <summary>
        /// Returns the last name.
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The last name cannot be null or empty");
                }
                lastName = value.Trim();
            }
        }

        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {

                if (value < 0)
                {
                    throw new ArgumentNullException("The id number must be greater than zero.");
                }
                idNumber = value;
            }
        }

        /// <summary>
        /// Returns the first and last name in a single string.
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        public Student(string first, string last, int id)
        {
            FirstName = first;
            LastName = last;
            IdNumber = id;
        }

        public override string ToString()
        {
            return $"{LastName},{FirstName},{IdNumber}";
        }
    }
}
