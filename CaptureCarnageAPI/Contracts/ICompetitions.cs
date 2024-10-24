using CaptureCarnageAPI.Models;
using System.Collections.Generic;

namespace CaptureCarnageAPI.Contracts
{
    public interface ICompetitions
    {
        public IEnumerable<Competition> GetCompetitions();
        public Competition GetCompetition(int id);
    }
}
