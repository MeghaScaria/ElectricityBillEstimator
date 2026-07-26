// Customer model
// Only stores customer information
public class Customer
{ 
    public int CustomerId { get; set; }
    public string CustomerName { get; set; } = "";
    public int UnitsConsumed { get; set; }
    public double RatePerUnit { get; set; }
    public double FixedCharge { get; set; }
    public double DutyPercentage { get; set; }
}
