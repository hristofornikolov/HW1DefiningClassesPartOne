using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Call // Task 8
    {
        public const decimal CallPrice = 0.37m;

        DateTime startTime;
        string phoneNumberDialed;
        int duration = 0;

        public Call(DateTime startTime, string phoneNumberDialed, int duration) // constructor (Task 8)
        {
            this.StartTime = startTime;
            this.PhoneNumberDialed = phoneNumberDialed;
            this.Duration = duration;
        }

        public DateTime StartTime // property (Task 8)
        {
            get { return this.startTime; }
            set { this.startTime = value; }
        }

        public string PhoneNumberDialed // property (Task 8)
        {
            get { return this.phoneNumberDialed; }
            set
            {
                foreach (char item in value)
                {
                    if ((item < '0' && item != '+' ) || item > '9')
                    {
                        throw new Exception("Invalid number! Please use digits only.");
                    }
                }
                if (value == null)
                {
                    throw new ArgumentException("A number dialed cannot be empty.");
                }

                this.phoneNumberDialed = value;
            }
        }

        public int Duration // property (Task 8)
        {
            get { return this.duration; }
            set
            {
               if (value <= 0)
               {
                   throw new ArgumentException("Invalid duration! Duration in seconds must be a positive integer.");
               }

                this.duration = value;
            }
        }

        public override string ToString() // Task 9
        {
            StringBuilder resultPrinter = new StringBuilder();
            resultPrinter.Append("Date: ");
            resultPrinter.Append(startTime.Date).Append("\n");
            resultPrinter.Append("Time: ");
            resultPrinter.Append(startTime.TimeOfDay).Append("\n");
            resultPrinter.Append("Number Dialed: ");
            resultPrinter.Append(phoneNumberDialed).Append("\n");
            resultPrinter.AppendFormat("Duration: {0}", duration);
            return resultPrinter.ToString();
        }
    }
}
