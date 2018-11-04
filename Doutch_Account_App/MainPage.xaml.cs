using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Doutch_Account_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void king_Tell_Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Manual_Burden_Detemination_Screen(), true);
        }

        ///  Auto_Burden_Detemination_Screenを開きます。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void king_Entrust_Button_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Auto_Burden_Detemination_Screen(), true);
        }

        private void selection_Back_Clicked(object sender, EventArgs e)
        {

        }
    }
}
