using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Journalife
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing(); 
            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Entry>();

                var diaries = conn.Table<Entry>().ToList();
                DiaryListView.ItemsSource = diaries;
                
            }
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DiaryEntryPage());
        }

        private void DiaryListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Entry TappedEnty = (Entry) e.Item;
            
            Navigation.PushAsync(new ViewEntryPage(TappedEnty));
        }
    }
}
