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
	public partial class Manual_Burden_Detemination_Screen : ContentPage
	{
		public Manual_Burden_Detemination_Screen ()
		{
			InitializeComponent ();
		}

        Entryinformation[] entryinformation = new Entryinformation[5];

        private void Rate_calculation_Button_ClickedAsync(object sender, EventArgs e)
        {



            int pay_total_amount = 0;
            int rate_sum = 0;
            int[] count = new int[5];
            int[] ratio = new int[5];
            try
            {
                count[0] = int.Parse(president_count.Text);
                count[1] = int.Parse(department_count.Text);
                count[2] = int.Parse(section_chief_count.Text);
                count[3] = int.Parse(lead_count.Text);
                count[4] = int.Parse(flat_employee_count.Text);

                ratio[0] = int.Parse(president_rate.Text);
                ratio[1] = int.Parse(department_rate.Text);
                ratio[2] = int.Parse(section_chief_rate.Text);
                ratio[3] = int.Parse(lead_rate.Text);
                ratio[4] = int.Parse(flat_employee_rate.Text);

                pay_total_amount = int.Parse(total_amount_entry.Text);

            }
            catch (FormatException)
            {
                DisplayAlert("入力エラー", "数字を入力してください。", "OK");
                return;
            }
            catch (Exception)
            {
                DisplayAlert("入力エラー", "入力されていない箇所があります。", "OK");
                return;
            }

            for (int i = 0; i < 5; i++)
            {
                rate_sum += ratio[i];
            }
            if (rate_sum != 100)
            {
                DisplayAlert("入力エラー", "割合の合計が100%ではありません。", "OK");
                return;
            }

            for (int i = 0; i < 5; i++)
            {
                entryinformation[i].each_job_title_burden_amount = Convert.ToString(pay_total_amount * (100 / ratio[i]) / count[i]);
                //WriteLine(entryinformation[i].each_job_title_burden_amount);
            }

            entryinformation[0].count_each_job_title = Convert.ToString(count[0]);
            entryinformation[1].count_each_job_title = Convert.ToString(count[1]);
            entryinformation[2].count_each_job_title = Convert.ToString(count[2]);
            entryinformation[3].count_each_job_title = Convert.ToString(count[3]);
            entryinformation[4].count_each_job_title = Convert.ToString(count[4]);

            entryinformation[0].ratio_each_job_title = Convert.ToString(ratio[0]);
            entryinformation[1].ratio_each_job_title = Convert.ToString(ratio[1]);
            entryinformation[2].ratio_each_job_title = Convert.ToString(ratio[2]);
            entryinformation[3].ratio_each_job_title = Convert.ToString(ratio[3]);
            entryinformation[4].ratio_each_job_title = Convert.ToString(ratio[4]);


            //Application.Current.MainPage = new Result_Indication();
            //画面遷移

            {
                this.Navigation.PushAsync(new Result_Indication(), true);
            }

        }
        private void Rate_auto_determining(object sender, EventArgs e)
        {
            Random rnd = new System.Random();
            int remaining_rate = 100;
            int random;

            for (int remaining_job_title = 5; remaining_job_title > 0; remaining_job_title--)
            {
                if (remaining_job_title == 1)
                {

                    entryinformation[remaining_job_title - 1].ratio_each_job_title = remaining_rate.ToString();
                }
                else
                {
                    random = rnd.Next(remaining_rate);
                    if (random == 0)
                    {
                        entryinformation[remaining_job_title - 1].ratio_each_job_title = random.ToString();
                    }
                    else
                    {
                        entryinformation[remaining_job_title - 1].ratio_each_job_title = random.ToString();
                        remaining_rate -= random;
                    }
                }
            }

            president_rate.Text = entryinformation[0].ratio_each_job_title.ToString();
            department_rate.Text = entryinformation[1].ratio_each_job_title.ToString();
            section_chief_rate.Text = entryinformation[2].ratio_each_job_title.ToString();
            lead_rate.Text = entryinformation[3].ratio_each_job_title.ToString();
            flat_employee_rate.Text = entryinformation[4].ratio_each_job_title.ToString();

        }



    }


    public struct Entryinformation

    {

        public String post;
        public String count_each_job_title;
        public String ratio_each_job_title;
        public String each_job_title_burden_amount;


    }
}