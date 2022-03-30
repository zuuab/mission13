using System;
using System.Linq;

namespace mission13.Models
{
    public class EFBowlersRepository : IBowlersRepository
    {
        private BowlingDbContext _context { get; set; }

        public EFBowlersRepository(BowlingDbContext temp)
        {
            _context = temp;
        }

        public IQueryable<Bowler> Bowlers => _context.Bowlers;

        public void Save(Bowler b)
        {
            _context.Update(b);
            _context.SaveChanges();
        }

        public void Add(Bowler b)
        {
            b.BowlerID = _context.Bowlers
                .ToList()
                .LastOrDefault()
                .BowlerID + 1;

            _context.Add(b);
            _context.SaveChanges();
        }

        public void Delete(Bowler b)
        {
            _context.Remove(b);
            _context.SaveChanges();
        }
    }
}
