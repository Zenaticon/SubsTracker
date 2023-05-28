using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace SubsTracker.Core
{
    public class Subscription
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Provider { get; set; }
        public string Icon { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public bool Type { get; set; }
        public int Day { get; set; }
        public string Month { get; set; }
    }
}
