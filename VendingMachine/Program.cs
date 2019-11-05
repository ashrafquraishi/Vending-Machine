using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        // Description
        // This is a vending application created by Ashraf
        
        //There is a list of snacks that you can select from
        //Enter (1-5) to make a selection
        //Once you select a snack
        //You will be displayed the price
        //Then make a payment
        //if you make a payment less than what you owe you will asked again to oay the rest of the amount
        // or if you make a payment equal to or more than you owe, you will be given your change back

         // Class Used
         //VendingCard.cs for Cashing the Customer
         //Constant.cs was used to store string Constants
         //VendingCartTest used for unit testing 





        static void Main(string[] args)
        {
            // I instantiated VendinfCart class to pass customer select through its object

            VendingCart vendingCart = new VendingCart();
            

                       // This is were the application store the user choice of snack
            var CustomerCart = new List<string>();

            // These are the snacks choices avaiable
            var Snack = new List<string>();
            Snack.Add(Constant.Cheetos);
            Snack.Add(Constant.Lay);
            Snack.Add(Constant.Nacho);
            Snack.Add(Constant.HoneyBun);
            Snack.Add(Constant.Doritos);

            
            Console.WriteLine(Constant.WelcomeCustomer );
            Console.WriteLine(Constant.DisplaySnacks);
            

            // This method will used in getting user choice of snack
            try
            {

                bool ValidSelection = true;
                do
                {

                    Console.WriteLine(Constant.SnackSelection);
                    string SelectingSnack = Console.ReadLine();


                    switch (SelectingSnack)                                 //This switch statement will used to determine what is selected 
                    {
                        case "1":
                            CustomerCart.Add(Constant.Cheetos);
                            vendingCart.AddToCart(CustomerCart);       //Then we will send the selected snack to user's Cart
                                                                       // After this will send the item for get checked in VendindCart.cs file
                            break;
                        case "2":
                            CustomerCart.Add(Constant.Lay);

                            vendingCart.AddToCart(CustomerCart);
                            break;
                        case "3":
                            CustomerCart.Add(Constant.Nacho);

                            vendingCart.AddToCart(CustomerCart);
                            break;
                        case "4":
                            CustomerCart.Add(Constant.HoneyBun);

                            vendingCart.AddToCart(CustomerCart);
                            break;
                        case "5":
                            CustomerCart.Add(Constant.Doritos);

                            vendingCart.AddToCart(CustomerCart);
                            break;

                        default:
                            Console.WriteLine(Constant.InvalidSelection);


                            break;





                    }

                    // If a  user entered  an invalid entry or once the selection this done this code will be excuted
                    //If a user want to select a snack again they can enter y or if thedont want to continue they can enter N this will stop the application

                    var DecisionToContinue = string.Empty;
                    do
                    {
                        Console.WriteLine(Constant.ContinueBuying);
                        DecisionToContinue = Console.ReadLine() ?? string.Empty;

                    } while (!DecisionToContinue.Equals("Y", StringComparison.OrdinalIgnoreCase) && !DecisionToContinue.Equals("N", StringComparison.OrdinalIgnoreCase));
                    ValidSelection = DecisionToContinue.Equals("Y", StringComparison.OrdinalIgnoreCase);

                } while (ValidSelection);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }




        }

        
    }
}
