using XamarinFC.Authentication;
using XamarinFC.Droid.Authentication;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(SocialAuthentication))]
namespace XamarinFC.Droid.Authentication
{
    class SocialAuthentication : IAuthentication
    {
        public async Task<MobileServiceUser> LoginAsync(MobileServiceClient client,
            MobileServiceAuthenticationProvider provider, IDictionary<string, string> parameters = null)
        {
            try
            {
                var user = await client.LoginAsync(Forms.Context, provider);

                Helpers.Settings.AuthToken = user.MobileServiceAuthenticationToken;
                Helpers.Settings.UserId = user.UserId;

                return user;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                // TODO: log error
                throw;
            }
        }
    }
}