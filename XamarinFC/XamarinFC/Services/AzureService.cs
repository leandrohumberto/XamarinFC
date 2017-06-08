using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFC.Authentication;
using XamarinFC.Helpers;
using XamarinFC.Services;

[assembly: Dependency(typeof(AzureService))]
namespace XamarinFC.Services
{
    public class AzureService
    {
        private static readonly string AppUrl = "https://xamarin-marathon-intermediate.azurewebsites.net/";

        public MobileServiceClient Client { get; set; } = null;

        public static bool userAuth { get; set; } = false;

        public void Initialize()
        {
            Client = new MobileServiceClient(AppUrl);

            if (!string.IsNullOrEmpty(Settings.AuthToken) && !string.IsNullOrWhiteSpace(Settings.UserId))
            {
                Client.CurrentUser = new MobileServiceUser(Settings.UserId)
                {
                    MobileServiceAuthenticationToken = Settings.AuthToken,
                };
            }
        }

        public async Task<bool> LoginAsync()
        {
            Initialize();

            var auth = DependencyService.Get<IAuthentication>();
            var user = await auth.LoginAsync(Client, MobileServiceAuthenticationProvider.Facebook);

            if (user == null)
            {
                Settings.AuthToken = string.Empty;
                Settings.UserId = string.Empty;

                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Application.Current?.MainPage?.DisplayAlert("OP!",
                        "Não conseguimos efetuar o seu login, tente novamente", "Lebeza");
                });

                return false;
            }

            Settings.AuthToken = user.MobileServiceAuthenticationToken;
            Settings.UserId = user.UserId;
            return true;
        }
    }
}
