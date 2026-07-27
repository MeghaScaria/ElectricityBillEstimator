using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        Bill? bill = null;

        BillCalculator calculator = new BillCalculator();
        InputValidator validator = new InputValidator();
        Menu menu = new Menu();

        bool running = true;

        while (running)
        {
            menu.Display();
            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1:

                    Console.Write("\nEnter Customer ID: ");
                    int.TryParse(Console.ReadLine(), out int customerId);
                    customer.CustomerId = customerId;

                    Console.Write("Enter Customer Name: ");
                    customer.CustomerName = Console.ReadLine() ?? ""; // null-coalescing operator

                    Console.Write("Enter Units Consumed: ");
                    int.TryParse(Console.ReadLine(), out int units);
                    customer.UnitsConsumed = units;

                    if (!validator.ValidateUnits(customer.UnitsConsumed))
                    {
                        Console.WriteLine("Units must be greater than zero.");
                        break;
                    }

                    Console.Write("Enter Rate Per Unit: ");
                    double.TryParse(Console.ReadLine(), out double rate);
                    customer.RatePerUnit = rate;

                    if (!validator.ValidateRate(customer.RatePerUnit))
                    {
                        Console.WriteLine("Rate must be greater than zero.");
                        break;
                    }

                    Console.Write("Enter Fixed Charge: ");
                    double.TryParse(Console.ReadLine(), out double fixedCharge);
                    customer.FixedCharge = fixedCharge;

                    if (!validator.ValidateFixedCharge(customer.FixedCharge))
                    {
                        Console.WriteLine("Fixed charge cannot be negative.");
                        break;
                    }

                    Console.Write("Enter Electricity Duty (%): ");
                    double.TryParse(Console.ReadLine(), out double duty);
                    customer.DutyPercentage = duty;

                    if (!validator.ValidateDuty(customer.DutyPercentage))
                    {
                        Console.WriteLine("Duty percentage cannot be negative.");
                        break;
                    }

                    bill = calculator.CalculateBill(customer);

                    Console.WriteLine("\nBill generated successfully!");
                    break;

                case 2:

                    if (bill == null)
                    {
                        Console.WriteLine("\nNo bill has been generated yet.");
                    }
                    else
                    {
                        Console.WriteLine("\n========== Electricity Bill ==========");

                        Console.WriteLine($"Customer ID          : {customer.CustomerId}");
                        Console.WriteLine($"Customer Name        : {customer.CustomerName}");
                        Console.WriteLine($"Units Consumed       : {customer.UnitsConsumed}");
                        Console.WriteLine($"Rate Per Unit        : ₹{customer.RatePerUnit:F2}");
                        Console.WriteLine($"Fixed Charge         : ₹{customer.FixedCharge:F2}");
                        Console.WriteLine($"Duty Percentage      : {customer.DutyPercentage}%");

                        Console.WriteLine("--------------------------------------");

                        Console.WriteLine($"Energy Charge        : ₹{bill.EnergyCharge:F2}");
                        Console.WriteLine($"Duty Amount          : ₹{bill.DutyAmount:F2}");
                        Console.WriteLine($"Final Bill Amount    : ₹{bill.FinalAmount:F2}");
                        Console.WriteLine($"Average Daily Units  : {bill.AverageDailyConsumption:F2}");

                        Console.WriteLine("======================================");
                    }

                    break;

                case 3:

                    customer = new Customer();
                    bill = null;

                    Console.WriteLine("\nData cleared successfully.");

                    break;

                case 4:

                    running = false;
                    Console.WriteLine("\nThank you for using Electricity Bill Estimator!");

                    break;

                default:

                    Console.WriteLine("\nInvalid choice. Please try again.");

                    break;
            }
        }
    }
}