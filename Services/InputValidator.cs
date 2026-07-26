public class InputValidator
{
    public bool ValidateUnits(int units) => units > 0;
    public bool ValidateRate(double rate) => rate > 0;
    public bool ValidateFixedCharge(double fixedCharge) => fixedCharge >= 0;
    public bool ValidateDuty(double dutyPercentage) => dutyPercentage >= 0;
}
