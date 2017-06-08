using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFC.Model.Entity;
using XamarinFC.Model.Repository;

namespace XamarinFC.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        public ObservableCollection<FootballClub> FootballClubs { get; private set; }

        private string _currentAnthem = string.Empty;
        public string CurrentAnthem
        {
            get { return _currentAnthem; }
            private set { SetProperty(ref _currentAnthem, value); }
        }
        public ICommand SelectedItemChangedCommand => 
            new Command(ExecuteSelectedItemChangedCommand, CanExecuteSelectedItemChangedCommand);

        public MainViewModel()
        {
            Title = "Xamarin FC";
            Initialize();
        }

        private async void Initialize()
        {
            FootballClubs = new ObservableCollection<FootballClub>(
                await Task.FromResult(await DependencyService.Get<IFootballClubRepository>().GetClubData()));
        }

        private void ExecuteSelectedItemChangedCommand(object item)
        {
            CurrentAnthem = (item as FootballClub)?.Anthem ?? string.Empty;
        }

        private bool CanExecuteSelectedItemChangedCommand(object item)
            => !IsBusy;
    }
}
