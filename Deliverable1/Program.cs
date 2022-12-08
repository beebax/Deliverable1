using System;

public class Program
{
    public static void Main()
    {
        string WannaRestart;
        do
        {

            Console.WriteLine("How many people are we making PB&J sandwiches for?");
            decimal numberEaters = decimal.Parse(Console.ReadLine());

            decimal BreadSlices = numberEaters * 2;
            decimal TblPB = numberEaters * 2;
            decimal TspJelly = numberEaters * 4;

            Console.WriteLine();
            Console.WriteLine("Okay, we'll need...");
            Console.WriteLine(BreadSlices + " slices of bread,");
            Console.WriteLine(TblPB + " tablespoons of peanut butter, and");
            Console.WriteLine(TspJelly + " teaspoons of jelly.");

            decimal Loaves = Math.Ceiling(BreadSlices / 28);
            decimal jarsPB = Math.Ceiling(TblPB / 32);
            decimal jarsJelly = Math.Ceiling(TspJelly / 48);

            Console.WriteLine();
            Console.WriteLine("Which is...");
            Console.WriteLine(Loaves + " loaves of bread,");
            Console.WriteLine(jarsPB + " jars of peanut butter, and");
            Console.WriteLine(jarsJelly + " jars of jelly.");

            Console.WriteLine();
            Console.WriteLine("Would you like to restart? Enter yes or y to continue, or any other key to exit.");
            WannaRestart = Console.ReadLine();

        } while (WannaRestart == "yes" || WannaRestart == "y");

        Console.WriteLine("Goodbye.");
    }
}