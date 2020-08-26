using System;

namespace CSharp01
{
    class Program
    {
        static void Main(string[] args)
        {
            float tasa = 0;
            int hrs = 0;
            int hrsRegulares = 0;
            int hrsExtras = 0;
            float gRegulares = 0;
            float gExtras = 0;
            float gTotales = 0;

            Console.WriteLine("Hours:");
            hrs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tasa:");
            tasa = Convert.ToSingle(Console.ReadLine());

            if(hrs>40){
                hrsExtras = hrs - 40;                                
            }

            hrsRegulares = hrs - hrsExtras;
            gRegulares = hrsRegulares * tasa;
            gExtras = hrsExtras * 1.5f * tasa;
            gTotales = gRegulares + gExtras;

            Console.WriteLine($"Number of Hours Regulars: {hrsRegulares}");
            Console.WriteLine($"Number of Hours Extras: {hrsExtras}");

            Console.WriteLine($"Profits Brutas Regulars: {gRegulares}");
            Console.WriteLine($"Profits Brutas Extras: {gExtras}");
            Console.WriteLine($"Profits Totales: {gTotales}");

            Console.ReadLine();
        }
    }
}
