using System;
using System.Collections.Generic;
using System.Text;

namespace F1Predict.Models
{
    internal class QualifyingResult
    {
        // Attributs
        private Race race;
        private Driver driver;
        private Team team;
        private int position;
        private TimeSpan? q1Time;
        private TimeSpan? q2Time;
        private TimeSpan? q3Time;
        private string status;
        private string qualifyingType;

        // Constructeur
        public QualifyingResult(Race race, Driver driver, Team team, int position, TimeSpan? q1Time, TimeSpan? q2Time, TimeSpan? q3Time, string status, string qualifyingType)
        {
            this.race = race;
            this.driver = driver;
            this.team = team;
            this.position = position;
            this.q1Time = q1Time;
            this.q2Time = q2Time;
            this.q3Time = q3Time;
            this.status = status;
            this.qualifyingType = qualifyingType;
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

        public int Position
        {
            get { return position; }
        }

        public TimeSpan? Q1Time
        {
            get { return q1Time; }
        }

        public TimeSpan? Q2Time
        {
            get { return q2Time; }
        }

        public TimeSpan? Q3Time
        {
            get { return q3Time; }
        }

        public string Status
        {
            get { return status; }
        }

        public string QualifyingType
        {
            get { return qualifyingType; }
        }
    }
}
