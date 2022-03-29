using System;
using System.Linq;

namespace mission13.Models
{
    public interface IBowlersRepository
    {
        IQueryable<Bowler> Bowlers { get; }
    }
}
