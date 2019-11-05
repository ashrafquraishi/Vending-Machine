using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
  public  class VendingCart
    {
        double _Invoice;
              double _Cheetos =2.15;
       double _Nachos = 2.30;
        double _Lays = 2.00;
         double _Honey = 1.20;
        double _Doritos = 1.69;
       
        //This method is using the select snack and making an invoice of the charges

        public double AddToCart(List<string>cart)

        {

           foreach(string Cart in cart)                   // By using foreeach loop i am check what is selected my the user a
            {
                if (Cart.Contains(Constant.Cheetos))               // With the if statement checking to see if a user has selected a specific item
                {
                    _Invoice = +_Cheetos;                            //then we will take the snacks worth and add it to the invoice
                }
                else if(Cart.Contains(Constant.Nacho))
                {
                    _Invoice = +_Nachos;

                }
                else if (Cart.Contains(Constant.Lay))
                {
                    _Invoice = +_Lays;


                }
               else  if (Cart.Contains(Constant.HoneyBun))
                {
                    _Invoice = +_Honey ;

                }
               else if (Cart.Contains(Constant.Doritos))
                {
                    _Invoice = +_Doritos;

                }
              
            }
           
            Console.WriteLine(_Invoice);
            var ChargingCustomer = ChargeCustomer(_Invoice);
            return _Invoice;
           
        }

        // This method will be used to Charge the Customer 
        public object ChargeCustomer(double inVoice  )                                                            // This has once parameter, this parameter will used to compare Customer Input
        {
            bool CashingCustomer = false;                               
            do                                                                              
            {
                Console.WriteLine(Constant.RequestPayment);                                                 

                string CustomerInput = Console.ReadLine();                                
                double CustomerMoney;
              bool ConversionSuccesful =  double.TryParse(CustomerInput, out CustomerMoney);                       //Since customer input will be numeric string, i used tryparse to convert it to int

                if(!ConversionSuccesful)                                                                        //If a user input is not numeric. THis will throw Exception
                {
                    throw new Exception(Constant.InvalidSelection);
                }

                if (CustomerMoney > inVoice)                                                                   //if a customer a paying more than what they owe this condition will give out the change that is vending machine owe
                {
                    Console.WriteLine(Constant.ShowCustomerChange, CustomerMoney - inVoice);
                    Console.WriteLine(Constant.CustomerOweNothing);
                }


                else if (CustomerMoney == inVoice)                                                      //if a customer a paying exactly what they owe this condition will be excuted
                {
                    Console.WriteLine(Constant.CustomerOweNothing);
                    
                    break;


                }

                 
                else if (CustomerMoney < inVoice)                                                        //if a customer a paying less what they owe this condition will be excuted
                {


                    double CustomerOweMoney = inVoice - CustomerMoney;
                    do
                    {
                        

                        Console.WriteLine(Constant.CustomerOweMoney, CustomerOweMoney);




                    } while (CustomerOweMoney.Equals(0) && CustomerOweMoney.Equals(CustomerMoney > inVoice) );         //i am using do while for checking to see if Customer paying exactly or more than what they owe 
                                                                                                                        //if not do while will keep asking the customer to enter the money they owe

                   
                    CashingCustomer = CustomerOweMoney.Equals(0) && CustomerOweMoney.Equals(CustomerMoney > inVoice);
                    ChargeCustomer(CustomerOweMoney);

                }
                
            } while (CashingCustomer);

            return inVoice;
            

        }

    }

}
