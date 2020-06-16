using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class Team
    {
        public int IdTeam { get; set; }

        public String TeamName { get; set; }

        public int MaxAge { get; set; }

        public ICollection<Player_Team> Player_Teams { get; set; }

        public ICollection<Championship_team> championship_Teams { get; set; }


    }
}
