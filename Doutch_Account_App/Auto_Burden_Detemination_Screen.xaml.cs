using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Doutch_Account_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Auto_Burden_Detemination_Screen : ContentPage
	{
		public Auto_Burden_Detemination_Screen ()
		{
			InitializeComponent ();
		}

        private async void resultIndication(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Result_Indication(), true);
        }
    

    }
}