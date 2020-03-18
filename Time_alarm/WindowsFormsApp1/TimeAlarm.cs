using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TimeAlarm : Form
    {
        public TimeAlarm()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void SecTimer_Tick(object sender, EventArgs e)
        {
            int minuteSet = (int)minutesCounter.Value;
            int secondSet = (int)secondsCounter.Value;

            int minuteNow = DateTime.Now.Minute;
            int secondNow = DateTime.Now.Second;

            labelTimeNow.Text = String.Format("Time now: {0}:{1}", minuteNow, secondNow);

            // алярм в ровную минуту
            if (minuteNow % minuteSet == 0 && secondNow == 0)
            {
                if (minuteNow == 30 && sound_30M.Checked)
                {
                    // сюда Алярм 30 мин
                    MessageBox.Show("АЛЯРМ! - 30 мин");
                }
                else if (minuteNow == 0 && sound_1H.Checked)
                {
                    // сюда Алярм 1 час
                    MessageBox.Show("АЛЯРМ! - 1 час");
                }
                else if (secondSet == 0 && sound_5M.Checked)
                {
                    // сюда Алярм 5 мин
                    MessageBox.Show(String.Format("АЛЯРМ! - {0} минут", minuteNow));
                }
            }
            // если таймер установлен за 'secondSet' секунд и текущая минута 4, 9, 14 ... 59
            else if (secondSet != 0 && (minuteNow + 1) % minuteSet == 0 && secondNow == 60 - secondSet && sound_5M.Checked 
                    // и при этом не установлено алярмов на 30М и 1H
                    && !(minuteNow + 1 == 30 && sound_30M.Checked) && !(minuteNow + 1 == 60 && sound_1H.Checked))
            {
                // сюда Алярм 5 мин
                MessageBox.Show(String.Format("АЛЯРМ! - {0} минут, за {1} секунд", minuteNow + 1, secondSet));
            }
        }
    }
}
