using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coursework1Form.Diary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Coursework1Form
{
    public partial class DailyCheckupForm : Form
    {
        public DailyCheckupForm()
        {
            InitializeComponent();
        }

        // writing the diary and saving it to file
        public static string path = "diary.txt";
        private void bttnSave_Click(object sender, EventArgs e)
        {
            Diary.Diary diaryEntry = new Diary.Diary(DateTime.Parse(txtbxDate.Text), txtbxDiary.Text);
            File.AppendAllText(path, diaryEntry.ToString/*GetDate*/() + ":" + diaryEntry.GetDiary() + "\n");

            txtbxDiary.Text = "";
            txtbxDate.Text = "";
            lblSaved.Text = "SAVED";
        }
        // ---

        // writing quotes that are random each time the form is open, var should be at the top 
        private string[] quotes =
        {
            "“It is never too late to be what you might have been.”", // — George Eliot
            "“Don't let someone else's opinion of you become your reality”", // — Les Brown"
            "“Opportunities don't happen, you create them.”", // — Chris Grosser"
            "“True freedom is impossible without a mind made free by discipline.”", // ―Mortimer J. Adler",
            "“Set your goals high, and don’t stop till you get there.”", // —Bo Jackson
            "“Life is like riding a bicycle. To keep your balance you must keep moving.”" // —Albert Einstein
        };

        private Random random = new Random();

        // quotes continued, actually runs it
        private void DailyCheckupForm_Load(object sender, EventArgs e)
        {
            lblQuote.Text = quotes[random.Next(0, quotes.Length)];
        }
        // ---

        // linking the file to view the diary - for privacy reasons
        private void bttnViewDiary_Click(object sender, EventArgs e)
        {
            ViewingDiaryForm form = new ViewingDiaryForm();
            form.Show();
        }
        // ---

        // rating scale 
        private void txtbxRate_TextChanged_1(object sender, EventArgs e)
        {
            if (txtbxRate.Text == "1") 
            {
                lblForRate.Text = "Everything will be okay.";
            }

            else if (txtbxRate.Text == "2" || txtbxRate.Text == "3")
            {
                lblForRate.Text = "It will get better!";
            }

            else if (txtbxRate.Text == "4" || txtbxRate.Text == "5" || txtbxRate.Text == "6")
            {
                lblForRate.Text = "You are doing well!";
            }

            else if (txtbxRate.Text == "7" || txtbxRate.Text == "8")
            {
                lblForRate.Text = "That's really good!";
            }

            else if (txtbxRate.Text == "9" || txtbxRate.Text == "10")
            {
                lblForRate.Text = "Very lovely to hear!";
            }

            else
            {
                lblForRate.Text = " "; // if the conditions dont meet it will just be blank (the conditions being numbers from 1 - 10)
            }
        }
        // ---
    }
}

