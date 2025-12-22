using System;
using System.IO;
namespace ProjektArbete_gr17
{
    public class ConvertLength
    {


        public double Feet;
        public double CentiMeter;
        public double kiloMeter;
        public double mile;


        public void cm()
        {
            bool convertToCm;
            do
            {
                Console.Write("cm:  ");
                try
                {
                    CentiMeter = Convert.ToDouble(Console.ReadLine());
                    double convertCm = CentiMeter / 30.48;

                    Alloutput.saveTofile($"Feet = {convertCm}");
                    



                    convertToCm = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    convertToCm = true;
                }
            } while (convertToCm == true);


          
        }



        public void ft()
        {
            bool convertToft;
            do
            {
                Console.Write("feet:  ");
                try
                {
                    Feet = Convert.ToDouble(Console.ReadLine());
                    double converttof = Feet * 30.48;
                    Alloutput.saveTofile($"cm = {converttof}");

                    convertToft = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    convertToft = true;
                }
            } while (convertToft == true);
        }


        public void kl()
        {
            bool convertToKl;

            do
            {
                Console.Write("Kilometer: ");

                try
                {
                    kiloMeter = Convert.ToDouble(Console.ReadLine());
                    double convertTok = kiloMeter /10 ;
                    Alloutput.saveTofile($"Mil = {convertTok}");

                   
                    convertToKl = false;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    convertToKl = true;
                }
            } while (convertToKl == true);
        }


        public void ml()
        {
            bool convertToml;

            do
            {
                Console.Write("Mil: ");

                try
                {
                    mile = Convert.ToDouble(Console.ReadLine());

                    double convertTom = mile * 10;
                    Alloutput.saveTofile($"Kl = {convertTom}");

                    
                    convertToml = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    convertToml = true;
                }
            } while (convertToml == true);
        }

        
    }
}


