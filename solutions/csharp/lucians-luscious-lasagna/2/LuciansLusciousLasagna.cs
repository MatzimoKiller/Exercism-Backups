class Lasagna
{
    public int ExpectedMinutesInOven() => 40;    
    
    
    public int RemainingMinutesInOven(int actualMinutes){
        return this.ExpectedMinutesInOven() - actualMinutes;
    }

    public int PreparationTimeInMinutes(int layers){
        return layers * 2;  
    }

    public int ElapsedTimeInMinutes(int layers, int minutes){
        int preptime = this.PreparationTimeInMinutes(layers);
        return preptime + minutes;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
}
