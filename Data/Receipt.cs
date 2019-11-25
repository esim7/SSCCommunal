using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Receipt : Entity
    {
        public Guid AbonentId { get; set; }
        public string BillingMonth { get; set; }
        public int ElectricityDebt { get; set; }
        public int WaterDebt { get; set; }
        public int InternetDebt { get; set; }
        public int GasDebt { get; set; }

    }
}
