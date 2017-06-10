using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFC.ViewModel;

namespace XamarinFC.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}