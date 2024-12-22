using System;
using System.Windows.Forms;

namespace Numb
{
    public partial class MakeNumb : Form
    {
        private readonly Form1 _parentForm;

        public MakeNumb(Form1 parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                string fio = textBox1.Text;
                string phoneNumber = textBox2.Text;
                DateTime meetingDate = dateTimePicker1.Value; 
                string meetingPlace = textBox4.Text;
                string meetingDescription = textBox5.Text;

                _parentForm.AddMeeting(fio, phoneNumber, meetingDate, meetingPlace, meetingDescription);
                MessageBox.Show("Встреча успешно создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                _parentForm.Show();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите ФИО клиента.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            _parentForm.Show();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
