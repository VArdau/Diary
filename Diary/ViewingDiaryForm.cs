using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework1Form.Diary;

namespace Coursework1Form.Diary
{
    public partial class ViewingDiaryForm : Form
    {
        public ViewingDiaryForm()
        {
            InitializeComponent();
        }

        // sorting the file
        private void ViewingDiaryForm_Load(object sender, EventArgs e)
        {
            List<Diary> sort = new List<Diary>(); // lists can make ordering easier

            foreach (string line in File.ReadAllLines(DailyCheckupForm.path))
            {
                string[] split = line.Split(":");
                sort.Add(
                    new Diary(DateTime.Parse(split[0]), split[1]) // first thing datetime and next content
                );
            }

            // how to seperate
            //see https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator
            foreach (Diary diary in sort.OrderByDescending(diary => diary.GetDate())) // ordering by date
            {
                lstDate.Items.Add(diary);
            }
        }
        // ---

        // when you touch the date the rest appears
        private void lstDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diary diaryEntry = (Diary)lstDate.SelectedItem;
            // need to specifiy what object (DiaryClass), the selected item (date(thats the object)) is casted ( () ) to the DiaryClass
            if (diaryEntry == null) // fixed in case you pressed other then the dates it wouldnt crash 
            {
                return;
            }
            txtbxDiary.Text = diaryEntry.GetDiary();
        }
        // ---

        
       // search bar
        private void bttnSearch_Click(object sender, EventArgs e)
        {
            lstDate.Items.Clear(); // clears the lst so you can restart

            foreach (string line in File.ReadAllLines(DailyCheckupForm.path))
            {
                string[] split = line.Split(":");
                Diary diary= new Diary(DateTime.Parse(split[0]), split[1]); // the date and diary content

                if (diary.GetDiary().Contains(txtbxSearch.Text, StringComparison.CurrentCultureIgnoreCase)) // string comparison makes it so you can have words no matter the casing. Checks if the diary content contains whats in the textbox
                { 
                    lstDate.Items.Add(diary); // if so it gets added
                }
            }
        }
        // ---
    }
}

