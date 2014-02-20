using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MobilePhoneDevice
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string ownersName;
        private Battery battery;
        private Display display;
        private List<Call> callsHistoryList; // Task 9
        private static string iPhone4S; // static field // Task 6

        static MobilePhoneDevice() // static property // Task 6
        {
            IPhone4S = "model: iPhone-4S";
        }

        public MobilePhoneDevice(string model, string manufacturer, decimal price, string ownersName) // constructor 1 (Task 2)
        : this(model, manufacturer)
        {
            this.Price = price;
            this.OwnersName = ownersName;
        }

        public MobilePhoneDevice(string model, string manufacturer) // alternative constructor 2 (Task 2)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.battery = new Battery(BatteryType.none, 0.0m, 0.0m);
            this.display = new Display(0, 0);
            this.callsHistoryList = new List<Call>();
        }

        //public MobilePhoneDevice() // alternative constructor 3 (Task 2)
        //{
        //}

        public Battery battProperty
        {
            get { return this.battery; }
            set { this.battery = value; } // a check is needed whether a null value is set !!!
        }

        public Display displProperty
        {
            get { return this.display; }
            set { this.display = value; } // a check is needed whether a null value is set !!!
        }

        public string Model // property
        {
            get { return this.model; }
		    set
		    {
			    if (String.IsNullOrEmpty(value))
			    {
				    throw new ArgumentException("Name cannot be empty!");
			    }
			    if (value.Length < 3)
			    {
				    throw new ArgumentException("Name too short! Name must be at least 3 letters long.");
			    }
			    if (value.Length >= 30)
			    {
				    throw new ArgumentException("Name too long! Name must be less than 30 letters long.");
			    }
			    foreach (char ch in value)
			    {
				    if (!char.IsLetter(ch) && ch != '-' && ch != ' ')
				    {
					    throw new ArgumentException("Invalid name! Please use letters, spaces and hyphens only.");
				    }
			    }
			    this.model = value;
		    }
        }

        public string Manufacturer // property
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name too short! Name must be at least 3 letters long.");
                }
                if (value.Length >= 30)
                {
                    throw new ArgumentException("Name too long! Name must be less than 30 letters long.");
                }
                foreach (char ch in value)
                {
                    if (!char.IsLetter(ch) && ch != '-' && ch != ' ')
                    {
                        throw new ArgumentException("Invalid name! Please use letters, spaces and hyphens only.");
                    }
                }
                this.manufacturer = value;
            }
        }

        public decimal Price  // property
        {
            get { return this.price;  }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price value cannot be negative! Please insert a positive value.");
                }               
                this.price = value;
            }
        }

        public string OwnersName // property
        {
            get { return this.ownersName; }
            set
            {

                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Name too short! Name must be at least 3 letters long.");
                }

                if (value.Length >= 30)
                {
                    throw new ArgumentException("Name too long! Name must be less than 30 letters long.");
                }

                foreach (char ch in value)
                {
                    if (!char.IsLetter(ch) && ch != '-' && ch != ' ')
                    {
                        throw new ArgumentException("Invalid name! Please use letters, spaces and hyphens only.");
                    }
                }

                this.ownersName = value;
            }
        }

        public static string IPhone4S // static property (Task 6)
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }

        public List<Call> CallsHistoryList // Task 9
        {
            get { return this.callsHistoryList; }
        }
        
        public void AddCall(Call call) // Task 10
        {
            this.callsHistoryList.Add(call);
        }

        public void DeleteCall(Call call) // Task 10
        {
            this.callsHistoryList.Remove(call);
        }

        public void ClearCallHistory() // Task 10
        {
            this.callsHistoryList.Clear();
        }

        public decimal CalculateTotalPrice(decimal callPrice) // Task 11
        {
            decimal result = 0;
            int totalDuration = 0;
            foreach (var call in this.callsHistoryList)
            {
                totalDuration += call.Duration;
            }
            result = (totalDuration / 60) * callPrice;
            return result;
        }

        public override string ToString() // Task 4
        {
            return string.Format("Model: {0}\nManufacturer: {1}\nPrice in BGN: {2}\nOwner's Name: {3}\nBattery: {4}\nDisplay: {5}",
                this.model, this.manufacturer, this.price, this.ownersName, this.battery, this.display);
        }
    }
}
