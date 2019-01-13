using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Journalife
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DiaryEntryPage : ContentPage
	{
		public DiaryEntryPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Entry entry = new Entry()
            {
                Grat1 = G1.Text,
                Grat2 = G2.Text,
                Grat3 = G3.Text,
                Diary = D.Text
            };

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                connection.CreateTable<Entry>();
                var numOfRows = connection.Insert(entry);

                if(numOfRows>0)
                    DisplayAlert("Success!", "Diary entry saved", "ok");
                else
                    DisplayAlert("Failure!", "Diary entry failed to save", "ok");

            }

        }
    }
}