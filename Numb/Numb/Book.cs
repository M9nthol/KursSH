using System;
using System.Linq;
using System.Windows.Forms;

namespace Numb
{
    public partial class Book : Form
    {
        private readonly Form1 _parentForm;
        public Book(Form1 parent)
        {
            InitializeComponent();
            _parentForm = parent;
            InitializeDataGridView();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.Show();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("FIO", "ФИО");
            dataGridView1.Columns.Add("PhoneNumber", "Номер телефона");
            dataGridView1.Columns.Add("MeetingDate", "Дата встречи");
            dataGridView1.Columns.Add("MeetingPlace", "Место встречи");
            dataGridView1.Columns.Add("MeetingDescription", "Описание встречи");

            foreach (var meeting in _parentForm.Meetings)
            {
                dataGridView1.Rows.Add(meeting.FIO, meeting.PhoneNumber, meeting.MeetingDate.ToShortDateString(), meeting.MeetingPlace, meeting.MeetingDescription);
            }

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Удалить";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButtonColumn);
            dataGridView1.CellClick += dataGridView1_CellClick;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _parentForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index)
            {
                int rowIndex = e.RowIndex;

                string fio = dataGridView1.Rows[rowIndex].Cells["FIO"].Value.ToString();
                string phoneNumber = dataGridView1.Rows[rowIndex].Cells["PhoneNumber"].Value.ToString();

                // тут дата
                DateTime meetingDate = DateTime.Parse(dataGridView1.Rows[rowIndex].Cells["MeetingDate"].Value.ToString());

                string meetingPlace = dataGridView1.Rows[rowIndex].Cells["MeetingPlace"].Value.ToString();
                string meetingDescription = dataGridView1.Rows[rowIndex].Cells["MeetingDescription"].Value.ToString();

                //сравнивание даты
                MeetingData meetingToRemove = _parentForm.Meetings.FirstOrDefault(m => m.FIO == fio && m.PhoneNumber == phoneNumber
                                                            && m.MeetingDate.Date == meetingDate.Date && m.MeetingPlace == meetingPlace && m.MeetingDescription == meetingDescription);

                if (meetingToRemove != null)
                {
                    _parentForm.RemoveMeeting(meetingToRemove);
                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении записи, попробуйте ещё раз");
                }
            }
        }

        private void Book_Load(object sender, EventArgs e)
        {

        }
    }
}
