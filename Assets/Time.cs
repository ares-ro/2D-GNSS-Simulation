using System;

public class Time
{ 
    //ms ����
    public static long GetTime()
    {
        return DateTime.Now.Ticks / 10000;
    }

}
