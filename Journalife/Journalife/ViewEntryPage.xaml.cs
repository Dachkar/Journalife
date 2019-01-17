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
	public partial class ViewEntryPage : ContentPage
	{
        Entry tappedEntry = new Entry();

        public ViewEntryPage (Entry TappedEntry)
		{
			InitializeComponent ();

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                int id = TappedEntry.ID;
                var dia = connection.Get<Entry>(id);
                tappedEntry = dia;
                
            }

            string firstGrat = tappedEntry.Grat1.ToString();
            string secondGrat = tappedEntry.Grat2.ToString();
            string thirdGrat = tappedEntry.Grat3.ToString();
            string diaryEntry = tappedEntry.Diary.ToString();
            string date = tappedEntry.Date.ToString();

            data.Text = date;
            g1.Text = firstGrat;
            g2.Text = secondGrat;
            g3.Text = thirdGrat;
            diary.Text = diaryEntry;
        }

    }
}