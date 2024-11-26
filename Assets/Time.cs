using System;

public class Time
{ 
    //ms ¥‹¿ß
    public static long GetTime()
    {
        return DateTime.Now.Ticks / 10000;
    }

}
