using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFC.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(sender is Picker))
                return;

            var picker = sender as Picker;

            if (picker.SelectedIndex >= 0)
            {
                picker.BackgroundColor = Color.Transparent;
            }
            else
            {
                picker.BackgroundColor = Color.LightSeaGreen;
            }

            await _scrollViewer.ScrollToAsync(0, 0, false);
        }
    }
}