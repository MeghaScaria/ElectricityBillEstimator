using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricityBillEstimator.Views
{
    public class CustomerFormView
    {
        private static int _choice = 0;
        public static int Choice { get => _choice; set => _choice = value; }
        public static List<string> MenuList
        {
            get;
            set;
        }

        /// <summary>
        /// This will be shown to all kinds of users - user/admin/partner
        /// </summary>
        public static void LoadMenuList()
        {
            CustomerFormView.MenuList = new List<string>() {
                "1. Enter Customer ID",
                "2. Enter Customer Name",
                "3. Enter Units Consumed",
                "4. Enter Rate Per Unit",
                "5. Enter Fixed Charge",
                "6. Enter Electricity Duty (%)",
                "7. Exit",
            };
        }

        public static void DisplayMenu()
        {
            do//main loop
            {
                Console.Clear();
                Console.WriteLine("\n=================================");
                Console.WriteLine(" Electricity Bill Estimator");
                Console.WriteLine("=================================");
                CustomerFormView.LoadMenuList();


                foreach (string instr in CustomerFormView.MenuList)
                {
                    Console.WriteLine(instr);
                }

                Console.Write("Enter Your Choice : ");

                int.TryParse(Console.ReadLine(), out _choice);
                switch (Choice)
                {
                    default:
                        Console.WriteLine("Please enter the valid Choice .....");
                        break;
                }
            } while (Choice != MenuList.Count);
        }
    }
}
