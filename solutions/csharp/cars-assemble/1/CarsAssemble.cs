using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double succesRate = 0.0;
        if(speed > 0 && speed < 5){
        succesRate = 1.0;
        }else if (speed >= 5 && speed < 9){
        succesRate =  0.9;
        }else if (speed == 9){
        succesRate = 0.8;
        }else if (speed == 10){
        succesRate =  0.77;
        }
    return succesRate;
    }
    
    public static double ProductionRatePerHour(int speed) => 221 * speed * SuccessRate(speed);
    

    public static int WorkingItemsPerMinute(int speed) => (int) ProductionRatePerHour(speed) / 60;
}
