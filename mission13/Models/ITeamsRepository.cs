using System;
using System.Linq;

namespace mission13.Models
{
    public interface ITeamsRepository
    {
        IQueryable<Team> Teams { get; }
    }
}
