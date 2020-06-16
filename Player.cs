﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class Player
    {
        public int IdPlayer { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public ICollection<Player_Team> Player_Teams { get; set; }
    }
}
