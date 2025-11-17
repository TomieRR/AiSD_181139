using System;

public class Generowanie
{
    public static int LosujLiczbe()
    {
        Random rnd = new Random((int)DateTime.Now.Ticks);
        return rnd.Next(1,50);
    }
}
