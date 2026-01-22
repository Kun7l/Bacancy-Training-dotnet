using System;

namespace Day_5;
public class Car
{
    int speed = 0;
    public delegate void  OverSpeedHandler(int speed);
    public event OverSpeedHandler? Overspeed;

    public void Accelerate(int val)
    {
        speed += val;

        if (speed > 50)
        {
            Overspeed?.Invoke(speed);
        }
        else
        {
            Console.WriteLine("Now speed is " + speed);
        }
    }
}

public class Driver
{
    public static void Main(String[] agrs)
    {
        Car car = new Car();
        car.Overspeed += Warning;
        car.Accelerate(20);
        car.Accelerate(40);
        static void Warning(int speed)
        {
            Console.WriteLine("Dont OverSpeed, Current Speed is : "+speed);
            
        }
    }
}
























//2025 LN4
//2024 MV1
//2023 MV1
//2022 MV1
//2021 MV33
//2020 LH44
//2019 LH44
//2018 LH44
//2017 LH44
//2016 NR6
//2015 LH44
//2014 LH44
//2013 SV5
//2012 SV5
//2011 SV5
//2010 SV5
//2009 JB22
//2008 LH44
//2007 KR7
//2006 FA14
//2005 FA14
//2004 MS1
//2003 MS1
//2002 MS1
//2001 MS1
//2000 MS1
//1999 MH
//1998 MH
//1997 JV
//1996 DH
//1995 MS
//1994 MS
//1993 AP
//1992 NM
//1991 AS