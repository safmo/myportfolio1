using System;
namespace ProjektArbete_gr17
{
    public class ConvertWeight
    {
        public double Pound;
        public double Kg;

       

        public void Ibs()
        {
            bool Omvandla;
            do
            {
                Console.Write("pound:  ");
                try
                {
                    Pound = Convert.ToDouble(Console.ReadLine());
                    double converttop = Pound / 2.205;
                    Alloutput.saveTofile($"Kg = {converttop}");


                    

                    Omvandla = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Omvandla = true;
                }
            } while (Omvandla == true);
        }
        public void kg()
        {
            bool Omvandla;
            do
            {
                Console.Write("kg:  ");
                try
                {
                    Kg = Convert.ToDouble(Console.ReadLine());
                    double converttok = Kg * 2.205;
                    Alloutput.saveTofile($"pound = {converttok}");

                   
                   

                    Omvandla = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Omvandla = true;
                }
            } while (Omvandla == true);
        }




    }

}


	


