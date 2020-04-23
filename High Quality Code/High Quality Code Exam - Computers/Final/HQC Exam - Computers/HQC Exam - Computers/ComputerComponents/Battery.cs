namespace HQC_Exam___Computers.ComputerComponents
{
    using HQC_Exam___Computers.ComputerComponents.Contracts;

    public abstract class Battery : IBattery
    {
        private int percentage;
        public int Percentage
        {
            get
            {
                return this.percentage;
            }
            protected set
            {
                if (value >= 100)
                {
                    this.percentage = 100;
                }

                if (value <= 0)
                {
                    this.percentage = 0;
                }
            }
        }

        public Battery()
        {
            this.Percentage = BatteryDefaultCharge();
        }
        public void Charge(int amountToCharge)
        {
            this.Percentage += amountToCharge;
        }

        protected abstract int BatteryDefaultCharge();
    }
}
