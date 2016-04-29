using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    public class OrderingSystem
    {
        //create the object to use it in this class
        private SqlData _sqlData = new SqlData();
        
        //constructor
        public OrderingSystem()
        {
            ShowMenu();
        }
        public void ShowMenu()
        { 
            Console.WriteLine("\n*********************************************************" +
                              "\n* *Welcome to Bangazon!Command Line Ordering System * *" +
                              "\n*********************************************************" +
                              "\n1.Create an account" +
                              "\n2.Create a payment option" +
                              "\n3.Order a product" +
                              "\n4.Complete an order" +
                              "\n5.See product popularity" +
                              "\n6.Leave Bangazon!");

            //Use the ReadLine for call the functions
            //string key is going to return the numbers of the menu (any key that the user presses)
            string key = Console.ReadLine();

            //we need the while loop to keep the menu going
            while (key != "6")
            {
                switch(key)
                {
                    case "1":
                        CreateAccount();
                        break;
                    case "2":
                        CreatePaymentOption();
                        break;
                    case "3":
                        OrderProduct();
                        break;
                    case "4":
                        CompleteOrder();
                        break;
                    case "5":
                        SeeProductPopularity();
                        break;
                }

                key = Console.ReadLine();
            }
        }

        //this is a stubbed function 
        public void CreateAccount()
        {
            string firstName = "";
            string lastName = "";
            string streetAddress = "";
            string city = "";
            string stateProvidence = "";
            string postalCode = "";
            string phoneNumber = "";

            Console.WriteLine("Enter Customer First Name");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Customer Last Name");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Street");
            streetAddress = Console.ReadLine();
            Console.WriteLine("Enter City");
            city = Console.ReadLine();
            Console.WriteLine("Enter State/Providence");
            stateProvidence = Console.ReadLine();
            Console.WriteLine("Enter Postal Code");
            postalCode = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            phoneNumber = Console.ReadLine();

            _sqlData.CreateCustomer(firstName, lastName, streetAddress, city, stateProvidence, postalCode, phoneNumber);
        }
        public void CreatePaymentOption() { }
        public void OrderProduct() { }
        public void CompleteOrder() { }
        public void SeeProductPopularity() { }
        public void LeaveBangazon() { }
    }
}
