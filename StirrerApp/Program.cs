using System;

namespace StirrerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stirrer Demo");

            var ikaStirrer = new IkaStirrer("Ika stirrer");
            var heidolphStirrer = new HeidolphStirrer("Heidolph Stirrer");

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