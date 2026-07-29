using ElectricityBillEstimator.Views;

public class MenuView
{
    /// <summary>
    /// Comments for Docs should be generated using /// <summary> and </summary> tags. This method displays the main menu options to the user.
    /// </summary>

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
        MenuView.MenuList = new List<string>() {
                "1. Generate New Bill",
                "2. View Bill",
                "3. Clear Data",
                "4. Exit",
            };
    }

    public static void DisplayMenu()
    {
        do//main loop
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine(" Electricity Bill Estimator");
            Console.WriteLine("=================================");
            MenuView.LoadMenuList();


            foreach (string instr in MenuView.MenuList)
            {
                Console.WriteLine(instr);
            }

            Console.Write("Enter Your Choice : ");


            int.TryParse(Console.ReadLine(), out _choice);
            switch (Choice)
            {
                case 1:
                    CustomerFormView.DisplayMenu();
                    //await HomeView.Instance.View();
                    break;

                case 2:
                    //ForgotPasswordFormView.Instance.View();
                    break;

                case 3:
                    //Contact Us
                    break;

                case 4:
                    //Careers
                    break;

                default:
                    Console.WriteLine("Please enter the valid Choice .....");
                    break;
            }
        } while (Choice != MenuList.Count);
    }
}