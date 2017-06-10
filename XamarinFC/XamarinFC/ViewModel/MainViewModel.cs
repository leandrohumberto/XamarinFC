using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFC.Model.Entity;
using XamarinFC.Model.Repository;

namespace XamarinFC.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        private const string _defaultTitle = "Xamarin FC";

        public ObservableCollection<FootballClub> FootballClubs { get; private set; }

        private string _currentAnthem;
        public string CurrentAnthem
        {
            get { return _currentAnthem; }
            private set { SetProperty(ref _currentAnthem, value); }
        }

        public ICommand SelectedItemChangedCommand => 
            new Command(ExecuteSelectedItemChangedCommand, CanExecuteSelectedItemChangedCommand);

        public MainViewModel()
        {
            Title = _defaultTitle;
            Initialize();
        }

        private async void Initialize()
        {
            var clubs = await DependencyService.Get<IFootballClubRepository>().GetClubsData();
            FootballClubs = new ObservableCollection<FootballClub>(clubs.OrderBy(c => c.Name));
        }

        private void ExecuteSelectedItemChangedCommand(object item)
        {
            if (!(item is FootballClub))
                return;

            var fc = item as FootballClub;
            CurrentAnthem = fc.Anthem;
            Title = !string.IsNullOrWhiteSpace(fc.FullName) ? fc.FullName : _defaultTitle;
        }

        private bool CanExecuteSelectedItemChangedCommand(object item)
            => !IsBusy;
    }
}
