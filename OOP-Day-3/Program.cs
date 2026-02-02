using System;

public class Program
{
    public static int display()
    {
        try
        {
            return 1;
        }
        finally
        {
            //return 2;
        }
    }
    public static void Main()
    {
        Console.WriteLine(display());
    }
}