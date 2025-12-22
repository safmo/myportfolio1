using System;
namespace ProjektArbete_gr17
{
	public class Alloutput
	{
		
		public static void saveTofile(string line)
		{
			
			string[] resultat = {line};
            File.AppendAllLines("textFile ", resultat);
			Console.WriteLine(line);
        }
	}
}

