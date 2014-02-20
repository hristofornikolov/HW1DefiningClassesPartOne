using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 12. Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
// * Create an instance of the GSM class.
// * Add few calls.
// * Display the information about the calls.
// * Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
// * Remove the longest call from the history and calculate the total price again.
// * Finally clear the call history and print it.

namespace Task1
{
    class CallHistoryTest
    {
        public static void Test()
        {
            MobilePhoneDevice telephone = new MobilePhoneDevice("Alcatel", "Lucent");
        
            telephone.AddCall(new Call(new DateTime(2014, 02, 01, 13, 12, 51), "+359879310320", 354));
            telephone.AddCall(new Call(new DateTime(2014, 02, 02, 17, 21, 50), "0876520320", 211));
            telephone.AddCall(new Call(new DateTime(2014, 02, 03, 10, 45, 13), "0887675685", 108));

            foreach (var call in telephone.CallsHistoryList)
            {
                Console.WriteLine(call);
            }

            var totalCallsPrice = telephone.CalculateTotalPrice(Call.CallPrice);
            Console.WriteLine("The total price of all calls is: {0} BGN.", totalCallsPrice);

            var sortedCallList = telephone.CallsHistoryList.OrderBy(c => c.Duration);
            var longestCall = sortedCallList.Last();
            Console.WriteLine(longestCall);
            telephone.DeleteCall(longestCall);

            var newTotalCallsPrice = telephone.CalculateTotalPrice(Call.CallPrice); // the newly calculated price
            Console.WriteLine("The total price of all calls is after the deletion of the longest call: {0} BGN.", newTotalCallsPrice);

            telephone.ClearCallHistory();
            Console.WriteLine("Here is the call history after the clearing.");
            
            foreach (var call in telephone.CallsHistoryList)
            {
                Console.WriteLine(call);
            }

        }
    }
}
