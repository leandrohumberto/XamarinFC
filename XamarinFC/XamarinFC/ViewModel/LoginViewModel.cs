using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFC.Helpers;
using XamarinFC.Services;
using XamarinFC.View;

namespace XamarinFC.ViewModel
{
    class LoginViewModel : BaseViewModel
    {

        private AzureService _azureService;

        private ICommand _loginCommand;
        public ICommand LoginCommand
            => _loginCommand ?? (_loginCommand = new Command(async () => await ExecuteLoginCommandAsync()));

        public LoginViewModel()
        {
            if (Settings.IsLoggedIn)
            {
                Task.Run(async () => await PushAsync<MainViewModel>()).ContinueWith(x => RemovePageFromStack())
                    .ConfigureAwait(false);
                return;
            }

            _azureService = DependencyService.Get<AzureService>();
            Title = "Xamarin FC";
        }

        private async Task ExecuteLoginCommandAsync()
        {
            if (IsBusy || !(await LoginAsync()))
                return;

            IsBusy = true;

            await PushAsync<MainViewModel>();

            RemovePageFromStack();

            IsBusy = false;
        }

        private void RemovePageFromStack()
        {
            var pages = Application.Current?.MainPage?.Navigation?.NavigationStack?.ToList() 
                ?? new List<Page>(Enumerable.Empty<Page>());

            foreach (var page in pages)
            {
                if (page.GetType() == typeof(LoginPage))
                {
                    Application.Current?.MainPage?.Navigation?.RemovePage(page);
                }
            }
        }

        public async Task<bool> LoginAsync()
        {
            if (Settings.IsLoggedIn)
            {
                return await Task.FromResult(true);
            }

            try
            {
                return await _azureService.LoginAsync();
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.GetType().ToString());
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                throw ex;
            }
        }
    }
}
