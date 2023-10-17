using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Coursework1Form.Diary
{
    internal class Diary
    {
        // variables
        // public string date;
        // public string diary;
        private DateTime date;
        private string diary;

        // constructor
        public Diary(DateTime date, string diary)
        {
            this.date = date;
            this.diary = diary;
        }

        // funtion
        public DateTime GetDate()
        {
            return date;
        }

        public string GetDiary()
        {
            return diary;
        }

        // specific implementation
        public override string ToString() // every class has an override so you do this manually to make a specicifc change or implementations
        {
            return date.ToShortDateString();
        }
    }
}
