using System;
using System.IO;
namespace ProjektArbete_gr17
{
	public class ConvertTemp
	{

        public double Celsius;
        public double Kelvin;
        public double Fahrenheit;

        public void cel()
        {
            bool convertToCel;
            do
            {
                Console.Write("celsius:  ");
                try
                {
                    Celsius = Convert.ToDouble(Console.ReadLine());
                    double tempKelvin = Celsius + 273;
                    double tempKelvinF = Celsius * 18 / 10 + 32;

                    Alloutput.saveTofile($"Kelvin = {tempKelvin}");
                    Alloutput.saveTofile($"Fahrenheit = {tempKelvinF}");
                    convertToCel = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    convertToCel = true;
                }
            } while (convertToCel == true);
        }
        public void kel()
        {
            bool convertTokel;
            do
            {
                Console.Write("kelvin:  ");
                try
                {
                    Kelvin = Convert.ToDouble(Console.ReadLine());
                    double tempcel = Kelvin - 273;
                    double tempcelf = Kelvin - 273.15 * 9 / 5 + 32;

                    Alloutput.saveTofile($"celsius = {tempcel}");
                    Console.WriteLine($"fahrenheit = {tempcelf}");
                    convertTokel = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    convertTokel = true;
                }
            } while (convertTokel == true);
        }
        public void fahren()
        {
            bool convertTfh;

            do
            {
                Console.Write("fahrenheit:  ");
                try
                {
                    Fahrenheit = Convert.ToDouble(Console.ReadLine());
                    double tempfhcel = Fahrenheit - 32 * 5 / 9;
                    double tempklfh = Fahrenheit - 32 * 5 / 9 + 273.15;


                    Alloutput.saveTofile($"celsius = {tempfhcel}");
                    Alloutput.saveTofile($"kelvin = {tempklfh}");
                    convertTfh = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    convertTfh = true;
                }
            } while (convertTfh == true);
        }


    }


   
   
}


   


