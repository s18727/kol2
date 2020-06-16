using Microsoft.EntityFrameworkCore;
using kolokwium2.Models;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Services
{
    public class SqlServerGameDbService : IGameDbService
    {

        private readonly GameDbContext _context;
        public SqlServerGameDbService(GameDbContext context)
        {
            _context = context;
        }

        public async string GetTeams(Championship champ)
        {
	   var champteam = await _context.Teams.SingleOrDefaultAsync(m => m.IdTeam == champ.idChampionship);
            var Team = await _context.Teams.SingleOrDefaultAsync(m => m.IdTeam == champteam.IdTeam);

	    
        }


        }
    }
}
