using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingRoom.Models
{
    public class Room
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public int NumberComputers { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
