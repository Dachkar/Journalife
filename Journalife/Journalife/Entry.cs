using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Journalife
{
    public class Entry
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Grat1 { get; set; }
        public string Grat2 { get; set; }
        public string Grat3 { get; set; }
        public string Diary { get; set; }

    }
}
