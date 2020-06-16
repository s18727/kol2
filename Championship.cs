using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class Championship
    {
        public int idChampionship { get; set; }

        public String OfficialName { get; set; }

        public int Year { get; set; }

        public ICollection<Championship_team> championship_Teams { get; set; }
    }
}
