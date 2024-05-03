using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec
{
    internal class Appointment
    {
        private DateTime dateTime;
        private string content;
        private string status = "Pending";

        public Appointment(DateTime dateTime, string content)
        {
            this.dateTime = dateTime;
            this.content = content;
        }

        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public string Content { get => content; set => content = value; }
        public string Status { get => status; set => status = value; }
    }
}
