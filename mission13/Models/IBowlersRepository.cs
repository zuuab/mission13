using System;
using System.Linq;

namespace mission13.Models
{
    public interface IBowlersRepository
    {
        IQueryable<Bowler> Bowlers { get; }

        public void Save(Bowler b);

        public void Add(Bowler b);

        public void Delete(Bowler b);
    }
}
