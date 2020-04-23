namespace HQC_Exam___Computers
{
    using HQC_Exam___Computers.ComputerComponents;
    public class LaptopBattery : Battery
    {
        private const int LaptopBatteryInitialChargePercentage = 50;
        protected override int BatteryDefaultCharge()
        {
            return LaptopBatteryInitialChargePercentage;
        }
    }
}
