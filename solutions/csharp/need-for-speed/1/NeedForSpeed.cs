using System;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int batteryLevel;
    private int distanceDriven;
    
    public RemoteControlCar(int speed, int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        batteryLevel = 100;
        distanceDriven = 0;
    }

    public bool BatteryDrained() => batteryLevel < batteryDrain;
   

    public int DistanceDriven() => distanceDriven;

    public void Drive(){
        if(BatteryDrained()) return;
        
        distanceDriven += speed;
        batteryLevel -= batteryDrain;
        }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50,4);
}

class RaceTrack
{
    private int distance;
    
    public RaceTrack(int distance) => this.distance=distance;
    
    public bool TryFinishTrack(RemoteControlCar car){
        while(car.DistanceDriven() < distance){
            if(!car.BatteryDrained())
            car.Drive();
            else
            return false;
        }    
    return true;
    }
    
}
