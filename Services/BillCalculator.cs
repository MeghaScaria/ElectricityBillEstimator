public class BillCalculator
{
    public Bill CalculateBill(Customer customer)
    {
        double energyCharge = customer.UnitsConsumed * customer.RatePerUnit;
        double dutyAmount = energyCharge * (customer.DutyPercentage / 100);
        return new Bill
        {
            EnergyCharge = energyCharge,
            DutyAmount = dutyAmount,
            FinalAmount = energyCharge + dutyAmount + customer.FixedCharge,
            AverageDailyConsumption = customer.UnitsConsumed / 30.0
        };
    }
}