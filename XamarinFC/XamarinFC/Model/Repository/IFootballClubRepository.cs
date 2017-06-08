using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFC.Model.Entity;

namespace XamarinFC.Model.Repository
{
    public interface IFootballClubRepository
    {
        Task<IEnumerable<FootballClub>> GetClubData();
    }
}
