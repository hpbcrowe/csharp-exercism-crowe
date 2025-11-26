class RemoteControlCar
{
    private int distance;
    private int battery = 100;
    public static RemoteControlCar Buy()
    {
     return new RemoteControlCar();
    }

    public string DistanceDisplay() => $"Driven {distance} meters";
    

    public string BatteryDisplay() => (battery > 0) ? $"Battery at {battery}%" : "Battery empty";
    

    public void Drive()
    {
         if (battery > 0) { distance += 20;};
        double tempBattery = battery;
        tempBattery -= (double)battery * .01; 
        battery = (int)tempBattery;
      
           
        }
        
    }

