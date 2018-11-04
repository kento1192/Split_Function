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
	public partial class Result_Indication : ContentPage
	{
		public Result_Indication ()
		{
			InitializeComponent ();
		}

        private void ChangePage_Clicked_cal(object sender, EventArgs e)
        {
            Navigation.PopAsync(true);
        }

    }
}