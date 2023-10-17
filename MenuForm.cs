using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1Form
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void bttnAppointment_Click(object sender, EventArgs e)
        {
            // linked the forms together, 
            // see https://www.youtube.com/watch?v=qVVtCPDu9ZU
            AppointmentForm form = new AppointmentForm();
            form.Show();
        }

        private void bttnDiary_Click(object sender, EventArgs e)
        {
            DailyCheckupForm form = new DailyCheckupForm();
            form.Show();
        }

        private void bttnToDo_Click(object sender, EventArgs e)
        {
            ToDo.ToDoForm form = new ToDo.ToDoForm();
            form.Show();
        }
    }
}
