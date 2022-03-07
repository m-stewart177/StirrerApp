using System;

namespace StirrerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stirrer Demo");

            // Ranges could be read from a configuration file.
            var ikaStirrer = new IkaStirrer("Ika stirrer", new RangeConstraint(300, 1500));
            var heidolphStirrer = new HeidolphStirrer("Heidolph Stirrer", new RangeConstraint(200, 2000));

            ikaStirrer.Rpm = 750;
            heidolphStirrer.Rpm = 1500;

            try
            {
                ikaStirrer.Rpm = 150;

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}