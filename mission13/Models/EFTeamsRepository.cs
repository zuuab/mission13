using System;
using System.Linq;

namespace mission13.Models
{
    public class EFTeamsRepository : ITeamsRepository
    {
        private BowlingDbContext _context { get; set; }

        public EFTeamsRepository(BowlingDbContext temp)
        {
            _context = temp;
        }

        public IQueryable<Team> Teams => _context.Teams;
    }
}
