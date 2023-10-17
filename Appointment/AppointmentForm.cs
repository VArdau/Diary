using System;
using System.IO;
using Coursework1Form.Appointment;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Coursework1Form
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        // making the appointment
        string path = "appointment.txt";
        public void bttnSubmit_Click(object sender, EventArgs e)
        {
            Appointment.Appointment appointmentEntry = new Appointment.Appointment(txtbxDate.Text, txtbxTime.Text, txtbxAppointmentFor.Text);

            //user1.date = txtbxDate.Text = Convert.ToString(txtbxDate.Text); // without the text it would have selected the bx
            //user1.time = txtbxTime.Text = Convert.ToString(txtbxTime.Text);
            //user1.appointment = txtbxAppointmentFor.Text = Convert.ToString(txtbxAppointmentFor.Text);

            File.AppendAllText(path, appointmentEntry.GetDate() + " | " + appointmentEntry.GetTime() + " | " + appointmentEntry.GetAppointment() + "\n");
            dataGridViewAppointment.Rows.Add(new object[] { "", DateTime.Parse(appointmentEntry.GetDate()), appointmentEntry.GetTime(), appointmentEntry.GetAppointment() }); // this makes it update without closing the program 
            // because i made an ID column and hid it, i believe the data didnt appear properly, because when i input an appointment, there would be time in date and appointment in time, so i made an empty string row where the ID would be
            dataGridViewAppointment.Sort(dataGridViewAppointment.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }
        // ---

        // making it into a grid so it can be seen
        private void InitialiseDataGridViewAppointment()
        {
            dataGridViewAppointment.Columns.Add("id", "ID");
            dataGridViewAppointment.Columns.Add("date", "Date"); //visual rep and another is for linking. Column name and header
            dataGridViewAppointment.Columns.Add("time", "Time");
            dataGridViewAppointment.Columns.Add("appointment", "Appointment");
            // dataGridViewAppointment.Rows.RemoveAt([1])

            // each row corresponds to index, index is the line number, so need to get rid of that line. 

            int id = 0;

            foreach (string line in File.ReadAllLines(path))
            {
                string[] splitData = line.Split(" | ");
                // dataGridView1.Rows.Add(splitData); // cant pass in the string array, as one of the elements needs to be converted to a DateTime object 
                dataGridViewAppointment.Rows.Add(new object[] { id++, DateTime.Parse(splitData[0]), splitData[1], splitData[2] }); 
                // manually pass the date in as a datatime object and the rest is a string 
            }

            // hide the column for the ID, it would have not made any sense to be visible but it was needed since there was no unique identifier to delete by,
            // see https://stackoverflow.com/a/15090175.
            dataGridViewAppointment.Columns[0].Visible = false;

            // to sort by,
            // see https://stackoverflow.com/a/29774365. 
            dataGridViewAppointment.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy"; 
            dataGridViewAppointment.Sort(dataGridViewAppointment.Columns[1], System.ComponentModel.ListSortDirection.Ascending /* acending, had it as decending but wanted to see the easrliest first */); // https://stackoverflow.com/a/806793
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            InitialiseDataGridViewAppointment();
        }
        // ---

        // delete appointment
        int row = -1;
        int rowLine = -1;
        private void dataGridViewAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            row = e.RowIndex; // the index of the row, position of where it is in the grid
            rowLine = Convert.ToInt32(dataGridViewAppointment.Rows[e.RowIndex].Cells[0].Value); // the ID
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            dataGridViewAppointment.Rows.RemoveAt(row);
            var lines = File.ReadAllLines(path).ToList();
            lines.RemoveAt(rowLine);
            File.WriteAllLines(path, lines); // so the previous line you removed is overwritten
            
        }
        // ---
    }
}
