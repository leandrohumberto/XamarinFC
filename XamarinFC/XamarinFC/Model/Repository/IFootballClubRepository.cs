using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinFC.Model.Entity;

namespace XamarinFC.Model.Repository
{
    public interface IFootballClubRepository
    {
        Task<IEnumerable<FootballClub>> GetClubsData();
    }
}
