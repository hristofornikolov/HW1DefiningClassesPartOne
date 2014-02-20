using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Display
    {
        private int displaySize; // needed in case a check is made on the property
        private int numberOfColours; // needed in case a check is made on the property

        public Display(int displaySize, int numberOfColours) // Constructor
        {
            this.DisplaySize = displaySize;
            this.NumberOfColours = numberOfColours;
        }

        public int DisplaySize { get; set; }

        public int NumberOfColours { get; set; }

        public override string ToString() // Task 4
        {
            return string.Format("Display Size: {0}, Number of colours: {1}",
                this.DisplaySize, this.NumberOfColours);
        }
    }
}
