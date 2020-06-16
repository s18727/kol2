using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class Championship_team
    {
        public int IdTeam { get; set; }

        public int IdChampionship { get; set; }

        public float Score { get; set; }

        public Championship Championship { get; set; }

        public Team Team { get; set; }
    }
}
