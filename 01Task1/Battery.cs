using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Battery
    {
        private BatteryType batteryModel;
        private decimal standbyModeHours;
        private decimal activeModeHours;

        public Battery(BatteryType batteryModel, decimal standbyModeHours, decimal activeModeHours) // constructor
        {
            this.BatteryModel = batteryModel;
            this.StandbyModeHours = standbyModeHours;
            this.ActiveModeHours = activeModeHours;
        }

        public BatteryType BatteryModel // property
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; } 
        }

        public decimal StandbyModeHours // property
        {
            get { return this.standbyModeHours; }
            set { this.standbyModeHours = value; } 
        }

        public decimal ActiveModeHours // property
        {
            get { return this.activeModeHours; }
            set { this.activeModeHours = value; } 
        }

        public override string ToString() // Task 4
        {
            return string.Format("BatteryModel: {0}, StandbyModeHours: {1}, ActiveModeHours: {2}",
                this.BatteryModel, this.StandbyModeHours, this.ActiveModeHours);
        }
    }
}
