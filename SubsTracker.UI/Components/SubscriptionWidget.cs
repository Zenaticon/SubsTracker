using System;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubsTracker.Core;

namespace SubsTracker.UI.Components
{
    public partial class SubscriptionWidget : UserControl
    {
        public static readonly DataManager dm = new DataManager();
        public event EventHandler OnSelect = null;
        public event EventHandler OnSelectDelete = null;

        public Guid SubId { get; set; }
        public Guid UserId { get; set; }
        public string SubName { get; set; }
        public Image Icon { get; set; }
        public string Amount { get; set; }
        public string Currency { get; set; }
        public bool Type { get; set; }
        public int Day { get; set; }
        public string Month { get; set; }
        public SubscriptionWidget()
        {
            InitializeComponent();
        }

        private void SubscriptionWidget_Load(object sender, EventArgs e)
        {
            string yearName;
            DateTime currentDate = DateTime.Now;
            DateTime nextMonth = currentDate;
            subscriptionName.Text = SubName;
            subscriptionIcon.Image = Icon;
            subscriptionAmmount.Text = Amount.ToString() + " " + Currency;
            if (Type)
            {
                if (Day < DateTime.Today.Day)
                {
                    nextMonth = currentDate.AddMonths(1);
                    string monthName = nextMonth.ToString("MMM");
                    subscriptionDate.Text = Day.ToString() + " " + monthName;
                }
                else if (Day > DateTime.Today.Day)
                {
                    string monthName = nextMonth.ToString("MMM");
                    subscriptionDate.Text = Day.ToString() + " " + monthName;
                }
                else
                {
                    subscriptionDate.Text = "Today";
                }
            }
            else
            {
                DateTime date = DateTime.ParseExact(Month, "MMM", CultureInfo.InvariantCulture);
                if (date.Month < DateTime.Today.Month)
                {
                    currentDate = currentDate.AddYears(1);
                    yearName = currentDate.ToString("Y").Split(' ')[1];
                    subscriptionDate.Text = Day.ToString() + " " + Month + " " + yearName;
                }
                else if (date.Month > DateTime.Today.Month)
                {
                    yearName = currentDate.ToString("Y").Split(' ')[1];
                    subscriptionDate.Text = Day.ToString() + " " + Month + " " + yearName;
                }
                else
                {
                    if (Day < DateTime.Today.Day)
                    {
                        currentDate = currentDate.AddYears(1);
                        yearName = currentDate.ToString("Y").Split(' ')[1];
                        subscriptionDate.Text = Day.ToString() + " " + Month + " " + yearName;
                    }
                    else if(Day > DateTime.Today.Day)
                    {
                        yearName = currentDate.ToString("Y").Split(' ')[1];
                        subscriptionDate.Text = Day.ToString() + " " + Month + " " + yearName;
                    }
                    else
                    {
                        subscriptionDate.Text = "Today";
                    }
                    
                }
            }
        }

        private void SubscriptionPanel_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void SubscriptionIcon_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void SubscriptionName_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void SubscriptionAmmount_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void SubscriptionDate_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                OnSelectDelete?.Invoke(this, e);
            });
        }
    }
}
