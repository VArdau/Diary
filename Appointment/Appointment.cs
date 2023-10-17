using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1Form.Appointment
{
    internal class Appointment 
    {
        // the variables
        private string date;
        private string time;
        private string appointment;

        // constructor
        public Appointment(string date, string time, string appointment) // constructor (function) inilising class 
        {
            this.date = date; // this means class, just data is the variables passed inside the class
            this.time = time;
            this.appointment = appointment;
        }

        // making funtions to use outside the class
        public string GetDate() // getter 
        {
            return date;
        }

        public string GetTime()
        {
            return time;
        }

        public string GetAppointment()
        {
            return appointment;
        }
    }
}
