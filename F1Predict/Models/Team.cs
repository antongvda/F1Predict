using System;
using System.Collections.Generic;
using System.Text;

namespace F1Predict.Models
{
    internal class Team
    {
        //Atributs
        private int id;
        private string name;

        //Constructeur
        public Team(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        //Propriétés
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
    }
}
