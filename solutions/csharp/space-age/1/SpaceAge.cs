using System;

public class SpaceAge
{
    private int seconds;
    public SpaceAge(int seconds)
    {
        this.seconds=seconds;
    }

    public double OnEarth() => (double)seconds / 31557600;
    public double OnMercury() => (double)seconds / (31557600*0.2408467);
    public double OnVenus() =>  (double)seconds / (31557600* 0.61519726);
    public double OnMars() => (double)seconds / (31557600* 1.8808158 );
    public double OnJupiter() => (double)seconds / (31557600* 11.862615 );
    public double OnSaturn() =>  (double)seconds / (31557600* 29.447498  );
    public double OnUranus() =>  (double)seconds / (31557600*  84.016846 );
    public double OnNeptune() =>  (double)seconds / (31557600*164.79132);

}