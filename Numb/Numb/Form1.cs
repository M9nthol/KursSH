using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Numb
{
    public partial class Form1 : Form
    {

        public List<MeetingData> Meetings { get; private set; } = new List<MeetingData>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateLabelMeetingsCount();
            UpdateUpcomingMeetingsLabels(); 
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            Book form3 = new Book(this);
            this.Hide();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            MakeNumb form2 = new MakeNumb(this);
            this.Hide();
            form2.Show();
        }

        
        public void UpdateLabelMeetingsCount()
        {
            label1.Text = $"Количество встреч: {Meetings.Count}";
        }


        public void AddMeeting(string fio, string phoneNumber, DateTime meetingDate, string meetingPlace, string meetingDescription)
        {
            Meetings.Add(new MeetingData
            {
                FIO = fio,
                PhoneNumber = phoneNumber,
                MeetingDate = meetingDate,
                MeetingPlace = meetingPlace,
                MeetingDescription = meetingDescription
            });
            UpdateLabelMeetingsCount();
            UpdateUpcomingMeetingsLabels(); 
        }

        public void RemoveMeeting(MeetingData meeting)
        {
            Meetings.Remove(meeting);
            UpdateLabelMeetingsCount();
            UpdateUpcomingMeetingsLabels(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateUpcomingMeetingsLabels()
        {
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);
            DateTime threeDaysFromNow = today.AddDays(3);

            //сегодня
            var todayMeetings = Meetings
              .Where(m => m.MeetingDate.Date == today)
              .ToList();
            label5.Text = $"Встречи сегодня: {todayMeetings.Count}";


            //завтра
            var tomorrowMeetings = Meetings
               .Where(m => m.MeetingDate.Date == tomorrow)
               .ToList();
            label4.Text = $"Встречи завтра: {tomorrowMeetings.Count}";

            //в ближайшие 3 дня
            var threeDayMeetings = Meetings
               .Where(m => m.MeetingDate.Date > today && m.MeetingDate.Date <= threeDaysFromNow)
               .ToList();

            label6.Text = $"Встречи в ближайшие 3 дня: {threeDayMeetings.Count}";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
