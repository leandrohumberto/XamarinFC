using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFC.Model.Entity;
using XamarinFC.Model.Repository;

//[assembly: Dependency(typeof(FootballClubRepository))]
namespace XamarinFC.Model.Repository
{
    public class FootballClubRepository : IFootballClubRepository
    {
        private IMobileServiceClient _client;
        private IMobileServiceTable<FootballClub> _table;
        private static readonly string AppUrl = "https://xamarin-marathon-intermediate.azurewebsites.net/";

        public FootballClubRepository()
        {
            _client = new MobileServiceClient(AppUrl);
            _table = _client.GetTable<FootballClub>();
        }

        public async Task<IEnumerable<FootballClub>> GetClubsData()
        {
            return await _table.ToEnumerableAsync();
        }
    }
}
