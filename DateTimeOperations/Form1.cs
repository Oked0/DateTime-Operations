namespace DateTimeOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }
        public static class DateTimeHelper
        {
            public static TimeSpan GetDateDifference(DateTime date1, DateTime date2)
            {
                return date1 > date2 ? date1 - date2 : date2 - date1;
            }

            public static bool IsLeapYear(int year)
            {
                return DateTime.IsLeapYear(year);
            }

            public static string GetTimeOfDay(DateTime time)
            {
                int hour = time.Hour;

                if (hour >= 6 && hour < 12) return "Утро";
                if (hour >= 12 && hour < 18) return "День";
                if (hour >= 18 && hour < 24) return "Вечер";
                return "Ночь";
            }

            public static string FormatDateTime(DateTime dateTime, string format)
            {
                return dateTime.ToString(format);
            }
        }

        private void InitializeCustomComponents()
        {
            // Инициализация ComboBox с форматами
            cmbFormat.Items.AddRange(new object[] {
                "dd.MM.yyyy",
                "MM/dd/yyyy",
                "yyyy-MM-dd",
                "dd MMMM yyyy",
                "dd.MM.yyyy HH:mm:ss",
                "HH:mm:ss",
                "yyyy-MM-ddTHH:mm:ss"
            });
            cmbFormat.SelectedIndex = 0;
        }

        private void btnDateDiff_Click(object sender, EventArgs e)
        {
            DateTime date1 = dtpDate1.Value;
            DateTime date2 = dtpDate2.Value;
            TimeSpan difference = DateTimeHelper.GetDateDifference(date1, date2);
            lblDateDiffResult.Text = $"{difference.Days} дней, {difference.Hours} часов, {difference.Minutes} минут";
        }

        private void btnIsLeap_Click(object sender, EventArgs e)
        {
            int year = dtpYear.Value.Year;
            bool isLeap = DateTimeHelper.IsLeapYear(year);
            lblIsLeapResult.Text = isLeap ? "Високосный" : "Не високосный";
        }

        private void btnTimeOfDay_Click(object sender, EventArgs e)
        {
            DateTime time = dtpTime.Value;
            string timeOfDay = DateTimeHelper.GetTimeOfDay(time);
            lblTimeOfDayResult.Text = timeOfDay;
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpFormat.Value;
            string format = cmbFormat.SelectedItem.ToString();
            string formatted = DateTimeHelper.FormatDateTime(dateTime, format);
            lblFormatResult.Text = formatted;
        }
    }
}
