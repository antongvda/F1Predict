using System;
using System.Collections.Generic;
using System.Text;

namespace F1Predict.Models
{
    internal class Race
    {
        // Attributs
        private int id;
        private string name;
        private string circuitName;
        private string location;
        private string country;
        private DateTime date;
        private int season;
        private int round;

        // Constructeur
        public Race(int id, string name, string circuitName, string location,string country, DateTime date, int season, int round)
        {
            this.id = id;
            this.name = name;
            this.circuitName = circuitName;
            this.location = location;
            this.country = country;
            this.date = date;
            this.season = season;
            this.round = round;
        }

        // Propriétés
        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public string CircuitName
        {
            get { return circuitName; }
        }

        public string Location
        {
            get { return location; }
        }

        public string Country
        {
            get { return country; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public int Season
        {
            get { return season; }
        }

        public int Round
        {
            get { return round; }
        }
    }
}
