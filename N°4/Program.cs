using System;

namespace Percentual
{
    class Program
    {
        static void Main(string[] args)
        {
            double SP = 67836.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double Outros = 19849.53;
            double total;
            double porcent;

            total = SP + RJ + MG + ES + Outros;
            porcent = total / 100;

            SP = SP / porcent;
            RJ = RJ / porcent;
            MG = MG / porcent;
            ES = ES / porcent;
            Outros = Outros / porcent;

            Console.WriteLine("O percentual de representação que cada estado teve foi:\nSP: "+ Math.Round(SP, 2) +"%\nRJ: " + Math.Round(RJ, 2) + "%\nMG: " + Math.Round(MG, 2) + "%\nES: " + Math.Round(ES, 2) + "%\nOutros: " + Math.Round(Outros, 2) + "%");
            


        }
    }
}