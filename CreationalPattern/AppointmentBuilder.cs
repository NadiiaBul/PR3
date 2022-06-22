using System;

namespace CreationalPattern
{
    class AppointmentBuilder : IBuilder
    {
        private readonly Appointment _appointment = new Appointment();
        public void SetDate(DateTime date)
        {
            _appointment.Date = date;
        }

        public void SetInfo(params string[] info)
        {
            _appointment.Deadline = DateTime.Parse(info[0]);
            _appointment.Unit = info[1];
        }

        public void SetNumber(uint number)
        {
            _appointment.Number = number;
        }
        public Appointment GetAppointment()
        {
            return _appointment;
        }
    }
}
