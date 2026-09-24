using System;
using System.Collections.Generic;
using System.Text;

namespace F1Predict.Models
{
    internal class Driver
    {
        //Atributs
        private int id;
        private string firstName;
        private string lastName;
        private string nationality;
        private string code;

        //Constructeur
        public Driver(int id, string firstName, string lastName, string nationality, string code)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.nationality = nationality;
            this.code = code;
        }

        //Propriétés
        public int Id
        {
            get { return id; }
        }
        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public string Nationality
        {
            get { return nationality; }
        }
        public string Code
        {
            get { return code; }
        }
    }
}
