using System;

namespace TechProject3
{
	class Program
	{
		static void Main(string[] args)
		{
			//Constant Values
			const double CONVERSION_FACTOR = 0.6214;
			
			int kph = 0;
			double mph;     // Miles per hour
			//Ask the user to input the values to execute the iterative statement
			Console.WriteLine("Enter an integer value between 10 and 25");

			try
			{
				//gather data for user input
				String input = Console.ReadLine();
				//perform various iterative statments and parse as an integer
				int increment = int.Parse(input);
				// if values are between 10 and 25 execute a for loop 
				if ((increment >= 10) && (increment <= 25))
				{
					Console.WriteLine("Executing while Loop.");
					Console.WriteLine("Kilometers      Equiv Miles");
					// this is the while loop 
					while (kph <= 200)
					{
						// Calculate miles per hour.
						mph = kph * CONVERSION_FACTOR;
						Console.WriteLine("  {0}              {1}  ", kph.ToString().PadLeft(3), Math.Round(mph, 1).ToString().PadLeft(5));
						kph = kph + increment;
					} // End of try
				}
			}
			catch
			{
				Console.WriteLine("Please enter an integer value between 10 and 25 and try running the program again ...");
				Console.WriteLine("Press any key to exit the program ...");
				Console.ReadKey(true);
			} // End of catch
		} // End of Main
	} // End of class
} // End of namespace



