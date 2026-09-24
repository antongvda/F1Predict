using System;
using System.Collections.Generic;
using System.Text;

namespace F1Predict.Models
{
    internal class RaceResult
    {
        // Attributs
        private Race race;
        private Driver driver;
        private Team team;
        private int? position;
        private string status;
        private string raceType;

        // Constructeur
        public RaceResult(Race race, Driver driver, Team team, int? position, string status, string raceType)
        {
            this.race = race;
            this.driver = driver;
            this.team = team;
            this.position = position;
            this.status = status;
            this.raceType = raceType;
        }

        // Propriétés
        public Race Race
        {
            get { return race; }
        }

        public Driver Driver
        {
            get { return driver; }
        }

        public Team Team
        {
            get { return team; }
        }

        public int? Position
        {
            get { return position; }
        }

        public string Status
        {
            get { return status; }
        }

        public string RaceType
        {
            get { return raceType; }
        }
    }
}
