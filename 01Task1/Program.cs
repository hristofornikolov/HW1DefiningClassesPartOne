using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Battery batteryOne = new Battery(BatteryType.NiMH, 120.00m, 6.00m);
            Display displayOne = new Display(5, 512);
            MobilePhoneDevice mobilePhoneOne = new MobilePhoneDevice("HTC", "HONG ME");  // Task 4 // Task 12
            mobilePhoneOne.battProperty = batteryOne;
            mobilePhoneOne.displProperty = displayOne;

            //Console.Write("Please insert a model: ");
            //mobilePhoneOne.model = Console.ReadLine();
            //Console.Write("Please inser a manufacturer: ");
            //mobilePhoneOne.manufacturer = Console.ReadLine();
            //Console.Write("Please insert a price: ");
            //mobilePhoneOne.price = decimal.Parse(Console.ReadLine());
            //Console.Write("Please insert an owner's name: ");
            //mobilePhoneOne.ownersName = Console.ReadLine();

            Battery batteryTwo = new Battery(BatteryType.LiIon, 96.00m, 5.00m);
            Display displayTwo = new Display(4, 512);
            MobilePhoneDevice mobilePhoneTwo = new MobilePhoneDevice("S Duos", "Samsung", 420.00m, "Georgi Minkov"); // Task 4 // Task 12
            mobilePhoneTwo.battProperty = batteryTwo;
            mobilePhoneTwo.displProperty = displayTwo;

            Battery batteryThree = new Battery(BatteryType.NiCd, 120.00m, 6.00m);
            Display displayThree = new Display(5, 1024);
            MobilePhoneDevice mobilePhoneThree = new MobilePhoneDevice("Lumia", "Nokia", 650.00m, "Dimitar Petrov"); // Task 4 // Task 12
            mobilePhoneThree.battProperty = batteryThree;
            mobilePhoneThree.displProperty = displayThree;

            //Console.WriteLine(mobilePhoneOne); // Task 4
            //Console.WriteLine(mobilePhoneTwo); // Task 4
            //Console.WriteLine(mobilePhoneThree); // Task 4

            MobilePhoneDevice[] mPDArray = { mobilePhoneOne, mobilePhoneTwo, mobilePhoneThree }; // Task 7

            foreach (object item in mPDArray)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.WriteLine(MobilePhoneDevice.IPhone4S);
            Console.WriteLine();
            CallHistoryTest.Test();

        }
    }
}
