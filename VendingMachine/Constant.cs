using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{

    // This class is used to store all the string constant
    // I did this to keep the code clean and easier to make changes in future
    class Constant
    {
        
        public const string WelcomeCustomer = "Welcome to Vending Machine! We have different kind of snacks available.   ";
        public const string DisplaySnacks = "(1)Cheetos $2.15, (2) Nachos $2.30, (3)Lays 2.00, (4)Honey Bun 1.20, (5)Doritos 1.69";
        public const string SnackSelection = "Please Select Your Snack By Entering (1-5)";
        public const string Cheetos = "Cheetos";
        public const string Lay = "Lay";
        public const string HoneyBun = "HoneyBun";
        public const string Nacho = "Nacho";
        public const string InvalidSelection = "Invalid Entry. Please Enter a Numeric Value  ";
        public const string RequestPayment = "Please Make Your Payment";
        public const string Doritos = "Doritos";
        public const string ContinueBuying = "Do you want to continue?(Y/N)";
        public const string ShowCustomerChange = "Your Change:{0}";

        public const string CustomerOweMoney = "Insuffient amount, you owe {0}";
        public const string CustomerOweNothing = "Thank you for shopping";


    }
}
