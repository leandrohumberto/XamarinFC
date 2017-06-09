using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
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
        }
    }
}