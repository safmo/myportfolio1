using System;
using System.IO;

namespace ProjektArbete_gr17;

class Program
{
    static void Main(string[] args)
    {



        int alternativ;
        do
        {
            //huvudmeny

            Console.Clear();
            Console.WriteLine("\nHej! välkommen till grupp 17 program\n");
            Console.WriteLine("\nVälj ett alternativ!");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1: Omvandla mellan Fahrenheit/Celsius/Kelvin.");
            Console.WriteLine("2: Omvandla längd.");
            Console.WriteLine("3: Omvandla vikt");
            Console.WriteLine("4: Avsluta program!");

            Console.Write("\nVälj ett alternativ:\n ");
            alternativ = Convert.ToInt32(Console.ReadLine());





            switch (alternativ)
            {
                case 1:
                    omvandlaTemp();
                    break;

                case 2:
                    omvandlalängd();
                    break;



                case 3:
                    omvandvikt();
                    break;



                case 4:
                    break;

                default:

                    Console.WriteLine($"please enter {1} {2} {3} {4}");
                    alternativ = Convert.ToInt32(Console.ReadLine());
                    return;




            }


        }


        while (alternativ != 4);
        Console.Clear();
    }



    static void omvandlaTemp()
    {
        ConvertTemp tempconvert = new ConvertTemp();
        bool tempMeny = false;
        Console.Clear();
        Console.WriteLine("\nVad vill du konvertera?\n");
        Console.WriteLine("\n------------------------\n");
        Console.WriteLine("c: celsius\n");
        Console.WriteLine("k: kelvin\n");
        Console.WriteLine("f: fahrenheit\n");
        Console.Write("\nEnter c, k or f:\n ");


        do
        {
            string inputOption = (Console.ReadLine()).ToLower();
            if (inputOption == "c" || inputOption == "k" || inputOption == "f")
            {
                tempMeny = true;
                switch (inputOption)
                {
                    case "c":
                        tempconvert.cel();
                        break;
                    case "k":
                        tempconvert.kel();
                        break;
                    case "f":
                        tempconvert.fahren();
                        break;

                }
            }
            else
            {
                Console.WriteLine("Invalid answer. Please enter c, k or f.");
            }

        } while (tempMeny == false);



        Console.WriteLine("\nPress any key to go back to the main menu");
        Console.ReadKey();

    }





    static void omvandlalängd()
    {
        ConvertLength lengthconvert = new ConvertLength();

        bool unitMeny = false;
        Console.Clear();
        Console.WriteLine("\nVad vill du konvertera?\n");
        Console.WriteLine("----------------------------\n");
        Console.WriteLine("c: centimeter\n");
        Console.WriteLine("f: fott\n");
        Console.WriteLine("k: Kilometer\n");
        Console.WriteLine("m: mil\n");

        Console.Write("\nEnter c,f,k or m:\n ");


        do
        {
            string inputOption = (Console.ReadLine()).ToLower();

            if (inputOption == "c" || inputOption == "f" || inputOption == "k" || inputOption == "m")
            {
                unitMeny = true;

                switch (inputOption)
                {
                    case "c":
                        lengthconvert.cm();
                        break;
                    case "f":
                        lengthconvert.ft();
                        break;
                    case "k":
                        lengthconvert.kl();
                        break;
                    case "m":
                        lengthconvert.ml();
                        break;


                }



            }


            else
            {
                Console.WriteLine("Invalid answer. Please enter c,f,k or m .");
            }

        } while (unitMeny == false);




        Console.WriteLine("\nPress any key to go back to the main menu\n");
        Console.ReadKey();
    }








    static void omvandvikt()
    {
        ConvertWeight weight = new ConvertWeight();
        bool weightMney = false;

        Console.Clear();
        Console.WriteLine("Vad vill du konvertera?");
        Console.WriteLine("\n----------------------\n");
        Console.WriteLine("p: Pound");
        Console.WriteLine("k: kg");

        Console.Write("\nEnter p, or k\n");
        do
        {
            string inputOption = (Console.ReadLine()).ToLower();
            if (inputOption == "p" || inputOption == "k")
            {
                weightMney = true;
                switch (inputOption)
                {
                    case "p":
                        weight.Ibs();
                        break;
                    case "k":
                        weight.kg();
                        break;


                }
            }
            else
            {
                Console.WriteLine("Invalid answer. Please enter p, or k.");
            }

        } while (weightMney == false);

        Console.WriteLine("\nPress any key to go back to the main menu\n");
        Console.ReadKey();
    }






}