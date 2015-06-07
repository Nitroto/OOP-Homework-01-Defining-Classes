using System;

class Battery
{
    private double batteryLife;
    private string batteryInfo;

    public Battery(string info, double batteryLife)
    {
        this.BatteryInfo = info;
        this.BatteryLife = batteryLife;
    }

    public string BatteryInfo
    {
        get { return this.batteryInfo; }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("batteryInfo", "Battery description can not be empty or null!");
            }
            this.batteryInfo = value;
        }
    }
    public double BatteryLife
    {
        get { return this.batteryLife; }
        set
        {
            if (value < 0.0)
            {
                throw new ArgumentOutOfRangeException("batteryLife", "Battery life can not be negative!");
            }
            this.batteryLife = value;
        }
    }

}
